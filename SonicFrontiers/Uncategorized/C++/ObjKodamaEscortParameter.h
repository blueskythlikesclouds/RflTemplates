#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    int32_t applicableFailedCount;
    float stackingHeight;
    float blowAwayLengthMin;
    float blowAwayLengthMax;
    float blowAwayHeightMin;
    float blowAwayHeightMax;
    float modelScale;
    float modelScaleSticking;
    float capsuleRadius;
    float capsuleHeight;
    csl::math::Vector3 capsuleOffset;
    float searchRadius;
    float rotationAnglePerSec;
    float verticalJumpSpeedMin;
    float verticalJumpSpeedMax;
    float horizontalJumpSpeedMin;
    float horizontalJumpSpeedMax;
    float jumpInterval;
    float contactRadius;
    float collectTime;
    float splineVelocityY;
    float splineVelocityMultiplier;
    float splineJumpTime;
    float flockRange;
    float spaceHA;
    float maxTiltOfEachKodamaBending;
    float bendingTimeDuringStop;
    float maxTiltOfEachKodamaBendingStop;
    float bendingCycleTimeDuringStay;
    float maxTiltOfEachKodamaBendingStay;
}
ObjKodamaEscortParameterElement;

typedef struct
{
    ObjKodamaEscortParameterElement element[3];
}
ObjKodamaEscortParameter;

