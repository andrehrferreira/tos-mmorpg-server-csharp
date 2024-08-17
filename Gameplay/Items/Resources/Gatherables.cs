namespace Server.Gameplay.Items
{
    public class Coal : Resource
    {
        public override string Namespace => "Coal";
        public override string Name => "Coal";
        public override float Weight => 0.5f;
        public override int GoldCost => 1;
    }

    public class Stone : Resource
    {
        public override string Namespace => "Stone";
        public override string Name => "Stone";
        public override float Weight => 0.5f;
        public override int GoldCost => 1;
    }

    public class Tin : Resource
    {
        public override string Namespace => "Tin";
        public override string Name => "Tin";
        public override float Weight => 0.2f;
        public override int GoldCost => 1;
    }

    public class Stick : Resource
    {
        public override string Namespace => "Stick";
        public override string Name => "Stick";
        public override float Weight => 0.1f;
        public override int GoldCost => 1;
    }
}
