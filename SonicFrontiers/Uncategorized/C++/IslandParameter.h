#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    bool isEnable;
    int8_t useKeyNum;
}
ChaosEmeraldStorageParam;

typedef struct
{
    ChaosEmeraldStorageParam storages[7];
}
IslandParam;

typedef struct
{
    float takableRange;
    float fadeTime;
    float chestJumpOutFadeTime;
    float tutorialDelayTime;
}
KodamaCommonParam;

typedef struct
{
    int8_t maxFollowNum;
    float speed;
    float rotateSpeed;
    float stopDistance;
    float vanishDistance;
    float respawnStandTime;
}
KodamaFollowParam;

typedef struct
{
    KodamaCommonParam common;
    KodamaFollowParam follow;
}
KodamaNormalParam;

typedef struct
{
    int32_t levelupKodamaNum[3];
}
KodamaElderParam;

typedef struct
{
    int32_t difficulty[3];
}
KodamaHermitLvUpParam;

typedef struct
{
    KodamaHermitLvUpParam levelupSeedNum[99];
}
KodamaHermitParam;

typedef struct
{
    float takableRange;
    float colliderRange;
    float fadeTime;
    float spaceVertical;
    float spaceHorizontal;
}
KodamaNewFormParam;

typedef struct
{
    KodamaNormalParam normal;
    KodamaElderParam elder;
    KodamaHermitParam hermit;
    KodamaNewFormParam newform[8];
}
KodamaParam;

typedef struct
{
    int32_t inputSequenceItemNumShort;
    int32_t inputSequenceItemNumMiddle;
}
NpcParam;

typedef struct
{
    IslandParam islands[5];
    KodamaParam kodama;
    NpcParam npc;
    int32_t portalExtraKeyNum;
}
IslandParameter;

