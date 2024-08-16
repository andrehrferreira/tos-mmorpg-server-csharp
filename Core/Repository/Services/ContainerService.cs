using Microsoft.EntityFrameworkCore;

namespace Server
{
    public static partial class Repository
    {
        public static async Task ContainersLoadAll()
        {
            Logger.Log("Loading Containers...");

            var containersData = await GetContainers();

            foreach (var container in containersData)
                Containers.FromDatabase(container);

            Logger.Log($"{containersData.Count} containers loaded...");
        }

        public static async Task<bool> CreateContainer(ContainerEntity data)
        {
            try
            {
                var containerExists = await Context.Containers
                    .FirstOrDefaultAsync(c => c.ContainerId == data.ContainerId && c.CharacterId == data.CharacterId);

                if (containerExists == null)
                {
                    Context.Containers.Add(data);
                    await Context.SaveChangesAsync();
                    return true;
                }
            }
            catch { }

            return false;
        }

        public static async Task<List<ContainerEntity>> GetContainers()
        {
            return await Context.Containers.ToListAsync();
        }

        public static async Task<ContainerEntity> GetContainer(string containerId, string characterId)
        {
            return await Context.Containers
                .FirstOrDefaultAsync(c => c.ContainerId == containerId && c.CharacterId == characterId);
        }

        public static async Task<bool> UpdateContainer(ContainerEntity data)
        {
            try
            {
                var container = await Context.Containers
                    .FirstOrDefaultAsync(c => c.ContainerId == data.ContainerId);

                if (container != null)
                {
                    Context.Entry(container).CurrentValues.SetValues(data);
                    await Context.SaveChangesAsync();
                    return true;
                }
            }
            catch { }

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
            catch { }

            return false;
        }

        public static async Task<bool> DeleteContainer(string containerId)
        {
            try
            {
                var container = await Context.Containers
                    .FirstOrDefaultAsync(c => c.ContainerId == containerId);

                if (container != null)
                {
                    Context.Containers.Remove(container);
                    await Context.SaveChangesAsync();
                    return true;
                }
            }
            catch { }

            return false;
        }
    }
}
