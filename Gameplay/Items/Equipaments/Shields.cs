namespace Server.Gameplay.Items
{
    public class AdornmentedShield : Offhand
    {
        public override string Namespace => "SM_wp_shield_heavy_04_b";
        public override string Name => "Adornmented Shield";
        public override string Alias => "AdornmentedShield";
        public override EquipmentType EquipmentType => EquipmentType.Offhand;
        public override EquipmentTier Tier => EquipmentTier.T2;
        public override float Weight => 2f;
        public override int GoldCost => 320;
        public override int MaxAttrs => 2;
        public override int BlockChance => 1;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Armor", "8-10" },
            { "Block Chance", "1-5%" },
            { "Attributes", "1-2" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(8, 10);
            SetBlockChance(1, 5);
        }
    }

    public class AncientProtector : Offhand
    {
        public override string Namespace => "AncientUndeadShield02";
        public override string Name => "Ancient Protector";
        public override string Alias => "AncientProtector";
        public override EquipmentType EquipmentType => EquipmentType.Offhand;
        public override EquipmentTier Tier => EquipmentTier.T5;
        public override float Weight => 10f;
        public override int GoldCost => 2000;
        public override int MaxAttrs => 4;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Armor", "14-17" },
            { "Block Chance", "15-25%" },
            { "Attributes", "4" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(14, 17);
            SetBlockChance(15, 25);
        }
    }

    public class AncientRoundShield : Offhand
    {
        public override string Namespace => "AncientUndeadShield01";
        public override string Name => "Ancient Round Shield";
        public override string Alias => "AncientRoundShield";
        public override EquipmentType EquipmentType => EquipmentType.Offhand;
        public override EquipmentTier Tier => EquipmentTier.T5;
        public override float Weight => 10f;
        public override int GoldCost => 2000;
        public override int MaxAttrs => 4;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Armor", "14-17" },
            { "Block Chance", "15-25%" },
            { "Attributes", "4" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(14, 17);
            SetBlockChance(15, 25);
        }
    }

    public class ArmoredShield : Offhand
    {
        public override string Namespace => "SM_wp_shield_heavy_02_a";
        public override string Name => "Armored Shield";
        public override string Alias => "ArmoredShield";
        public override EquipmentType EquipmentType => EquipmentType.Offhand;
        public override EquipmentTier Tier => EquipmentTier.T3;
        public override float Weight => 10f;
        public override int GoldCost => 800;
        public override int MaxAttrs => 3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Armor", "8-10" },
            { "Block Chance", "5-10%" },
            { "Attributes", "1-3" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(8, 10);
            SetBlockChance(5, 10);
        }
    }

    public class BarbedDragonShield : Offhand
    {
        public override string Namespace => "SM_wp_shield_heavy_01_a";
        public override string Name => "Barbed Dragon Shield";
        public override string Alias => "BarbedDragonShield";
        public override EquipmentType EquipmentType => EquipmentType.Offhand;
        public override EquipmentTier Tier => EquipmentTier.T4;
        public override float Weight => 10f;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "4" },
            { "Armor", "11-13" },
            { "Block Chance", "10-20%" },
            { "Attributes", "2-3" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(11, 13);
            SetBlockChance(10, 20);
        }
    }

    public class ChivalryShield : Offhand
    {
        public override string Namespace => "SM_wp_shield_heavy_01_a";
        public override string Name => "Chivalry Shield";
        public override string Alias => "ChivalryShield";
        public override EquipmentType EquipmentType => EquipmentType.Offhand;
        public override EquipmentTier Tier => EquipmentTier.T2;
        public override float Weight => 10f;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Armor", "5-7" },
            { "Block Chance", "5-10%" },
            { "Attributes", "1-2" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(5, 7);
            SetBlockChance(5, 10);
        }
    }

    public class CrystalShield : Offhand
    {
        public override string Namespace => "SM_wp_shield_round_01_d";
        public override string Name => "Crystal Shield";
        public override string Alias => "CrystalShield";
        public override EquipmentType EquipmentType => EquipmentType.Offhand;
        public override EquipmentTier Tier => EquipmentTier.T2;
        public override float Weight => 10f;
        public override int GoldCost => 300;
        public override int MaxAttrs => 2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Armor", "5-7" },
            { "Block Chance", "5-10%" },
            { "Attributes", "1-2" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(5, 7);
            SetBlockChance(5, 10);
        }
    }

    public class CurvedOrnamentedShield : Offhand
    {
        public override string Namespace => "SM_wp_shield_heavy_05_c";
        public override string Name => "Curved Ornamented Shield";
        public override string Alias => "CurvedOrnamentedShield";
        public override EquipmentType EquipmentType => EquipmentType.Offhand;
        public override EquipmentTier Tier => EquipmentTier.T3;
        public override float Weight => 10f;
        public override int GoldCost => 800;
        public override int MaxAttrs => 3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Armor", "8-10" },
            { "Block Chance", "5-10%" },
            { "Attributes", "1-3" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(8, 10);
            SetBlockChance(5, 10);
        }
    }

    public class CurvedShield : Offhand
    {
        public override string Namespace => "SM_wp_shield_heavy_05_a";
        public override string Name => "Curved Shield";
        public override string Alias => "CurvedShield";
        public override EquipmentType EquipmentType => EquipmentType.Offhand;
        public override EquipmentTier Tier => EquipmentTier.T3;
        public override float Weight => 10f;
        public override int GoldCost => 800;
        public override int MaxAttrs => 3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Armor", "8-10" },
            { "Block Chance", "5-10%" },
            { "Attributes", "1-3" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(8, 10);
            SetBlockChance(5, 10);
        }
    }

    public class CurvedStrangeShield : Offhand
    {
        public override string Namespace => "SM_wp_shield_heavy_05_b";
        public override string Name => "Curved Strange Shield";
        public override string Alias => "CurvedStrangeShield";
        public override EquipmentType EquipmentType => EquipmentType.Offhand;
        public override EquipmentTier Tier => EquipmentTier.T3;
        public override float Weight => 10f;
        public override int GoldCost => 800;
        public override int MaxAttrs => 3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Armor", "8-10" },
            { "Block Chance", "5-10%" },
            { "Attributes", "1-3" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(8, 10);
            SetBlockChance(5, 10);
        }
    }

    public class DragonShield : Offhand
    {
        public override string Namespace => "SM_wp_shield_heavy_01_b";
        public override string Name => "Dragon Shield";
        public override string Alias => "DragonShield";
        public override EquipmentType EquipmentType => EquipmentType.Offhand;
        public override EquipmentTier Tier => EquipmentTier.T3;
        public override float Weight => 10f;
        public override int GoldCost => 800;
        public override int MaxAttrs => 3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Armor", "8-10" },
            { "Block Chance", "5-10%" },
            { "Attributes", "1-3" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(8, 10);
            SetBlockChance(5, 10);
        }
    }

    public class FrameShield : Offhand
    {
        public override string Namespace => "ArzaonShield07";
        public override string Name => "Frame Shield";
        public override string Alias => "FrameShield";
        public override EquipmentType EquipmentType => EquipmentType.Offhand;
        public override EquipmentTier Tier => EquipmentTier.T2;
        public override float Weight => 5f;
        public override int GoldCost => 200;
        public override int MaxAttrs => 2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Armor", "5-7" },
            { "Block Chance", "1-5%" },
            { "Attributes", "1-2" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(5, 7);
            SetBlockChance(1, 5);
        }
    }

    public class GreatAdornmentedShield : Offhand
    {
        public override string Namespace => "SM_wp_shield_heavy_04_c";
        public override string Name => "Great Adornmented Shield";
        public override string Alias => "GreatAdornmentedShield";
        public override EquipmentType EquipmentType => EquipmentType.Offhand;
        public override EquipmentTier Tier => EquipmentTier.T3;
        public override float Weight => 10f;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Armor", "8-10" },
            { "Block Chance", "5-10%" },
            { "Attributes", "1-3" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(8, 10);
            SetBlockChance(5, 10);
        }
    }

    public class GreateOrnamentedShield : Offhand
    {
        public override string Namespace => "SM_wp_shield_heavy_02_c";
        public override string Name => "Greate Ornamented Shield";
        public override string Alias => "GreateOrnamentedShield";
        public override EquipmentType EquipmentType => EquipmentType.Offhand;
        public override EquipmentTier Tier => EquipmentTier.T3;
        public override float Weight => 10f;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Armor", "8-10" },
            { "Block Chance", "5-10%" },
            { "Attributes", "1-3" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(8, 10);
            SetBlockChance(5, 10);
        }
    }

    public class HeavyOrnamentedShield : Offhand
    {
        public override string Namespace => "SM_wp_shield_heavy_04_a";
        public override string Name => "Heavy Ornamented Shield";
        public override string Alias => "HeavyOrnamentedShield";
        public override EquipmentType EquipmentType => EquipmentType.Offhand;
        public override EquipmentTier Tier => EquipmentTier.T3;
        public override float Weight => 10f;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Armor", "8-10" },
            { "Block Chance", "5-10%" },
            { "Attributes", "1-3" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(8, 10);
            SetBlockChance(5, 10);
        }
    }

    public class HeavySpikedSquareShield : Offhand
    {
        public override string Namespace => "SM_wp_shield_heavy_03_c";
        public override string Name => "Heavy Spiked Square Shield";
        public override string Alias => "HeavySpikedSquareShield";
        public override EquipmentType EquipmentType => EquipmentType.Offhand;
        public override EquipmentTier Tier => EquipmentTier.T4;
        public override float Weight => 10f;
        public override int GoldCost => 2000;
        public override int MaxAttrs => 3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "4" },
            { "Armor", "11-13" },
            { "Block Chance", "10-20%" },
            { "Attributes", "2-3" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(11, 13);
            SetBlockChance(10, 20);
        }
    }

    public class HeraldicShield : Offhand
    {
        public override string Namespace => "ArzaonShield05";
        public override string Name => "Heraldic Shield";
        public override string Alias => "HeraldicShield";
        public override EquipmentType EquipmentType => EquipmentType.Offhand;
        public override EquipmentTier Tier => EquipmentTier.T2;
        public override float Weight => 5f;
        public override int GoldCost => 800;
        public override int MaxAttrs => 2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Armor", "5-7" },
            { "Block Chance", "5-10%" },
            { "Attributes", "1-2" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(5, 7);
            SetBlockChance(5, 10);
        }
    }

    public class KiteShield : Offhand
    {
        public override string Namespace => "SM_wp_shield_guard_01_a";
        public override string Name => "Kite Shield";
        public override string Alias => "KiteShield";
        public override EquipmentType EquipmentType => EquipmentType.Offhand;
        public override EquipmentTier Tier => EquipmentTier.T4;
        public override float Weight => 10f;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "4" },
            { "Armor", "11-13" },
            { "Block Chance", "10-15%" },
            { "Attributes", "2-3" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(11, 13);
            SetBlockChance(10, 15);
        }
    }

    public class LionShield : Offhand
    {
        public override string Namespace => "ArzaonShield03";
        public override string Name => "Lion Shield";
        public override string Alias => "LionShield";
        public override EquipmentType EquipmentType => EquipmentType.Offhand;
        public override EquipmentTier Tier => EquipmentTier.T5;
        public override float Weight => 10f;
        public override int GoldCost => 2000;
        public override int MaxAttrs => 4;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Armor", "14-17" },
            { "Block Chance", "15-25%" },
            { "Attributes", "4" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(14, 17);
            SetBlockChance(15, 25);
        }
    }

    public class MetalShield : Offhand
    {
        public override string Namespace => "ArzaonShield04";
        public override string Name => "Metal Shield";
        public override string Alias => "MetalShield";
        public override EquipmentType EquipmentType => EquipmentType.Offhand;
        public override EquipmentTier Tier => EquipmentTier.T5;
        public override float Weight => 10f;
        public override int GoldCost => 2000;
        public override int MaxAttrs => 4;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Armor", "14-17" },
            { "Block Chance", "15-25%" },
            { "Attributes", "4" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(14, 17);
            SetBlockChance(15, 25);
        }
    }

    public class OrnamentedShield : Offhand
    {
        public override string Namespace => "SM_wp_shield_heavy_02_d";
        public override string Name => "Ornamented Shield";
        public override string Alias => "OrnamentedShield";
        public override EquipmentType EquipmentType => EquipmentType.Offhand;
        public override EquipmentTier Tier => EquipmentTier.T3;
        public override float Weight => 10f;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Armor", "8-10" },
            { "Block Chance", "5-10%" },
            { "Attributes", "1-3" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(8, 10);
            SetBlockChance(5, 10);
        }
    }

    public class PlankShield : Offhand
    {
        public override string Namespace => "SM_wp_shield_square_01_a";
        public override string Name => "Plank Shield";
        public override string Alias => "PlankShield";
        public override EquipmentType EquipmentType => EquipmentType.Offhand;
        public override EquipmentTier Tier => EquipmentTier.T0;
        public override float Weight => 1f;
        public override int GoldCost => 60;
        public override int MaxAttrs => 1;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "0" },
            { "Armor", "1" },
            { "Block Chance", "2%" },
            { "Attributes", "1" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(1);
            SetBlockChance(2);
        }
    }

    public class Protector : Offhand
    {
        public override string Namespace => "SM_wp_shield_ellipse_01_a";
        public override string Name => "Protector";
        public override string Alias => "Protector";
        public override EquipmentType EquipmentType => EquipmentType.Offhand;
        public override EquipmentTier Tier => EquipmentTier.T4;
        public override float Weight => 5f;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "4" },
            { "Armor", "11-13" },
            { "Block Chance", "10-15%" },
            { "Attributes", "2-3" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(11, 13);
            SetBlockChance(10, 15);
        }
    }

    public class RoughSquareShield : Offhand
    {
        public override string Namespace => "SM_wp_shield_square_02_a";
        public override string Name => "Rough Square Shield";
        public override string Alias => "RoughSquareShield";
        public override EquipmentType EquipmentType => EquipmentType.Offhand;
        public override EquipmentTier Tier => EquipmentTier.T1;
        public override float Weight => 5f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "1" },
            { "Armor", "2-4" },
            { "Block Chance", "2-4%" },
            { "Attributes", "1-2" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(2, 4);
            SetBlockChance(2, 4);
        }
    }

    public class RoundLightShield : Offhand
    {
        public override string Namespace => "SM_wp_shield_round_01_a";
        public override string Name => "Round Light Shield";
        public override string Alias => "RoundLightShield";
        public override EquipmentType EquipmentType => EquipmentType.Offhand;
        public override EquipmentTier Tier => EquipmentTier.T1;
        public override float Weight => 5f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "1" },
            { "Armor", "2-4" },
            { "Block Chance", "1-5%" },
            { "Attributes", "1-2" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(2, 4);
            SetBlockChance(1, 5);
        }
    }

    public class RoundMetalShield : Offhand
    {
        public override string Namespace => "ArzaonShield06";
        public override string Name => "Round Metal Shield";
        public override string Alias => "RoundMetalShield";
        public override EquipmentType EquipmentType => EquipmentType.Offhand;
        public override EquipmentTier Tier => EquipmentTier.T1;
        public override float Weight => 5f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "1" },
            { "Armor", "2-4" },
            { "Block Chance", "1-5%" },
            { "Attributes", "1-2" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(2, 4);
            SetBlockChance(1, 5);
        }
    }

    public class RoundSpikedBuckler : Offhand
    {
        public override string Namespace => "SM_wp_shield_round_01_c";
        public override string Name => "Round Spiked Buckler";
        public override string Alias => "RoundSpikedBuckler";
        public override EquipmentType EquipmentType => EquipmentType.Offhand;
        public override EquipmentTier Tier => EquipmentTier.T2;
        public override float Weight => 5f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Armor", "5-7" },
            { "Block Chance", "5-10%" },
            { "Attributes", "1-2" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(5, 7);
            SetBlockChance(5, 10);
        }
    }

    public class RoundSpikedShield : Offhand
    {
        public override string Namespace => "SM_wp_shield_round_01_b";
        public override string Name => "Round Spiked Shield";
        public override string Alias => "RoundSpikedShield";
        public override EquipmentType EquipmentType => EquipmentType.Offhand;
        public override EquipmentTier Tier => EquipmentTier.T2;
        public override float Weight => 5f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Armor", "5-7" },
            { "Block Chance", "5-10%" },
            { "Attributes", "1-2" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(5, 7);
            SetBlockChance(5, 10);
        }
    }

    public class SimpleProtector : Offhand
    {
        public override string Namespace => "ArzaonShield01";
        public override string Name => "Simple Protector";
        public override string Alias => "SimpleProtector";
        public override EquipmentType EquipmentType => EquipmentType.Offhand;
        public override EquipmentTier Tier => EquipmentTier.T1;
        public override float Weight => 5f;
        public override int GoldCost => 20;
        public override int MaxAttrs => 2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "1" },
            { "Armor", "2-4" },
            { "Block Chance", "1-5%" },
            { "Attributes", "1-2" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(2, 4);
            SetBlockChance(1, 5);
        }
    }

    public class SimpleShield : Offhand
    {
        public override string Namespace => "SM_wp_shield_round_02_b";
        public override string Name => "Simple Shield";
        public override string Alias => "SimpleShield";
        public override EquipmentType EquipmentType => EquipmentType.Offhand;
        public override EquipmentTier Tier => EquipmentTier.T1;
        public override float Weight => 5f;
        public override int GoldCost => 20;
        public override int MaxAttrs => 2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "1" },
            { "Armor", "2-4" },
            { "Block Chance", "1-5%" },
            { "Attributes", "1-2" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(2, 4);
            SetBlockChance(1, 5);
        }
    }

    public class SpikedArmoredShield : Offhand
    {
        public override string Namespace => "SM_wp_shield_heavy_02_b";
        public override string Name => "Spiked Armored Shield";
        public override string Alias => "SpikedArmoredShield";
        public override EquipmentType EquipmentType => EquipmentType.Offhand;
        public override EquipmentTier Tier => EquipmentTier.T5;
        public override float Weight => 20f;
        public override int GoldCost => 2000;
        public override int MaxAttrs => 4;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "5" },
            { "Armor", "14-17" },
            { "Block Chance", "15-25%" },
            { "Attributes", "4" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(14, 17);
            SetBlockChance(15, 25);
        }
    }

    public class SpikedSquareShield : Offhand
    {
        public override string Namespace => "SM_wp_shield_heavy_03_b";
        public override string Name => "Spiked Square Shield";
        public override string Alias => "SpikedSquareShield";
        public override EquipmentType EquipmentType => EquipmentType.Offhand;
        public override EquipmentTier Tier => EquipmentTier.T4;
        public override float Weight => 20f;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 4;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "4" },
            { "Armor", "11-13" },
            { "Block Chance", "10-15%" },
            { "Attributes", "2-3" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(11, 13);
            SetBlockChance(10, 15);
        }
    }

    public class SquareShield : Offhand
    {
        public override string Namespace => "SM_wp_shield_heavy_03_a";
        public override string Name => "Square Shield";
        public override string Alias => "SquareShield";
        public override EquipmentType EquipmentType => EquipmentType.Offhand;
        public override EquipmentTier Tier => EquipmentTier.T3;
        public override float Weight => 20f;
        public override int GoldCost => 1000;
        public override int MaxAttrs => 3;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "3" },
            { "Armor", "8-10" },
            { "Block Chance", "5-10%" },
            { "Attributes", "1-3" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(8, 10);
            SetBlockChance(5, 10);
        }
    }

    public class TableShield : Offhand
    {
        public override string Namespace => "SM_wp_shield_round";
        public override string Name => "Table Shield";
        public override string Alias => "TableShield";
        public override EquipmentType EquipmentType => EquipmentType.Offhand;
        public override EquipmentTier Tier => EquipmentTier.T1;
        public override float Weight => 5f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "1" },
            { "Armor", "2-4" },
            { "Block Chance", "1-5%" },
            { "Attributes", "1-2" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(2, 4);
            SetBlockChance(1, 5);
        }
    }

    public class TowerShield : Offhand
    {
        public override string Namespace => "SM_wp_shield_round";
        public override string Name => "Tower Shield";
        public override string Alias => "TowerShield";
        public override EquipmentType EquipmentType => EquipmentType.Offhand;
        public override EquipmentTier Tier => EquipmentTier.T2;
        public override float Weight => 10f;
        public override int GoldCost => 100;
        public override int MaxAttrs => 2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "2" },
            { "Armor", "5-7" },
            { "Block Chance", "5-10%" },
            { "Attributes", "1-2" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(5, 7);
            SetBlockChance(5, 10);
        }
    }

    public class VikingShield : Offhand
    {
        public override string Namespace => "SM_wp_shield_round_02_a";
        public override string Name => "Viking Shield";
        public override string Alias => "VikingShield";
        public override EquipmentType EquipmentType => EquipmentType.Offhand;
        public override EquipmentTier Tier => EquipmentTier.T1;
        public override float Weight => 5f;
        public override int GoldCost => 20;
        public override int MaxAttrs => 2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "1" },
            { "Armor", "1" },
            { "Block Chance", "5-10%" },
            { "Attributes", "1-2" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(1);
            SetBlockChance(5, 10);
        }
    }

    public class WoodenRoundShield : Offhand
    {
        public override string Namespace => "ArzaonShield08";
        public override string Name => "Wooden Round Shield";
        public override string Alias => "WoodenRoundShield";
        public override EquipmentType EquipmentType => EquipmentType.Offhand;
        public override EquipmentTier Tier => EquipmentTier.T1;
        public override float Weight => 5f;
        public override int GoldCost => 20;
        public override int MaxAttrs => 2;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "1" },
            { "Armor", "1" },
            { "Block Chance", "5-10%" },
            { "Attributes", "1-2" }
        };

        public override void GenerateAttrs()
        {
            SetArmor(1);
            SetBlockChance(5, 10);
        }
    }
}
