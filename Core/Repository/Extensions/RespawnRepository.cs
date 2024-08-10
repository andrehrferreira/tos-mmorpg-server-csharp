using Microsoft.EntityFrameworkCore;

namespace Server
{
    public static partial class Repository
    {
        public static async Task<bool> CreateRespawn(RespawnEntity data)
        {
            try
            {
                Context.Set<RespawnEntity>().Add(data);
                await Context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static async Task<List<RespawnEntity>> GetRespawns(string map)
        {
            return await Context.Set<RespawnEntity>().Where(r => r.Map == map).ToListAsync();
        }

        public static async Task<bool> RemoveRespawn(string id)
        {
            try
            {
                var respawn = await Context.Set<RespawnEntity>().FindAsync(id);
                if (respawn != null)
                {
                    Context.Set<RespawnEntity>().Remove(respawn);
                    await Context.SaveChangesAsync();
                    return true;
                }
            }
            catch { }

            return false;
        }
    }
}
