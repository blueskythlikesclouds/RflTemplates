#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

enum LaserType : int8_t
{
    LT_NONE = 0,
    LT_STRAIGHT = 1,
    LT_HOMING = 2
};

typedef struct
{
    float hpRatio;
    LaserType type;
}
BossRifleThresholdRingSupplyParam;

