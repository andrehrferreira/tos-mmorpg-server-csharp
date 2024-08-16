using Newtonsoft.Json;
using System;
using static MongoDB.Bson.Serialization.Serializers.SerializerHelper;

namespace Server
{
    public enum GuildAccessLevel
    {
        Recruter,
        Member,
        Staff,
        Owner
    }

    public struct GuildMember
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Tag { get; set; }
        public GuildAccessLevel Plevel { get; set; }
    }

    public struct GuildJoinRequest
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Tag { get; set; }
    }

    public struct GuildData
    {
        public string Id { get; set; }
        public string Owner { get; set; }
        public string GuildName { get; set; }
        public List<GuildMember> Members { get; set; }
        public int MaxMembers { get; set; }
        public int Level { get; set; }
        public string Flag { get; set; }
        public List<GuildJoinRequest> Requests { get; set; }
    }

    public class Guilds
    {
        public static Dictionary<string, Guild> CachedGuilds = new Dictionary<string, Guild>();
        public static Dictionary<string, Guild> CachedGuildsByName = new Dictionary<string, Guild>();

        public static Guild FromDatabase(GuildEntity data)
        {
            var guild = new Guild(
                data.Id,
                data.Owner,
                data.GuildName,
                data.Flag,
                data.MaxMembers,
                data.Level,
                data.Requests
            );

            CachedGuilds[data.Id] = guild;
            CachedGuildsByName[data.GuildName] = guild;

            guild.ParseMembers(JsonConvert.DeserializeObject<List<GuildMember>>(data.Members));

            return guild;
        }

        public static bool HasGuild(string id)
        {
            return CachedGuilds.ContainsKey(id);
        }

        public static bool HasGuildByName(string name)
        {
            return CachedGuildsByName.ContainsKey(name);
        }

        public static Guild GetGuild(string id)
        {
            return CachedGuilds.TryGetValue(id, out var guild) ? guild : null;
        }

        public static List<dynamic> GetGuilds()
        {
            var guildList = new List<dynamic>();

            foreach (var guild in CachedGuilds.Values)
            {
                if (guildList.Count < 50)
                {
                    guildList.Add(new
                    {
                        id = guild.Id,
                        guildName = guild.Name,
                        members = guild.Members.Count,
                        flag = guild.Flag,
                        maxMembers = guild.MaxMembers,
                        level = guild.Level
                    });
                }
            }

            return guildList;
        }
    }

    public class Guild
    {
        public string Owner { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Flag { get; set; }
        public List<GuildMember> Members { get; set; } = new List<GuildMember>();
        public List<GuildJoinRequest> Requests { get; set; } = new List<GuildJoinRequest>();
        public int MaxMembers { get; set; }
        public int Level { get; set; }

        public Guild(
            string id,
            string owner,
            string name,
            string flag = "",
            int maxMembers = 100,
            int level = 1,
            string requests = "[]"
        )
        {
            Id = id;
            Owner = owner;
            Name = name;
            Flag = flag;
            MaxMembers = maxMembers;
            Level = level;
            Requests = JsonConvert.DeserializeObject<List<GuildJoinRequest>>(requests) ?? new List<GuildJoinRequest>();
        }

        public void ParseMembers(List<GuildMember> data)
        {
            foreach (var member in data)            
                Members.Add(member);            
        }

        public async Task Update()
        {
            Guilds.CachedGuilds[Id] = this;
            Guilds.CachedGuildsByName[Name] = this;

            var guild = Serialize(true);

            var members = JsonConvert.SerializeObject(
                guild.Members.Select(member => new
                {
                    id = member.Id,
                    name = member.Name,
                    plevel = member.Plevel,
                    tag = member.Tag
                }).ToList()
            );

            await Repository.UpdateGuild(new GuildEntity
            {
                Id = guild.Id,
                Owner = guild.Owner,
                GuildName = guild.GuildName,
                Members = members,
                Flag = guild.Flag,
                Level = guild.Level,
                MaxMembers = guild.MaxMembers,
                Requests = JsonConvert.SerializeObject(guild.Requests)
            });
        }

        public bool HasPlevel(GuildAccessLevel plevel, Player player)
        {
            var member = Members.FirstOrDefault(m => m.Id == player.CharacterId);
            return member.Plevel >= plevel;
        }

        public async Task AddRequest(Player player)
        {
            var exists = Requests.Any(request => request.Id == player.CharacterId);

            if (!exists && player.Guild == null && Members.Count < MaxMembers)
            {
                if (Members.Count == 0)
                {
                    Members.Add(new GuildMember
                    {
                        Id = player.CharacterId,
                        Name = player.Name,
                        Plevel = GuildAccessLevel.Owner,
                        Tag = player.Hashtag
                    });

                    Owner = player.CharacterId;
                    player.Guild = this;
                    player.Save();
                    player.SaveToDatabase();

                    var entities = new HashSet<Entity>(player.AreaOfInterest);

                    foreach (var entity in entities.OfType<Player>())
                    {
                        Packet.Get(ServerPacketType.JoinGuild).Send(entity, new
                        {
                            entityId = player.MapIndex,
                            guildId = this.Id,
                            guildName = this.Name
                        });
                    }

                    await Update();

                    Packet.Get(ServerPacketType.SystemMessage).Send(player.Socket, "Congratulations, you are now the owner of the guild.");
                    Packet.Get(ServerPacketType.GuildData).Send(player, JsonConvert.SerializeObject(Serialize(Owner == player.CharacterId)));
                }
                else
                {
                    Requests.Add(new GuildJoinRequest
                    {
                        Id = player.CharacterId,
                        Name = player.Name,
                        Tag = player.Hashtag
                    });

                    await Update();
                    Packet.Get(ServerPacketType.SystemMessage).Send(player.Socket, $"You sent a request to join the guild \"{this.Name}\".");
                }
            }
            else if (Members.Count >= MaxMembers)
            {
                Packet.Get(ServerPacketType.SystemMessage).Send(player.Socket, "The guild already has as many members as possible at the moment.");
            }
            else
            {
                Packet.Get(ServerPacketType.SystemMessage).Send(player.Socket, "You have already sent a request to join the guild.");
            }
        }

        public async Task AcceptRequest(Player player, string requestId)
        {
            if (!HasPlevel(GuildAccessLevel.Staff, player))
            {
                Packet.Get(ServerPacketType.SystemMessage).Send(player.Socket, "You do not have permission to accept requests.");
                return;
            }

            var requestIndex = Requests.FindIndex(request => request.Id == requestId);

            if (requestIndex == -1)
            {
                Packet.Get(ServerPacketType.SystemMessage).Send(player.Socket, "Request not found.");
                return;
            }

            if (Members.Count >= MaxMembers)
            {
                Packet.Get(ServerPacketType.SystemMessage).Send(player.Socket, "The total number of members has already been reached for now.");
                return;
            }

            var request = Requests[requestIndex];
            Requests.RemoveAt(requestIndex);
            var newMember = Player.GetPlayerByTag(request.Tag);

            if (newMember != null)
            {
                Members.Add(new GuildMember
                {
                    Id = request.Id,
                    Name = request.Name,
                    Plevel = GuildAccessLevel.Recruter,
                    Tag = request.Tag
                });

                newMember.Guild = this;
                newMember.Save();
                newMember.SaveToDatabase();

                var entities = new HashSet<Entity>(newMember.AreaOfInterest);

                foreach (var entity in entities.OfType<Player>())
                {
                    Packet.Get(ServerPacketType.JoinGuild).Send(entity, new
                    {
                        entityId = newMember.MapIndex,
                        guildId = this.Id,
                        guildName = this.Name
                    });
                }
            }

            await Update();

            Packet.Get(ServerPacketType.SystemMessage).Send(player.Socket, $"Request accepted. {request.Name} is now a member of the guild.");
            Packet.Get(ServerPacketType.GuildData).Send(player, JsonConvert.SerializeObject(Serialize(Owner == player.CharacterId)));
        }

        public async Task DenyRequest(Player player, string requestId)
        {
            if (!HasPlevel(GuildAccessLevel.Staff, player))
            {
                Packet.Get(ServerPacketType.SystemMessage).Send(player.Socket, "You do not have permission to deny requests.");
                return;
            }

            var requestIndex = Requests.FindIndex(request => request.Id == requestId);

            if (requestIndex == -1)
            {
                Packet.Get(ServerPacketType.SystemMessage).Send(player.Socket, "Request not found.");
                return;
            }

            Requests.RemoveAt(requestIndex);

            await Update();

            Packet.Get(ServerPacketType.SystemMessage).Send(player.Socket, "Request denied.");
            Packet.Get(ServerPacketType.GuildData).Send(player, JsonConvert.SerializeObject(Serialize(Owner == player.CharacterId)));
        }

        public async Task RemoveGuildMember(Player player, string characterId)
        {
            if (!HasPlevel(GuildAccessLevel.Staff, player))
            {
                Packet.Get(ServerPacketType.SystemMessage).Send(player.Socket, "You do not have permission to remove members.");
                return;
            }

            var memberIndex = Members.FindIndex(member => member.Id == characterId);

            if (memberIndex == -1)
            {
                Packet.Get(ServerPacketType.SystemMessage).Send(player.Socket, "Member not found.");
                return;
            }

            var removedMember = Members[memberIndex];
            Members.RemoveAt(memberIndex);

            var removedPlayer = Player.GetPlayerByTag(removedMember.Tag);
            if (removedPlayer != null)
            {
                removedPlayer.Guild = null;
                removedPlayer.Save();
                removedPlayer.SaveToDatabase();
            }

            // Update local storage
            var character = Player.GetData(removedPlayer.CharacterId);
            character.GuildId = null;
            character.GuildName = null;
            Player.FromDatabase(character);

            // Update database
            await Update();

            await Repository.UpdateCharacter(removedPlayer.CharacterId, new CharacterEntity{ GuildId = (string)null, GuildName = (string)null });

            Packet.Get(ServerPacketType.SystemMessage).Send(player.Socket, "Member removed successfully.");
            Packet.Get(ServerPacketType.GuildData).Send(player, JsonConvert.SerializeObject(Serialize(Owner == player.CharacterId)));
        }

        public async Task LeaveGuild(Player player)
        {
            var memberIndex = Members.FindIndex(member => member.Id == player.CharacterId);

            if (memberIndex == -1)
            {
                Packet.Get(ServerPacketType.SystemMessage).Send(player.Socket, "Member not found.");
                return;
            }

            var removedMember = Members[memberIndex];

            if (removedMember.Plevel <= GuildAccessLevel.Staff || (removedMember.Plevel == GuildAccessLevel.Owner && Members.Count <= 1))
            {
                Members.RemoveAt(memberIndex);

                var removedPlayer = Player.GetPlayerByTag(removedMember.Tag);
                if (removedPlayer != null)
                {
                    removedPlayer.Guild = null;
                    removedPlayer.Save();
                    removedPlayer.SaveToDatabase();
                }

                // Update local storage
                var character = Player.GetData(player.CharacterId);
                character.GuildId = null;
                character.GuildName = null;
                Player.FromDatabase(character);

                await Repository.UpdateCharacter(player.CharacterId, new CharacterEntity{ GuildId = (string)null, GuildName = (string)null });

                Packet.Get(ServerPacketType.SystemMessage).Send(player.Socket, "You left the guild.");
                Packet.Get(ServerPacketType.GuildData).Send(player, JsonConvert.SerializeObject(Serialize(Owner == player.CharacterId)));
            }
            else if (removedMember.Plevel == GuildAccessLevel.Owner && Members.Count > 1)
            {
                Packet.Get(ServerPacketType.SystemMessage).Send(player.Socket, "To close the guild, you need to remove all members first.");
            }
        }

        public GuildData Serialize(bool returnRequests = false)
        {
            var dataBase = new GuildData
            {
                Id = Id,
                Owner = Owner,
                GuildName = Name,
                Members = Members,
                MaxMembers = MaxMembers,
                Level = Level,
                Flag = Flag,
                Requests = returnRequests ? Requests : new List<GuildJoinRequest>()
            };

            return dataBase;
        }
    }
}
