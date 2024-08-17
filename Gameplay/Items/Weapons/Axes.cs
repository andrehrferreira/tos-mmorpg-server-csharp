namespace Server.Gameplay.Items
{
    public class AmortusDecapitator : Weapon
    {
        public override string Namespace => "SM_wp_blunt_2h";
        public override string Name => "Amortu's Decapitator";
        public override string Alias => "AmortusDecapitator";
        public override WeaponType WeaponType => WeaponType.Axe;
        public override Dices Damage => Dices.D5D10;
        public override float AttackSpeed => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;
        public override int GoldCost => 3000;
        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            {"Tier", "5"},
            {"Attack Speed", "4s"},
            {"Damage", "5D10"},
            {"Durability", "+125"},
            {"Attributes", "4"},
            {"Max Slots", "0-3"}
        };
    }

    public class CurvedHandleAxe : Weapon
    {
        public override string Namespace => "ArzaonAxe03";
        public override string Name => "Curved Handle Axe";
        public override string Alias => "CurvedHandleAxe";
        public override WeaponType WeaponType => WeaponType.Axe;
        public override Dices Damage => Dices.D2D6;
        public override float AttackSpeed => 3;
        public override EquipmentTier Tier => EquipmentTier.T2;
        public override int GoldCost => 600;
        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            {"Tier", "2"},
            {"Attack Speed", "3s"},
            {"Damage", "2D6"},
            {"Durability", "+35"},
            {"Attributes", "1-2"}
        };
    }

    public class DoubleAxe : Weapon
    {
        public override string Namespace => "ArzaonAxe07";
        public override string Name => "Double Axe";
        public override string Alias => "DoubleAxe";
        public override WeaponType WeaponType => WeaponType.TwoHandedAxe;
        public override Dices Damage => Dices.D4D10;
        public override float AttackSpeed => 4;
        public override EquipmentTier Tier => EquipmentTier.T4;
        public override int GoldCost => 2000;
        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            {"Tier", "4"},
            {"Attack Speed", "4s"},
            {"Damage", "4D10"},
            {"Durability", "+75"},
            {"Attributes", "3-4"},
            {"Max Slots", "0-2"}
        };
    }

    public class Hatchet : Weapon
    {
        public override string Namespace => "SM_wp_axe_01_a";
        public override string Name => "Hatchet";
        public override string Alias => "Hatchet";
        public override WeaponType WeaponType => WeaponType.Axe;
        public override Dices Damage => Dices.D1D6;
        public override float AttackSpeed => 3;
        public override EquipmentTier Tier => EquipmentTier.T1;
        public override int GoldCost => 300;
        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            {"Tier", "1"},
            {"Attack Speed", "3s"},
            {"Damage", "1D6"},
            {"Durability", "+25"},
            {"Attributes", "1"}
        };
    }

    public class HeavyOneHandedAxe : Weapon
    {
        public override string Namespace => "SM_wp_axe_1h_barber_02";
        public override string Name => "Heavy One-Handed Axe";
        public override string Alias => "HeavyOneHandedAxe";
        public override WeaponType WeaponType => WeaponType.Axe;
        public override Dices Damage => Dices.D2D6;
        public override float AttackSpeed => 3;
        public override EquipmentTier Tier => EquipmentTier.T2;
        public override int GoldCost => 600;
        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            {"Tier", "2"},
            {"Attack Speed", "3s"},
            {"Damage", "2D6"},
            {"Durability", "+35"},
            {"Attributes", "1-2"}
        };
    }

    public class HeavyOneHandedBrutalAxe : Weapon
    {
        public override string Namespace => "SM_wp_blunt_02_brutal";
        public override string Name => "Heavy One-Handed Brutal Axe";
        public override string Alias => "HeavyOneHandedBrutalAxe";
        public override WeaponType WeaponType => WeaponType.Axe;
        public override Dices Damage => Dices.D4D6;
        public override float AttackSpeed => 3;
        public override EquipmentTier Tier => EquipmentTier.T5;
        public override int GoldCost => 3000;
        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            {"Tier", "5"},
            {"Attack Speed", "3s"},
            {"Damage", "4D6"},
            {"Durability", "+125"},
            {"Attributes", "4"},
            {"Max Slots", "0-3"}
        };
    }

    public class LongAxe : Weapon
    {
        public override string Namespace => "ArzaonAxe02";
        public override string Name => "Long Axe";
        public override string Alias => "LongAxe";
        public override WeaponType WeaponType => WeaponType.TwoHandedAxe;
        public override Dices Damage => Dices.D2D10;
        public override float AttackSpeed => 4;
        public override EquipmentTier Tier => EquipmentTier.T2;
        public override int GoldCost => 600;
        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            {"Tier", "2"},
            {"Attack Speed", "4s"},
            {"Damage", "2D10"},
            {"Durability", "+35"},
            {"Attributes", "1-2"}
        };
    }

    public class LongHatchet : Weapon
    {
        public override string Namespace => "axe_4";
        public override string Name => "Long Hatchet";
        public override string Alias => "LongHatchet";
        public override WeaponType WeaponType => WeaponType.TwoHandedAxe;
        public override Dices Damage => Dices.D1D10;
        public override float AttackSpeed => 4;
        public override EquipmentTier Tier => EquipmentTier.T1;
        public override int GoldCost => 300;
        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            {"Tier", "1"},
            {"Attack Speed", "4s"},
            {"Damage", "1D10"},
            {"Durability", "+25"},
            {"Attributes", "1"}
        };
    }

    public class LongLumberjackAxe : Weapon
    {
        public override string Namespace => "ArzaonAxe06";
        public override string Name => "Long Lumberjack Axe";
        public override string Alias => "LongLumberjackAxe";
        public override WeaponType WeaponType => WeaponType.TwoHandedAxe;
        public override Dices Damage => Dices.D3D10;
        public override float AttackSpeed => 4;
        public override EquipmentTier Tier => EquipmentTier.T3;
        public override int GoldCost => 1200;
        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            {"Tier", "3"},
            {"Attack Speed", "4s"},
            {"Damage", "3D10"},
            {"Durability", "+50"},
            {"Attributes", "2-3"},
            {"Max Slots", "0-1"}
        };
    }

    public class LongSimpleAxe : Weapon
    {
        public override string Namespace => "axe_1";
        public override string Name => "Long Simple Axe";
        public override string Alias => "LongSimpleAxe";
        public override WeaponType WeaponType => WeaponType.TwoHandedAxe;
        public override Dices Damage => Dices.D1D10;
        public override float AttackSpeed => 4;
        public override EquipmentTier Tier => EquipmentTier.T1;
        public override int GoldCost => 300;
        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            {"Tier", "1"},
            {"Attack Speed", "4s"},
            {"Damage", "1D10"},
            {"Durability", "+25"},
            {"Attributes", "1"}
        };
    }

    public class OneHandedBarbedAxe : Weapon
    {
        public override string Namespace => "SM_wp_axe_1h_barber_01";
        public override string Name => "One-Handed Barbed Axe";
        public override string Alias => "OneHandedBarbedAxe";
        public override WeaponType WeaponType => WeaponType.Axe;
        public override Dices Damage => Dices.D3D6;
        public override float AttackSpeed => 3;
        public override EquipmentTier Tier => EquipmentTier.T3;
        public override int GoldCost => 1200;
        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            {"Tier", "3"},
            {"Attack Speed", "3s"},
            {"Damage", "3D6"},
            {"Durability", "+50"},
            {"Attributes", "2-3"},
            {"Max Slots", "0-1"}
        };
    }

    public class OneHandedBrutalAxe : Weapon
    {
        public override string Namespace => "SM_wp_blunt_02_brutal_short";
        public override string Name => "One-Handed Brutal Axe";
        public override string Alias => "OneHandedBrutalAxe";
        public override WeaponType WeaponType => WeaponType.Axe;
        public override Dices Damage => Dices.D3D6;
        public override float AttackSpeed => 3;
        public override EquipmentTier Tier => EquipmentTier.T4;
        public override int GoldCost => 2000;
        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            {"Tier", "4"},
            {"Attack Speed", "3s"},
            {"Damage", "3D6"},
            {"Durability", "+75"},
            {"Attributes", "3-4"},
            {"Max Slots", "0-2"}
        };
    }

    public class OneHandedSpikedAxe : Weapon
    {
        public override string Namespace => "ArzaonAxe01";
        public override string Name => "One-Handed Spiked Axe";
        public override string Alias => "OneHandedSpikedAxe";
        public override WeaponType WeaponType => WeaponType.Axe;
        public override Dices Damage => Dices.D2D6;
        public override float AttackSpeed => 3;
        public override EquipmentTier Tier => EquipmentTier.T2;
        public override int GoldCost => 600;
        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            {"Tier", "2"},
            {"Attack Speed", "3s"},
            {"Damage", "2D6"},
            {"Attributes", "1-2"}
        };
    }

    public class SpikedAxe : Weapon
    {
        public override string Namespace => "ArzaonAxe08";
        public override string Name => "Spiked Axe";
        public override string Alias => "SpikedAxe";
        public override WeaponType WeaponType => WeaponType.Axe;
        public override Dices Damage => Dices.D2D6;
        public override float AttackSpeed => 3;
        public override EquipmentTier Tier => EquipmentTier.T2;
        public override int GoldCost => 600;
        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            {"Tier", "2"},
            {"Attack Speed", "3s"},
            {"Damage", "2D6"},
            {"Attributes", "1-2"}
        };
    }

    public class ThrowingAxe : Weapon
    {
        public override string Namespace => "ArzaonAxe05";
        public override string Name => "Throwing Axe";
        public override string Alias => "ThrowingAxe";
        public override WeaponType WeaponType => WeaponType.Axe;
        public override Dices Damage => Dices.D1D6;
        public override float AttackSpeed => 3;
        public override EquipmentTier Tier => EquipmentTier.T0;
        public override int GoldCost => 100;
        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            {"Tier", "0"},
            {"Attack Speed", "3s"},
            {"Damage", "1D6"},
            {"Attributes", "1"}
        };
    }
}
