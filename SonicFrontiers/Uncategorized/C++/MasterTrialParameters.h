#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    uint8_t prerequisite;
    float limitTime;
    float speedUpScale;
    float recoveryHpTime;
    uint32_t recoveryHpPoint;
    uint32_t limitMistake;
}
MasterTrialStageParameter;

typedef struct
{
    int32_t applicableFailedCount;
    MasterTrialStageParameter stages[4];
}
MasterTrialParameterElement;

typedef struct
{
    float subjectViewTime;
    float readyTime;
    float clearTime;
    float failedTime;
    float clearWaitTime;
    float failedWaitTime;
    MasterTrialParameterElement element[3];
}
MasterTrialParameters;

