namespace Server.Gameplay.Items
{
    public class AlchemistPestle : Tool
    {
        public override string Namespace => "AlchemistPestle";
        public override string Name => "Alchemist Pestle";
        public override float Weight => 1;
        public override int GoldCost => 50;
    }

    public class JewelersTools : Tool
    {
        public override string Namespace => "JewelersTools";
        public override string Name => "Jeweler`s Tools";
        public override float Weight => 2;
        public override int GoldCost => 200;
    }

    public class PaintingBrushes : Tool
    {
        public override string Namespace => "PaintingBrushes";
        public override string Name => "Painting Brushes";
        public override float Weight => 2;
        public override int GoldCost => 100;
    }

    public class WritingInstruments : Tool
    {
        public override string Namespace => "WritingInstruments";
        public override string Name => "Writing Instruments";
        public override float Weight => 1;
        public override int GoldCost => 100;
    }

    public class Pickaxe : PickaxeTool
    {
        public override string Namespace => "Pickaxe";
        public override string Name => "Pickaxe";
        public override EquipmentTier Tier => EquipmentTier.T0;
        public override int GoldCost => 20;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>()
        {
            { "Durability", "100" }
        };

        public override void GenerateAttrs()
        {
            SetDurability(100);
        }
    }

    public class SilverPickaxe : PickaxeTool
    {
        public override string Namespace => "SilverPickaxe";
        public override string Name => "Silver Pickaxe";
        public override EquipmentTier Tier => EquipmentTier.T2;
        public override ItemRarity Rarity => ItemRarity.Uncommon;
        public override int GoldCost => 300;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>()
        {
            { "Durability", "500" },
            { "BonusCollectsMineral", "50%" }
        };

        public override void GenerateAttrs()
        {
            SetDurability(500);
            SetAttr(AttributeType.BonusCollectsMineral, 50);
        }
    }

    public class GoldPickaxe : PickaxeTool
    {
        public override string Namespace => "GoldPickaxe";
        public override string Name => "Gold Pickaxe";
        public override EquipmentTier Tier => EquipmentTier.T5;
        public override ItemRarity Rarity => ItemRarity.Rare;
        public override int GoldCost => 2000;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>()
        {
            { "Durability", "1000" },
            { "BonusCollectsMineral", "100%" }
        };

        public override void GenerateAttrs()
        {
            SetDurability(1000);
            SetAttr(AttributeType.BonusCollectsMineral, 100);
        }
    }

    public class LumberjackAxe : AxeTool
    {
        public override string Namespace => "ArzaonAxe04";
        public override string Name => "Lumberjack Axe";
        public override EquipmentTier Tier => EquipmentTier.T0;
        public override int GoldCost => 20;

        public override void GenerateAttrs()
        {
            SetDurability(100);
        }
    }

    public class SilverLumberjackAxe : AxeTool
    {
        public override string Namespace => "SilverLumberjackAxe";
        public override string Name => "Silver LumberjackAxe";
        public override EquipmentTier Tier => EquipmentTier.T2;
        public override ItemRarity Rarity => ItemRarity.Uncommon;
        public override int GoldCost => 300;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>()
        {
            { "Durability", "500" },
            { "BonusCollectsWood", "50%" }
        };

        public override void GenerateAttrs()
        {
            SetDurability(500);
            SetAttr(AttributeType.BonusCollectsWood, 50);
        }
    }

    public class GoldLumberjackAxe : AxeTool
    {
        public override string Namespace => "GoldLumberjackAxe";
        public override string Name => "Gold LumberjackAxe";
        public override EquipmentTier Tier => EquipmentTier.T5;
        public override ItemRarity Rarity => ItemRarity.Rare;
        public override int GoldCost => 2000;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>()
        {
            { "Durability", "1000" },
            { "BonusCollectsWood", "100%" }
        };

        public override void GenerateAttrs()
        {
            SetDurability(1000);
            SetAttr(AttributeType.BonusCollectsWood, 100);
        }
    }

    public class Sickle : ScytheTool
    {
        public override string Namespace => "SM_tool_sickle_01";
        public override string Name => "Sickle";
        public override EquipmentTier Tier => EquipmentTier.T0;
        public override int GoldCost => 20;

        public override void GenerateAttrs()
        {
            SetDurability(100);
        }
    }

    public class SilverSickle : ScytheTool
    {
        public override string Namespace => "SilverSickle";
        public override string Name => "Silver Sickle";
        public override EquipmentTier Tier => EquipmentTier.T2;
        public override ItemRarity Rarity => ItemRarity.Uncommon;
        public override int GoldCost => 300;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>()
        {
            { "Durability", "500" },
            { "BonusCollectsSkins", "50%" }
        };

        public override void GenerateAttrs()
        {
            SetDurability(500);
            SetAttr(AttributeType.BonusCollectsSkins, 50);
        }
    }

    public class GoldSickle : ScytheTool
    {
        public override string Namespace => "GoldSickle";
        public override string Name => "Gold Sickle";
        public override EquipmentTier Tier => EquipmentTier.T5;
        public override ItemRarity Rarity => ItemRarity.Rare;
        public override int GoldCost => 2000;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>()
        {
            { "Durability", "1000" },
            { "BonusCollectsSkins", "100%" }
        };

        public override void GenerateAttrs()
        {
            SetDurability(1000);
            SetAttr(AttributeType.BonusCollectsSkins, 100);
        }
    }

    public class FishRod : Tool
    {
        public override string Namespace => "FishRod";
        public override string Name => "Fish Rod";
        public override int GoldCost => 20;
    }
}
