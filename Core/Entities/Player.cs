using Newtonsoft.Json;
using Server.Packets;

namespace Server
{
    public class ActionbarRef
    {
        public BaseAction Action { get; set; }
        public Item Item { get; set; }
        public int SlotId { get; set; }

        public ActionbarRef(BaseAction action, Item item, int slotId)
        {
            Action = action;
            Item = item;
            SlotId = slotId;
        }
    }

    public partial class Player: Humanoid
    {
        public static Dictionary<string, Player> Players = new Dictionary<string, Player>();
        public static HashSet<string> OnlinePlayers = new HashSet<string>();
        public static Dictionary<string, CharacterEntity> PlayerData = new Dictionary<string, CharacterEntity>();

        public CharacterEntity CharacterModel;

        public override int UpdateIntensity { get; set; } = 1;
        public string AccountId { get; set; }
        public bool Loaded { get; set; } = false;
        public string Hashtag { get; set; }
        public SafeTrade Trade { get; set; }
        public Dictionary<int, ActionbarRef> Actionbar { get; set; } = new Dictionary<int, ActionbarRef>();
        public List<string> TooltipSended { get; set; } = new List<string>();
        public Dictionary<string, object> VendorList { get; set; } = new Dictionary<string, object>();
        public List<string> Friends { get; set; } = new List<string>();
        public List<string> FriendsRequests { get; set; } = new List<string>();

        // Gathering
        public GatherableResource GatherableInteract { get; set; } = null;
        public Gatherable GatherableSpot { get; set; } = null;

        // Quest
        public List<Quest> Quests { get; set; } = new List<Quest>();
        public int DailyQuestsIndex { get; set; } = 1;
        public DailyQuests DailyQuest { get; set; }

        // Guild
        public int CreateGuildCost { get; set; } = 20000;

        // Taming
        public bool InTamingProgress { get; set; } = false;

        // Event
        public bool InEvent { get; set; } = false;
        public MapEventType EventMapType { get; set; }
        public string EventMapId { get; set; }
        public string EventMap { get; set; }
        public Vector3 EventPosition { get; set; }

        public Player(Socket socket, CharacterEntity characterModel, string accId)
        {
            CharacterModel = characterModel;
            AccountId = accId;
            SocketId = socket.Id;
            Socket = socket;
            socket.Player = this;

            SyncCharacterModel();

            Task.Run(async () =>
            {
                while (true)
                {
                    await Task.Delay(1000);
                    SyncPlayerStats();
                }
            });

            Task.Run(async () =>
            {
                while (true)
                {
                    await Task.Delay(300000);
                    await SaveToDatabase();
                }
            });
        }

        public static Player GetPlayerByTag(string hashtag)
        {
            foreach (var player in Players.Values)
            {
                if (player.Hashtag.Equals(hashtag, StringComparison.OrdinalIgnoreCase))                
                    return player;                
            }

            return null;
        }

        public static Player GetPlayer(string characterId)
        {
            foreach (var player in Players.Values)
            {
                if (player.CharacterId.Equals(characterId, StringComparison.OrdinalIgnoreCase))                
                    return player;                
            }

            return null;
        }

        public static void RefreshOnlinePlayer()
        {
            var playersOnline = new HashSet<string>();

            foreach (var player in Players.Values)
            {
                if (player.LastUpdate > DateTimeOffset.UtcNow.ToUnixTimeMilliseconds())                
                    playersOnline.Add(player.CharacterId);                
            }

            OnlinePlayers = playersOnline;
        }

        public static void FromDatabase(CharacterEntity data)
        {
            try
            {
                /*var steamArchivements = data.steamArchivements as List<string>;

                if (steamArchivements != null)                
                    data.steamArchivements = steamArchivements.Distinct().ToList();*/
            }
            catch{}

            PlayerData[data.Id.ToString()] = data;
        }

        public static CharacterEntity GetData(string characterId)
        {
            if (PlayerData.ContainsKey(characterId))
            {
                var data = PlayerData[characterId];
                return data;
            }

            return null;
        }

        public static void Update(string characterId, Dictionary<string, object> data, Player entity)
        {
            if (PlayerData.ContainsKey(characterId))
            {
                var character = PlayerData[characterId];
                var entityType = character.GetType();

                foreach (var key in data.Keys)
                {
                    var property = entityType.GetProperty(key);

                    if (property != null && property.CanWrite)
                    {
                        try
                        {
                            var propertyType = property.PropertyType;

                            if (data[key] != null)
                            {
                                var convertedValue = Convert.ChangeType(data[key], propertyType);
                                property.SetValue(character, convertedValue);
                            }
                        }
                        catch{}
                    }
                }

                PlayerData[characterId] = character;
            }
        }


        public override void UpdatePosition(Vector3 location)
        {
            base.UpdatePosition(location);
            Save();
        }

        public override void SetMap(Maps map, string id)
        {
            base.SetMap(map, id);
            Save();
            SaveToDatabase().Wait();
        }

        public void RefreshLocalPlayerData()
        {
            var playerData = ParseData(CharacterId);
            var character = JsonConvert.DeserializeObject(playerData);
            Socket.Character = (CharacterEntity)character;
            Packet.Get(ServerPacketType.FullCharacter).Send(Socket, playerData);
        }

        public override void Tick(int tickNumber)
        {
            if (!Removed)
            {
                base.Tick(tickNumber);

                if (Party != null)                
                    Party.Tick(tickNumber);
                
                if (tickNumber % 100 == 0)
                {
                    Save();
                    SaveToDatabase().Wait();
                }
            }
            else if (Players.ContainsKey(CharacterId) && Removed)
            {
                Players.Remove(CharacterId);
            }
        }

        public override void Destroy()
        {
            OnlinePlayers.Add(CharacterId);
            AreaOfInterest.ForEach(entity => entity.RemoveFromAreaOfInterest(this));
            Save();
            SaveToDatabase().Wait(); 
            base.Destroy();
        }

        //DB / Network
        public override void PacketCreateEntity(Entity entity)
        {
            Packet.Get(ServerPacketType.CreateCharacter)?.Send(this, entity);
        }

        public void SyncCharacterModel()
        {
            /*Id = CharacterModel.Id;
            Name = CharacterModel.Name;
            Visual = CharacterModel.Visual;
            Hashtag = CharacterModel.Hashtag;
            CharacterId = CharacterModel.Id;
            States = new StateFlags(CharacterModel.States);
            Team = new Team(TeamKind.Players, this);
            Kind = EntitiesKind.Player;
            StatsPoints = CharacterModel.StatsPoints;
            StatsCap = CharacterModel.StatsCap;
            DailyQuestsIndex = CharacterModel.DailyQuestsIndex;
            Friends = CharacterModel.Friends;
            FriendsRequests = CharacterModel.FriendsRequests ?? new List<string>();
            SteamArchivements = CharacterModel.Archivements ?? new List<string>();

            // Quests
            var dailyMetadata = CharacterModel.DailyQuestsMetadata;
            if (dailyMetadata != null && dailyMetadata is string)
            {
                try
                {
                    dailyMetadata = JsonConvert.DeserializeObject<Dictionary<string, object>>(dailyMetadata.ToString());
                }
                catch {}
            }

            DailyQuest = DailyQuests.GetQuests(DailyQuestsIndex, dailyMetadata);

            // Guild
            if (CharacterModel.GuildId != null)
            {
                Guild = Guilds.GetGuild(CharacterModel.GuildId);
            }

            // Stats
            Str = CharacterModel.Str;
            Dex = CharacterModel.Dex;
            Int = CharacterModel.Int;
            Vig = CharacterModel.Vig;
            Agi = CharacterModel.Agi;
            Luc = CharacterModel.Luc;

            Life = CharacterModel.Life;
            Mana = CharacterModel.Mana;
            Stamina = CharacterModel.Stamina;

            // Equipments
            Helmet = CharacterModel.HelmetArmor;
            Chest = CharacterModel.ChestArmor;
            Gloves = CharacterModel.GlovesArmor;
            Boots = CharacterModel.BootsArmor;
            Pants = CharacterModel.PantsArmor;
            Robe = CharacterModel.Robe;
            Cloak = CharacterModel.Cloak;
            Ring01 = CharacterModel.Ring01;
            Ring02 = CharacterModel.Ring02;
            Necklance = CharacterModel.Necklance;
            Offhand = CharacterModel.Offhand;
            Mainhand = CharacterModel.Mainhand;
            Instrument = CharacterModel.Instrument;
            Pet = CharacterModel.Pet;
            Mount = CharacterModel.Mount;

            PickaxeTool = CharacterModel.PickaxeTool;
            AxeTool = CharacterModel.AxeTool;
            ScytheTool = CharacterModel.ScytheTool;

            // Position and Rotation
            Transform = new Transform(
                new Vector3(CharacterModel.X, CharacterModel.Y, CharacterModel.Z),
                new Rotator(0, 0, CharacterModel.R)
            );

            // Actionbar
            if (CharacterModel.Actionbar != null)
            {
                Actionbar.Clear();

                foreach (var key in CharacterModel.Actionbar.Keys)
                {
                    var slot = CharacterModel.Actionbar[key];
                    var action = slot.Action != null ? Actions.FindActionByName(slot.Action) : null;
                    var item = slot.Item != null ? Items.GetItemByRef(slot.Item) : null;
                    Actionbar[key] = new ActionbarRef(action, item, key);
                }
            }

            // Skills
            var skills = CharacterModel.Skills is string
                ? JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(CharacterModel.Skills)
                : CharacterModel.Skills;

            if (skills != null)
            {
                foreach (var key in skills.Keys)
                {
                    var skill = skills[key];
                    Skills[GetSkillNameFromFormattedString(key)] = new Skill
                    {
                        Value = skill.Value,
                        Cap = skill.Cap,
                        Experience = skill.Progress
                    };
                }
            }

            // Inventory
            Inventory = new Container(this, CharacterModel.InventoryId);
            Inventory.LoadFromModel(CharacterModel.Inventory.ToString());
            Containers.Set(CharacterModel.InventoryId, Inventory);
            Inventory.OnChange.Subscribe(() => InventoryChange());

            // Schedule inventory updates
            Task.Delay(1000).ContinueWith(_ =>
            {
                foreach (var slot in Inventory.Slots)
                {
                    var item = slot.Value;
                    var slotId = slot.Key;

                    PacketAddItemContainer.Send(this, new
                    {
                        amount = item.Amount,
                        containerId = Inventory.ContainerId,
                        itemName = item.Namespace,
                        itemRef = item.Ref,
                        slotId,
                        itemRarity = item.Rarity,
                        goldCost = item.GoldCost,
                        weight = item.Weight
                    }, false);

                    if (item is Equipament || item is PowerScroll || item is PetItem || item is MountItem)
                    {
                        PacketTooltip.Send(this, item.Ref, item.Serialize());
                    }
                }

                RefreshEquipamentsList();
                CalculateStats();
                CalculateStatics();
                SendTooltips();
                PacketUpdateSkillInfo.Send(this);
                PacketPlayerStatics.Send(this);
            });

            // Party
            if (CharacterModel.Party != null)
            {
                var sessionParty = Party.GetSession(CharacterModel.Party);
                if (sessionParty != null)
                {
                    Party = sessionParty;
                    PartyOwner = sessionParty.Owner;
                    sessionParty.RefreshCharacter(this);
                }
            }

            CalculateStats();
            RestoreStats();
            Loaded = true;*/
        }

        public void SyncPlayerStats()
        {
            if (Map == null || Removed)            
                return;            

            if (!Removed)
            {
                Packet.Get(ServerPacketType.PlayerStatics).Send(this);
                Packet.Get(ServerPacketType.PlayerStats).Send(this);
            }
        }

        public override void Save()
        {
            if (Map == null || Removed)            
                return;
            
            var data = Serialize();

            if (data.ContainsKey("Id"))            
                Update(data["Id"].ToString(), data, this);
        }

        public Dictionary<string, object> Serialize()
        {
            var actionbarParsed = new List<Dictionary<string, object>>();
            foreach (var kvp in Actionbar)
            {
                var slot = kvp.Value;
                actionbarParsed.Add(new Dictionary<string, object>
                {
                    { "Index", kvp.Key },
                    { "Action", slot.Action?.Namespace },
                    { "Item", slot.Item?.Ref }
                });
            }

            var inventoryParsed = Inventory.SaveToModel();

            var skillsParsed = new Dictionary<string, object>();
            var pointerIndex = 0;

            foreach (var kvp in Skills)
            {
                var skill = kvp.Value;

                skillsParsed[SkillNameExtensions.GetSkillNameString(kvp.Key)] = new Dictionary<string, object>
                {
                    { "Index", pointerIndex },
                    { "Cap", skill.Cap },
                    { "Value", skill.Value },
                    { "Progress", skill.Experience == 0 && skill.Value > 0 ? GetTotalExperienceForLevel(skill.Value) : skill.Experience }
                };

                pointerIndex++;
            }
                      
            var data = new Dictionary<string, object>
            {
                { "Id", CharacterId },
                { "Name", Name },
                { "Visual", Visual },
                { "States", States.GetCurrentFlags() },
                { "Map", Map?.Name },
                { "X", Transform.Position.X },
                { "Y", Transform.Position.Y },
                { "Z", Transform.Position.Z },
                { "R", Transform.Rotation.Yaw },
                { "Str", Str },
                { "Dex", Dex },
                { "Int", Int },
                { "Vig", Vig },
                { "Agi", Agi },
                { "Luc", Luc },
                { "Life", Life },
                { "Mana", Mana },
                { "Stamina", Stamina },
                { "HelmetArmor", Helmet != null ? JsonConvert.SerializeObject(Helmet) : null },
                { "ChestArmor", Chest != null ? JsonConvert.SerializeObject(Chest) : null },
                { "GlovesArmor", Gloves != null ? JsonConvert.SerializeObject(Gloves) : null },
                { "BootsArmor", Boots != null ? JsonConvert.SerializeObject(Boots) : null },
                { "PantsArmor", Pants != null ? JsonConvert.SerializeObject(Pants) : null },
                { "Robe", Robe != null ? JsonConvert.SerializeObject(Robe) : null },
                { "Cloak", Cloak != null ? JsonConvert.SerializeObject(Cloak) : null },
                { "Ring01", Ring01 != null ? JsonConvert.SerializeObject(Ring01) : null },
                { "Ring02", Ring02 != null ? JsonConvert.SerializeObject(Ring02) : null },
                { "Necklance", Necklance != null ? JsonConvert.SerializeObject(Necklance) : null },
                { "Offhand", Offhand != null ? JsonConvert.SerializeObject(Offhand) : null },
                { "Mainhand", Mainhand != null ? JsonConvert.SerializeObject(Mainhand) : null },
                { "Instrument", Instrument != null ? JsonConvert.SerializeObject(Instrument) : null },
                { "Pet", Pet != null ? JsonConvert.SerializeObject(Pet) : null },
                { "Mount", Mount != null ? JsonConvert.SerializeObject(Mount) : null },
                { "Pickaxetool", Pickaxetool != null ? JsonConvert.SerializeObject(Pickaxetool) : null },
                { "Axetool", Axetool != null ? JsonConvert.SerializeObject(Axetool) : null },
                { "Scythetool", Scythetool != null ? JsonConvert.SerializeObject(Scythetool) : null },
                { "Actionbar", actionbarParsed.Count > 0 ? JsonConvert.SerializeObject(actionbarParsed) : "[]" },
                { "Skills", skillsParsed.Count > 0 ? JsonConvert.SerializeObject(skillsParsed) : null },
                { "Inventory", inventoryParsed },
                { "InventoryId", Inventory.ContainerId },
                { "StatsPoints", StatsPoints },
                { "StatsCap", StatsCap },
                { "Party", (Party != null) ? Party?.Id : null },
                { "DailyQuestsIndex", DailyQuestsIndex >= 1 ? DailyQuestsIndex : 1 },
                { "DailyQuestsMetadata", DailyQuest.GenerateMetadata(false, true) },
                { "Friends", Friends.Count > 0 ? JsonConvert.SerializeObject(Friends) : "[]" },
                { "FriendsRequests", FriendsRequests.Count > 0 ? JsonConvert.SerializeObject(FriendsRequests) : "[]" },
                { "GuildId", Guild?.Id },
                { "GuildName", Guild?.Name },
                { "Archivements", SteamArchivements.Count > 0 ? JsonConvert.SerializeObject(SteamArchivements) : "[]" }
            };

            return data;
        }

        public static string ParseData(string characterId)
        {
            var character = GetData(characterId);

            if (character == null) return "{}";

            var mappedCharacter = new Dictionary<string, object>();

            foreach (var property in typeof(CharacterEntity).GetProperties())
            {
                var value = property.GetValue(character);
                mappedCharacter[property.Name] = value;
            }

            var inventoryParsed = new List<object>();
            if (character.Inventory != null)
            {
                var inventory = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(character.Inventory);
                foreach (var slotId in inventory.Keys)
                {
                    try
                    {
                        var inventorySlot = JsonConvert.DeserializeObject<MoveItemPayload>(inventory[slotId].ToString());
                        var itemRef = Items.GetItemByRef(inventorySlot.ItemRef);
                        inventory[slotId]["slotId"] = int.Parse(slotId);
                        inventory[slotId]["rarity"] = itemRef?.Rarity ?? 0;
                        inventory[slotId]["goldCost"] = itemRef?.GoldCost ?? 0;
                        inventoryParsed.Add(inventory[slotId]);
                    }
                    catch { }
                }
            }

            var actionbarParsed = new List<object>();
            if (character.Actionbar != null)
            {
                var actionbar = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(character.Actionbar);
                foreach (var slotId in actionbar.Keys)
                {
                    try
                    {
                        if (!string.IsNullOrEmpty(actionbar[slotId]["ActionName"].ToString()) || !string.IsNullOrEmpty(actionbar[slotId]["ItemName"].ToString()))
                        {
                            actionbar[slotId]["slotId"] = int.Parse(slotId);
                            actionbarParsed.Add(actionbar[slotId]);
                        }
                    }
                    catch { }
                }
            }

            mappedCharacter["ChestArmor"] = character.ChestArmor != null ? GetRarity(JsonConvert.DeserializeObject<Dictionary<string, object>>(character.ChestArmor)) : null;
            mappedCharacter["HelmetArmor"] = character.HelmetArmor != null ? GetRarity(JsonConvert.DeserializeObject<Dictionary<string, object>>(character.HelmetArmor)) : null;
            mappedCharacter["BootsArmor"] = character.BootsArmor != null ? GetRarity(JsonConvert.DeserializeObject<Dictionary<string, object>>(character.BootsArmor)) : null;
            mappedCharacter["GlovesArmor"] = character.GlovesArmor != null ? GetRarity(JsonConvert.DeserializeObject<Dictionary<string, object>>(character.GlovesArmor)) : null;
            mappedCharacter["PantsArmor"] = character.PantsArmor != null ? GetRarity(JsonConvert.DeserializeObject<Dictionary<string, object>>(character.PantsArmor)) : null;
            mappedCharacter["Robe"] = character.Robe != null ? GetRarity(JsonConvert.DeserializeObject<Dictionary<string, object>>(character.Robe)) : null;
            mappedCharacter["Cloak"] = character.Cloak != null ? GetRarity(JsonConvert.DeserializeObject<Dictionary<string, object>>(character.Cloak)) : null;
            mappedCharacter["Ring01"] = character.Ring01 != null ? GetRarity(JsonConvert.DeserializeObject<Dictionary<string, object>>(character.Ring01)) : null;
            mappedCharacter["Ring02"] = character.Ring02 != null ? GetRarity(JsonConvert.DeserializeObject<Dictionary<string, object>>(character.Ring02)) : null;
            mappedCharacter["Necklance"] = character.Necklance != null ? GetRarity(JsonConvert.DeserializeObject<Dictionary<string, object>>(character.Necklance)) : null;
            mappedCharacter["Offhand"] = character.Offhand != null ? GetRarity(JsonConvert.DeserializeObject<Dictionary<string, object>>(character.Offhand)) : null;
            mappedCharacter["Mainhand"] = character.Mainhand != null ? GetRarity(JsonConvert.DeserializeObject<Dictionary<string, object>>(character.Mainhand)) : null;
            mappedCharacter["Instrument"] = character.Instrument != null ? GetRarity(JsonConvert.DeserializeObject<Dictionary<string, object>>(character.Instrument)) : null;
            mappedCharacter["Pet"] = character.Pet != null ? GetRarity(JsonConvert.DeserializeObject<Dictionary<string, object>>(character.Pet)) : null;
            mappedCharacter["Mount"] = character.Mount != null ? GetRarity(JsonConvert.DeserializeObject<Dictionary<string, object>>(character.Mount)) : null;
            mappedCharacter["Pickaxetool"] = character.PickaxeTool != null ? GetRarity(JsonConvert.DeserializeObject<Dictionary<string, object>>(character.PickaxeTool)) : null;
            mappedCharacter["Axetool"] = character.AxeTool != null ? GetRarity(JsonConvert.DeserializeObject<Dictionary<string, object>>(character.AxeTool)) : null;
            mappedCharacter["Scythetool"] = character.ScytheTool != null ? GetRarity(JsonConvert.DeserializeObject<Dictionary<string, object>>(character.ScytheTool)) : null;

            var dailyQuestsMetadata = character.DailyQuestsMetadata != null ? JsonConvert.DeserializeObject<Dictionary<string, object>>(character.DailyQuestsMetadata) : null;
            var dailyQuests = DailyQuests.GetQuests(character.DailyQuestsIndex, dailyQuestsMetadata);

            var friends = !string.IsNullOrEmpty(character.Friends) ? JsonConvert.DeserializeObject<List<string>>(character.Friends) : new List<string>();
            var friendsRequests = !string.IsNullOrEmpty(character.FriendsRequests) ? JsonConvert.DeserializeObject<List<string>>(character.FriendsRequests) : new List<string>();

            var archivements = !string.IsNullOrEmpty(character.Archivements) ? new HashSet<string>(JsonConvert.DeserializeObject<List<string>>(character.Archivements)) : new HashSet<string>();

            mappedCharacter["Inventory"] = inventoryParsed;
            mappedCharacter["Actionbar"] = actionbarParsed;
            mappedCharacter["DailyQuests"] = dailyQuests?.GenerateMetadata(true);
            mappedCharacter["Friends"] = friends;
            mappedCharacter["FriendsRequests"] = friendsRequests;
            mappedCharacter["Archivements"] = archivements.ToList();

            return JsonConvert.SerializeObject(mappedCharacter);
        }

        public static Dictionary<string, object> GetRarity(Dictionary<string, object> data)
        {
            if (data != null && data.ContainsKey("ItemRef"))
            {
                var itemRef = data["ItemRef"].ToString();
                var item = Items.GetItemByRef(itemRef);

                data["Rarity"] = item != null ? item.Rarity : ItemRarity.Common;
            }

            return data;
        }

        public async Task SaveToDatabase()
        {
            if (Map == null || Removed)
                return;

            if (!InEvent)
            {
                var data = Serialize();

                if (Map?.Name == "_Dev")
                {
                    data.Remove("map");
                    data.Remove("x");
                    data.Remove("y");
                    data.Remove("z");
                    data.Remove("r");
                }

                await Queue.EnqueueUpdateJobAsync(new JobData()
                {
                    Table = "character",
                    Id = data["id"].ToString(),
                    Set = data
                });

                if (data.ContainsKey("inventory"))
                {
                    await Queue.EnqueueUpdateJobAsync(new JobData()
                    {
                        Table = "container",
                        ContainerId = Inventory.ContainerId,
                        CharacterId = CharacterId,
                        Set = data["inventory"]
                    });
                }
            }
        }

        public void SendTooltips()
        {
            foreach (var item in Inventory.Slots.Values)
            {
                if (item is Equipament equipament)                
                    Packet.Get<PacketTooltipHandler>(ServerPacketType.Tooltip).Send(this, equipament.Ref, equipament.Serialize());                
            }

            if (Equipaments.Count > 0)
            {
                foreach (var equipament in Equipaments)                
                    Packet.Get<PacketTooltipHandler>(ServerPacketType.Tooltip).Send(this, equipament.Ref, equipament.Serialize());
            }
        }

        public void Disconnect()
        {
            if (Socket != null)
            {
                try
                {
                    Socket.Close();
                }
                catch (Exception ex){}
            }

            Save();

            SaveToDatabase().ConfigureAwait(false);

            if (Map != null)            
                Map.LeaveMap(this);
            
            Removed = true;
            Player.OnlinePlayers.Remove(CharacterId);
        }
    }
}
