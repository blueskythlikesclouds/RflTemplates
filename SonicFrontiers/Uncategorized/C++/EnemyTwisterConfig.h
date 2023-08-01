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
    int32_t m_maxNumPieces;
    float gravity;
    float lifeTime;
    float force;
}
DebrisParameter;

typedef struct
{
    RingParameter ringParam;
    float rigidColliderRadius;
    float damageColliderRadius;
    float battleDistance;
    float cyloopHeight;
    float rotateSpeed;
    bool useUniqueDebrisSetting;
    DebrisParameter debris;
}
EnemyTwisterCommonConfig;

typedef struct
{
    int32_t maxHealthPoint;
    float attackRate;
    uint16_t expItemNum;
    uint16_t exp;
}
TwisterCommonLevelConfig;

typedef struct
{
    int32_t level;
    TwisterCommonLevelConfig common;
}
EnemyTwisterLevelConfig;

typedef struct
{
    EnemyTwisterCommonConfig commonParams;
    EnemyTwisterLevelConfig levelParams[5];
}
EnemyTwisterConfig;

