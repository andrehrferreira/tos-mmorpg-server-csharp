namespace Server.Gameplay.Items
{
    public class CardSkeletonKnight : Card
    {
        public override string Namespace => "CardSkeletonKnight";
        public override string Name => "Card: Skeleton Knight";
        public override int GoldCost => 300;
        public override int Attack => 3;
        public override int HP => 4;
        public override int Energy => 2;
        public override ItemRarity Rarity => ItemRarity.Rare;

        public override void GenerateAttrs()
        {
            SetAttr(AttributeType.BonusDamage, 2);
        }
    }

    public class CardGiantWorm : Card
    {
        public override string Namespace => "CardGiantWorm";
        public override string Name => "Card: Giant Worm";
        public override int GoldCost => 300;
        public override int Attack => 2;
        public override int HP => 6;
        public override int Energy => 4;
        public override ItemRarity Rarity => ItemRarity.Rare;

        public override void GenerateAttrs()
        {
            SetPoisonResistence(5);
        }
    }

    public class CardTroll : Card
    {
        public override string Namespace => "CardTroll";
        public override string Name => "Card: Troll";
        public override int GoldCost => 300;
        public override int Attack => 4;
        public override int HP => 6;
        public override int Energy => 4;
        public override ItemRarity Rarity => ItemRarity.Rare;

        public override void GenerateAttrs()
        {
            SetArmor(5);
        }
    }
}
