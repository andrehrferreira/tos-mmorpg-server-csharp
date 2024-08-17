namespace Server.Gameplay.Items
{
    public class TreasuresOfTheSea : BaseChest
    {
        public override string Namespace => "TreasuresOfTheSea";
        public override string Name => "Treasures Of The Sea";
        public override int GoldCost => 10000;
        public override ItemRarity Rarity => ItemRarity.Rare;

        public TreasuresOfTheSea()
        {
            DropChance<GoldCoin>(100, 3000, 5000);
            DropChance<ColdEssence>(100, 30, 50);
            DropChance<NatureEssence>(100, 20, 30);

            DropChance<Pearl>(100, 1, 3);
            DropChance<Emerald>(50, 1);
            DropChance<Diamond>(50, 1);
            DropChance<Ametist>(50, 1);
            DropChance<Ruby>(1, 1);
            DropChance<Sunstone>(1, 1);
            DropChance<Topaz>(1, 1);

            DropChance<FragmentWhiteCrystal>(100, 10, 20);
            DropChance<FragmentGreenCrystal>(90, 5, 10);
            DropChance<FragmentBlueCrystal>(30, 1, 5);
            DropChance<FragmentOrangeCrystal>(1, 1);
        }
    }
}
