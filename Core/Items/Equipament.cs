namespace Server
{
    public abstract class Equipament : Item
    {
        public virtual EquipmentType EquipmentType { get; set; } = EquipmentType.None;
        public virtual EquipmentWeight EquipmentWeight { get; set; } = EquipmentWeight.Light;
        public virtual int MaxDurability { get; set; } = 25;
        public virtual int Durability { get; set; } = 25;
        public virtual int Armor { get; set; } = 0;
        public virtual int MaxAttrs { get; set; } = 0;
        public virtual EquipmentTier Tier { get; set; } = EquipmentTier.T1;

        // Resistences
        public virtual int FireResistence { get; set; } = 0;
        public virtual int ColdResistence { get; set; } = 0;
        public virtual int PoisonResistence { get; set; } = 0;
        public virtual int EnergyResistence { get; set; } = 0;
        public virtual int LightResistence { get; set; } = 0;
        public virtual int DarkResistence { get; set; } = 0;

        public virtual Dictionary<AttributeType, int> Attrs { get; set; } = new Dictionary<AttributeType, int>();

        // Card
        public virtual List<string> Cards { get; set; } = new List<string>();
        public virtual int MaxSlots { get; set; } = 3;
        public virtual int CardSlots { get; set; } = 0;

        public virtual void OnEquip(Humanoid entity) { }
        public virtual void OnDesequip(Humanoid entity) { }

        private void RemoveRandomAttributes(int count)
        {
            var attributes = Attrs.Keys.ToList();

            for (int i = 0; i < count; i++)
            {
                if (attributes.Count == 0)
                    break;

                int randomIndex = RandomHelper.MinMaxInt(0, attributes.Count - 1);
                var attributeToRemove = attributes[randomIndex];
                Attrs.Remove(attributeToRemove);
                attributes.RemoveAt(randomIndex);
            }
        }

        public int GetTierValueAttr()
        {
            return Tier switch
            {
                EquipmentTier.T0 => 1,
                EquipmentTier.T1 => RandomHelper.MinMaxInt(1, 5),
                EquipmentTier.T2 => RandomHelper.MinMaxInt(6, 10),
                EquipmentTier.T3 => RandomHelper.MinMaxInt(11, 15),
                EquipmentTier.T4 => RandomHelper.MinMaxInt(16, 20),
                EquipmentTier.T5 => RandomHelper.MinMaxInt(21, 25),
                _ => 0,
            };
        }

        public override void GenerateRandomAttrs()
        {
            int baseDurability = 25;
            int minAttrs = 1;

            switch (Tier)
            {
                case EquipmentTier.T2:
                    baseDurability += 10;
                    minAttrs = 1;
                    break;
                case EquipmentTier.T3:
                    baseDurability += 25;
                    minAttrs = 2;
                    break;
                case EquipmentTier.T4:
                    baseDurability += 50;
                    minAttrs = 3;
                    break;
                case EquipmentTier.T5:
                    baseDurability += 100;
                    minAttrs = 4;
                    break;
            }

            switch (Rarity)
            {
                case ItemRarity.Uncommon:
                    baseDurability += 20;
                    minAttrs++;
                    break;
                case ItemRarity.Rare:
                    baseDurability += 50;
                    if (minAttrs < 2) minAttrs = 2;
                    break;
                case ItemRarity.Magic:
                    baseDurability += 100;
                    if (minAttrs < 3) minAttrs = 3;
                    break;
                case ItemRarity.Legendary:
                    baseDurability += 100;
                    if (minAttrs < 4) minAttrs = 4;
                    break;
                case ItemRarity.Unique:
                    baseDurability += 300;
                    if (minAttrs < 4) minAttrs = 4;
                    break;
            }

            if (!(this is Tool))
            {
                minAttrs = Math.Min(minAttrs, 4);
                int attrsCounts = (MaxAttrs > minAttrs) ? RandomHelper.MinMaxInt(minAttrs, MaxAttrs) : minAttrs;
                Attrs.Clear();

                for (int i = 0; i < attrsCounts; i++)
                {
                    var attrType = (this is Weapon) ? RandomHelper.ArrRandom(AttrsWeapon) : RandomHelper.ArrRandom(AttrsEquipments);
                    int value = GetTierValueAttr();

                    if (!Attrs.ContainsKey(attrType))
                        Attrs.Add(attrType, value);
                    else
                        i--;
                }

                if (Flags.HasFlag(ItemStates.Exceptional))
                {
                    baseDurability += 50;
                    if (Armor > 0) Armor++;
                    if (FireResistence > 0) FireResistence++;
                    if (ColdResistence > 0) ColdResistence++;
                    if (PoisonResistence > 0) PoisonResistence++;
                    if (EnergyResistence > 0) EnergyResistence++;
                    if (LightResistence > 0) LightResistence++;
                    if (DarkResistence > 0) DarkResistence++;
                }

                SetDurability(Math.Min(baseDurability, 450));

                if (Tier >= EquipmentTier.T3 && MaxSlots > 0 && CardSlots <= 0)
                {
                    int slotChance = RandomHelper.MinMaxInt(0, 100);

                    if (slotChance <= 10)
                    {
                        int slotAmount = RandomHelper.MinMaxInt(1, MaxSlots);
                        RemoveRandomAttributes(slotAmount);
                        CardSlots = slotAmount;
                        Name = $"{Name} ({CardSlots})";
                    }
                }
                else if (CardSlots > 0)
                {
                    Name = $"{Name} ({CardSlots})";
                }
            }
        }

        public void RandomRarity(Player player)
        {
            int randomValue = RandomHelper.MinMaxInt(1, 1000);
            int randomValueExceptional = RandomHelper.MinMaxInt(1, 5);
            double luckFactor = Math.Min(player.Luc, 300) / 300.0;

            double legendaryChance = 0.02 * luckFactor;
            double magicChance = 0.05 * luckFactor;
            double rareChance = 0.10 * luckFactor;
            double uncommonChance = 0.5 * luckFactor;
            double commonChance = 1 - (legendaryChance + magicChance + rareChance + uncommonChance);

            randomValue += player.Luc * 3;

            if (randomValueExceptional == 1)
                Flags.AddFlag(ItemStates.Exceptional);

            if (randomValue <= 1000 * legendaryChance)
                Rarity = ItemRarity.Legendary;
            else if (randomValue <= 1000 * magicChance + 1000 * legendaryChance)
                Rarity = ItemRarity.Magic;
            else if (randomValue <= 1000 * rareChance + 1000 * magicChance + 1000 * legendaryChance)
                Rarity = ItemRarity.Rare;
            else if (randomValue <= 1000 * uncommonChance + 1000 * rareChance + 1000 * magicChance + 1000 * legendaryChance)
                Rarity = ItemRarity.Uncommon;
            else
                Rarity = ItemRarity.Common;

            GenerateRandomAttrs();
        }

        public void SetDurability(int newDurability, int maxDurability = 0)
        {
            MaxDurability = (maxDurability > 0) ? maxDurability : newDurability;
            Durability = newDurability;
        }

        public void SetArmor(int min, int max = 0)
        {
            Armor = (max > 0) ? RandomHelper.MinMaxInt(min, max) : min;
        }

        public void SetFireResistence(int min, int max = 0)
        {
            FireResistence = (max > 0) ? RandomHelper.MinMaxInt(min, max) : min;
        }

        public void SetColdResistence(int min, int max = 0)
        {
            ColdResistence = (max > 0) ? RandomHelper.MinMaxInt(min, max) : min;
        }

        public void SetPoisonResistence(int min, int max = 0)
        {
            PoisonResistence = (max > 0) ? RandomHelper.MinMaxInt(min, max) : min;
        }

        public void SetEnergyResistence(int min, int max = 0)
        {
            EnergyResistence = (max > 0) ? RandomHelper.MinMaxInt(min, max) : min;
        }

        public void SetLightResistence(int min, int max = 0)
        {
            LightResistence = (max > 0) ? RandomHelper.MinMaxInt(min, max) : min;
        }

        public void SetDarkResistence(int min, int max = 0)
        {
            DarkResistence = (max > 0) ? RandomHelper.MinMaxInt(min, max) : min;
        }

        public void SetAttr(AttributeType attributeType, int value)
        {
            Attrs[attributeType] = value;
        }

        public override Dictionary<string, object> Serialize()
        {
            var data = base.Serialize() as Dictionary<string, object>;
            data["MaxDurability"] = MaxDurability;
            data["Durability"] = Durability;
            data["Armor"] = Armor;
            data["FireResistence"] = FireResistence;
            data["ColdResistence"] = ColdResistence;
            data["PoisonResistence"] = PoisonResistence;
            data["EnergyResistence"] = EnergyResistence;
            data["LightResistence"] = LightResistence;
            data["DarkResistence"] = DarkResistence;
            data["Attr"] = Attrs.Select(kvp => new { Type = kvp.Key, Value = kvp.Value }).ToList();
            data["Weight"] = Weight;
            data["GoldCost"] = GoldCost;
            data["CardSlots"] = CardSlots;
            data["Cards"] = Cards;
            return data;
        }
    }

    public abstract class Offhand : Equipament
    {
        public override int MaxAttrs => 0;
        public override int MaxSlots => 1;
        public int BlockChance { get; private set; } = 0;

        public void SetBlockChance(int min, int max = 0)
        {
            BlockChance = (max > 0) ? GetRandomIntInRange(min, max) : min;
        }

        public override Dictionary<string, object> Serialize()
        {
            var data = base.Serialize();
            data["BlockChance"] = BlockChance;
            return data;
        }
    }
}
