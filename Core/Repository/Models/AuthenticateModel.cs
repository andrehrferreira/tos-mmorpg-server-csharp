using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Server
{
    [BsonIgnoreExtraElements]
    public class AuthenticateModel
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string hashtag { get; set; }
        public string[] othersId { get; set; }
        public string emailToken { get; set; }
        public string emailValidationCode { get; set; }
        public bool emailValidation { get; set; }
        public DateTime emailLastSendCode { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public Plevel plevel { get; set; }
        public DateTime lastLogin { get; set; }
        public string pin { get; set; }
        public string optin { get; set; }
        public bool twoFactorEnabled { get; set; }
        public string fingerprints { get; set; }
        public bool block { get; set; }
        public int blockTimeout { get; set; }
        public bool banned { get; set; }
        public string bannedReason { get; set; }
        public string banAdminId { get; set; }
        public DateTime banDatetime { get; set; }
    }
}
