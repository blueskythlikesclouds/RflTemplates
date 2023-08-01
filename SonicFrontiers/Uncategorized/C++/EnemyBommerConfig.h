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
    float rotationDeceleration;
    float rotationAngleMax;
    float changeTimeIdlePatrolMin;
    float changeTimeIdlePatrolMax;
}
EnemyBommerPatrolConfig;

typedef struct
{
    float moveDecerleration;
    float rotationAngleMax;
    float chargeTime;
    float rotateSpeed;
}
EnemyBommerAimingConfig;

typedef struct
{
    float moveVelocity;
    float moveDecerleration;
    float moveDecelerationDamaged;
    float cooldownTime;
    float colliderOffsetRate;
}
EnemyBommerAttackConfig;

typedef struct
{
    float moveVelocity;
    float moveAccerleration;
    float amplitude;
    float period;
    float rotateSpeedInFront;
    float rotateSpeedOnBack;
    float chaseTime;
    float parriedMoveDistance;
    float parriedShortenTime;
    float parriedCoolDownTime;
    float colliderOffsetRate;
    float cameraDistance;
    float cameraElevation;
}
EnemyBommerChaseConfig;

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
    float mass;
    float slopeAngleMax;
    float checkBarrierDistance;
    float colliderRadius;
    float colliderHeight;
    float damageColliderRadiusOffset;
    float eyesightDistance;
    float eyesightDistanceMargin;
    EnemyBommerPatrolConfig patrolConfig;
    EnemyBommerAimingConfig aimingConfig;
    EnemyBommerAttackConfig attackConfig;
    EnemyBommerChaseConfig chaseConfig;
    float explodeSignalTime;
    float explodeColliderRadius;
    bool useUniqueDebrisSetting;
    DebrisParameter debrisExplode;
    DebrisParameter debrisCyloop;
}
EnemyBommerCommonConfig;

typedef struct
{
    int32_t maxHealthPoint;
    float attackRate;
    uint16_t expItemNum;
    uint16_t exp;
}
BommerCommonLevelConfig;

typedef struct
{
    int32_t level;
    BommerCommonLevelConfig common;
}
EnemyBommerLevelConfig;

typedef struct
{
    EnemyBommerCommonConfig commonParams;
    EnemyBommerLevelConfig levelParams[5];
}
EnemyBommerConfig;

