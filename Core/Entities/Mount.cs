namespace Server
{
    public class Mount : Creature
    {
        public override Player Owner { get; protected set; }

        public Mount(Player owner)
        {
            Kind = EntitiesKind.Mount;
            Team = new Team(TeamKind.Pet, this);
            TeamOwner = owner;
            Owner = owner;
            Guild = owner.Guild;
            Life = 10000;
        }

        public override void Init()
        {
            base.Init();
            Kind = EntitiesKind.Mount;
            States = new StateFlags((int)EntityStates.None);
            Team = new Team(TeamKind.Pet, this);
        }
    }
}
