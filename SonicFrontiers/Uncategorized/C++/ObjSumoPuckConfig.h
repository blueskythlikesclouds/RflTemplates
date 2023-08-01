#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    float mass;
    float slopeAngleMax;
    float stairHeightMax;
    float colliderRigidHeight;
    float colliderRigidRadius;
    float colliderEventHeight;
    float colliderEventRadius;
    float colliderOffsetHeightSlingshot;
    float explodeRadius;
    float bumperBlowSpeed;
    float bumperOCTime;
    int32_t damageToEnemy;
    float lifeTimeParried;
    float decelerationParried;
}
ObjSumoPuckConfig;

