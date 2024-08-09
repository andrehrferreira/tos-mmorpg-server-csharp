
namespace Server
{

    public class Items
    {
    }

    public class Item
    {
        public static readonly List<AttributeType> AttrsEquipments = new List<AttributeType>
        {
            AttributeType.BonusDex, AttributeType.BonusInt, AttributeType.BonusLife,
            AttributeType.BonusMana, AttributeType.BonusSpeed, AttributeType.BonusStam,
            AttributeType.BonusStr, AttributeType.CastSpeed, AttributeType.CooldownReduction,
            AttributeType.CriticalChance, AttributeType.DamageReduction, AttributeType.DodgeChance,
            AttributeType.HealthRegen, AttributeType.ManaRegen, AttributeType.StaminaRegen,
            AttributeType.LowerManaCost, AttributeType.IncreasedKarmaLoss,
            AttributeType.Luck, AttributeType.ReflectPhysical, AttributeType.ReflectSpell,
            AttributeType.BonusAgi, AttributeType.BonusVig, AttributeType.BonusLuc
        };

            public static readonly List<AttributeType> AttrsAccessories = new List<AttributeType>
        {
            AttributeType.HealthRegen, AttributeType.ManaRegen, AttributeType.StaminaRegen,
            AttributeType.BonusDex, AttributeType.BonusInt, AttributeType.BonusLife,
            AttributeType.BonusAgi, AttributeType.BonusVig, AttributeType.BonusLuc
        };

            public static readonly List<AttributeType> AttrsWeapon = new List<AttributeType>
        {
            AttributeType.HealthRegen, AttributeType.ManaRegen, AttributeType.StaminaRegen,
            AttributeType.BonusDex, AttributeType.BonusInt, AttributeType.BonusLife,
            AttributeType.BonusAgi, AttributeType.BonusVig, AttributeType.BonusLuc,
            AttributeType.BonusDamage, AttributeType.BonusMagicDamage,
            AttributeType.CriticalDamage, AttributeType.FasterCasting,
            AttributeType.SpellDamage, AttributeType.FireDamage,
            AttributeType.ColdDamage, AttributeType.PoisonDamage,
            AttributeType.EnergyDamage, AttributeType.LightDamage,
            AttributeType.DarkDamage
        };

            public static readonly List<AttributeType> AttrsWeaponWithoutElementalDamage = new List<AttributeType>
        {
            AttributeType.HealthRegen, AttributeType.ManaRegen, AttributeType.StaminaRegen,
            AttributeType.BonusDex, AttributeType.BonusInt, AttributeType.BonusLife,
            AttributeType.BonusAgi, AttributeType.BonusVig, AttributeType.BonusLuc,
            AttributeType.BonusDamage, AttributeType.BonusMagicDamage,
            AttributeType.CriticalDamage, AttributeType.FasterCasting,
            AttributeType.SpellDamage
        };
    }
}
