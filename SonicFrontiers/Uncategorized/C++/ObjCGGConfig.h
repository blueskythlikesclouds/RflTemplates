#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    uint8_t alpha;
    uint8_t red;
    uint8_t green;
    uint8_t blue;
}
color8;

typedef struct
{
    float yOffset;
    float cameraElevation;
    float cameraDistance;
    float cameraFovy;
    float radius;
    float cameraLookAtPointOffsetY;
    float cameraDegreeForClockwiseMovement;
    float cameraDegreeForCounterClockwiseMovement;
    float cameraMaxChangeableDegreeByStickInput;
    float cameraMaxDegreeChangedByStickInputPerSec;
}
RailCameraParam;

typedef struct
{
    float radius;
    csl::math::Vector3 offset;
    color8 colorActive;
    color8 colorDeactive;
    float timerHeightOffset;
    RailCameraParam twoRailCamera;
    RailCameraParam threeRailCamera;
}
ObjCGGRootConfig;

typedef struct
{
    float radius;
    color8 color;
    float speed;
    float waitFollowTime;
    float followTime;
    float waitKillTime;
    float radiusBulletCircle;
    float followLimitAngleHorizontal;
    float followLimitAngleVertical;
    float rotateDeceleration;
    float muzzuleEffectLoopTime;
}
ObjCGGBulletNormalConfig;

typedef struct
{
    float radius;
    color8 color;
    float timeToReachTimer;
}
ObjCGGResetBindConfig;

typedef struct
{
    float radius;
    float heightInterval;
    color8 color;
}
ObjCGGLaserConfig;

typedef struct
{
    float radius;
    color8 color;
}
ObjCGGAttachmentConfig;

typedef struct
{
    ObjCGGRootConfig root;
    ObjCGGBulletNormalConfig bulletNormal;
    ObjCGGResetBindConfig resetBind;
    ObjCGGLaserConfig laser;
    ObjCGGAttachmentConfig attachment;
}
ObjCGGConfig;

