
using Newtonsoft.Json;

namespace Server
{
    public static partial class Repository
    {
        public static async Task ItemsLoadAll()
        {
            Console.WriteLine("Loading Items...");

            var itemsData = await GetItems();

            foreach (var item in itemsData)            
                Items.ItemFromDatabase(item);

            Console.WriteLine($"{itemsData.Count} Items loaded...");
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
