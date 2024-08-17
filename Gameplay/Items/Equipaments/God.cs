namespace Server.Gameplay.Items
{
    public class DiabolicHat : Equipament
    {
        public override string Namespace => "GodSetHat";
        public override string Name => "Diabolic's Hat";
        public override string Alias => "DiabolicHat";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 0f;
        public override int GoldCost => 1;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;
        public override ItemRarity Rarity => ItemRarity.Unique;

        public override void GenerateAttrs()
        {
            SetArmor(100);
        }
    }

    public class DiabolicBoots : Equipament
    {
        public override string Namespace => "GodSetBoots";
        public override string Name => "Diabolic's Boots";
        public override string Alias => "DiabolicBoots";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 0f;
        public override int GoldCost => 1;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;
        public override ItemRarity Rarity => ItemRarity.Unique;

        public override void GenerateAttrs()
        {
            SetArmor(100);
        }
    }

    public class DiabolicPants : Equipament
    {
        public override string Namespace => "GodSetPants";
        public override string Name => "Diabolic's Pants";
        public override string Alias => "DiabolicPants";
        public override EquipmentType EquipmentType => EquipmentType.Pants;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 0f;
        public override int GoldCost => 1;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;
        public override ItemRarity Rarity => ItemRarity.Unique;

        public override void GenerateAttrs()
        {
            SetArmor(100);
        }
    }

    public class DiabolicTunic : Equipament
    {
        public override string Namespace => "GodSetTunic";
        public override string Name => "Diabolic's Tunic";
        public override string Alias => "DiabolicTunic";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 0f;
        public override int GoldCost => 1;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;
        public override ItemRarity Rarity => ItemRarity.Unique;

        public override void GenerateAttrs()
        {
            SetArmor(100);
        }
    }

    public class DiabolicRobe : Equipament
    {
        public override string Namespace => "GodSetRobe";
        public override string Name => "Diabolic's Robe";
        public override string Alias => "DiabolicRobe";
        public override EquipmentType EquipmentType => EquipmentType.Robe;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 0f;
        public override int GoldCost => 1;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;
        public override ItemRarity Rarity => ItemRarity.Unique;

        public override void GenerateAttrs()
        {
            SetArmor(100);
        }
    }
}
