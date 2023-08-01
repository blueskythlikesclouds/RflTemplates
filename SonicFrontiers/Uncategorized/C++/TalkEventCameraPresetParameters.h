#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

enum GazePositionType : int8_t
{
    Base = 0,
    Head = 1,
    Eye = 2,
    Center = 3
};

typedef struct
{
    bool enable;
    GazePositionType primaryTarget;
    GazePositionType secondaryTarget;
    float targetRatio;
    float rotateDegreePitch;
    float rotateDegreeYaw;
    float cameraOffsetRatio;
    float fovy;
    float targetOffsetX;
    float targetOffsetY;
    float targetOffsetZ;
}
TalkEventCameraPresetParameter;

typedef struct
{
    TalkEventCameraPresetParameter param[16];
}
TalkEventCameraPresetParameters;

