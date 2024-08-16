using Newtonsoft.Json;

namespace Server
{
    public class Items
    {
        public static Dictionary<string, Type> BaseItems { get; private set; } = new Dictionary<string, Type>();
        public static Dictionary<string, Item> CachedItems { get; private set; } = new Dictionary<string, Item>();

        public static void Init()
        {
            foreach (Type t in Namespaces.GetTypesInNamespace("Server.Gameplay.Items"))
            {
                if (!t.IsAbstract && Activator.CreateInstance(t) is Item item)
                    AddBaseItem(item.Namespace, t);
            }
        }

        public static void AddBaseItem(string[] refs, Type clas)
        {
            foreach (var ns in refs)
            {
                if (ns != null)
                {
                    BaseItems[ns] = clas;
                    BaseItems[ns.ToLower()] = clas;
                }
            }
        }

        public static void AddBaseItem(string ns, Type clas)
        {
            if(ns != null)
            {
                BaseItems[ns] = clas;
                BaseItems[ns.ToLower()] = clas;
            }
        }

        public static Type FindBaseItemByNamespace(string ns)
        {
            return BaseItems.ContainsKey(ns) ? BaseItems[ns] : null;
        }

        public static Item LoadFromDatabase(string ns, string refId, Dictionary<string, object> props)
        {
            var baseItem = FindBaseItemByNamespace(ns);

            if (baseItem != null)
            {
                var item = (Item)Activator.CreateInstance(baseItem);
                item.Ref = refId;

                if (props != null)
                {
                    //Console.WriteLine($"{item.Name}: {item.Ref}");

                    foreach (var key in props.Keys)
                    {
                        if (key != "Attr" && key != "Cards" && key != "Flags" && props[key].ToString() != "[object Object]")
                        {
                            var propertyInfo = item.GetType().GetProperty(key);
                            if (propertyInfo != null && propertyInfo.CanWrite)
                                propertyInfo.SetValue(item, props[key]);
                        }
                    }

                    if (props.ContainsKey("Attr") && props["Attr"] is List<object> attrs && item is Equipament equip)
                    {
                        foreach (var attrObj in attrs)
                        {
                            if (attrObj is Dictionary<string, object> attrDict &&
                                attrDict.ContainsKey("type") &&
                                attrDict.ContainsKey("value"))
                            {
                                var type = (AttributeType)Convert.ToInt32(attrDict["type"]);
                                var value = Convert.ToInt32(attrDict["value"]);
                                equip.Attrs.Add(type, value);
                            }
                        }
                    }

                    if (props.ContainsKey("Cards") && props["Cards"] is List<string> cards && item is Equipament equipCards)
                    {
                        foreach (var card in cards)
                            equipCards.Cards.Add(card);
                    }

                    if (props.ContainsKey("Flags"))
                        item.Flags = new StateFlags((int)props["Flags"]);

                    item.Amount = Math.Max(item.Amount, 1);
                    item.UpdateGoldCost();
                }

                return item;
            }

            return null;
        }

        public static bool HasItemBase(string baseItemName)
        {
            return BaseItems.ContainsKey(baseItemName);
        }

        public static Type GetItemBase(string baseItemName)
        {
            return BaseItems.ContainsKey(baseItemName) ? BaseItems[baseItemName] : null;
        }

        public static Item CreateItem(string baseItemName, Dictionary<string, object> attrs, string createBy = "")
        {
            if (BaseItems.ContainsKey(baseItemName))
            {
                var baseType = BaseItems[baseItemName];
                var item = (Item)Activator.CreateInstance(baseType);

                if (item is PowerScroll powerScroll)
                {
                    powerScroll.GenerateAttrs();
                }
                else
                {
                    item.GenerateAttrs();
                    item.GenerateRandomAttrs();
                    item.UpdateGoldCost();
                    item.CraftBy = createBy;
                }

                return item;
            }

            return null;
        }

        public static Item CreateItemByClass(Type cls, string createBy = "")
        {
            var item = (Item)Activator.CreateInstance(cls);
            item.GenerateAttrs();
            item.GenerateRandomAttrs();
            item.UpdateGoldCost();
            item.CraftBy = createBy;
            return item;
        }

        public static Item ItemFromDatabase(ItemEntity data)
        {
            try
            {
                var itemName = data.ItemName;
                var amount = data.Amount;
                var refId = data.Id;
                Dictionary<string, object> props = null;
                var containerId = data.ContainerId;

                if (data.Props is string jsonProps)                
                    props = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonProps);
                
                var item = LoadFromDatabase(itemName, refId, props);

                if (item != null)
                {
                    item.ContainerId = containerId;

                    if (amount > 1 && item is Stackable stackableItem)
                        stackableItem.Amount = amount;

                    CachedItems[refId] = item;
                }

                return item;
            }
            catch
            {
                return null;
            }
        }

        public static bool HasItem(string refId)
        {
            return CachedItems.ContainsKey(refId);
        }

        public static Item GetItemByRef(string refId)
        {
            return CachedItems.ContainsKey(refId) ? CachedItems[refId] : null;
        }

        public static void SetItem(string refId, Item item)
        {
            CachedItems[refId] = item;
        }

        public static void RemoveItem(string refId)
        {
            CachedItems.Remove(refId);
        }

        public static async Task ReduceDurability(string refId, Player owner)
        {
            if (CachedItems.ContainsKey(refId))
            {
                var item = CachedItems[refId];
                var chanceReduce = new Random().Next(1, 11);

                if (item is Equipament equipament && chanceReduce == 1)
                {
                    var newDurability = Math.Max(equipament.Durability - 1, 0);
                    equipament.SetDurability(newDurability, equipament.MaxDurability);

                    if (newDurability <= 0)
                        equipament.Flags.AddFlag(ItemStates.Broken);

                    var props = equipament.Serialize();

                    await Queue.EnqueueUpdateJobAsync(new JobData()
                    {
                        Table = "item",
                        Id = item.Ref,
                        Set = new Dictionary<string, object> { { "props", props } }
                    });

                    CachedItems[refId] = equipament;
                    Packet.Get(ServerPacketType.Tooltip).Send(owner, item.Ref, props);
                }
            }
        }
    }

    public abstract class Item: IComparable<Item>
    {
        public static readonly List<AttributeType> AttrsEquipments = new List<AttributeType>
        {
            AttributeType.BonusDex, AttributeType.BonusInt, AttributeType.BonusLife,
            AttributeType.BonusMana, AttributeType.BonusSpeed, AttributeType.BonusStam,
            AttributeType.BonusStr, AttributeType.CastSpeed, AttributeType.CooldownReduction,
            AttributeType.CriticalChance, AttributeType.DamageReduction, AttributeType.DodgeChance,
            AttributeType.HealthRegen, AttributeType.ManaRegen, AttributeType.StaminaRegen,
            AttributeType.LowerManaCost, AttributeType.IncreasedKarmaLoss,
            AttributeType.Luck, AttributeType.ReflectPhysical, AttributeType.ReflectSpell,
            AttributeType.BonusAgi, AttributeType.BonusVig, AttributeType.BonusLuc
        };

        public static readonly List<AttributeType> AttrsAccessories = new List<AttributeType>
        {
            AttributeType.HealthRegen, AttributeType.ManaRegen, AttributeType.StaminaRegen,
            AttributeType.BonusDex, AttributeType.BonusInt, AttributeType.BonusLife,
            AttributeType.BonusAgi, AttributeType.BonusVig, AttributeType.BonusLuc
        };

        public static readonly List<AttributeType> AttrsWeapon = new List<AttributeType>
        {
            AttributeType.HealthRegen, AttributeType.ManaRegen, AttributeType.StaminaRegen,
            AttributeType.BonusDex, AttributeType.BonusInt, AttributeType.BonusLife,
            AttributeType.BonusAgi, AttributeType.BonusVig, AttributeType.BonusLuc,
            AttributeType.BonusDamage, AttributeType.BonusMagicDamage,
            AttributeType.CriticalDamage, AttributeType.FasterCasting,
            AttributeType.SpellDamage, AttributeType.FireDamage,
            AttributeType.ColdDamage, AttributeType.PoisonDamage,
            AttributeType.EnergyDamage, AttributeType.LightDamage,
            AttributeType.DarkDamage
        };

        public static readonly List<AttributeType> AttrsWeaponWithoutElementalDamage = new List<AttributeType>
        {
            AttributeType.HealthRegen, AttributeType.ManaRegen, AttributeType.StaminaRegen,
            AttributeType.BonusDex, AttributeType.BonusInt, AttributeType.BonusLife,
            AttributeType.BonusAgi, AttributeType.BonusVig, AttributeType.BonusLuc,
            AttributeType.BonusDamage, AttributeType.BonusMagicDamage,
            AttributeType.CriticalDamage, AttributeType.FasterCasting,
            AttributeType.SpellDamage
        };

        public virtual string Namespace { get; set; }
        public virtual string Name { get; set; }
        public virtual string ContainerId { get; set; }
        public virtual int Amount { get; set; } = 1;
        public virtual ItemRarity Rarity { get; set; } = ItemRarity.Common;
        public virtual string Ref { get; set; }
        public virtual double Weight { get; set; } = 0.1;
        public virtual int Hue { get; set; }
        public virtual StateFlags Flags { get; set; } = new StateFlags(ItemStates.None);
        public virtual int GoldCost { get; set; } = 0;
        public virtual string CraftBy { get; set; }
        public Dictionary<string, string> CraftingInfo { get; set; } = new Dictionary<string, string>();


        public int CompareTo(Item other)
        {
            return Ref.CompareTo(other.Ref);
        }

        protected int GetRandomIntInRange(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public Item CreateItem(string itemName)
        {
            var baseItem = Items.FindBaseItemByNamespace(itemName);

            if (baseItem != null)
            {
                var newItem = (Item)Activator.CreateInstance(baseItem.GetType());
                newItem.GenerateAttrs();
                newItem.GenerateRandomAttrs();
                newItem.UpdateGoldCost();
                return newItem;
            }

            return null;
        }

        public void UpdateGoldCost()
        {
            switch (Rarity)
            {
                case ItemRarity.Uncommon:
                    GoldCost += (int)Math.Round(GoldCost * 0.3);
                    break;
                case ItemRarity.Rare:
                    GoldCost += (int)Math.Round(GoldCost * 0.5);
                    break;
                case ItemRarity.Magic:
                    GoldCost += (int)Math.Round(GoldCost * 0.8);
                    break;
                case ItemRarity.Legendary:
                    GoldCost += GoldCost;
                    break;
            }

            if (Flags.HasFlag(ItemStates.Exceptional))
                GoldCost += (int)Math.Round(GoldCost * 0.15);

            if (Flags.HasFlag(ItemStates.Insured))
                GoldCost += GoldCost;

            if (Flags.HasFlag(ItemStates.Blessed))
                GoldCost += GoldCost * 5;

            if (Flags.HasFlag(ItemStates.Broken))
                GoldCost = 1;
        }

        public virtual void GenerateAttrs() { }
        public virtual void GenerateRandomAttrs() { }

        public void SetInsured()
        {
            Flags.AddFlag(ItemStates.Insured);
        }

        public void RemoveInsured()
        {
            Flags.RemoveFlag(ItemStates.Insured);
        }

        public void SetBlessed()
        {
            Flags.AddFlag(ItemStates.Blessed);
        }

        public virtual object Serialize()
        {
            return new
            {
                Rarity,
                Hue,
                Flags = Flags.GetCurrentFlags(),
                CraftBy
            };
        }
    }

    public abstract class Stackable : Item
    {
        public void SetAmount(int amount)
        {
            if (amount > 0)
            {
                Amount = amount;
            }
        }

        public override object Serialize()
        {
            var data = base.Serialize() as Dictionary<string, object>;

            if (data != null)            
                data["Amount"] = this.Amount;
            
            return data;
        }
    }

    public abstract class Resource : Stackable { }

    public abstract class Consumable : Resource
    {
        public virtual async Task Use(Entity entity) { await Task.CompletedTask; }

        public void PlayAnimation(Entity owner, int index)
        {
            Packet.Get(ServerPacketType.PlayMontage).Send(owner, owner, index);

            foreach (var entity in owner.AreaOfInterest)            
                Packet.Get(ServerPacketType.PlayMontage).Send(owner, entity, index);
        }

        public async Task ExecActionInterval(int ticks, int delay, Action<Consumable> cb)
        {
            for (int i = 0; i < ticks; i++)
            {
                await Task.Delay(delay);
                cb(this);
            }
        }
    }
}
