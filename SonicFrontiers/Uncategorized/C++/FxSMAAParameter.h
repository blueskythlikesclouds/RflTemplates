#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

enum Preset : int8_t
{
    PRESET_SPEED = 0,
    PRESET_QUALITY = 1
};

enum TestMode : int8_t
{
    TEST_MODE_DISABLE = 0,
    TEST_MODE_1 = 1,
    TEST_MODE_2 = 2
};

typedef struct
{
    Preset preset;
    TestMode testMode;
}
FxSMAAParameter;

