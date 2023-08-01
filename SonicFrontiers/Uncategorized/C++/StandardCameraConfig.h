#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    float distance;
    float distanceSuspensionK;
    float minElevation;
    float maxElevation;
    float azimuthSensitivity;
    float elevationUpSensitivity;
    float elevationDownSensitivity;
    float elevationOffset;
    float targetUpOffset;
    float targetMinUpOffsetLimit;
    float targetMaxUpOffsetLimit;
    float targetMinUpOffsetLimitDistance;
    float targetMaxUpOffsetLimitDistance;
    float targetOffsetSuspensionK;
    float delayAllowDistance;
    float delayLimitDistance;
    float delaySuspensionK;
    float autocontrolDisabledTime;
    float chaseSegmentSuspensionK;
    float chaseSegmentShortenSpeed;
    int32_t chaseSegmentMaxCount;
    float inertiaMinDecel;
    float inertiaOvershootAngle;
    float resetSuspensionK;
    float downDirectionDotThreshold;
    float baseUpLeanRate;
}
StandardCameraCommonParameter;

typedef struct
{
    float minDistance;
    float maxDistance;
    float minDistanceAccel;
    float maxDistanceAccel;
    float distanceSuspensionK;
    float elevationOffset;
    float azimuthSensitivity;
    float targetOffsetSuspensionK;
    float targetUpOffset;
    float delayAllowDistance;
    float delayLimitDistance;
    float delaySuspensionK;
}
StandardCameraDashParameter;

typedef struct
{
    float minDistance;
    float maxDistance;
    float elevationOffset;
    float azimuthSensitivity;
    float elevationUpSensitivity;
    float elevationDownSensitivity;
    float targetUpOffset;
    float minDelayLimitDistance;
    float maxDelayLimitDistance;
}
StandardCameraCyloopParameter;

typedef struct
{
    float distance;
    float minElevation;
    float maxElevation;
    float elevationOffset;
    float minElevationCyloop;
    float maxElevationCyloop;
    float elevationOffsetCyloop;
    float targetUpOffset;
    float delayAllowDistance;
    float delayLimitDistance;
    float delaySuspensionK;
    float panningSuspensionK;
    float interiorPanningDistance;
    float interiorPanningSuspensionK;
}
StandardCameraLockonParameter;

typedef struct
{
    float distance;
    float targetUpOffset;
}
StandardCameraWallParameter;

typedef struct
{
    float azimuthSensitivity;
    float elevationUpSensitivity;
    float elevationDownSensitivity;
    float targetUpOffset;
    float baseUpLeanRate;
}
StandardCameraLoopParameter;

typedef struct
{
    float distance;
    float distanceSuspensionK;
    float elevationOffset;
    float azimuthMinOffset;
    float azimuthMaxOffset;
    float azimuthMinOffsetDistance;
    float azimuthMaxOffsetDistance;
    float azimuthSensitivity;
    float targetOffsetSuspensionK;
    float targetMinUpOffset;
    float targetMaxUpOffset;
    float targetFrontOffset;
    float delayAllowDistance;
    float delayLimitDistance;
    float delaySuspensionK;
    float manualControlTime;
}
StandardCameraBattleParameter;

typedef struct
{
    float minManualRotationSpeed;
    float maxManualRotationSpeed;
    float minDistanceScale;
    float maxDistanceScale;
    float maxElevationAddOffset;
    float minTargetUpOffsetScale;
    float maxTargetUpOffsetScale;
    float minFovyRate;
    float minLimitFovy;
}
StandardCameraOptionParameter;

typedef struct
{
    StandardCameraCommonParameter common;
    StandardCameraDashParameter dash;
    StandardCameraCyloopParameter cyloop;
    StandardCameraCyloopParameter cyloopSnipe;
    StandardCameraLockonParameter lockon;
    StandardCameraLockonParameter lockonCharger;
    StandardCameraLockonParameter lockonSpider;
    StandardCameraLockonParameter lockonDaruma;
    StandardCameraLockonParameter lockonNinja;
    StandardCameraLockonParameter lockonSumo;
    StandardCameraWallParameter wall;
    StandardCameraLoopParameter loop;
    StandardCameraBattleParameter battle;
    StandardCameraOptionParameter option;
}
StandardCameraConfig;

