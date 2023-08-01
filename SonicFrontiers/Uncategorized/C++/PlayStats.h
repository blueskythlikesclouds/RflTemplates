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
    cstring stagecode;
    int32_t highTime;
    int32_t highScore;
}
PlayStatsSummary;

typedef struct
{
    cstring stagecode;
    cstring play;
    cstring option;
    csl::math::Vector3 position;
    float time;
}
PlayLog;

typedef struct
{
    int32_t enemies;
    int32_t damages;
    int32_t misses;
    int32_t retry;
    int32_t restart;
    PlayLog logs;
}
PlayStatsData;

typedef struct
{
    cstring username;
    cstring time;
    PlayStatsSummary summaries;
    PlayStatsData playLog;
}
PlayStats;

