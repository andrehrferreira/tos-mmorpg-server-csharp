using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Server
{
    [BsonIgnoreExtraElements]
    public class ServerModel
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string name { get; set; }
        public string ownerId { get; set; }
        public string apiUrl { get; set; }
        public string gameServer { get; set; }
        public string pingIP { get; set; }
        public bool privateServer { get; set; }
        public string type { get; set; }
        public string status { get; set; }
        public string rate { get; set; }
    }
}
