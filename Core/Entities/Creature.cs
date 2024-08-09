namespace Server
{
    public class Creature: Entity
    {
        protected virtual CreatureIAState IAState { get; set; } = CreatureIAState.Idle;
        public virtual CreatureType CreatureType { get; set; } = CreatureType.Common;
        public virtual Player Owner { get; protected set; }

        public override bool IsCreature { get => true; }

        public virtual void Init()
        {
            Kind = EntitiesKind.Monster;
            States = new StateFlags(EntityStates.None);
            Team = new Team(TeamKind.Monsters, this);
            TeamOwner = this;
        }

    }
}
