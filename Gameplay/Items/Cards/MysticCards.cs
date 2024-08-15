namespace Server.Gameplay.Items
{
    public class CardDragonide : Card
    {
        public override string Namespace => "CardDragonide";
        public override string Name => "Card: Dragonide";
        public override int GoldCost => 600;
        public override int Attack => 5;
        public override int HP => 4;
        public override int Energy => 5;
        public override ItemRarity Rarity => ItemRarity.Magic;

        public override void GenerateAttrs()
        {
            SetArmor(5);
        }
    }

    public class CardSoulReaper : Card
    {
        public override string Namespace => "CardSoulReaper";
        public override string Name => "Card: Soul Reaper";
        public override int GoldCost => 600;
        public override int Attack => 8;
        public override int HP => 6;
        public override int Energy => 5;
        public override ItemRarity Rarity => ItemRarity.Magic;

        public override void GenerateAttrs()
        {
            SetAttr(AttributeType.BonusMagicDamage, 10);
        }
    }
}
