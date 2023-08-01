#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    uint8_t no;
}
Record;

typedef struct
{
    const char* pValue;
    INSERT_PADDING(8);
}
cstring;

typedef struct
{
    Record record;
    cstring name;
    float baseRate;
    float slashRate;
    float quickRate;
    float stunRate;
    float staggerRate;
}
EnemyDefenceRecord;

typedef struct
{
    EnemyDefenceRecord data[128];
}
EnemyDefenceRecordTable;

