using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server
{
    [Table("respawns")]
    public class RespawnEntity
    {
        [Key]
        [Column("id")]
        [Required]
        public string Id { get; set; }

        [Column("map")]
        [Required]
        public string Map { get; set; }

        [Column("x")]
        [Required]
        public float X { get; set; }

        [Column("y")]
        [Required]
        public float Y { get; set; }

        [Column("z")]
        [Required]
        public float Z { get; set; }

        [Column("timer", TypeName = "int")]
        [Required]
        [DefaultValue(60)]
        public int Timer { get; set; } = 60;

        [Column("respawnOnStart")]
        [Required]
        public bool RespawnOnStart { get; set; }

        [Column("timeout", TypeName = "bigint")]
        [Required]
        [DefaultValue(0)]
        public long Timeout { get; set; } = 0;

        [Column("entities")]
        [Required]
        public string Entities { get; set; }
    }
}