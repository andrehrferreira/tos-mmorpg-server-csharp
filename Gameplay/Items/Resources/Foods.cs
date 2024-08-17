namespace Server.Gameplay.Items
{
    public class Apple : Consumable
    {
        public override string Namespace => "Apple";
        public override string Name => "Apple";
        public override float Weight => 0.1f;
        public override int GoldCost => 1;

        public override async Task Use(Entity entity)
        {
            entity.Heal(entity, 1);
        }
    }

    public class ApplePie : Consumable
    {
        public override string Namespace => "ApplePie";
        public override string Name => "Apple Pie";
        public override float Weight => 1;
        public override int GoldCost => 20;

        public override async Task Use(Entity entity)
        {
            entity.Heal(entity, 10);
        }
    }

    public class Bacon : Consumable
    {
        public override string Namespace => "Bacon";
        public override string Name => "Bacon";
        public override float Weight => 0.1f;
        public override int GoldCost => 10;

        public override async Task Use(Entity entity)
        {
            entity.Heal(entity, 1);
        }
    }

    public class BakedFish : Consumable
    {
        public override string Namespace => "BakedFish";
        public override string Name => "Baked Fish";
        public override float Weight => 0.1f;
        public override int GoldCost => 50;

        public override async Task Use(Entity entity)
        {
            entity.Heal(entity, 20);
        }
    }

    public class Beer : Consumable
    {
        public override string Namespace => "Beer";
        public override string Name => "Beer";
        public override float Weight => 0.1f;
        public override int GoldCost => 5;

        public override async Task Use(Entity entity)
        {
            entity.Heal(entity, 5);
        }
    }

    public class Bread : Consumable
    {
        public override string Namespace => "Bread";
        public override string Name => "Bread";
        public override float Weight => 0.1f;
        public override int GoldCost => 1;

        public override async Task Use(Entity entity)
        {
            entity.Heal(entity, 1);
        }
    }

    public class Butter : Resource
    {
        public override string Namespace => "Butter";
        public override string Name => "Butter";
        public override float Weight => 0.1f;
        public override int GoldCost => 20;
    }

    public class Cabbage : Resource
    {
        public override string Namespace => "Cabbage";
        public override string Name => "Cabbage";
        public override float Weight => 0.1f;
        public override int GoldCost => 1;
    }

    public class Cake : Consumable
    {
        public override string Namespace => "Cake";
        public override string Name => "Cake";
        public override float Weight => 0.1f;
        public override int GoldCost => 100;

        public override async Task Use(Entity entity)
        {
            entity.Heal(entity, 100);
        }
    }

    public class Carrot : Consumable
    {
        public override string Namespace => "Carrot";
        public override string Name => "Carrot";
        public override float Weight => 0.1f;
        public override int GoldCost => 5;

        public override async Task Use(Entity entity)
        {
            entity.Heal(entity, 1);
        }
    }

    public class CheeseWedge : Consumable
    {
        public override string Namespace => "CheeseWedge";
        public override string Name => "Cheese Wedge";
        public override float Weight => 0.1f;
        public override int GoldCost => 20;

        public override async Task Use(Entity entity)
        {
            entity.Heal(entity, 10);
        }
    }

    public class Chocolate : Consumable
    {
        public override string Namespace => "Chocolate";
        public override string Name => "Chocolate";
        public override float Weight => 0.1f;
        public override int GoldCost => 50;

        public override async Task Use(Entity entity)
        {
            entity.Heal(entity, 50);
        }
    }

    public class Cocoa : Consumable
    {
        public override string Namespace => "Cocoa";
        public override string Name => "Cocoa";
        public override float Weight => 0.1f;
        public override int GoldCost => 20;

        public override async Task Use(Entity entity)
        {
            entity.Heal(entity, 100);
        }
    }

    public class Coconut : Consumable
    {
        public override string Namespace => "Coconut";
        public override string Name => "Coconut";
        public override float Weight => 0.1f;
        public override int GoldCost => 10;

        public override async Task Use(Entity entity)
        {
            entity.Heal(entity, 100);
        }
    }

    public class Cookies : Consumable
    {
        public override string Namespace => "Cookies";
        public override string Name => "Cookies";
        public override float Weight => 0.1f;
        public override int GoldCost => 10;

        public override async Task Use(Entity entity)
        {
            entity.Heal(entity, 100);
            entity.Mana = Math.Min(entity.Mana + 100, entity.MaxMana);
            entity.HealBroadcast(entity, 100, HealType.Mana);
            entity.Stamina = Math.Min(entity.Stamina + 100, entity.MaxStamina);
            entity.HealBroadcast(entity, 100, HealType.Stamina);
        }
    }

    public class Corn : Consumable
    {
        public override string Namespace => "Corn";
        public override string Name => "Corn";
        public override float Weight => 0.1f;
        public override int GoldCost => 5;

        public override async Task Use(Entity entity)
        {
            entity.Heal(entity, 100);
        }
    }

    public class Cucumber : Consumable
    {
        public override string Namespace => "Cucumber";
        public override string Name => "Cucumber";
        public override float Weight => 0.1f;
        public override int GoldCost => 2;

        public override async Task Use(Entity entity)
        {
            entity.Heal(entity, 100);
        }
    }

    public class Egg : Consumable
    {
        public override string Namespace => "Egg";
        public override string Name => "Egg";
        public override float Weight => 0.1f;
        public override int GoldCost => 1;

        public override async Task Use(Entity entity)
        {
            entity.Heal(entity, 100);
        }
    }

    public class FishRaw : Resource
    {
        public override string Namespace => "FishRaw";
        public override string Name => "Fish Raw";
        public override float Weight => 0.1f;
        public override int GoldCost => 2;
    }

    public class FishSteak : Consumable
    {
        public override string Namespace => "FishSteak";
        public override string Name => "Fish Steak";
        public override float Weight => 0.1f;
        public override int GoldCost => 10;

        public override async Task Use(Entity entity)
        {
            entity.Heal(entity, 50);
        }
    }

    public class Grapes : Consumable
    {
        public override string Namespace => "Grapes";
        public override string Name => "Grapes";
        public override float Weight => 0.1f;
        public override int GoldCost => 10;

        public override async Task Use(Entity entity)
        {
            entity.Mana = Math.Min(entity.Mana + 50, entity.MaxMana);
            entity.HealBroadcast(entity, 50, HealType.Mana);
        }
    }

    public class Ham : Consumable
    {
        public override string Namespace => "Ham";
        public override string Name => "Ham";
        public override float Weight => 0.1f;
        public override int GoldCost => 25;

        public override async Task Use(Entity entity)
        {
            entity.Heal(entity, 25);
        }
    }

    public class Honey : Consumable
    {
        public override string Namespace => "Honey";
        public override string Name => "Honey";
        public override float Weight => 0.1f;
        public override int GoldCost => 100;

        public override async Task Use(Entity entity)
        {
            entity.Mana = Math.Min(entity.Mana + 100, entity.MaxMana);
            entity.HealBroadcast(entity, 100, HealType.Mana);
        }
    }

    public class Leek : Resource
    {
        public override string Namespace => "Leek";
        public override string Name => "Leek";
        public override float Weight => 0.1f;
        public override int GoldCost => 1;
    }

    public class Lemon : Resource
    {
        public override string Namespace => "Lemon";
        public override string Name => "Lemon";
        public override float Weight => 0.1f;
        public override int GoldCost => 5;
    }

    public class Lettuce : Resource
    {
        public override string Namespace => "Lettuce";
        public override string Name => "Lettuce";
        public override float Weight => 0.1f;
        public override int GoldCost => 1;
    }

    public class Mead : Consumable
    {
        public override string Namespace => "Mead";
        public override string Name => "Mead";
        public override float Weight => 0.1f;
        public override int GoldCost => 100;

        public override async Task Use(Entity entity)
        {
            entity.Mana = Math.Min(entity.Mana + 300, entity.MaxMana);
            entity.HealBroadcast(entity, 300, HealType.Mana);
        }
    }

    public class Meat : Resource
    {
        public override string Namespace => "Meat";
        public override string Name => "Meat";
        public override float Weight => 0.1f;
        public override int GoldCost => 1;
    }

    public class Meatstick : Consumable
    {
        public override string Namespace => "Meatstick";
        public override string Name => "Meatstick";
        public override float Weight => 0.1f;
        public override int GoldCost => 5;

        public override async Task Use(Entity entity)
        {
            entity.Heal(entity, 100);
        }
    }

    public class Melon : Resource
    {
        public override string Namespace => "Melon";
        public override string Name => "Melon";
        public override float Weight => 0.1f;
        public override int GoldCost => 10;
    }

    public class Milk : Resource
    {
        public override string Namespace => "Milk";
        public override string Name => "Milk";
        public override float Weight => 0.1f;
        public override int GoldCost => 1;
    }

    public class Mushrooms : Consumable
    {
        public override string Namespace => "Mushrooms";
        public override string Name => "Mushrooms";
        public override float Weight => 0.1f;
        public override int GoldCost => 2;

        public override async Task Use(Entity entity)
        {
            entity.Stamina = Math.Min(entity.Stamina + 50, entity.MaxStamina);
            entity.HealBroadcast(entity, 50, HealType.Stamina);
        }
    }

    public class OmeleteWithBacon : Consumable
    {
        public override string Namespace => "OmeleteWithBacon";
        public override string Name => "Omelete With Bacon";
        public override float Weight => 0.1f;
        public override int GoldCost => 10;

        public override async Task Use(Entity entity)
        {
            entity.Heal(entity, 100);
            entity.Stamina = Math.Min(entity.Stamina + 50, entity.MaxStamina);
            entity.HealBroadcast(entity, 50, HealType.Stamina);
        }
    }

    public class Onion : Resource
    {
        public override string Namespace => "Onion";
        public override string Name => "Onion";
        public override float Weight => 0.1f;
        public override int GoldCost => 3;
    }

    public class OnionSoup : Consumable
    {
        public override string Namespace => "OnionSoup";
        public override string Name => "Onion Soup";
        public override float Weight => 0.1f;
        public override int GoldCost => 80;

        public override async Task Use(Entity entity)
        {
            if (!entity.InHealAction)
            {
                await ExecActionInterval(25, 3000, (Consumable item) =>
                {
                    if (entity.Mana < entity.MaxMana)
                    {
                        entity.Mana = Math.Min(entity.Mana + 5, entity.MaxMana);
                        entity.HealBroadcast(entity, 5, HealType.Mana);
                    }
                });
            }
        }
    }

    public class Pear : Resource
    {
        public override string Namespace => "Pear";
        public override string Name => "Pear";
        public override float Weight => 0.1f;
        public override int GoldCost => 3;
    }

    public class Pepper : Resource
    {
        public override string Namespace => "Pepper";
        public override string Name => "Pepper";
        public override float Weight => 0.1f;
        public override int GoldCost => 3;
    }

    public class Potato : Resource
    {
        public override string Namespace => "Potato";
        public override string Name => "Potato";
        public override float Weight => 0.1f;
        public override int GoldCost => 5;
    }

    public class PotatoSoup : Consumable
    {
        public override string Namespace => "PotatoSoup";
        public override string Name => "Potato Soup";
        public override float Weight => 0.1f;
        public override int GoldCost => 150;

        public override async Task Use(Entity entity)
        {
            if (!entity.InHealAction)
            {
                await ExecActionInterval(30, 3000, (Consumable item) =>
                {
                    if (entity.Stamina < entity.MaxStamina)
                    {
                        entity.Stamina = Math.Min(entity.Stamina + 5, entity.MaxStamina);
                        entity.HealBroadcast(entity, 5, HealType.Stamina);
                    }
                });
            }
        }
    }

    public class Pumpkin : Resource
    {
        public override string Namespace => "Pumpkin";
        public override string Name => "Pumpkin";
        public override float Weight => 0.1f;
        public override int GoldCost => 20;
    }

    public class RawChickenLeg : Resource
    {
        public override string Namespace => "RawChickenLeg";
        public override string Name => "Raw Chicken Leg";
        public override float Weight => 0.1f;
        public override int GoldCost => 1;
    }

    public class Ribs : Consumable
    {
        public override string Namespace => "Ribs";
        public override string Name => "Ribs";
        public override float Weight => 0.1f;
        public override int GoldCost => 150;

        public override async Task Use(Entity entity)
        {
            entity.Heal(entity, 300);
        }
    }

    public class RoundCheese : Consumable
    {
        public override string Namespace => "RoundCheese";
        public override string Name => "Round Cheese";
        public override float Weight => 0.1f;
        public override int GoldCost => 80;

        public override async Task Use(Entity entity)
        {
            entity.Heal(entity, 100);
        }
    }

    public class Sandwich : Consumable
    {
        public override string Namespace => "Sandwich";
        public override string Name => "Sandwich";
        public override float Weight => 0.1f;
        public override int GoldCost => 10;

        public override async Task Use(Entity entity)
        {
            entity.Heal(entity, 300);
        }
    }

    public class Sausage : Consumable
    {
        public override string Namespace => "Sausage";
        public override string Name => "Sausage";
        public override float Weight => 0.1f;
        public override int GoldCost => 5;

        public override async Task Use(Entity entity)
        {
            entity.Heal(entity, 30);
        }
    }

    public class Strawberry : Consumable
    {
        public override string Namespace => "Strawberry";
        public override string Name => "Strawberry";
        public override float Weight => 0.1f;
        public override int GoldCost => 1;

        public override async Task Use(Entity entity)
        {
            entity.Heal(entity, 1000);
        }
    }

    public class Sugar : Resource
    {
        public override string Namespace => "Sugar";
        public override string Name => "Sugar";
        public override float Weight => 0.1f;
        public override int GoldCost => 10;
    }

    public class Sushi : Consumable
    {
        public override string Namespace => "Sushi";
        public override string Name => "Sushi";
        public override float Weight => 0.1f;
        public override int GoldCost => 100;
    }

    public class Tomato : Consumable
    {
        public override string Namespace => "Tomato";
        public override string Name => "Tomato";
        public override float Weight => 0.1f;
        public override int GoldCost => 5;

        public override async Task Use(Entity entity)
        {
            entity.Heal(entity, 1);
        }
    }

    public class Water : Resource
    {
        public override string Namespace => "Water";
        public override string Name => "Water";
        public override float Weight => 0.1f;
        public override int GoldCost => 1;
    }

    public class Wheat : Resource
    {
        public override string Namespace => "Wheat";
        public override string Name => "Wheat";
        public override float Weight => 0.1f;
        public override int GoldCost => 1;
    }

    public class Wine : Consumable
    {
        public override string Namespace => "Wine";
        public override string Name => "Wine";
        public override float Weight => 0.1f;
        public override int GoldCost => 300;

        public override async Task Use(Entity entity)
        {
            entity.Mana = Math.Min(entity.Mana + 1000, entity.MaxMana);
            entity.HealBroadcast(entity, 1000, HealType.Mana);
        }
    }
}
