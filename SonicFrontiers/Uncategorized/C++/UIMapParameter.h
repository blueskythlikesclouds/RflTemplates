#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    int32_t challengeID[40];
}
ChallengeID1DimParameter;

typedef struct
{
    ChallengeID1DimParameter challengeIDHorizonGridGroup[40];
}
IslandMapParameter;

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
    int32_t id;
    color8 color;
}
IDColor;

typedef struct
{
    IslandMapParameter islandMapParam[5];
    IDColor idColors[136];
}
UIMapParameter;

