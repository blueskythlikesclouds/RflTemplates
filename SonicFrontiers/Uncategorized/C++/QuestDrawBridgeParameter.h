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
QuestDrawBridgeTimerParameter;

typedef struct
{
    int32_t applicableFailedCount;
    QuestDrawBridgeTimerParameter timerParam;
}
QuestDrawBridgeParameterElement;

typedef struct
{
    QuestDrawBridgeParameterElement element[3];
}
QuestDrawBridgeParameter;

