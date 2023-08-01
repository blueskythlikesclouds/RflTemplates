#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    float value;
    float delayTime;
    float fadeTime;
}
BGMVolumeChangeInfo;

typedef struct
{
    BGMVolumeChangeInfo playerStop;
    BGMVolumeChangeInfo playerWalk;
    BGMVolumeChangeInfo playerRun;
    BGMVolumeChangeInfo fishingHitIn;
    BGMVolumeChangeInfo fishingHitOut;
    BGMVolumeChangeInfo musicBoxIn;
    BGMVolumeChangeInfo musicBoxOut;
}
BGMVolumeChangeInfoList;

typedef struct
{
    float value;
    float fadeTime;
}
AisacChangeInfo;

typedef struct
{
    AisacChangeInfo sunny;
    AisacChangeInfo cloudy;
    AisacChangeInfo rainy;
    AisacChangeInfo beginUnderWater;
    AisacChangeInfo finishUnderWater;
}
AisacChangeInfoList;

typedef struct
{
    const char* pValue;
    INSERT_PADDING(8);
}
cstring;

enum Priority : int8_t
{
    PRIORITY_LOW = 0,
    PRIORITY_DEFAULT = 1,
    PRIORITY_HIGH = 2,
    PRIORITY_SUPER_HIGH = 3,
    NUM_PRIORITY = 4,
    PRIORITY_INVALID = -1
};

enum InterruptType : int8_t
{
    INTERRUPT_TYPE_STOP = 0,
    INTERRUPT_TYPE_PAUSE = 1,
    INTERRUPT_TYPE_OVERLAP = 2,
    NUM_INTERRUPT_TYPE = 3
};

typedef struct
{
    cstring cueName;
    int32_t blockId;
    float fadeInTime;
    float fadeOutTime;
    float delayTime;
    cstring aisacName;
    float aisacValue;
    float aisacFadeTime;
    bool isVolumeControl;
    bool isOverlapPlay;
    Priority priority;
    InterruptType interruptType;
}
BGMInfo;

enum BGMTransitInfo_InterruptType : int8_t
{
    BGMTransitInfo_InterruptType_INTERRUPT_TYPE_STOP = 0,
    BGMTransitInfo_InterruptType_INTERRUPT_TYPE_PAUSE = 1,
    BGMTransitInfo_InterruptType_INTERRUPT_TYPE_OVERLAP = 2,
    BGMTransitInfo_InterruptType_NUM_INTERRUPT_TYPE = 3
};

typedef struct
{
    cstring tagName;
    int32_t beforeId;
    int32_t beforeIdMax;
    int32_t afterId;
    BGMTransitInfo_InterruptType type;
    float fadeOutTime;
    float fadeInTime;
    float delayTime;
}
BGMTransitInfo;

typedef struct
{
    float pauseFadeOutTime;
    float pauseFadeInTime;
    float enterCyberFadeOutTime;
    float leaveCyberResultFadeOutTime;
    BGMVolumeChangeInfoList bgmVolumeInfo;
    AisacChangeInfoList aisacInfo;
    BGMInfo changeBgmInfo[128];
    BGMTransitInfo transitBgmInfo[128];
}
SoundCommonParameter;

