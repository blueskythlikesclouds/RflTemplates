#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

enum ReplayMode : int8_t
{
    REPLAY_MODE_OFF = 0,
    REPLAY_MODE_RECORD = 1,
    REPLAY_MODE_PLAY = 2,
    REPLAY_MODE_GHOST = 3
};

typedef struct
{
    bool autoSaveEnabled;
    bool gismoEnabled;
    bool reportEnabled;
    bool skillTreeEnabled;
    bool tutorialEnabled;
    ReplayMode replayMode;
}
DevConfigParameters;

