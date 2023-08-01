#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    float interoplateTimeActivate;
    float interoplateTimeDeactivate;
}
ReflexesPanelCameraParam;

typedef struct
{
    csl::math::Vector3 collisionHalfExtents;
    csl::math::Vector3 collisionOffset;
}
ReflexesPanelPanelParam;

typedef struct
{
    ReflexesPanelCameraParam cameraParam;
    ReflexesPanelPanelParam panelParam;
}
ReflexesPanelParam;

