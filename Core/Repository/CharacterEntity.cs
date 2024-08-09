using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Server.Repository
{
    [Table("characters")]
    [Index(nameof(Id), Name = "idx_character_id")]
    [Index(nameof(AccountId), Name = "idx_character_accountId")]
    [Index(nameof(Hashtag), Name = "idx_character_hashtag")]
    public class CharacterEntity: BaseEntity
    {
        [Key]
        [Column("id", TypeName = "nvarchar(50)")]
        public string Id { get; set; }

        [Column("accountId", TypeName = "nvarchar(50)", Nullable = false)]
        public string AccountId { get; set; }

        [Column("admin", TypeName = "bit", Nullable = false)]
        public bool Admin { get; set; } = false;

        [Column("name", TypeName = "nvarchar(100)", Nullable = false)]
        public string Name { get; set; }

        [Column("hashtag", TypeName = "nvarchar(50)", Nullable = false)]
        public string Hashtag { get; set; }
    }
}
