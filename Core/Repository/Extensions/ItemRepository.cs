using Microsoft.EntityFrameworkCore;

namespace Server
{
    public static partial class Repository
    {
        public static async Task<bool> CreateItem(ItemEntity data)
        {
            try
            {
                Context.Items.Add(data);
                await Context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static async Task<ItemEntity> GetItem(string refId)
        {
            return await Context.Items.FindAsync(refId);
        }

        public static async Task<List<ItemEntity>> GetItems()
        {
            return await Context.Items.ToListAsync();
        }

        public static async Task<bool> UpdateItem(string refId, ItemEntity data)
        {
            try
            {
                var item = await Context.Items.FindAsync(refId);

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

        public static async Task<bool> DeleteItem(string refId)
        {
            try
            {
                var item = await Context.Items.FindAsync(refId);

                if (item != null)
                {
                    Context.Items.Remove(item);
                    await Context.SaveChangesAsync();
                    return true;
                }
            }
            catch { }

            return false;
        }
    }
}
