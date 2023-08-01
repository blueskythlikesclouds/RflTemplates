#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    float rotateSpeedMin;
    float rotateSpeedMax;
    float speedMin;
    float speedMax;
    float changeTimeIdlePatrolMin;
    float changeTimeIdlePatrolMax;
    float lockonDistance;
    float unlockDistance;
    float distance;
    float minElevation;
    float maxElevation;
    float panningSuspensionK;
    float interiorPanningSuspensionK;
}
EnemyJumperPatrolConfig;

typedef struct
{
    float distance;
    float lockOnMinDistance;
    csl::math::Vector3 playerOffset;
}
EnemyJumperAutoLockonParam;

typedef struct
{
    float killWaitTime;
    float colliderRadius;
    float colliderHeight;
    float headRadius;
    float headHeight;
    float damageColliderRadiusOffset;
    float eyesightDistance;
    float maxSpeed;
    float checkBarrierDistance;
    EnemyJumperPatrolConfig patrolConfig;
    EnemyJumperAutoLockonParam lockonCamera;
}
EnemyJumperCommonParam;

typedef struct
{
    int32_t maxHealthPoint;
    float attackRate;
    uint16_t expItemNum;
    uint16_t exp;
}
EnemyJumperCommonLevelParam;

typedef struct
{
    int32_t level;
    EnemyJumperCommonLevelParam common;
}
EnemyJumperLevelParam;

typedef struct
{
    int32_t level;
}
EnemyJumperLevelBand;

typedef struct
{
    float height;
    float radius;
    csl::math::Vector3 offset;
    csl::math::Vector3 scale;
}
CharacterControllerCollision;

typedef struct
{
    float rotateSpeedMin;
    float rotateSpeedMax;
    float speedMin;
    float speedMax;
}
MovementParam;

typedef struct
{
    float velocity;
    float targetCursorMaxDistance;
}
SpringPlayer;

typedef struct
{
    float stompingRange;
    float stompingTotalNum;
    float interpalTimeFinal;
    float range;
    float riseDistance;
    float riseTime;
    float upLoopTime;
    float chaseSpeed;
    float speed;
    float groundImpactRadius;
    SpringPlayer springPlayer;
}
BattleParam;

typedef struct
{
    EnemyJumperCommonParam commonParam;
    EnemyJumperLevelParam levelParams[5];
    EnemyJumperLevelBand levelBand[5];
    CharacterControllerCollision characterControllerCollision;
    MovementParam movement;
    BattleParam battleParam;
}
EnemyJumperConfig;

