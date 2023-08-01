#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

enum SeedType : uint8_t
{
    SeedSensor = 0,
    ObjItem = 1
};

typedef struct
{
    float suckedTime;
    SeedType seedType;
}
SeedParameter;

