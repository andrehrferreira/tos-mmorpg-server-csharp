namespace Server
{
    public abstract class PetItem : Equipament
    {
        public abstract Type PetCreature { get; }
        public override int MaxSlots => 0;
        public override EquipmentType EquipmentType => EquipmentType.Pet;

        public override void OnEquip(Humanoid entity)
        {
            if (entity.PetInstance != null)
            {
                entity.PetInstance.Destroy();
                entity.PetInstance = null;
            }

            Task.Delay(1000).ContinueWith(_ =>
            {
                if (entity != null && entity.Map != null && entity.PetInstance == null)
                {
                    entity.PetInstance = (Pet)Activator.CreateInstance(PetCreature, entity as Player);
                    entity.PetInstance.Transform.SetPosition(entity.Transform.Position);
                    entity.PetInstance.States.AddFlag(EntityStates.Pet);
                    entity.Map.JoinMap(entity.PetInstance);
                }
            });
        }

        public override void OnDesequip(Humanoid entity)
        {
            if (entity.PetInstance != null)
            {
                entity.PetInstance.Destroy();
                entity.PetInstance = null;
            }
        }
    }

    public abstract class MountItem : Equipament
    {
        //public abstract Type MountCreature { get; }
        public override EquipmentType EquipmentType => EquipmentType.Mount;
        public override int MaxSlots { get; set; } = 0;
        //private Mount InstancedCreature;
    }

    public abstract class Gemstone : Resource {}
}
