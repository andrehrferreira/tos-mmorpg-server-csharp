namespace Server.Gameplay.Items
{
    public class BetaTicket : Consumable
    {
        public override string Namespace => "BetaTicket";
        public override string Name => "Beta Ticket";
        public override float Weight => 0.1f;
        public override int GoldCost => 1;
    }
}
