#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    bool enable;
    bool enableMultiHeightmap;
    bool debugDrawFrustum;
    bool reprojection;
    uint32_t renderTargetWidth;
    uint32_t renderTargetHeight;
    float referenceValue;
    float heightScale;
    float fadeTime;
    float colorMask;
    csl::math::Matrix44 viewMatrix;
    csl::math::Matrix44 projMatrix;
}
FxHeightMapParameter;

