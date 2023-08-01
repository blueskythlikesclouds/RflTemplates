#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

enum Checker : int8_t
{
    InvalidChecker = -1,
    CountActions = 0,
    CountAirTrick = 1,
    CountControlCamera = 2,
    CountInfinityCombo = 3,
    CountFiveCombo = 4,
    NumCheckers = 5
};

enum Type : uint8_t
{
    None = 0,
    ControlCamera = 1,
    Cyloop = 2,
    QuickCyloop = 3,
    FocusCamera = 4,
    Parry = 5,
    Avoid = 6,
    AcceleCombo = 7,
    Crasher = 8,
    HomingShot = 9,
    StompingAttack = 10,
    SonicBoom = 11,
    SpinSlash = 12,
    LoopKick = 13,
    CrossSlash = 14,
    ChargeAttack = 15,
    Smash = 16,
    RecoverySmash = 17,
    Jump = 18,
    DoubleJump = 19,
    HomingAttack = 20,
    Boost = 21,
    Stomping = 22,
    BoundStomping = 23,
    AirBoost = 24,
    QuickStep = 25,
    LightDash = 26,
    DropDash = 27,
    Sliding = 28,
    WallRun = 29,
    Discontinued = 30,
    AirTrick = 31,
    AirTrickEnd = 32,
    CancelHomingAttackBounceStomping = 33,
    CancelAirBoostStomping = 34,
    Squat = 35,
    SpinBoostCharge = 36,
    SpinBoost = 37,
    RunToSpinBoost = 38,
    Num = 39
};

enum Judge : int8_t
{
    Succeed = 0,
    Failed = 1,
    Skiped = 2,
    Waiting = 3,
    Unknown = 4,
    NumJudges = 5
};

typedef struct
{
    const char* pValue;
    INSERT_PADDING(8);
}
cstring;

typedef struct
{
    Type action;
    Judge dummy;
    uint64_t skipableActions;
    cstring label;
}
PracticeAction;

typedef struct
{
    uint32_t skill;
    uint64_t clearedSubject;
    uint64_t clearedSubject2;
    uint64_t clearedSubject3;
    uint64_t clearedSubject4;
    bool unlockSpinBoost;
}
PracticePrerequisite;

typedef struct
{
    Checker checker;
    PracticeAction actions[6];
    int32_t count;
    PracticePrerequisite prerequisite;
    uint8_t options;
}
PracticeSubject;

typedef struct
{
    cstring labels[10];
}
PracticeText;

typedef struct
{
    float readyTime;
    float countTime;
    float subjectViewTime;
    float clearedPostTime;
    float fadeoutWaitTime;
    float rebuildWaitTime1;
    float rebuildWaitTime2;
}
PracticeTime;

typedef struct
{
    uint32_t skill;
    bool tutorialCleared;
    bool unlockArcadeMode;
    bool unlockCyberPowerBoost;
    bool unlockVeryHardMode;
    bool unlockStrongNewGame;
    bool unlockSpinBoost;
}
PracticeTipsPrerequisite;

typedef struct
{
    PracticeTipsPrerequisite prerequisite;
}
PracticeTips;

typedef struct
{
    int8_t subjects[20];
    int16_t tips[100];
}
PracticeSet;

typedef struct
{
    PracticeSubject subjects[200];
    PracticeText text;
    PracticeTime time;
    float notifyTime;
    PracticeTips tips[256];
    float tipsMinViewTime;
    PracticeSet sets[81];
}
PracticeParameters;

