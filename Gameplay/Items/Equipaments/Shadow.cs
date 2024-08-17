namespace Server.Gameplay.Items
{
    public class ShadowMask : Equipament
    {
        public override string Namespace => "ShadowMask";
        public override string Name => "Shadow's Mask";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 0;
        public override int GoldCost => 1;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;
        public override ItemRarity Rarity => ItemRarity.Unique;
        public override int CardSlots => 3;

        public override void GenerateAttrs()
        {
            SetArmor(100);
        }
    }

    public class ShadowBoots : Equipament
    {
        public override string Namespace => "ShadowBoots";
        public override string Name => "Shadow's Boots";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 0;
        public override int GoldCost => 1;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;
        public override ItemRarity Rarity => ItemRarity.Unique;
        public override int CardSlots => 3;

        public override void GenerateAttrs()
        {
            SetArmor(100);
        }
    }

    public class ShadowCape : Equipament
    {
        public override string Namespace => "ShadowCape";
        public override string Name => "Shadow's Cape";
        public override EquipmentType EquipmentType => EquipmentType.Cloak;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 0;
        public override int GoldCost => 1;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;
        public override ItemRarity Rarity => ItemRarity.Unique;
        public override int CardSlots => 3;

        public override void GenerateAttrs()
        {
            SetArmor(100);
        }
    }

    public class ShadowChest : Equipament
    {
        public override string Namespace => "ShadowChest";
        public override string Name => "Shadow's Chest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 0;
        public override int GoldCost => 1;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;
        public override ItemRarity Rarity => ItemRarity.Unique;
        public override int CardSlots => 3;

        public override void GenerateAttrs()
        {
            SetArmor(100);
        }
    }

    public class ShadowGloves : Equipament
    {
        public override string Namespace => "ShadowGloves";
        public override string Name => "Shadow's Gloves";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 0;
        public override int GoldCost => 1;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;
        public override ItemRarity Rarity => ItemRarity.Unique;
        public override int CardSlots => 3;

        public override void GenerateAttrs()
        {
            SetArmor(100);
        }
    }
}
