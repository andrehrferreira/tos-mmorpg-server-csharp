namespace Server.Gameplay.Items
{
    public class SilverRing : Ring
    {
        public override string Namespace => "SilverRing";
        public override string Name => "Silver Ring";
        public override float Weight => 1f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 1;
        public override EquipmentTier Tier => EquipmentTier.T0;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "0" },
            { "Attributes", "1" }
        };
    }

    public class RubySilverRing : Ring
    {
        public override string Namespace => "RubySilverRing";
        public override string Name => "Ruby Silver Ring";
        public override float Weight => 1f;
        public override int GoldCost => 800;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T1;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "1" },
            { "Attributes", "1-2" },
            { "Bonus Damage", "2-10" }
        };

        public override void GenerateAttrs()
        {
            base.GenerateAttrs();
            SetAttr(AttributeType.BonusDamage, RandomHelper.MinMaxInt(2, 10));
        }
    }

    public class SilverAndDiamondRing : Ring
    {
        public override string Namespace => "SilverAndDiamondRing";
        public override string Name => "Silver And Diamond Ring";
        public override float Weight => 1f;
        public override int GoldCost => 1200;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Attributes", "1-2" },
            { "Cold Resistence", "2-10" },
            { "Poison Resistence", "2-10" },
            { "Fire Resistence", "2-10" },
            { "Energy Resistence", "2-10" }
        };

        public override void GenerateAttrs()
        {
            base.GenerateAttrs();
            SetColdResistence(RandomHelper.MinMaxInt(2, 10));
            SetPoisonResistence(RandomHelper.MinMaxInt(2, 10));
            SetFireResistence(RandomHelper.MinMaxInt(2, 10));
            SetEnergyResistence(RandomHelper.MinMaxInt(2, 10));
        }
    }

    public class SunstoneSilverRing : Ring
    {
        public override string Namespace => "SunstoneSilverRing";
        public override string Name => "Sunstone Silver Ring";
        public override float Weight => 1f;
        public override int GoldCost => 1200;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Attributes", "1-2" },
            { "Bonus Magic Damage", "2-10" }
        };

        public override void GenerateAttrs()
        {
            base.GenerateAttrs();
            SetAttr(AttributeType.BonusMagicDamage, RandomHelper.MinMaxInt(2, 10));
        }
    }

    public class GoldRing : Ring
    {
        public override string Namespace => "GoldRing";
        public override string Name => "Gold Ring";
        public override float Weight => 1f;
        public override int GoldCost => 500;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Attributes", "1-2" }
        };
    }

    public class BoneRing : Ring
    {
        public override string Namespace => "BoneRing";
        public override string Name => "Bone Ring";
        public override float Weight => 1f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T1;
        public override ItemRarity Rarity => ItemRarity.Uncommon;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "1" },
            { "Attributes", "1-2" },
            { "Armor", "2" }
        };

        public override void GenerateAttrs()
        {
            base.GenerateAttrs();
            SetArmor(2);
        }
    }

    public class ArcherRing : Ring
    {
        public override string Namespace => "ArcherRing";
        public override string Name => "Archer Ring";
        public override float Weight => 1f;
        public override int GoldCost => 3000;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Stamina Regen", "10" },
            { "Bonus Dex", "10" }
        };

        public override void GenerateAttrs()
        {
            base.GenerateAttrs();
            SetAttr(AttributeType.StaminaRegen, 10);
            SetAttr(AttributeType.BonusDex, 10);
        }
    }

    public class WarriorRing : Ring
    {
        public override string Namespace => "WarriorRing";
        public override string Name => "Warrior Ring";
        public override float Weight => 1f;
        public override int GoldCost => 3000;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Health Regen", "10" },
            { "Bonus Str", "10" }
        };

        public override void GenerateAttrs()
        {
            base.GenerateAttrs();
            SetAttr(AttributeType.HealthRegen, 10);
            SetAttr(AttributeType.BonusStr, 10);
        }
    }

    public class WizardRing : Ring
    {
        public override string Namespace => "WizardRing";
        public override string Name => "Wizard Ring";
        public override float Weight => 1f;
        public override int GoldCost => 3000;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Mana Regen", "10" },
            { "Bonus Int", "10" }
        };

        public override void GenerateAttrs()
        {
            base.GenerateAttrs();
            SetAttr(AttributeType.ManaRegen, 10);
            SetAttr(AttributeType.BonusInt, 10);
        }
    }
}
