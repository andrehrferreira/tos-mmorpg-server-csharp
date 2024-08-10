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
        public string ContainerId { get; set; }
        public Dictionary<int, Item> Slots { get; set; } = new Dictionary<int, Item>();
        public Dictionary<string, SlotRef> ItemIndex { get; set; } = new Dictionary<string, SlotRef>();
        public List<Player> Observers { get; set; } = new List<Player>();
        public Subject<Container> OnChange { get; } = new Subject<Container>();

        public Container(Entity owner, string containerId = null)
        {
            Owner = owner;
            ContainerId = containerId != null ? containerId.Substring(0, 12) : GUID.NewID();
            Slots = new Dictionary<int, Item>();
            ItemIndex = new Dictionary<string, SlotRef>();
        }

        public void LoadFromModel(string data)
        {
            var parsedData = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(data);

            if (parsedData != null)
            {
                foreach (var itemData in parsedData)
                {
                    int slotId = Convert.ToInt32(itemData["SlotId"]);
                    var item = Items.GetItemByRef(itemData["ItemRef"].ToString());

                    if (item != null && slotId >= 0)
                    {
                        Slots[slotId] = item;
                        ItemIndex[item.Ref] = new SlotRef(slotId, item);
                    }
                }
            }
        }

        public Container ChangeOwner(Entity newOwner)
        {
            Owner = newOwner;
            return this;
        }

        public string SaveToModel()
        {
            var inventory = new Dictionary<int, object>();

            foreach (var slot in Slots)
            {
                if (slot.Value != null)
                {
                    inventory[slot.Key] = new
                    {
                        ItemName = slot.Value.Namespace,
                        Amount = slot.Value.Amount,
                        ItemRef = slot.Value.Ref
                    };
                }
            }

            return JsonConvert.SerializeObject(inventory);
        }

        public int GetEmptySlot()
        {
            for (int i = 0; i < 100; i++)
            {
                if (!Slots.ContainsKey(i))
                    return i;
            }

            return Slots.Count;
        }

        public int HasStackableItem(Item item)
        {
            if (item is Stackable stackable)
            {
                var namespaceName = stackable.Namespace;

                foreach (var slot in Slots)
                {
                    if (slot.Value.Namespace == namespaceName)
                        return slot.Key;
                }
            }

            return -1;
        }

        public bool HasItem(string refId)
        {
            return ItemIndex.ContainsKey(refId);
        }

        public bool HasItemAmount(string itemName, int amount)
        {
            foreach (var item in Slots.Values)
            {
                if (item.Namespace == itemName && item.Amount >= amount)
                    return true;
            }

            return false;
        }

        public bool HasItemBySlotId(int slotId)
        {
            return Slots.ContainsKey(slotId);
        }

        public SlotRef GetItemSlot(string refId)
        {
            return ItemIndex.ContainsKey(refId) ? ItemIndex[refId] : null;
        }

        public Item GetItem(string refId)
        {
            return ItemIndex.ContainsKey(refId) ? ItemIndex[refId].Item : null;
        }

        public Item GetItemByNamespace(string itemName)
        {
            foreach (var item in Slots.Values)
            {
                if (item.Namespace == itemName)
                    return item;
            }

            return null;
        }

        public Item GetSlot(int slotId)
        {
            return Slots.ContainsKey(slotId) ? Slots[slotId] : null;
        }

        public int GetSlotByItemNamespace(string itemName)
        {
            foreach (var slot in Slots)
            {
                if (slot.Value.Namespace == itemName)
                    return slot.Key;
            }

            return -1;
        }

        public int GetSlotByRef(string refId)
        {
            foreach (var slot in Slots)
            {
                if (slot.Value.Ref == refId)
                    return slot.Key;
            }

            return -1;
        }

        public bool ClearSlot(int slotId)
        {
            if (Slots.ContainsKey(slotId))
            {
                var itemRef = Slots[slotId];
                Slots.Remove(slotId);

                if (itemRef != null)                
                    ItemIndex.Remove(itemRef.Ref);
                
                var observers = new HashSet<Entity>(Observers) { Owner };

                foreach (var observer in observers)
                {
                    Packet.Get(ServerPacketType.RemoveItemContainer).Send(observer, new
                    {
                        containerId = ContainerId,
                        itemRef = itemRef?.Ref,
                        slotId = slotId
                    });
                }

                OnChange.OnNext(this);

                return true;
            }

            return false;
        }

        public async Task<bool> ChangeAmount(int slotId, int amount)
        {
            if (Slots.ContainsKey(slotId))
            {
                var observers = new HashSet<Entity>(Observers) { Owner };
                var item = Slots[slotId];

                if (amount > 0)
                {
                    item.Amount = amount;
                    Slots[slotId] = item;
                    Items.SetItem(item.Ref, item);

                    if (Owner != null && Owner.Socket != null)
                    {
                        await Owner.Socket.Services.GameServerQueue.Add("update", new
                        {
                            table = "item",
                            id = item.Ref,
                            set = new { amount }
                        });

                        foreach (var observer in observers)
                        {
                            Packet.Get(ServerPacketType.ChangeAmountItemContainer).Send(observer, new
                            {
                                containerId = ContainerId,
                                slotId,
                                amount
                            });
                        }

                        await Save();

                        if (Owner is Player player)
                        {
                            player.Save();
                            await player.SaveToDatabase();
                        }

                        OnChange.OnNext(this);
                    }

                    return true;
                }
                else
                {
                    await RemoveItem(item.Ref);
                    return true;
                }
            }
            else
            {
                return false;
            }
        }


        public int Count()
        {
            return ItemIndex.Count;
        }

        public void AddObserver(Player player)
        {
            Observers.Add(player);
        }

        public void ClearObservers()
        {
            Observers = new List<Player>();
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
