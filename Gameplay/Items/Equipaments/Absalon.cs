namespace Server.Gameplay.Items
{
    public class AbsalonHelmet : Equipament
    {
        public override string Namespace => "AbsalonHelmet";
        public override string Name => "Absalon's Helmet";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 0;
        public override int GoldCost => 1;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;
        public override ItemRarity Rarity => ItemRarity.Unique;

        public override void GenerateAttrs()
        {
            SetArmor(100);
        }
    }

    public class AbsalonBoots : Equipament
    {
        public override string Namespace => "AbsalonBoots";
        public override string Name => "Absalon's Boots";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 0;
        public override int GoldCost => 1;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;
        public override ItemRarity Rarity => ItemRarity.Unique;

        public override void GenerateAttrs()
        {
            SetArmor(100);
        }
    }

    public class AbsalonChest : Equipament
    {
        public override string Namespace => "AbsalonChest";
        public override string Name => "Absalon's Chest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 0;
        public override int GoldCost => 1;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;
        public override ItemRarity Rarity => ItemRarity.Unique;

        public override void GenerateAttrs()
        {
            SetArmor(100);
        }
    }

    public class AbsalonPants : Equipament
    {
        public override string Namespace => "AbsalonPants";
        public override string Name => "Absalon's Pants";
        public override EquipmentType EquipmentType => EquipmentType.Pants;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 0;
        public override int GoldCost => 1;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;
        public override ItemRarity Rarity => ItemRarity.Unique;

        public override void GenerateAttrs()
        {
            SetArmor(100);
        }
    }

    public class AbsalonAcessories : Equipament
    {
        public override string Namespace => "AbsalonAcessories";
        public override string Name => "Absalon's Acessories";
        public override EquipmentType EquipmentType => EquipmentType.Robe;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 0;
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
