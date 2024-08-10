using System.ComponentModel.DataAnnotations.Schema;

namespace Server
{
    public abstract class BaseEntity
    {
        [Column("createdAt")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("updatedAt")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
