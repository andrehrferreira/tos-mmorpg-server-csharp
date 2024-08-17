namespace Server.Gameplay.Items
{
    public class ArcaneCloak : Equipament
    {
        public override string Namespace => "SK_ma_tal_nrw_cloak_hood_down";
        public override string Name => "Arcane Cloak";
        public override string Alias => "ArcaneCloak";
        public override EquipmentType EquipmentType => EquipmentType.Cloak;
        public override float Weight => 1;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 0;
        public override EquipmentTier Tier => EquipmentTier.T4;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "4" }
        };
    }

    public class DragonhideHood : Equipament
    {
        public override string Namespace => "SK_fe_meta_tal_nrw_cloak_base_V1_hood_down";
        public override string Name => "Dragonhide Hood";
        public override string Alias => "DragonhideHood";
        public override EquipmentType EquipmentType => EquipmentType.Cloak;
        public override float Weight => 1;
        public override int GoldCost => 2000;
        public override int MaxAttrs => 0;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" }
        };
    }

    public class EnchantedCloak : Equipament
    {
        public override string Namespace => "SK_ma_tal_nrw_cloak_base";
        public override string Name => "Enchanted Cloak";
        public override string Alias => "EnchantedCloak";
        public override EquipmentType EquipmentType => EquipmentType.Cloak;
        public override float Weight => 1;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 0;
        public override EquipmentTier Tier => EquipmentTier.T4;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "4" }
        };
    }

    public class GodlyHood : Equipament
    {
        public override string Namespace => "SK_fe_meta_tal_nrw_cloak_base_V1";
        public override string Name => "Godly Hood";
        public override string Alias => "GodlyHood";
        public override EquipmentType EquipmentType => EquipmentType.Cloak;
        public override float Weight => 1;
        public override int GoldCost => 320;
        public override int MaxAttrs => 0;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" }
        };
    }

    public class LeatherCloak : Equipament
    {
        public override string Namespace => "SK_ma_tal_nrw_cloak_base";
        public override string Name => "Leather Cloak";
        public override string Alias => "LeatherCloak";
        public override EquipmentType EquipmentType => EquipmentType.Cloak;
        public override float Weight => 1;
        public override int GoldCost => 100;
        public override int MaxAttrs => 0;
        public override EquipmentTier Tier => EquipmentTier.T3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" }
        };
    }

    public class SilkCloak : Equipament
    {
        public override string Namespace => "SK_ma_tal_nrw_cloak_hood_down";
        public override string Name => "Silk Cloak";
        public override string Alias => "SilkCloak";
        public override EquipmentType EquipmentType => EquipmentType.Cloak;
        public override float Weight => 1;
        public override int GoldCost => 100;
        public override int MaxAttrs => 0;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" }
        };
    }

    public class UnholyCloak : Equipament
    {
        public override string Namespace => "SK_ma_tal_nrw_cloak_base_high";
        public override string Name => "Unholy Cloak";
        public override string Alias => "UnholyCloak";
        public override EquipmentType EquipmentType => EquipmentType.Cloak;
        public override float Weight => 1;
        public override int GoldCost => 800;
        public override int MaxAttrs => 0;
        public override EquipmentTier Tier => EquipmentTier.T3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" }
        };
    }
}
