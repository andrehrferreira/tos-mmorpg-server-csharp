namespace Server.Gameplay.Items
{
    public class IronOre : Resource
    {
        public override string Namespace => "IronOre";
        public override string Name => "Iron Ore";
        public override double Weight => 1;
        public override int GoldCost => 1;
    }

    public class CopperOre : Resource
    {
        public override string Namespace => "CopperOre";
        public override string Name => "Copper Ore";
        public override double Weight => 2;
        public override int GoldCost => 1;
    }

    public class SilverOre : Resource
    {
        public override string Namespace => "SilverOre";
        public override string Name => "Silver Ore";
        public override double Weight => 2;
        public override int GoldCost => 5;
    }

    public class GoldOre : Resource
    {
        public override string Namespace => "GoldOre";
        public override string Name => "Gold Ore";
        public override double Weight => 3;
        public override int GoldCost => 25;
    }

    public class DarkOre : Resource
    {
        public override string Namespace => "DarkOre";
        public override string Name => "Dark Ore";
        public override double Weight => 4;
        public override int GoldCost => 150;
    }

    public class MithrilOre : Resource
    {
        public override string Namespace => "MithrilOre";
        public override string Name => "Mithril Ore";
        public override double Weight => 6;
        public override int GoldCost => 300;
    }

    public class HeavenlyOre : Resource
    {
        public override string Namespace => "HeavenlyOre";
        public override string Name => "Heavenly Ore";
        public override double Weight => 10;
        public override int GoldCost => 2000;
    }

    // Ingot Classes
    public class CopperIngot : Resource
    {
        public override string Namespace => "CopperIngot";
        public override string Name => "Copper Ingot";
        public override double Weight => 1;
        public override int GoldCost => 5;
    }

    public class IronIngot : Resource
    {
        public override string Namespace => "IronIngot";
        public override string Name => "Iron Ingot";
        public override double Weight => 1;
        public override int GoldCost => 5;
    }

    public class SteelIngot : Resource
    {
        public override string Namespace => "SteelIngot";
        public override string Name => "Steel Ingot";
        public override double Weight => 0.5;
        public override int GoldCost => 15;
    }

    public class SilverIngot : Resource
    {
        public override string Namespace => "SilverIngot";
        public override string Name => "Silver Ingot";
        public override double Weight => 1;
        public override int GoldCost => 25;
    }

    public class GoldIngot : Resource
    {
        public override string Namespace => "GoldIngot";
        public override string Name => "Gold Ingot";
        public override double Weight => 2;
        public override int GoldCost => 50;
    }

    public class DarkIngot : Resource
    {
        public override string Namespace => "DarkIngot";
        public override string Name => "Dark Ingot";
        public override double Weight => 2;
        public override int GoldCost => 100;
    }

    public class DarkSteelIngot : Resource
    {
        public override string Namespace => "DarkSteelIngot";
        public override string Name => "Dark Steel Ingot";
        public override double Weight => 1.5;
        public override int GoldCost => 150;
    }

    public class DwarfMetalIngot : Resource
    {
        public override string Namespace => "DwarfMetalIngot";
        public override string Name => "Dwarf Metal Ingot";
        public override double Weight => 10;
        public override int GoldCost => 500;
    }

    public class MithrilIngot : Resource
    {
        public override string Namespace => "MithrilIngot";
        public override string Name => "Mithril Ingot";
        public override double Weight => 10;
        public override int GoldCost => 500;
    }

    public class HeavenlyIngot : Resource
    {
        public override string Namespace => "HeavenlyIngot";
        public override string Name => "Heavenly Ingot";
        public override double Weight => 10;
        public override int GoldCost => 1000;
    }
}
