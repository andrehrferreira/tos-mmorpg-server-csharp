using Microsoft.EntityFrameworkCore;

namespace Server
{
    public class Db: DbContext
    {
        public DbSet<CharacterEntity> Characters { get; set; }
        public DbSet<ContainerEntity> Containers { get; set; }        
        public DbSet<GuildEntity> Guilds { get; set; }
        public DbSet<ItemEntity> Items { get; set; }
        public DbSet<LogsEntity> Logs { get; set; }
        public DbSet<MapsEntity> Maps { get; set; }
        public DbSet<RespawnEntity> Respawns { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "database.sqlite");
            optionsBuilder.UseSqlite($"Data Source={path}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Character
            modelBuilder.Entity<CharacterEntity>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasDatabaseName("idx_character_id");

                entity.HasIndex(e => e.AccountId)
                    .HasDatabaseName("idx_character_accountId");

                entity.HasIndex(e => e.Hashtag)
                    .HasDatabaseName("idx_character_hashtag");

                entity.Property(e => e.Admin)
                    .HasDefaultValue(false);

                entity.Property(e => e.Speed)
                    .HasDefaultValue(5);

                entity.Property(e => e.AdminSpeed)
                    .HasDefaultValue(5);

                entity.Property(e => e.Pvpflag)
                    .HasDefaultValue(false);

                entity.Property(e => e.Str)
                    .HasDefaultValue(1);

                entity.Property(e => e.Dex)
                    .HasDefaultValue(1);

                entity.Property(e => e.Int)
                    .HasDefaultValue(1);

                entity.Property(e => e.Vig)
                    .HasDefaultValue(1);

                entity.Property(e => e.Agi)
                    .HasDefaultValue(1);

                entity.Property(e => e.Luc)
                    .HasDefaultValue(1);

                entity.Property(e => e.Life)
                    .HasDefaultValue(100);

                entity.Property(e => e.Mana)
                    .HasDefaultValue(10);

                entity.Property(e => e.Stamina)
                    .HasDefaultValue(10);

                entity.Property(e => e.Karma)
                    .HasDefaultValue(0);

                entity.Property(e => e.PlayerKills)
                    .HasDefaultValue(0);

                entity.Property(e => e.CriminalStatus)
                    .HasDefaultValue(0);

                entity.Property(e => e.Mounted)
                    .HasDefaultValue(false);

                entity.Property(e => e.States)
                    .HasDefaultValue(0);

                entity.Property(e => e.StatsPoints)
                    .HasDefaultValue(0);

                entity.Property(e => e.StatsCap)
                    .HasDefaultValue(225);

                entity.Property(e => e.DailyQuestsIndex)
                    .HasDefaultValue(1);

                entity.Property(e => e.DailyQuestsMetadata)
                    .HasDefaultValue("{}");

                entity.Property(e => e.Quests)
                    .HasDefaultValue("[]");

                entity.Property(e => e.Friends)
                    .HasDefaultValue("[]");

                entity.Property(e => e.FriendsRequests)
                    .HasDefaultValue("[]");

                entity.Property(e => e.InEvent)
                    .HasDefaultValue(false);

                entity.Property(e => e.EventMapType)
                    .HasDefaultValue(MapEventType.None);

                entity.Property(e => e.EventMapId)
                    .HasDefaultValue("");

                entity.Property(e => e.EventMap)
                    .HasDefaultValue("");

                entity.Property(e => e.EventX)
                    .HasDefaultValue(0);

                entity.Property(e => e.EventY)
                    .HasDefaultValue(0);

                entity.Property(e => e.EventZ)
                    .HasDefaultValue(0);

                entity.Property(e => e.Archivements)
                    .HasDefaultValue("[]");
            });

            //Container
            modelBuilder.Entity<ContainerEntity>(entity =>
            {
                entity.HasIndex(e => e.ContainerId)
                    .HasDatabaseName("idx_container_containerId");
            });
                    
            //Guild
            modelBuilder.Entity<GuildEntity>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasDatabaseName("idx_guild_id");

                entity.HasIndex(e => e.Owner)
                    .HasDatabaseName("idx_guild_owner");

                entity.Property(e => e.CreateAt)
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Members)
                    .HasDefaultValue("[]");

                entity.Property(e => e.Flag)
                    .HasDefaultValue("{}");

                entity.Property(e => e.MaxMembers)
                    .HasDefaultValue(100);

                entity.Property(e => e.Level)
                    .HasDefaultValue(1);

                entity.Property(e => e.Requests)
                    .HasDefaultValue("[]");
            });

            //Items
            modelBuilder.Entity<ItemEntity>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasDatabaseName("idx_item_id");

                entity.HasIndex(e => e.Owner)
                    .HasDatabaseName("idx_item_owner");

                entity.HasIndex(e => e.ContainerId)
                    .HasDatabaseName("idx_item_containerId");

                entity.Property(e => e.Owner)
                    .HasDefaultValue("1");

                entity.Property(e => e.Amount)
                    .HasDefaultValue(1);

                entity.Property(e => e.SlotId)
                    .HasDefaultValue(0);
            });

            //Logs
            modelBuilder.Entity<LogsEntity>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasDatabaseName("idx_logger_id");

                entity.HasIndex(e => e.Type)
                    .HasDatabaseName("idx_logger_type");
            });

            //Maps
            modelBuilder.Entity<MapsEntity>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasDatabaseName("idx_map_id");

                entity.HasIndex(e => e.Name)
                    .HasDatabaseName("idx_map_name");

                entity.HasIndex(e => e.LevelInEngine)
                    .HasDatabaseName("idx_map_levelInEngine");

                entity.HasIndex(e => e.ServerProxy)
                    .HasDatabaseName("idx_map_serverProxy");

                entity.Property(e => e.Instantiable)
                    .HasDefaultValue(false);

                entity.Property(e => e.InstanceType)
                    .HasDefaultValue(MapsInstanceType.NotSet);
            });

            //Respawn
            modelBuilder.Entity<RespawnEntity>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasDatabaseName("idx_respawn_id");

                entity.HasIndex(e => e.Map)
                    .HasDatabaseName("idx_respawn_map");

                entity.Property(e => e.Timer)
                    .HasDefaultValue(60);

                entity.Property(e => e.RespawnOnStart)
                    .HasDefaultValue(false);

                entity.Property(e => e.Timeout)
                    .HasDefaultValue(0);
            });
        }
    }
}
