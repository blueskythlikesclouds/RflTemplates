#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    bool enable;
    csl::math::Vector3 color;
    float intensity;
    float nearDist;
    float farDist;
    float influence;
}
FxDistanceFogParameter;

typedef struct
{
    bool enable;
    csl::math::Vector3 color;
    float intensity;
    float minHeight;
    float maxHeight;
    float nearDist;
    float farDist;
    float influence;
}
FxHeightFogParameter;

typedef struct
{
    FxDistanceFogParameter distanceFogParam;
    FxHeightFogParameter heightFogParam;
}
FxFogParameter;

