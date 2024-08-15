using System.Reactive.Subjects;
using Newtonsoft.Json;

namespace Server
{
    public enum Stats
    {
        Str,
        Dex,
        Int,
        Vig,
        Agi,
        Luc
    }

    public struct SkillValue : ISkillValue
    {
        public int Value { get; set; }
        public int Cap { get; set; }
        public int Experience { get; set; }

        public SkillValue(int value = 0, int cap = 10, int experience = 0)
        {
            Value = value;
            Cap = cap;
            Experience = experience;
        }
    }

    public struct SkillLevelExperience : ILevelExperience
    {
        public int Level { get; set; }
        public int Experience { get; set; }

        public SkillLevelExperience(int level, int experience)
        {
            Level = level;
            Experience = experience;
        }
    }

    public abstract class Entity: IEquatable<Entity>, IComparable<Entity>
    {
        public static Dictionary<string, Func<object>> Entities = new Dictionary<string, Func<object>>();
        public static Dictionary<string, Func<Player, object>> Summons = new Dictionary<string, Func<Player, object>>();
        public static Dictionary<string, Func<Player, object>> Pets = new Dictionary<string, Func<Player, object>>();

        //Network
        public string SocketId { get; set; }
        public Socket Socket { get; set; }
        public string CharacterId { get; set; }
        public long LastUpdate {  get; set; }
        public bool Admin { get; set; }
        public bool Removed { get; set; }
        
        //Map / Position
        public Maps Map { get; set; }
        public string MapIndex { get; set; }
        public Transform Transform { get; set; }
        public Vector3 RespawnPosition { get; set; }
        public Respawn Respawn { get; set; }
        public int MovementDistance { get; set; } = 600;
        public int MaxDistanceToRespawn { get; set; } = 3000;
        public int Speed { get; set; } = 700;

        //Character Info
        public string Id { get; set; }
        public string Name { get; set; }
        public virtual bool IsCreature { get; set; } = false;
        public List<Entity> AreaOfInterest = new List<Entity>();
        public StateFlags States { get; set; } = new StateFlags((int)EntityStates.None);
        public StateFlags BuffsDebuffsState { get; set; } = new StateFlags((int)BuffDebuffStates.None);
        public List<Condition> Conditions { get; set; } = new List<Condition>();
        public List<BuffDebuff> BuffDebuffs { get; set; } = new List<BuffDebuff>();
        public EntitiesKind Kind { get; set; } = EntitiesKind.None;
        public Team Team;
        public Entity TeamOwner = null;
        public Dictionary<string, int> DamageCauser = new Dictionary<string, int>();
        public bool InAction = false;
        public bool DestroyOnDie = false;
        public Guild Guild = null;

        //Target
        public string Target = null;
        public Entity TargetActor = null;
        public IDisposable TargetOnDie {  get; set; }
        public IDisposable TargetOnDestroy { get; set; }

        //Loot
        public Loot Loot { get; set; }
        public Func<object> SkinnerResources { get; set; }
        public int SkinnerTick { get; set; } = 0;
        public int SkinnerAmount { get; set; } = 3;
        public int SkinnerGainExp { get; set; } = 1;
        public long DieTimeout { get; set; }

        //Stats
        public int StatsPoints { get; set; } = 0;
        public int StatsCap { get; set; } = 225;
        public int Str { get; set; } = 0;
        public int Dex { get; set; } = 0;
        public int Int { get; set; } = 0;
        public int Vig { get; set; } = 0;
        public int Agi { get; set; } = 0;
        public int Luc { get; set; } = 0;
        public int Life { get; set; } = 0;
        public int MaxLife { get; set; } = 0;
        public int LifeByte { get; set; } = 0;
        public int Mana { get; set; } = 0;
        public int MaxMana { get; set; } = 0;
        public int Stamina { get; set; } = 0;
        public int MaxStamina { get; set; } = 0;
        public int BonusStr { get; set; } = 0;
        public int BonusDex { get; set; } = 0;
        public int BonusInt { get; set; } = 0;
        public int BonusVig { get; set; } = 0;
        public int BonusAgi { get; set; } = 0;
        public int BonusLuc { get; set; } = 0;

        public bool FixedLife { get; set; } = false;
        public Dictionary<SkillName, ISkillValue> Skills { get; set; } = new Dictionary<SkillName, ISkillValue>();
        public Container Inventory { get; set; }
        public int Karma { get; set; } = 0;
        public bool IsDead { get; set; } = false;
        public bool Sprint { get; set; } = false;

        // Resistences
        public int PhysicalResistance { get; set; } = 0;
        public int FireResistance { get; set; } = 0;
        public int ColdResistance { get; set; } = 0;
        public int PoisonResistance { get; set; } = 0;
        public int EnergyResistance { get; set; } = 0;
        public int LightResistance { get; set; } = 0;
        public int DarkResistance { get; set; } = 0;
        public int BonusPhysicalResistance { get; set; } = 0;
        public int BonusFireResistance { get; set; } = 0;
        public int BonusColdResistance { get; set; } = 0;
        public int BonusPoisonResistance { get; set; } = 0;
        public int BonusEnergyResistance { get; set; } = 0;
        public int BonusLightResistance { get; set; } = 0;
        public int BonusDarkResistance { get; set; } = 0;

        // Statics
        public int LifeRegeneration { get; set; } = 0;
        public int ManaRegeneration { get; set; } = 0;
        public int StaminaRegeneration { get; set; } = 0;
        public int BonusPhysicalDamage { get; set; } = 0;
        public int BonusMagicDamage { get; set; } = 0;
        public string WeaponDamage { get; set; } = "";
        public int WeaponSpeed { get; set; } = 0;
        public int CriticalChance { get; set; } = 0;
        public int CriticalDamage { get; set; } = 0;
        public int Armor { get; set; } = 0;
        public int DamageReduction { get; set; } = 0;
        public int DodgeChance { get; set; } = 0;
        public int ReflectionPhysicalDamage { get; set; } = 0;
        public int ReflectionMagicDamage { get; set; } = 0;
        public int LowerManaCost { get; set; } = 0;
        public int LowerStamCost { get; set; } = 0;
        public int FasterCasting { get; set; } = 0;
        public int CooldownReduction { get; set; } = 0;

        // Elemental Damage
        public int FireDamage { get; set; } = 0;
        public int ColdDamage { get; set; } = 0;
        public int EnergyDamage { get; set; } = 0;
        public int PoisonDamage { get; set; } = 0;
        public int LightDamage { get; set; } = 0;
        public int DarkDamage { get; set; } = 0;

        // Bonus collect
        public int BonusCollectsMineral { get; set; } = 0;
        public int BonusCollectsSkins { get; set; } = 0;
        public int BonusCollectsWood { get; set; } = 0;

        // Events
        public Subject<Entity> OnDie { get; } = new Subject<Entity>();
        public Subject<Entity> OnDestroy { get; } = new Subject<Entity>();
        public Subject<Condition> OnConditionChanged { get; } = new Subject<Condition>();
        public Subject<BuffDebuff> OnBuffDebuffChanged { get; } = new Subject<BuffDebuff>();

        //Others
        public string CustomVisual { get; set; }
        public List<string> MultipleVisual = new List<string>();
        public virtual int UpdateIntensity { get; set; } = 3;

        // Party
        public Party Party { get; set; } = null;
        public Player PartyOwner { get; set; } = null;

        // Equipament Heavy
        public bool HasMediumEquipamentPart { get; set; } = false;
        public bool HasHeavyEquipamentPart { get; set; } = false;

        //Timers
        private CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

        public static readonly List<SkillLevelExperience> LevelsExperience = new List<SkillLevelExperience>
        {
            new SkillLevelExperience(1, 1),
            new SkillLevelExperience(2, 150),
            new SkillLevelExperience(3, 600),
            new SkillLevelExperience(4, 2150),
            new SkillLevelExperience(5, 3250),
            new SkillLevelExperience(6, 4574),
            new SkillLevelExperience(7, 6124),
            new SkillLevelExperience(8, 9480),
            new SkillLevelExperience(9, 11880),
            new SkillLevelExperience(10, 39600),
            new SkillLevelExperience(11, 49500),
            new SkillLevelExperience(12, 59400)
        };

        public Entity()
        {
            Id = GUID.NewID(); 
            CalculateStats(); 
            CalculateStatics();
            Loot = new Loot(this);
            Inventory = new Container(this);

            Task.Run(async () => await RegenStatsLoop(_cancellationTokenSource.Token));
            Task.Run(async () => await UpdateLoop(_cancellationTokenSource.Token));
        }

        public bool Equals(Entity other)
        {
            return Id == other.Id || (MapIndex == other.MapIndex && Map.Equals(other.Map));
        }

        public int CompareTo(Entity other)
        {
            return Id.CompareTo(other.Id);
        }

        public static bool operator ==(Entity left, Entity right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Entity left, Entity right)
        {
            return !left.Equals(right);
        }

        private async Task RegenStatsLoop(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                RegenStats();
                await Task.Delay(3000, token); 
            }
        }

        private async Task UpdateLoop(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                Update();
                await Task.Delay(1000, token); 
            }
        }

        public void StopTimers()
        {
            _cancellationTokenSource.Cancel(); 
        }

        public static object GetEntityBase(string reference)
        {
            return Entities.ContainsKey(reference) ? Entities[reference] : null;
        }

        public static void AddEntityBase(string[] refs, Func<Entity> clas)
        {
            foreach (var @namespace in refs)
            {
                Entities[@namespace] = clas;
                Entities[@namespace.ToLower()] = clas;
            }
        }

        public static void AddEntityBase(string @ref, Func<Entity> clas)
        {
            Entities[@ref] = clas;
            Entities[@ref.ToLower()] = clas;
        }

        public static Entity Create(string entityName)
        {
            if (Entities.ContainsKey(entityName))
            {
                var entityClass = Entities[entityName];
                var entity = entityClass() as Entity;

                if (entity.MultipleVisual.Count > 0)                
                    entity.CustomVisual = RandomHelper.ArrRandom<string>(entity.MultipleVisual); 
                
                entity.Init();

                return entity;
            }

            return null;
        }

        public void Init() { }

        public void Update()
        {
            if (Map == null || Removed)
                return;

            if (!Removed)
            {
                UpdateAreaOfInterest();

                if (!IsDead)
                {
                    if (Conditions.Count > 0)
                    {
                        for (int i = Conditions.Count - 1; i >= 0; i--)
                        {
                            var condition = Conditions[i];
                            if (condition != null)
                            {
                                condition.Update(this);

                                if (condition.Lifetime <= 0)
                                {
                                    condition.Remove(this);
                                    RemoveCondition(i);
                                }
                            }
                        }
                    }

                    if (BuffDebuffs.Count > 0)
                    {
                        for (int i = BuffDebuffs.Count - 1; i >= 0; i--)
                        {
                            var buffDebuff = BuffDebuffs[i];
                            if (buffDebuff != null)
                            {
                                buffDebuff.Update(this);

                                if (buffDebuff.Lifetime <= 0)
                                {
                                    buffDebuff.Remove(this);
                                    RemoveBuffDebuff(i);
                                }
                            }
                        }
                    }
                }
                else
                {
                    if ((SkinnerTick == 0 && Loot != null && Loot.Count() <= 0 && DieTimeout < DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()) ||
                        DieTimeout < DateTimeOffset.UtcNow.ToUnixTimeMilliseconds())
                    {
                        foreach (var entity in AreaOfInterest)
                        {
                            // e.g., packetDissolveEntity.Send(this, entity);
                        }

                        OnDestroy.OnNext(this);
                        Map.RemoveEntity(this);
                        Destroy();
                    }
                }
            }
        }

        public virtual void Tick(int tickNumber)
        {
            if (!Removed)
            {
                IsDead = (Life <= 0);
                UpdateAreaOfInterest();

                if (IsDead)
                    AddState(EntityStates.Dead);

                foreach (var entity in AreaOfInterest)                
                    Packet.Get(ServerPacketType.UpdateEntity)?.Send(this, entity, false);
            }

            if (LastUpdate < DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() && Socket != null)
            {
                Removed = true;
                Player.OnlinePlayers.Remove(CharacterId);
                Console.WriteLine($"Client disconnected: {Socket.Id} | Char: {CharacterId} ({Name})");
                Socket.Close();
                Destroy();
            }
        }

        public virtual void Destroy()
        {
            if (this is Player)            
                Player.OnlinePlayers.Remove(CharacterId);
            
            Removed = true;
            Map?.RemoveEntity(this);
            Map = null;
            Conditions.Clear();
            OnDestroy.OnNext(this);
            OnDestroy.OnCompleted(); 
            QueueBuffer.RemoveSocket(MapIndex);
            StopTimers();
        }

        // Network
        public string GetSocketId()
        {
            return SocketId;
        }

        public void Broadcast(Packet packet, object data = null)
        {
            var entities = new HashSet<Entity>(AreaOfInterest) { this };

            foreach (var entity in entities)            
                packet.Send(this, entity, data);
        }

        public void UpdateLastInteract()
        {
            LastUpdate = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() + (60 * 1000);
        }

        public virtual void Save() { }

        //Stats
        public virtual void CalculateStats()
        {
            if (!FixedLife)
                MaxLife = 10 + ((Vig + BonusVig) * 5) + (Str + BonusStr);

            MaxStamina = 10 + ((Str + BonusStr) * 2) + ((Dex + BonusDex) * 3) + (Vig + BonusVig);
            MaxMana = 10 + ((Int + BonusInt) * 3);
        }

        public virtual void RestoreStats()
        {
            Life = MaxLife;
            Mana = MaxMana;
            Stamina = MaxStamina;
        }

        public virtual void RegenStats()
        {
            if (Map == null || Removed)
                return;

            if (!Removed && !IsCreature)
            {
                if (States.HasFlag(EntityStates.Dead) != true)
                {
                    int lifeRegen = Math.Max(1, (int)Math.Round(1 + (LifeRegeneration / 10.0)));
                    int manaRegen = Math.Max(1, (int)Math.Round(3 + (ManaRegeneration / 10.0)));
                    int stamRegen = Math.Max(1, (int)Math.Round(10 + (StaminaRegeneration / 10.0)));
                    stamRegen = (!Sprint) ? stamRegen : -10;

                    Life = Math.Max(Math.Min(Life + lifeRegen, MaxLife), 0);

                    if (HasMediumEquipamentPart || HasHeavyEquipamentPart)
                        manaRegen = (int)Math.Round(manaRegen / 2.0);

                    Mana = Math.Max(Math.Min(Mana + manaRegen, MaxMana), 0);

                    if (!HasHeavyEquipamentPart)
                        stamRegen = (int)Math.Round(stamRegen * 2.0);

                    Stamina = Math.Max(Math.Min(Stamina + stamRegen, MaxStamina), 0);
                }
            }
        }

        public virtual void AddStatsPoint()
        {
            int points = StatsPoints > 0 ? StatsPoints : 0;
            int cap = StatsCap > 0 ? StatsCap : 225;
            int statsUsage = Str + Dex + Int + Vig + Agi + Luc + points;

            if (statsUsage < cap)
            {
                StatsPoints++;
                Packet.Get(ServerPacketType.SpecialMessage)?.Send(this, "You gained 1 status point");
                Packet.Get(ServerPacketType.SystemMessage)?.Send(this, "You have received 1 stat point that can be assigned to your character");
                OnStatsChange();
            }
        }

        public virtual void OnStatsChange() { }

        public virtual void AddStat(Stats stat)
        {
            int points = StatsPoints > 0 ? StatsPoints : 0;
            int cap = StatsCap > 0 ? StatsCap : 225;
            int statsUsage = Str + Dex + Int + Vig + Agi + Luc;

            if (points > 0 && cap >= statsUsage)
            {
                StatsPoints--;

                switch (stat)
                {
                    case Stats.Str: Str++; break;
                    case Stats.Dex: Dex++; break;
                    case Stats.Int: Int++; break;
                    case Stats.Vig: Vig++; break;
                    case Stats.Agi: Agi++; break;
                    case Stats.Luc: Luc++; break;
                }

                CalculateStats();
                Save();
            }
            else
            {
                StatsPoints = 0;
                CalculateStats();
                Save();
            }
        }

        //Statics
        public virtual void CalculateStatics()
        {
            int baseResistances = GetSkillValue(SkillName.MagicResistence);
            PhysicalResistance = Math.Min(BonusPhysicalResistance, 70);
            FireResistance = Math.Min((baseResistances * 2) + BonusFireResistance, 70);
            ColdResistance = Math.Min((baseResistances * 2) + BonusColdResistance, 70);
            PoisonResistance = Math.Min((baseResistances * 2) + BonusPoisonResistance, 70);
            EnergyResistance = Math.Min((baseResistances * 2) + BonusEnergyResistance, 70);
            LightResistance = Math.Min(baseResistances + BonusLightResistance, 70);
            DarkResistance = Math.Min(baseResistances + BonusDarkResistance, 70);
        }

        //Map
        public virtual void SetMap(Maps map, string id)
        {
            Map = map;
            MapIndex = id;

            if (Socket != null)            
                Socket.EntityId = id;            
        }

        public virtual void UpdatePosition(Vector3 Location)
        {
            if (Transform.Position.Diff(Location))            
                Transform.SetPosition(Location);
        }

        //Events
        public void UpdateEvent(object data)
        {
            foreach (var entity in AreaOfInterest)            
                Packet.Get(ServerPacketType.SyncEvent).Send(this, entity, data);
        }

        public void UpdatePlayMontage(int index)
        {
            foreach (var entity in AreaOfInterest)            
                Packet.Get(ServerPacketType.PlayMontage).Send(this, entity, index);
        }

        public void PreCast(int index)
        {
            try
            {
                if (index >= 0)
                {
                    var action = Actions.FindActionById(index);

                    if (action != null)
                        action.Precast(this);
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception if necessary
            }
        }

        public void UpdateAction(int index, Entity target = null)
        {
            try
            {
                if (index >= 0)
                {
                    var action = Actions.FindActionById(index);

                    if (action != null)
                    {
                        if (action.Skill != SkillName.None)
                        {
                            var skillLevel = GetSkillValue(action.Skill);

                            if (skillLevel >= action.SkillRequeriment || IsCreature)
                            {
                                var reductManaCost = Math.Max((action.Cost * LowerManaCost) / 100, 0);
                                var reductStamCost = Math.Max((action.Cost * LowerStamCost) / 100, 0);

                                switch (action.CostType)
                                {
                                    case ActionCostType.Life:
                                        Life -= action.Cost;
                                        break;
                                    case ActionCostType.Mana:
                                        Mana -= (action.Cost - reductManaCost);
                                        break;
                                    case ActionCostType.Stamina:
                                        Stamina -= (action.Cost - reductStamCost);
                                        break;
                                }

                                foreach (var entity in AreaOfInterest)                                
                                    Packet.Get(ServerPacketType.Action).Send(this, entity, index);                                
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception if necessary
            }
        }

        public void UpdateActionArea(int index, Vector3 position)
        {
            try
            {
                if (index >= 0)
                {
                    var action = Actions.FindActionById(index);

                    if (action != null)
                    {
                        if (action.Skill != SkillName.None)
                        {
                            var skillLevel = GetSkillValue(action.Skill);

                            if (skillLevel >= action.SkillRequeriment || IsCreature)
                            {
                                var reductManaCost = Math.Max((action.Cost * LowerManaCost) / 100, 0);
                                var reductStamCost = Math.Max((action.Cost * LowerStamCost) / 100, 0);

                                switch (action.CostType)
                                {
                                    case ActionCostType.Life:
                                        Life -= action.Cost;
                                        break;
                                    case ActionCostType.Mana:
                                        Mana -= (action.Cost - reductManaCost);
                                        break;
                                    case ActionCostType.Stamina:
                                        Stamina -= (action.Cost - reductStamCost);
                                        break;
                                }

                                foreach (var entity in AreaOfInterest)                                
                                    Packet.Get(ServerPacketType.ActionArea).Send(this, entity, new { index, position });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception if necessary
            }
        }

        public void ActionSuccess(int index, object targetOrPosition = null)
        {
            try
            {
                if (index >= 0)
                {
                    var action = Actions.FindActionById(index);
                    action?.Exec(this, targetOrPosition);
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception if necessary
            }
        }

        //Area Of Interest
        public virtual void PacketCreateEntity(Entity entity)
        {
            Packet.Get(ServerPacketType.CreateEntity).Send(this, entity);
        }

        public void AddToAreaOfInterest(Entity entity)
        {
            PacketCreateEntity(entity);
            AreaOfInterest.Add(entity);
        }

        public void RemoveFromAreaOfInterest(Entity entity)
        {
            Packet.Get(ServerPacketType.RemoveEntity).Send(this, entity);
            AreaOfInterest.RemoveAll(e => e.MapIndex == entity.MapIndex);
        }

        public void UpdateAreaOfInterest()
        {
            if (Map == null || Removed)
                return;

            const int InterestRadius = 8000;
            var currentArea = new HashSet<string>(AreaOfInterest.Select(e => e.MapIndex));

            foreach (var entity in Map.EntitiesIndexById.Values)
            {
                if (entity.MapIndex == MapIndex)
                    continue;

                var distance = Transform.Position.DistanceTo(entity.Transform.Position);
                var isInInterestArea = distance <= InterestRadius;
                var alreadyInArea = currentArea.Contains(entity.MapIndex);

                if (!entity.IsDead)
                {
                    if (isInInterestArea && !alreadyInArea)
                    {
                        AddToAreaOfInterest(entity);
                        entity.AddToAreaOfInterest(this);
                    }
                    else if (!isInInterestArea && alreadyInArea)
                    {
                        RemoveFromAreaOfInterest(entity);
                        entity.RemoveFromAreaOfInterest(this);
                    }
                }
            }
        }

        public List<Entity> GetEnemiesInRadius(Vector3 position, int radius)
        {
            var enemies = new List<Entity>();

            foreach (var entity in AreaOfInterest)
            {
                if (entity.Team.IsEnemyOf(Team) && position.DistanceBetween(entity.Transform.Position) <= radius)                
                    enemies.Add(entity);                
            }

            return enemies;
        }

        //States
        public void AddState(EntityStates state)
        {
            States.AddFlag(state);
        }

        public void RemoveState(EntityStates state)
        {
            States.RemoveFlag(state);
        }

        public bool HasState(EntityStates state)
        {
            return States.HasFlag(state);
        }

        public StateFlags GetStates(Entity other, string context)
        {
            var currentFlag = new StateFlags(States.GetCurrentFlags());

            if (Admin && !States.HasFlag(EntityStates.Admin))
            {
                States.AddFlag(EntityStates.Admin);
                currentFlag.AddFlag(EntityStates.Admin);
            }

            if (other.PartyOwner == PartyOwner && PartyOwner != null && other.PartyOwner != null)            
                currentFlag.AddFlag(EntityStates.Party);
            
            if (Guild != null && other.Guild != null && other.Guild.Id == Guild.Id)            
                currentFlag.AddFlag(EntityStates.Guild);            

            if (Team.IsAllyOf(other.Team))
                currentFlag.AddFlag(EntityStates.Ally);
            else if (Team.IsEnemyOf(other.Team))
                currentFlag.AddFlag(EntityStates.Enemy);

            return currentFlag;
        }

        public void StartSprint()
        {
            Sprint = true;
        }

        public void EndSprint()
        {
            Sprint = false;
        }

        public void Roll()
        {
            Stamina = Math.Max(Stamina - 10, 0);
        }

        //Skill
        public ISkillValue GetSkill(SkillName skill)
        {
            return Skills.ContainsKey(skill) ? Skills[skill] : new SkillValue { Cap = 10, Experience = 1, Value = 0 };
        }

        public int GetSkillValue(SkillName skill)
        {
            return Skills.ContainsKey(skill) ? Skills[skill].Value : 0;
        }

        public int GetSkillCap(SkillName skill)
        {
            return Skills.ContainsKey(skill) ? Skills[skill].Cap : 0;
        }

        public void SetSkill(SkillName skill, int value)
        {
            if (skill != SkillName.None)
            {
                int cap = Skills.ContainsKey(skill) ? Skills[skill].Cap : 10;

                Skills[skill] = new SkillValue
                {
                    Experience = GetTotalExperienceForLevel(value),
                    Value = value,
                    Cap = cap
                };

                Packet.Get(ServerPacketType.SystemMessage)
                    .Send(this, $"You increased your skill by {SkillNameExtensions.GetSkillNameString(skill)} and now you have a total of {value}");
            }
        }

        public int GetLevelFromExperience(int experience)
        {
            for (int i = 0; i < LevelsExperience.Count - 1; i++)
            {
                if (experience >= LevelsExperience[i].Experience && experience < LevelsExperience[i + 1].Experience)
                {
                    int experienceForCurrentLevel = LevelsExperience[i].Experience;
                    int experienceForNextLevel = LevelsExperience[i + 1].Experience;
                    int experienceInRange = experience - experienceForCurrentLevel;
                    int totalExperienceNeededForNextLevel = experienceForNextLevel - experienceForCurrentLevel;
                    double progressFraction = (double)experienceInRange / totalExperienceNeededForNextLevel;
                    double levelWithProgress = LevelsExperience[i].Level + progressFraction;

                    return (int)Math.Round(levelWithProgress, 1);
                }
            }

            return experience >= LevelsExperience[LevelsExperience.Count - 1].Experience
                ? LevelsExperience[LevelsExperience.Count - 1].Level
                : 1;
        }

        public SkillName GetSkillByWeapon(WeaponType weaponType)
        {
            switch (weaponType)
            {
                case WeaponType.Axe:
                case WeaponType.Dagger:
                case WeaponType.Sword:
                case WeaponType.Hammer:
                    return SkillName.CombatWithWeapons;
                case WeaponType.TwoHandedAxe:
                case WeaponType.TwoHandedSword:
                case WeaponType.TwoHandedHammer:
                case WeaponType.Spear:
                case WeaponType.Staff:
                    return SkillName.TwoHandedWeapons;
                case WeaponType.Bow:
                case WeaponType.Crossbow:
                    return SkillName.LongRangeWeapons;
                default:
                    return SkillName.None;
            }
        }

        public void GainSkillExperience(SkillName skill, int gain = 3, bool saveOnDatabase = true)
        {
            try
            {
                if (skill != SkillName.None)
                {
                    var skillValue = GetSkill(skill);
                    skillValue.Experience += gain;
                    var tmpValue = GetLevelFromExperience(skillValue.Experience);
                    bool changeLevel = tmpValue != skillValue.Value;
                    skillValue.Value = tmpValue <= skillValue.Cap ? tmpValue : skillValue.Cap;
                    Skills[skill] = skillValue;

                    if (saveOnDatabase)
                        Save();

                    //if (this is Player)
                    //    (this as Player).CheckSkillAchievement();

                    if (changeLevel && tmpValue < skillValue.Cap)
                    {
                        if (tmpValue % 2 == 0)
                            AddStatsPoint();

                        if (RandomHelper.MinMaxInt(1, 5) == 1)
                            AddStatsPoint();

                        if (this is Player)
                        {
                            (this as Player).Save();
                            (this as Player).SaveToDatabase();
                        }

                        Packet.Get(ServerPacketType.SystemMessage).Send(this, $"You increased your skill by {SkillNameExtensions.GetSkillNameString(skill)} and now you have a total of {(skillValue.Value * 10)}");
                        Packet.Get(ServerPacketType.UpdateSkillExperience).Send(this, skill, skillValue);
                        Packet.Get(ServerPacketType.SpecialMessage).Send(this, $"You gained 1 point from the {SkillNameExtensions.GetSkillNameString(skill)} skill");
                        Packet.Get(ServerPacketType.UpdateSkillInfo).Send(this);
                    }
                }
            }
            catch (Exception) { }
        }

        public void GainSkillExperienceByWeapon(WeaponType weaponType, int gain = 3, bool saveOnDatabase = true)
        {
            var skill = GetSkillByWeapon(weaponType);
            GainSkillExperience(skill, gain, saveOnDatabase);
        }

        public int GetSkillBonus(SkillName skill)
        {
            int skillValue = GetSkillValue(skill);
            int modSkillValue = skillValue - 3;
            return modSkillValue > 0 ? modSkillValue : 0;
        }

        public int GetSkillBonusByWeaponType(WeaponType weaponType)
        {
            var skill = GetSkillByWeapon(weaponType);
            return skill != SkillName.None ? GetSkillBonus(skill) : 0;
        }

        public int GetTotalExperienceForLevel(int level)
        {
            foreach (var levelExperience in LevelsExperience)
            {
                if (levelExperience.Level == level)
                    return levelExperience.Experience;
            }

            return 0;
        }

        public string SerializeSkills()
        {
            var skillsParsed = new List<object>();

            foreach (var skill in Skills)
            {
                skillsParsed.Add(new
                {
                    s = skill.Key,
                    c = skill.Value.Cap,
                    v = skill.Value.Value,
                    p = (skill.Value.Experience == 0 && skill.Value.Value > 0) ?
                        GetTotalExperienceForLevel(skill.Value.Value) :
                        skill.Value.Experience
                });
            }

            return JsonConvert.SerializeObject(new { data = skillsParsed });
        }

        //Actionbar
        public void setAction(string action, string itemRef, int index) {}

        public void clearAction(int index) {}

        //Target
        public void SelectTarget(string targetName, Entity target)
        {
            Target = targetName;
            BindTargetActor(target);

            foreach (var entity in AreaOfInterest)            
                Packet.Get(ServerPacketType.SelectTarget).Send(this, entity, targetName);            
        }

        public void BindTargetActor(Entity target)
        {
            if (TargetActor != null)
                RemoveTargetActor();

            TargetActor = target;

            TargetOnDie = TargetActor.OnDie.Subscribe(entity =>
            {
                TargetActor = null;
                Target = null;
                TargetOnDie?.Dispose();
                TargetOnDie = null;
            });

            TargetOnDestroy = TargetActor.OnDestroy.Subscribe(entity =>
            {
                TargetActor = null;
                Target = null;
                TargetOnDestroy?.Dispose();
                TargetOnDestroy = null;
            });
        }

        public void CancelTarget()
        {
            Target = null;
            TargetActor = null;
            RemoveTargetActor();

            foreach (var entity in AreaOfInterest)  
                Packet.Get(ServerPacketType.CancelTarget).Send(this, entity);
        }

        public void RemoveTargetActor()
        {
            if (TargetActor != null && TargetOnDie != null)
            {
                TargetOnDie?.Dispose();
                TargetOnDie = null;
                TargetActor = null;
            }
        }

        //Damage
        public int RollDice(Dices dice)
        {
            if (dice == Dices.None) return 0;

            var match = System.Text.RegularExpressions.Regex.Match(dice.ToString(), @"(\d+)D(\d+)");

            if (!match.Success) return 0;

            int numDices = int.Parse(match.Groups[1].Value);
            int numSides = int.Parse(match.Groups[2].Value);

            int total = 0;

            var random = new Random();

            for (int i = 0; i < numDices; i++)            
                total += random.Next(1, numSides + 1);            

            return total;
        }

        protected virtual bool ValidateHit(ICheckHitAutoAttack data, Entity actor)
        {
            var checkHitData = new CheckHit
            {
                EntityId = data.EntityId,
                ActorId = data.ActorId,
                X = data.X,
                Y = data.Y,
                Z = data.Z,
                Action = -1
            };

            return ValidateHit(checkHitData, actor);
        }

        protected bool ValidateHit(ICheckHit data, Entity actor)
        {
            try
            {
                var distance = actor.Transform.Position.DistanceTo(this.Transform.Position);
                var distanceHitToEntity = actor.Transform.Position.DistanceTo(
                    new Vector3(data.X, data.Y, data.Z));

                if (data.EntityId == data.ActorId)
                    throw new Exception("Invalid damage self");

                if (actor == null)
                    throw new Exception($"Entity {data.ActorId} does not exist");

                if (actor.HasState(EntityStates.Dead))
                    throw new Exception($"The {data.ActorId} target is dead");

                //if (distance > 10000)
                //    throw new Exception("The attacked entity is very far from the caster");

                //if (distanceHitToEntity > 2000)
                //    throw new Exception("The reported hit is too far from the target");

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void CheckHit(ICheckHit data)
        {
            try
            {
                var action = Actions.FindActionById(data.Action);
                var actor = this.Map.FindEntityById(data.ActorId);

                if (actor == null)
                    throw new Exception("Invalid actor");

                if (!ValidateHit(data, actor))
                    throw new Exception("Invalid data hit");

                if (action == null)
                    throw new Exception("Invalid action");

                actor.TakeDamage(this, action.Damage, action.DamageType, 0, action);

                CheckElementalDamage(actor);
            }
            catch (Exception)
            {
                // Handle exceptions if necessary
            }
        }

        public virtual void CheckHitAutoAttack(ICheckHitAutoAttack data)
        {
            try
            {
                var actor = this.Map.FindEntityById(data.ActorId);

                if (actor == null)
                    throw new Exception("Invalid actor");

                if (!ValidateHit(data, actor))
                    throw new Exception("Invalid data hit");

                actor.TakeDamage(this, Dices.D1D4, DamageType.Physic, 0, null, false, true);

                CheckElementalDamage(actor);
            }
            catch (Exception)
            {
                // Handle exceptions if necessary
            }
        }

        public int GetMods(SkillName skill, WeaponType weaponAmplify = WeaponType.None)
        {
            var skillMod = GetSkillBonus(skill);
            var weaponMod = (GetWeaponType() == weaponAmplify) ? GetWeaponBaseDamage() : 0;
            return skillMod + weaponMod;
        }

        public int CalculateDamage(Dices damage, BaseAction action = null)
        {
            return (action != null) ? action.GetEffectValue(this) : RollDice(damage);
        }

        public WeaponType GetActionWeaponAmplify(BaseAction action)
        {
            return action.WeaponAmplify;
        }

        public virtual int GetWeaponBaseDamage() { return 0; }

        public virtual WeaponType GetWeaponType() { return WeaponType.None; }

        public int AmplifyDamage(int damageBase, int resistence)
        {
            int bonusDamage = 0;

            if (resistence < 0)
            {
                var plusDamage = (damageBase * -resistence) / 100;

                if (plusDamage > 0)
                    bonusDamage = plusDamage;
            }

            return (bonusDamage > 0) ? bonusDamage : 0;
        }

        public int CalculateResistence(int damage, DamageType damageType)
        {
            int reductDamageEquips = (damage * DamageReduction) / 100;

            if (reductDamageEquips > 0)
                damage -= reductDamageEquips;

            // Resistências
            switch (damageType)
            {
                case DamageType.Physic:
                    int physicalResistence = PhysicalResistance + BonusPhysicalResistance;
                    if (physicalResistence > 0)
                    {
                        int reductDamage = (damage * physicalResistence) / 100;
                        if (reductDamage > 0)
                            damage -= reductDamage;
                    }
                    else
                    {
                        damage += AmplifyDamage(damage, physicalResistence);
                    }
                    break;

                case DamageType.Fire:
                    int fireResistence = FireResistance + BonusFireResistance;
                    if (fireResistence > 0)
                    {
                        int reductDamageFire = (damage * fireResistence) / 100;
                        if (reductDamageFire > 0)
                            damage -= reductDamageFire;
                    }
                    else
                    {
                        damage += AmplifyDamage(damage, fireResistence);
                    }
                    break;

                case DamageType.Cold:
                    int coldResistence = ColdResistance + BonusColdResistance;
                    if (coldResistence > 0)
                    {
                        int reductDamageCold = (damage * coldResistence) / 100;
                        if (reductDamageCold > 0)
                            damage -= reductDamageCold;
                    }
                    else
                    {
                        damage += AmplifyDamage(damage, coldResistence);
                    }
                    break;

                case DamageType.Poison:
                    int poisonResistence = PoisonResistance + BonusPoisonResistance;
                    if (poisonResistence > 0)
                    {
                        int reductDamagePoison = (damage * poisonResistence) / 100;
                        if (reductDamagePoison > 0)
                            damage -= reductDamagePoison;
                    }
                    else
                    {
                        damage += AmplifyDamage(damage, poisonResistence);
                    }
                    break;

                case DamageType.Energy:
                    int energyResistence = EnergyResistance + BonusEnergyResistance;
                    if (energyResistence > 0)
                    {
                        int reductDamageEnergy = (damage * energyResistence) / 100;
                        if (reductDamageEnergy > 0)
                            damage -= reductDamageEnergy;
                    }
                    else
                    {
                        damage += AmplifyDamage(damage, energyResistence);
                    }
                    break;

                case DamageType.Light:
                    int lightResistence = LightResistance + BonusLightResistance;
                    if (lightResistence > 0)
                    {
                        int reductDamageLight = (damage * lightResistence) / 100;
                        if (reductDamageLight > 0)
                            damage -= reductDamageLight;
                    }
                    else
                    {
                        damage += AmplifyDamage(damage, lightResistence);
                    }
                    break;

                case DamageType.Dark:
                    int darkResistence = DarkResistance + BonusDarkResistance;
                    if (darkResistence > 0)
                    {
                        int reductDamageDark = (damage * darkResistence) / 100;
                        if (reductDamageDark > 0)
                            damage -= reductDamageDark;
                    }
                    else
                    {
                        damage += AmplifyDamage(damage, darkResistence);
                    }
                    break;
            }

            return damage;
        }

        public int CheckBuffEffect(Entity causer, int damage, DamageType damageType)
        {
            if (BuffDebuffs.Count > 0)
            {
                foreach (var buffsDebuff in BuffDebuffs)                
                    damage = buffsDebuff.Action.EffectOnTakeDamage(this, causer, damage, damageType);                
            }

            if (causer.BuffDebuffs.Count > 0)
            {
                foreach (var buffsDebuff in causer.BuffDebuffs)                
                    damage = buffsDebuff.Action.EffectOnHit(causer, this, damage, damageType);
                
            }

            return damage;
        }

        public void CheckElementalDamage(Entity actor)
        {
            if (actor.FireDamage > 0)
                TakeElementalDamage(actor, DamageType.Fire, actor.FireDamage);

            if (actor.ColdDamage > 0)
                TakeElementalDamage(actor, DamageType.Cold, actor.ColdDamage);

            if (actor.PoisonDamage > 0)
                TakeElementalDamage(actor, DamageType.Poison, actor.PoisonDamage);

            if (actor.EnergyDamage > 0)
                TakeElementalDamage(actor, DamageType.Energy, actor.EnergyDamage);

            if (actor.LightDamage > 0)
                TakeElementalDamage(actor, DamageType.Light, actor.LightDamage);

            if (actor.DarkDamage > 0)
                TakeElementalDamage(actor, DamageType.Dark, actor.DarkDamage);
        }

        public void TakeElementalDamage(Entity actor, DamageType type, int damage)
        {
            actor.TakeDamage(this, Dices.D1D4, type, RandomHelper.MinMaxInt(Math.Max(1, damage / 2), damage));
        }

        public int BonusDamageMod(StatusType type)
        {
            switch (type)
            {
                case StatusType.Str: return ReturnModStatus(Str);
                case StatusType.Dex: return ReturnModStatus(Dex);
                case StatusType.Int: return ReturnModStatus(Int);
                case StatusType.Vig: return ReturnModStatus(Vig);
                case StatusType.Agi: return ReturnModStatus(Agi);
                case StatusType.Luc: return ReturnModStatus(Luc);
            }

            return 0;
        }

        public int ReturnModStatus(int value)
        {
            return (int)Math.Max(Math.Round(value / 10.0), 0);
        }

        public void TakeDamage(
            Entity causer,
            Dices dice,
            DamageType damageType,
            int bonusDamage = 0,
            BaseAction action = null,
            bool ignoreBuffEffect = false,
            bool autoattack = false
        )
        {
            var entities = new HashSet<Entity>(AreaOfInterest) { causer, this };

            if (!IsDead && causer.Transform.Position.DistanceTo(Transform.Position) > 5000)
            {
                foreach (var entity in entities)                
                    Packet.Get(ServerPacketType.TakeMiss).Send(this, entity);
                
                if (Target == null)
                {
                    Target = causer.MapIndex;
                    BindTargetActor(causer);
                    SelectTarget(causer.MapIndex, causer);
                }
            }
            else if (!IsDead && causer.Team.IsEnemyOf(Team))
            {
                int bonusDamageEquips = (damageType == DamageType.Physic) ? BonusPhysicalDamage : BonusMagicDamage;
                int damage = causer.CalculateDamage(dice, action) + bonusDamage + bonusDamageEquips;
                damage += (RandomHelper.MinMaxInt(1, 100) < CriticalChance) ? Math.Min(CriticalDamage, damage) : 0;

                if (damageType == DamageType.Physic)
                {
                    if (GetWeaponType() == WeaponType.Bow || GetWeaponType() == WeaponType.Crossbow)                    
                        damage += causer.BonusDamageMod(StatusType.Dex);                    
                    else                    
                        damage += causer.BonusDamageMod(StatusType.Str);
                }
                else
                {
                    damage += causer.BonusDamageMod(StatusType.Int);
                }

                damage = CalculateResistence(damage, damageType);

                if (!ignoreBuffEffect)
                    damage = CheckBuffEffect(causer, damage, damageType);

                if (action != null && !ignoreBuffEffect)
                    damage = action.EffectOnTakeDamage(this, causer, damage, damageType);

                if (States.HasFlag(EntityStates.Invulnerable))
                    damage = 0;

                if (autoattack)
                    damage = (int)Math.Round(damage / 2.0);

                bool dodge = (RandomHelper.MinMaxInt(1, 100) < DodgeChance);

                if (Target == null)
                {
                    Target = causer.MapIndex;
                    BindTargetActor(causer);
                    SelectTarget(causer.MapIndex, causer);
                }

                if (damage >= 1 && !dodge)
                {
                    if (DamageReduction > 0)
                    {
                        double dmFactor = DamageReduction / 100.0;
                        double dmReduct = Math.Abs(Math.Max(damage * dmFactor, 1));

                        if (dmReduct > 0)
                            damage -= (int)dmReduct;
                    }

                    Life -= damage;

                    if (action != null && action.Skill != SkillName.None)
                        causer.GainSkillExperience(action.Skill);

                    if (States.HasFlag(EntityStates.Stunned) && damageType == DamageType.Physic)
                        States.RemoveFlag(EntityStates.Stunned);

                    if (Life <= 0)
                    {
                        foreach (var entity in entities)
                        {
                            Packet.Get(ServerPacketType.TakeDamage).Send(this, entity, new
                            {
                                damage,
                                damageType,
                                causer
                            });
                        }

                        Die(causer);
                    }
                    else
                    {
                        if (damageType != DamageType.Physic)
                        {
                            this.GainSkillExperience(SkillName.MagicResistence, 1);

                            int magicDamageReflect = (int)Math.Round(damage * (ReflectionMagicDamage / 100.0));

                            if (magicDamageReflect > 0)
                                causer.TakeDamage(this, Dices.D1D4, damageType, magicDamageReflect);
                        }
                        else
                        {
                            int physicalDamageReflect = (int)Math.Round(damage * (ReflectionPhysicalDamage / 100.0));

                            if (physicalDamageReflect > 0)
                                causer.TakeDamage(this, Dices.D1D4, DamageType.Physic, physicalDamageReflect);
                        }

                        if (!DamageCauser.ContainsKey(causer.MapIndex))
                            DamageCauser[causer.MapIndex] = damage;
                        else
                            DamageCauser[causer.MapIndex] += damage;

                        if (causer is Player player)
                        {
                            if (player.GetWeaponType() != WeaponType.None)
                                player.GainSkillExperienceByWeapon(player.GetWeaponType());
                        }

                        foreach (var entity in entities)
                        {
                            Packet.Get(ServerPacketType.TakeDamage).Send(this, entity, new
                            {
                                damage,
                                damageType,
                                causer
                            });
                        }
                    }
                }
                else
                {
                    foreach (var entity in entities)                    
                        Packet.Get(ServerPacketType.TakeMiss).Send(this, entity);
                }
            }
        }

        public void Die(Entity causer)
        {
            IsDead = true;
            DieTimeout = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() + (60 * 10 * 1000);
            States.AddFlag(EntityStates.Dead);
            States.RemoveFlag(EntityStates.Poisoned);
            States.RemoveFlag(EntityStates.Stunned);
            States.RemoveFlag(EntityStates.Frenzy);
            States.RemoveFlag(EntityStates.Burning);
            States.RemoveFlag(EntityStates.Frozen);
            Conditions.Clear();
            BuffDebuffs.Clear();
            OnDie?.OnNext(this);

            var entities = new HashSet<Entity>(AreaOfInterest) { causer, this };

            foreach (var entity in entities)
            {
                if (entity != null)
                    Packet.Get(ServerPacketType.Die).Send(this, entity);
            }

            if (causer != null && Socket != null)
                Packet.Get(ServerPacketType.SystemMessage).Send(this, $"You were killed by a {causer.Name} attack");

            if (DestroyOnDie)
            {
                Packet.Get(ServerPacketType.Dissolve).Send(this, causer);

                foreach (var otherEntity in entities)                
                    Packet.Get(ServerPacketType.Dissolve).Send(this, otherEntity);
                
                Destroy();
            }
        }

        public virtual void Revive()
        {
            IsDead = false;
            Life = MaxLife;
            States.RemoveFlag(EntityStates.Dead);
            States.RemoveFlag(EntityStates.Poisoned);
            States.RemoveFlag(EntityStates.Stunned);
            States.RemoveFlag(EntityStates.Frenzy);
            States.RemoveFlag(EntityStates.Burning);
            States.RemoveFlag(EntityStates.Frozen);
            Conditions = new List<Condition>();
            BuffDebuffs = new List<BuffDebuff>();

            if (this is Player player)
            {
                player.Save();
                player.SaveToDatabase();
            }

            Packet.Get(ServerPacketType.SyncEvent).Send(this, EventType.Revive);
        }

        public void Heal(Entity caster, int value)
        {
            if (caster.Team.IsAllyOf(this.Team) || this is Player)
            {
                Life = Math.Max(1, Math.Min(Life + value, MaxLife));
                var entities = new HashSet<Entity>(AreaOfInterest) { caster, this };

                foreach (var entity in entities)
                {
                    Packet.Get(ServerPacketType.Heal).Send(this, entity, new
                    {
                        value,
                        caster,
                        type = HealType.Life
                    });
                }
            }
        }

        public void HealBroadcast(Entity caster, int value, HealType type = HealType.Life)
        {
            var entities = new HashSet<Entity>(AreaOfInterest) { caster, this };

            foreach (var entity in entities)
            {
                Packet.Get(ServerPacketType.Heal).Send(this, entity, new
                {
                    value,
                    caster,
                    type
                });
            }
        }

        //Conditions
        public void ApplyCondition(Condition c)
        {
            if (!IsDead)
            {
                foreach (var condition in Conditions)
                {
                    if (condition.Type == c.Type)
                    {
                        // condition.Refresh(this, c.Dealer, c.Lifetime, c.Value);
                        // OnConditionChanged.OnNext(condition);
                        return;
                    }
                }

                Conditions.Add(c);
                Conditions.Last().Apply(this);
            }
        }

        public bool HasCondition(ConditionType conditionType)
        {
            foreach (var condition in Conditions)
            {
                if (conditionType == condition.Type)
                    return true;
            }

            return false;
        }

        public void RemoveCondition(int index)
        {
            if (index >= 0 && index < Conditions.Count)
            {
                Conditions[index].Remove(this);
                Conditions[index] = null;
                Conditions = Conditions.Where(v => v != null).ToList();
            }
        }

        // Buffs and Debuffs
        public void ApplyBuffDebuff(BuffDebuff c)
        {
            if (!IsDead)
            {
                foreach (var buffsDebuff in BuffDebuffs)
                {
                    if (buffsDebuff.Type == c.Type)
                    {
                        buffsDebuff.Refresh(this, c.Lifetime);
                        OnBuffDebuffChanged.OnNext(buffsDebuff);
                        return;
                    }
                }

                c.Action.EffectOnCast(this);
                BuffDebuffs.Add(c);
                BuffDebuffs.Last().Apply(this);
            }
        }

        public bool HasBuffDebuff(BuffDebuffStates type)
        {
            return BuffsDebuffsState.HasFlag(type);
        }

        public void RemoveBuffDebuff(int index)
        {
            if (index >= 0 && index < BuffDebuffs.Count)
            {
                BuffDebuffs[index].Action.RemoveEffect(this);
                BuffDebuffs[index].Remove(this);
                BuffDebuffs[index] = null;
                BuffDebuffs = BuffDebuffs.Where(v => v != null).ToList();
            }
        }

        //Packets
        public void SendInfo(Entity entity)
        {
            Packet.Get(ServerPacketType.CreateEntity)?.Send(entity, this);
        }

        public void Say(string message, string color = "255,255,255,255")
        {
            var entities = new HashSet<Entity>(AreaOfInterest) { this };

            foreach (var entity in entities)
            {
                Packet.Get(ServerPacketType.Say)?.Send(entity, new
                {
                    speaker = this,
                    message = message,
                    color = color
                });
            }
        }

    }
}
