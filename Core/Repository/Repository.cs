using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Bson.Serialization;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Conventions;
using DotNetEnv;
using Newtonsoft.Json;

namespace Server
{
    public static partial class Repository
    {
        private static readonly Lazy<Sqlite> _instance = new Lazy<Sqlite>(() => new Sqlite());
        public static Sqlite Context => _instance.Value;

        public static MongoClient Client;
        public static IMongoDatabase DbMongo;

        public static IMongoCollection<AuthenticateModel> AuthenticateCollection;
        public static IMongoCollection<ServerModel> ServerCollection;

        public static List<ServerModel> ServerList = new List<ServerModel>();
        public static string ServerListJson;

        public static void Initialize ()
        {
            try
            {
                BsonSerializer.RegisterSerializer(new GuidSerializer(GuidRepresentation.Standard));

                BsonDefaults.GuidRepresentation = GuidRepresentation.Standard;
                BsonDefaults.GuidRepresentationMode = GuidRepresentationMode.V3;

                ConventionRegistry.Register("CamelCaseConvention", new ConventionPack { new CamelCaseElementNameConvention() }, v => true);
                ConventionRegistry.Register("EnumStringConvention", new ConventionPack { new EnumRepresentationConvention(BsonType.String) }, v => true);
                ConventionRegistry.Register("IgnoreDefaultValue", new ConventionPack() { new IgnoreIfDefaultConvention(true) }, v => true);

                BsonClassMap.RegisterClassMap<AuthenticateModel>(cm =>
                {
                    cm.AutoMap();
                    cm.MapIdProperty(pd => pd.Id).SetElementName("_id");
                });

                BsonClassMap.RegisterClassMap<ServerModel>(cm =>
                {
                    cm.AutoMap();
                    cm.MapIdProperty(pd => pd.Id).SetElementName("_id");
                });

                Logger.Log($"Connecting to MongoDB...");
                Client = new MongoClient(Env.GetString("MONGODB_URL"));
                Logger.Log($"MongoDB connected!");

                DbMongo = Client.GetDatabase("tos");

                AuthenticateCollection = DbMongo.GetCollection<AuthenticateModel>("Accounts");
                ServerCollection = DbMongo.GetCollection<ServerModel>("Servers");

                AuthenticateCollection.Indexes.CreateOne(
                    new CreateIndexModel<AuthenticateModel>(
                        new IndexKeysDefinitionBuilder<AuthenticateModel>().Ascending(
                            new StringFieldDefinition<AuthenticateModel>(nameof(AuthenticateModel.username))
                        ),
                        new CreateIndexOptions() { Unique = true }
                    )
                );

                ServerList = ServerCollection.Find(FilterDefinition<ServerModel>.Empty).ToList();
                ServerListJson = JsonConvert.SerializeObject(ServerList);
                //Logger.Log($"Found {ServerList.Count} servers.");
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
            }
        }
    }
}
