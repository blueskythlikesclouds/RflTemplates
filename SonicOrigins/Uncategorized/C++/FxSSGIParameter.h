#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    bool useDenoise;
    float rayLength;
}
FxSSGIDebugParameter;

typedef struct
{
    bool enable;
    float intensity;
    bool useAlbedo;
    bool useParameter;
    FxSSGIDebugParameter debugParam;
}
FxSSGIParameter;

