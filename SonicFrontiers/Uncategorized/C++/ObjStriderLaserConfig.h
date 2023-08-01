#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    float alpha;
    float red;
    float green;
    float blue;
}
colorF;

typedef struct
{
    uint8_t alpha;
    uint8_t red;
    uint8_t green;
    uint8_t blue;
}
color8;

typedef struct
{
    float arrivalTime;
    uint8_t numPatterns;
    float radius;
    float tilingDistance;
    float fluctuationPeriod;
    float fluctuationAmplitude;
    float uvScrollSpeed;
    colorF colorPrimary;
    color8 colorVertexEdge;
    color8 colorVertexCenter;
    float colorIntensity;
    float patternChangeIntervalTime;
    float edgeWidthScale;
    float edgeWidthScaleLength;
}
ArcLaserConfig;

typedef struct
{
    float lifeTime;
    float degreeVelocityPrePostLaser;
    float degreeVelocity;
    float degreeToRotate;
    float radius;
    float collisionRadius;
    float minStartingPointOffset;
    float maxStartingPointOffset;
    ArcLaserConfig arcLaserConfig;
}
ObjStriderLaserConfig;

