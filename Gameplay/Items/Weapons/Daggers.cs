namespace Server.Gameplay.Items
{
    public class AncientDagger : Weapon
    {
        public override string Namespace => "AncientUndeadDagger";
        public override string Name => "Ancient Dagger";
        public override string Alias => "AncientDagger";
        public override WeaponType WeaponType => WeaponType.Dagger;
        public override Dices Damage => Dices.D5D4;
        public override float AttackSpeed => 0.8f;
        public override EquipmentTier Tier => EquipmentTier.T5;
        public override int GoldCost => 3000;
        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Attack Speed", "0.8s" },
            { "Damage", "4D4" },
            { "Durability", "+125" },
            { "Attributes", "4" },
            { "Max Slots", "0-3" }
        };
    }

    public class CurvedDagger : Weapon
    {
        public override string Namespace => "SM_wp_dagger_01";
        public override string Name => "Curved Dagger";
        public override string Alias => "CurvedDagger";
        public override WeaponType WeaponType => WeaponType.Dagger;
        public override Dices Damage => Dices.D4D4;
        public override float AttackSpeed => 0.9f;
        public override EquipmentTier Tier => EquipmentTier.T4;
        public override int GoldCost => 2000;
        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "4" },
            { "Attack Speed", "0.9s" },
            { "Damage", "3D4" },
            { "Durability", "+75" },
            { "Attributes", "3-4" },
            { "Max Slots", "0-2" }
        };
    }

    public class Dagger : Weapon
    {
        public override string Namespace => "SM_wp_1h_sword_05";
        public override string Name => "Dagger";
        public override string Alias => "Dagger";
        public override WeaponType WeaponType => WeaponType.Dagger;
        public override Dices Damage => Dices.D1D4;
        public override float AttackSpeed => 1;
        public override EquipmentTier Tier => EquipmentTier.T1;
        public override int GoldCost => 300;
        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "1" },
            { "Attack Speed", "1s" },
            { "Damage", "1D4" },
            { "Durability", "+25" },
            { "Attributes", "1" }
        };
    }

    public class SacrificialDagger : Weapon
    {
        public override string Namespace => "SM_wp_sword_04";
        public override string Name => "Sacrificial Dagger";
        public override string Alias => "SacrificialDagger";
        public override WeaponType WeaponType => WeaponType.Dagger;
        public override Dices Damage => Dices.D3D4;
        public override float AttackSpeed => 0.8f;
        public override EquipmentTier Tier => EquipmentTier.T3;
        public override int GoldCost => 1200;
        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Attack Speed", "0.8s" },
            { "Damage", "3D4" },
            { "Durability", "+50" },
            { "Attributes", "2-4" },
            { "Max Slots", "0-1" }
        };
    }

    public class SurvivalKnife : Weapon
    {
        public override string Namespace => "SM_wp_1h_sword_01";
        public override string Name => "Survival Knife";
        public override string Alias => "SurvivalKnife";
        public override WeaponType WeaponType => WeaponType.Dagger;
        public override Dices Damage => Dices.D3D4;
        public override float AttackSpeed => 0.8f;
        public override EquipmentTier Tier => EquipmentTier.T3;
        public override int GoldCost => 1200;
        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Attack Speed", "0.8s" },
            { "Damage", "3D4" },
            { "Durability", "+50" },
            { "Attributes", "2-4" },
            { "Max Slots", "0-1" }
        };
    }

    public class Toothpick : Weapon
    {
        public override string Namespace => "dagger_1";
        public override string Name => "Toothpick";
        public override string Alias => "Toothpick";
        public override WeaponType WeaponType => WeaponType.Dagger;
        public override Dices Damage => Dices.D2D4;
        public override float AttackSpeed => 0.9f;
        public override EquipmentTier Tier => EquipmentTier.T2;
        public override int GoldCost => 600;
        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Attack Speed", "0.9s" },
            { "Damage", "2D4" },
            { "Durability", "+35" },
            { "Attributes", "1" }
        };
    }
}
