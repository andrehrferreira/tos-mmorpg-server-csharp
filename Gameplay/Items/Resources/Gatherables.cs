namespace Server.Gameplay.Items
{
    public class Coal : Resource
    {
        public override string Namespace => "Coal";
        public override string Name => "Coal";
        public override double Weight => 0.5;
        public override int GoldCost => 1;
    }

    public class Stone : Resource
    {
        public override string Namespace => "Stone";
        public override string Name => "Stone";
        public override double Weight => 0.5;
        public override int GoldCost => 1;
    }

    public class Tin : Resource
    {
        public override string Namespace => "Tin";
        public override string Name => "Tin";
        public override double Weight => 0.2;
        public override int GoldCost => 1;
    }

    public class Stick : Resource
    {
        public override string Namespace => "Stick";
        public override string Name => "Stick";
        public override double Weight => 0.1;
        public override int GoldCost => 1;
    }
}
