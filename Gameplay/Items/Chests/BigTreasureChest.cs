namespace Server.Gameplay.Items
{
    public class BigTreasureChest : BaseChest
    {
        public override string Namespace => "BigTreasureChest";
        public override string Name => "Big Treasure Chest";
        public override int GoldCost => 1;

        public BigTreasureChest()
        {
            DropChance<GoldCoin>(100, 500, 3000);

            DropChance<Emerald>(50, 1);
            DropChance<Diamond>(1, 1);
            DropChance<Ametist>(50, 1);
            DropChance<Pearl>(10, 1);
            DropChance<Ruby>(10, 1);
            DropChance<Sunstone>(1, 1);
            DropChance<Topaz>(10, 1);

            DropChance<FragmentWhiteCrystal>(100, 5, 10);
            DropChance<FragmentGreenCrystal>(50, 1, 5);
            DropChance<FragmentBlueCrystal>(10, 1);
            DropChance<FragmentOrangeCrystal>(0.1f, 1);
        }
    }
}
