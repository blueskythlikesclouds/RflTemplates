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
    float blockRadius;
    float blockHeight;
    float damageRadius;
    float damagedBlockRadius;
    float damagedBlockHeight;
    float returnRadius;
    float returnBlockRadius;
    float returnHeight;
    float weakPointRadius;
    float grabRadius;
    float attackRadius;
}
MiniBossSkierColliderParam;

typedef struct
{
    float tailRotateMinSpeed;
    float tailRotateMaxSpeed;
    float tailRotateAddSpeed;
}
MiniBossSkeirTailMoveParam;

typedef struct
{
    float tailExtendTime;
    float tailNodeLenthMin;
    float tailNodeLenthMax;
    float checkGroundStartDistanceOnSkiing;
    float checkGroundEndDistanceOnSkiing;
    float checkGroundEndDistanceOnSkiingJump;
    float checkGroundEndDistanceOnSkiingCamera;
    MiniBossSkeirTailMoveParam rotateParamNormal;
    MiniBossSkeirTailMoveParam rotateParamAttack;
}
MiniBossSkierTailParam;

typedef struct
{
    float LRFBNormalRatioSpeed;
    float LRDangerAngle;
    float LRDangerTime;
    float LRInputInterfere;
    float LRRecoverSpeed;
    float LRDragSpeed;
    float LRRecoverEndRatio;
}
MiniBossSkeirPlayerControlLR;

typedef struct
{
    float UDSafeRatio;
    float UDRecoverSpeed;
    float UDDragSpeed;
}
MiniBossSkeirPlayerControlUD;

typedef struct
{
    float tailRatioChangeSpeed;
    float tailRatioRecoverSpeed;
    float tailAddSpeedMax;
    float tailAddSpeedAttenuation;
}
MiniBossSkeirPlayerControlTail;

typedef struct
{
    float timeExplodePassed;
    float timeExplodeAuto;
}
MiniBossSkierMissileParam;

typedef struct
{
    float interoplateTimeActivate;
    float interoplateTimeDeactivate;
    csl::math::Vector3 targetOffset;
    csl::math::Vector3 cameraPosOffset;
}
MiniBossSkierCustomCameraParam;

typedef struct
{
    MiniBossCommonConfig commonConfig;
    MiniBossSkierColliderParam colliderParam;
    MiniBossSkierTailParam tailParam;
    MiniBossSkeirPlayerControlLR LRControlParam;
    MiniBossSkeirPlayerControlUD UDControlParam;
    MiniBossSkeirPlayerControlTail tailControlParam;
    MiniBossSkierMissileParam missileParam;
    MiniBossSkierCustomCameraParam customCameraParam;
    MiniBossSkierCustomCameraParam skiCameraParam;
}
MiniBossSkierCommonParam;

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
MiniBossSkierLevelParam;

typedef struct
{
    float NoActionRate;
    float SnakeMoveRate;
    float JumpHighRate;
    float JumpLowRate;
    float PylonRate;
    float MissileRate;
}
MiniBossSkierSkiAcitionRate;

typedef struct
{
    float HPRate;
    MiniBossSkierSkiAcitionRate actionRate;
    float showWeaknessTimeReTry;
}
MiniBossSkierBattlePhaseParam;

typedef struct
{
    float attackInterval;
    float attackSensorRange;
    float returnToWanderTime;
    float pathPosAngleLimit;
}
MiniBossSkierJumpOutParam;

typedef struct
{
    float showWeaknessTime;
    float skiMoveSpeed;
    float skiWeakMoveSpeed;
    float skiReturnSpeed;
    float homingSpeed;
    float jumpHighSpeed;
    float jumpLowSpeed;
    float struggleTime;
    float returnUndergroundTime;
}
MiniBossSkierSkiParam;

typedef struct
{
    float snakeMoveAmplitude;
    float snakeMovePeriod;
    float snakeMovePrepareTime;
    float snakeMoveReturnTime;
    float snakeMoveDangerAngleOffset;
}
MiniBossSkierSnakeMoveParam;

typedef struct
{
    float signSpeed;
    float attackMinSpeed;
    float attackMaxSpeed;
    float maxWaitTime;
    float driftLenth;
    float driftLenthUIOffset;
    float rotStartAngularSpeed;
    float rotEndAngularSpeed;
    float avoidObjCalMargePylon;
    float avoidObjCalMargeMissile;
}
MiniBossSkierTailAttackParam;

typedef struct
{
    float signSpeed;
    float signTime;
    float pylonAppearTime;
    float pylonDisappearTime;
}
MiniBossSkierTailAttackPylonParam;

typedef struct
{
    int32_t level;
    MiniBossSkierBattlePhaseParam phaseParam[3];
    MiniBossSkierJumpOutParam jumpOutParam;
    MiniBossSkierSkiParam skiParam;
    MiniBossSkierSnakeMoveParam snakeMoveParam;
    MiniBossSkierTailAttackParam tailAttackParam;
    MiniBossSkierTailAttackPylonParam pylonParam;
}
MiniBossSkierLevelBand;

typedef struct
{
    MiniBossSkierCommonParam commonParam;
    MiniBossSkierLevelParam levelParams[5];
    MiniBossSkierLevelBand levelBand[5];
}
MiniBossSkierConfig;

