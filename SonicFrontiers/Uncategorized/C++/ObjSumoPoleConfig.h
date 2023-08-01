#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    float baseHeight;
    float baseRadius;
    float baseOffset;
    float poleHeight;
    float poleRadius;
    float rigidAdditionalHeight;
    float ropeThicknessRigid;
    float ropeThicknessDamage;
    float ropeThicknessArea;
}
ObjSumoPoleColliderConfig;

typedef struct
{
    float interpolationTime;
    float height;
    float fovy;
}
ObjSumoPoleSlingShotLookDownCameraConfig;

typedef struct
{
    float shotGuideMoveDistance;
    float shotRaycastLength;
    float sweepCapsuleHeight;
    float shotMoveLengthMax;
    int32_t shotReflectCountMax;
    int32_t shotReflectOwnerCountMax;
    float shotOffset;
    float shotDirAngleLimit;
    float shotDirAngleChangeSpeed;
    float shotSpeedMin;
    float shotSpeedMax;
    float shotSpeedAdd;
    float cancelSpeed;
    float bendPullLength;
    float aimTimeScale;
    float aimLimitTime;
    ObjSumoPoleSlingShotLookDownCameraConfig cameraLookDown;
}
ObjSumoPoleSlingShotConfig;

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
    float width;
    float maxDistance;
    float tilingDistance;
    float uvScrollSpeedMin;
    float uvScrollSpeedMax;
    int32_t reflectCountSpeedMax;
    color8 colors[5];
    float colorIntensity;
    bool colorGradation;
    bool colorChangeAll;
}
ObjSumoPoleSlingshotLineConfig;

typedef struct
{
    float alpha;
    float red;
    float green;
    float blue;
}
colorF;

typedef struct
{
    float width;
    float tilingDistance;
    float fluctuationPeriod;
    float fluctuationAmplitude;
    float uvScrollSpeed;
    colorF colorPrimary;
    color8 colorVertexEdge;
    color8 colorVertexCenter;
    float colorIntensityAnimTime;
    float colorIntensityMin;
    float colorIntensityMax;
    float patternChangeIntervalTime;
    float edgeWidthScale;
    float edgeWidthScaleLength;
    float roll;
}
ObjSumoPoleRopeElectricConfig;

typedef struct
{
    float timeAppear;
    float timeDisappear;
    int32_t count;
    float swingWidthMin;
    float swingWidthMax;
    float swingWidthReductionRate;
    float swingTime;
    float swingPeriod;
    float swingReturnSlowTime;
    ObjSumoPoleRopeElectricConfig electric;
}
ObjSumoPoleRopeConfig;

typedef struct
{
    int32_t electricDamageToEnemy;
    ObjSumoPoleColliderConfig collider;
    ObjSumoPoleSlingShotConfig slingShot;
    ObjSumoPoleSlingshotLineConfig line;
    ObjSumoPoleRopeConfig rope;
}
ObjSumoPoleConfig;

