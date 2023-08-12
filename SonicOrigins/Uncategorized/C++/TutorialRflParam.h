#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    bool isEnable;
    int32_t movieIndex;
}
TutorialPageInfo;

typedef struct
{
    bool isEnable;
    int32_t priority;
    TutorialPageInfo pageInfos[3];
}
TutorialInfo;

typedef struct
{
    TutorialInfo infos[64];
}
TutorialRflParam;

