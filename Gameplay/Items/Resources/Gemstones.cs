namespace Server.Gameplay.Items
{
    public abstract class Gemstone : Resource { }

    public class Ametist : Gemstone
    {
        public override string Namespace => "Ametist";
        public override string Name => "Ametist";
        public override double Weight => 0.1;
        public override int GoldCost => 300;
        public override ItemRarity Rarity => ItemRarity.Rare;
    }

    public class Diamond : Gemstone
    {
        public override string Namespace => "Diamond";
        public override string Name => "Diamond";
        public override double Weight => 0.1;
        public override int GoldCost => 500;
        public override ItemRarity Rarity => ItemRarity.Legendary;
    }

    public class Emerald : Gemstone
    {
        public override string Namespace => "Emerald";
        public override string Name => "Emerald";
        public override double Weight => 0.1;
        public override int GoldCost => 400;
        public override ItemRarity Rarity => ItemRarity.Rare;
    }

    public class Pearl : Gemstone
    {
        public override string Namespace => "Pearl";
        public override string Name => "Pearl";
        public override double Weight => 0.1;
        public override int GoldCost => 350;
        public override ItemRarity Rarity => ItemRarity.Magic;
    }

    public class Ruby : Gemstone
    {
        public override string Namespace => "Ruby";
        public override string Name => "Ruby";
        public override double Weight => 0.1;
        public override int GoldCost => 450;
        public override ItemRarity Rarity => ItemRarity.Rare;
    }

    public class Sunstone : Gemstone
    {
        public override string Namespace => "Sunstone";
        public override string Name => "Sunstone";
        public override double Weight => 0.1;
        public override int GoldCost => 600;
        public override ItemRarity Rarity => ItemRarity.Legendary;
    }

    public class Topaz : Gemstone
    {
        public override string Namespace => "Topaz";
        public override string Name => "Topaz";
        public override double Weight => 0.1;
        public override int GoldCost => 350;
        public override ItemRarity Rarity => ItemRarity.Rare;
    }
}
