using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server
{
    public enum MapsInstanceType
    {
        NotSet,
        IndividualInstance,
        PartyInstance,
        GuildInstance
    }

    [Table("server-maps")]
    public class MapsEntity
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string LevelInEngine { get; set; }

        [Required]
        public bool Instantiable { get; set; } = false;

        public MapsInstanceType InstanceType { get; set; } = MapsInstanceType.NotSet;

        public string ServerProxy { get; set; }
    }
}
