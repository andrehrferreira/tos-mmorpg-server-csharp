using Microsoft.EntityFrameworkCore;

namespace Server
{
    public static partial class Repository
    {
        public static async Task<int> GetCharacterCount(string accountId)
        {
            return await Context.Set<CharacterEntity>()
                                .CountAsync(c => c.AccountId == accountId);
        }

        public static async Task<List<CharacterEntity>> GetAllCharacters()
        {
            try
            {
                return await Context.Set<CharacterEntity>().ToListAsync();
            }
            catch
            {
                throw new Exception("Characters not found.");
            }
        }

        public static async Task<List<CharacterEntity>> GetCharacters(string accountId)
        {
            try
            {
                return await Context.Set<CharacterEntity>()
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
                IQueryable<CharacterEntity> query = Context.Set<CharacterEntity>()
                                                           .Where(c => c.AccountId == accountId && c.Id == characterId);

                if (fields != "*")
                {
                    var selectFields = fields.Split(',').Select(f => f.Trim()).ToList();
                    query = query.Select(c => new CharacterEntity
                    {
                        Id = c.Id
                    });
                }

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
                Context.Set<CharacterEntity>().Add(data);
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
                var character = await Context.Set<CharacterEntity>().FindAsync(id);

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
                var character = await Context.Set<CharacterEntity>().FindAsync(id);
                if (character != null)
                {
                    Context.Set<CharacterEntity>().Remove(character);
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
    }
}
