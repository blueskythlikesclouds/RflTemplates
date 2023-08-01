#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    float targetRadius;
    float catchDistance;
    float linearDamping;
    float angularDamping;
    float appearDelay;
}
ObjShotGunTouchTargetParam;

typedef struct
{
    csl::math::Vector3 cameraOffset;
    float cameraHoldTime;
}
ObjShotGunTouchCameraParam;

typedef struct
{
    ObjShotGunTouchTargetParam targetParam;
    ObjShotGunTouchCameraParam cameraParam;
}
ObjShotGunTouchParam;

