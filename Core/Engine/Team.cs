
namespace Server
{
    public enum TeamKind
    {
        None,
        Monsters,
        NPCs,
        Players,
        Tower,
        Guards,
        Provocation,
        Team1,
        Team2,
        Pet
    }

    public class Team
    {
        public TeamKind Kind { get; private set; }
        public Entity Self { get; private set; }

        public Team(TeamKind kind, Entity self)
        {
            Kind = kind;
            Self = self;
        }

        public bool IsEnemyOf(Team other)
        {
            switch (Kind)
            {
                case TeamKind.Monsters:
                    return (other.Kind == TeamKind.Players && !other.Self.States.HasFlag((int)EntityStates.Invulnerable))
                           || other.Kind == TeamKind.Guards
                           || other.Kind == TeamKind.Provocation;

                case TeamKind.Players:
                    return other.Kind == TeamKind.None
                           || other.Kind == TeamKind.Monsters
                           || other.Kind == TeamKind.Provocation
                           || (other.Kind == TeamKind.Players && (other.Self != Self && (IsDuelZoneEnemy(other) || IsPlayerEnemy(other))))
                           || (other.Kind == TeamKind.Guards && Self.States.HasFlag((int)EntityStates.NegativeKarma));

                case TeamKind.Tower:
                    return true;

                case TeamKind.Guards:
                    return (other.Kind == TeamKind.Players && Self.States.HasFlag((int)EntityStates.NegativeKarma))
                           || other.Kind == TeamKind.Monsters;

                case TeamKind.Provocation:
                    return other.Kind == TeamKind.None
                           || other.Kind == TeamKind.Monsters
                           || other.Kind == TeamKind.Provocation
                           || other.Kind == TeamKind.Players;

                case TeamKind.Team1:
                    return other.Kind == TeamKind.Team2 && !other.Self.States.HasFlag((int)EntityStates.Invulnerable);

                case TeamKind.Team2:
                    return other.Kind == TeamKind.Team1 && !other.Self.States.HasFlag((int)EntityStates.Invulnerable);

                default:
                    return false;
            }
        }

        public bool IsAllyOf(Team other)
        {
            switch (Kind)
            {
                case TeamKind.Monsters:
                    return other.Kind == TeamKind.Monsters;

                case TeamKind.NPCs:
                    return true;

                case TeamKind.Players:
                    return other.Self.Id == Self.Id
                           || (other.Self.TeamOwner == Self.TeamOwner && other.Self.TeamOwner != null && Self.TeamOwner != null);

                case TeamKind.Guards:
                    return other.Kind != TeamKind.Players || !Self.States.HasFlag((int)EntityStates.NegativeKarma);

                case TeamKind.Provocation:
                    return false;

                case TeamKind.Tower:
                    return other.Kind == TeamKind.Tower || other.Kind == TeamKind.Players;

                case TeamKind.Team1:
                    return other.Kind == TeamKind.Team1;

                case TeamKind.Team2:
                    return other.Kind == TeamKind.Team2;

                case TeamKind.Pet:
                    return Self.TeamOwner == other.Self.TeamOwner || (Self as Pet)?.Owner?.CharacterId == other.Self.CharacterId;

                default:
                    return false;
            }
        }

        private bool IsDuelZoneEnemy(Team pt)
        {
            return Self.States.HasFlag((int)EntityStates.DuelZone)
                   && pt.Self.States.HasFlag((int)EntityStates.DuelZone)
                   && !pt.Self.States.HasFlag((int)EntityStates.Invulnerable)
                   && Self.TeamOwner != pt.Self.TeamOwner;
        }

        private bool IsPlayerEnemy(Team pt)
        {
            return !pt.Self.States.HasFlag((int)EntityStates.Invulnerable)
                   && !pt.Self.States.HasFlag((int)EntityStates.SafeZone)
                   && !Self.States.HasFlag((int)EntityStates.SafeZone)
                   && Self.TeamOwner != pt.Self.TeamOwner;
        }
    }
}
