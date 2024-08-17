namespace Server.Gameplay.Items
{
    public class ArmoredDarkPlateGloves : Equipament
    {
        public override string Namespace => "sk_ma_gauntlet_death_01_b";
        public override string Name => "Armored Dark Plate Gloves";
        public override string Alias => "ArmoredDarkPlateGloves";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 5;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T4;

        public override void GenerateAttrs()
        {
            SetArmor(3, 5);
        }
    }

    public class ArmoredKnightGloves : Equipament
    {
        public override string Namespace => "SK_gloves_03_b";
        public override string Name => "Armored Knight Gloves";
        public override string Alias => "ArmoredKnightGloves";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 5;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T4;

        public override void GenerateAttrs()
        {
            SetArmor(3, 5);
        }
    }

    public class ArmoredRoyalGuardGloves : Equipament
    {
        public override string Namespace => "SK_gloves_03_a";
        public override string Name => "Armored Royal Guard Gloves";
        public override string Alias => "ArmoredRoyalGuardGloves";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 5;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T4;

        public override void GenerateAttrs()
        {
            SetArmor(3, 5);
        }
    }

    public class BardGloves : Equipament
    {
        public override string Namespace => "SK_gloves_02_a";
        public override string Name => "Bard Gloves";
        public override string Alias => "BardGloves";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 1;
        public override int GoldCost => 100;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override void GenerateAttrs()
        {
            SetArmor(2, 3);
        }
    }

    public class BattleplateGloves : Equipament
    {
        public override string Namespace => "SK_ma_bracers_heavy_04_b";
        public override string Name => "Battleplate Gloves";
        public override string Alias => "BattleplateGloves";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 10f;
        public override int GoldCost => 800;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T3;

        public override void GenerateAttrs()
        {
            SetArmor(2, 4);
        }
    }

    public class BracerOfEndingVisions : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_caster_bracers_cloth_a";
        public override string Name => "Bracer Of Ending Visions";
        public override string Alias => "BracerOfEndingVisions";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 1f;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T4;

        public override void GenerateAttrs()
        {
            SetArmor(3, 5);
        }
    }

    public class CataclysmicMailFists : Equipament
    {
        public override string Namespace => "SK_fe_meta_tal_nrw_musc_bracers_04_metal_001";
        public override string Name => "Cataclysmic Mail Fists";
        public override string Alias => "CataclysmicMailFists";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 3f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override void GenerateAttrs()
        {
            SetArmor(2, 3);
        }
    }

    public class ChampionGloves : Equipament
    {
        public override string Namespace => "sk_ma_gauntlet_death_01_c";
        public override string Name => "Champion Gloves";
        public override string Alias => "ChampionGloves";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 3f;
        public override int GoldCost => 800;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T3;

        public override void GenerateAttrs()
        {
            SetArmor(2, 4);
        }
    }

    public class ChampionScaledHands : Equipament
    {
        public override string Namespace => "SK_gloves_01_e";
        public override string Name => "Champion Scaled Hands";
        public override string Alias => "ChampionScaledHands";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 3f;
        public override int GoldCost => 800;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T3;

        public override void GenerateAttrs()
        {
            SetArmor(2, 4);
        }
    }

    public class CombatantBracer : Equipament
    {
        public override string Namespace => "SK_gloves_01_e";
        public override string Name => "Combatant Bracer";
        public override string Alias => "CombatantBracer";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 3f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T1;

        public override void GenerateAttrs()
        {
            SetArmor(1, 2);
        }
    }

    public class ConquerorsMailGloves : Equipament
    {
        public override string Namespace => "SK_ma_tal_nrw_skeleton_bracers_01";
        public override string Name => "Conqueror's Mail Gloves";
        public override string Alias => "ConquerorsMailGloves";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 3f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T1;

        public override void GenerateAttrs()
        {
            SetArmor(1, 2);
        }
    }

    public class DarkPlateGloves : Equipament
    {
        public override string Namespace => "sk_ma_gauntlet_death_01_e";
        public override string Name => "Dark Plate Gloves";
        public override string Alias => "DarkPlateGloves";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 10f;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T4;

        public override void GenerateAttrs()
        {
            SetArmor(3, 5);
        }
    }

    public class DefenderOfBlightBracer : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_barbar_bracers_light_01_001";
        public override string Name => "Defender Of Blight Bracer";
        public override string Alias => "DefenderOfBlightBracer";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 1f;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T4;

        public override void GenerateAttrs()
        {
            SetArmor(2, 4);
        }
    }

    public class DragonhideLeatherGloves : Equipament
    {
        public override string Namespace => "sk_ma_gauntlet_01";
        public override string Name => "Dragonhide Leather Gloves";
        public override string Alias => "DragonhideLeatherGloves";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 10f;
        public override int GoldCost => 2000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override void GenerateAttrs()
        {
            SetArmor(5, 8);
        }
    }

    public class GlovesOfCursedComrades : Equipament
    {
        public override string Namespace => "sk_ma_gauntlet_death_01_d";
        public override string Name => "Gloves Of Cursed Comrades";
        public override string Alias => "GlovesOfCursedComrades";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 20f;
        public override int GoldCost => 2000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T4;

        public override void GenerateAttrs()
        {
            SetArmor(3, 5);
        }
    }

    public class GlovesOfEndingWarlords : Equipament
    {
        public override string Namespace => "sk_ma_gauntlet_dragon_01_b";
        public override string Name => "Gloves Of Ending Warlords";
        public override string Alias => "GlovesOfEndingWarlords";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 20f;
        public override int GoldCost => 2000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override void GenerateAttrs()
        {
            SetArmor(5, 8);
        }
    }

    public class GlovesOfRelentlessSorrow : Equipament
    {
        public override string Namespace => "SK_fe_meta_tal_nrw_musc_gloves_spiky_001";
        public override string Name => "Gloves Of Relentless Sorrow";
        public override string Alias => "GlovesOfRelentlessSorrow";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 5f;
        public override int GoldCost => 2000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override void GenerateAttrs()
        {
            SetArmor(5, 8);
        }
    }

    public class GlovesOfTheTalon : Equipament
    {
        public override string Namespace => "SK_gloves_01_a";
        public override string Name => "Gloves Of The Talon";
        public override string Alias => "GlovesOfTheTalon";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 1f;
        public override int GoldCost => 500;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T3;

        public override void GenerateAttrs()
        {
            SetArmor(2, 4);
        }
    }

    public class GranArcaneBracer : Equipament
    {
        public override string Namespace => "SK_fe_meta_tal_nrw_caster_bracers_01_light";
        public override string Name => "Gran Arcane Bracer";
        public override string Alias => "GranArcaneBracer";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 1f;
        public override int GoldCost => 2000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override void GenerateAttrs()
        {
            SetArmor(5, 8);
        }
    }

    public class GreatleatherGloves : Equipament
    {
        public override string Namespace => "SK_gloves_01_b";
        public override string Name => "Greatleather Gloves";
        public override string Alias => "GreatleatherGloves";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 5f;
        public override int GoldCost => 800;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T3;

        public override void GenerateAttrs()
        {
            SetArmor(2, 4);
        }
    }

    public class GuardianGloves : Equipament
    {
        public override string Namespace => "SK_ma_tal_nrw_skeleton_bracers_03";
        public override string Name => "Guardian Gloves";
        public override string Alias => "GuardianGloves";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 5f;
        public override int GoldCost => 800;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T1;

        public override void GenerateAttrs()
        {
            SetArmor(1, 2);
        }
    }

    public class GuardOfTheLightGloves : Equipament
    {
        public override string Namespace => "SK_ma_bracers_heavy_04_a";
        public override string Name => "Guard Of The Light Gloves";
        public override string Alias => "GuardOfTheLightGloves";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 10f;
        public override int GoldCost => 800;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T4;

        public override void GenerateAttrs()
        {
            SetArmor(3, 5);
        }
    }

    public class GuardiansHeavyLeatherGrasps : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_cultist_bracers_d";
        public override string Name => "Guardian's Heavy Leather Grasps";
        public override string Alias => "GuardiansHeavyLeatherGrasps";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 5f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override void GenerateAttrs()
        {
            SetArmor(2, 3);
        }
    }

    public class HandguardsOfAncientPower : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_caster_bracers_cloth_a";
        public override string Name => "Handguards Of Ancient Power";
        public override string Alias => "HandguardsOfAncientPower";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 1f;
        public override int GoldCost => 800;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T3;

        public override void GenerateAttrs()
        {
            SetArmor(2, 4);
        }
    }

    public class HeavyLeatherGrasps : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_barbar_bracers_leather_02_001";
        public override string Name => "Heavy Leather Grasps";
        public override string Alias => "HeavyLeatherGrasps";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 5f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override void GenerateAttrs()
        {
            SetArmor(2, 3);
        }
    }

    public class HideGlovesOfShadowWhispers : Equipament
    {
        public override string Namespace => "SK_ma_bracers_heavy_04_e";
        public override string Name => "Hide Gloves Of Shadow Whispers";
        public override string Alias => "HideGlovesOfShadowWhispers";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 5f;
        public override int GoldCost => 2000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override void GenerateAttrs()
        {
            SetArmor(5, 8);
        }
    }

    public class IronGrips : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_cultist_bracer_c";
        public override string Name => "Iron Grips";
        public override string Alias => "IronGrips";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 2f;
        public override int GoldCost => 20;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T1;

        public override void GenerateAttrs()
        {
            SetArmor(1, 2);
        }
    }

    public class IvoryGloves : Equipament
    {
        public override string Namespace => "SK_ma_tal_nrw_skeleton_bracers_01";
        public override string Name => "Ivory Gloves";
        public override string Alias => "IvoryGloves";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 4f;
        public override int GoldCost => 20;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T1;

        public override void GenerateAttrs()
        {
            SetArmor(1, 2);
        }
    }

    public class LeatherBracer : Equipament
    {
        public override string Namespace => "SK_gloves_01_d";
        public override string Name => "Leather Bracer";
        public override string Alias => "LeatherBracer";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 1f;
        public override int GoldCost => 20;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T0;

        public override void GenerateAttrs()
        {
            SetArmor(1);
        }
    }

    public class MagicianBracer : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_caster_bracers_cloth_b";
        public override string Name => "Magician Bracer";
        public override string Alias => "MagicianBracer";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 1f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T1;

        public override void GenerateAttrs()
        {
            SetArmor(1, 2);
        }
    }

    public class MercenaryGloves : Equipament
    {
        public override string Namespace => "sk_ma_gauntlet_death_01_a2";
        public override string Name => "Mercenary Gloves";
        public override string Alias => "MercenaryGloves";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 10f;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T4;

        public override void GenerateAttrs()
        {
            SetArmor(3, 5);
        }
    }

    public class MobilityGloves : Equipament
    {
        public override string Namespace => "SK_gloves_04_a";
        public override string Name => "Mobility Gloves";
        public override string Alias => "MobilityGloves";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 5f;
        public override int GoldCost => 320;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T3;

        public override void GenerateAttrs()
        {
            SetArmor(2, 4);
        }
    }

    public class NatureProtectorBrace : Equipament
    {
        public override string Namespace => "SK_gloves_01_c_";
        public override string Name => "Nature Protector Brace";
        public override string Alias => "NatureProtectorBrace";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 5f;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override void GenerateAttrs()
        {
            SetArmor(5, 8);
        }
    }

    public class NatureProtectorGloves : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_cultist_bracer_b";
        public override string Name => "Nature Protector Gloves";
        public override string Alias => "NatureProtectorGloves";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 1f;
        public override int GoldCost => 800;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T4;

        public override void GenerateAttrs()
        {
            SetArmor(2, 3);
        }
    }

    public class PromiseOfVengeanceGloves : Equipament
    {
        public override string Namespace => "SK_ma_bracers_heavy_03_a";
        public override string Name => "Promise Of Vengeance Gloves";
        public override string Alias => "PromiseOfVengeanceGloves";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 5f;
        public override int GoldCost => 2000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override void GenerateAttrs()
        {
            SetArmor(5, 8);
        }
    }

    public class RecruitsGauntlets : Equipament
    {
        public override string Namespace => "SK_ma_tal_nrw_skeleton_bracers_02";
        public override string Name => "Recruit's Gauntlets";
        public override string Alias => "RecruitsGauntlets";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 1f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T1;

        public override void GenerateAttrs()
        {
            SetArmor(1, 2);
        }
    }

    public class RoaringMailGloves : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_cultist_bracer_c";
        public override string Name => "Roaring Mail Gloves";
        public override string Alias => "RoaringMailGloves";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 2f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T1;

        public override void GenerateAttrs()
        {
            SetArmor(1, 2);
        }
    }

    public class SanctunGloves : Equipament
    {
        public override string Namespace => "SK_ma_bracers_heavy_04_c";
        public override string Name => "Sanctun Gloves";
        public override string Alias => "SanctunGloves";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 10f;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T4;

        public override void GenerateAttrs()
        {
            SetArmor(3, 5);
        }
    }

    public class SavageWoolGauntlets : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_barbar_glove_01_a_001";
        public override string Name => "Savage Wool Gauntlets";
        public override string Alias => "SavageWoolGauntlets";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 5f;
        public override int GoldCost => 800;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T3;

        public override void GenerateAttrs()
        {
            SetArmor(2, 4);
        }
    }

    public class ShadowHideGrips : Equipament
    {
        public override string Namespace => "SK_ma_bracers_heavy_04_d";
        public override string Name => "Shadow Hide Grips";
        public override string Alias => "ShadowHideGrips";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 5f;
        public override int GoldCost => 800;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T3;

        public override void GenerateAttrs()
        {
            SetArmor(2, 4);
        }
    }

    public class SoldierGloves : Equipament
    {
        public override string Namespace => "SK_fe_meta_tal_nrw_musc_bracers_03_b_001";
        public override string Name => "Soldier Gloves";
        public override string Alias => "SoldierGloves";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 2f;
        public override int GoldCost => 800;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T1;

        public override void GenerateAttrs()
        {
            SetArmor(1, 2);
        }
    }

    public class SpikedMailBracer : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_barbar_bracers_leather_02_001";
        public override string Name => "Spiked Mail Bracer";
        public override string Alias => "SpikedMailBracer";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 2f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override void GenerateAttrs()
        {
            SetArmor(2, 3);
        }
    }

    public class SturdyBracer : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_barbar_bracers_leather_02_001";
        public override string Name => "Sturdy Bracer";
        public override string Alias => "SturdyBracer";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 2f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T1;

        public override void GenerateAttrs()
        {
            SetArmor(1, 2);
        }
    }

    public class TrooperBracer : Equipament
    {
        public override string Namespace => "SK_ma_tal_nrw_skeleton_bracers_02";
        public override string Name => "Trooper Bracer";
        public override string Alias => "TrooperBracer";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 1f;
        public override int GoldCost => 20;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T0;

        public override void GenerateAttrs()
        {
            SetArmor(1);
        }
    }

    public class UnholyGloves : Equipament
    {
        public override string Namespace => "sk_ma_gauntlet_death_01_a";
        public override string Name => "Unholy Gloves";
        public override string Alias => "UnholyGloves";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 10f;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override void GenerateAttrs()
        {
            SetArmor(5, 8);
        }
    }

    public class VengefulClothHands : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_caster_bracers_cloth_c";
        public override string Name => "Vengeful Cloth Hands";
        public override string Alias => "VengefulClothHands";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 1f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override void GenerateAttrs()
        {
            SetArmor(1, 2);
        }
    }

    public class WitchBracer : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_cultist_bracer_b";
        public override string Name => "Witch Bracer";
        public override string Alias => "WitchBracer";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 1f;
        public override int GoldCost => 20;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T0;

        public override void GenerateAttrs()
        {
            SetArmor(1);
        }
    }

    public class WrathfulGloves : Equipament
    {
        public override string Namespace => "sk_ma_gauntlet_death_01_b_fur";
        public override string Name => "Wrathful Gloves";
        public override string Alias => "WrathfulGloves";
        public override EquipmentType EquipmentType => EquipmentType.Gloves;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 10f;
        public override int GoldCost => 800;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T4;

        public override void GenerateAttrs()
        {
            SetArmor(3, 5);
        }
    }
}
