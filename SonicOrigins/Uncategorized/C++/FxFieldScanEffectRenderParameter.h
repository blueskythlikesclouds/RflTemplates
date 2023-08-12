#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    uint8_t alpha;
    uint8_t red;
    uint8_t green;
    uint8_t blue;
}
color8;

typedef struct
{
    bool enable;
    csl::math::Vector3 centerPos;
    color8 color;
    float radius1;
    float radius2;
    float radius3;
    float intensity1;
    float intensity2;
    float intensity3;
    float gridIntensity;
    float innerWidth;
    float gridLineWidth;
    float gridLineSpan;
}
FxFieldScanEffectRenderParameter;

