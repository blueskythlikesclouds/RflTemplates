#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    csl::math::Vector3 centerPosOffsetMin;
    csl::math::Vector3 centerPosOffsetMax;
    float range;
    float powerMin;
    float powerMax;
}
ExplosionParameter;

typedef struct
{
    csl::math::Vector3 impulseDir;
    float powerMin;
    float powerMax;
}
ImpulseParameter;

typedef struct
{
    float marginTime;
    float nextTime;
    float gravity;
    float moveStopTime;
    bool damping;
    ExplosionParameter explosionParam;
    ImpulseParameter impulseParam;
}
DebrisPhaseParameter;

typedef struct
{
    DebrisPhaseParameter debrisPhaseParameters[3];
}
EffectDebrisParameter;

typedef struct
{
    EffectDebrisParameter effectDebrisParameters[10];
}
ObjEffectDebrisParameters;

