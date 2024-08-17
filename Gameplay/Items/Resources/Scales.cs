namespace Server.Gameplay.Items
{
    public class AncientDragonScale : Resource
    {
        public override string Namespace => "AncientDragonScale";
        public override string Name => "Ancient Dragon Scale";
        public override float Weight => 20;
        public override int GoldCost => 5000;
    }

    public class DragonScale : Resource
    {
        public override string Namespace => "DragonScale";
        public override string Name => "Dragon Scale";
        public override float Weight => 15;
        public override int GoldCost => 1000;
    }

    public class DrakeScale : Resource
    {
        public override string Namespace => "DrakeScale";
        public override string Name => "Drake Scale";
        public override float Weight => 10;
        public override int GoldCost => 200;
    }
}
