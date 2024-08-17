namespace Server.Gameplay.Items
{
    public class ColdEssence : Resource
    {
        public override string Namespace => "ColdEssence";
        public override string Name => "Cold Essence";
        public override float Weight => 0.1f;
        public override int GoldCost => 10;
    }

    public class DarknessEssence : Resource
    {
        public override string Namespace => "DarknessEssence";
        public override string Name => "Darkness Essence";
        public override float Weight => 0.1f;
        public override int GoldCost => 100;
    }

    public class EarthEssence : Resource
    {
        public override string Namespace => "EarthEssence";
        public override string Name => "Earth Essence";
        public override float Weight => 0.1f;
        public override int GoldCost => 10;
    }

    public class FireEssence : Resource
    {
        public override string Namespace => "FireEssence";
        public override string Name => "Fire Essence";
        public override float Weight => 0.1f;
        public override int GoldCost => 10;
    }

    public class LightEssence : Resource
    {
        public override string Namespace => "LightEssence";
        public override string Name => "Light Essence";
        public override float Weight => 0.1f;
        public override int GoldCost => 10;
    }

    public class NatureEssence : Resource
    {
        public override string Namespace => "NatureEssence";
        public override string Name => "Nature Essence";
        public override float Weight => 0.1f;
        public override int GoldCost => 10;
    }

    public class WindEssence : Resource
    {
        public override string Namespace => "WindEssence";
        public override string Name => "Wind Essence";
        public override float Weight => 0.1f;
        public override int GoldCost => 10;
    }

    public class ElementalDust : Resource
    {
        public override string Namespace => "ElementalDust";
        public override string Name => "Elemental Dust";
        public override float Weight => 0.1f;
        public override int GoldCost => 50;
    }

    public class MagicDust : Resource
    {
        public override string Namespace => "MagicDust";
        public override string Name => "Magic Dust";
        public override float Weight => 0.1f;
        public override int GoldCost => 100;
    }

    public class MagicEssence : Resource
    {
        public override string Namespace => "MagicEssence";
        public override string Name => "Magic Essence";
        public override float Weight => 0.1f;
        public override int GoldCost => 300;
    }
}
