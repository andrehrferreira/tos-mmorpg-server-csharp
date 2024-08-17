namespace Server.Gameplay.Items
{
    public class AprenticePants : Equipament
    {
        public override string Namespace => "SK_fe_meta_tal_nrw_caster_pants_03";
        public override string Name => "Aprentice Pants";
        public override EquipmentType EquipmentType => EquipmentType.Pants;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override EquipmentTier Tier => EquipmentTier.T2;
        public override float Weight => 2f;
        public override int GoldCost => 320;
        public override int MaxAttrs => 2;

        public override void GenerateAttrs()
        {
            SetArmor(2, 3);
        }
    }

    public class ArcanePants : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_caster_pants_02";
        public override string Name => "Arcane Pants";
        public override EquipmentType EquipmentType => EquipmentType.Pants;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override EquipmentTier Tier => EquipmentTier.T3;
        public override float Weight => 2f;
        public override int GoldCost => 800;
        public override int MaxAttrs => 3;

        public override void GenerateAttrs()
        {
            SetArmor(2, 4);
        }
    }

    public class ArmoredRoyalGuardPants : Equipament
    {
        public override string Namespace => "SK_ma_pants_heavy_01_c";
        public override string Name => "Armored Royal Guard Pants";
        public override EquipmentType EquipmentType => EquipmentType.Pants;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override EquipmentTier Tier => EquipmentTier.T4;
        public override float Weight => 5f;
        public override int GoldCost => 800;
        public override int MaxAttrs => 4;

        public override void GenerateAttrs()
        {
            SetArmor(3, 5);
        }
    }

    public class BardPants : Equipament
    {
        public override string Namespace => "SK_ma_medieval_pants_04";
        public override string Name => "Bard Pants";
        public override EquipmentType EquipmentType => EquipmentType.Pants;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override EquipmentTier Tier => EquipmentTier.T3;
        public override float Weight => 1f;
        public override int GoldCost => 800;
        public override int MaxAttrs => 4;

        public override void GenerateAttrs()
        {
            SetArmor(2, 4);
        }
    }

    public class BattleplateLegs : Equipament
    {
        public override string Namespace => "SK_ma_medieval_armour_pants_05_a";
        public override string Name => "Battleplate Legs";
        public override EquipmentType EquipmentType => EquipmentType.Pants;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override EquipmentTier Tier => EquipmentTier.T4;
        public override float Weight => 10f;
        public override int GoldCost => 800;
        public override int MaxAttrs => 4;

        public override void GenerateAttrs()
        {
            SetArmor(3, 5);
        }
    }

    public class ChampionLegs : Equipament
    {
        public override string Namespace => "SK_ma_pants_heavy_01_b";
        public override string Name => "Champion Legs";
        public override EquipmentType EquipmentType => EquipmentType.Pants;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override EquipmentTier Tier => EquipmentTier.T4;
        public override float Weight => 10f;
        public override int GoldCost => 800;
        public override int MaxAttrs => 4;

        public override void GenerateAttrs()
        {
            SetArmor(3, 5);
        }
    }

    public class ChampionPants : Equipament
    {
        public override string Namespace => "SK_ma_pants_02";
        public override string Name => "Champion Pants";
        public override EquipmentType EquipmentType => EquipmentType.Pants;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override EquipmentTier Tier => EquipmentTier.T2;
        public override float Weight => 2f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 3;

        public override void GenerateAttrs()
        {
            SetArmor(2, 3);
        }
    }

    public class ComfortablePants : Equipament
    {
        public override string Namespace => "SK_ma_pants_01";
        public override string Name => "Comfortable Pants";
        public override EquipmentType EquipmentType => EquipmentType.Pants;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override EquipmentTier Tier => EquipmentTier.T2;
        public override float Weight => 2f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 3;

        public override void GenerateAttrs()
        {
            SetArmor(2, 3);
        }
    }

    public class DarkPlatePants : Equipament
    {
        public override string Namespace => "SK_ma_pants_02";
        public override string Name => "Dark Plate Pants";
        public override EquipmentType EquipmentType => EquipmentType.Pants;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override EquipmentTier Tier => EquipmentTier.T4;
        public override float Weight => 4f;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 4;

        public override void GenerateAttrs()
        {
            SetArmor(3, 5);
        }
    }

    public class DragonhideLeatherLegs : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_pants_01";
        public override string Name => "Dragonhide Leather Legs";
        public override EquipmentType EquipmentType => EquipmentType.Pants;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override EquipmentTier Tier => EquipmentTier.T5;
        public override float Weight => 4f;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 4;

        public override void GenerateAttrs()
        {
            SetArmor(5, 8);
        }
    }

    public class GranArcanePants : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_caster_pants_01_001";
        public override string Name => "Gran Arcane Pants";
        public override EquipmentType EquipmentType => EquipmentType.Pants;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override EquipmentTier Tier => EquipmentTier.T5;
        public override float Weight => 4f;
        public override int GoldCost => 2000;
        public override int MaxAttrs => 4;

        public override void GenerateAttrs()
        {
            SetArmor(5, 8);
        }
    }

    public class GreatleatherPants : Equipament
    {
        public override string Namespace => "SK_fe_meta_tal_nrw_musc_pants_01";
        public override string Name => "Greatleather Pants";
        public override EquipmentType EquipmentType => EquipmentType.Pants;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override EquipmentTier Tier => EquipmentTier.T3;
        public override float Weight => 4f;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 3;

        public override void GenerateAttrs()
        {
            SetArmor(2, 4);
        }
    }

    public class GuardianLegs : Equipament
    {
        public override string Namespace => "SK_ma_medieval_armour_pants_04_b";
        public override string Name => "Guardian Legs";
        public override EquipmentType EquipmentType => EquipmentType.Pants;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override EquipmentTier Tier => EquipmentTier.T2;
        public override float Weight => 2f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 3;

        public override void GenerateAttrs()
        {
            SetArmor(2, 3);
        }
    }

    public class HeavyDutyPants : Equipament
    {
        public override string Namespace => "SK_ma_medieval_armour_pants_02";
        public override string Name => "Heavy Duty Pants";
        public override EquipmentType EquipmentType => EquipmentType.Pants;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override EquipmentTier Tier => EquipmentTier.T1;
        public override float Weight => 2f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 2;

        public override void GenerateAttrs()
        {
            SetArmor(1, 2);
        }
    }

    public class HidePantsOfShadowWhispers : Equipament
    {
        public override string Namespace => "SK_ma_medieval_pants_01";
        public override string Name => "Hide Pants Of Shadow Whispers";
        public override EquipmentType EquipmentType => EquipmentType.Pants;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override EquipmentTier Tier => EquipmentTier.T5;
        public override float Weight => 2f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 4;

        public override void GenerateAttrs()
        {
            SetArmor(5, 8);
        }
    }

    public class IvoryLegs : Equipament
    {
        public override string Namespace => "SK_ma_medieval_armour_pants_01_b";
        public override string Name => "Ivory Legs";
        public override EquipmentType EquipmentType => EquipmentType.Pants;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override EquipmentTier Tier => EquipmentTier.T3;
        public override float Weight => 5f;
        public override int GoldCost => 800;
        public override int MaxAttrs => 3;

        public override void GenerateAttrs()
        {
            SetArmor(5, 8);
        }
    }

    public class JokerPants : Equipament
    {
        public override string Namespace => "SK_ma_medieval_pants_03";
        public override string Name => "Joker Pants";
        public override EquipmentType EquipmentType => EquipmentType.Pants;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override EquipmentTier Tier => EquipmentTier.T3;
        public override float Weight => 1f;
        public override int GoldCost => 800;
        public override int MaxAttrs => 3;

        public override void GenerateAttrs()
        {
            SetArmor(1, 2);
        }
    }

    public class MercenaryPants : Equipament
    {
        public override string Namespace => "SK_ma_medieval_pants_02";
        public override string Name => "Mercenary Pants";
        public override EquipmentType EquipmentType => EquipmentType.Pants;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override EquipmentTier Tier => EquipmentTier.T4;
        public override float Weight => 1f;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 4;

        public override void GenerateAttrs()
        {
            SetArmor(3, 5);
        }
    }

    public class MobilityPants : Equipament
    {
        public override string Namespace => "SK_ma_medieval_armour_pants_01_a";
        public override string Name => "Mobility Pants";
        public override EquipmentType EquipmentType => EquipmentType.Pants;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override EquipmentTier Tier => EquipmentTier.T3;
        public override float Weight => 1f;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 3;

        public override void GenerateAttrs()
        {
            SetArmor(2, 4);
        }
    }

    public class NatureProtectorPants : Equipament
    {
        public override string Namespace => "SK_ma_medieval_armour_pants_04_a";
        public override string Name => "Nature Protector Pants";
        public override EquipmentType EquipmentType => EquipmentType.Pants;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override EquipmentTier Tier => EquipmentTier.T5;
        public override float Weight => 1f;
        public override int GoldCost => 2000;
        public override int MaxAttrs => 4;

        public override void GenerateAttrs()
        {
            SetArmor(5, 8);
        }
    }

    public class ProtectorPants : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_caster_pants_01";
        public override string Name => "Protector Pants";
        public override EquipmentType EquipmentType => EquipmentType.Pants;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override EquipmentTier Tier => EquipmentTier.T5;
        public override float Weight => 1f;
        public override int GoldCost => 2000;
        public override int MaxAttrs => 4;

        public override void GenerateAttrs()
        {
            SetArmor(1, 2);
        }
    }

    public class PantsOfEndingVisions : Equipament
    {
        public override string Namespace => "SK_fe_meta_tal_nrw_caster_pants_03";
        public override string Name => "Pants Of Ending Visions";
        public override EquipmentType EquipmentType => EquipmentType.Pants;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override EquipmentTier Tier => EquipmentTier.T4;
        public override float Weight => 1f;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 4;

        public override void GenerateAttrs()
        {
            SetArmor(3, 5);
        }
    }

    public class PantsOfEndingWarlords : Equipament
    {
        public override string Namespace => "SK_ma_pants_heavy_01_d";
        public override string Name => "Pants Of Ending Warlords";
        public override EquipmentType EquipmentType => EquipmentType.Pants;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override EquipmentTier Tier => EquipmentTier.T5;
        public override float Weight => 10f;
        public override int GoldCost => 2000;
        public override int MaxAttrs => 4;

        public override void GenerateAttrs()
        {
            SetArmor(5, 8);
        }
    }

    public class PlainPants : Equipament
    {
        public override string Namespace => "SK_ma_medieval_pants_05";
        public override string Name => "Plain Pants";
        public override EquipmentType EquipmentType => EquipmentType.Pants;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override EquipmentTier Tier => EquipmentTier.T0;
        public override float Weight => 1f;
        public override int GoldCost => 20;
        public override int MaxAttrs => 0;

        public override void GenerateAttrs()
        {
            SetArmor(1);
        }
    }

    public class PromiseOfVengeanceLegs : Equipament
    {
        public override string Namespace => "SK_ma_pants_heavy_01_a";
        public override string Name => "Promise Of Vengeance Legs";
        public override EquipmentType EquipmentType => EquipmentType.Pants;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override EquipmentTier Tier => EquipmentTier.T5;
        public override float Weight => 10f;
        public override int GoldCost => 2000;
        public override int MaxAttrs => 4;

        public override void GenerateAttrs()
        {
            SetArmor(5, 8);
        }
    }

    public class RippedPants : Equipament
    {
        public override string Namespace => "SK_ma_medieval_armour_pants_03";
        public override string Name => "Ripped Pants";
        public override EquipmentType EquipmentType => EquipmentType.Pants;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override EquipmentTier Tier => EquipmentTier.T0;
        public override float Weight => 1f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 2;

        public override void GenerateAttrs()
        {
            SetArmor(1);
        }
    }

    public class Shorts : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_slave_pants_short_01";
        public override string Name => "Shorts";
        public override EquipmentType EquipmentType => EquipmentType.Pants;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override EquipmentTier Tier => EquipmentTier.T0;
        public override float Weight => 1f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 1;

        public override void GenerateAttrs()
        {
            SetArmor(1);
        }
    }

    public class SmartPants : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_pants_02";
        public override string Name => "Smart Pants";
        public override EquipmentType EquipmentType => EquipmentType.Pants;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override EquipmentTier Tier => EquipmentTier.T2;
        public override float Weight => 1f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 3;

        public override void GenerateAttrs()
        {
            SetArmor(2, 3);
        }
    }

    public class StretchPants : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_caster_pants_01";
        public override string Name => "Stretch Pants";
        public override EquipmentType EquipmentType => EquipmentType.Pants;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override EquipmentTier Tier => EquipmentTier.T1;
        public override float Weight => 1f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 2;

        public override void GenerateAttrs()
        {
            SetArmor(1, 2);
        }
    }

    public class SturdyPants : Equipament
    {
        public override string Namespace => "SK_ma_pants_03_a";
        public override string Name => "Sturdy Pants";
        public override EquipmentType EquipmentType => EquipmentType.Pants;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override EquipmentTier Tier => EquipmentTier.T2;
        public override float Weight => 2f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 3;

        public override void GenerateAttrs()
        {
            SetArmor(2, 3);
        }
    }

    public class TreeClimbingPants : Equipament
    {
        public override string Namespace => "SK_fe_meta_tal_nrw_musc_pants_02";
        public override string Name => "Tree Climbing Pants";
        public override EquipmentType EquipmentType => EquipmentType.Pants;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override EquipmentTier Tier => EquipmentTier.T2;
        public override float Weight => 2f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 3;

        public override void GenerateAttrs()
        {
            SetArmor(2, 3);
        }
    }

    public class UnholyLegs : Equipament
    {
        public override string Namespace => "SK_fe_meta_tal_nrw_caster_pants_01";
        public override string Name => "Unholy Legs";
        public override EquipmentType EquipmentType => EquipmentType.Pants;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override EquipmentTier Tier => EquipmentTier.T5;
        public override float Weight => 2f;
        public override int GoldCost => 2000;
        public override int MaxAttrs => 4;

        public override void GenerateAttrs()
        {
            SetArmor(5, 8);
        }
    }

    public class WrathfulPants : Equipament
    {
        public override string Namespace => "SK_ma_medieval_armour_pants_01_c";
        public override string Name => "Wrathful Pants";
        public override EquipmentType EquipmentType => EquipmentType.Pants;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override EquipmentTier Tier => EquipmentTier.T3;
        public override float Weight => 2f;
        public override int GoldCost => 800;
        public override int MaxAttrs => 3;

        public override void GenerateAttrs()
        {
            SetArmor(2, 3);
        }
    }
}
