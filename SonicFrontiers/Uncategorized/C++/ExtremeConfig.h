#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

enum LineType : int8_t
{
    LINE3 = 0,
    LINE5 = 1,
    LINE_INF = 2
};

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
    LineType lineType;
    float lineWidth;
    float roadLength;
    float speed;
    float barricadeInterval;
    float emergencyDistance;
    csl::math::Vector3 barricadeSize;
    color8 roadColor;
    color8 barricadeColor;
    float cameraFovy;
    float cameraDistance;
    float cameraUpOffset;
    float cameraShakeOffset;
}
ExtremeConfig;

