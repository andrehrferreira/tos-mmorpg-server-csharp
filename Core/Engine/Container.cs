using System.Reactive.Subjects;
using Newtonsoft.Json;

namespace Server
{
    public enum ContainerType
    {
        Stash,
        Loot,
        Trade,
        Inventory,
        Recipient
    }

    public enum DefaultLootType
    {
        Poor,
        Meager,
        Average,
        Rich,
        FilthyRich,
        UltraRich,
        SuperBoss
    }

    public class SlotRef
    {
        public int SlotId { get; set; }
        public Item Item { get; set; }

        public SlotRef(int slotId, Item item)
        {
            SlotId = slotId;
            Item = item;
        }
    }

    public class Container
    {
        public Entity Owner { get; set; }
        public string ContainerId { get; protected set; }
        public Dictionary<int, Item> Slots { get; protected set; } = new Dictionary<int, Item>();
        public Dictionary<string, SlotRef> ItemIndex { get; protected set; } = new Dictionary<string, SlotRef>();
        public List<Player> Observers { get; protected set; } = new List<Player>();
        public Subject<Container> OnChange { get; } = new Subject<Container>();

        public Container(Entity owner, string containerId = null)
        {
            Owner = owner;
            ContainerId = containerId != null ? containerId.Substring(0, 12) : GUID.NewID();
            Slots = new Dictionary<int, Item>();
            ItemIndex = new Dictionary<string, SlotRef>();
        }

        public async Task LoadFromModelAsync(dynamic data)
        {
            if (data is string)
                data = JsonConvert.DeserializeObject<List<dynamic>>(data);

            if (data != null)
            {
                foreach (var itemData in data)
                {
                    int slotId = itemData.slotId ?? itemData.SlotId;
                    slotId = (itemData.slotId == 0) ? itemData.slotId : slotId;

                    var item = Items.GetItemByRef(itemData.ItemRef);

                    if (item != null && slotId >= 0)
                    {
                        Slots[slotId] = item;
                        ItemIndex[item.Ref] = new SlotRef(slotId, item);
                    }
                }
            }
        }
    }

    public class Loot: Container
    {
        public Loot(Entity owner, string containerId = null): base(owner, containerId) 
        { 
        }
    }

    public static class Containers
    {
        public static Dictionary<string, Container> ContainerDictionary { get; private set; } = new Dictionary<string, Container>();

        public static void FromDatabase(dynamic data)
        {
            var container = new Container(null, data.containerId);
            var items = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(data.items);
            var itemsParsed = new List<dynamic>();

            if (items != null)
            {
                foreach (var slotId in items.Keys)
                {
                    try
                    {
                        if (slotId != null && int.Parse(slotId) >= 0)
                        {
                            items[slotId].slotId = int.Parse(slotId);
                            itemsParsed.Add(items[slotId]);
                        }
                    }
                    catch
                    {
                        // Handle exceptions if needed
                    }
                }
            }

            container.LoadFromModel(itemsParsed);
            ContainerDictionary[data.containerId] = container;
        }

        public static bool Has(string containerId)
        {
            return ContainerDictionary.ContainsKey(containerId);
        }

        public static Container Get(string containerId)
        {
            return ContainerDictionary.TryGetValue(containerId, out var container) ? container : null;
        }

        public static void Set(string containerId, Container container)
        {
            ContainerDictionary[containerId] = container;
        }

        public static Container GetOrCreate(string containerId, Entity entity)
        {
            if (ContainerDictionary.TryGetValue(containerId, out var container))
            {
                container.Owner = entity;
                ContainerDictionary[containerId] = container;
                return container;
            }
            else
            {
                var newContainer = new Container(entity, containerId);
                ContainerDictionary[containerId] = newContainer;
                return newContainer;
            }
        }
    }
}
