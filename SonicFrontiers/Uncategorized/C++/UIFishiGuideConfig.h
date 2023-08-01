#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    csl::math::Vector3 position;
    csl::math::Vector3 target;
    float fovy;
}
FishCameraParam;

typedef struct
{
    FishCameraParam fishList[105];
}
UIFishiGuideConfig;

