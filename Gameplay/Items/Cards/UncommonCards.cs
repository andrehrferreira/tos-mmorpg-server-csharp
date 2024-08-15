namespace Server.Gameplay.Items
{
    public class CardMushroomMonsterShine : Card
    {
        public override string Namespace => "CardMushroomMonsterShine";
        public override string Name => "Card: Mushroom Monster";
        public override int GoldCost => 100;
        public override int Attack => 2;
        public override int HP => 4;
        public override int Energy => 3;
        public override ItemRarity Rarity => ItemRarity.Uncommon;

        public override void GenerateAttrs()
        {
            SetArmor(3);
        }
    }

    public class CardSkeletonArcher : Card
    {
        public override string Namespace => "CardSkeletonArcher";
        public override string Name => "Card: Skeleton Archer";
        public override int GoldCost => 100;
        public override int Attack => 2;
        public override int HP => 3;
        public override int Energy => 2;
        public override ItemRarity Rarity => ItemRarity.Uncommon;

        public override void GenerateAttrs()
        {
            SetAttr(AttributeType.BonusDamage, 2);
        }
    }

    public class CardSkeletonMage : Card
    {
        public override string Namespace => "CardSkeletonMage";
        public override string Name => "Card: Skeleton Mage";
        public override int GoldCost => 100;
        public override int Attack => 4;
        public override int HP => 2;
        public override int Energy => 3;
        public override ItemRarity Rarity => ItemRarity.Uncommon;

        public override void GenerateAttrs()
        {
            SetAttr(AttributeType.BonusMagicDamage, 3);
        }
    }
}
