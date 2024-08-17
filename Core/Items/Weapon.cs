namespace Server
{
    public abstract class Weapon : Equipament
    {
        public override int MaxSlots => 4;
        public virtual Dices Damage { get; set; } = Dices.None;
        public virtual int BonusDamage { get; set; } = 0;
        public override EquipmentType EquipmentType => EquipmentType.Weapon;
        public virtual WeaponType WeaponType { get; set; } = WeaponType.None;
        public virtual float AttackSpeed { get; set; } = 2;
        public override int MaxAttrs { get; set; } = 2;

        private static readonly Dictionary<string, string> DiceUpgradeMap = new Dictionary<string, string>
        {
            {"1D4", "1D6"}, {"2D4", "2D6"}, {"3D4", "3D6"}, {"4D4", "4D6"}, {"5D4", "5D6"}, {"6D4", "6D6"},
            {"1D6", "1D8"}, {"2D6", "2D8"}, {"3D6", "3D8"}, {"4D6", "4D8"}, {"5D6", "5D8"}, {"6D6", "6D8"},
            {"1D8", "1D10"}, {"2D8", "2D10"}, {"3D8", "3D10"}, {"4D8", "4D10"}, {"5D8", "5D10"}, {"6D8", "6D10"},
            {"1D10", "1D12"}, {"2D10", "2D12"}, {"3D10", "3D12"}, {"4D10", "4D12"}, {"5D10", "5D12"}, {"6D10", "6D12"},
            {"1D12", "1D20"}, {"2D12", "2D20"}, {"3D12", "3D20"}, {"4D12", "4D20"}, {"5D12", "5D20"}, {"6D12", "6D20"}
        };

        private Dices UpgradeDamage(Dices damage)
        {
            var damageStr = damage.ToString();
            return DiceUpgradeMap.ContainsKey(damageStr) ? Enum.Parse<Dices>(DiceUpgradeMap[damageStr]) : damage;
        }

        public override void GenerateRandomAttrs()
        {
            base.GenerateRandomAttrs();

            switch (Rarity)
            {
                case ItemRarity.Uncommon:
                    BonusDamage = 1;
                    Damage = UpgradeDamage(Damage);
                    break;
                case ItemRarity.Rare:
                    BonusDamage = 2;
                    Damage = UpgradeDamage(UpgradeDamage(Damage));
                    break;
                case ItemRarity.Magic:
                    BonusDamage = 3;
                    for (int i = 0; i < 3; i++)
                        Damage = UpgradeDamage(Damage);
                    break;
                case ItemRarity.Legendary:
                    BonusDamage = 4;
                    for (int i = 0; i < 4; i++)
                        Damage = UpgradeDamage(Damage);
                    break;
                case ItemRarity.Unique:
                    BonusDamage = 5;
                    for (int i = 0; i < 5; i++)
                        Damage = UpgradeDamage(Damage);
                    break;
            }

            if (Flags.HasFlag(ItemStates.Exceptional))
                BonusDamage++;
        }

        public override Dictionary<string, object> Serialize()
        {
            var data = base.Serialize();
            data["Damage"] = Damage;
            data["BonusDamage"] = BonusDamage;
            data["AttackSpeed"] = AttackSpeed;
            return data;
        }
    }
}
