#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    bool enable;
    float width;
    float normalOffset;
    float blurOffsetMax;
    csl::math::Vector4 strength[16];
}
FxSeparableSSSParameter;

