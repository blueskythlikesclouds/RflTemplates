#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    float scoutDistance;
    float scoutDistanceOutside;
    float zoomDistance;
    csl::math::Vector3 zoomOffset;
    csl::math::Vector3 zoomAngle;
    float zoomFov;
}
MiniBossCommonConfig;

typedef struct
{
    MiniBossCommonConfig commonConfig;
}
MiniBossStriderCommonParam;

typedef struct
{
    int32_t maxHealthPoint;
    float maxStunPoint[3];
    float stunDecreaseStartTime;
    float stunDecreaseSpeed;
    float maxStaggerPoint[3];
    float staggerDecreaseStartTime;
    float staggerDecreaseSpeed;
    float attackRate;
    uint16_t expItemNum;
    uint16_t exp;
}
MiniBossLevelCommonConfig;

typedef struct
{
    int32_t level;
    MiniBossLevelCommonConfig commonConfig;
}
MiniBossStriderLevelParam;

typedef struct
{
    int32_t level;
}
MiniBossStriderLevelBand;

enum MeansOfAttack : uint8_t
{
    Bullet = 0,
    Laser = 1,
    NumAttackTypes = 2
};

typedef struct
{
    MeansOfAttack meansOfAttack;
    bool enabled;
    float attackInterval;
}
AttackInfo;

typedef struct
{
    AttackInfo attackInfos[2];
    float triggeredHPRatio;
}
AttackPhase;

typedef struct
{
    AttackPhase attackPhases[3];
    float initialAttackWaitBullet;
    float initialAttackWaitLaser;
    float attackableTime;
    float railBulletAttackInterval;
    float tentativePlatformTopYOffset;
    float tentativePlatformBottomYOffset;
    float tentativePlatformRadius;
    float cameraElevation;
    float cameraFovy;
    float cameraDistance;
    float cameraDegreeForClockwiseMovement;
    float cameraDegreeForCounterClockwiseMovement;
    float cameraLookAtPointOffsetY;
    float cameraMaxChangeableDegreeByStickInput;
    float cameraMaxDegreeChangedByStickInputPerSec;
    float attackableCameraElevation;
    float attackableCameraDistance;
    float attackableCameraInterpolationTime;
    float attackableCameraDuration;
    bool enableAttackableCamera;
    bool enableStun;
    bool enableStagger;
}
MiniBossStriderParam;

typedef struct
{
    float radius1;
    float radius2;
    float radius3;
    float yOffset1;
    float yOffset2;
    float yOffset3;
    uint8_t numRailBulletsFiredAtOnce;
    float railBulletPreAttackEffectTime;
    float railBulletRadius;
    float railBulletSearchDistance;
    float maxJumpDistanceFromRailBullet;
    float distToDestWithinWhichJumpIsDone;
}
ObjStriderGrindRailParam;

typedef struct
{
    float colliderRadius;
    float colliderHeight;
}
ObjStriderPlatformParam;

typedef struct
{
    MiniBossStriderCommonParam commonParam;
    MiniBossStriderLevelParam levelParams[5];
    MiniBossStriderLevelBand levelBand[5];
    MiniBossStriderParam striderParam;
    ObjStriderGrindRailParam grindRailParam;
    ObjStriderPlatformParam platformParam;
}
MiniBossStriderConfig;

