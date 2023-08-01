#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    uint8_t columns[5];
}
FSRow;

typedef struct
{
    FSRow rows[5];
}
FSLayer;

typedef struct
{
    uint8_t numLayers;
    uint8_t numRows;
    uint8_t numColumns;
    csl::math::Vector3 offsetToTopLeft;
    FSLayer layers[5];
}
FreeShape;

typedef struct
{
    FreeShape freeShapes[29];
}
Obj3DPuzzleBlockConfig;

