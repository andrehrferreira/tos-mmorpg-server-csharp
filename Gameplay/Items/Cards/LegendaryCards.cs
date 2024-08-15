namespace Server.Gameplay.Items
{
    public class CardMountainDragon: Card
    {
        public override string Namespace => "CardMoutainDragon";
        public override string Name => "Card: Mountain Dragon";
        public override int GoldCost => 1000;
        public override int Attack => 6;
        public override int HP => 10;
        public override int Energy => 5;
        public override ItemRarity Rarity => ItemRarity.Legendary;

        public override void GenerateAttrs()
        {
            this.SetArmor(20);
        }
    }

    public class CardBigSlime : Card
    {
        public override string Namespace => "CardBigSlime";
        public override string Name => "Card: Big Slime";
        public override int GoldCost => 1000;
        public override int Attack => 2;
        public override int HP => 20;
        public override int Energy => 5;
        public override ItemRarity Rarity => ItemRarity.Legendary;

        public override void GenerateAttrs()
        {
            SetFireResistence(10);
            SetColdResistence(10);
            SetPoisonResistence(10);
            SetEnergyResistence(10);
            SetLightResistence(10);
            SetDarkResistence(10);
        }
    }

    public class CardFabio : Card
    {
        public override string Namespace => "CardFabio";
        public override string Name => "Card: Fabio";
        public override int GoldCost => 1;
        public override int Attack => 1;
        public override int HP => 1;
        public override int Energy => 1;
        public override ItemRarity Rarity => ItemRarity.Legendary;
    }

    public class CardAkelodon : Card
    {
        public override string Namespace => "CardAkelodon";
        public override string Name => "Card: Akelodon";
        public override int GoldCost => 1;
        public override int Attack => 6;
        public override int HP => 10;
        public override int Energy => 6;
        public override ItemRarity Rarity => ItemRarity.Legendary;
    }
}
