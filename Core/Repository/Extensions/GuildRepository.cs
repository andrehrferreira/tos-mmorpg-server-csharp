using Microsoft.EntityFrameworkCore;

namespace Server
{
    public static partial class Repository
    {
        public static async Task<List<GuildEntity>> GetGuildsAsync()
        {
            return await Context.Set<GuildEntity>().ToListAsync();
        }

        public static async Task<bool> CreateGuildAsync(string guildId, GuildEntity data)
        {
            try
            {
                var guild = new GuildEntity
                {
                    Id = guildId,
                    Owner = data.Owner,
                    GuildName = data.GuildName,
                    // Outros campos que possam existir no GuildEntity
                };

                Context.Set<GuildEntity>().Add(guild);
                await Context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static async Task<bool> UpdateGuildAsync(GuildEntity data)
        {
            try
            {
                var guild = await Context.Set<GuildEntity>()
                    .FirstOrDefaultAsync(g => g.Id == data.Id);

                if (guild != null)
                {
                    Context.Entry(guild).CurrentValues.SetValues(data);
                    await Context.SaveChangesAsync();
                    return true;
                }
            }
            catch{}

            return false;
        }
    }
}
