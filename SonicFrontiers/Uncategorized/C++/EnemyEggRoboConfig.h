#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    float scaleSv;
    float scaleFv;
    float appearEffTimer;
    float colliderRadius;
    float colliderHeight;
    csl::math::Vector3 colliderOffset;
    float laserColliderRadius;
    float laserColliderHeight;
    csl::math::Vector3 laserColliderSizeSV;
    float missileColliderRadius;
    float missileColliderHeight;
    csl::math::Vector3 missileColliderOffset;
}
EnemyEggRoboConfig;

