namespace Server.Gameplay.Items
{
    public class AlchemistTable : Item
    {
        public override string Namespace => "AlchemistTable";
        public override string Name => "Alchemist Table";
        public override string Alias => "AlchemistTable";
        public override float Weight => 10f;
        public override int GoldCost => 100;
    }

    public class CarpentryTable : Item
    {
        public override string Namespace => "CarpentryTable";
        public override string Name => "Carpentry Table";
        public override string Alias => "CarpentryTable";
        public override float Weight => 10f;
        public override int GoldCost => 100;
    }

    public class CookingPit : Item
    {
        public override string Namespace => "CookingPit";
        public override string Name => "Cooking Pit";
        public override string Alias => "CookingPit";
        public override float Weight => 5f;
        public override int GoldCost => 50;
    }

    public class Forge : Item
    {
        public override string Namespace => "Forge";
        public override string Name => "Forge";
        public override string Alias => "Forge";
        public override float Weight => 30f;
        public override int GoldCost => 500;
    }

    public class TailoringTools : Item
    {
        public override string Namespace => "TailoringTools";
        public override string Name => "Tailoring Tools";
        public override string Alias => "TailoringTools";
        public override float Weight => 10f;
        public override int GoldCost => 100;
    }

    // Wood Parts
    public class WoodFloor : Resource
    {
        public override string Namespace => "WoodFloor";
        public override string Name => "Wood Floor";
        public override string Alias => "WoodFloor";
        public override float Weight => 10f;
        public override int GoldCost => 100;
    }

    public class WoodRoof : Resource
    {
        public override string Namespace => "WoodRoof";
        public override string Name => "Wood Roof";
        public override string Alias => "WoodRoof";
        public override float Weight => 10f;
        public override int GoldCost => 100;
    }

    public class WoodWall : Resource
    {
        public override string Namespace => "WoodWall";
        public override string Name => "Wood Wall";
        public override string Alias => "WoodWall";
        public override float Weight => 10f;
        public override int GoldCost => 100;
    }

    public class WoodFence : Resource
    {
        public override string Namespace => "WoodFence";
        public override string Name => "Wood Fence";
        public override string Alias => "WoodFence";
        public override float Weight => 1f;
        public override int GoldCost => 10;
    }

    public class WoodWindow : Resource
    {
        public override string Namespace => "WoodWindow";
        public override string Name => "Wood Window";
        public override string Alias => "WoodWindow";
        public override float Weight => 1f;
        public override int GoldCost => 10;
    }

    public class WoodDoor : Resource
    {
        public override string Namespace => "WoodDoor";
        public override string Name => "Wood Door";
        public override string Alias => "WoodDoor";
        public override float Weight => 5f;
        public override int GoldCost => 50;
    }

    // Stone Parts
    public class StoneFloor : Resource
    {
        public override string Namespace => "StoneFloor";
        public override string Name => "Stone Floor";
        public override string Alias => "StoneFloor";
        public override float Weight => 30f;
        public override int GoldCost => 300;
    }

    public class StoneWall : Resource
    {
        public override string Namespace => "StoneWall";
        public override string Name => "Stone Wall";
        public override string Alias => "StoneWall";
        public override float Weight => 20f;
        public override int GoldCost => 200;
    }

    public class StoneRoof : Resource
    {
        public override string Namespace => "StoneRoof";
        public override string Name => "Stone Roof";
        public override string Alias => "StoneRoof";
        public override float Weight => 20f;
        public override int GoldCost => 200;
    }

    public class StoneWindow : Resource
    {
        public override string Namespace => "StoneWindow";
        public override string Name => "Stone Window";
        public override string Alias => "StoneWindow";
        public override float Weight => 10f;
        public override int GoldCost => 100;
    }

    public class StoneFence : Resource
    {
        public override string Namespace => "StoneFence";
        public override string Name => "Stone Fence";
        public override string Alias => "StoneFence";
        public override float Weight => 10f;
        public override int GoldCost => 100;
    }

    public class StoneDoor : Resource
    {
        public override string Namespace => "StoneDoor";
        public override string Name => "Stone Door";
        public override string Alias => "StoneDoor";
        public override float Weight => 10f;
        public override int GoldCost => 100;
    }

    // Furniture
    public class WoodBed : Resource
    {
        public override string Namespace => "WoodBed";
        public override string Name => "Wood Bed";
        public override string Alias => "WoodBed";
        public override float Weight => 5f;
        public override int GoldCost => 50;
    }

    public class WoodBookcase : Resource
    {
        public override string Namespace => "WoodBookcase";
        public override string Name => "Wood Bookcase";
        public override string Alias => "WoodBookcase";
        public override float Weight => 5f;
        public override int GoldCost => 50;
    }

    public class WoodCabinet : Resource
    {
        public override string Namespace => "WoodCabinet";
        public override string Name => "Wood Cabinet";
        public override string Alias => "WoodCabinet";
        public override float Weight => 5f;
        public override int GoldCost => 50;
    }

    public class WoodChair : Resource
    {
        public override string Namespace => "WoodChair";
        public override string Name => "Wood Chair";
        public override string Alias => "WoodChair";
        public override float Weight => 5f;
        public override int GoldCost => 50;
    }

    public class WoodChest : Resource
    {
        public override string Namespace => "WoodChest";
        public override string Name => "Wood Chest";
        public override string Alias => "WoodChest";
        public override float Weight => 5f;
        public override int GoldCost => 50;
    }
}
