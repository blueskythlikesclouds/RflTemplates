#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

enum Value : int8_t
{
    Invalid = -1,
    Sonic = 0,
    Amy = 1,
    Knuckles = 2,
    Tails = 3,
    Num = 4,
    Default = 0
};

typedef struct
{
    bool autoSaveEnabled;
    bool gismoEnabled;
    bool reportEnabled;
    bool skillTreeEnabled;
    bool tutorialEnabled;
    bool arcadeModeEnabled;
    bool battleModeEnabled;
    bool cyberChallengeEnabled;
    bool practice;
    bool practiceTimeLimitEnabled;
    bool creditsEnabled;
    Value character;
}
DevConfigParameters;

