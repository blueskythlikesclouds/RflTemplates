#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

enum QualityType : int8_t
{
    QUALITY_LOW = 0,
    QUALITY_MEDIUM = 1,
    QUALITY_HIGH = 2,
    QUALITY_COUNT = 3
};

typedef struct
{
    QualityType qualityType;
}
FxFXAAParameter;

