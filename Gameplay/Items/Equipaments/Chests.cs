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


}
