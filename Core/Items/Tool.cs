namespace Server
{
    public abstract class Tool : Equipament
    {
        public override int MaxSlots => 0;
    }

    public abstract class PickaxeTool : Tool
    {
        public override EquipmentType EquipmentType => EquipmentType.PickaxeTool;
    }

    public abstract class AxeTool : Tool
    {
        public override EquipmentType EquipmentType => EquipmentType.AxeTool;
    }

    public abstract class ScytheTool : Tool
    {
        public override EquipmentType EquipmentType => EquipmentType.ScytheTool;
    }
}
