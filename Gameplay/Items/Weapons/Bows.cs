namespace Server.Gameplay.Items
{
    public class AshwoodBow : Weapon
    {
        public override string Namespace => "Bow-Long_1";
        public override string Name => "Ashwood Bow";
        public override string Alias => "AshwoodBow";
        public override WeaponType WeaponType => WeaponType.Bow;
        public override Dices Damage => Dices.D1D6;
        public override float AttackSpeed => 0.9f;
        public override float Weight => 2;
        public override EquipmentTier Tier => EquipmentTier.T1;
        public override int GoldCost => 300;
        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "1" },
            { "Attack Speed", "0.9s" },
            { "Damage", "1D6" },
            { "Attributes", "1" }
        };
    }

    public class BonecosRevenge : Weapon
    {
        public override string Namespace => "ArzaonLongBow2";
        public override string Name => "Boneco's Revenge";
        public override string Alias => "BonecosRevenge";
        public override WeaponType WeaponType => WeaponType.Bow;
        public override Dices Damage => Dices.D6D6;
        public override float AttackSpeed => 0.7f;
        public override float Weight => 2;
        public override EquipmentTier Tier => EquipmentTier.T5;
        public override int GoldCost => 3000;
        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Attack Speed", "0.7s" },
            { "Damage", "6D6" },
            { "Attributes", "4" },
            { "Max Slots", "0-3" }
        };
    }

    public class CompositeBow : Weapon
    {
        public override string Namespace => "Bow-Composite_1";
        public override string Name => "Composite Bow";
        public override string Alias => "CompositeBow";
        public override WeaponType WeaponType => WeaponType.Bow;
        public override Dices Damage => Dices.D2D6;
        public override float AttackSpeed => 0.9f;
        public override EquipmentTier Tier => EquipmentTier.T2;
        public override int GoldCost => 600;
        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Attack Speed", "0.9s" },
            { "Damage", "2D6" },
            { "Attributes", "1-2" }
        };
    }

    public class CompoundBow : Weapon
    {
        public override string Namespace => "ArzaonShortBow";
        public override string Name => "Compound Bow";
        public override string Alias => "CompoundBow";
        public override WeaponType WeaponType => WeaponType.Bow;
        public override Dices Damage => Dices.D2D6;
        public override float AttackSpeed => 0.8f;
        public override EquipmentTier Tier => EquipmentTier.T2;
        public override int GoldCost => 600;
        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Attack Speed", "0.8s" },
            { "Damage", "2D6" },
            { "Attributes", "1-2" }
        };
    }

    public class EagleStrike : Weapon
    {
        public override string Namespace => "Bow-Elf_1";
        public override string Name => "Eagle Strike";
        public override string Alias => "EagleStrike";
        public override WeaponType WeaponType => WeaponType.Bow;
        public override Dices Damage => Dices.D5D6;
        public override float AttackSpeed => 1.2f;
        public override EquipmentTier Tier => EquipmentTier.T4;
        public override int GoldCost => 2000;
        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "4" },
            { "Attack Speed", "1.2s" },
            { "Damage", "5D6" },
            { "Attributes", "3-4" },
            { "Max Slots", "0-2" }
        };
    }

    public class EbonFlatbow : Weapon
    {
        public override string Namespace => "Bow-Orc_1";
        public override string Name => "Ebon Flatbow";
        public override string Alias => "EbonFlatbow";
        public override WeaponType WeaponType => WeaponType.Bow;
        public override Dices Damage => Dices.D4D6;
        public override float AttackSpeed => 1.0f;
        public override EquipmentTier Tier => EquipmentTier.T4;
        public override int GoldCost => 2000;
        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "4" },
            { "Attack Speed", "1s" },
            { "Damage", "4D6" },
            { "Attributes", "3-4" },
            { "Max Slots", "0-2" }
        };
    }

    public class LongBow : Weapon
    {
        public override string Namespace => "ArzaonLongBow";
        public override string Name => "Long Bow";
        public override string Alias => "LongBow";
        public override WeaponType WeaponType => WeaponType.Bow;
        public override Dices Damage => Dices.D1D6;
        public override float AttackSpeed => 1.0f;
        public override EquipmentTier Tier => EquipmentTier.T1;
        public override int GoldCost => 300;
        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "1" },
            { "Attack Speed", "1s" },
            { "Damage", "1D6" },
            { "Attributes", "1" }
        };
    }

    public class Quillshooter : Weapon
    {
        public override string Namespace => "ArzaonLongBow2";
        public override string Name => "Quillshooter";
        public override string Alias => "Quillshooter";
        public override WeaponType WeaponType => WeaponType.Bow;
        public override Dices Damage => Dices.D3D6;
        public override float AttackSpeed => 0.9f;
        public override EquipmentTier Tier => EquipmentTier.T3;
        public override int GoldCost => 1200;
        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Attack Speed", "0.9s" },
            { "Damage", "3D6" },
            { "Attributes", "2-3" },
            { "Max Slots", "0-1" }
        };
    }

    public class RecurveBow : Weapon
    {
        public override string Namespace => "ArzaonShortBow2";
        public override string Name => "Recurve Bow";
        public override string Alias => "RecurveBow";
        public override WeaponType WeaponType => WeaponType.Bow;
        public override Dices Damage => Dices.D2D6;
        public override float AttackSpeed => 0.8f;
        public override EquipmentTier Tier => EquipmentTier.T2;
        public override int GoldCost => 600;
        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Attack Speed", "0.8s" },
            { "Damage", "2D6" },
            { "Attributes", "1-2" }
        };
    }

    public class RougeBow : Weapon
    {
        public override string Namespace => "SM_wp_bow_01_rouge";
        public override string Name => "Rouge Bow";
        public override string Alias => "RougeBow";
        public override WeaponType WeaponType => WeaponType.Bow;
        public override Dices Damage => Dices.D3D6;
        public override float AttackSpeed => 0.6f;
        public override EquipmentTier Tier => EquipmentTier.T3;
        public override int GoldCost => 1200;
        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Attack Speed", "0.6s" },
            { "Damage", "3D6" },
            { "Attributes", "2-3" },
            { "Max Slots", "0-1" }
        };
    }

    public class ShortBow : Weapon
    {
        public override string Namespace => "Bow-Short_1";
        public override string Name => "Short Bow";
        public override string Alias => "ShortBow";
        public override WeaponType WeaponType => WeaponType.Bow;
        public override Dices Damage => Dices.D1D4;
        public override float AttackSpeed => 0.8f;
        public override EquipmentTier Tier => EquipmentTier.T0;
        public override int GoldCost => 100;
        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "0" },
            { "Attack Speed", "0.8s" },
            { "Damage", "1D4" },
            { "Attributes", "1" }
        };
    }

    public class WarpBow : Weapon
    {
        public override string Namespace => "Bow-Goblin_1";
        public override string Name => "Warp Bow";
        public override string Alias => "WarpBow";
        public override WeaponType WeaponType => WeaponType.Bow;
        public override Dices Damage => Dices.D1D6;
        public override float AttackSpeed => 0.8f;
        public override EquipmentTier Tier => EquipmentTier.T1;
        public override int GoldCost => 300;
        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "1" },
            { "Attack Speed", "0.8s" },
            { "Damage", "1D6" },
            { "Attributes", "1" }
        };
    }

    public class Windbreaker : Weapon
    {
        public override string Namespace => "SM_wp_bow_01";
        public override string Name => "Windbreaker";
        public override string Alias => "Windbreaker";
        public override WeaponType WeaponType => WeaponType.Bow;
        public override Dices Damage => Dices.D6D6;
        public override float AttackSpeed => 0.7f;
        public override EquipmentTier Tier => EquipmentTier.T5;
        public override int GoldCost => 3000;
        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Attack Speed", "0.7s" },
            { "Damage", "6D6" },
            { "Attributes", "4" },
            { "Max Slots", "0-3" }
        };
    }
}
