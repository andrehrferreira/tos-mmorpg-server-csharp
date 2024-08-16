using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Server
{
    public static partial class Repository
    {
        public static async Task ItemsLoadAll()
        {
            Logger.Log("Loading Items...");
                 
            var itemsData = await GetItems();

            foreach (var item in itemsData)            
                Items.ItemFromDatabase(item);

            Logger.Log($"{itemsData.Count} Items loaded...");
        }

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

        public static string CreateItemId()
        {
            var tmpUUID = Guid.NewGuid();
            var hexStringWithLeadingZero = tmpUUID.ToString("N").ToUpper();
            return hexStringWithLeadingZero.Substring(0, 10);
        }

        public static async Task<string> CreateItem(
            string containerId,
            string owner,
            string itemName,
            int amount,
            string createBy,
            string createByAdmin = "",
            object props = null,
            bool createInDatabase = true
        )
        {
            var itemId = CreateItemId();

            if (createInDatabase)
            {
                var itemData = new ItemEntity
                {
                    ContainerId = containerId,
                    Id = itemId,
                    Owner = owner,
                    ItemName = itemName,
                    Amount = amount,
                    CreateByAdmin = createByAdmin,
                    Props = props is Dictionary<string, object> ? JsonConvert.SerializeObject(props) : null
                };

                var result = await CreateItem(itemData);

                Items.ItemFromDatabase(new ItemEntity
                {
                    ItemName = itemName,
                    Amount = amount,
                    Id = itemId,
                    Props = props is Dictionary<string, object> ? JsonConvert.SerializeObject(props) : null
                });

                return result ? itemId : null;
            }
            else
            {
                Items.ItemFromDatabase(new ItemEntity
                {
                    ItemName = itemName,
                    Amount = amount,
                    Id = itemId,
                    Props = props is Dictionary<string, object> ? JsonConvert.SerializeObject(props) : null
                });

                return itemId;
            }
        }
    }
}
