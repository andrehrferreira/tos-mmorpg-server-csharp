namespace Server.Gameplay.Items
{
    public class GoldCoin : Stackable
    {
        public override string Namespace => "GoldCoin";
        public override string Name => "Gold Coin";
        public override double Weight => 0.01;
    }

    public class SilverCoin : Stackable
    {
        public override string Namespace => "SilverCoin";
        public override string Name => "Silver Coin";
        public override int GoldCost => 1000;
        public override double Weight => 0.01;
    }

    public class AncientMagicStoneRunes : Item
    {
        public override string Namespace => "AncientMagicStoneRunes";
        public override string Name => "Ancient Magic Stone Runes";
        public override int GoldCost => 5000;
        public override double Weight => 0.1;
    }

    public class AncientRune : Item
    {
        public override string Namespace => "AncientRune";
        public override string Name => "Ancient Rune";
        public override int GoldCost => 1000;
        public override double Weight => 0.1;
    }

    public class Bandage : Consumable
    {
        public override string Namespace => "Bandage";
        public override string Name => "Bandage";
        public override int GoldCost => 1;
        public override double Weight => 0.01;

        public override async Task Use(Entity entity)
        {
            if (!entity.InHealAction)
            {
                entity.InHealAction = true;

                ExecActionInterval(6, 2000, (Consumable item) =>
                {
                    int value = entity.RollDice(Dices.D1D4);
                    entity.Heal(entity, value);
                }).ContinueWith(_ =>
                {
                    entity.InHealAction = false;
                });
            }
        }
    }

    public class LockpickSet : Resource
    {
        public override string Namespace => "LockpickSet";
        public override string Name => "Lockpick Set";
        public override int GoldCost => 10;
        public override double Weight => 0.1;
    }

    public class Sand : Stackable
    {
        public override string Namespace => "Sand";
        public override string Name => "Sand";
        public override int GoldCost => 1;
        public override double Weight => 0.01;
    }

    //Others
    public class BatWing : Resource
    {
        public override string Namespace => "BatWing";
        public override string Name => "Bat Wing";
        public override int GoldCost => 5;
    }

    public class Bone : Resource
    {
        public override string Namespace => "Bone";
        public override string Name => "Bone";
        public override int GoldCost => 5;
    }

    public class DeerSkull : Resource
    {
        public override string Namespace => "DeerSkull";
        public override string Name => "Deer Skull";
        public override int GoldCost => 10;
        public override ItemRarity Rarity => ItemRarity.Rare;
    }

    public class Feather : Resource
    {
        public override string Namespace => "Feather";
        public override string Name => "Feather";
        public override int GoldCost => 1;
    }

    public class PhoenixFeather : Resource
    {
        public override string Namespace => "PhoenixFeather";
        public override string Name => "Phoenix Feather";
        public override int GoldCost => 1000;
        public override ItemRarity Rarity => ItemRarity.Rare;
    }

    public class Fin : Resource
    {
        public override string Namespace => "Fin";
        public override string Name => "Fin";
        public override int GoldCost => 5;
    }

    public class Horn : Resource
    {
        public override string Namespace => "Horn";
        public override string Name => "Horn";
        public override int GoldCost => 100;
        public override ItemRarity Rarity => ItemRarity.Uncommon;
    }

    public class Line : Resource
    {
        public override string Namespace => "Line";
        public override string Name => "Line";
        public override int GoldCost => 1;
    }

    public class MinotaurEye : Resource
    {
        public override string Namespace => "MinotaurEye";
        public override string Name => "Minotaur Eye";
        public override int GoldCost => 100;
        public override ItemRarity Rarity => ItemRarity.Uncommon;
    }

    public class MoonStone : Resource
    {
        public override string Namespace => "MoonStone";
        public override string Name => "Moon Stone";
        public override int GoldCost => 1000;
        public override ItemRarity Rarity => ItemRarity.Magic;
    }

    public class Parchment : Resource
    {
        public override string Namespace => "Parchment";
        public override string Name => "Parchment";
        public override int GoldCost => 10;
    }

    public class Scarab : Resource
    {
        public override string Namespace => "Scarab";
        public override string Name => "Scarab";
        public override int GoldCost => 2000;
        public override ItemRarity Rarity => ItemRarity.Rare;
    }

    public class Shell : Resource
    {
        public override string Namespace => "Shell";
        public override string Name => "Shell";
        public override int GoldCost => 100;
        public override ItemRarity Rarity => ItemRarity.Uncommon;
    }

    public class Skull : Resource
    {
        public override string Namespace => "Skull";
        public override string Name => "Skull";
        public override int GoldCost => 100;
        public override ItemRarity Rarity => ItemRarity.Uncommon;
    }

    public class SlugSnail : Resource
    {
        public override string Namespace => "SlugSnail";
        public override string Name => "Slug Snail";
        public override int GoldCost => 5;
    }

    public class SoulStone : Resource
    {
        public override string Namespace => "SoulStone";
        public override string Name => "Soul Stone";
        public override int GoldCost => 5000;
        public override ItemRarity Rarity => ItemRarity.Legendary;
    }

    public class SpiderFang : Resource
    {
        public override string Namespace => "SpiderFang";
        public override string Name => "Spider Fang";
        public override int GoldCost => 5;
    }

    public class Sting : Resource
    {
        public override string Namespace => "Sting";
        public override string Name => "Sting";
        public override int GoldCost => 5;
    }

    public class Tusk : Resource
    {
        public override string Namespace => "Tusk";
        public override string Name => "Tusk";
        public override int GoldCost => 100;
        public override ItemRarity Rarity => ItemRarity.Uncommon;
    }

    public class VitalityStone : Resource
    {
        public override string Namespace => "VitalityStone";
        public override string Name => "Vitality Stone";
        public override int GoldCost => 3000;
        public override ItemRarity Rarity => ItemRarity.Magic;
    }

    public class Wool : Resource
    {
        public override string Namespace => "Wool";
        public override string Name => "Wool";
        public override int GoldCost => 1;
    }

    public class ViperTooth : Resource
    {
        public override string Namespace => "ViperTooth";
        public override string Name => "Viper Tooth";
        public override int GoldCost => 5;
    }

    public class DemonHorn : Resource
    {
        public override string Namespace => "DemonHorn";
        public override string Name => "Demon Horn";
        public override int GoldCost => 5;
        public override ItemRarity Rarity => ItemRarity.Rare;
    }
}
