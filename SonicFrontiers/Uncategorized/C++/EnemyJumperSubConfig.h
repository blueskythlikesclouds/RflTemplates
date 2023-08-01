#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    float killWaitTime;
    float colliderRadius;
    float colliderHeight;
    float damageColliderRadiusOffset;
    float eyesightDistance;
}
EnemyJumperSubCommonParam;

typedef struct
{
    int32_t maxHealthPoint;
    float attackRate;
    uint16_t expItemNum;
    uint16_t exp;
}
EnemyJumperSubCommonLevelParam;

typedef struct
{
    int32_t level;
    EnemyJumperSubCommonLevelParam common;
}
EnemyJumperSubLevelParam;

typedef struct
{
    int32_t level;
}
EnemyJumperSubLevelBand;

typedef struct
{
    EnemyJumperSubCommonParam commonParam;
    EnemyJumperSubLevelParam levelParams[5];
    EnemyJumperSubLevelBand levelBand[5];
}
EnemyJumperSubConfig;

