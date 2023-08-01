#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    float interoplateTimeActivate;
    float interoplateTimeDeactivate;
    csl::math::Vector3 targetOffset;
    csl::math::Vector3 cameraPosOffset;
}
GimmickCameraParam;

typedef struct
{
    GimmickCameraParam rotateMirrorH;
    GimmickCameraParam rotateMirrorV;
    GimmickCameraParam moveMirror;
}
ObjLaserMirrorConfig;

