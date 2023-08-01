#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    float moveMinDistance;
    float moveSpeedMax;
}
EnemyBubbleApproachConfig;

typedef struct
{
    float moveMinDistance;
    float moveSpeedMax;
    float blitzProtectionMaxDistance;
    float blitzProtectionReadyTime;
}
EnemyBubbleBlitzProtectionReadyConfig;

typedef struct
{
    float moveMinDistance;
    float moveSpeedMax;
    float blitzProtectionAttackTime;
    float blitzProtectionIntervalTime;
}
EnemyBubbleBlitzProtectionConfig;

typedef struct
{
    float baseHeight;
    float innerDistance;
    float outerDistance;
    float innerRadius;
    float outerRadius;
    float innerAccelMax;
    float outerAccelMax;
    float innerSpeedMax;
    float outerSpeedMax;
    uint8_t innerNum;
    uint8_t outerNum;
}
EnemyBubbleShellConfig;

typedef struct
{
    float killWaitTime;
    float colliderRadius;
    float damageColliderRadiusOffset;
    float attackColliderRadiusOffset;
    float eyesightDistance;
    float moveAccerleration;
    float moveDeceleration;
    float rotationAngleMax;
    float mass;
    float slopeAngleMax;
    float knockBackTime;
    EnemyBubbleApproachConfig approachConfig;
    EnemyBubbleBlitzProtectionReadyConfig blitzReadyConfig;
    EnemyBubbleBlitzProtectionConfig blitzConfig;
    EnemyBubbleShellConfig shellConfig;
}
EnemyBubbleCommonParam;

typedef struct
{
    int32_t maxHealthPoint;
    float attackRate;
    uint16_t expItemNum;
    uint16_t exp;
}
EnemyBubbleCommonLevelParam;

typedef struct
{
    int32_t level;
    EnemyBubbleCommonLevelParam common;
}
EnemyBubbleLevelParam;

typedef struct
{
    int32_t level;
}
EnemyBubbleLevelBand;

typedef struct
{
    EnemyBubbleCommonParam commonParam;
    EnemyBubbleLevelParam levelParams[5];
    EnemyBubbleLevelBand levelBand[5];
}
EnemyBubbleConfig;

