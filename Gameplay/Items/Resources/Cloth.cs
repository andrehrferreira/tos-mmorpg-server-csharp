namespace Server.Gameplay.Items
{
    public class Cotton : Resource
    {
        public override string Namespace => "Cotton";
        public override string Name => "Cotton";
        public override double Weight => 0.1;
        public override int GoldCost => 1;
    }

    public class Fiber : Resource
    {
        public override string Namespace => "Fiber";
        public override string Name => "Fiber";
        public override double Weight => 0.1;
        public override int GoldCost => 1;
    }

    public class ArcaneFiber : Resource
    {
        public override string Namespace => "ArcaneFiber";
        public override string Name => "Arcane Fiber";
        public override double Weight => 0.1;
        public override int GoldCost => 3;
        public override ItemRarity Rarity => ItemRarity.Uncommon;
    }

    public class MasterCotton : Resource
    {
        public override string Namespace => "MasterCotton";
        public override string Name => "Master Cotton";
        public override double Weight => 0.1;
        public override int GoldCost => 5;
        public override ItemRarity Rarity => ItemRarity.Uncommon;
    }

    public class Silk : Resource
    {
        public override string Namespace => "Silk";
        public override string Name => "Silk";
        public override double Weight => 0.1;
        public override int GoldCost => 10;
        public override ItemRarity Rarity => ItemRarity.Rare;
    }

    public class MysticSilk : Resource
    {
        public override string Namespace => "MysticSilk";
        public override string Name => "Mystic Silk";
        public override double Weight => 0.1;
        public override int GoldCost => 25;
        public override ItemRarity Rarity => ItemRarity.Rare;
    }

    public class DragonFlowerSilk : Resource
    {
        public override string Namespace => "DragonFlowerSilk";
        public override string Name => "Dragon Flower Silk";
        public override double Weight => 0.1;
        public override int GoldCost => 30;
        public override ItemRarity Rarity => ItemRarity.Magic;
    }

    public class DivineCotton : Resource
    {
        public override string Namespace => "DivineCotton";
        public override string Name => "Divine Cotton";
        public override double Weight => 0.1;
        public override int GoldCost => 100;
        public override ItemRarity Rarity => ItemRarity.Legendary;
    }

    //Cloth
    public class LinenCloth : Resource
    {
        public override string Namespace => "LinenCloth";
        public override string Name => "Linen Cloth";
        public override double Weight => 0.1;
        public override int GoldCost => 1;
    }

    public class WoolenCloth : Resource
    {
        public override string Namespace => "WoolenCloth";
        public override string Name => "Woolen Cloth";
        public override double Weight => 0.1;
        public override int GoldCost => 1;
    }

    public class MageweaveCloth : Resource
    {
        public override string Namespace => "MageweaveCloth";
        public override string Name => "Mageweave Cloth";
        public override double Weight => 0.1;
        public override int GoldCost => 3;
        public override ItemRarity Rarity => ItemRarity.Uncommon;
    }

    public class PrimalCloth : Resource
    {
        public override string Namespace => "PrimalCloth";
        public override string Name => "Primal Cloth";
        public override double Weight => 0.1;
        public override int GoldCost => 5;
        public override ItemRarity Rarity => ItemRarity.Uncommon;
    }

    public class MagicCloth : Resource
    {
        public override string Namespace => "MagicCloth";
        public override string Name => "Magic Cloth";
        public override double Weight => 0.1;
        public override int GoldCost => 10;
        public override ItemRarity Rarity => ItemRarity.Rare;
    }

    public class SilkCloth : Resource
    {
        public override string Namespace => "SilkCloth";
        public override string Name => "Silk Cloth";
        public override double Weight => 0.1;
        public override int GoldCost => 10;
        public override ItemRarity Rarity => ItemRarity.Rare;
    }

    public class EnchantedCloth : Resource
    {
        public override string Namespace => "EnchantedCloth";
        public override string Name => "Enchanted Cloth";
        public override double Weight => 0.1;
        public override int GoldCost => 15;
        public override ItemRarity Rarity => ItemRarity.Magic;
    }

    public class DemonicCloth : Resource
    {
        public override string Namespace => "DemonicCloth";
        public override string Name => "Demonic Cloth";
        public override double Weight => 0.1;
        public override int GoldCost => 30;
        public override ItemRarity Rarity => ItemRarity.Magic;
    }

    public class DarknessCloth : Resource
    {
        public override string Namespace => "DarknessCloth";
        public override string Name => "Darkness Cloth";
        public override double Weight => 0.1;
        public override int GoldCost => 35;
        public override ItemRarity Rarity => ItemRarity.Magic;
    }

    public class DragonestCloth : Resource
    {
        public override string Namespace => "DragonestCloth";
        public override string Name => "Dragonest Cloth";
        public override double Weight => 0.1;
        public override int GoldCost => 50;
        public override ItemRarity Rarity => ItemRarity.Legendary;
    }

    public class DivineCloth : Resource
    {
        public override string Namespace => "DivineCloth";
        public override string Name => "Divine Cloth";
        public override double Weight => 0.1;
        public override int GoldCost => 100;
        public override ItemRarity Rarity => ItemRarity.Legendary;
    }
}
