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
    float requestTime;
    float accessDistance;
    uint32_t numRings[3];
}
ObjBossRingSupplyConfig;

