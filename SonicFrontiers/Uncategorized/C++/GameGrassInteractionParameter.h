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
    cstring name;
    float radius;
    float height;
    float power;
    bool moveHitEnabled;
}
GameGrassInteractionParameterData;

typedef struct
{
    GameGrassInteractionParameterData data[32];
}
GameGrassInteractionParameter;

