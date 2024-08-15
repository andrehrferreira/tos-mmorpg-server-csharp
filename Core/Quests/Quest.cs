namespace Server
{
    public enum QuestType
    {
        Collect,
        KillerMobiles,
        Delivery,
        Crafting
    }

    public interface IItemRef
    {
        string ItemName { get; set; }
        int Quantity { get; set; }
    }

    public interface IReward
    {
        Type Item { get; set; }
        int Quantity { get; set; }
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
        public static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        public static Dictionary<string, Type> Quests { get; private set; } = new Dictionary<string, Type>();

        public string Namespace { get; set; }
        public QuestType Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Progress { get; set; }
        public bool Completed { get; set; } = false;
        public bool Fav { get; set; } = false;

        // Objectives
        public List<IItemRef> ItemCollect { get; set; } = new List<IItemRef>();
        public List<IItemRef> ItemCrafting { get; set; } = new List<IItemRef>();
        public string CreatureToKill { get; set; }
        public string ItemToDelivery { get; set; }

        // Rewards
        public List<IReward> Rewards { get; set; } = new List<IReward>();

        public static void AddQuest(string @namespace, Type questType)
        {
            if (!Quests.ContainsKey(@namespace))            
                Quests.Add(@namespace, questType);            
        }

        public virtual void ParseMetadata(Dictionary<string, dynamic> metadata)
        {
            if (metadata != null && metadata.ContainsKey(Namespace))
            {
                Completed = metadata[Namespace]?.completed ?? false;
                Fav = metadata[Namespace]?.fav ?? false;
                Progress = metadata[Namespace]?.progress ?? 0;
            }
        }

        public virtual Dictionary<string, dynamic> GetMetadata(bool appendPublicData = false)
        {
            var baseData = new Dictionary<string, dynamic>
            {
                { "namespace", Namespace },
                { "completed", Completed },
                { "progress", Progress },
                { "fav", Fav }
            };

            if (appendPublicData)
            {
                baseData.Add("name", Name);
                baseData.Add("description", Description);
                baseData.Add("type", Type);

                var rewardData = new List<Dictionary<string, dynamic>>();

                foreach (var reward in Rewards)
                {
                    var rewardItem = Activator.CreateInstance(reward.Item) as Item;
                    rewardData.Add(new Dictionary<string, dynamic>
                    {
                        { "i", rewardItem?.Namespace },
                        { "q", reward.Quantity }
                    });
                }

                baseData.Add("reward", rewardData);

                var itemsCollectData = new List<Dictionary<string, dynamic>>();

                foreach (var item in ItemCollect)
                {
                    itemsCollectData.Add(new Dictionary<string, dynamic>
                    {
                        { "i", item.ItemName },
                        { "q", item.Quantity }
                    });
                }

                baseData.Add("itemsCollect", itemsCollectData);
            }

            return baseData;
        }
    }
}
