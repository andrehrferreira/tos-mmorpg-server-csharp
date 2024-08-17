namespace Server.Gameplay.Items
{
    public class ArcaneChest : Equipament
    {
        public override string Namespace => "sk_ma_meta_tal_nrw_mage_dress_01_a";
        public override string Name => "Arcane Chest";
        public override string Alias => "ArcaneChest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override int GoldCost => 4000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Weight Type", "Light" },
            { "Armor", "12-15" },
            { "Fire Resistence", "26-30" },
            { "Cold Resistence", "26-30" },
            { "Poison Resistence", "26-30" },
            { "Energy Resistence", "26-30" },
            { "Mana Regen", "10" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(12, 15);
            SetFireResistence(26, 30);
            SetColdResistence(26, 30);
            SetPoisonResistence(26, 30);
            SetEnergyResistence(26, 30);
            SetAttr(AttributeType.ManaRegen, 10);
        }
    }

    public class ArmorOfRelentlessSorrow : Equipament
    {
        public override string Namespace => "sk_ma_chest_deathknight_02_c";
        public override string Name => "Armor of Relentless Sorrow";
        public override string Alias => "ArmorOfRelentlessSorrow";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override int GoldCost => 4000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Weight Type", "Heavy" },
            { "Armor", "26-30" },
            { "Fire Resistence", "12-15" },
            { "Cold Resistence", "12-15" },
            { "Poison Resistence", "12-15" },
            { "Energy Resistence", "12-15" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(26, 30);
            SetFireResistence(12, 15);
            SetColdResistence(12, 15);
            SetPoisonResistence(12, 15);
            SetEnergyResistence(12, 15);
        }
    }

    public class ArmoredDarkPlateChest : Equipament
    {
        public override string Namespace => "SK_ma_chest_heavy_plated_b";
        public override string Name => "Armored Dark Plate Chest";
        public override string Alias => "ArmoredDarkPlateChest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override int GoldCost => 4000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Weight Type", "Heavy" },
            { "Armor", "26-30" },
            { "Fire Resistence", "12-15" },
            { "Cold Resistence", "12-15" },
            { "Poison Resistence", "12-15" },
            { "Energy Resistence", "12-15" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(26, 30);
            SetFireResistence(12, 15);
            SetColdResistence(12, 15);
            SetPoisonResistence(12, 15);
            SetEnergyResistence(12, 15);
        }
    }

    public class ArmoredFullPlateChest : Equipament
    {
        public override string Namespace => "SK_chest_knight_01_d";
        public override string Name => "Armored Full Plate Chest";
        public override string Alias => "ArmoredFullPlateChest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override int GoldCost => 4000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Weight Type", "Heavy" },
            { "Armor", "26-30" },
            { "Fire Resistence", "12-15" },
            { "Cold Resistence", "12-15" },
            { "Poison Resistence", "12-15" },
            { "Energy Resistence", "12-15" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(26, 30);
            SetFireResistence(12, 15);
            SetColdResistence(12, 15);
            SetPoisonResistence(12, 15);
            SetEnergyResistence(12, 15);
        }
    }

    public class ArmoredKnightChest : Equipament
    {
        public override string Namespace => "SK_chest_knight_01_b";
        public override string Name => "Armored Knight Chest";
        public override string Alias => "ArmoredKnightChest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override int GoldCost => 4000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Weight Type", "Heavy" },
            { "Armor", "26-30" },
            { "Fire Resistence", "12-15" },
            { "Cold Resistence", "12-15" },
            { "Poison Resistence", "12-15" },
            { "Energy Resistence", "12-15" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(26, 30);
            SetFireResistence(12, 15);
            SetColdResistence(12, 15);
            SetPoisonResistence(12, 15);
            SetEnergyResistence(12, 15);
        }
    }

    public class KnightChest : Equipament
    {
        public override string Namespace => "SK_chest_knight_02_a";
        public override string Name => "Knight Chest";
        public override string Alias => "KnightChest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override int GoldCost => 350;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Weight Type", "Medium" },
            { "Armor", "10-14" },
            { "Fire Resistence", "5-6" },
            { "Cold Resistence", "5-6" },
            { "Poison Resistence", "5-6" },
            { "Energy Resistence", "5-6" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(10, 14);
            SetFireResistence(5, 6);
            SetColdResistence(5, 6);
            SetPoisonResistence(5, 6);
            SetEnergyResistence(5, 6);
        }
    }

    public class ArmoredRoyalGuardChest : Equipament
    {
        public override string Namespace => "SK_chest_knight_01_c_";
        public override string Name => "Armored Royal Guard Chest";
        public override string Alias => "ArmoredRoyalGuardChest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override int GoldCost => 4000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Weight Type", "Heavy" },
            { "Armor", "26-30" },
            { "Fire Resistence", "12-15" },
            { "Cold Resistence", "12-15" },
            { "Poison Resistence", "12-15" },
            { "Energy Resistence", "12-15" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(26, 30);
            SetFireResistence(12, 15);
            SetColdResistence(12, 15);
            SetPoisonResistence(12, 15);
            SetEnergyResistence(12, 15);
        }
    }

    public class ArmoredSacredChest : Equipament
    {
        public override string Namespace => "SK_chest_knight_01_a";
        public override string Name => "Armored Sacred Chest";
        public override string Alias => "ArmoredSacredChest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override int GoldCost => 4000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Weight Type", "Heavy" },
            { "Armor", "26-30" },
            { "Fire Resistence", "12-15" },
            { "Cold Resistence", "12-15" },
            { "Poison Resistence", "12-15" },
            { "Energy Resistence", "12-15" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(26, 30);
            SetFireResistence(12, 15);
            SetColdResistence(12, 15);
            SetPoisonResistence(12, 15);
            SetEnergyResistence(12, 15);
        }
    }

    public class BarbarianChest : Equipament
    {
        public override string Namespace => "SK_ma_metal_tal_nrw_barbar_chest_05_d";
        public override string Name => "Barbarian Chest";
        public override string Alias => "BarbarianChest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override int GoldCost => 2000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T4;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "4" },
            { "Weight Type", "Medium" },
            { "Armor", "21-25" },
            { "Fire Resistence", "9-11" },
            { "Cold Resistence", "9-11" },
            { "Poison Resistence", "9-11" },
            { "Energy Resistence", "9-11" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(21, 25);
            SetFireResistence(9, 11);
            SetColdResistence(9, 11);
            SetPoisonResistence(9, 11);
            SetEnergyResistence(9, 11);
        }
    }

    public class BarbaricScaleArmor : Equipament
    {
        public override string Namespace => "SK_ma_chest_heavy_03_c";
        public override string Name => "Barbaric Scale Armor";
        public override string Alias => "BarbaricScaleArmor";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override int GoldCost => 800;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Weight Type", "Medium" },
            { "Armor", "15-20" },
            { "Fire Resistence", "7-9" },
            { "Cold Resistence", "7-9" },
            { "Poison Resistence", "7-9" },
            { "Energy Resistence", "7-9" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(15, 20);
            SetFireResistence(7, 9);
            SetColdResistence(7, 9);
            SetPoisonResistence(7, 9);
            SetEnergyResistence(7, 9);
        }
    }

    public class BardVest : Equipament
    {
        public override string Namespace => "SK_ma_medieval_chest_citizen_01_a";
        public override string Name => "Bard Vest";
        public override string Alias => "BardVest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override int GoldCost => 4000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Weight Type", "Light" },
            { "Armor", "16-20" },
            { "Fire Resistence", "16-20" },
            { "Cold Resistence", "16-20" },
            { "Poison Resistence", "16-20" },
            { "Energy Resistence", "16-20" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(16, 20);
            SetFireResistence(16, 20);
            SetColdResistence(16, 20);
            SetPoisonResistence(16, 20);
            SetEnergyResistence(16, 20);
        }
    }

    public class BattleplateChest : Equipament
    {
        public override string Namespace => "SK_ma_chest_heavy_05_b";
        public override string Name => "Battleplate Chest";
        public override string Alias => "BattleplateChest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override int GoldCost => 2000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T4;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "4" },
            { "Weight Type", "Medium" },
            { "Armor", "21-25" },
            { "Fire Resistence", "9-11" },
            { "Cold Resistence", "9-11" },
            { "Poison Resistence", "9-11" },
            { "Energy Resistence", "9-11" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(21, 25);
            SetFireResistence(9, 11);
            SetColdResistence(9, 11);
            SetPoisonResistence(9, 11);
            SetEnergyResistence(9, 11);
        }
    }

    public class BerserkerChest : Equipament
    {
        public override string Namespace => "SK_ma_metal_tal_nrw_barbar_chest_01_b_0";
        public override string Name => "Berserker Chest";
        public override string Alias => "BerserkerChest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override int GoldCost => 2000;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Weight Type", "Light" },
            { "Armor", "15-20" },
            { "Fire Resistence", "7-8" },
            { "Cold Resistence", "7-8" },
            { "Poison Resistence", "7-8" },
            { "Energy Resistence", "7-8" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(15, 20);
            SetFireResistence(7, 8);
            SetColdResistence(7, 8);
            SetPoisonResistence(7, 8);
            SetEnergyResistence(7, 8);
        }
    }

    public class ChampionChestplate : Equipament
    {
        public override string Namespace => "SK_ma_chest_heavy_04_b";
        public override string Name => "Champion Chestplate";
        public override string Alias => "ChampionChestplate";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override int GoldCost => 2000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T4;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "4" },
            { "Weight Type", "Heavy" },
            { "Armor", "21-25" },
            { "Fire Resistence", "9-11" },
            { "Cold Resistence", "9-11" },
            { "Poison Resistence", "9-11" },
            { "Energy Resistence", "9-11" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(21, 25);
            SetFireResistence(9, 11);
            SetColdResistence(9, 11);
            SetPoisonResistence(9, 11);
            SetEnergyResistence(9, 11);
        }
    }

    public class ChestplateOfEndingWarlords : Equipament
    {
        public override string Namespace => "sk_ma_chest_darkknight_01_c";
        public override string Name => "Chestplate of Ending Warlords";
        public override string Alias => "ChestplateOfEndingWarlords";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override int GoldCost => 2000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Weight Type", "Heavy" },
            { "Armor", "26-30" },
            { "Fire Resistence", "12-15" },
            { "Cold Resistence", "12-15" },
            { "Poison Resistence", "12-15" },
            { "Energy Resistence", "12-15" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(26, 30);
            SetFireResistence(12, 15);
            SetColdResistence(12, 15);
            SetPoisonResistence(12, 15);
            SetEnergyResistence(12, 15);
        }
    }

    public class CommonCultistMetalChest : Equipament
    {
        public override string Namespace => "sk_ma_meta_tal_nrw_cultist_dress_a";
        public override string Name => "Common Cultist Metal Chest";
        public override string Alias => "CommonCultistMetalChest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override int GoldCost => 2000;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T1;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "1" },
            { "Weight Type", "Light" },
            { "Armor", "3-4" },
            { "Fire Resistence", "6-9" },
            { "Cold Resistence", "6-9" },
            { "Poison Resistence", "6-9" },
            { "Energy Resistence", "6-9" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(3, 4);
            SetFireResistence(6, 9);
            SetColdResistence(6, 9);
            SetPoisonResistence(6, 9);
            SetEnergyResistence(6, 9);
        }
    }

    public class CommonVillagerChest : Equipament
    {
        public override string Namespace => "SK_ma_medieval_chest_villager_02_a";
        public override string Name => "Common Villager Chest";
        public override string Alias => "CommonVillagerChest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override int GoldCost => 100;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T1;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "1" },
            { "Weight Type", "Medium" },
            { "Armor", "6-9" },
            { "Fire Resistence", "3-4" },
            { "Cold Resistence", "3-4" },
            { "Poison Resistence", "3-4" },
            { "Energy Resistence", "3-4" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(6, 9);
            SetFireResistence(3, 4);
            SetColdResistence(3, 4);
            SetPoisonResistence(3, 4);
            SetEnergyResistence(3, 4);
        }
    }

    public class CommonVillagerProtectorChest : Equipament
    {
        public override string Namespace => "SK_ma_medieval_chest_villager_03_c";
        public override string Name => "Common Villager Protector Chest";
        public override string Alias => "CommonVillagerProtectorChest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override int GoldCost => 350;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Weight Type", "Medium" },
            { "Armor", "10-14" },
            { "Fire Resistence", "5-6" },
            { "Cold Resistence", "5-6" },
            { "Poison Resistence", "5-6" },
            { "Energy Resistence", "5-6" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(10, 14);
            SetFireResistence(5, 6);
            SetColdResistence(5, 6);
            SetPoisonResistence(5, 6);
            SetEnergyResistence(5, 6);
        }
    }

    public class CommonWhiteRuggedLeatherChest : Equipament
    {
        public override string Namespace => "SK_chest_soldier_01_a";
        public override string Name => "Common White Rugged Leather Chest";
        public override string Alias => "CommonWhiteRuggedLeatherChest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override int GoldCost => 100;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T1;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "1" },
            { "Weight Type", "Medium" },
            { "Armor", "6-9" },
            { "Fire Resistence", "3-4" },
            { "Cold Resistence", "3-4" },
            { "Poison Resistence", "3-4" },
            { "Energy Resistence", "3-4" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(6, 9);
            SetFireResistence(3, 4);
            SetColdResistence(3, 4);
            SetPoisonResistence(3, 4);
            SetEnergyResistence(3, 4);
        }
    }

    public class CommonWorkerChest : Equipament
    {
        public override string Namespace => "SK_ma_medieval_chest_villager_02_b";
        public override string Name => "Common Worker Chest";
        public override string Alias => "CommonWorkerChest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override int GoldCost => 100;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T1;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "1" },
            { "Weight Type", "Medium" },
            { "Armor", "6-9" },
            { "Fire Resistence", "3-4" },
            { "Cold Resistence", "3-4" },
            { "Poison Resistence", "3-4" },
            { "Energy Resistence", "3-4" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(6, 9);
            SetFireResistence(3, 4);
            SetColdResistence(3, 4);
            SetPoisonResistence(3, 4);
            SetEnergyResistence(3, 4);
        }
    }

    public class ConquerorsMailChest : Equipament
    {
        public override string Namespace => "SK_chest_north_02_a_fur";
        public override string Name => "Conqueror's Mail Chest";
        public override string Alias => "ConquerorsMailChest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override int GoldCost => 800;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Weight Type", "Light" },
            { "Armor", "9-12" },
            { "Fire Resistence", "9-12" },
            { "Cold Resistence", "9-12" },
            { "Poison Resistence", "9-12" },
            { "Energy Resistence", "9-12" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(9, 12);
            SetFireResistence(9, 12);
            SetColdResistence(9, 12);
            SetPoisonResistence(9, 12);
            SetEnergyResistence(9, 12);
        }
    }

    public class CuirassOfCursedComrades : Equipament
    {
        public override string Namespace => "SK_chest_north_02_a_fur";
        public override string Name => "Cuirass of Cursed Comrades";
        public override string Alias => "CuirassOfCursedComrades";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override int GoldCost => 4000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Weight Type", "Heavy" },
            { "Armor", "26-30" },
            { "Fire Resistence", "12-15" },
            { "Cold Resistence", "12-15" },
            { "Poison Resistence", "12-15" },
            { "Energy Resistence", "12-15" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(26, 30);
            SetFireResistence(12, 15);
            SetColdResistence(12, 15);
            SetPoisonResistence(12, 15);
            SetEnergyResistence(12, 15);
        }
    }

    public class CultistGarment : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_cultist_dress_e";
        public override string Name => "Cultist Garment";
        public override string Alias => "CultistGarment";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override int GoldCost => 350;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Weight Type", "Light" },
            { "Armor", "5-6" },
            { "Fire Resistence", "10-14" },
            { "Cold Resistence", "10-14" },
            { "Poison Resistence", "10-14" },
            { "Energy Resistence", "10-14" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(5, 6);
            SetFireResistence(10, 14);
            SetColdResistence(10, 14);
            SetPoisonResistence(10, 14);
            SetEnergyResistence(10, 14);
        }
    }

    public class CultistRobe : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_cultist_dress_b";
        public override string Name => "Cultist Robe";
        public override string Alias => "CultistRobe";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override int GoldCost => 350;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Weight Type", "Light" },
            { "Armor", "5-6" },
            { "Fire Resistence", "10-14" },
            { "Cold Resistence", "10-14" },
            { "Poison Resistence", "10-14" },
            { "Energy Resistence", "10-14" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(5, 6);
            SetFireResistence(10, 14);
            SetColdResistence(10, 14);
            SetPoisonResistence(10, 14);
            SetEnergyResistence(10, 14);
        }
    }

    public class DarkKinghtChest : Equipament
    {
        public override string Namespace => "SK_ma_chest_darkknight_01_b";
        public override string Name => "Dark Kinght Chest";
        public override string Alias => "DarkKinghtChest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override int GoldCost => 4000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Weight Type", "Heavy" },
            { "Armor", "26-30" },
            { "Fire Resistence", "12-15" },
            { "Cold Resistence", "12-15" },
            { "Poison Resistence", "12-15" },
            { "Energy Resistence", "12-15" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(26, 30);
            SetFireResistence(12, 15);
            SetColdResistence(12, 15);
            SetPoisonResistence(12, 15);
            SetEnergyResistence(12, 15);
        }
    }

    public class DarkPlateChest : Equipament
    {
        public override string Namespace => "SK_ma_chest_heavy_plated_a";
        public override string Name => "Dark Plate Chest";
        public override string Alias => "DarkPlateChest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override int GoldCost => 2000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T4;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "4" },
            { "Weight Type", "Heavy" },
            { "Armor", "26-30" },
            { "Fire Resistence", "12-15" },
            { "Cold Resistence", "12-15" },
            { "Poison Resistence", "12-15" },
            { "Energy Resistence", "12-15" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(26, 30);
            SetFireResistence(12, 15);
            SetColdResistence(12, 15);
            SetPoisonResistence(12, 15);
            SetEnergyResistence(12, 15);
        }
    }

    public class DefenderArmor : Equipament
    {
        public override string Namespace => "SK_chest_north_02_b";
        public override string Name => "Defender Armor";
        public override string Alias => "DefenderArmor";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override int GoldCost => 350;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Weight Type", "Heavy" },
            { "Armor", "10-14" },
            { "Fire Resistence", "5-6" },
            { "Cold Resistence", "5-6" },
            { "Poison Resistence", "5-6" },
            { "Energy Resistence", "5-6" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(10, 14);
            SetFireResistence(5, 6);
            SetColdResistence(5, 6);
            SetPoisonResistence(5, 6);
            SetEnergyResistence(5, 6);
        }
    }

    public class DefenderOfBlightChest : Equipament
    {
        public override string Namespace => "sk_ma_meta_tal_nrw_mage_dress_01_c";
        public override string Name => "Defender of Blight Chest";
        public override string Alias => "DefenderOfBlightChest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override int GoldCost => 2000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T4;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "4" },
            { "Weight Type", "Light" },
            { "Armor", "9-11" },
            { "Fire Resistence", "21-25" },
            { "Cold Resistence", "21-25" },
            { "Poison Resistence", "21-25" },
            { "Energy Resistence", "21-25" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(9, 11);
            SetFireResistence(21, 25);
            SetColdResistence(21, 25);
            SetPoisonResistence(21, 25);
            SetEnergyResistence(21, 25);
        }
    }

    public class DragonhideLeatherChest : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_rogue_01_b";
        public override string Name => "Dragonhide Leather Chest";
        public override string Alias => "DragonhideLeatherChest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override int GoldCost => 4000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Weight Type", "Medium" },
            { "Armor", "16-20" },
            { "Fire Resistence", "16-20" },
            { "Cold Resistence", "16-20" },
            { "Poison Resistence", "16-20" },
            { "Energy Resistence", "16-20" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(16, 20);
            SetFireResistence(16, 20);
            SetColdResistence(16, 20);
            SetPoisonResistence(16, 20);
            SetEnergyResistence(16, 20);
        }
    }

    public class DruidLeatherRobe : Equipament
    {
        public override string Namespace => "SK_ma_druid_set_01_b";
        public override string Name => "Druid Leather Robe";
        public override string Alias => "DruidLeatherRobe";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override int GoldCost => 350;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Weight Type", "Light" },
            { "Armor", "5-6" },
            { "Fire Resistence", "10-14" },
            { "Cold Resistence", "10-14" },
            { "Poison Resistence", "10-14" },
            { "Energy Resistence", "10-14" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(5, 6);
            SetFireResistence(10, 14);
            SetColdResistence(10, 14);
            SetPoisonResistence(10, 14);
            SetEnergyResistence(10, 14);
        }
    }

    public class DruidWinterGarments : Equipament
    {
        public override string Namespace => "SK_ma_druid_set_02_c";
        public override string Name => "Druid Winter Garments";
        public override string Alias => "DruidWinterGarments";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override int GoldCost => 2000;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Weight Type", "Light" },
            { "Armor", "5-6" },
            { "Fire Resistence", "10-14" },
            { "Cold Resistence", "10-14" },
            { "Poison Resistence", "10-14" },
            { "Energy Resistence", "10-14" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(5, 6);
            SetFireResistence(10, 14);
            SetColdResistence(10, 14);
            SetPoisonResistence(10, 14);
            SetEnergyResistence(10, 14);
        }
    }

    public class EngravedArmor : Equipament
    {
        public override string Namespace => "sk_ma_chest_deathknight_02_a";
        public override string Name => "Engraved Armor";
        public override string Alias => "EngravedArmor";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override int GoldCost => 4000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Weight Type", "Heavy" },
            { "Armor", "25-30" },
            { "Fire Resistence", "12-15" },
            { "Cold Resistence", "12-15" },
            { "Poison Resistence", "12-15" },
            { "Energy Resistence", "12-15" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(25, 30);
            SetFireResistence(12, 15);
            SetColdResistence(12, 15);
            SetPoisonResistence(12, 15);
            SetEnergyResistence(12, 15);
        }
    }

    public class FancierCommonerChest : Equipament
    {
        public override string Namespace => "SK_ma_medieval_chest_citizen_02_c";
        public override string Name => "Fancier Commoner Chest";
        public override string Alias => "FancierCommonerChest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override int GoldCost => 350;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Weight Type", "Light" },
            { "Armor", "7-8" },
            { "Fire Resistence", "7-8" },
            { "Cold Resistence", "7-8" },
            { "Poison Resistence", "7-8" },
            { "Energy Resistence", "7-8" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(7, 8);
            SetFireResistence(7, 8);
            SetColdResistence(7, 8);
            SetPoisonResistence(7, 8);
            SetEnergyResistence(7, 8);
        }
    }

    public class FancyCommonerChest : Equipament
    {
        public override string Namespace => "SK_ma_medieval_chest_citizen_02_b";
        public override string Name => "Fancy Commoner Chest";
        public override string Alias => "FancyCommonerChest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override int GoldCost => 350;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Weight Type", "Light" },
            { "Armor", "7-8" },
            { "Fire Resistence", "7-8" },
            { "Cold Resistence", "7-8" },
            { "Poison Resistence", "7-8" },
            { "Energy Resistence", "7-8" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(7, 8);
            SetFireResistence(7, 8);
            SetColdResistence(7, 8);
            SetPoisonResistence(7, 8);
            SetEnergyResistence(7, 8);
        }
    }

    public class FancyWhiteRuggedLeatherChest : Equipament
    {
        public override string Namespace => "SK_chest_soldier_fancy_01_b";
        public override string Name => "Fancy White Rugged Leather Chest";
        public override string Alias => "FancyWhiteRuggedLeatherChest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override int GoldCost => 500;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Weight Type", "Light" },
            { "Armor", "8-10" },
            { "Fire Resistence", "10-12" },
            { "Cold Resistence", "10-12" },
            { "Poison Resistence", "10-12" },
            { "Energy Resistence", "10-12" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(8, 10);
            SetFireResistence(10, 12);
            SetColdResistence(10, 12);
            SetPoisonResistence(10, 12);
            SetEnergyResistence(10, 12);
        }
    }

    public class FighterArmor : Equipament
    {
        public override string Namespace => "SK_ma_chest_fighter_01_b";
        public override string Name => "Fighter Armor";
        public override string Alias => "FighterArmor";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override int GoldCost => 4000;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T4;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "4" },
            { "Weight Type", "Heavy" },
            { "Armor", "20-24" },
            { "Fire Resistence", "18-20" },
            { "Cold Resistence", "18-20" },
            { "Poison Resistence", "18-20" },
            { "Energy Resistence", "18-20" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(20, 24);
            SetFireResistence(18, 20);
            SetColdResistence(18, 20);
            SetPoisonResistence(18, 20);
            SetEnergyResistence(18, 20);
        }
    }

    public class GranArcaneVest : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_mage_dress_01_a_bags";
        public override string Name => "Gran Arcane Vest";
        public override string Alias => "GranArcaneVest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override int GoldCost => 4000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Weight Type", "Light" },
            { "Armor", "12-15" },
            { "Fire Resistence", "26-30" },
            { "Cold Resistence", "26-30" },
            { "Poison Resistence", "26-30" },
            { "Energy Resistence", "26-30" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(12, 15);
            SetFireResistence(26, 30);
            SetColdResistence(26, 30);
            SetPoisonResistence(26, 30);
            SetEnergyResistence(26, 30);
        }
    }

    public class GreatleatherChest : Equipament
    {
        public override string Namespace => "sk_chest_merc_02_b";
        public override string Name => "Greatleather Chest";
        public override string Alias => "GreatleatherChest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override int GoldCost => 2000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T4;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "4" },
            { "Weight Type", "Medium" },
            { "Armor", "13-15" },
            { "Fire Resistence", "13-15" },
            { "Cold Resistence", "13-15" },
            { "Poison Resistence", "13-15" },
            { "Energy Resistence", "13-15" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(13, 15);
            SetFireResistence(13, 15);
            SetColdResistence(13, 15);
            SetPoisonResistence(13, 15);
            SetEnergyResistence(13, 15);
        }
    }

    public class GuardOfTheLightArmor : Equipament
    {
        public override string Namespace => "SK_ma_chest_heavy_05_c";
        public override string Name => "Guard of the Light Armor";
        public override string Alias => "GuardOfTheLightArmor";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override int GoldCost => 2000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T4;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "4" },
            { "Weight Type", "Heavy" },
            { "Armor", "21-25" },
            { "Fire Resistence", "9-11" },
            { "Cold Resistence", "9-11" },
            { "Poison Resistence", "9-11" },
            { "Energy Resistence", "9-11" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(21, 25);
            SetFireResistence(9, 11);
            SetColdResistence(9, 11);
            SetPoisonResistence(9, 11);
            SetEnergyResistence(9, 11);
        }
    }

    public class GuardianArmor : Equipament
    {
        public override string Namespace => "SK_chest_knight_02_b";
        public override string Name => "Guardian Armor";
        public override string Alias => "GuardianArmor";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override int GoldCost => 350;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Weight Type", "Heavy" },
            { "Armor", "10-14" },
            { "Fire Resistence", "5-6" },
            { "Cold Resistence", "5-6" },
            { "Poison Resistence", "5-6" },
            { "Energy Resistence", "5-6" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(10, 14);
            SetFireResistence(5, 6);
            SetColdResistence(5, 6);
            SetPoisonResistence(5, 6);
            SetEnergyResistence(5, 6);
        }
    }

    public class HeavyHideVestArmor : Equipament
    {
        public override string Namespace => "SK_chest_north_01_a";
        public override string Name => "Heavy Hide Vest Armor";
        public override string Alias => "HeavyHideVestArmor";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override int GoldCost => 100;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T1;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "1" },
            { "Weight Type", "Medium" },
            { "Armor", "6-9" },
            { "Fire Resistence", "3-4" },
            { "Cold Resistence", "3-4" },
            { "Poison Resistence", "3-4" },
            { "Energy Resistence", "3-4" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(6, 9);
            SetFireResistence(3, 4);
            SetColdResistence(3, 4);
            SetPoisonResistence(3, 4);
            SetEnergyResistence(3, 4);
        }
    }

    public class HeavyNorthChest : Equipament
    {
        public override string Namespace => "SK_chest_north_02_d";
        public override string Name => "Heavy North Chest";
        public override string Alias => "HeavyNorthChest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override int GoldCost => 100;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Weight Type", "Medium" },
            { "Armor", "5-6" },
            { "Fire Resistence", "5-6" },
            { "Cold Resistence", "5-6" },
            { "Poison Resistence", "5-6" },
            { "Energy Resistence", "5-6" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(5, 6);
            SetFireResistence(5, 6);
            SetColdResistence(5, 6);
            SetPoisonResistence(5, 6);
            SetEnergyResistence(5, 6);
        }
    }
    public class HideChestOfShadowWhispers : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_elv_chest_01_a";
        public override string Name => "Hide Chest of Shadow Whispers";
        public override string Alias => "HideChestOfShadowWhispers";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override int GoldCost => 4000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Weight Type", "Medium" },
            { "Armor", "16-20" },
            { "Fire Resistence", "16-20" },
            { "Cold Resistence", "16-20" },
            { "Poison Resistence", "16-20" },
            { "Energy Resistence", "16-20" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(16, 20);
            SetFireResistence(16, 20);
            SetColdResistence(16, 20);
            SetPoisonResistence(16, 20);
            SetEnergyResistence(16, 20);
        }
    }

    public class HideVestArmor : Equipament
    {
        public override string Namespace => "SK_chest_north_01_b";
        public override string Name => "Hide Vest Armor";
        public override string Alias => "HideVestArmor";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override int GoldCost => 100;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T1;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "1" },
            { "Weight Type", "Medium" },
            { "Armor", "6-9" },
            { "Fire Resistence", "3-4" },
            { "Cold Resistence", "3-4" },
            { "Poison Resistence", "3-4" },
            { "Energy Resistence", "3-4" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(6, 9);
            SetFireResistence(3, 4);
            SetColdResistence(3, 4);
            SetPoisonResistence(3, 4);
            SetEnergyResistence(3, 4);
        }
    }

    public class InitiatedRobe : Equipament
    {
        public override string Namespace => "SK_ma_druid_set_01_a";
        public override string Name => "Initiated Robe";
        public override string Alias => "InitiatedRobe";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override int GoldCost => 20;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T0;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "0" },
            { "Weight Type", "Light" },
            { "Armor", "1-2" },
            { "Fire Resistence", "3-5" },
            { "Cold Resistence", "3-5" },
            { "Poison Resistence", "3-5" },
            { "Energy Resistence", "3-5" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(1, 2);
            SetFireResistence(3, 5);
            SetColdResistence(3, 5);
            SetPoisonResistence(3, 5);
            SetEnergyResistence(3, 5);
        }
    }

    public class IvoryArmor : Equipament
    {
        public override string Namespace => "sk_chest_merc_02_d";
        public override string Name => "Ivory Armor";
        public override string Alias => "IvoryArmor";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override int GoldCost => 800;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Weight Type", "Medium" },
            { "Armor", "9-12" },
            { "Fire Resistence", "9-12" },
            { "Cold Resistence", "9-12" },
            { "Poison Resistence", "9-12" },
            { "Energy Resistence", "9-12" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(9, 12);
            SetFireResistence(9, 12);
            SetColdResistence(9, 12);
            SetPoisonResistence(9, 12);
            SetEnergyResistence(9, 12);
        }
    }

    public class JokerChest : Equipament
    {
        public override string Namespace => "SK_ma_medieval_chest_citizen_02_a";
        public override string Name => "Joker Chest";
        public override string Alias => "JokerChest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override int GoldCost => 2000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T4;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "4" },
            { "Weight Type", "Medium" },
            { "Armor", "13-15" },
            { "Fire Resistence", "13-15" },
            { "Cold Resistence", "13-15" },
            { "Poison Resistence", "13-15" },
            { "Energy Resistence", "13-15" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(13, 15);
            SetFireResistence(13, 15);
            SetColdResistence(13, 15);
            SetPoisonResistence(13, 15);
            SetEnergyResistence(13, 15);
        }
    }

    public class LeatherChest : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_rogue_01_a";
        public override string Name => "Leather Chest";
        public override string Alias => "LeatherChest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override int GoldCost => 4000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Weight Type", "Light" },
            { "Armor", "16-20" },
            { "Fire Resistence", "16-20" },
            { "Cold Resistence", "16-20" },
            { "Poison Resistence", "16-20" },
            { "Energy Resistence", "16-20" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(16, 20);
            SetFireResistence(16, 20);
            SetColdResistence(16, 20);
            SetPoisonResistence(16, 20);
            SetEnergyResistence(16, 20);
        }
    }

    public class LeatherGarments : Equipament
    {
        public override string Namespace => "SK_ma_medieval_chest_villager_01_a";
        public override string Name => "Leather Garments";
        public override string Alias => "LeatherGarments";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override int GoldCost => 100;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T1;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "1" },
            { "Weight Type", "Light" },
            { "Armor", "5-6" },
            { "Fire Resistence", "5-6" },
            { "Cold Resistence", "5-6" },
            { "Poison Resistence", "5-6" },
            { "Energy Resistence", "5-6" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(5, 6);
            SetFireResistence(5, 6);
            SetColdResistence(5, 6);
            SetPoisonResistence(5, 6);
            SetEnergyResistence(5, 6);
        }
    }

    public class MaliciousChest : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_cultist_dress_d";
        public override string Name => "Malicious Chest";
        public override string Alias => "MaliciousChest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override int GoldCost => 20;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T0;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "0" },
            { "Weight Type", "Light" },
            { "Armor", "1-2" },
            { "Fire Resistence", "3-5" },
            { "Cold Resistence", "3-5" },
            { "Poison Resistence", "3-5" },
            { "Energy Resistence", "3-5" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(1, 2);
            SetFireResistence(3, 5);
            SetColdResistence(3, 5);
            SetPoisonResistence(3, 5);
            SetEnergyResistence(3, 5);
        }
    }

    public class MasterOfDeath : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_cultist_dress_knight_02_001";
        public override string Name => "Master of Death";
        public override string Alias => "MasterOfDeath";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override int GoldCost => 4000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Weight Type", "Light" },
            { "Armor", "12-15" },
            { "Fire Resistence", "26-30" },
            { "Cold Resistence", "26-30" },
            { "Poison Resistence", "26-30" },
            { "Energy Resistence", "26-30" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(12, 15);
            SetFireResistence(26, 30);
            SetColdResistence(26, 30);
            SetPoisonResistence(26, 30);
            SetEnergyResistence(26, 30);
        }
    }

    public class MercenaryChest : Equipament
    {
        public override string Namespace => "sk_chest_merc_02_b_cloak";
        public override string Name => "Mercenary Chest";
        public override string Alias => "MercenaryChest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override int GoldCost => 4000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Weight Type", "Medium" },
            { "Armor", "16-20" },
            { "Fire Resistence", "16-20" },
            { "Cold Resistence", "16-20" },
            { "Poison Resistence", "16-20" },
            { "Energy Resistence", "16-20" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(16, 20);
            SetFireResistence(16, 20);
            SetColdResistence(16, 20);
            SetPoisonResistence(16, 20);
            SetEnergyResistence(16, 20);
        }
    }

    public class NatureProtectorRobe : Equipament
    {
        public override string Namespace => "SK_ma_druid_set_02_a";
        public override string Name => "Nature Protector Robe";
        public override string Alias => "NatureProtectorRobe";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override int GoldCost => 4000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Weight Type", "Light" },
            { "Armor", "12-15" },
            { "Fire Resistence", "26-30" },
            { "Cold Resistence", "26-30" },
            { "Poison Resistence", "26-30" },
            { "Energy Resistence", "26-30" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(12, 15);
            SetFireResistence(26, 30);
            SetColdResistence(26, 30);
            SetPoisonResistence(26, 30);
            SetEnergyResistence(26, 30);
        }
    }

    public class NorthChest : Equipament
    {
        public override string Namespace => "SK_chest_north_02_e";
        public override string Name => "North Chest";
        public override string Alias => "NorthChest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override int GoldCost => 350;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Weight Type", "Light" },
            { "Armor", "10-14" },
            { "Fire Resistence", "5-6" },
            { "Cold Resistence", "5-6" },
            { "Poison Resistence", "5-6" },
            { "Energy Resistence", "5-6" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(10, 14);
            SetFireResistence(5, 6);
            SetColdResistence(5, 6);
            SetPoisonResistence(5, 6);
            SetEnergyResistence(5, 6);
        }
    }

    public class OminousChestplate : Equipament
    {
        public override string Namespace => "SK_ma_chest_heavy_04_a";
        public override string Name => "Ominous Chestplate";
        public override string Alias => "OminousChestplate";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override int GoldCost => 2000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T4;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "4" },
            { "Weight Type", "Heavy" },
            { "Armor", "21-25" },
            { "Fire Resistence", "9-11" },
            { "Cold Resistence", "9-11" },
            { "Poison Resistence", "9-11" },
            { "Energy Resistence", "9-11" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(21, 25);
            SetFireResistence(9, 11);
            SetColdResistence(9, 11);
            SetPoisonResistence(9, 11);
            SetEnergyResistence(9, 11);
        }
    }

    public class PactOfTheMage : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_mage_dress_02_b";
        public override string Name => "Pact of the Mage";
        public override string Alias => "PactOfTheMage";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override int GoldCost => 820;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Weight Type", "Light" },
            { "Armor", "7-8" },
            { "Fire Resistence", "15-20" },
            { "Cold Resistence", "15-20" },
            { "Poison Resistence", "15-20" },
            { "Energy Resistence", "15-20" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(7, 8);
            SetFireResistence(15, 20);
            SetColdResistence(15, 20);
            SetPoisonResistence(15, 20);
            SetEnergyResistence(15, 20);
        }
    }

    public class PromiseOfVengeanceArmor : Equipament
    {
        public override string Namespace => "sk_ma_chest_deathknight_02_b";
        public override string Name => "Promise of Vengeance Armor";
        public override string Alias => "PromiseOfVengeanceArmor";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override int GoldCost => 4000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Weight Type", "Heavy" },
            { "Armor", "26-30" },
            { "Fire Resistence", "12-15" },
            { "Cold Resistence", "12-15" },
            { "Poison Resistence", "12-15" },
            { "Energy Resistence", "12-15" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(26, 30);
            SetFireResistence(12, 15);
            SetColdResistence(12, 15);
            SetPoisonResistence(12, 15);
            SetEnergyResistence(12, 15);
        }
    }

    public class ProtectorArmor : Equipament
    {
        public override string Namespace => "SK_chest_soldier_02_a";
        public override string Name => "Protector Armor";
        public override string Alias => "ProtectorArmor";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override int GoldCost => 320;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Weight Type", "Heavy" },
            { "Armor", "10-14" },
            { "Fire Resistence", "5-6" },
            { "Cold Resistence", "5-6" },
            { "Poison Resistence", "5-6" },
            { "Energy Resistence", "5-6" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(10, 14);
            SetFireResistence(5, 6);
            SetColdResistence(5, 6);
            SetPoisonResistence(5, 6);
            SetEnergyResistence(5, 6);
        }
    }

    public class ProtectorOfPridesFall : Equipament
    {
        public override string Namespace => "SK_chest_merc_02_a";
        public override string Name => "Protector of Pride's Fall";
        public override string Alias => "ProtectorOfPridesFall";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Weight Type", "Medium" },
            { "Armor", "9-12" },
            { "Fire Resistence", "9-12" },
            { "Cold Resistence", "9-12" },
            { "Poison Resistence", "9-12" },
            { "Energy Resistence", "9-12" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(9, 12);
            SetFireResistence(9, 12);
            SetColdResistence(9, 12);
            SetPoisonResistence(9, 12);
            SetEnergyResistence(9, 12);
        }
    }

    public class RecruitChest : Equipament
    {
        public override string Namespace => "SK_ma_medieval_chest_villager_03_a";
        public override string Name => "Recruit Chest";
        public override string Alias => "RecruitChest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override int GoldCost => 100;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T0;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "0" },
            { "Weight Type", "Light" },
            { "Armor", "3-5" },
            { "Fire Resistence", "1-2" },
            { "Cold Resistence", "1-2" },
            { "Poison Resistence", "1-2" },
            { "Energy Resistence", "1-2" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(3, 5);
            SetFireResistence(1, 2);
            SetColdResistence(1, 2);
            SetPoisonResistence(1, 2);
            SetEnergyResistence(1, 2);
        }
    }

    public class ReiforcedHideVestArmor : Equipament
    {
        public override string Namespace => "SK_chest_north_01_c";
        public override string Name => "Reiforced Hide Vest Armor";
        public override string Alias => "ReiforcedHideVestArmor";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override int GoldCost => 100;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T1;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "1" },
            { "Weight Type", "Heavy" },
            { "Armor", "6-9" },
            { "Fire Resistence", "3-4" },
            { "Cold Resistence", "3-4" },
            { "Poison Resistence", "3-4" },
            { "Energy Resistence", "3-4" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(6, 9);
            SetFireResistence(3, 4);
            SetColdResistence(3, 4);
            SetPoisonResistence(3, 4);
            SetEnergyResistence(3, 4);
        }
    }

    public class ReinforcedDefenderArmor : Equipament
    {
        public override string Namespace => "SK_chest_north_02_c";
        public override string Name => "Reinforced Defender Armor";
        public override string Alias => "ReinforcedDefenderArmor";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override int GoldCost => 350;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Weight Type", "Medium" },
            { "Armor", "10-14" },
            { "Fire Resistence", "5-6" },
            { "Cold Resistence", "5-6" },
            { "Poison Resistence", "5-6" },
            { "Energy Resistence", "5-6" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(10, 14);
            SetFireResistence(5, 6);
            SetColdResistence(5, 6);
            SetPoisonResistence(5, 6);
            SetEnergyResistence(5, 6);
        }
    }

    public class ReinforcedScaleArmor : Equipament
    {
        public override string Namespace => "SK_ma_chest_heavy_03_a2";
        public override string Name => "Reinforced Scale Armor";
        public override string Alias => "ReinforcedScaleArmor";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Weight Type", "Medium" },
            { "Armor", "15-20" },
            { "Fire Resistence", "7-8" },
            { "Cold Resistence", "7-8" },
            { "Poison Resistence", "7-8" },
            { "Energy Resistence", "7-8" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(15, 20);
            SetFireResistence(7, 8);
            SetColdResistence(7, 8);
            SetPoisonResistence(7, 8);
            SetEnergyResistence(7, 8);
        }
    }

    public class ReinforcedVillagerProtectorChest : Equipament
    {
        public override string Namespace => "SK_ma_medieval_chest_villager_02_c";
        public override string Name => "Reinforced Villager Protector Chest";
        public override string Alias => "ReinforcedVillagerProtectorChest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override int GoldCost => 320;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Weight Type", "Heavy" },
            { "Armor", "10-14" },
            { "Fire Resistence", "5-6" },
            { "Cold Resistence", "5-6" },
            { "Poison Resistence", "5-6" },
            { "Energy Resistence", "5-6" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(10, 14);
            SetFireResistence(5, 6);
            SetColdResistence(5, 6);
            SetPoisonResistence(5, 6);
            SetEnergyResistence(5, 6);
        }
    }

    public class ReinforcedWarriorArmor : Equipament
    {
        public override string Namespace => "SK_chest_soldier_02_c";
        public override string Name => "Reinforced Warrior Armor";
        public override string Alias => "ReinforcedWarriorArmor";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override int GoldCost => 320;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Weight Type", "Medium" },
            { "Armor", "10-14" },
            { "Fire Resistence", "5-6" },
            { "Cold Resistence", "5-6" },
            { "Poison Resistence", "5-6" },
            { "Energy Resistence", "5-6" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(10, 14);
            SetFireResistence(5, 6);
            SetColdResistence(5, 6);
            SetPoisonResistence(5, 6);
            SetEnergyResistence(5, 6);
        }
    }

    public class RobesOfCataclysms : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_cultist_dress_c_seperate_005";
        public override string Name => "Robes of Cataclysms";
        public override string Alias => "RobesOfCataclysms";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override int GoldCost => 320;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Weight Type", "Light" },
            { "Armor", "5-6" },
            { "Fire Resistence", "10-14" },
            { "Cold Resistence", "10-14" },
            { "Poison Resistence", "10-14" },
            { "Energy Resistence", "10-14" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(5, 6);
            SetFireResistence(10, 14);
            SetColdResistence(10, 14);
            SetPoisonResistence(10, 14);
            SetEnergyResistence(10, 14);
        }
    }

    public class RobesOfEndingVisions : Equipament
    {
        public override string Namespace => "sk_ma_meta_tal_nrw_mage_dress_01_b_tome";
        public override string Name => "Robes of Ending Visions";
        public override string Alias => "RobesOfEndingVisions";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override int GoldCost => 4000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Weight Type", "Light" },
            { "Armor", "12-15" },
            { "Fire Resistence", "26-30" },
            { "Cold Resistence", "26-30" },
            { "Poison Resistence", "26-30" },
            { "Energy Resistence", "26-30" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(12, 15);
            SetFireResistence(26, 30);
            SetColdResistence(26, 30);
            SetPoisonResistence(26, 30);
            SetEnergyResistence(26, 30);
        }
    }

    public class RobesOfNature : Equipament
    {
        public override string Namespace => "SK_ma_druid_set_01_c";
        public override string Name => "Robes of Nature";
        public override string Alias => "RobesOfNature";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Weight Type", "Light" },
            { "Armor", "7-8" },
            { "Fire Resistence", "15-20" },
            { "Cold Resistence", "15-20" },
            { "Poison Resistence", "15-20" },
            { "Energy Resistence", "15-20" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(7, 8);
            SetFireResistence(15, 20);
            SetColdResistence(15, 20);
            SetPoisonResistence(15, 20);
            SetEnergyResistence(15, 20);
        }
    }

    public class RoyalRuggedLeatherChest : Equipament
    {
        public override string Namespace => "SK_chest_soldier_01_c_cloak";
        public override string Name => "Royal Rugged Leather Chest";
        public override string Alias => "RoyalRuggedLeatherChest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override int GoldCost => 320;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T1;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "1" },
            { "Weight Type", "Medium" },
            { "Armor", "6-9" },
            { "Fire Resistence", "3-4" },
            { "Cold Resistence", "3-4" },
            { "Poison Resistence", "3-4" },
            { "Energy Resistence", "3-4" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(6, 9);
            SetFireResistence(3, 4);
            SetColdResistence(3, 4);
            SetPoisonResistence(3, 4);
            SetEnergyResistence(3, 4);
        }
    }

    public class RuggedLeatherChest : Equipament
    {
        public override string Namespace => "SK_chest_soldier_01_d";
        public override string Name => "Rugged Leather Chest";
        public override string Alias => "RuggedLeatherChest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override int GoldCost => 320;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T1;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "1" },
            { "Weight Type", "Medium" },
            { "Armor", "6-9" },
            { "Fire Resistence", "3-4" },
            { "Cold Resistence", "3-4" },
            { "Poison Resistence", "3-4" },
            { "Energy Resistence", "3-4" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(6, 9);
            SetFireResistence(3, 4);
            SetColdResistence(3, 4);
            SetPoisonResistence(3, 4);
            SetEnergyResistence(3, 4);
        }
    }

    public class ScaleArmor : Equipament
    {
        public override string Namespace => "SK_ma_chest_heavy_03_a";
        public override string Name => "Scale Armor";
        public override string Alias => "ScaleArmor";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override int GoldCost => 320;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Weight Type", "Medium" },
            { "Armor", "15-20" },
            { "Fire Resistence", "7-8" },
            { "Cold Resistence", "7-8" },
            { "Poison Resistence", "7-8" },
            { "Energy Resistence", "7-8" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(15, 20);
            SetFireResistence(7, 8);
            SetColdResistence(7, 8);
            SetPoisonResistence(7, 8);
            SetEnergyResistence(7, 8);
        }
    }

    public class Sharper : Equipament
    {
        public override string Namespace => "SK_ma_medieval_chest_villager_01_b";
        public override string Name => "Sharper";
        public override string Alias => "Sharper";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override int GoldCost => 20;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T0;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "0" },
            { "Weight Type", "Light" },
            { "Armor", "3-4" },
            { "Fire Resistence", "3-4" },
            { "Cold Resistence", "3-4" },
            { "Poison Resistence", "3-4" },
            { "Energy Resistence", "3-4" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(3, 4);
            SetFireResistence(3, 4);
            SetColdResistence(3, 4);
            SetPoisonResistence(3, 4);
            SetEnergyResistence(3, 4);
        }
    }

    public class SlenderChest : Equipament
    {
        public override string Namespace => "SK_chest_merc_01_a";
        public override string Name => "Slender Chest";
        public override string Alias => "SlenderChest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override int GoldCost => 20;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T0;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "0" },
            { "Weight Type", "Light" },
            { "Armor", "3-4" },
            { "Fire Resistence", "3-4" },
            { "Cold Resistence", "3-4" },
            { "Poison Resistence", "3-4" },
            { "Energy Resistence", "3-4" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(3, 4);
            SetFireResistence(3, 4);
            SetColdResistence(3, 4);
            SetPoisonResistence(3, 4);
            SetEnergyResistence(3, 4);
        }
    }


    public class SoldierChest : Equipament
    {
        public override string Namespace => "SK_chest_knight_02_c";
        public override string Name => "Soldier Chest";
        public override string Alias => "SoldierChest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override int GoldCost => 100;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Weight Type", "Medium" },
            { "Armor", "10-14" },
            { "Fire Resistence", "5-6" },
            { "Cold Resistence", "5-6" },
            { "Poison Resistence", "5-6" },
            { "Energy Resistence", "5-6" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(10, 14);
            SetFireResistence(5, 6);
            SetColdResistence(5, 6);
            SetPoisonResistence(5, 6);
            SetEnergyResistence(5, 6);
        }
    }

    public class SoldierRuggedLeatherChest : Equipament
    {
        public override string Namespace => "SK_chest_soldier_01_e";
        public override string Name => "Soldier Rugged Leather Chest";
        public override string Alias => "SoldierRuggedLeatherChest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override int GoldCost => 20;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T1;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "1" },
            { "Weight Type", "Medium" },
            { "Armor", "6-9" },
            { "Fire Resistence", "3-4" },
            { "Cold Resistence", "3-4" },
            { "Poison Resistence", "3-4" },
            { "Energy Resistence", "3-4" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(6, 9);
            SetFireResistence(3, 4);
            SetColdResistence(3, 4);
            SetPoisonResistence(3, 4);
            SetEnergyResistence(3, 4);
        }
    }

    public class SpiritHideBreastplate : Equipament
    {
        public override string Namespace => "SK_ma_druid_set_02_d";
        public override string Name => "Spirit Hide Breastplate";
        public override string Alias => "SpiritHideBreastplate";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override int GoldCost => 20;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T1;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "1" },
            { "Weight Type", "Light" },
            { "Armor", "3-4" },
            { "Fire Resistence", "6-9" },
            { "Cold Resistence", "6-9" },
            { "Poison Resistence", "6-9" },
            { "Energy Resistence", "6-9" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(3, 4);
            SetFireResistence(6, 9);
            SetColdResistence(6, 9);
            SetPoisonResistence(6, 9);
            SetEnergyResistence(6, 9);
        }
    }

    public class StealthyArmor : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_elv_chest_01_c";
        public override string Name => "Stealthy Armor";
        public override string Alias => "StealthyArmor";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override int GoldCost => 4000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Weight Type", "Medium" },
            { "Armor", "16-20" },
            { "Fire Resistence", "16-20" },
            { "Cold Resistence", "16-20" },
            { "Poison Resistence", "16-20" },
            { "Energy Resistence", "16-20" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(16, 20);
            SetFireResistence(16, 20);
            SetColdResistence(16, 20);
            SetPoisonResistence(16, 20);
            SetEnergyResistence(16, 20);
        }
    }

    public class TributeOfBlessedFortunes : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_elv_chest_01_c";
        public override string Name => "Tribute of Blessed Fortunes";
        public override string Alias => "TributeOfBlessedFortunes";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Weight Type", "Light" },
            { "Armor", "7-8" },
            { "Fire Resistence", "15-20" },
            { "Cold Resistence", "15-20" },
            { "Poison Resistence", "15-20" },
            { "Energy Resistence", "15-20" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(7, 8);
            SetFireResistence(15, 20);
            SetColdResistence(15, 20);
            SetPoisonResistence(15, 20);
            SetEnergyResistence(15, 20);
        }
    }

    public class TroublemakerChest : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_elv_chest_01_c";
        public override string Name => "Troublemaker Chest";
        public override string Alias => "TroublemakerChest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override int GoldCost => 100;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T1;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "1" },
            { "Weight Type", "Light" },
            { "Armor", "5-6" },
            { "Fire Resistence", "5-6" },
            { "Cold Resistence", "5-6" },
            { "Poison Resistence", "5-6" },
            { "Energy Resistence", "5-6" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(5, 6);
            SetFireResistence(5, 6);
            SetColdResistence(5, 6);
            SetPoisonResistence(5, 6);
            SetEnergyResistence(5, 6);
        }
    }

    public class TunicOfLife : Equipament
    {
        public override string Namespace => "SK_ma_druid_set_02_b";
        public override string Name => "Tunic of Life";
        public override string Alias => "TunicOfLife";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override int GoldCost => 2000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T4;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "4" },
            { "Weight Type", "Light" },
            { "Armor", "9-11" },
            { "Fire Resistence", "21-25" },
            { "Cold Resistence", "21-25" },
            { "Poison Resistence", "21-25" },
            { "Energy Resistence", "21-25" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(9, 11);
            SetFireResistence(21, 25);
            SetColdResistence(21, 25);
            SetPoisonResistence(21, 25);
            SetEnergyResistence(21, 25);
        }
    }

    public class TunicOfSacredJustice : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_mage_dress_02_c_hood";
        public override string Name => "Tunic of Sacred Justice";
        public override string Alias => "TunicOfSacredJustice";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Weight Type", "Light" },
            { "Armor", "7-8" },
            { "Fire Resistence", "15-20" },
            { "Cold Resistence", "15-20" },
            { "Poison Resistence", "15-20" },
            { "Energy Resistence", "15-20" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(7, 8);
            SetFireResistence(15, 20);
            SetColdResistence(15, 20);
            SetPoisonResistence(15, 20);
            SetEnergyResistence(15, 20);
        }
    }

    public class TunicOfSouls : Equipament
    {
        public override string Namespace => "sk_ma_meta_tal_nrw_mage_dress_01_b";
        public override string Name => "Tunic of Souls";
        public override string Alias => "TunicOfSouls";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override int GoldCost => 2000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T4;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "4" },
            { "Weight Type", "Light" },
            { "Armor", "9-11" },
            { "Fire Resistence", "21-25" },
            { "Cold Resistence", "21-25" },
            { "Poison Resistence", "21-25" },
            { "Energy Resistence", "21-25" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(9, 11);
            SetFireResistence(21, 25);
            SetColdResistence(21, 25);
            SetPoisonResistence(21, 25);
            SetEnergyResistence(21, 25);
        }
    }

    public class UnholyChest : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_cultist_dress_knight_01_001";
        public override string Name => "Unholy Chest";
        public override string Alias => "UnholyChest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override int GoldCost => 4000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T5;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Weight Type", "Light" },
            { "Armor", "12-15" },
            { "Fire Resistence", "26-30" },
            { "Cold Resistence", "26-30" },
            { "Poison Resistence", "26-30" },
            { "Energy Resistence", "26-30" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(12, 15);
            SetFireResistence(26, 30);
            SetColdResistence(26, 30);
            SetPoisonResistence(26, 30);
            SetEnergyResistence(26, 30);
        }
    }

    public class VestOfDivineHope : Equipament
    {
        public override string Namespace => "SK_ma_meta_tal_nrw_mage_dress_02_b_bags";
        public override string Name => "Vest of Divine Hope";
        public override string Alias => "VestOfDivineHope";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Weight Type", "Light" },
            { "Armor", "7-8" },
            { "Fire Resistence", "15-20" },
            { "Cold Resistence", "15-20" },
            { "Poison Resistence", "15-20" },
            { "Energy Resistence", "15-20" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(7, 8);
            SetFireResistence(15, 20);
            SetColdResistence(15, 20);
            SetPoisonResistence(15, 20);
            SetEnergyResistence(15, 20);
        }
    }

    public class VillagerProtectorChest : Equipament
    {
        public override string Namespace => "SK_ma_medieval_chest_villager_03_b";
        public override string Name => "Villager Protector Chest";
        public override string Alias => "VillagerProtectorChest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override int GoldCost => 320;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Weight Type", "Heavy" },
            { "Armor", "10-14" },
            { "Fire Resistence", "5-6" },
            { "Cold Resistence", "5-6" },
            { "Poison Resistence", "5-6" },
            { "Energy Resistence", "5-6" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(10, 14);
            SetFireResistence(5, 6);
            SetColdResistence(5, 6);
            SetPoisonResistence(5, 6);
            SetEnergyResistence(5, 6);
        }
    }

    public class WarriorArmor : Equipament
    {
        public override string Namespace => "SK_chest_soldier_02_b";
        public override string Name => "Warrior Armor";
        public override string Alias => "WarriorArmor";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override int GoldCost => 320;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Weight Type", "Medium" },
            { "Armor", "10-14" },
            { "Fire Resistence", "5-6" },
            { "Cold Resistence", "5-6" },
            { "Poison Resistence", "5-6" },
            { "Energy Resistence", "5-6" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(10, 14);
            SetFireResistence(5, 6);
            SetColdResistence(5, 6);
            SetPoisonResistence(5, 6);
            SetEnergyResistence(5, 6);
        }
    }

    public class WhiteRuggedLeatherChest : Equipament
    {
        public override string Namespace => "SK_chest_soldier_01_b";
        public override string Name => "White Rugged Leather Chest";
        public override string Alias => "WhiteRuggedLeatherChest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override int GoldCost => 100;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T1;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "1" },
            { "Weight Type", "Medium" },
            { "Armor", "6-9" },
            { "Fire Resistence", "3-4" },
            { "Cold Resistence", "3-4" },
            { "Poison Resistence", "3-4" },
            { "Energy Resistence", "3-4" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(6, 9);
            SetFireResistence(3, 4);
            SetColdResistence(3, 4);
            SetPoisonResistence(3, 4);
            SetEnergyResistence(3, 4);
        }
    }

    public class WildChest : Equipament
    {
        public override string Namespace => "SK_ma_metal_tal_nrw_barbar_chest_01_a";
        public override string Name => "Wild Chest";
        public override string Alias => "WildChest";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Medium;
        public override int GoldCost => 20;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T0;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "0" },
            { "Weight Type", "Medium" },
            { "Armor", "3-5" },
            { "Fire Resistence", "1-2" },
            { "Cold Resistence", "1-2" },
            { "Poison Resistence", "1-2" },
            { "Energy Resistence", "1-2" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(3, 5);
            SetFireResistence(1, 2);
            SetColdResistence(1, 2);
            SetPoisonResistence(1, 2);
            SetEnergyResistence(1, 2);
        }
    }

    public class WrapsOfBrokenMight : Equipament
    {
        public override string Namespace => "sk_ma_meta_tal_nrw_mage_dress_02_c";
        public override string Name => "Wraps of Broken Might";
        public override string Alias => "WrapsOfBrokenMight";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Light;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 3;
        public override EquipmentTier Tier => EquipmentTier.T3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Weight Type", "Light" },
            { "Armor", "7-8" },
            { "Fire Resistence", "15-20" },
            { "Cold Resistence", "15-20" },
            { "Poison Resistence", "15-20" },
            { "Energy Resistence", "15-20" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(7, 8);
            SetFireResistence(15, 20);
            SetColdResistence(15, 20);
            SetPoisonResistence(15, 20);
            SetEnergyResistence(15, 20);
        }
    }

    public class WrathfulBatteplate : Equipament
    {
        public override string Namespace => "SK_ma_chest_heavy_05_d";
        public override string Name => "Wrathful Batteplate";
        public override string Alias => "WrathfulBatteplate";
        public override EquipmentType EquipmentType => EquipmentType.Chest;
        public override EquipmentWeight EquipmentWeight => EquipmentWeight.Heavy;
        public override int GoldCost => 2000;
        public override int MaxAttrs => 4;
        public override EquipmentTier Tier => EquipmentTier.T4;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "4" },
            { "Weight Type", "Heavy" },
            { "Armor", "21-25" },
            { "Fire Resistence", "9-11" },
            { "Cold Resistence", "9-11" },
            { "Poison Resistence", "9-11" },
            { "Energy Resistence", "9-11" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(21, 25);
            SetFireResistence(9, 11);
            SetColdResistence(9, 11);
            SetPoisonResistence(9, 11);
            SetEnergyResistence(9, 11);
        }
    }

}
