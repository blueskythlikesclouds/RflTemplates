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
    float changeTimeIdlePatrolMin;
    float changeTimeIdlePatrolMax;
}
EnemyDefenderPatrolConfig;

typedef struct
{
    RingParameter ringParam;
    float mass;
    float slopeAngleMax;
    float checkBarrierDistance;
    float colliderRadius;
    float colliderHeight;
    float damageColliderRadiusOffset;
    float boomerangColliderRadius;
    float boomerangColliderHeight;
    float boomerangColliderOffset;
    float boomerangCameraKeepTimeMin;
    float eyesightDistance;
    float eyesightLostDelayTime;
    EnemyDefenderPatrolConfig patrolConfig;
    float shieldBlowUpTime;
    float shieldBlowUpHeight;
    float shieldBoomerangSpeed;
    float shieldBoomerangMinDistance;
    float shieldBoomerangMaxDistance;
    float killWaitTime;
    float cameraDistance;
    float cameraElevation;
    int32_t parryBoomerangRound;
    float parryBoomerangOffset;
    float parryBoomerangSpeed;
}
EnemyDefenderCommonConfig;

typedef struct
{
    int32_t maxHealthPoint;
    float attackRate;
    uint16_t expItemNum;
    uint16_t exp;
}
DefenderCommonLevelConfig;

typedef struct
{
    int32_t level;
    DefenderCommonLevelConfig common;
}
EnemyDefenderLevelConfig;

typedef struct
{
    EnemyDefenderCommonConfig commonParams;
    EnemyDefenderLevelConfig levelParams[5];
}
EnemyDefenderConfig;

