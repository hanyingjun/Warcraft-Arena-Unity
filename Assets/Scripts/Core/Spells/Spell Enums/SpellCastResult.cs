﻿namespace Core
{
    public enum SpellCastResult
    {
        Success = 0,
        AffectingCombat,
        AlreadyAtFullHealth,
        AlreadyAtFullMana,
        AlreadyAtFullPower,
        BadImplicitTargets,
        BadTargets = 6,
        CantStealth,
        CasterAurastate,
        CasterDead = 9,
        CasterNotExists = 10,
        Confused,
        DontReport,
        Error,
        Falling,
        Fleeing,
        LowLevel,
        Highlevel,
        Immune,
        IncorrectArea,
        Interrupted,
        LevelRequirement,
        LineOfSight,
        Moving = 23,
        NotBehind,
        NotFlying,
        NotHere,
        NotInfront,
        NotInControl,
        NotKnown,
        NotReady = 30,
        NotStanding,
        NoAmmo,
        NoChargesRemain,
        NoComboPoints,
        NoPower,
        NothingToDispel,
        NothingToSteal,
        OnlyStealthed,
        OnlyUnderwater,
        OutOfRange = 40,
        Pacified,
        Possessed,
        Rooted,
        Silenced,
        SpellInProgress,
        SpellUnavailable = 46,
        Stunned,
        TargetDead,
        TargetAurastate,
        TargetEnemy,
        TargetEnraged,
        TargetFriendly,
        TargetIsPlayer,
        TargetNotDead,
        TargetNotPlayer = 55,
        TargetNoPockets,
        TargetNoWeapons,
        TargetNoRangedWeapons,
        TooClose,
        TryAgain,
        VisionObscured,
        DamageImmune,
        PreventedByMechanic,
        BmOrInvisGod = 64,
        CustomError,
        NoValidTargets,
        TargetCannotBeResurrected = 67,
        Unknown
    }
}
