using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Server
{
    public static partial class Repository
    {
        public static async Task<bool> CreateContainer(ContainerEntity data)
        {
            try
            {
                var containerExists = await Context.Set<ContainerEntity>()
                    .FirstOrDefaultAsync(c => c.ContainerId == data.ContainerId && c.CharacterId == data.CharacterId);

                if (containerExists == null)
                {
                    Context.Set<ContainerEntity>().Add(data);
                    await Context.SaveChangesAsync();
                    return true;
                }
            }
            catch{}

            return false;
        }

        public static async Task<List<ContainerEntity>> GetContainers()
        {
            return await Context.Set<ContainerEntity>().ToListAsync();
        }

        public static async Task<ContainerEntity> GetContainer(string containerId, string characterId)
        {
            return await Context.Set<ContainerEntity>()
                .FirstOrDefaultAsync(c => c.ContainerId == containerId && c.CharacterId == characterId);
        }

        public static async Task<bool> UpdateContainer(ContainerEntity data)
        {
            try
            {
                var container = await Context.Set<ContainerEntity>()
                    .FirstOrDefaultAsync(c => c.ContainerId == data.ContainerId);

                if (container != null)
                {
                    Context.Entry(container).CurrentValues.SetValues(data);
                    await Context.SaveChangesAsync();
                    return true;
                }
            }
            catch {}

            return false;
        }

        public static async Task<bool> UpsertContainer(ContainerEntity data)
        {
            try
            {
                var updated = await UpdateContainer(data);

                if (!updated)                
                    return await CreateContainer(data);
                
                return true;
            }
            catch {}

            return false;
        }

        public static async Task<bool> DeleteContainer(string containerId)
        {
            try
            {
                var container = await Context.Set<ContainerEntity>()
                    .FirstOrDefaultAsync(c => c.ContainerId == containerId);

                if (container != null)
                {
                    Context.Set<ContainerEntity>().Remove(container);
                    await Context.SaveChangesAsync();
                    return true;
                }
            }
            catch {}

            return false;
        }
    }
}
