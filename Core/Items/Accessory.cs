namespace Server
{
    public abstract class Accessory : Equipament
    {
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override int MaxSlots => 1;

        public override void GenerateRandomAttrs()
        {
            int minAttrs = 1;
            minAttrs = Math.Min(minAttrs, 4);
            int attrsCounts = (MaxAttrs > minAttrs) ? RandomHelper.MinMaxInt(minAttrs, MaxAttrs) : minAttrs;
            Attrs.Clear();

            for (int i = 0; i < attrsCounts; i++)
            {
                AttributeType attrType = (this is Weapon) ? RandomHelper.ArrRandom(AttrsWeapon) :
                                                          RandomHelper.ArrRandom(AttrsAccessories);

                int value = GetTierValueAttr();

                if (!Attrs.ContainsKey(attrType))
                    Attrs[attrType] = value;
                else
                    i--;
            }
        }
    }

    public abstract class Ring : Accessory
    {
        public override EquipmentType EquipmentType => EquipmentType.Ring;
        public override int MaxSlots => 1;
    }

    public abstract class Necklance : Accessory
    {
        public override EquipmentType EquipmentType => EquipmentType.Necklance;
        public override int MaxSlots => 1;
    }
}
