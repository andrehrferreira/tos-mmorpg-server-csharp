namespace Server.Gameplay.Items
{
    public class BetaTicket : Consumable
    {
        public override string Namespace => "BetaTicket";
        public override string Name => "Beta Ticket";
        public override double Weight => 0.1;
        public override int GoldCost => 1;
    }
}
