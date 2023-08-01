#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

enum StatsType : int32_t
{
    TYPE_INVALID = 0,
    TYPE_UINT64 = 1,
    TYPE_UINT32 = 2,
    TYPE_SINT32 = 3,
    TYPE_FLOAT = 4
};

typedef struct
{
    StatsType type;
    uint64_t value;
}
StatsDataValue;

typedef struct
{
    StatsDataValue data;
}
StatsDataContainer;

