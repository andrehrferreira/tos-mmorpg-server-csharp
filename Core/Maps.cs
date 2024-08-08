
using System.Net.NetworkInformation;

namespace Server
{
    class Maps
    {
        static readonly Dictionary<string, Maps> MapsInstances = new Dictionary<string, Maps>();
        static float deltaTime = 0.3f; 

        public string Name;
        public string ID;
        public int mapTick;
        public int mapIndex = 20;

        //Entities
        public Dictionary<string, Entity> entitiesIndexById = new Dictionary<string, Entity>();
        public Dictionary<string, Entity> entitiesMapIndex = new Dictionary<string, Entity>();
        public int entitiesPersistentId = 1;
        
        //Respawn
        public Dictionary<string, Respawn> respawns = new Dictionary<string, Respawn>();

        //Gathering
        public static Dictionary<string, string> foliageInitialData = new Dictionary<string, string>();
        public Dictionary<int, Gatherable> foliageIndex = new Dictionary<int, Gatherable>();  
        public Dictionary<string, Gatherable> foliage = new Dictionary<string, Gatherable>();

        public Maps(string id, string name)
        {
            ID = id;
            Name = name;

        }

        public static void AddMap(string name, Maps map)
        {
            if(!MapsInstances.ContainsKey(name))
            {
                MapsInstances.Add(name, map);
            }            
        }

        

        public AddEntity()
        {

        }
    }
}
