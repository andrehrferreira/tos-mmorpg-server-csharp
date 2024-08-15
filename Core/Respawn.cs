namespace Server
{
    public class Respawn
    {
        public string Id { get; private set; }
        public IRespawn Settings { get; private set; }
        public Maps Map { get; private set; } = null;
        public Entity EntityRespawned { get; private set; } = null;
        private bool Removed { get; set; } = false;

        public Respawn(string id, IRespawn settings)
        {
            Id = id;
            Settings = settings;
            Map = Maps.GetMap(settings.Map);

            if (settings.RespawnOnStart)            
                CreateEntity();            
        }

        public void Tick()
        {
            if (EntityRespawned == null && !Removed && DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() > Settings.Timeout)
            {
                Settings.Timeout = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() + (Settings.Timer * 1000);
                CreateEntity();
            }
        }

        public void Destroy()
        {
            Removed = true;
        }

        private void CreateEntity()
        {
            EntityRespawned?.Destroy();

            var randomIndex = new Random().Next(Settings.Entities.Count);
            var entityName = Settings.Entities[randomIndex];
            var newEntity = Entity.Create(entityName);

            if (newEntity != null)
            {
                var respawnPosition = new Transform(
                    new Vector3(Settings.X, Settings.Y, Settings.Z),
                    Rotator.Zero,
                    Vector3.One
                );

                newEntity.Respawn = this;
                newEntity.OnDie.Subscribe(entity => entity.Respawn.EntityDie());
                newEntity.OnDestroy.Subscribe(entity => entity.Respawn.EntityDie());
                newEntity.Transform = respawnPosition;
                newEntity.RespawnPosition = respawnPosition.Position;
                EntityRespawned = newEntity;
                _ = Map.JoinMap(EntityRespawned);
            }
        }

        public void EntityDie()
        {
            Settings.Timeout = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() + (Settings.Timer * 1000);
            EntityRespawned = null;
        }

        public void RemoveRespawn()
        {
            Removed = true;
            _ = Map.RemoveRespawn(Id);
        }
    }
}
