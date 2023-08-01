#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

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
    RingParameter ringParam;
    int32_t codeDropNumMin;
    int32_t codeDropNumMax;
    int32_t codeXDropNumMin;
    int32_t codeXDropNumMax;
    float eyesightDistancePatrol;
    float eyesightDistanceBattle;
    float hideCoreDistance;
    float showCoreDistance;
    float guardShotWaitTime;
    float guardShotAngle;
    float aimBendSpeed;
    float muzzleShrinkStartDist;
    float muzzleShrinkEndDist;
    float snipeMaxAngle;
    float guardMaxAngle;
}
EnemySniperCommonConfig;

typedef struct
{
    int32_t maxHealthPoint;
    int32_t maxGuardPoint;
    float stunTime;
    float attackRate;
    uint16_t expItemNum;
    uint16_t exp;
    float snipeRotateSpeed;
    float chargeRotateSpeed;
    float predictRotateSpeed;
    float snipeWaitTime;
    float snipeShotSpeed;
    float snipeIntervalTime;
    float predictTime;
    float predictAngleRange;
    float guardShotSpeed;
    float guardShotRotateSpeed;
    float guardShotMotionSpeed;
    float guardShotLifeTime;
}
SniperCommonLevelConfig;

typedef struct
{
    int32_t level;
    SniperCommonLevelConfig common;
}
EnemySniperLevelConfig;

typedef struct
{
    int32_t dummy;
}
SniperCommonActionConfig;

typedef struct
{
    int32_t level;
    SniperCommonActionConfig common;
}
EnemySniperLevelBandConfig;

typedef struct
{
    EnemySniperCommonConfig commonParams;
    EnemySniperLevelConfig levelParams[5];
    EnemySniperLevelBandConfig levelBands[5];
}
EnemySniperConfig;

