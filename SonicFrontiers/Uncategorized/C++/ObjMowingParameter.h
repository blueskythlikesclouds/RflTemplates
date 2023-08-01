#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    float radius;
}
ObjMowingGrassParameter;

typedef struct
{
    float modelScale;
    float capsuleRadiusSprouts;
    float capsuleRadiusFlower;
    float capsuleHeightSprouts;
    float capsuleHeightFlower;
    csl::math::Vector3 effectOffsetSprouts;
    csl::math::Vector3 effectOffsetFlower;
    float beeAttractDist;
    float efficacyTimeFlower;
}
ObjBeeFlowerParameter;

typedef struct
{
    csl::math::Vector3 targetOffset;
    csl::math::Vector3 targetOffsetFlower;
    float collRadius;
    float modelScale;
    float beeMoveSpeed;
    float reflectionAngle;
    float coefAverage;
    float coefCenter;
    float coefRepulse;
    float waitTimeAfterAttack;
    float waitTimeAfterFlower;
}
ObjBeeSwarmParameter;

typedef struct
{
    ObjMowingGrassParameter grassParam;
    ObjBeeFlowerParameter beeFlowerParam;
    ObjBeeSwarmParameter beeSwarm;
}
ObjMowingParameterElement;

typedef struct
{
    ObjMowingParameterElement element[3];
}
ObjMowingParameter;

