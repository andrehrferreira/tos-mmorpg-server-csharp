using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server
{
    [Table("characters")]
    public class CharacterEntity
    {
        [Key]
        [Required]
        public string Id { get; set; }

        [Required]
        public string AccountId { get; set; }

        [Required]
        public bool Admin { get; set; } = false;

        [Required]
        public string Name { get; set; }

        [Required]
        public string Hashtag { get; set; }

        [Required]
        public string Visual { get; set; }

        public string GuildId { get; set; }

        public string GuildName { get; set; }

        [Required]
        public int Speed { get; set; } = 5;

        [Required]
        public int AdminSpeed { get; set; } = 5;

        [Required]
        public string Skills { get; set; }

        public string Proficiencies { get; set; }

        [Required]
        public string Inventory { get; set; }

        [Required]
        public string InventoryId { get; set; }

        public string Actionbar { get; set; }

        [Required]
        public bool Pvpflag { get; set; } = false;

        [Required]
        public int Str { get; set; } = 1;

        [Required]
        public int Dex { get; set; } = 1;

        [Required]
        public int Int { get; set; } = 1;

        [Required]
        public int Vig { get; set; } = 1;

        [Required]
        public int Agi { get; set; } = 1;

        [Required]
        public int Luc { get; set; } = 1;

        [Required]
        public int Life { get; set; } = 100;

        [Required]
        public int Mana { get; set; } = 10;

        [Required]
        public int Stamina { get; set; } = 10;

        [Required]
        public string Map { get; set; }

        [Required]
        public int X { get; set; }

        [Required]
        public int Y { get; set; }

        [Required]
        public int Z { get; set; }

        [Required]
        public int R { get; set; }

        public string ChestArmor { get; set; }

        public string HelmetArmor { get; set; }

        public string BootsArmor { get; set; }

        public string GlovesArmor { get; set; }

        public string PantsArmor { get; set; }

        public string Robe { get; set; }

        public string Cloak { get; set; }

        public string Ring01 { get; set; }

        public string Ring02 { get; set; }

        public string Necklace { get; set; }

        public string Offhand { get; set; }

        public string Mainhand { get; set; }

        public string Instrument { get; set; }

        public string Pet { get; set; }

        public string Mount { get; set; }

        public string PickaxeTool { get; set; }

        public string AxeTool { get; set; }

        public string ScytheTool { get; set; }

        [Required]
        public int Karma { get; set; } = 0;

        [Required]
        public int PlayerKills { get; set; } = 0;

        [Required]
        public int CriminalStatus { get; set; } = 0;

        [Required]
        public bool Mounted { get; set; } = false;

        public string MountId { get; set; }

        public string Pets { get; set; }

        [Required]
        public int States { get; set; } = 0;

        [Required]
        public int StatsPoints { get; set; } = 0;

        [Required]
        public int StatsCap { get; set; } = 225;

        public string Party { get; set; }

        [Required]
        public int DailyQuestsIndex { get; set; } = 1;

        [Required]
        public string DailyQuestsMetadata { get; set; } = "{}";

        [Required]
        public string Quests { get; set; } = "[]";

        [Required]
        public string Friends { get; set; } = "[]";

        [Required]
        public string FriendsRequests { get; set; } = "[]";

        // Events
        public bool? InEvent { get; set; } = false;

        public MapEventType? EventMapType { get; set; } = MapEventType.None;

        public string EventMapId { get; set; } = "";

        public string EventMap { get; set; } = "";

        public int EventX { get; set; } = 0;

        public int EventY { get; set; } = 0;

        public int EventZ { get; set; } = 0;

        public string Archivements { get; set; } = "[]";
    }
}
