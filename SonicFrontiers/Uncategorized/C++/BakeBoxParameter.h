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
    cstring name;
    csl::math::Vector3 center;
    csl::math::Vector3 halfExtents;
}
BakeBoxParameter;

