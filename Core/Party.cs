using Newtonsoft.Json;

namespace Server
{
    public class Party
    {
        public static Dictionary<string, Party> PartySessions { get; private set; } = new Dictionary<string, Party>();

        public string Id { get; private set; }
        public Player Owner { get; private set; }
        public int MaxMembers { get; set; } = 5;
        public Dictionary<string, Player> Members { get; private set; } = new Dictionary<string, Player>();

        public Party(Player owner)
        {
            Id = GUID.NewID();
            Owner = owner;
            PartySessions[Id] = this;
            Members[owner.CharacterId] = owner;
        }

        public static Party GetSession(string id)
        {
            return PartySessions.TryGetValue(id, out var session) ? session : null;
        }

        public static void DestroySession(string id)
        {
            if (PartySessions.ContainsKey(id))
                PartySessions.Remove(id);
        }

        public static void UpdateParty(Party party)
        {
            if (PartySessions.ContainsKey(party.Id))
            {
                PartySessions[party.Id].Owner = party.Owner;
                PartySessions[party.Id].MaxMembers = party.MaxMembers;
                PartySessions[party.Id].Members = party.Members;
            }
        }

        public void RefreshCharacter(Player player)
        {
            if (Owner.CharacterId == player.CharacterId)
                Owner = player;

            Members[player.CharacterId] = player;
            var partyData = Serialize(player);

            Task.Delay(2000).ContinueWith(_ =>
            {
                Packet.Get(ServerPacketType.PartyData).Send(player, partyData);
            });
        }

        public void RequestMember(string characterId)
        {
            if (Player.Players.TryGetValue(characterId, out var player))
            {
                if (player != null && player.Party == null)
                    Packet.Get(ServerPacketType.RequestParty).Send(player, Id, Owner.Name);
                else
                    Packet.Get(ServerPacketType.SystemMessage)?.Send(Owner, "The player is already in another group.");
            }
        }

        public void JoinMember(Player player)
        {
            if (Members.Count < MaxMembers)
            {
                Members[player.CharacterId] = player;
                player.Party = this;
                player.PartyOwner = Owner;
                player.Save();
                Packet.Get(ServerPacketType.SystemMessage)?.Send(player, $"You have been accepted into the group organized by {Owner.Name}.");
                UpdateParty(this);

                foreach (var member in Members.Values)
                {
                    if (member.CharacterId != player.CharacterId)
                        Packet.Get(ServerPacketType.SystemMessage)?.Send(member, $"Member {player.Name} joined the group.");
                }

                Broadcast();
            }
            else
            {
                Packet.Get(ServerPacketType.SystemMessage)?.Send(player, "I'm joining a group that is already complete.");
            }
        }

        public void Leave(Player player)
        {
            if (Members.ContainsKey(player.CharacterId))
            {
                Members.Remove(player.CharacterId);
                player.Party = null;
                player.PartyOwner = null;
                player.Save();

                Packet.Get(ServerPacketType.PartyData).Send(player, SerializeLeaveData());

                if (Owner.CharacterId == player.CharacterId && Members.Count > 0)
                {
                    var newOwner = Members.Values.GetEnumerator();
                    if (newOwner.MoveNext())
                    {
                        Owner = newOwner.Current;

                        foreach (var member in Members.Values)                        
                            member.PartyOwner = Owner;                        

                        Packet.Get(ServerPacketType.SystemMessage)?.Send(Owner, "You have been promoted as group leader.");
                    }
                }

                UpdateParty(this);
                Packet.Get(ServerPacketType.SystemMessage)?.Send(player, "You left the group.");

                foreach (var member in Members.Values)                
                    Packet.Get(ServerPacketType.SystemMessage)?.Send(member, $"Member {player.Name} left the group.");
                
                Broadcast(true);
            }
        }

        public void Tick(int tickNumber)
        {
            if (tickNumber % 60 == 0)
                Broadcast();
        }

        public void Broadcast(bool force = false)
        {
            foreach (var player in Members.Values)
            {
                var partyData = Serialize(player, force);
                Packet.Get(ServerPacketType.PartyData).Send(player, partyData);
            }
        }

        public string Serialize(Player player, bool force = false)
        {
            var data = new
            {
                members = new List<object>(),
                isleader = player.CharacterId == Owner.CharacterId,
                force
            };

            foreach (var member in Members.Values)
            {
                if (member.CharacterId != player.CharacterId)
                {
                    data.members.Add(new
                    {
                        c = member.CharacterId,
                        n = member.Name,
                        l = member.Life,
                        ml = member.MaxLife,
                        m = member.Mana,
                        mm = member.MaxMana,
                        s = member.Stamina,
                        sm = member.MaxStamina,
                        a = member.LastUpdate > DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() + (30 * 1000),
                        o = member.CharacterId == Owner.CharacterId,
                        t = member.Hashtag
                    });
                }
            }

            return JsonConvert.SerializeObject(data);
        }

        private string SerializeLeaveData()
        {
            var data = new
            {
                members = new List<object>(),
                isleader = false,
                force = true
            };

            return JsonConvert.SerializeObject(data);
        }
    }
}
