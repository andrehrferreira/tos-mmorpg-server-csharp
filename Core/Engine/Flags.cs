namespace Server
{
    [Flags]
    public enum EntityStates
    {
        None = 0,
        Stunned = 1 << 1,
        Dead = 1 << 2,
        Ally = 1 << 3,
        Enemy = 1 << 4,
        NegativeKarma = 1 << 5,
        Burning = 1 << 6,
        Bleeding = 1 << 7,
        Poisoned = 1 << 8,
        Party = 1 << 9,
        Guild = 1 << 10,
        Stealth = 1 << 11,
        Mounted = 1 << 12,
        Feared = 1 << 13,
        Invulnerable = 1 << 14,
        Warmode = 1 << 15,
        Frozen = 1 << 16,
        Untargettable = 1 << 17,
        Frenzy = 1 << 18,
        DuelZone = 1 << 19,
        SafeZone = 1 << 20,
        Admin = 1 << 21,
        Pet = 1 << 22
    }

    [Flags]
    public enum BuffDebuffStates
    {
        None = 0,
        HeavenlyProtection = 1 << 0,
        EchoOfTheDeath = 1 << 1,
        ShatteringImpact = 1 << 2,
        ShatteringImpactEffect = 1 << 3,
        ThunderAura = 1 << 4,
    }

    [Flags]
    public enum ItemStates
    {
        None = 0,
        Blessed = 1 << 0,
        Insured = 1 << 1,
        Exceptional = 1 << 2,
        SpellChanneling = 1 << 3,
        Broken = 1 << 4
    }

    public struct StateFlags
    {
        private int Flags;

        public StateFlags(int initialFlags = 0)
        {
            Flags = initialFlags;
        }

        public StateFlags(EntityStates initialFlags = 0)
        {
            Flags = (int)initialFlags;
        }

        public StateFlags(BuffDebuffStates initialFlags = 0)
        {
            Flags = (int)initialFlags;
        }

        public StateFlags(ItemStates initialFlags = 0)
        {
            Flags = (int)initialFlags;
        }

        public void AddFlag(EntityStates flag)
        {
            Flags |= (int)flag;
        }

        public void AddFlag(BuffDebuffStates flag)
        {
            Flags |= (int)flag;
        }

        public void AddFlag(ItemStates flag)
        {
            Flags |= (int)flag;
        }

        public void RemoveFlag(EntityStates flag)
        {
            Flags &= ~(int)flag;
        }

        public void RemoveFlag(BuffDebuffStates flag)
        {
            Flags &= ~(int)flag;
        }

        public void RemoveFlag(ItemStates flag)
        {
            Flags &= ~(int)flag;
        }

        public bool HasFlag(EntityStates flag)
        {
            return (Flags & (int)flag) == (int)flag;
        }

        public bool HasFlag(BuffDebuffStates flag)
        {
            return (Flags & (int)flag) == (int)flag;
        }

        public bool HasFlag(ItemStates flag)
        {
            return (Flags & (int)flag) == (int)flag;
        }

        public bool DontHasFlag(EntityStates flag)
        {
            return !HasFlag(flag);
        }

        public bool DontHasFlag(BuffDebuffStates flag)
        {
            return !HasFlag(flag);
        }

        public bool DontHasFlag(ItemStates flag)
        {
            return !HasFlag(flag);
        }

        public int GetCurrentFlags()
        {
            return Flags;
        }
    }
}
