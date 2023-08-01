#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    float fadeOutTime;
    float delayTime;
}
CustomMusicTransitInfo;

typedef struct
{
    const char* pValue;
    INSERT_PADDING(8);
}
cstring;

enum MusicType : int8_t
{
    THEME_SONG = 0,
    OTHER = 1
};

typedef struct
{
    cstring cueName;
    float fadeOutTiming;
    bool lock;
    MusicType musicType;
}
CustomMusicInfo;

typedef struct
{
    CustomMusicTransitInfo transitInfo;
    CustomMusicInfo musicInfos[128];
    float idlingViewTime;
}
CustomMusicParameter;

