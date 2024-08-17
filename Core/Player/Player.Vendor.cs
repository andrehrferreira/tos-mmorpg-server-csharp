namespace Server
{
    public partial class Player : Humanoid
    {
        public int GetGoldCoins()
        {
            var goldCoin = Inventory.GetItemByNamespace("GoldCoin");
            return goldCoin != null ? goldCoin.Amount : 0;
        }

        public async Task<bool> RemoveGoldCoins(int amount)
        {
            var goldCoin = Inventory.GetItemByNamespace("GoldCoin");
            var slot = Inventory.GetSlotByItemNamespace("GoldCoin");

            if (goldCoin != null && goldCoin.Amount >= amount && slot != -1)
            {
                await Inventory.ChangeAmount(slot, goldCoin.Amount - amount);
                return true;
            }

            return false;
        }

        public async Task<bool> RemoveItem(string itemRef, int amount)
        {
            var item = Inventory.GetItem(itemRef);
            var slot = Inventory.GetSlotByRef(itemRef);

            if (item != null && item.Amount == 1 && slot != -1)
            {
                await Inventory.RemoveItem(itemRef);
                return true;
            }
            else if (item != null && item.Amount >= amount && slot != -1)
            {
                await Inventory.ChangeAmount(slot, item.Amount - amount);
                return true;
            }

            return false;
        }

        public async Task BuyItem(string itemNamespace, int amount)
        {
            try
            {
                if (VendorList != null)
                {
                    foreach (var vendorItem in VendorList.Data)
                    {
                        if (vendorItem.Namespace == itemNamespace)
                        {
                            var totalCost = vendorItem.Price * amount;
                            var playerGoldCoins = GetGoldCoins();
                            var baseItemType = Items.GetItemBase(vendorItem.Namespace);

                            if (baseItemType != null)
                            {
                                var baseItem = Activator.CreateInstance(baseItemType) as Item;

                                if (totalCost <= playerGoldCoins && baseItem != null)
                                {
                                    if (await RemoveGoldCoins(totalCost))
                                    {
                                        if (baseItem is Stackable)
                                        {
                                            var itemRef = await Repository.CreateItem(
                                                Inventory.ContainerId,
                                                CharacterId,
                                                baseItem.Namespace,
                                                amount,
                                                "buy",
                                                null,
                                                baseItem.Serialize()
                                            );

                                            GainSkillExperience(SkillName.Diplomacy);

                                            var item = Items.GetItemByRef(itemRef);
                                            Packet.Get(ServerPacketType.SystemMessage).Send(Socket, $"You received +{amount} {baseItem.Name}");
                                            await Inventory.AddItem(itemRef, amount, -1);

                                            if (baseItem is Equipament)                                            
                                                Packet.Get(ServerPacketType.Tooltip).Send(this, itemRef, item.Serialize());                                            
                                        }
                                        else
                                        {
                                            for (int i = 0; i < amount; i++)
                                            {
                                                var itemRef = await Repository.CreateItem(
                                                    Inventory.ContainerId,
                                                    CharacterId,
                                                    baseItem.Namespace,
                                                    1,
                                                    "buy",
                                                    null,
                                                    baseItem.Serialize()
                                                );

                                                var item = Items.GetItemByRef(itemRef);
                                                Packet.Get(ServerPacketType.SystemMessage).Send(Socket, $"You received +1 {baseItem.Name}");
                                                await Inventory.AddItem(itemRef, 1);

                                                if (baseItem is Equipament)                                                
                                                    Packet.Get(ServerPacketType.Tooltip).Send(this, itemRef, item.Serialize());                                                
                                            }

                                            GainSkillExperience(SkillName.Diplomacy);
                                        }

                                        Save();
                                        await SaveToDatabase();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch {}
        }

        public async Task SellItem(string itemRef, int amount = 1)
        {
            try
            {
                var item = Inventory.GetItem(itemRef);

                if (item != null)
                {
                    var totalGainGold = item.GoldCost * amount;

                    if (await RemoveItem(itemRef, amount))
                    {
                        await AddItem("GoldCoin", totalGainGold, "sell");
                        Save();
                        await SaveToDatabase();
                    }
                }
            }
            catch {}
        }

        public async Task AddItem(string baseItemName, int amount = 1, string context = "add")
        {
            var baseItemCls = Items.GetItemBase(baseItemName);

            if (baseItemCls != null)
            {
                var baseItem = Activator.CreateInstance(baseItemCls) as Item;
                var hasStackableItem = Inventory.HasStackableItem(baseItem);
                object props = null;

                if (baseItem is Equipament || baseItem is PowerScroll || baseItem is PetItem || baseItem is MountItem)                
                    props = baseItem.Serialize();
                
                var itemRef = await Repository.CreateItem(
                    Inventory.ContainerId,
                    CharacterId,
                    baseItem.Namespace,
                    amount,
                    context,
                    null,
                    props,
                    hasStackableItem == -1
                );

                var item = Items.GetItemByRef(itemRef);
                Packet.Get(ServerPacketType.SystemMessage).Send(Socket, $"You received +{amount} {baseItem.Name}");
                await Inventory.AddItem(itemRef, amount, -1);

                Save();
                await SaveToDatabase();

                if (item is Equipament || item is PowerScroll || item is PetItem || item is MountItem)                
                    Packet.Get(ServerPacketType.Tooltip).Send(this, itemRef, item.Serialize());                
            }
        }

        public async Task AddItemByClass(Type cls, int amount, string context = "add")
        {
            if (cls != null)
            {
                var baseItem = Activator.CreateInstance(cls) as Item;

                if (baseItem is PowerScroll powerScroll)
                {
                    powerScroll.GenerateAttrs();
                }
                else if (baseItem is Equipament equipament)
                {
                    equipament.GenerateAttrs();
                    equipament.GenerateRandomAttrs();
                    equipament.UpdateGoldCost();
                }

                var itemRef = await Repository.CreateItem(
                    Inventory.ContainerId,
                    CharacterId,
                    baseItem.Namespace,
                    amount,
                    context,
                    null,
                    baseItem.Serialize()
                );

                var item = Items.GetItemByRef(itemRef);
                Packet.Get(ServerPacketType.SystemMessage).Send(Socket, $"You received +{amount} {baseItem.Name}");
                await Inventory.AddItem(itemRef, amount, -1);

                Save();
                await SaveToDatabase();

                if (item is Equipament || item is PowerScroll || item is PetItem || item is MountItem)
                    Packet.Get(ServerPacketType.Tooltip).Send(this, itemRef, item.Serialize());                
            }
        }
    }
}
