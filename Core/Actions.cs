
namespace Server
{
    public enum ActionType
    {
        None,
        Projectible,
        Target,
        TargetSelf,
        Area,
        DirectionalCamera
    }

    public enum ActionCostType
    {
        None,
        Life,
        Mana,
        Stamina
    }

    public class Actions
    {
        public static List<BaseAction> ActionsIndex { get; private set; } = new List<BaseAction>();
        public static Dictionary<string, BaseAction> ActionsByName { get; private set; } = new Dictionary<string, BaseAction>(StringComparer.OrdinalIgnoreCase);

        public static void AddAction(BaseAction action)
        {
            // Expande a lista se necessário
            while (ActionsIndex.Count <= action.Id)
            {
                ActionsIndex.Add(null); // Adiciona valores nulos para manter o índice
            }

            ActionsIndex[action.Id] = action;

            ActionsByName[action.Name] = action;
            ActionsByName[action.Namespace] = action;
            ActionsByName[action.Namespace.ToLower()] = action; // Dictionary com StringComparer.OrdinalIgnoreCase cuida da insensibilidade a maiúsculas/minúsculas
        }

        public static BaseAction FindActionById(int id)
        {
            if (id >= 0 && id < ActionsIndex.Count)
            {
                return ActionsIndex[id];
            }
            return null;
        }

        public static BaseAction FindActionByName(string name)
        {
            return ActionsByName.TryGetValue(name.ToLower(), out var action) ? action : null;
        }
    }

    public abstract class BaseAction
    {
        public abstract int Id { get; }
        public abstract string Name { get; }
        public abstract string Namespace { get; }
        public abstract ActionCostType CostType { get; }
        public abstract int Cost { get; }

        public ActionType Type { get; set; } = ActionType.None;
        public Dices Damage { get; set; } = Dices.None;
        public DamageType DamageType { get; set; } = DamageType.Physic;
        public SkillName Skill { get; set; } = SkillName.None;
        public int? SkillRequeriment { get; set; } = 0;
        public Dictionary<int, Dices> DamagePerLevel { get; set; } = new Dictionary<int, Dices>();
        public WeaponType WeaponAmplify { get; set; } = WeaponType.None;
        public int? Radius { get; set; } = 0;
        public int PreCastTime { get; set; } = 0;
        public string CastSay { get; set; } = "";

        public virtual void Precast(Entity owner)
        {
            if (!string.IsNullOrEmpty(CastSay))
                owner.Say(CastSay, ColorByDamageType());
        }

        public virtual void Exec(Entity owner, object target)
        {
            GainSkillExperience(owner);
        }

        public virtual void EffectOnCast(Entity owner) { }

        public virtual void RemoveEffect(Entity owner) { }

        public virtual int EffectOnTakeDamage(Entity owner, Entity causer, int damage, DamageType damageType)
        {
            return damage;
        }

        public virtual int EffectOnHit(Entity owner, Entity causer, int damage, DamageType damageType)
        {
            return damage;
        }

        public virtual void GainSkillExperience(Entity owner)
        {
            if (owner is Player player)
            {
                player.GainSkillExperience(Skill);
            }
        }

        public int RollDice(Dices dice)
        {
            if (dice == Dices.None) return 0;

            string[] parts = dice.ToString().Split('D');
            if (parts.Length != 2) return 0;

            int numDices = int.Parse(parts[0]);
            int numSides = int.Parse(parts[1]);

            int total = 0;
            Random rnd = new Random();
            for (int i = 0; i < numDices; i++)
            {
                total += rnd.Next(1, numSides + 1);
            }

            return total;
        }

        public List<Entity> GetEnemiesInRadius(Entity caster, Vector3 position, int radius)
        {
            List<Entity> enemies = new List<Entity>();

            foreach (var entity in caster.AreaOfInterece)
            {
                if (entity.Team.IsEnemyOf(caster.Team) &&
                    position.DistanceBetween(entity.Transform.Position) <= radius &&
                    !entity.IsDead)
                {
                    enemies.Add(entity);
                }
            }

            return enemies;
        }

        public List<Entity> GetAlliesInRadius(Entity caster, Vector3 position, int radius, bool includeSelf = false)
        {
            List<Entity> allies = new List<Entity>();

            foreach (var entity in caster.AreaOfInterece)
            {
                if (entity.Team.IsAllyOf(caster.Team) &&
                    position.DistanceBetween(entity.Transform.Position) <= radius &&
                    !entity.IsDead)
                {
                    allies.Add(entity);
                }
            }

            if (includeSelf)
            {
                if (position.DistanceBetween(caster.Transform.Position) <= radius &&
                    !caster.IsDead)
                {
                    allies.Add(caster);
                }
            }

            return allies;
        }

        public Task ExecActionInterval(int ticks, int delay, Action callback)
        {
            return Task.Run(async () =>
            {
                for (int i = 0; i < ticks; i++)
                {
                    await Task.Delay(delay);
                    callback();
                }
            });
        }

        public int GetMods(Entity owner, SkillName skill, WeaponType weaponAmplify = WeaponType.None)
        {
            int skillMod = owner.GetSkillBonus(skill);
            int weaponMod = (owner.GetWeaponType() == weaponAmplify) ? owner.GetWeaponBaseDamage() : 0;
            return skillMod + weaponMod;
        }

        public int GetEffectValue(Entity owner)
        {
            int mods = GetMods(owner, Skill.Value, WeaponAmplify);
            int skillValue = owner.GetSkillValue(Skill.Value);
            Dices effectDice = Damage;

            if (DamagePerLevel.TryGetValue(skillValue, out var dice))
            {
                effectDice = dice;
            }

            if (effectDice == null || effectDice == Dices.None)
                effectDice = Damage;

            return RollDice(effectDice) + mods;
        }

        public string ColorByDamageType()
        {
            return DamageType switch
            {
                DamageType.Fire => "255,42,29,255",
                DamageType.Cold => "67,87,255,255",
                DamageType.Poison => "84,255,76,255",
                DamageType.Energy => "82,247,255,255",
                DamageType.Light => "255,239,124,255",
                DamageType.Dark => "57,12,88,255",
                _ => "255,255,255,255",
            };
        }
    }

    public abstract class BaseHealAction : BaseAction
    {
        public override void Exec(Entity owner, object target)
        {
            if (target is Entity entity)
            {
                GainSkillExperience(owner);
                int modInt = owner.GetBonusDamageMod(StatusType.Int);
                entity.Heal(owner, Math.Round(GetEffectValue(owner) + modInt));
            }
        }
    }

    public abstract class BaseSummonAction : BaseAction
    {
        public int Lifetime { get; set; } = 60;

        public void CreateSummon(Player owner, Summon creature, Vector3 position)
        {
            creature.Transform.Position = position;
            creature.StartLifeTime(Lifetime);
            owner.Map.JoinMap(creature);
        }
    }
}

