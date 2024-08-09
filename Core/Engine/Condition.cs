namespace Server.Core.Engine
{
    public enum ConditionType
    {
        None,
        Burning,
        Bleeding,
        Electrified,
        Chilling,
        Poisoned,
        Healing,
        Stunned,
        Slowed,
        Snared,
        Frozen,
        Feared
    }

    public class Condition
    {
        public Entity Dealer { get; private set; }
        public double Lifetime { get; private set; }
        public ConditionType Type { get; private set; }
        public Dices Value { get; private set; }
        public int DamageBonus { get; private set; } = 0;

        public Condition(ConditionType type, double lifetime, Entity dealer, Dices value = Dices.None, int damageBonus = 0)
        {
            Type = type;
            Lifetime = lifetime * 1000;
            Dealer = dealer;
            Value = value;
            DamageBonus = damageBonus;
        }

        public void Apply(Entity c)
        {
            switch (Type)
            {
                case ConditionType.Burning:
                    c.States.AddFlag(EntityStates.Burning);
                    break;
                case ConditionType.Bleeding:
                    c.States.AddFlag(EntityStates.Bleeding);
                    break;
                case ConditionType.Poisoned:
                    c.States.AddFlag(EntityStates.Poisoned);
                    break;
                case ConditionType.Slowed:
                    break;
                case ConditionType.Frozen:
                    c.States.AddFlag(EntityStates.Frozen);
                    break;
                case ConditionType.Stunned:
                    c.States.AddFlag(EntityStates.Stunned);
                    break;
                case ConditionType.Feared:
                    c.States.AddFlag(EntityStates.Feared);
                    break;
            }
        }

        public void Refresh(Entity c, Entity dealer, double newLifetime, Dices newValue)
        {
            switch (Type)
            {
                case ConditionType.Burning:
                case ConditionType.Bleeding:
                case ConditionType.Poisoned:
                    Lifetime = newLifetime + (Lifetime % 1);
                    Value = newValue;
                    break;
            }
        }

        public void Remove(Entity c)
        {
            switch (Type)
            {
                case ConditionType.Burning:
                    c.States.RemoveFlag(EntityStates.Burning);
                    break;
                case ConditionType.Bleeding:
                    c.States.RemoveFlag(EntityStates.Bleeding);
                    break;
                case ConditionType.Poisoned:
                    c.States.RemoveFlag(EntityStates.Poisoned);
                    break;
                case ConditionType.Frozen:
                    c.States.RemoveFlag(EntityStates.Frozen);
                    break;
                case ConditionType.Stunned:
                    c.States.RemoveFlag(EntityStates.Stunned);
                    break;
                case ConditionType.Feared:
                    c.States.RemoveFlag(EntityStates.Feared);
                    break;
            }
        }

        public void Update(Entity c)
        {
            double previousLifetime = Lifetime;
            Lifetime -= 1000;

            switch (Type)
            {
                case ConditionType.Burning:
                    if (Math.Truncate(Lifetime) < Math.Truncate(previousLifetime))
                        c.TakeDamage(Dealer, Value, DamageType.Fire, DamageBonus);
                    break;
                case ConditionType.Poisoned:
                    if (Math.Truncate(Lifetime) < Math.Truncate(previousLifetime))
                        c.TakeDamage(Dealer, Value, DamageType.Poison, DamageBonus);
                    break;
                case ConditionType.Bleeding:
                    if (Math.Truncate(Lifetime) < Math.Truncate(previousLifetime))
                        c.TakeDamage(Dealer, Value, DamageType.Bleed, DamageBonus);
                    break;
                case ConditionType.Healing:
                    if (Math.Truncate(Lifetime) < Math.Truncate(previousLifetime))
                        c.Heal(Dealer, c.RollDice(Value));
                    break;
            }
        }
    }

    public class BuffDebuff
    {
        public BuffDebuffStates Type { get; private set; }
        public Entity Dealer { get; private set; }
        public double Lifetime { get; private set; }
        public BaseAction Action { get; private set; }

        public BuffDebuff(BuffDebuffStates type, double lifetime, Entity dealer, BaseAction action)
        {
            Type = type;
            Lifetime = lifetime * 1000;
            Dealer = dealer;
            Action = action;
        }

        public void Apply(Entity c)
        {
            c.BuffsDebuffsState.AddFlag(Type);
        }

        public void Refresh(Entity c, double newLifetime)
        {
            Lifetime = newLifetime + (Lifetime % 1);
        }

        public void Remove(Entity c)
        {
            c.BuffsDebuffsState.RemoveFlag(Type);
        }

        public void Update(Entity c)
        {
            Lifetime -= 1000;
        }
    }
}
