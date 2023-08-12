#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    bool enable;
    csl::math::Vector4 projectionPlane;
    csl::math::Vector3 lightPosition[4];
    int8_t lightCount;
    float vanishStart;
    float vanishDistance;
    float projectionBias;
    csl::math::Vector3 shadowMapBoxSize;
    csl::math::Vector3 shadowMapBoxOffset;
}
FxPlanarProjectionShadowParameter;

