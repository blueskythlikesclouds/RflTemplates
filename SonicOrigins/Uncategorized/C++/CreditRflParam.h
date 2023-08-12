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
    float timeIn;
    float timeRunning;
    float timeOut;
}
StuffRollTime;

typedef struct
{
    float timeIn;
    float timeRunning1;
    float timeRunningCD;
    float timeRunning2;
    float timeRunning3K;
    float timeRunningHite;
}
DecoAndMovieTime;

enum TextDecoType : int8_t
{
    position = 0,
    name = 1,
    category = 2,
    logo = 3,
    empty = 4,
    num = 5,
    min = 0,
    max = 4
};

typedef struct
{
    cstring stringLeft;
    cstring stringRight;
    TextDecoType decoType;
    float size;
}
CreditStringDataRflParam;

typedef struct
{
    float position;
    float name;
    float category;
    float empty;
}
TextDecoTypeSize;

typedef struct
{
    float soundVolume;
    cstring movieNames[5];
    StuffRollTime staffRollTime;
    DecoAndMovieTime decoAndMovieTime;
    CreditStringDataRflParam stringData[2048];
    TextDecoTypeSize textDecoTypeSize;
}
CreditRflParam;

