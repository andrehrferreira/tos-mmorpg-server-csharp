using Newtonsoft.Json;

namespace Server
{
    public class Maps
    {
        static readonly Dictionary<string, Maps> MapsInstances = new Dictionary<string, Maps>();
        public static float DeltaTime = 0.3f;

        public string Name;
        public string ID;
        public int MapTick;
        public int MapIndex = 20;

        //Entities
        public Dictionary<string, Entity> EntitiesIndexById = new Dictionary<string, Entity>();
        public Dictionary<string, Entity> EntitiesMapIndex = new Dictionary<string, Entity>();
        public int EntitiesPersistentId = 1;

        //Respawn
        public Dictionary<string, Respawn> Respawns = new Dictionary<string, Respawn>();

        //Gathering
        public static Dictionary<string, string> FoliageInitialData = new Dictionary<string, string>();
        public Dictionary<int, string> FoliageIndex = new Dictionary<int, string>();
        public Dictionary<string, Gatherable> Foliage = new Dictionary<string, Gatherable>();

        public Maps(string id, string name)
        {
            ID = id;
            Name = name;
            GetRespawns();
        }

        public static int ParseLevelData(string levelName, string dataFile)
        {
            var map = GetOrCreateMap(levelName);

            if (!string.IsNullOrEmpty(dataFile))
            {
                var parts = dataFile.Split('@');
                var indexItems = parts[0].Split('|');
                var dataItems = parts[1].Split('|');
                var indexArr = new Dictionary<int, string>();
                int totalSpots = 0;

                if(indexItems != null)
                {
                    foreach (var indexData in indexItems)
                    {
                        if (indexData != null)
                        {
                            var splitData = indexData.Split(':');

                            try
                            {
                                int id = int.Parse(splitData[0]);
                                string mesh = splitData[1];
                                indexArr[id] = mesh;
                            }
                            catch { }                               
                        }
                    }
                }

                map.FoliageIndex = indexArr;

                foreach (var dataPart in dataItems)
                {
                    try
                    {
                        var splitData = dataPart.Split(',');
                        int meshIndex = int.Parse(splitData[0]);
                        int type = int.Parse(splitData[1]);
                        int x = (int)Math.Round(float.Parse(splitData[2]));
                        int y = (int)Math.Round(float.Parse(splitData[3]));
                        int z = (int)Math.Round(float.Parse(splitData[4]));

                        string foliageId = $"{x}{y}{z}";
                        totalSpots++;

                        var gatherableSettings = new GatherableSettings
                        {
                            Map = levelName,
                            RespawnOnStart = true,
                            Timeout = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds(),
                            Timer = 120,
                            Entities = new List<GatherableType> { (GatherableType)type },
                            X = x,
                            Y = y,
                            Z = z,
                            MeshIndex = meshIndex,
                            FoliageId = foliageId
                        };

                        var gatherable = new Gatherable(gatherableSettings);
                        map.Foliage[foliageId] = gatherable;
                        map.Foliage[meshIndex.ToString()] = gatherable;
                    }
                    catch { }
                }

                map.RefreshMapInitialData();
                return totalSpots;
            }
            else
            {
                return 0;
            }
        }

        public static Maps GetMap(string name)
        {
            return MapsInstances.TryGetValue(name, out var map) ? map : null;
        }

        public static Entity GetEntity(string mapName, string entityId)
        {
            Maps? map = GetMap(mapName);
            return (map != null) ? map.FindEntityById(entityId) : null;
        }

        public static bool HasMap(string mapName)
        {
            return MapsInstances.ContainsKey(mapName);
        }

        public static bool CreateMap(string mapName)
        {
            if (!MapsInstances.ContainsKey(mapName))
            {
                string mapId = GUID.NewID();
                Maps map = new Maps(mapId, mapName);
                MapsInstances.Add(mapName, map);
                MapsInstances.Add(mapName.ToLower(), map);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string CreateInstance(string mapName)
        {
            string mapId = GUID.NewID();
            Maps map = new Maps(mapId, mapName);
            MapsInstances.Add(mapId, map);
            return mapId;
        }

        public static Maps GetOrCreateMap(string mapName)
        {
            if (!HasMap(mapName))
                CreateMap(mapName);

            return MapsInstances[mapName];
        }

        public async Task<string> JoinMap(Entity entity)
        {
            string currentId = GUID.IntToId(MapIndex++);

            if(EntitiesIndexById.Count > 0)
            {
                foreach (var otherEntity in EntitiesIndexById.Values)
                {
                    if(entity.Id == otherEntity.Id)
                    {
                        otherEntity.Socket?.Disconnect();

                        if (entity is Player currentPlayer)
                        {
                            currentPlayer.Save();
                            currentPlayer.SaveToDatabase();
                            currentPlayer.Destroy();
                        }

                        EntitiesIndexById.Remove(otherEntity.Id);
                        EntitiesMapIndex.Remove(otherEntity.MapIndex);

                        await Task.Delay(2000);
                    }
                }
            }

            if (entity is Player player)
            {
                player.Map = this;
                player.MapIndex = currentId;
                player.Socket.EntityId = currentId;
                player.SetMap(this, currentId);
            }
            else
            {
                entity.SetMap(this, currentId);
            }

            EntitiesIndexById.Add(entity.Id, entity);
            EntitiesMapIndex.Add(entity.MapIndex, entity);

            return currentId;
        }

        public void LeaveMap(Player player)
        {
            Player.Players.Remove(player.CharacterId);
            player.SaveToDatabase();
            player.Destroy();
            player.OnDestroy.OnNext(player);
            EntitiesIndexById.Remove(player.Id);
            EntitiesMapIndex.Remove(player.MapIndex);
            ValidateAndCleanIndices();
            player.SetMap(null, string.Empty);
        }

        public void ValidateAndCleanIndices()
        {
            HashSet<string> characterIdSet = new HashSet<string>();
            HashSet<string> entitiesToRemove = new HashSet<string>();

            foreach (var entityEntry in EntitiesIndexById)
            {
                var entity = entityEntry.Value;
                var entityId = entityEntry.Key;

                if (!string.IsNullOrEmpty(entity.CharacterId))
                {
                    if (characterIdSet.Contains(entity.CharacterId))
                    {
                        if (entity.Socket == null || !entity.Socket.IsConnected)
                        {
                            entitiesToRemove.Add(entityId);
                        }
                        else
                        {
                            foreach (var otherEntityEntry in EntitiesIndexById)
                            {
                                var otherEntity = otherEntityEntry.Value;
                                var otherEntityId = otherEntityEntry.Key;

                                if (otherEntity.CharacterId == entity.CharacterId && otherEntityId != entityId)
                                {
                                    if (otherEntity.Socket == null || !otherEntity.Socket.IsConnected)
                                    {
                                        entitiesToRemove.Add(otherEntityId);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        characterIdSet.Add(entity.CharacterId);
                    }
                }
            }

            foreach (var entityId in entitiesToRemove)
            {
                if (EntitiesIndexById.TryGetValue(entityId, out var entity))
                {
                    EntitiesIndexById.Remove(entityId);
                    EntitiesMapIndex.Remove(entity.MapIndex);

                    entity.Socket?.Close();
                    entity.OnDestroy.OnNext(entity);
                }
            }
        }

        public async Task TeleportTo(Player player, string waypoint)
        {
            foreach (var entity in player.AreaOfInterest)            
                entity.RemoveFromAreaOfInterest(player);
            
            player.Map.LeaveMap(player);
            player.Map = Maps.GetMap(Name);
            player.Socket.Character.Map = Name;
            player.SetMap(null, string.Empty);
            player.Save();
            await player.SaveToDatabase();
            //player.RefreshLocalPlayerData();

            await Task.Delay(1000);

            Packet.Get(ServerPacketType.LoadLevel)?.Send(player, new { LevelName = Name, Waypoint = waypoint });
        }

        //Respawn
        public async Task GetRespawns()
        {
            var respawns = await Repository.GetRespawns(Name);

            foreach (var respawn in respawns)
            {
                var entities = JsonConvert.DeserializeObject<List<string>>(respawn.Entities);
                var baseEntity = Entity.GetEntityBase(entities[0]);

                if (baseEntity != null)
                {
                    var tmpEntity = (Entity)Activator.CreateInstance(baseEntity.GetType());

                    Respawns[respawn.Id] = new Respawn(respawn.Id, new RespawnOptions
                    {
                        Map = respawn.Map,
                        RespawnOnStart = respawn.RespawnOnStart,
                        Timeout = respawn.Timeout,
                        Timer = (tmpEntity is Boss) ? 86400 : 300,
                        X = respawn.X,
                        Y = respawn.Y,
                        Z = respawn.Z,
                        Entities = entities
                    });
                }
            }            
        }

        public async Task CreateRespawn(Vector3 position, object entityNameOrNames)
        {
            var tmpId = GUID.NewID();
            List<string> entityNames;

            if (entityNameOrNames is string singleEntityName)
            {
                entityNames = new List<string> { singleEntityName };
            }
            else if (entityNameOrNames is List<string> entityNameList)
            {
                entityNames = entityNameList;
            }
            else
            {
                throw new ArgumentException("entityNameOrNames must be either a string or a List<string>.");
            }

            var baseEntity = Entity.GetEntityBase(entityNames[0]);

            if (baseEntity != null)
            {
                var tmpEntity = (Entity)Activator.CreateInstance(baseEntity.GetType());

                await Repository.CreateRespawn(new RespawnEntity
                {
                    Id = tmpId,
                    Map = Name,
                    RespawnOnStart = true,
                    Timeout = DateTimeOffset.UtcNow.ToUnixTimeSeconds(),
                    Timer = (tmpEntity is Boss) ? 86400 : 300,
                    X = position.X,
                    Y = position.Y,
                    Z = position.Z,
                    Entities = JsonConvert.SerializeObject(entityNames)
                });

                Respawns[tmpId] = new Respawn(tmpId, new RespawnOptions
                {
                    Map = Name,
                    RespawnOnStart = true,
                    Timeout = DateTimeOffset.UtcNow.ToUnixTimeSeconds(),
                    Timer = (tmpEntity is Boss) ? 86400 : 300,
                    X = position.X,
                    Y = position.Y,
                    Z = position.Z,
                    Entities = entityNames
                });
            }           
        }

        public async Task RemoveRespawn(string id)
        {
            if (Respawns.ContainsKey(id))
            {
                var respawn = Respawns[id];

                respawn.Destroy();

                await Repository.RemoveRespawn(id);

                respawn.EntityRespawned?.Destroy();

                Respawns.Remove(id);
            }
        }

        //Foliage
        public void AddFoliage(Gatherable instance, GatherableResource resource)
        {
            string currentId = GUID.NewID();
            resource.SetEntityId(currentId);
            Foliage[currentId] = instance;
        }

        public void SetFoliageAsCollected(string currentId)
        {
            if (Foliage.TryGetValue(currentId, out var resource))
            {
                resource.Collected();
                Foliage[currentId] = resource;
                RefreshMapInitialData();
            }
        }

        public void RemoveFoliage(string foliageId)
        {
            if (Foliage.ContainsKey(foliageId))
            {
                Foliage.Remove(foliageId);
            }
        }

        public void RefreshMapInitialData()
        {
            string data = string.Empty;

            foreach (var gatherable in Foliage.Values)
            {
                string locRef = $"{gatherable.Settings.X}{gatherable.Settings.Y}{gatherable.Settings.Z}";
                string foliageId = gatherable.EntityRespawned != null ? gatherable.EntityRespawned.FoliageId : "0";
                int tick = gatherable.EntityRespawned != null ? gatherable.EntityRespawned.Tick : 0;
                int enable = (gatherable.EntityRespawned != null && gatherable.EntityRespawned.Tick > 0) ? 1 : 0;

                data += (!string.IsNullOrEmpty(data) ? "|" : "") + $"{locRef},{foliageId},{enable},{tick}";
            }

            FoliageInitialData[Name] = data;
        }

        //Tick
        public static void Tick()
        {
            if (MapsInstances != null)
            {
                foreach (var map in MapsInstances.Values)
                {
                    map.OnTick();
                }
            }
        }

        public static void TickRespawn()
        {
            if (MapsInstances != null)
            {
                foreach (var map in MapsInstances.Values)
                {
                    map.OnTickRespawn();
                }
            }
        }

        public void OnTick()
        {
            MapTick++;

            foreach (var entity in EntitiesIndexById.Values)
            {
                switch (entity)
                {
                    case Player player: player.Tick(MapTick); break;
                    case Creature creature: creature.Tick(MapTick); break;
                    default: entity.Tick(MapTick); break;
                }
            }
        }

        public void OnTickRespawn()
        {
            foreach (var respawn in Respawns.Values)            
                respawn.Tick();
            
            foreach (var foliage in Foliage.Values)            
                foliage.Tick();            
        }

        //Entities
        public void CreateOrUpdateEntity(Entity entity)
        {
            bool hasEntity = EntitiesIndexById.ContainsKey(entity.Id);

            if (!hasEntity)
            {
                string currentId = GUID.IntToId(MapIndex++);
                EntitiesIndexById[entity.Id] = entity;
                EntitiesMapIndex[currentId] = entity;
            }
            else
            {
                EntitiesIndexById[entity.Id] = entity;
                EntitiesMapIndex[entity.MapIndex] = entity;
            }
        }

        public void RemoveEntity(Entity entity)
        {
            EntitiesIndexById.Remove(entity.Id);
            EntitiesMapIndex.Remove(entity.MapIndex);

            foreach (var other in entity.AreaOfInterest)
            {
                if (other.Socket != null)                
                    Packet.Get(ServerPacketType.RemoveEntity)?.Send(other, entity);                
            }
        }

        public Entity FindEntityById(string entityId)
        {
            return (EntitiesIndexById.TryGetValue(entityId, out var entity)) ? entity : null;
        }
    }
}
