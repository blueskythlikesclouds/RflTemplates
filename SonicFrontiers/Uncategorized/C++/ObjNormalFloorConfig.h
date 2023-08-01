#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    float length;
    float width;
    float height;
}
NormalFloorSize;

typedef struct
{
    NormalFloorSize sizeInfo[10];
}
ObjNormalFloorConfig;

