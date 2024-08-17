namespace Server.Gameplay.Items
{
    public class Ballista : Weapon
    {
        public override string Namespace => "Crossbow_1";
        public override string Name => "Ballista";
        public override string Alias => "Ballista";
        public override WeaponType WeaponType => WeaponType.Crossbow;
        public override Dices Damage => Dices.D3D8;
        public override float AttackSpeed => 3.0f;
        public override EquipmentTier Tier => EquipmentTier.T3;
        public override int GoldCost => 1200;
        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Attack Speed", "3s" },
            { "Damage", "3D8" },
            { "Attributes", "2-3" },
            { "Max Slots", "0-1" }
        };
    }

    public class HeavyCrossbow : Weapon
    {
        public override string Namespace => "ArzaonCrossbow";
        public override string Name => "Heavy Crossbow";
        public override string Alias => "HeavyCrossbow";
        public override WeaponType WeaponType => WeaponType.Crossbow;
        public override Dices Damage => Dices.D2D8;
        public override float AttackSpeed => 3.0f;
        public override EquipmentTier Tier => EquipmentTier.T2;
        public override int GoldCost => 600;
        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Attack Speed", "3s" },
            { "Damage", "2D8" },
            { "Attributes", "1-2" }
        };
    }

    public class Crossbow : Weapon
    {
        public override string Namespace => "ArzaonCrossbow02";
        public override string Name => "Crossbow";
        public override string Alias => "Crossbow";
        public override WeaponType WeaponType => WeaponType.Crossbow;
        public override Dices Damage => Dices.D1D8;
        public override float AttackSpeed => 2.0f;
        public override EquipmentTier Tier => EquipmentTier.T1;
        public override int GoldCost => 300;
        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "1" },
            { "Attack Speed", "2s" },
            { "Damage", "1D8" },
            { "Attributes", "1" }
        };
    }
}
