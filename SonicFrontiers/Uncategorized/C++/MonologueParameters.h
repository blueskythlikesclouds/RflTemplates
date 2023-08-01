#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    const char* pValue;
    INSERT_PADDING(8);
}
cstring;

typedef struct
{
    float playSpanTime;
    cstring labelNames[24];
}
MonologueIslandParameters;

typedef struct
{
    cstring labelNames[4];
}
MonologueMultiTextParameters;

enum Value : int8_t
{
    SteppeIsland1 = 0,
    DesertIsland = 1,
    VolcanicIsland = 2,
    TowerIsland = 3,
    SteppeIsland2 = 4,
    Num = 5,
    ExtraIsland = 5,
    NumInExtra = 6
};

typedef struct
{
    MonologueIslandParameters islands[5];
    MonologueMultiTextParameters multiText;
    int8_t firstTheEndNotifyCount;
    int8_t theEndNotifyCount;
    Value dummy;
}
MonologueParameters;

