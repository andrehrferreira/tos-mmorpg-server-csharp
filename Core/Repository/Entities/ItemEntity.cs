using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server
{
    [Table("items")]
    public class ItemEntity
    {
        [Required]
        public string Id { get; set; }

        [Required]
        [DefaultValue(1)]
        public string Owner { get; set; }

        [Required]
        public string ItemName { get; set; }

        [Required]
        [DefaultValue(1)]
        public int Amount { get; set; }

        public string CreateByAdmin { get; set; }

        public string ContainerId { get; set; }

        [DefaultValue(0)]
        public int SlotId { get; set; }

        public string Props { get; set; }
    }
}
