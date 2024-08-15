namespace Server.Gameplay.Items
{
    public class CardSlime : Card
    {
        public override string Namespace => "CardSlime";
        public override string Name => "Card: Slime";
        public override int GoldCost => 100;
        public override int Attack => 1;
        public override int HP => 2;
        public override int Energy => 1;
        public override ItemRarity Rarity => ItemRarity.Common;

        public override void GenerateAttrs()
        {
            SetArmor(2);
        }
    }

    public class CardBomberBug : Card
    {
        public override string Namespace => "CardBomberBug";
        public override string Name => "Card: Bomber Bug";
        public override int GoldCost => 100;
        public override int Attack => 2;
        public override int HP => 3;
        public override int Energy => 2;
        public override ItemRarity Rarity => ItemRarity.Common;

        public override void GenerateAttrs()
        {
            SetPoisonResistence(2);
        }
    }

    public class CardMushroomMonster : Card
    {
        public override string Namespace => "CardMushroomMonster";
        public override string Name => "Card: Mushroom Monster";
        public override int GoldCost => 100;
        public override int Attack => 2;
        public override int HP => 2;
        public override int Energy => 2;
        public override ItemRarity Rarity => ItemRarity.Common;

        public override void GenerateAttrs()
        {
            SetPoisonResistence(1);
        }
    }

    public class CardSkeleton : Card
    {
        public override string Namespace => "CardSkeleton";
        public override string Name => "Card: Skeleton";
        public override int GoldCost => 100;
        public override int Attack => 1;
        public override int HP => 2;
        public override int Energy => 1;
        public override ItemRarity Rarity => ItemRarity.Common;

        public override void GenerateAttrs()
        {
            SetArmor(1);
        }
    }

    public class CardPlantMonster : Card
    {
        public override string Namespace => "CardPlantMonster";
        public override string Name => "Card: Plant Monster";
        public override int GoldCost => 100;
        public override int Attack => 2;
        public override int HP => 2;
        public override int Energy => 2;
        public override ItemRarity Rarity => ItemRarity.Common;

        public override void GenerateAttrs()
        {
            SetPoisonResistence(2);
        }
    }

    public class CardCrab : Card
    {
        public override string Namespace => "CardCrab";
        public override string Name => "Card: Crab";
        public override int GoldCost => 100;
        public override int Attack => 2;
        public override int HP => 2;
        public override int Energy => 2;
        public override ItemRarity Rarity => ItemRarity.Common;

        public override void GenerateAttrs()
        {
            SetAttr(AttributeType.BonusStr, 1);
        }
    }

    public class CardGiantViper : Card
    {
        public override string Namespace => "CardGiantViper";
        public override string Name => "Card: Giant Viper";
        public override int GoldCost => 100;
        public override int Attack => 2;
        public override int HP => 2;
        public override int Energy => 2;
        public override ItemRarity Rarity => ItemRarity.Common;

        public override void GenerateAttrs()
        {
            // Attribute generation not implemented
        }
    }

    public class CardFishman : Card
    {
        public override string Namespace => "CardFishman";
        public override string Name => "Card: Fishman";
        public override int GoldCost => 100;
        public override int Attack => 1;
        public override int HP => 2;
        public override int Energy => 1;
        public override ItemRarity Rarity => ItemRarity.Common;

        public override void GenerateAttrs()
        {
            SetArmor(1);
        }
    }

    public class CardWeranglerfish : Card
    {
        public override string Namespace => "CardWeranglerfish";
        public override string Name => "Card: Weranglerfish";
        public override int GoldCost => 100;
        public override int Attack => 2;
        public override int HP => 2;
        public override int Energy => 2;
        public override ItemRarity Rarity => ItemRarity.Common;

        public override void GenerateAttrs()
        {
            SetAttr(AttributeType.BonusStr, 2);
        }
    }
}
