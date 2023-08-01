#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    uint16_t hpS;
    uint16_t hpM;
    uint16_t hpL;
    float colliderRadius;
    float colliderHeight;
    float modelScale;
}
HackingEnemyParameterNormal;

typedef struct
{
    float colliderRadius;
    float colliderHeight;
    float modelScale;
}
HackingEnemyParameterCore;

typedef struct
{
    HackingEnemyParameterNormal normalEnemyParam;
    HackingEnemyParameterCore coreEnemyParam;
}
HackingEnemyParameters;

