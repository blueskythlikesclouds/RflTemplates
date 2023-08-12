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
    color8 clientColor;
    uint8_t windowAlpha;
    color8 startGradationGuideColor;
    color8 endGradationGuideColor;
}
DecoConfigParam;

