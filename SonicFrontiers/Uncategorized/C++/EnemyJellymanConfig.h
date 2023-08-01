#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    float rotateSpeedMin;
    float rotateSpeedMax;
    float rotateSpeedMaxSpeedMin;
    float rotateSpeedMinSpeedMax;
}
Movement;

typedef struct
{
    float distance;
    float angle;
}
Eyesight;

typedef struct
{
    float attackRange;
    float attackAngle;
    float attackSpeed;
}
Fight;

typedef struct
{
    Movement movement;
    Eyesight eyesight;
    Fight fight;
    float transformRate;
}
EnemyJellymanModeConfig;

typedef struct
{
    EnemyJellymanModeConfig common;
    float actionDistance[5];
}
JellymanHumanCommonConfig;

typedef struct
{
    float suckedTime;
    float launchAngle;
    float launchMaxSpeed;
    float launchMinSpeed;
    float randomRangeMin;
    float randomRangeMax;
    float lifeTime;
}
RingParameter;

typedef struct
{
    const char* pValue;
    INSERT_PADDING(8);
}
cstring;

enum VolumeShape : int8_t
{
    SPHERE = 0,
    BOX = 1,
    CYLINDER = 2,
    CAPSULE = 3,
    NUM = 4
};

typedef struct
{
    csl::math::Vector3 volumeSize;
    csl::math::Vector3 volumeOffset;
    csl::math::Vector3 volumeRotation;
}
VolumeInfo;

typedef struct
{
    cstring tagName;
    int8_t pieceNum;
    float pieceFuncFactor;
    VolumeShape volumeShape;
    cstring humanNodeName;
    VolumeInfo humanVolume;
    cstring eggNodeName;
    VolumeInfo eggVolume;
    bool effectActive;
    bool debugDraw;
    bool debugDrawVolumeAxis;
    bool debugDrawAxis;
}
MappingPairInfo;

typedef struct
{
    JellymanHumanCommonConfig human;
    RingParameter ringParam;
    int32_t codeDropNumMin;
    int32_t codeDropNumMax;
    int32_t codeXDropNumMin;
    int32_t codeXDropNumMax;
    MappingPairInfo mappingPairInfo[32];
}
EnemyCommonConfig;

typedef struct
{
    int32_t maxHealthPoint;
    float maxStunPoint[3];
    float stunDecreaseStartTime;
    float stunDecreaseSpeed;
    float maxStaggerPoint[3];
    float staggerDecreaseStartTime;
    float staggerDecreaseSpeed;
    float stunTime;
    float attackRate;
    float attackMotionSpeed;
    uint16_t expItemNum;
    uint16_t exp;
}
JellymanCommonLevelConfig;

typedef struct
{
    float wallTime;
    int32_t wallLife;
    float guardTime;
    float guardCoolTime;
}
JellymanHumanLevelConfig;

typedef struct
{
    int32_t level;
    JellymanCommonLevelConfig common;
    JellymanHumanLevelConfig human;
}
EnemyLevelConfig;

enum SuperArmorType : int8_t
{
    None = 0,
    Attack = 1,
    Always = 2
};

typedef struct
{
    SuperArmorType superArmor;
    bool isTransform;
    float downTime;
}
JellymanCommonActionConfig;

typedef struct
{
    float actionRate[5];
}
JellymanHumanActionRate;

typedef struct
{
    JellymanHumanActionRate rateTable[4];
    float coolTime[5];
    float attackCoolTime;
    float nearRange;
    int32_t nearRateId;
    int32_t farRateId;
    bool isCounterGuard;
    bool isCounterWall;
    bool isSpikeWall;
    int32_t waveNum;
    float waveUpTime;
    float waveLifeTime;
    float waveDownTime;
    float waveRadius;
    float waveAddRadius;
    float waveSpawnTime;
    float waveKeepRadius;
    float waveHeight;
    int32_t rushNum;
}
JellymanHumanActionConfig;

typedef struct
{
    int32_t level;
    JellymanCommonActionConfig common;
    JellymanHumanActionConfig human;
}
EnemyLevelBandConfig;

typedef struct
{
    int32_t level;
    int32_t maxActionCount;
    float spAttackWaitTime;
    int32_t humanMaxActionCount[5];
}
EnemySquadAvarageLevelConfig;

typedef struct
{
    EnemySquadAvarageLevelConfig averageLevelConfig[5];
}
EnemySquadConfig;

typedef struct
{
    EnemyCommonConfig commonParams;
    EnemyLevelConfig levelParams[8];
    EnemyLevelBandConfig levelBands[5];
    EnemySquadConfig squadParams;
}
EnemyJellymanConfig;

