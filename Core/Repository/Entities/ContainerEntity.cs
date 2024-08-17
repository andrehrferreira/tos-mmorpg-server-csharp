using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server
{
    [Table("containers")]
    public class ContainerEntity
    {
        [Key]
        [Required]
        public string ContainerId { get; set; }

        [Required]
        public string CharacterId { get; set; }

        public string Items { get; set; }
    }
}
