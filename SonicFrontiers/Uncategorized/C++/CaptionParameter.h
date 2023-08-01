#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

enum DisplayType : int8_t
{
    Caption = 0,
    Tutorial = 1
};

typedef struct
{
    const char* pValue;
    INSERT_PADDING(8);
}
cstring;

typedef struct
{
    DisplayType display;
    cstring label;
    float waitTime;
}
LabelData;

typedef struct
{
    LabelData labels[20];
    bool isForcePlay;
}
Discussion;

typedef struct
{
    Discussion discussions[10];
}
CaptionParameter;

