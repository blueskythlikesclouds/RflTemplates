#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    float timeLimitSeconds;
    float cautionTime;
    float warningTime;
    bool useCautionAnimation;
    bool useWarningAnimation;
}
QuestCollectitemTimerParameter;

typedef struct
{
    float distance;
    float azimuthSensitivity;
    float elevationUpSensitivity;
    float elevationDownSensitivity;
    float elevationOffset;
}
QuestCameraParameter;

typedef struct
{
    int32_t applicableFailedCount;
    int32_t RequestItemNum;
    QuestCollectitemTimerParameter timerParam;
    QuestCameraParameter cameraParam;
}
QuestCollectItemParameterElement;

typedef struct
{
    QuestCollectItemParameterElement element[3];
}
QuestCollectItemParameter;

