#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    uint32_t scoreS;
    uint32_t scoreA;
    uint32_t scoreB;
    uint32_t scoreC;
}
ActionChainScoreThresholdParameter;

typedef struct
{
    float time;
    ActionChainScoreThresholdParameter scoreEasy;
    ActionChainScoreThresholdParameter scoreNormal;
    ActionChainScoreThresholdParameter scoreHard;
    ActionChainScoreThresholdParameter scoreVeryHard;
}
ActionChainPlaceParameter;

typedef struct
{
    ActionChainPlaceParameter placeParam[16];
}
ActionChainStageParameter;

