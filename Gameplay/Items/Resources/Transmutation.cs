namespace Server.Gameplay.Items
{
    public class FragmentWhiteCrystal : Resource
    {
        public override string Namespace => "FragmentWhiteCrystal";
        public override string Name => "Fragment White Crystal";
        public override int GoldCost => 1;
    }

    public class FragmentBlueCrystal : Resource
    {
        public override string Namespace => "FragmentBlueCrystal";
        public override string Name => "Fragment Blue Crystal";
        public override int GoldCost => 1;
        public override ItemRarity Rarity => ItemRarity.Rare;
    }

    public class FragmentGreenCrystal : Resource
    {
        public override string Namespace => "FragmentGreenCrystal";
        public override string Name => "Fragment Green Crystal";
        public override int GoldCost => 1;
        public override ItemRarity Rarity => ItemRarity.Uncommon;
    }

    public class FragmentOrangeCrystal : Resource
    {
        public override string Namespace => "FragmentOrangeCrystal";
        public override string Name => "Fragment Orange Crystal";
        public override int GoldCost => 1;
        public override ItemRarity Rarity => ItemRarity.Legendary;
    }

    public class FragmentPurpleCrystal : Resource
    {
        public override string Namespace => "FragmentPurpleCrystal";
        public override string Name => "Fragment Purple Crystal";
        public override int GoldCost => 1;
        public override ItemRarity Rarity => ItemRarity.Magic;
    }

    public class WhiteCrystal : Resource
    {
        public override string Namespace => "WhiteCrystal";
        public override string Name => "White Crystal";
        public override int GoldCost => 100;
        public override ItemRarity Rarity => ItemRarity.Uncommon;
    }

    public class RainbowCrystal : BaseChest
    {
        public override string Namespace => "RainbowCrystal";
        public override string Name => "Rainbow Crystal";
        public override int GoldCost => 500;
        public override ItemRarity Rarity => ItemRarity.Uncommon;

        public RainbowCrystal()
        {
            DropChance(typeof(FragmentGreenCrystal), 20, 1);
            DropChance(typeof(FragmentBlueCrystal), 5, 1);
            DropChance(typeof(FragmentPurpleCrystal), 1, 1);
            DropChance(typeof(FragmentOrangeCrystal), 0.1f, 1);
            DropChance(typeof(WhiteCrystal), 80, 1);
            DropChance(typeof(GreenCrystal), 5, 1);
            DropChance(typeof(BlueCrystal), 1, 1);
            DropChance(typeof(PurpleCrystal), 0.1f, 1);
        }
    }

    public class GreenCrystal : Resource
    {
        public override string Namespace => "GreenCrystal";
        public override string Name => "Green Crystal";
        public override int GoldCost => 1000;
        public override ItemRarity Rarity => ItemRarity.Uncommon;
    }

    public class BlueCrystal : Resource
    {
        public override string Namespace => "BlueCrystal";
        public override string Name => "Blue Crystal";
        public override int GoldCost => 5000;
        public override ItemRarity Rarity => ItemRarity.Rare;
    }

    public class PurpleCrystal : Resource
    {
        public override string Namespace => "PurpleCrystal";
        public override string Name => "Purple Crystal";
        public override int GoldCost => 10000;
        public override ItemRarity Rarity => ItemRarity.Magic;
    }

    public class OrageCrystal : Resource
    {
        public override string Namespace => "OrageCrystal";
        public override string Name => "Orage Crystal";
        public override int GoldCost => 50000;
        public override ItemRarity Rarity => ItemRarity.Legendary;
    }
}
