#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    float duration;
    float distance;
    float minElevation;
    float maxElevation;
    float panningSuspensionK;
    float interiorPanningSuspensionK;
}
FocusCameraConfig;

typedef struct
{
    FocusCameraConfig focusCamera;
    float shotInterval;
    float shotInterval_Parried;
    float shotInterval_Reborn;
    float shotInterval_First;
    float shotInterval_NoReborn;
    float stunTime;
    float approachWait;
    float dispWait;
    float rollWait;
    float reactionTime;
    float controlDelay;
    float shotAngle;
}
ObjWolfManagerConfig;

