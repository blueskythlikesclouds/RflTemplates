#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    float playerBoostRatio;
}
QuestMowingPlayerParameter;

typedef struct
{
    uint32_t collisionNum;
    uint32_t pointLine;
}
QuestMowingPointParameter;

typedef struct
{
    float timeLimitSeconds;
    float cautionTime;
    float warningTime;
    bool useCautionAnimation;
    bool useWarningAnimation;
}
QuestMowingTimerParameter;

typedef struct
{
    float visibleSize;
    float visibleTime;
    csl::math::Vector3 viewOffset;
}
QuestMowingEarnedScoreParameter;

typedef struct
{
    float resultCameraEaseTime;
}
QuestMowingResultCameraParameter;

typedef struct
{
    int32_t applicableFailedCount;
    uint32_t questClearPoint;
    QuestMowingPlayerParameter playerParam;
    uint32_t pointParamNum;
    QuestMowingPointParameter pointParam[5];
    QuestMowingTimerParameter timerParam;
    QuestMowingEarnedScoreParameter scoreUIParam;
    QuestMowingResultCameraParameter resultCameraParam;
}
QuestMowingParameterElement;

typedef struct
{
    QuestMowingParameterElement element[3];
}
QuestMowingParameter;

