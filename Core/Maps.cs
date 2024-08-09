using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        public Dictionary<int, Gatherable> FoliageIndex = new Dictionary<int, Gatherable>();
        public Dictionary<string, Gatherable> Foliage = new Dictionary<string, Gatherable>();

        public Maps(string id, string name)
        {
            ID = id;
            Name = name;
            GetRespawns();
        }

        public static Maps? GetMap(string name)
        {
            return MapsInstances.TryGetValue(name, out var map) ? map : null;
        }

        public static Entity? GetEntity(string mapName, string entityId)
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

        public Entity FindEntityById(string entityId)
        {
            return (EntitiesIndexById.TryGetValue(entityId, out var entity)) ? entity : null;
        }

        public void GetRespawns()
        {

        }
    }
}
