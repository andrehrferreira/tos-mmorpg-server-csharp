using Microsoft.EntityFrameworkCore;
using System;

namespace Server
{
    public static partial class Repository
    {
        public static async Task GuildsLoadAll()
        {
            Logger.Log("Loading Guilds...");

            var guildsData = await GetGuilds();

            foreach (var guild in guildsData)            
                Guilds.FromDatabase(guild);            

            Logger.Log($"{guildsData.Count} guilds loaded...");
        }


        public static async Task<List<GuildEntity>> GetGuilds()
        {
            return await Context.Guilds.ToListAsync();
        }

        public static async Task<bool> CreateGuild(string guildId, GuildEntity data)
        {
            try
            {
                Context.Guilds.Add(data);
                await Context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static async Task<bool> UpdateGuild(GuildEntity data)
        {
            try
            {
                var guild = await Context.Guilds
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
