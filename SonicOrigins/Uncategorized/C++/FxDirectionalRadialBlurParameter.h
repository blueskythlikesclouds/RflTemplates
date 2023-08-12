#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    bool enable;
    csl::math::Vector3 center;
    csl::math::Vector3 direction;
    float blurPowerMax;
    float blurPowerMin;
    float focusRange;
    float alphaSlope;
    int32_t sampleNum;
}
FxDirectionalRadialBlurParameter;

