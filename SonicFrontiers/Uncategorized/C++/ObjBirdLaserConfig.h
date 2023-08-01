#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    float speed;
    float maxSpeed;
    float acceleration;
}
SpeedInfo;

typedef struct
{
    SpeedInfo speedInfoToSonic;
    SpeedInfo speedInfoToBird;
    float colliderLength;
    float colliderRadius;
    float lifeTime;
    csl::math::Vector3 laserScale;
}
ObjBirdLaserConfig;

