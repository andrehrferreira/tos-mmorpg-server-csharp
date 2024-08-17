using Sprache;
using Newtonsoft.Json;
using DotNetEnv;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace Server
{
    public static partial class Repository
    {
        public static async Task CharactersLoadAll()
        {
            Logger.Log("Loading Players...");

            var allCharacters = await GetAllCharacters();

            foreach (var character in allCharacters)            
                Player.FromDatabase(character);
            
            Logger.Log($"{allCharacters.Count()} Players Loaded.");
        }

        public static async Task<int> GetCharacterCount(string accountId)
        {
            return await Context.Characters.CountAsync(c => c.AccountId == accountId);
        }

        public static async Task<List<CharacterEntity>> GetAllCharacters()
        {
            try
            {
                return await Context.Characters.ToListAsync();
            }
            catch (SqliteException ex)
            {
                Logger.Error("SQLite error: " + ex.Message);
                throw;
            }
            catch (Exception ex)
            {
                Logger.Error("General error: " + ex.Message);
                throw new Exception("Characters not found.", ex);
            }
        }

        public static async Task<string> GetAllCharacters(string masterId)
        {
            try
            {
                var characters = await GetCharacters(masterId);
                var characterList = new List<object>();

                foreach (var character in characters)
                {
                    var chestArmor = character.ChestArmor != null ? JsonConvert.DeserializeObject(character.ChestArmor) : null;
                    var helmetArmor = character.HelmetArmor != null ? JsonConvert.DeserializeObject(character.HelmetArmor) : null;
                    var bootsArmor = character.BootsArmor != null ? JsonConvert.DeserializeObject(character.BootsArmor) : null;
                    var glovesArmor = character.GlovesArmor != null ? JsonConvert.DeserializeObject(character.GlovesArmor) : null;
                    var pantsArmor = character.PantsArmor != null ? JsonConvert.DeserializeObject(character.PantsArmor) : null;
                    var robe = character.Robe != null ? JsonConvert.DeserializeObject(character.Robe) : null;
                    var cloak = character.Cloak != null ? JsonConvert.DeserializeObject(character.Cloak) : null;
                    var offhand = character.Offhand != null ? JsonConvert.DeserializeObject(character.Offhand) : null;
                    var mainhand = character.Mainhand != null ? JsonConvert.DeserializeObject(character.Mainhand) : null;
                    var instrument = character.Instrument != null ? JsonConvert.DeserializeObject(character.Instrument) : null;
                    var pet = character.Pet != null ? JsonConvert.DeserializeObject(character.Pet) : null;
                    var mount = character.Mount != null ? JsonConvert.DeserializeObject(character.Mount) : null;

                    characterList.Add(new
                    {
                        character.Id,
                        character.Name,
                        character.Hashtag,
                        character.Visual,
                        ChestArmor = chestArmor,
                        HelmetArmor = helmetArmor,
                        BootsArmor = bootsArmor,
                        GlovesArmor = glovesArmor,
                        PantsArmor = pantsArmor,
                        Robe = robe,
                        Cloak = cloak,
                        Offhand = offhand,
                        Mainhand = mainhand,
                    });
                }

                return JsonConvert.SerializeObject(new { characters = characterList }, new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                });
            }
            catch
            {
                return "{\"characters\":[]}";
            }
        }


        public static async Task<List<CharacterEntity>> GetCharacters(string accountId)
        {
            try
            {
                return await Context.Characters
                                    .Where(c => c.AccountId == accountId)
                                    .Select(c => new CharacterEntity
                                    {
                                        Id = c.Id,
                                        Name = c.Name,
                                        Hashtag = c.Hashtag,
                                        Visual = c.Visual,
                                        ChestArmor = c.ChestArmor,
                                        HelmetArmor = c.HelmetArmor,
                                        BootsArmor = c.BootsArmor,
                                        GlovesArmor = c.GlovesArmor,
                                        PantsArmor = c.PantsArmor,
                                        Robe = c.Robe,
                                        Cloak = c.Cloak,
                                        Offhand = c.Offhand,
                                        Mainhand = c.Mainhand
                                    })
                                    .Take(10)
                                    .ToListAsync();
            }
            catch
            {
                throw new Exception("Characters not found.");
            }
        }

        public static async Task<CharacterEntity> GetCharacter(string accountId, string characterId, string fields = "*")
        {
            try
            {
                IQueryable<CharacterEntity> query = Context
                    .Characters.Where(c => c.AccountId == accountId && c.Id == characterId);

                var character = await query.FirstOrDefaultAsync();

                if (character != null)
                {
                    character.Skills = !string.IsNullOrEmpty(character.Skills) ? character.Skills : "{}";
                    character.Inventory = !string.IsNullOrEmpty(character.Inventory) ? character.Inventory : "{}";
                    character.Proficiencies = !string.IsNullOrEmpty(character.Proficiencies) ? character.Proficiencies : "{}";
                }

                return character;
            }
            catch
            {
                throw new Exception("Character not found.");
            }
        }

        public static async Task<bool> CreateCharacter(CharacterEntity data)
        {
            try
            {
                data.Skills = data.Skills ?? "{}";
                Context.Characters.Add(data);
                await Context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static async Task<bool> UpdateCharacter(string id, CharacterEntity data)
        {
            try
            {
                var character = await Context.Characters.FindAsync(id);

                if (character == null)
                    throw new Exception("Character not found.");

                Context.Entry(character).CurrentValues.SetValues(data);
                await Context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static async Task<bool> DeleteCharacter(string id)
        {
            try
            {
                var character = await Context.Characters.FindAsync(id);
                if (character != null)
                {
                    Context.Characters.Remove(character);
                    await Context.SaveChangesAsync();
                    return true;
                }
            }
            catch
            {
                return false;
            }

            return false;
        }

        public static async Task<bool> CreateCharacter(ICharacterCreatePayload characterPayload, Socket socket)
        {
            try
            {
                int limitCharsPerAccount = Env.GetInt("TOR_CHARS_PER_ACCOUNT");

                if (socket.AccountId != "" && socket.AccountId != null)
                    throw new UnauthorizedAccessException("Invalid token.");

                string masterId = socket.AccountId;

                int characterCount = await GetCharacterCount(masterId);

                ICharacterPayloadInfo payload = JsonConvert.DeserializeObject<ICharacterPayloadInfo>(characterPayload.Payload);

                if (characterCount > limitCharsPerAccount)
                    throw new Exception($"The limit of characters per account is {limitCharsPerAccount}");

                if (characterPayload.Name.Length < 3 || characterPayload.Name.Length > 14)
                    throw new Exception("The character name is outside the standard accepted by the server");

                var character = new CharacterEntity
                {
                    Id = Guid.NewGuid().ToString(),
                    AccountId = masterId,
                    Name = characterPayload.Name,
                    Hashtag = $"{characterPayload.Name.Replace(" ", "").Substring(0, 10).ToUpper()}#{CreateHash()}"
                };

                character.Str = payload.Stats.Str;
                character.Dex = payload.Stats.Dex;
                character.Int = payload.Stats.Int;
                character.Agi = payload.Stats.Agi;
                character.Vig = payload.Stats.Vig;
                character.Luc = payload.Stats.Luc;

                //Visual
                var visual = new Dictionary<string, object>();

                var payloadType = payload.GetType();
                foreach (var prop in payloadType.GetProperties())
                {
                    if (prop.Name != "Stats" && prop.Name != "Skills")                    
                        visual[prop.Name] = prop.GetValue(payload);                    
                }

                character.Visual = JsonConvert.SerializeObject(visual);

                character.Skills = JsonConvert.SerializeObject(payload.Skills);
                character.Map = GameServerSettings.InitialMap;
                character.X = GameServerSettings.InitialPosX;
                character.Y = GameServerSettings.InitialPosY;
                character.Z = GameServerSettings.InitialPosZ;
                character.R = 0;

                character.ChestArmor = JsonConvert.SerializeObject( new { ItemName = "SK_ma_medieval_chest_villager_01_b" } );
                character.PantsArmor = JsonConvert.SerializeObject( new { ItemName = "SK_ma_medieval_armour_pants_02" });
                character.BootsArmor = JsonConvert.SerializeObject( new { ItemName = "SK_ma_medieval_shoe_02_a" });

                var inventory = new List<dynamic>
                {
                    new { ItemName = "GoldCoin", Amount = 500 },
                    new { ItemName = "SmallLifePotion", Amount = 10 }
                };

                var inventoryDic = new Dictionary<string, dynamic>();

                foreach (var item in inventory)
                    inventoryDic.Add(Guid.NewGuid().ToString(), item);

                string inventoryId = Guid.NewGuid().ToString();
                var referredInventory = await CreateInventoryItems(character.Id, inventoryId, inventoryDic);

                character.Inventory = JsonConvert.SerializeObject(referredInventory);
                character.InventoryId = inventoryId;
                character = await CreateEquipmentsRefs(character, character.Id, inventoryId);

                character.ChestArmor = JsonConvert.SerializeObject(character.ChestArmor);
                character.PantsArmor = JsonConvert.SerializeObject(character.PantsArmor);
                character.BootsArmor = JsonConvert.SerializeObject(character.BootsArmor);

                bool result = await CreateCharacter(character);

                Player.PlayerData[character.Id] = character;

                await UpsertContainer(new ContainerEntity {
                    CharacterId = character.Id,
                    ContainerId = inventoryId,
                    Items = character.Inventory
                });

                Containers.FromDatabase(new ContainerEntity
                {
                    ContainerId = inventoryId,
                    Items = character.Inventory
                });

                if (!result)
                {
                    Logger.Error("Error when trying to create character");
                    throw new Exception("Error when trying to create character");
                }

                return true;
            }
            catch (Exception e)
            {
                Logger.Error(e.Message);
                return false;
            }
        }

        public static int TotalStatsPoints(ICharacterPayloadInfo characterPayload)
        {
            return characterPayload.Stats.Str +
                   characterPayload.Stats.Dex +
                   characterPayload.Stats.Int +
                   characterPayload.Stats.Luc +
                   characterPayload.Stats.Agi +
                   characterPayload.Stats.Vig;
        }

        public static int TotalSkillPoints(ICharacterPayloadInfo characterPayload)
        {
            int total = 0;

            foreach (var skill in characterPayload.Skills.Values)            
                total += skill.Value;            

            return total;
        }

        public static async Task<Dictionary<string, dynamic>> CreateInventoryItems(string characterId, string inventoryId, Dictionary<string, dynamic> inventory)
        {
            foreach (var key in inventory.Keys.ToList())
            {
                try
                {
                    var itemName = inventory[key].ItemName;
                    var amount = inventory[key].Amount > 0 ? inventory[key].Amount : 1;
                    var itemRef = await Repository.CreateItem(inventoryId, characterId, itemName, amount, "createchar");
                    inventory[key].ItemRef = itemRef;
                }
                catch (Exception e)
                {
                    throw new Exception($"Internal Server Error: {e.Message}");
                }
            }

            return inventory;
        }

        public static async Task<CharacterEntity> CreateEquipmentsRefs(CharacterEntity character, string characterId, string inventoryId)
        {
            // Chest Armor
            if (!string.IsNullOrEmpty(character.ChestArmor))
            {
                var chestItem = JsonConvert.DeserializeObject<dynamic>(character.ChestArmor);
                var chestId = await Repository.CreateItem(inventoryId, characterId, chestItem.ItemName.ToString(), 1, "createchar");
                chestItem.ItemRef = chestId;
                character.ChestArmor = JsonConvert.SerializeObject(chestItem);
                Items.ItemFromDatabase(new ItemEntity{ Id = chestId, ItemName = chestItem.ItemName.ToString() });
            }

            // Pants Armor
            if (!string.IsNullOrEmpty(character.PantsArmor))
            {
                var pantsItem = JsonConvert.DeserializeObject<dynamic>(character.PantsArmor);
                var pantsId = await Repository.CreateItem(inventoryId, characterId, pantsItem.ItemName.ToString(), 1, "createchar");
                pantsItem.ItemRef = pantsId;
                character.PantsArmor = JsonConvert.SerializeObject(pantsItem);
                Items.ItemFromDatabase(new ItemEntity{ Id = pantsId, ItemName = pantsItem.ItemName.ToString() });
            }

            // Boots Armor
            if (!string.IsNullOrEmpty(character.BootsArmor))
            {
                var bootsItem = JsonConvert.DeserializeObject<dynamic>(character.BootsArmor);
                var bootsId = await Repository.CreateItem(inventoryId, characterId, bootsItem.ItemName.ToString(), 1, "createchar");
                bootsItem.ItemRef = bootsId;
                character.BootsArmor = JsonConvert.SerializeObject(bootsItem);
                Items.ItemFromDatabase(new ItemEntity{ Id = bootsId, ItemName = bootsItem.ItemName.ToString() });
            }

            return character;
        }

        public static async Task<string> GetAllCharacters(Socket socket)
        {
            try
            {
                var characters = await GetCharacters(socket.AccountId);

                foreach (var character in characters)
                {
                    character.ChestArmor = !string.IsNullOrEmpty(character.ChestArmor)
                        ? GetRarity(JsonConvert.DeserializeObject<dynamic>(character.ChestArmor)) : null;
                    character.HelmetArmor = !string.IsNullOrEmpty(character.HelmetArmor)
                        ? GetRarity(JsonConvert.DeserializeObject<dynamic>(character.HelmetArmor)) : null;
                    character.BootsArmor = !string.IsNullOrEmpty(character.BootsArmor)
                        ? GetRarity(JsonConvert.DeserializeObject<dynamic>(character.BootsArmor)) : null;
                    character.GlovesArmor = !string.IsNullOrEmpty(character.GlovesArmor)
                        ? GetRarity(JsonConvert.DeserializeObject<dynamic>(character.GlovesArmor)) : null;
                    character.PantsArmor = !string.IsNullOrEmpty(character.PantsArmor)
                        ? GetRarity(JsonConvert.DeserializeObject<dynamic>(character.PantsArmor)) : null;
                    character.Robe = !string.IsNullOrEmpty(character.Robe)
                        ? GetRarity(JsonConvert.DeserializeObject<dynamic>(character.Robe)) : null;
                    character.Cloak = !string.IsNullOrEmpty(character.Cloak)
                        ? GetRarity(JsonConvert.DeserializeObject<dynamic>(character.Cloak)) : null;
                    character.Offhand = !string.IsNullOrEmpty(character.Offhand)
                        ? GetRarity(JsonConvert.DeserializeObject<dynamic>(character.Offhand)) : null;
                    character.Mainhand = !string.IsNullOrEmpty(character.Mainhand)
                        ? GetRarity(JsonConvert.DeserializeObject<dynamic>(character.Mainhand)) : null;
                    character.Instrument = !string.IsNullOrEmpty(character.Instrument)
                        ? GetRarity(JsonConvert.DeserializeObject<dynamic>(character.Instrument)) : null;
                    character.Pet = !string.IsNullOrEmpty(character.Pet)
                        ? GetRarity(JsonConvert.DeserializeObject<dynamic>(character.Pet)) : null;
                    character.Mount = !string.IsNullOrEmpty(character.Mount)
                        ? GetRarity(JsonConvert.DeserializeObject<dynamic>(character.Mount)) : null;
                }

                if (characters != null && characters.Any())
                    return JsonConvert.SerializeObject(new { characters });
                else
                    throw new Exception("No characters found on this account");
            }
            catch
            {
                return "{\"characters\":[]}";
            }
        }

        public static string GetFullCharacterInfo(Socket socket, string characterId)
        {
            try
            {
                var character = Player.GetData(socket.CharacterId);

                if (character == null)                
                    throw new Exception("The requested character does not exist or you cannot access it");
                
                return Player.ParseData(characterId);
            }
            catch (Exception e)
            {
                Logger.Error(e.Message);
                throw new Exception(e.Message);
            }
        }

        public static string GetRarity(string jsonData)
        {
            try
            {
                var data = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonData);
                var updatedData = GetRarity(data);
                return JsonConvert.SerializeObject(updatedData);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error processing item rarity: {ex.Message}");
                return null; 
            }
        }

        public static Dictionary<string, object> GetRarity(Dictionary<string, object> data)
        {
            if (data != null && data.ContainsKey("ItemRef"))
            {
                var itemRef = data["ItemRef"].ToString();
                var item = Items.GetItemByRef(itemRef);

                if (item != null)
                    data["Rarity"] = item.Rarity;
                else
                    data["Rarity"] = ItemRarity.Common;
            }

            return data;
        }

    }
}
