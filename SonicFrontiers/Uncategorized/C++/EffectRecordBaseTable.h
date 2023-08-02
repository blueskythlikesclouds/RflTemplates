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
    cstring emitterSetName[5];
}
EffectRecord;

typedef struct
{
    EffectRecord data[100];
}
EffectRecordBaseTable;
