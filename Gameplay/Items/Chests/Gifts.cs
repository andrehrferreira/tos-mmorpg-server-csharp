namespace Server.Gameplay.Items
{
    public class BetaGift : BaseChest
    {
        public override string Namespace => "BetaGift";
        public override string Name => "Beta Gift";
        public override int GoldCost => 1;

        public BetaGift()
        {
            DropChance(typeof(GoldCoin), 100, 10000);
            DropChance(typeof(PowerScroll), 100, 1);

            DropChance(typeof(Emerald), 50, 1);
            DropChance(typeof(Diamond), 1, 1);
            DropChance(typeof(Ametist), 50, 1);
            DropChance(typeof(Pearl), 10, 1);
            DropChance(typeof(Ruby), 10, 1);
            DropChance(typeof(Sunstone), 1, 1);
            DropChance(typeof(Topaz), 10, 1);

            DropChance(typeof(FragmentWhiteCrystal), 100, 5, 10);
            DropChance(typeof(FragmentGreenCrystal), 50, 1, 5);
            DropChance(typeof(FragmentBlueCrystal), 10, 1);
            DropChance(typeof(FragmentOrangeCrystal), 0.1f, 1);

            DropChance(typeof(CardAkelodon), 0.1f, 1);
            DropChance(typeof(CardBigSlime), 0.1f, 1);
            DropChance(typeof(CardFabio), 100, 1);
            DropChance(typeof(CardBomberBug), 10, 1);
            DropChance(typeof(CardSkeleton), 10, 1);
            DropChance(typeof(CardSlime), 10, 1);
        }
    }
}
