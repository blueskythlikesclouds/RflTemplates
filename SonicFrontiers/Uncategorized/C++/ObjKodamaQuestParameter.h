#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    int32_t clearKodamaNum;
    float modelScale;
    float capsuleRadius;
    float capsuleHeight;
    csl::math::Vector3 capsuleOffset;
    float searchRadius;
    float collectTime;
}
QuestKodamaCollectionBaseParameter;

typedef struct
{
    float rotationAnglePerSec;
    float moveSpeed;
    float moveStopSpeed;
    float moveStopeTime;
    float groupRadius;
    float groupMoveAdjustRangeOffset;
    float groupLeaderFixTime;
    float returnToCenterDistance;
    float returnToCenterRotationAngle;
}
QuestKodamaCollectionMoveParameter;

typedef struct
{
    float bombSpawnTrialTime;
    uint16_t numKodamasNeededForBombSpawnRate2;
    uint16_t numKodamasNeededForBombSpawnRate3;
    float bombSpawnRate1;
    float bombSpawnRate2;
    float bombSpawnRate3;
    uint8_t maxAliveBombNum;
    float bombSpawnRange;
}
QuestKodamaCollectionBombParameter;

typedef struct
{
    bool isTimeUp;
    float timeLimitSeconds;
    float cautionTime;
    float warningTime;
    bool useCautionAnimation;
    bool useWarningAnimation;
}
QuestKodamaCollectionTimerParameter;

typedef struct
{
    int32_t applicableFailedCount;
    QuestKodamaCollectionBaseParameter baseParam;
    QuestKodamaCollectionMoveParameter moveParam;
    QuestKodamaCollectionBombParameter bombParam;
    QuestKodamaCollectionTimerParameter timerParam;
}
ObjKodamaQuestGrassIslandParameter;

typedef struct
{
    QuestKodamaCollectionBombParameter questKodamaCollectionBombParameter;
    float sandStormTime;
    float noBombsTime;
    float sandStormInLerpTime;
    float sandStormOutLerpTime;
}
QuestKodamaCollectionSandBombParameter;

typedef struct
{
    int32_t applicableFailedCount;
    QuestKodamaCollectionBaseParameter baseParam;
    QuestKodamaCollectionMoveParameter moveParam;
    QuestKodamaCollectionSandBombParameter bombParam;
    QuestKodamaCollectionTimerParameter timerParam;
}
ObjKodamaQuestDesertIslandParameter;

typedef struct
{
    ObjKodamaQuestGrassIslandParameter grassIslandParam[3];
    ObjKodamaQuestDesertIslandParameter desertIslandParam[3];
}
ObjKodamaQuestParameter;

