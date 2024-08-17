namespace Server.Gameplay.Items
{
    public class AgileVillagerHood : Equipament
    {
        public override string Namespace => "SK_ma_medieval_hat_03";
        public override string Name => "Agile Villager Hood";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 1f;
        public override int GoldCost => 20;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T1;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "1" },
            { "Weight Type", "Light" },
            { "Armor", "1" },
            { "Attributes", "1-2" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(1);
        }
    }

    public class ApprenticeHat : Equipament
    {
        public override string Namespace => "sk_ma_meta_tal_nrwhat_caster_01_b";
        public override string Name => "Apprentice Hat";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 1f;
        public override int GoldCost => 20;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T1;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "1" },
            { "Weight Type", "Light" },
            { "Armor", "1" },
            { "Attributes", "1-2" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(1);
        }
    }

    public class ArcaneClothHood : Equipament
    {
        public override string Namespace => "SK_ma_tal_nrw_hood_01_a";
        public override string Name => "Arcane Cloth Hood";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 1f;
        public override int GoldCost => 820;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Weight Type", "Light" },
            { "Armor", "1" },
            { "Attributes", "1-3" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(1);
        }
    }

    public class ArmoredDarkPlateHelm : Equipament
    {
        public override string Namespace => "SK_ma_tal_nrw_barbar_helm_03_a";
        public override string Name => "Armored Dark Plate Helm";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 10f;
        public override int GoldCost => 4000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Weight Type", "Heavy" },
            { "Armor", "5-8" },
            { "Attributes", "4" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(5, 8);
        }
    }

    public class ArmoredRoyalGuardHelm : Equipament
    {
        public override string Namespace => "SK_ma_heavy_helm_paladin_a";
        public override string Name => "Armored Royal Guard Helm";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 5f;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Weight Type", "Heavy" },
            { "Armor", "3-4" },
            { "Attributes", "1-3" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(3, 4);
        }
    }

    public class BanditMask : Equipament
    {
        public override string Namespace => "SK_ma_tal_nrw_hood_mask";
        public override string Name => "Bandit Mask";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 1f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T1;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "1" },
            { "Weight Type", "Medium" },
            { "Armor", "1" },
            { "Attributes", "1-2" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(1);
        }
    }

    public class BarbarianHelm : Equipament
    {
        public override string Namespace => "SK_ma_tal_nrw_barbar_helm_03_e";
        public override string Name => "Barbarian Helm";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 10f;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T4;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "4" },
            { "Weight Type", "Heavy" },
            { "Armor", "3-5" },
            { "Attributes", "3-4" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(3, 5);
        }
    }

    public class BattleplateHelm : Equipament
    {
        public override string Namespace => "SK_ma_helm_03_d";
        public override string Name => "Battleplate Helm";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 10f;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Weight Type", "Heavy" },
            { "Armor", "2-4" },
            { "Attributes", "1-3" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(2, 4);
        }
    }

    public class ChampionHelm : Equipament
    {
        public override string Namespace => "SK_helmet_crusader_01_b";
        public override string Name => "Champion Helm";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 5f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Weight Type", "Heavy" },
            { "Armor", "2-3" },
            { "Attributes", "1-2" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(2, 3);
        }
    }

    public class CircletOfSacredJustice : Equipament
    {
        public override string Namespace => "sk_ma_headband_01_a";
        public override string Name => "Circlet Of Sacred Justice";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 1f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Weight Type", "Light" },
            { "Armor", "1" },
            { "Attributes", "1-2" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(1);
        }
    }

    public class CombatantHelm : Equipament
    {
        public override string Namespace => "SK_helmet_soldier_04_b";
        public override string Name => "Combatant Helm";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 2f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T1;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "1" },
            { "Weight Type", "Heavy" },
            { "Armor", "1" },
            { "Attributes", "1-2" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(1);
        }
    }

    public class ConquerorsMailHelm : Equipament
    {
        public override string Namespace => "SK_helmet_north_02_b";
        public override string Name => "Conqueror's Mail Helm";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 5f;
        public override int GoldCost => 800;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Weight Type", "Medium" },
            { "Armor", "3-4" },
            { "Attributes", "1-3" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(3, 4);
        }
    }

    public class CooksVillagerHood : Equipament
    {
        public override string Namespace => "SK_fe_medieval_hat_01";
        public override string Name => "Cook's Villager Hood";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 1f;
        public override int GoldCost => 20;
        public override int MaxAttrs => 1;
        public override EquipmentTier Tier => EquipmentTier.T0;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "0" },
            { "Weight Type", "Light" },
            { "Armor", "1" },
            { "Attributes", "1" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(1);
        }
    }

    public class CrownOfCursedSouls : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_cultist_hood_crown";
        public override string Name => "Crown Of Cursed Souls";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 1f;
        public override int GoldCost => 800;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Weight Type", "Light" },
            { "Armor", "2-4" },
            { "Attributes", "1-3" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(2, 4);
        }
    }

    public class CultistMask : Equipament
    {
        public override string Namespace => "SK_raven_02_mask";
        public override string Name => "Cultist Mask";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 1f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Weight Type", "Light" },
            { "Armor", "2-3" },
            { "Attributes", "1-3" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(2, 3);
        }
    }

    public class DarkPlateHelm : Equipament
    {
        public override string Namespace => "SK_fe_meta_tal_nrw_helm_heavy_01_a";
        public override string Name => "Dark Plate Helm";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 5f;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T4;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "4" },
            { "Weight Type", "Heavy" },
            { "Armor", "3-5" },
            { "Attributes", "3-4" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(3, 5);
        }
    }

    public class DefenderHelm : Equipament
    {
        public override string Namespace => "SK_helmet_knight_01_a";
        public override string Name => "Defender Helm";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 5f;
        public override int GoldCost => 300;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Weight Type", "Heavy" },
            { "Armor", "2-3" },
            { "Attributes", "1-3" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(2, 3);
        }
    }

    public class DefenderOfBlightHelm : Equipament
    {
        public override string Namespace => "SK_ma_tal_nrw_helm_base";
        public override string Name => "Defender Of Blight Helm";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 10f;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T4;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "4" },
            { "Weight Type", "Heavy" },
            { "Armor", "3-5" },
            { "Attributes", "3-4" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(3, 5);
        }
    }

    public class DragonhideLeatherHelm : Equipament
    {
        public override string Namespace => "SK_ma_helm_03_a";
        public override string Name => "Dragonhide Leather Helm";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 20f;
        public override int GoldCost => 2000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Weight Type", "Heavy" },
            { "Armor", "5-8" },
            { "Attributes", "4" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(5, 8);
        }
    }

    public class DruidLeatherHelm : Equipament
    {
        public override string Namespace => "sk_ma_druid_helm_02_a";
        public override string Name => "Druid Leather Helm";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 1f;
        public override int GoldCost => 800;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Weight Type", "Light" },
            { "Armor", "3-4" },
            { "Attributes", "1-3" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(3, 4);
        }
    }

    public class EbonHelm : Equipament
    {
        public override string Namespace => "SK_ma_helm_03_b";
        public override string Name => "Ebon Helm";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 5f;
        public override int GoldCost => 2000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Weight Type", "Heavy" },
            { "Armor", "5-8" },
            { "Attributes", "4" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(5, 8);
        }
    }

    public class EngravedHelm : Equipament
    {
        public override string Namespace => "SK_ma_helm_spiky_04_b";
        public override string Name => "Engraved Helm";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 20f;
        public override int GoldCost => 10000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Weight Type", "Heavy" },
            { "Armor", "5-8" },
            { "Attributes", "4" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(5, 8);
        }
    }

    public class FancyHat : Equipament
    {
        public override string Namespace => "SK_fe_medieval_hat_04";
        public override string Name => "Fancy Hat";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 1f;
        public override int GoldCost => 20;
        public override int MaxAttrs => 1;
        public override EquipmentTier Tier => EquipmentTier.T0;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "0" },
            { "Weight Type", "Light" },
            { "Armor", "1" },
            { "Attributes", "1" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(1);
        }
    }

    public class FighterHelm : Equipament
    {
        public override string Namespace => "SK_helmet_knight_01_b";
        public override string Name => "Fighter Helm";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 5f;
        public override int GoldCost => 20;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T1;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "1" },
            { "Weight Type", "Heavy" },
            { "Armor", "1-2" },
            { "Attributes", "1-2" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(1, 2);
        }
    }

    public class GranArcaneHelm : Equipament
    {
        public override string Namespace => "SK_ma_tal_nrw_helm_elegant_a";
        public override string Name => "Gran Arcane Helm";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 20f;
        public override int GoldCost => 10000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Weight Type", "Heavy" },
            { "Armor", "5-8" },
            { "Attributes", "4" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(5, 8);
        }
    }

    public class GreatConquerorsMailHelm : Equipament
    {
        public override string Namespace => "SK_helmet_north_02_a";
        public override string Name => "Great Conqueror's Mail Helm";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 5f;
        public override int GoldCost => 800;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Weight Type", "Medium" },
            { "Armor", "3-4" },
            { "Attributes", "1-4" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(3, 4);
        }
    }

    public class GreatplateHelm : Equipament
    {
        public override string Namespace => "SK_fe_meta_tal_nrw_helm_heavy_01_f";
        public override string Name => "Greatplate Helm";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 20f;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T4;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "4" },
            { "Weight Type", "Heavy" },
            { "Armor", "3-5" },
            { "Attributes", "3-4" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(3, 5);
        }
    }

    public class GuardOfTheLightHelm : Equipament
    {
        public override string Namespace => "SK_ma_helm_03_c";
        public override string Name => "Guard Of The Light Helm";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 10f;
        public override int GoldCost => 2000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T4;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "4" },
            { "Weight Type", "Heavy" },
            { "Armor", "3-5" },
            { "Attributes", "3-4" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(3, 5);
        }
    }

    public class GuardianHelm : Equipament
    {
        public override string Namespace => "SK_helmet_soldier_05_b";
        public override string Name => "Guardian Helm";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 5f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T1;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "1" },
            { "Weight Type", "Medium" },
            { "Armor", "1-2" },
            { "Attributes", "1-2" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(1, 2);
        }
    }

    public class HelmOfDivineHope : Equipament
    {
        public override string Namespace => "SK_helmet_soldier_05_b";
        public override string Name => "Helm Of Divine Hope";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 10f;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T4;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "4" },
            { "Weight Type", "Heavy" },
            { "Armor", "3-5" },
            { "Attributes", "3-4" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(3, 5);
        }
    }

    public class HelmOfTheNatureSpirits : Equipament
    {
        public override string Namespace => "sk_ma_druid_helm_01_hair";
        public override string Name => "Helm Of The Nature Spirits";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 1f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Weight Type", "Light" },
            { "Armor", "2-3" },
            { "Attributes", "1-3" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(2, 3);
        }
    }

    public class HelmetOfCursedComrades : Equipament
    {
        public override string Namespace => "SK_ma_helm_darkknight_02_c";
        public override string Name => "Helmet Of Cursed Comrades";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 10f;
        public override int GoldCost => 5000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Weight Type", "Heavy" },
            { "Armor", "5-8" },
            { "Attributes", "4" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(5, 8);
        }
    }

    public class HelmetOfEndingVisions : Equipament
    {
        public override string Namespace => "SK_ma_tal_nrw_helm_antlers";
        public override string Name => "Helmet Of Ending Visions";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 5f;
        public override int GoldCost => 5000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Weight Type", "Medium" },
            { "Armor", "5-8" },
            { "Attributes", "4" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(5, 8);
        }
    }

    public class HelmetOfEndingWarlords : Equipament
    {
        public override string Namespace => "SK_ma_helm_spiky_04";
        public override string Name => "Helmet Of Ending Warlords";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 20f;
        public override int GoldCost => 5000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Weight Type", "Heavy" },
            { "Armor", "5-8" },
            { "Attributes", "4" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(5, 8);
        }
    }

    public class HelmetOfRelentlessSorrow : Equipament
    {
        public override string Namespace => "SK_ma_helm_darkknight_02_b";
        public override string Name => "Helmet Of Relentless Sorrow";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 20f;
        public override int GoldCost => 5000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Weight Type", "Heavy" },
            { "Armor", "5-8" },
            { "Attributes", "4" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(5, 8);
        }
    }

    public class HideMaskOfShadowWhispers : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_cultist_hood";
        public override string Name => "Hide Mask Of Shadow Whispers";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 1f;
        public override int GoldCost => 10000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Weight Type", "Medium" },
            { "Armor", "5-8" },
            { "Attributes", "4" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(5, 8);
        }
    }

    public class Hood : Equipament
    {
        public override string Namespace => "SK_fe_medieval_hat_03";
        public override string Name => "Hood";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 1f;
        public override int GoldCost => 20;
        public override int MaxAttrs => 1;
        public override EquipmentTier Tier => EquipmentTier.T0;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "0" },
            { "Weight Type", "Light" },
            { "Armor", "1" },
            { "Attributes", "1" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(1);
        }
    }

    public class HoodOfDivineHope : Equipament
    {
        public override string Namespace => "SK_fe_meta_tal_nrw_caster_hood_hair_01";
        public override string Name => "Hood Of Divine Hope";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 2f;
        public override int GoldCost => 800;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Weight Type", "Light" },
            { "Armor", "3-4" },
            { "Attributes", "1-3" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(3, 4);
        }
    }

    public class HoodOfHallowedDamnation : Equipament
    {
        public override string Namespace => "SK_ma_tal_nrw_hood_assassin";
        public override string Name => "Hood Of Hallowed Damnation";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 2f;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T4;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "4" },
            { "Weight Type", "Medium" },
            { "Armor", "3-5" },
            { "Attributes", "3-4" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(3, 5);
        }
    }

    public class HoodOfOminousTrials : Equipament
    {
        public override string Namespace => "SK_ma_tal_nrw_cloak_hood_up";
        public override string Name => "Hood Of Ominous Trials";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 1f;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Weight Type", "Light" },
            { "Armor", "2-4" },
            { "Attributes", "1-3" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(2, 4);
        }
    }

    public class InitiatedCrown : Equipament
    {
        public override string Namespace => "sk_ma_druid_helm_02_b";
        public override string Name => "Initiated Crown";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 1f;
        public override int GoldCost => 20;
        public override int MaxAttrs => 1;
        public override EquipmentTier Tier => EquipmentTier.T0;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "0" },
            { "Weight Type", "Light" },
            { "Armor", "1" },
            { "Attributes", "1" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(1);
        }
    }

    public class IronGreathelm : Equipament
    {
        public override string Namespace => "SK_helmet_knight_01_c";
        public override string Name => "Iron Greathelm";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 3f;
        public override int GoldCost => 20;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Weight Type", "Medium" },
            { "Armor", "2-3" },
            { "Attributes", "1-3" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(2, 3);
        }
    }

    public class IronHeadguard : Equipament
    {
        public override string Namespace => "SK_helmet_soldier_01_a";
        public override string Name => "Iron Headguard";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 3f;
        public override int GoldCost => 20;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Weight Type", "Medium" },
            { "Armor", "2-3" },
            { "Attributes", "1-3" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(2, 3);
        }
    }

    public class IvoryHelm : Equipament
    {
        public override string Namespace => "SK_helmet_knight_01_b_hood";
        public override string Name => "Ivory Helm";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 3f;
        public override int GoldCost => 20;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Weight Type", "Heavy" },
            { "Armor", "2-4" },
            { "Attributes", "1-3" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(2, 4);
        }
    }

    public class LeatherHelm : Equipament
    {
        public override string Namespace => "SK_ma_medieval_hat_02";
        public override string Name => "Leather Helm";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 1f;
        public override int GoldCost => 20;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T1;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "1" },
            { "Weight Type", "Medium" },
            { "Armor", "1-2" },
            { "Attributes", "1-2" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(1, 2);
        }
    }

    public class MagisterHat : Equipament
    {
        public override string Namespace => "sk_ma_meta_tal_nrwhat_caster_01_a";
        public override string Name => "Magister Hat";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 1f;
        public override int GoldCost => 20;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Weight Type", "Light" },
            { "Armor", "2-3" },
            { "Attributes", "1-3" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(2, 3);
        }
    }

    public class MaliciousMask : Equipament
    {
        public override string Namespace => "SK_ma_mask_wood_a";
        public override string Name => "Malicious Mask";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 1f;
        public override int GoldCost => 20;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T0;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "0" },
            { "Weight Type", "Light" },
            { "Armor", "1" },
            { "Attributes", "1-2" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(1);
        }
    }


    public class MaskOfCataclysms : Equipament
    {
        public override string Namespace => "SK_ma_mask_wood_b";
        public override string Name => "Mask Of Cataclysms";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 1f;
        public override int GoldCost => 20;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T1;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "1" },
            { "Weight Type", "Light" },
            { "Armor", "1-2" },
            { "Attributes", "1" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(1, 2);
        }
    }

    public class MaskOfNature : Equipament
    {
        public override string Namespace => "SK_ma_mask_wood_b_feather";
        public override string Name => "Mask Of Nature";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 1f;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T4;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "4" },
            { "Weight Type", "Light" },
            { "Armor", "3-5" },
            { "Attributes", "3-4" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(3, 5);
        }
    }

    public class MercenaryHelm : Equipament
    {
        public override string Namespace => "SK_ma_helm_darkknight_01_a";
        public override string Name => "Mercenary Helm";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 20f;
        public override int GoldCost => 2000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Weight Type", "Heavy" },
            { "Armor", "5-8" },
            { "Attributes", "4" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(5, 8);
        }
    }

    public class MilitaryIronGreathelm : Equipament
    {
        public override string Namespace => "SK_helmet_knight_02_a";
        public override string Name => "Military Iron Greathelm";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 5f;
        public override int GoldCost => 320;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Weight Type", "Heavy" },
            { "Armor", "2-3" },
            { "Attributes", "1-3" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(2, 3);
        }
    }

    public class NatureProtectorHead : Equipament
    {
        public override string Namespace => "sk_ma_druid_helm_01_b";
        public override string Name => "Nature Protector Head";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 5f;
        public override int GoldCost => 5000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Weight Type", "Medium" },
            { "Armor", "5-8" },
            { "Attributes", "4" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(5, 8);
        }
    }

    public class PlatemailHelm : Equipament
    {
        public override string Namespace => "SK_helmet_soldier_04_a";
        public override string Name => "Platemail Helm";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 5f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Weight Type", "Heavy" },
            { "Armor", "2-3" },
            { "Attributes", "1-2" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(2, 3);
        }
    }

    public class PromiseOfVengeanceHelm : Equipament
    {
        public override string Namespace => "SK_ma_helm_darkknight_02_a";
        public override string Name => "Promise Of Vengeance Helm";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 20f;
        public override int GoldCost => 10000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Weight Type", "Heavy" },
            { "Armor", "5-10" },
            { "Attributes", "4" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(5, 10);
        }
    }

    public class ProtectorHelm : Equipament
    {
        public override string Namespace => "SK_helmet_crusader_01_a";
        public override string Name => "Protector Helm";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 5f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Weight Type", "Medium" },
            { "Armor", "2-3" },
            { "Attributes", "1-3" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(2, 3);
        }
    }

    public class RascalHood : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_cultist_hood_trim";
        public override string Name => "Rascal Hood";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 1f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Weight Type", "Medium" },
            { "Armor", "2-3" },
            { "Attributes", "1-3" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(2, 3);
        }
    }

    public class RecruitHelm : Equipament
    {
        public override string Namespace => "SK_helmet_soldier_03_a";
        public override string Name => "Recruit Helm";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 1f;
        public override int GoldCost => 20;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T0;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "0" },
            { "Weight Type", "Medium" },
            { "Armor", "1" },
            { "Attributes", "1-2" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(1);
        }
    }

    public class RecruitsHelm : Equipament
    {
        public override string Namespace => "SK_helmet_soldier_05_a";
        public override string Name => "Recruit's Helm";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 1f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T1;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "1" },
            { "Weight Type", "Medium" },
            { "Armor", "1" },
            { "Attributes", "1-2" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(1);
        }
    }

    public class RoaringMailHelm : Equipament
    {
        public override string Namespace => "SK_helmet_knight_01_a_hood";
        public override string Name => "Roaring Mail Helm";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 5f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Weight Type", "Heavy" },
            { "Armor", "2-3" },
            { "Attributes", "1-2" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(2, 3);
        }
    }

    public class Scarf : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_scarf_single";
        public override string Name => "Scarf";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 1f;
        public override int GoldCost => 20;
        public override int MaxAttrs => 1;
        public override EquipmentTier Tier => EquipmentTier.T0;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "0" },
            { "Weight Type", "Light" },
            { "Armor", "1" },
            { "Attributes", "1" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(1);
        }
    }

    public class ShamanicMask : Equipament
    {
        public override string Namespace => "SK_ma_mask_wood_c";
        public override string Name => "Shamanic Mask";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 1f;
        public override int GoldCost => 800;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Weight Type", "Light" },
            { "Armor", "3-4" },
            { "Attributes", "1-3" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(3, 4);
        }
    }

    public class SoldierHelm : Equipament
    {
        public override string Namespace => "SK_helmet_soldier_02_a";
        public override string Name => "Soldier Helm";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 5f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T1;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "1" },
            { "Weight Type", "Medium" },
            { "Armor", "1-2" },
            { "Attributes", "1-2" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(1, 2);
        }
    }

    public class SpiritHideCrown : Equipament
    {
        public override string Namespace => "sk_ma_druid_helm_03_";
        public override string Name => "Spirit Hide Crown";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 1f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T1;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "1" },
            { "Weight Type", "Light" },
            { "Armor", "1-2" },
            { "Attributes", "1-2" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(1, 2);
        }
    }

    public class StrawHat : Equipament
    {
        public override string Namespace => "SK_fe_medieval_hat_05";
        public override string Name => "Straw Hat";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 1f;
        public override int GoldCost => 20;
        public override int MaxAttrs => 1;
        public override EquipmentTier Tier => EquipmentTier.T0;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "0" },
            { "Weight Type", "Light" },
            { "Armor", "1" },
            { "Attributes", "1" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(1);
        }
    }

    public class TellsHat : Equipament
    {
        public override string Namespace => "SK_fe_medieval_hat_02";
        public override string Name => "Tell's Hat";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 1f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Weight Type", "Light" },
            { "Armor", "2-3" },
            { "Attributes", "1-3" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(2, 3);
        }
    }

    public class TrooperHelm : Equipament
    {
        public override string Namespace => "SK_helmet_north_01_b";
        public override string Name => "Trooper Helm";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 5f;
        public override int GoldCost => 20;
        public override int MaxAttrs => 1;
        public override EquipmentTier Tier => EquipmentTier.T0;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "0" },
            { "Weight Type", "Medium" },
            { "Armor", "1" },
            { "Attributes", "1" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(1);
        }
    }

    public class TroublemakerMask : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_scarf_mask";
        public override string Name => "Troublemaker Mask";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 1f;
        public override int GoldCost => 20;
        public override int MaxAttrs => 1;
        public override EquipmentTier Tier => EquipmentTier.T0;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "0" },
            { "Weight Type", "Medium" },
            { "Armor", "1" },
            { "Attributes", "1" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(1);
        }
    }

    public class UnholyMask : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_skullmask_01";
        public override string Name => "Unholy Mask";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 1f;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Weight Type", "Light" },
            { "Armor", "5-8" },
            { "Attributes", "4" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(5, 8);
        }
    }

    public class VillagerHood : Equipament
    {
        public override string Namespace => "SK_helmet_merc_01_a";
        public override string Name => "Villager Hood";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 1f;
        public override int GoldCost => 20;
        public override int MaxAttrs => 1;
        public override EquipmentTier Tier => EquipmentTier.T0;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "0" },
            { "Weight Type", "Medium" },
            { "Armor", "1" },
            { "Attributes", "1" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(1);
        }
    }

    public class WarriorHelm : Equipament
    {
        public override string Namespace => "SK_helmet_crusader_02_a";
        public override string Name => "Warrior Helm";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 5f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Weight Type", "Heavy" },
            { "Armor", "2-3" },
            { "Attributes", "1-3" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(2, 3);
        }
    }

    public class WrathfulHelm : Equipament
    {
        public override string Namespace => "SK_helmet_north_01_a";
        public override string Name => "Wrathful Helm";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 5f;
        public override int GoldCost => 800;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T4;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "4" },
            { "Weight Type", "Medium" },
            { "Armor", "3-5" },
            { "Attributes", "3-4" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(3, 5);
        }
    }

    public class RatoMask : Equipament
    {
        public override string Namespace => "RatoMask";
        public override string Name => "Rato Borrachudo Mask";
        public override EquipmentType EquipmentType => EquipmentType.Helmet;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 5f;
        public override int GoldCost => 1;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T5;
        public override ItemRarity Rarity => ItemRarity.Unique;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Weight Type", "Light" },
            { "Armor", "3-5" },
            { "Attributes", "2" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(3, 5);
        }
    }
}
