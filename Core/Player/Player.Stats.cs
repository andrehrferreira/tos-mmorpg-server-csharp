using Newtonsoft.Json;

namespace Server
{
    public partial class Player : Humanoid
    {
        public override void CalculateStats()
        {
            MaxLife = 10 + ((Vig + BonusVig) * 5) + (Str + BonusStr);
            MaxStamina = 10 + ((Str + BonusStr) * 2) + ((Dex + BonusDex) * 3) + (Vig + BonusVig);
            MaxMana = 10 + ((Int + BonusInt) * 3);
        }

        public override void AddStatsPoint()
        {
            base.AddStatsPoint();

            Save();
            SaveToDatabase();

            Packet.Get(ServerPacketType.PlayerStatics).Send(this);
        }

        public override void AddStat(Stats stat)
        {
            base.AddStat(stat);

            CalculateStats();

            Save();
            SaveToDatabase();

            Packet.Get(ServerPacketType.PlayerStatics).Send(this);
        }

        public override void RegenStats()
        {
            base.RegenStats();

            if (Stamina <= 0)            
                UpdateEvent(EventType.SprintEnd);            
        }

        public override void OnStatsChange()
        {
            Packet.Get(ServerPacketType.UpdateStats).Send(this);

            Packet.Get(ServerPacketType.PlayerStatics).Send(this);
        }

        public string GetStaticsPlayer()
        {
            var statics = new
            {
                stats = new
                {
                    str = Str,
                    dex = Dex,
                    @int = Int,
                    vig = Vig,
                    agi = Agi,
                    luc = Luc,
                    bstr = BonusStr,
                    bdex = BonusDex,
                    bint = BonusInt,
                    bvig = BonusVig,
                    bagi = BonusAgi,
                    bluc = BonusLuc,
                    l = Life,
                    ml = MaxLife,
                    m = Mana,
                    mm = MaxMana,
                    s = Stamina,
                    ms = MaxStamina
                },
                resistences = new
                {
                    ca = PhysicalResistance,
                    f = FireResistance,
                    c = ColdResistance,
                    p = PoisonResistance,
                    e = EnergyResistance,
                    l = LightResistance,
                    d = DarkResistance
                },
                lr = LifeRegeneration,
                mr = ManaRegeneration,
                sr = StaminaRegeneration,
                bpd = BonusPhysicalDamage,
                bmd = BonusMagicDamage,
                wd = WeaponDamage,
                ws = WeaponSpeed,
                cc = CriticalChance,
                cd = CriticalDamage,
                ar = Armor,
                dr = DamageReduction,
                dc = DodgeChance,
                rpd = ReflectionPhysicalDamage,
                rmd = ReflectionMagicDamage,
                lmc = LowerManaCost,
                fc = FasterCasting,
                cr = CooldownReduction,
                sc = StatsCap,
                sp = StatsPoints
            };

            return JsonConvert.SerializeObject(statics);
        }
    }
}
