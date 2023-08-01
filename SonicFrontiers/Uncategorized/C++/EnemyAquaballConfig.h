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
    float rotateSpeedMin;
    float rotateSpeedMax;
    float speedMin;
    float speedMax;
    float moveSpeed;
    float bounceHeight;
    float bounceInterval;
    float movePointUpdateInterval;
    float addForceOfHA;
}
EnemyAquaballPatrolConfig;

typedef struct
{
    int32_t maxSuccessCount;
    csl::math::Vector2 bounceSuccessTiming[3];
    float captureLimitTime;
    float captureLimitHeight;
    float failLimitTime;
    float failNoticeTime;
}
EnemyAquaballActionConfig;

typedef struct
{
    float killWaitTime;
    float colliderRadius;
    float colliderHeight;
    float damageColliderRadiusOffset;
    float hitPlayerColliderRadiusOffset;
    float checkBarrierDistance;
    float battleDistance;
    RingParameter ringParam;
    EnemyAquaballPatrolConfig patrolConfig;
    EnemyAquaballActionConfig actionConfig;
}
EnemyAquaballCommonParam;

typedef struct
{
    int32_t maxHealthPoint;
    float attackRate;
    uint16_t expItemNum;
    uint16_t exp;
}
EnemyAquaballCommonLevelParam;

typedef struct
{
    int32_t level;
    EnemyAquaballCommonLevelParam common;
}
EnemyAquaballLevelParam;

typedef struct
{
    int32_t level;
}
EnemyAquaballLevelBand;

typedef struct
{
    EnemyAquaballCommonParam commonParam;
    EnemyAquaballLevelParam levelParams[5];
    EnemyAquaballLevelBand levelBand[5];
}
EnemyAquaballConfig;

