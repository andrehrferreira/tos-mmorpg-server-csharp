public enum CreatureType
{
    None,
    Animals,
    Undead,
    NPC,
    Summon,
    Pet,
    Dragon,
    Common,
    Demon
}

public enum CreatureIAState
{
    Idle,
    GoingToSpawn,
    GoingToSpawnTime,
    TeleportToSpawn,
    Patrol,
    FollowingMaster,
    InCombat,
    Dead,
    RunFromTarget
}

public enum CreatureCombatMode
{
    Melee,
    Ranged
}

public enum CreatureTargetMode
{
    Closer,
    ShorterLife,
    DamageCaused
}
