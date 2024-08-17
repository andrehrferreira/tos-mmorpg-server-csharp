namespace Server.Gameplay.Items
{
    public class AgilityBoots : Equipament
    {
        public override string Namespace => "SK_ma_medieval_boot_01_b";
        public override string Name => "Agility Boots";
        public override string Alias => "AgilityBoots";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 2;
        public override int GoldCost => 400;
        public override int MaxAttrs => 2;
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

    public class ApprenticeBoots : Equipament
    {
        public override string Namespace => "SK_ma_medieval_shoe_02_a";
        public override string Name => "Apprentice Boots";
        public override string Alias => "ApprenticeBoots";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 1;
        public override int GoldCost => 400;
        public override int MaxAttrs => 2;
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

    public class ArmoredDarkPlateBoots : Equipament
    {
        public override string Namespace => "sk_ma_shoe_heavy_01_e";
        public override string Name => "Armored Dark Plate Boots";
        public override string Alias => "ArmoredDarkPlateBoots";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 10;
        public override int GoldCost => 1500;
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

    public class ArmoredRoyalGuardBoots : Equipament
    {
        public override string Namespace => "SK_ma_shoe_heavy_04_c";
        public override string Name => "Armored Royal Guard Boots";
        public override string Alias => "ArmoredRoyalGuardBoots";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 10;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Weight Type", "Heavy" },
            { "Armor", "2-4" },
            { "Attributes", "2-3" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(2, 4);
        }
    }

    public class BardBoots : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_elv_shoes_02";
        public override string Name => "Bard Boots";
        public override string Alias => "BardBoots";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 2;
        public override int GoldCost => 1500;
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

    public class BasicBoots : Equipament
    {
        public override string Namespace => "SK_ma_medieval_shoe_03_a";
        public override string Name => "Basic Boots";
        public override string Alias => "BasicBoots";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 1;
        public override int GoldCost => 60;
        public override int MaxAttrs => 2;
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

    public class BattleplateBoots : Equipament
    {
        public override string Namespace => "SK_ma_shoe_heavy_03_a";
        public override string Name => "Battleplate Boots";
        public override string Alias => "BattleplateBoots";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 10;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Weight Type", "Heavy" },
            { "Armor", "2-4" },
            { "Attributes", "2-3" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(2, 4);
        }
    }

    public class BootsOfCursedComrades : Equipament
    {
        public override string Namespace => "sk_ma_shoe_heavy_01_d";
        public override string Name => "Boots Of Cursed Comrades";
        public override string Alias => "BootsOfCursedComrades";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 10;
        public override int GoldCost => 1500;
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

    public class BootsOfEndingVisions : Equipament
    {
        public override string Namespace => "SK_ma_medieval_armour_boot_03_a";
        public override string Name => "Boots Of Ending Visions";
        public override string Alias => "BootsOfEndingVisions";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 2;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Weight Type", "Medium" },
            { "Armor", "2-4" },
            { "Attributes", "2-3" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(2, 4);
        }
    }

    public class BootsOfEndingWarlords : Equipament
    {
        public override string Namespace => "SK_ma_dragon_boots_01_a";
        public override string Name => "Boots Of Ending Warlords";
        public override string Alias => "BootsOfEndingWarlords";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 10;
        public override int GoldCost => 2500;
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

    public class BootsOfRecognition : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_boots_a";
        public override string Name => "Boots Of Recognition";
        public override string Alias => "BootsOfRecognition";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 2;
        public override int GoldCost => 1500;
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

    public class BootsOfRelentlessSorrow : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_barbar_boots_heavy_a";
        public override string Name => "Boots Of Relentless Sorrow";
        public override string Alias => "BootsOfRelentlessSorrow";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 10;
        public override int GoldCost => 2500;
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

    public class ChampionBoots : Equipament
    {
        public override string Namespace => "SK_ma_shoe_heavy_04_d";
        public override string Name => "Champion Boots";
        public override string Alias => "ChampionBoots";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 10;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Weight Type", "Heavy" },
            { "Armor", "2-4" },
            { "Attributes", "2-3" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(2, 4);
        }
    }

    public class CleverBoots : Equipament
    {
        public override string Namespace => "SK_ma_medieval_armour_boot_03_b";
        public override string Name => "Clever Boots";
        public override string Alias => "CleverBoots";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 5;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Weight Type", "Medium" },
            { "Armor", "2-4" },
            { "Attributes", "2-3" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(2, 4);
        }
    }

    public class ComfortableBoots : Equipament
    {
        public override string Namespace => "SK_ma_medieval_shoe_01_a";
        public override string Name => "Comfortable Boots";
        public override string Alias => "ComfortableBoots";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 2;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Weight Type", "Light" },
            { "Armor", "2-4" },
            { "Attributes", "2-3" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(2, 4);
        }
    }

    public class CommonBoots : Equipament
    {
        public override string Namespace => "SK_ma_medieval_armour_boot_02";
        public override string Name => "Common Boots";
        public override string Alias => "CommonBoots";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 2;
        public override int GoldCost => 60;
        public override int MaxAttrs => 2;
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

    public class CommonShoes : Equipament
    {
        public override string Namespace => "SK_ma_medieval_shoe_04_b";
        public override string Name => "Common Shoes";
        public override string Alias => "CommonShoes";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 1;
        public override int GoldCost => 60;
        public override int MaxAttrs => 2;
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

    public class ConquerorsMailBoots : Equipament
    {
        public override string Namespace => "SK_ma_medieval_boot_01_d";
        public override string Name => "Conqueror's Mail Boots";
        public override string Alias => "ConquerorsMailBoots";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 3;
        public override int GoldCost => 400;
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

    public class CozyBoots : Equipament
    {
        public override string Namespace => "SK_ma_medieval_shoe_02_b";
        public override string Name => "Cozy Boots";
        public override string Alias => "CozyBoots";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 3;
        public override int GoldCost => 200;
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

    public class DarkPlateBoots : Equipament
    {
        public override string Namespace => "sk_ma_shoe_heavy_01_a";
        public override string Name => "Dark Plate Boots";
        public override string Alias => "DarkPlateBoots";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 10;
        public override int GoldCost => 1500;
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

    public class DefenderOfBlightBoots : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_boots_01_c";
        public override string Name => "Defender Of Blight Boots";
        public override string Alias => "DefenderOfBlightBoots";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 10;
        public override int GoldCost => 2500;
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

    public class DragonhideLeatherBoots : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_shoes_01_a";
        public override string Name => "Dragonhide Leather Boots";
        public override string Alias => "DragonhideLeatherBoots";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 5;
        public override int GoldCost => 2500;
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

    public class FancyBoots : Equipament
    {
        public override string Namespace => "SK_ma_medieval_shoe_01_c";
        public override string Name => "Fancy Boots";
        public override string Alias => "FancyBoots";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 1;
        public override int GoldCost => 400;
        public override int MaxAttrs => 4;
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

    public class FurBoots : Equipament
    {
        public override string Namespace => "SK_fe_meta_tal_nrw_shoe_01_d";
        public override string Name => "Fur Boots";
        public override string Alias => "FurBoots";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 3;
        public override int GoldCost => 60;
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

    public class FuzzyBoot : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_boots_02";
        public override string Name => "Fuzzy Boot";
        public override string Alias => "FuzzyBoot";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 3;
        public override int GoldCost => 200;
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

    public class GranArcaneBoots : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_shoes_01_c";
        public override string Name => "Gran Arcane Boots";
        public override string Alias => "GranArcaneBoots";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 3;
        public override int GoldCost => 2500;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Weight Type", "Medium" },
            { "Armor", "3-5" },
            { "Attributes", "4" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(3, 5);
        }
    }

    public class GuardOfTheLightBoots : Equipament
    {
        public override string Namespace => "SK_ma_medieval_armour_boot_04";
        public override string Name => "Guard Of The Light Boots";
        public override string Alias => "GuardOfTheLightBoots";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 10;
        public override int GoldCost => 1500;
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

    public class GuardianBoots : Equipament
    {
        public override string Namespace => "SK_ma_shoe_heavy_04_e";
        public override string Name => "Guardian Boots";
        public override string Alias => "GuardianBoots";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 10;
        public override int GoldCost => 400;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Weight Type", "Heavy" },
            { "Armor", "1-3" },
            { "Attributes", "2-3" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(2, 3);
        }
    }

    public class HideBootsOfShadowWhispers : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_shoes_01_b";
        public override string Name => "Hide Boots Of Shadow Whispers";
        public override string Alias => "HideBootsOfShadowWhispers";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 2;
        public override int GoldCost => 2500;
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

    public class HighBoots : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_cultist_shoe_01_a";
        public override string Name => "High Boots";
        public override string Alias => "HighBoots";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 2;
        public override int GoldCost => 200;
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

    public class IvoryBoots : Equipament
    {
        public override string Namespace => "sk_ma_shoe_heavy_01_f";
        public override string Name => "Ivory Boots";
        public override string Alias => "IvoryBoots";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 3;
        public override int GoldCost => 400;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Weight Type", "Heavy" },
            { "Armor", "1-3" },
            { "Attributes", "1-2" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(1, 2);
        }
    }

    public class LeatherBoots : Equipament
    {
        public override string Namespace => "SK_fe_meta_tal_nrw_shoe_01_b";
        public override string Name => "Leather Boots";
        public override string Alias => "LeatherBoots";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 3;
        public override int GoldCost => 60;
        public override int MaxAttrs => 2;
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

    public class MercenaryBoots : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_shoes_01_d";
        public override string Name => "Mercenary Boots";
        public override string Alias => "MercenaryBoots";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 5;
        public override int GoldCost => 2500;
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

    public class MobilityBoots : Equipament
    {
        public override string Namespace => "SK_fe_meta_tal_nrw_shoe_01_c";
        public override string Name => "Mobility Boots";
        public override string Alias => "MobilityBoots";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 5;
        public override int GoldCost => 1500;
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

    public class MountainBoots : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_boots_b";
        public override string Name => "Mountain Boots";
        public override string Alias => "MountainBoots";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 1;
        public override int GoldCost => 200;
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

    public class NatureProtectorBoots : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_boots_03";
        public override string Name => "Nature Protector Boots";
        public override string Alias => "NatureProtectorBoots";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 5;
        public override int GoldCost => 2500;
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

    public class NoviceBoots : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_boots_01_a";
        public override string Name => "Novice Boots";
        public override string Alias => "NoviceBoots";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 2;
        public override int GoldCost => 200;
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

    public class PoshBoots : Equipament
    {
        public override string Namespace => "SK_ma_medieval_shoe_01_b";
        public override string Name => "Posh Boots";
        public override string Alias => "PoshBoots";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 2;
        public override int GoldCost => 400;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Weight Type", "Light" },
            { "Armor", "2-3" },
            { "Attributes", "1-2" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(2, 3);
        }
    }

    public class PromiseOfVengeanceBoots : Equipament
    {
        public override string Namespace => "SK_ma_dragon_boots_01_b";
        public override string Name => "Promise Of Vengeance Boots";
        public override string Alias => "PromiseOfVengeanceBoots";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 10;
        public override int GoldCost => 2500;
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

    public class ReinforcedBoot : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_cultist_shoe_01_b";
        public override string Name => "Reinforced Boot";
        public override string Alias => "ReinforcedBoot";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 2;
        public override int GoldCost => 200;
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

    public class RidingBoots : Equipament
    {
        public override string Namespace => "SK_ma_medieval_boot_01_a";
        public override string Name => "Riding Boots";
        public override string Alias => "RidingBoots";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 5;
        public override int GoldCost => 100;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T1;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "1" },
            { "Weight Type", "Medium" },
            { "Armor", "2-3" },
            { "Attributes", "1-2" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(2, 3);
        }
    }

    public class SlipShoes : Equipament
    {
        public override string Namespace => "SK_ma_medieval_shoe_04_a";
        public override string Name => "Slip Shoes";
        public override string Alias => "SlipShoes";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 1;
        public override int GoldCost => 60;
        public override int MaxAttrs => 2;
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

    public class SoldierBoots : Equipament
    {
        public override string Namespace => "SK_ma_shoe_heavy_04_b";
        public override string Name => "Soldier Boots";
        public override string Alias => "SoldierBoots";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 1;
        public override int GoldCost => 400;
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

    public class SpeedyBoots : Equipament
    {
        public override string Namespace => "SK_ma_medieval_boot_01_c";
        public override string Name => "Speedy Boots";
        public override string Alias => "SpeedyBoots";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 1;
        public override int GoldCost => 400;
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

    public class SpikedBoots : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_barbar_boots_heavy_c";
        public override string Name => "Spiked Boots";
        public override string Alias => "SpikedBoots";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override float Weight => 5;
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

    public class SturdyBoots : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_cultist_shoe_01_c";
        public override string Name => "Sturdy Boots";
        public override string Alias => "SturdyBoots";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override float Weight => 2;
        public override int GoldCost => 200;
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

    public class UnholyBoots : Equipament
    {
        public override string Namespace => "sk_ma_shoe_heavy_01_b";
        public override string Name => "Unholy Boots";
        public override string Alias => "UnholyBoots";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 10;
        public override int GoldCost => 1500;
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

    public class WrathfulBoots : Equipament
    {
        public override string Namespace => "SK_ma_shoe_heavy_04_a";
        public override string Name => "Wrathful Boots";
        public override string Alias => "WrathfulBoots";
        public override EquipmentType EquipmentType => EquipmentType.Boots;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override float Weight => 10;
        public override int GoldCost => 400;
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
}
