using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server
{
    [Table("guilds")]
    public class GuildEntity
    {
        [Key]
        [Required]
        public string Id { get; set; }

        [Required]
        [DefaultValue(1)]
        public string Owner { get; set; }

        [Required]
        public string GuildName { get; set; }

        [Required]
        [Column(TypeName = "datetime")]
        public DateTime CreateAt { get; set; } = DateTime.UtcNow;

        [Required]
        [DefaultValue("[]")]
        public string Members { get; set; }

        [Required]
        [DefaultValue("{}")]
        public string Flag { get; set; }

        [Required]
        [DefaultValue(100)]
        public int MaxMembers { get; set; }

        [Required]
        [DefaultValue(1)]
        public int Level { get; set; }

        [Required]
        [DefaultValue("[]")]
        public string Requests { get; set; }
    }
}
