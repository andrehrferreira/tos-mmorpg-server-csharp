namespace Server
{
    public enum QuestType
    {
        Collect,
        KillerMobiles,
        Delivery,
        Crafting
    }

    public class ItemRef
    {
        public string ItemName { get; set; }
        public int Quantity { get; set; }
    }

    public class Reward
    {
        public Func<object> Item { get; set; }
        public int Quantity { get; set; }
    }


    public abstract class Quest
    {

    }
}
