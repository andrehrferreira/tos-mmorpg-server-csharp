using Microsoft.EntityFrameworkCore;

namespace Server
{
    public static partial class Repository
    {
        public static async Task<bool> CreateItemAsync(ItemEntity data)
        {
            try
            {
                Context.Set<ItemEntity>().Add(data);
                await Context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static async Task<ItemEntity> GetItemAsync(string refId)
        {
            return await Context.Set<ItemEntity>().FindAsync(refId);
        }

        public static async Task<List<ItemEntity>> GetItemsAsync()
        {
            return await Context.Set<ItemEntity>().ToListAsync();
        }

        public static async Task<bool> UpdateItemAsync(string refId, ItemEntity data)
        {
            try
            {
                var item = await Context.Set<ItemEntity>().FindAsync(refId);

                if (item != null)
                {
                    Context.Entry(item).CurrentValues.SetValues(data);
                    await Context.SaveChangesAsync();
                    return true;
                }
            }
            catch { }

            return false;
        }

        public static async Task<bool> DeleteItemAsync(string refId)
        {
            try
            {
                var item = await Context.Set<ItemEntity>().FindAsync(refId);
                if (item != null)
                {
                    Context.Set<ItemEntity>().Remove(item);
                    await Context.SaveChangesAsync();
                    return true;
                }
            }
            catch { }

            return false;
        }
    }
}
