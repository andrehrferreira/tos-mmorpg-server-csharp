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

        public bool Admin { get; set; } = false;

        [Required]
        public string Name { get; set; }

        [Required]
        public string Hashtag { get; set; }

        [Required]
        public string Visual { get; set; }

        public string GuildId { get; set; }

        public string GuildName { get; set; }

        public int Speed { get; set; } = 5;
        public int AdminSpeed { get; set; } = 5;
        public string Skills { get; set; }
        public string Proficiencies { get; set; }
        public string Inventory { get; set; }
        public string InventoryId { get; set; }
        public string Actionbar { get; set; }
        public bool Pvpflag { get; set; } = false;

        // Stats
        public int Str { get; set; } = 1;
        public int Dex { get; set; } = 1;
        public int Int { get; set; } = 1;
        public int Vig { get; set; } = 1;
        public int Agi { get; set; } = 1;
        public int Luc { get; set; } = 1;
        public int Life { get; set; } = 100;
        public int Mana { get; set; } = 10;
        public int Stamina { get; set; } = 10;

        [Required]
        public string Map { get; set; }

        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public int R { get; set; }

        // Equipments
        public string ChestArmor { get; set; }
        public string HelmetArmor { get; set; }
        public string BootsArmor { get; set; }
        public string GlovesArmor { get; set; }
        public string PantsArmor { get; set; }
        public string Robe { get; set; }
        public string Cloak { get; set; }
        public string Ring01 { get; set; }
        public string Ring02 { get; set; }
        public string Necklance { get; set; }
        public string Offhand { get; set; }
        public string Mainhand { get; set; }
        public string Instrument { get; set; }
        public string Pet { get; set; }
        public string Mount { get; set; }
        public string PickaxeTool { get; set; }
        public string AxeTool { get; set; }
        public string ScytheTool { get; set; }

        public int Karma { get; set; } = 0;
        public int PlayerKills { get; set; } = 0;
        public int CriminalStatus { get; set; } = 0;
        public bool Mounted { get; set; } = false;

        public string MountId { get; set; }
        public string Pets { get; set; }
        public int States { get; set; } = 0;
        public int StatsPoints { get; set; } = 0;
        public int StatsCap { get; set; } = 225;

        public string Party { get; set; }

        public int DailyQuestsIndex { get; set; } = 1;
        public string DailyQuestsMetadata { get; set; } = "{}";
        public string Quests { get; set; } = "[]";
        public string Friends { get; set; } = "[]";
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
