#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    float bulletSpeed;
    float bulletRotDegPerSec;
    float jumpToCenterTime;
    float jumpTime;
    float jumpToCenterTangentY;
    float jumpTangentMultiplier;
    float jumpDestinationOffsetY;
    float jumpDestinationOffsetXZ;
    float jumpToFloorHeight;
    float jumpToFloorOffset;
    float jumpToFloorTime;
    float bulletWaitTime;
    float timeTilDisappear;
    float segmentLength;
    float collisionHeight;
    float collisionRadiusAddend;
    float initialEffectScaleY;
    float initialEffectScaleXZ;
    float maxEffectScaleXZ;
    float timeToMaxEffectScale;
}
ObjStriderGrindRailConfig;

