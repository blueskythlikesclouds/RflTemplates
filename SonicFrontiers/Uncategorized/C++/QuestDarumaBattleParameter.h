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
QuestDarumaTimerParameter;

typedef struct
{
    int32_t applicableFailedCount;
    float collectionColliderRadius;
    float collectionColliderHeight;
    QuestDarumaTimerParameter timerParam;
}
QuestDarumaBattleParameterElement;

typedef struct
{
    QuestDarumaBattleParameterElement element[3];
}
QuestDarumaBattleParameter;

