#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    float colliderHeight;
    float colliderRadius;
    csl::math::Vector3 colliderOffset;
    float explodeRadius;
    float distanceStartCurve;
    float distanceEndCurve;
    float inducedExplosionTimePerDistance;
}
ObjSkierMissileConfig;

