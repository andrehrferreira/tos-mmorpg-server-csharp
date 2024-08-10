namespace Server
{
    public class ActionbarRef
    {
        public BaseAction Action { get; set; }
        public Item Item { get; set; }
        public int SlotId { get; set; }

        public ActionbarRef(BaseAction action, Item item, int slotId)
        {
            this.Action = action;
            this.Item = item;
            this.SlotId = slotId;
        }
    }

    public class Player: Humanoid
    {
        public static Dictionary<string, Player> Players = new Dictionary<string, Player>();
        public static HashSet<string> OnlinePlayers = new HashSet<string>();
        public static Dictionary<string, object> PlayerData = new Dictionary<string, object>();

        public override int UpdateIntensity { get; set; } = 1;
        public string AccountId { get; set; }
        public bool Loaded { get; set; } = false;
        public string Hashtag { get; set; }
        public SafeTrade Trade { get; set; }
        public Dictionary<int, ActionbarRef> Actionbar { get; set; } = new Dictionary<int, ActionbarRef>();
        public List<string> TooltipSended { get; set; } = new List<string>();
        public Dictionary<string, object> VendorList { get; set; } = new Dictionary<string, object>();
        public List<string> Friends { get; set; } = new List<string>();
        public List<string> FriendsRequests { get; set; } = new List<string>();

        // Gathering
        public GatherableResource GatherableInteract { get; set; } = null;
        public Gatherable GatherableSpot { get; set; } = null;

        // Quest
        public List<Quest> Quests { get; set; } = new List<Quest>();
        public int DailyQuestsIndex { get; set; } = 1;
        public DailyQuests DailyQuest { get; set; }

        // Guild
        public int CreateGuildCost { get; set; } = 20000;

        // Taming
        public bool InTamingProgress { get; set; } = false;

        // Event
        public bool InEvent { get; set; } = false;
        public MapEventType EventMapType { get; set; }
        public string EventMapId { get; set; }
        public string EventMap { get; set; }
        public Vector3 EventPosition { get; set; }

        public static Player GetPlayerByTag(string hashtag)
        {
            foreach (var player in Players.Values)
            {
                if (player.Hashtag.Equals(hashtag, StringComparison.OrdinalIgnoreCase))                
                    return player;                
            }

            return null;
        }

        public static Player? GetPlayer(string characterId)
        {
            foreach (var player in Players.Values)
            {
                if (player.CharacterId.Equals(characterId, StringComparison.OrdinalIgnoreCase))                
                    return player;                
            }

            return null;
        }

        public static void RefreshOnlinePlayer()
        {
            var playersOnline = new HashSet<string>();

            foreach (var player in Players.Values)
            {
                if (player.LastUpdate > DateTimeOffset.UtcNow.ToUnixTimeMilliseconds())                
                    playersOnline.Add(player.CharacterId);                
            }

            OnlinePlayers = playersOnline;
        }


        public void Save()
        {

        }

        public Task SaveToDatabase()
        {
            return Task.CompletedTask;

        }

        public override void Destroy()
        {

        }
    }
}
