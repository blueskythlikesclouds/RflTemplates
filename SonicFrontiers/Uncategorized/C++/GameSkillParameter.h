#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    uint8_t unlockPoint;
    uint8_t addUnlockPoint;
    bool present;
}
SkillParam;

enum Value : int8_t
{
    Cyloop = 0,
    Smash = 1,
    QuickCyloop = 2,
    AcceleLevel = 3,
    ChargeAttack = 4,
    RecoverySmash = 5,
    AirTrick = 6,
    SonicBoom = 7,
    Crasher = 8,
    LoopKick = 9,
    SpinSlash = 10,
    StompingAttack = 11,
    HomingShot = 12,
    CrossSlash = 13,
    AutoCombo = 14,
    Dummy0 = 15,
    Dummy1 = 16,
    Dummy2 = 17,
    Dummy3 = 18,
    Dummy4 = 19,
    Num = 20,
    NumUsed = 15,
    Invalid = -1
};

typedef struct
{
    bool down;
    bool left;
    bool right;
}
SkillLinkSetting;

typedef struct
{
    bool enable;
    Value skill;
    SkillLinkSetting link;
}
SkillNodeParam;

typedef struct
{
    SkillNodeParam nodeParams[30];
    int8_t startIndex;
}
SkillTreeParam;

typedef struct
{
    SkillParam skillParams[20];
    SkillTreeParam treeParams;
}
GameSkillParameter;

