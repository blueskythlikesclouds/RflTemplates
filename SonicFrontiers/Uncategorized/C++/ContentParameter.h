#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    uint8_t recordNo;
    uint8_t numRecords;
}
AddDatabaseInfo;

typedef struct
{
    const char* pValue;
    INSERT_PADDING(8);
}
cstring;

typedef struct
{
    AddDatabaseInfo databases[2];
    cstring stagedata;
}
ContentParameter;

