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

        public void LoadFromModel(List<dynamic> parsedData)
        {
            if (parsedData == null || parsedData.Count == 0) return;

            try
            {
                foreach (var itemData in parsedData)
                {
                    int slotId = -1;

                    if (itemData != null &&
                        itemData.ContainsKey("SlotId") &&
                        int.TryParse(itemData["SlotId"].ToString(), out slotId) &&
                        slotId >= 0)
                    {
                        if (itemData.ContainsKey("ItemRef"))
                        {
                            var item = Items.GetItemByRef(itemData["ItemRef"].ToString());

                            if (item != null)
                            {
                                Slots[slotId] = item;
                                ItemIndex[item.Ref] = new SlotRef(slotId, item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro durante o processamento dos itens: {ex.Message}");
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

        public async Task<int> AddItem(string refId, int amount = 1, int slotId = -1, bool showHint = true)
        {
            if (!string.IsNullOrEmpty(ContainerId))
            {
                var item = Items.GetItemByRef(refId);

                if (item != null)
                {
                    var stackableItemSlotId = HasStackableItem(item);
                    var observers = new HashSet<Entity>(Observers) { Owner };

                    item.ContainerId = ContainerId;

                    if (stackableItemSlotId < 0)
                    {
                        slotId = slotId > -1 ? slotId : GetEmptySlot();

                        if (amount <= 0)
                        {
                            amount = 1;
                            slotId = -1;
                        }

                        if (slotId > -1)
                        {
                            ItemIndex[refId] = new SlotRef(slotId, item);
                            Slots[slotId] = item;
                            Items.SetItem(refId, item);

                            if (Owner != null)
                            {
                                if (item is Equipament)
                                    Packet.Get(ServerPacketType.Tooltip)?.Send(Owner as Player, refId, item.Serialize());

                                if (Owner.Socket != null)
                                {
                                    await Queue.EnqueueUpdateJobAsync(new JobData()
                                    {
                                        Table = "item",
                                        Id = refId,
                                        Set = new { slotId, containerId = ContainerId }
                                    });
                                }

                                foreach (var observer in observers)
                                {
                                    Packet.Get(ServerPacketType.AddItemContainer)?.Send(observer, new
                                    {
                                        containerId = ContainerId,
                                        slotId,
                                        itemRef = refId,
                                        itemName = item.Namespace,
                                        amount,
                                        itemRarity = item.Rarity,
                                        goldCost = item.GoldCost,
                                        weight = item.Weight
                                    }, showHint);

                                    if (item is Equipament || item is PowerScroll || item is PetItem || item is MountItem)
                                        Packet.Get(ServerPacketType.Tooltip)?.Send(observer as Player, refId, item.Serialize());
                                }

                                OnChange.OnNext(this);
                            }

                            Owner.Save();
                            return slotId;
                        }
                    }
                    else
                    {
                        var itemInSlot = Slots[stackableItemSlotId];
                        itemInSlot.Amount += amount;

                        ItemIndex[itemInSlot.Ref] = new SlotRef(stackableItemSlotId, itemInSlot);
                        Slots[stackableItemSlotId] = itemInSlot;
                        Items.SetItem(itemInSlot.Ref, itemInSlot);

                        if (Owner != null)
                        {
                            if (Owner.Socket != null)
                            {
                                await Queue.EnqueueUpdateJobAsync(new JobData()
                                {
                                    Table = "item",
                                    Id = itemInSlot.Ref,
                                    Set = new { amount = itemInSlot.Amount }
                                });

                                await Queue.EnqueueDeleteJobAsync(new JobData()
                                {
                                    Table = "item",
                                    Id = refId
                                });
                            }

                            foreach (var observer in observers)
                            {
                                Packet.Get(ServerPacketType.ChangeAmountItemContainer)?.Send(observer, new
                                {
                                    containerId = ContainerId,
                                    slotId = stackableItemSlotId,
                                    amount = itemInSlot.Amount
                                });
                            }

                            OnChange.OnNext(this);
                        }
                                                
                        Owner.Save();
                        return stackableItemSlotId;
                    }
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
                        await Queue.EnqueueUpdateJobAsync(new JobData()
                        {
                            Table = "item",
                            Id = item.Ref,
                            Set = new { amount }
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

        public async Task<bool> RemoveItem(string refId)
        {
            if (ItemIndex.ContainsKey(refId))
            {
                var observers = new HashSet<Entity>(Observers) { Owner };
                var slotRef = ItemIndex[refId];

                ItemIndex.Remove(refId);
                Slots.Remove(slotRef.SlotId);
                Items.RemoveItem(slotRef.Item.Ref);

                if (Owner != null)
                {
                    if (Owner.Socket != null)
                    {
                        await Queue.EnqueueUpdateJobAsync(new JobData()
                        {
                            Table = "item",
                            Id = slotRef.Item.Ref,
                            Set = new { deleted = true, deletedAt = DateTime.UtcNow }
                        });
                    }

                    foreach (var observer in observers)
                    {
                        Packet.Get(ServerPacketType.RemoveItemContainer)?.Send(observer, new
                        {
                            containerId = ContainerId,
                            itemRef = slotRef.Item.Ref,
                            slotId = slotRef.SlotId
                        });
                    }

                    OnChange.OnNext(this);
                }

                await Save();

                if (Owner is Player player)
                {
                    player.Save();
                    await player.SaveToDatabase();
                }

                return true;
            }

            return false;
        }

        public async Task<bool> MoveItem(int from, int to)
        {
            if (Slots.TryGetValue(from, out var slotFrom))
            {
                var slotToExists = Slots.TryGetValue(to, out var slotTo);

                if (slotToExists)
                {
                    ItemIndex[slotTo.Ref] = new SlotRef(from, slotTo);
                    Slots[from] = slotTo;

                    if (Owner != null && Owner.Socket != null)
                    {
                        await Queue.EnqueueUpdateJobAsync(new JobData()
                        {
                            Table = "item",
                            Id = slotTo.Ref,
                            Set = new { slotId = from, containerId = ContainerId }
                        });
                    }
                }

                ItemIndex[slotFrom.Ref] = new SlotRef(to, slotFrom);
                Slots[to] = slotFrom;

                if (Owner != null && Owner.Socket != null)
                {
                    await Queue.EnqueueUpdateJobAsync(new JobData()
                    {
                        Table = "item",
                        Id = slotFrom.Ref,
                        Set = new { slotId = to, containerId = ContainerId }

                    });
                }

                if (!slotToExists)
                {
                    ItemIndex.Remove(slotFrom.Ref);
                    Slots.Remove(from);
                }

                await Save();

                if (Owner is Player player)
                {
                    player.Save();
                    await player.SaveToDatabase();
                }

                OnChange.OnNext(this);

                return true;
            }

            return false;
        }

        public async Task ChangeContainer(
            int currentSlotId,
            Container containerTo,
            int newSlotId,
            int amount = 1
        )
        {
            var currentItem = GetSlot(currentSlotId);

            if (currentItem != null)
            {
                bool totalItem = currentItem.Amount == amount;
                bool hasItem = containerTo.HasItemBySlotId(newSlotId);

                if (!totalItem)
                {
                    if (Owner.Socket != null)
                    {
                        int newAmount = currentItem.Amount - amount;

                        if (newAmount > 0)
                        {
                            var itemRef = await Repository.CreateItem(
                                containerTo.ContainerId,
                                containerTo.Owner.CharacterId,
                                currentItem.Namespace,
                                amount,
                                "split",
                                null,
                                currentItem.Serialize()
                            );

                            if (currentItem is Equipament)
                                Packet.Get(ServerPacketType.Tooltip)?.Send(Owner as Player, itemRef, currentItem.Serialize());

                            await ChangeAmount(currentSlotId, newAmount);
                            await containerTo.AddItem(itemRef, amount);
                        }
                        else
                        {
                            return;
                        }
                    }
                }
                else
                {
                    var observers = new HashSet<Entity>(Observers) { Owner };
                    int slotId = hasItem ? containerTo.GetEmptySlot() : newSlotId;
                                    
                    string itemRef = await Repository.CreateItem(
                        ContainerId,
                        Owner.CharacterId,
                        currentItem.Namespace,
                        amount,
                        "split",
                        null,
                        currentItem.Serialize()
                    );

                    if (currentItem is Equipament)
                        Packet.Get(ServerPacketType.Tooltip)?.Send(Owner as Player, itemRef, currentItem.Serialize());

                    int realSlotAlloc = await containerTo.AddItem(itemRef, amount, slotId);
                    ClearSlot(currentSlotId);

                    if (Owner != null && Owner.Socket != null)
                    {
                        await Queue.EnqueueDeleteJobAsync(new JobData()
                        {
                            Table = "item",
                            Id = currentItem.Ref
                        });

                        if (realSlotAlloc == slotId)
                        {
                            foreach (var observer in observers)
                            {
                                Packet.Get(ServerPacketType.AddItemContainer)?.Send(observer, new
                                {
                                    containerId = containerTo.ContainerId,
                                    slotId = slotId,
                                    itemRef = currentItem.Ref,
                                    itemName = currentItem.Namespace,
                                    amount = amount,
                                    itemRarity = currentItem.Rarity,
                                    goldCost = currentItem.GoldCost,
                                    weight = currentItem.Weight
                                });

                                if (currentItem is Equipament)
                                    Packet.Get(ServerPacketType.Tooltip)?.Send(observer as Player, itemRef, currentItem.Serialize());
                            }
                        }
                    }
                }

                OnChange.OnNext(this);
                await Save();
                await containerTo.Save();

                if (Owner is Player player)
                {
                    player.Save();
                    await player.SaveToDatabase();
                }
            }
        }

        public async Task Consume(int slotId)
        {
            var item = GetSlot(slotId);

            if (item != null)
            {
                if ((item is Consumable || item is PowerScroll) && item.Amount > 0)
                {
                    if (item.Amount == 1)
                    {
                        if (item is Consumable consumable)
                            await consumable.Use(Owner);
                        else if (item is PowerScroll powerScroll)
                            await powerScroll.Use(Owner as Player);

                        ClearSlot(slotId);
                    }
                    else if (await ChangeAmount(slotId, item.Amount - 1))
                    {
                        if (item is Consumable consumable)
                            await consumable.Use(Owner);
                        else if (item is PowerScroll powerScroll)
                            await powerScroll.Use(Owner as Player);
                    }

                    if (Owner is Player player)
                    {
                        player.Save();
                        await player.SaveToDatabase();
                    }
                }
            }
        }

        public async Task SendToInventory()
        {
            foreach (var itemEntry in ItemIndex.Values)
            {
                await ChangeContainer(
                    itemEntry.SlotId,
                    Owner.Inventory,
                    -1, 
                    itemEntry.Item.Amount
                );
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

        public async Task Save()
        {
            if (Owner != null && Owner.Socket != null)
            {
                Owner.Save();

                var containerParsed = SaveToModel();

                await Queue.EnqueueUpdateJobAsync(new JobData()
                {
                    Table = "container",
                    ContainerId = ContainerId,
                    CharacterId = Owner.CharacterId,
                    Set = !string.IsNullOrEmpty(containerParsed) ? containerParsed : "{}"
                });
            }
        }

    }

    public class LootRef
    {
        public int Chance { get; }
        public int AmountMin { get; }
        public int AmountMax { get; }

        public LootRef(int chance, int amountMin, int amountMax)
        {
            Chance = chance;
            AmountMin = amountMin;
            AmountMax = amountMax;
        }
    }


    public class Loot: Container
    {
        private readonly Dictionary<Type, LootRef> DropsPossibility = new Dictionary<Type, LootRef>();

        public Loot(Entity owner, string containerId = null): base(owner, containerId) {}

        public void DropChance(Type cls, int chance, int amountMin, int amountMax = 1)
        {
            if (cls != null)            
                DropsPossibility[cls] = new LootRef(chance, amountMin, amountMax);
        }

        public async Task GenerateLoot(Player player)
        {
            if (player != null && player.Socket != null)
            {
                foreach (var kvp in DropsPossibility)
                {
                    var lootRef = kvp.Value;
                    var itemType = kvp.Key;

                    if (RandomHelper.DropChance(lootRef.Chance))
                    {
                        var baseItem = Items.CreateItemByClass(itemType);
                        var amount = RandomHelper.MinMaxInt(lootRef.AmountMin, lootRef.AmountMax);

                        var itemRef = await Repository.CreateItem(
                            ContainerId,
                            Owner.Id,
                            baseItem.Namespace,
                            amount,
                            "loot",
                            null,
                            baseItem.Serialize()
                        );

                        if (baseItem is Equipament)                        
                            Packet.Get(ServerPacketType.Tooltip).Send(player, itemRef, baseItem.Serialize());
                        
                        await AddItem(itemRef, amount);
                        Containers.Set(ContainerId, this);
                    }
                }
            }
        }

        public void SetBaseType(DefaultLootType type)
        {
            switch (type)
            {
                case DefaultLootType.Poor:
                    //DropChance(typeof(GoldCoin), 100, 11, 20);
                    //DropChance(LootPack.GetMagicItemsPoor(), 2, 1); // 0.02% chance convertido para 2%
                    //DropChance(LootPack.GetInstruments(), 2, 1); // 0.02% chance convertido para 2%
                break;
            }
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
                            items[slotId]["slotId"] = int.Parse(slotId);
                            itemsParsed.Add(items[slotId]);
                        }
                    }
                    catch {}
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
