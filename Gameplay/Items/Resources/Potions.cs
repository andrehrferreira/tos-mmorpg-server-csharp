namespace Server.Gameplay.Items
{
    public class EmptyBottle : Resource
    {
        public override string Namespace => "EmptyBottle";
        public override string Name => "Empty Bottle";
        public override int GoldCost => 5;
    }

    public class BlackHerbMix : Resource
    {
        public override string Namespace => "BlackHerbMix";
        public override string Name => "Black Herbal Extract";
        public override int GoldCost => 350;
    }

    public class BlueHerbMix : Resource
    {
        public override string Namespace => "BlueHerbMix";
        public override string Name => "Blue Herbal Extract";
        public override int GoldCost => 250;
    }

    public class GreenHerbMix : Resource
    {
        public override string Namespace => "GreenHerbMix";
        public override string Name => "Green Herbal Extract";
        public override int GoldCost => 250;
    }

    public class RedHerbMix : Resource
    {
        public override string Namespace => "RedHerbMix";
        public override string Name => "Red Herbal Extract";
        public override int GoldCost => 250;
    }

    public class YellowHerbMix : Resource
    {
        public override string Namespace => "YellowHerbMix";
        public override string Name => "Yellow Herbal Extract";
        public override int GoldCost => 250;
    }

    public abstract class BasePotion : Consumable
    {
        public int ConsumePotionAnim = 13;

        public override async Task Use(Entity entity)
        {
            var baseItem = new EmptyBottle();
            var itemRef = await Repository.CreateItem(entity.Inventory.ContainerId, entity.CharacterId, baseItem.Namespace, 1, "consume");
            entity.Inventory.AddItem(itemRef, 1);
            entity.Save();
        }
    }

    // Life Potions
    public class SmallLifePotion : BasePotion
    {
        public override string Namespace => "SmallLifePotion";
        public override string Name => "Small Life Potion";
        public override int GoldCost => 30;

        public override async Task Use(Entity entity)
        {
            await base.Use(entity);
            PlayAnimation(entity, ConsumePotionAnim);
            entity.Heal(entity, 50);
        }
    }

    public class LifePotion : BasePotion
    {
        public override string Namespace => "LifePotion";
        public override string Name => "Life Potion";
        public override int GoldCost => 100;

        public override async Task Use(Entity entity)
        {
            await base.Use(entity);
            PlayAnimation(entity, ConsumePotionAnim);
            entity.Heal(entity, 100);
        }
    }

    public class LargeLifePotion : BasePotion
    {
        public override string Namespace => "LargeLifePotion";
        public override string Name => "Large Life Potion";
        public override int GoldCost => 500;

        public override async Task Use(Entity entity)
        {
            await base.Use(entity);
            PlayAnimation(entity, ConsumePotionAnim);
            entity.Heal(entity, 200);
        }
    }

    // Mana Potions
    public class SmallManaPotion : BasePotion
    {
        public override string Namespace => "SmallManaPotion";
        public override string Name => "Small Mana Potion";
        public override int GoldCost => 50;

        public override async Task Use(Entity entity)
        {
            await base.Use(entity);
            PlayAnimation(entity, ConsumePotionAnim);
            int value = 50;
            entity.Mana = Math.Min(entity.Mana + value, entity.MaxMana);
            entity.HealBroadcast(entity, value, HealType.Mana);
        }
    }

    public class ManaPotion : BasePotion
    {
        public override string Namespace => "ManaPotion";
        public override string Name => "Mana Potion";
        public override int GoldCost => 200;

        public override async Task Use(Entity entity)
        {
            await base.Use(entity);
            PlayAnimation(entity, ConsumePotionAnim);
            int value = 100;
            entity.Mana = Math.Min(entity.Mana + value, entity.MaxMana);
            entity.HealBroadcast(entity, value, HealType.Mana);
        }
    }

    public class LargeManaPotion : BasePotion
    {
        public override string Namespace => "LargeManaPotion";
        public override string Name => "Large Mana Potion";
        public override int GoldCost => 600;

        public override async Task Use(Entity entity)
        {
            await base.Use(entity);
            PlayAnimation(entity, ConsumePotionAnim); 
            int value = 200;
            entity.Mana = Math.Min(entity.Mana + value, entity.MaxMana);
            entity.HealBroadcast(entity, value, HealType.Mana);
        }
    }

    // Stamina Potions
    public class SmallStaminaPotion : BasePotion
    {
        public override string Namespace => "SmallStaminaPotion";
        public override string Name => "Small Stamina Potion";
        public override int GoldCost => 30;

        public override async Task Use(Entity entity)
        {
            await base.Use(entity);
            PlayAnimation(entity, ConsumePotionAnim);
            int value = 50;
            entity.Stamina = Math.Min(entity.Stamina + value, entity.MaxStamina);
            entity.HealBroadcast(entity, value, HealType.Stamina);
        }
    }

    public class StaminaPotion : BasePotion
    {
        public override string Namespace => "StaminaPotion";
        public override string Name => "Stamina Potion";
        public override int GoldCost => 90;

        public override async Task Use(Entity entity)
        {
            await base.Use(entity);
            PlayAnimation(entity, ConsumePotionAnim);
            int value = 100;
            entity.Stamina = Math.Min(entity.Stamina + value, entity.MaxStamina);
            entity.HealBroadcast(entity, value, HealType.Stamina);
        }
    }

    public class LargeStaminaPotion : BasePotion
    {
        public override string Namespace => "LargeStaminaPotion";
        public override string Name => "Large Stamina Potion";
        public override int GoldCost => 120;

        public override async Task Use(Entity entity)
        {
            await base.Use(entity);
            PlayAnimation(entity, ConsumePotionAnim);
            int value = 150;
            entity.Stamina = Math.Min(entity.Stamina + value, entity.MaxStamina);
            entity.HealBroadcast(entity, value, HealType.Stamina);
        }
    }

    // Cure Potions
    public class SmallCurePotion : BasePotion
    {
        public override string Namespace => "SmallCurePotion";
        public override string Name => "Small Cure Potion";
        public override int GoldCost => 30;

        public override async Task Use(Entity entity)
        {
            await base.Use(entity);
            PlayAnimation(entity, ConsumePotionAnim);
            entity.States.RemoveFlag(EntityStates.Poisoned);
        }
    }

    public class CurePotion : BasePotion
    {
        public override string Namespace => "CurePotion";
        public override string Name => "Cure Potion";
        public override int GoldCost => 90;

        public override async Task Use(Entity entity)
        {
            await base.Use(entity);
            PlayAnimation(entity, ConsumePotionAnim);
            entity.States.RemoveFlag(EntityStates.Poisoned);
            entity.Heal(entity, 50);
        }
    }

    public class LargeCurePotion : BasePotion
    {
        public override string Namespace => "LargeCurePotion";
        public override string Name => "Large Cure Potion";
        public override int GoldCost => 120;

        public override async Task Use(Entity entity)
        {
            await base.Use(entity);
            PlayAnimation(entity, ConsumePotionAnim);
            entity.States.RemoveFlag(EntityStates.Poisoned);
            entity.Heal(entity, 100);
        }
    }

    //Elixir
    public class SmallRestoreElixir : BasePotion
    {
        public override string Namespace => "SmallRestoreElixir";
        public override string Name => "Small Restore Elixir";
        public override int GoldCost => 100;

        public override async Task Use(Entity entity)
        {
            await base.Use(entity);
            PlayAnimation(entity, ConsumePotionAnim);
            entity.Heal(entity, 50);
            entity.Mana = Math.Min(entity.Mana + 50, entity.MaxMana);
            entity.Stamina = Math.Min(entity.Stamina + 50, entity.MaxStamina);
        }
    }

    public class RestoreElixir : BasePotion
    {
        public override string Namespace => "RestoreElixir";
        public override string Name => "Restore Elixir";
        public override int GoldCost => 500;

        public override async Task Use(Entity entity)
        {
            await base.Use(entity);
            PlayAnimation(entity, ConsumePotionAnim);
            entity.Heal(entity, 100);
            entity.Mana = Math.Min(entity.Mana + 100, entity.MaxMana);
            entity.Stamina = Math.Min(entity.Stamina + 100, entity.MaxStamina);
        }
    }

    public class BigRestoreElixir : BasePotion
    {
        public override string Namespace => "BigRestoreElixir";
        public override string Name => "Big Restore Elixir";
        public override int GoldCost => 1000;

        public override async Task Use(Entity entity)
        {
            await base.Use(entity);
            PlayAnimation(entity, ConsumePotionAnim);
            entity.Heal(entity, 100);
            entity.Mana = Math.Min(entity.Mana + 100, entity.MaxMana);
            entity.Stamina = Math.Min(entity.Stamina + 100, entity.MaxStamina);
        }
    }

    // Poison Potions
    public class SmallPoisonPotion : BasePotion
    {
        public override string Namespace => "SmallPoisonPotion";
        public override string Name => "Small Poison Potion";
        public override int GoldCost => 90;

        public override async Task Use(Entity entity)
        {
            await base.Use(entity);
            PlayAnimation(entity, ConsumePotionAnim);
            entity.TakeDamage(entity, Dices.D1D10, DamageType.Poison);
            entity.ApplyCondition(new Condition(ConditionType.Poisoned, 6, entity, Dices.D1D6));
            entity.States.AddFlag(EntityStates.Poisoned);
        }
    }

    public class PoisonPotion : BasePotion
    {
        public override string Namespace => "PoisonPotion";
        public override string Name => "Poison Potion";
        public override int GoldCost => 250;

        public override async Task Use(Entity entity)
        {
            await base.Use(entity);
            PlayAnimation(entity, ConsumePotionAnim);
            entity.TakeDamage(entity, Dices.D2D10, DamageType.Poison);
            entity.ApplyCondition(new Condition(ConditionType.Poisoned, 8, entity, Dices.D1D10));
            entity.States.AddFlag(EntityStates.Poisoned);
        }
    }

    public class LargePoisonPotion : BasePotion
    {
        public override string Namespace => "LargePoisonPotion";
        public override string Name => "Large Poison Potion";
        public override int GoldCost => 900;

        public override async Task Use(Entity entity)
        {
            await base.Use(entity);
            PlayAnimation(entity, ConsumePotionAnim);
            entity.TakeDamage(entity, Dices.D3D10, DamageType.Poison);
            entity.ApplyCondition(new Condition(ConditionType.Poisoned, 10, entity, Dices.D1D10));
            entity.States.AddFlag(EntityStates.Poisoned);
        }
    }

    // Legendary Potions
    public class OblivionPotion : BasePotion
    {
        public override string Namespace => "OblivionPotion";
        public override string Name => "Oblivion Potion";
        public override ItemRarity Rarity => ItemRarity.Legendary;
        public override int GoldCost => 10000;

        public override async Task Use(Entity entity)
        {
            await base.Use(entity);
        }
    }

    public class ShrinkagePotion : BasePotion
    {
        public override string Namespace => "ShrinkagePotion";
        public override string Name => "Shrinkage Potion";
        public override ItemRarity Rarity => ItemRarity.Magic;
        public override int GoldCost => 8000;

        public override async Task Use(Entity entity)
        {
            await base.Use(entity);
        }
    }
}
