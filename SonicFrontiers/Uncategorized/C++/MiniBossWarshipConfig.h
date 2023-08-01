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
    float highSpeed;
    float lowSpeed;
    float changeLowSpeedDistance;
    float disableDistanceMaxSpeed;
    float relativeSpeedDisableDistance;
    float speedOnJump;
    float speedDownOnJumpDistance;
}
MiniBossWarshipSpeedParam;

typedef struct
{
    float min;
    float max;
}
MiniBossWarshipAccelSpeed;

typedef struct
{
    float zoomDistance;
    csl::math::Vector3 zoomOffset;
    csl::math::Vector3 zoomAngle;
    float zoomFov;
}
MiniBossWarshipWarpCameraParam;

typedef struct
{
    float fovy;
    float zRot;
    float distance;
    float pathOffset;
    bool usePathVerticalComponent;
    bool usePathNormal;
    float angleSensitivity;
    float angleSensitivityBoost;
    float azimuthOffsetDeg;
    float elevationOffsetDeg;
    float gravityOffset;
    csl::math::Vector3 playerOffset;
}
MiniBossWarshipEscapeCameraParam;

typedef struct
{
    float dashRingAppearDistance;
    float dashRingDisappearDistance;
    float birdAppearDistance;
    float birdDisappearDistance;
    float bulletAppearDistance;
    float bulletDisappearDistance;
}
MiniBossWarshipObjectParam;

typedef struct
{
    float outStrength;
    float inStrength;
    float outElev;
    float inElev;
    float speedMin;
    float speedMax;
    float speedMinLength;
    float speedMaxLength;
}
WarshipNearLaunchParam;

typedef struct
{
    MiniBossCommonConfig commonConfig;
    MiniBossWarshipSpeedParam speedParam;
    MiniBossWarshipAccelSpeed normalSpeedParam;
    MiniBossWarshipAccelSpeed boostSpeedParam;
    MiniBossWarshipWarpCameraParam warpCameraParam;
    MiniBossWarshipEscapeCameraParam escapeCameraParam;
    MiniBossWarshipObjectParam objectParam;
    WarshipNearLaunchParam launchParam;
}
MiniBossWarshipCommonParam;

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
MiniBossWarshipLevelParam;

typedef struct
{
    int32_t level;
}
MiniBossWarshipLevelBand;

typedef struct
{
    float normal;
    float boost;
}
MiniBossWarshipRecoverBoostGaugeParam;

typedef struct
{
    float moveSpeed;
    float bombDropSpeed;
    float bombInterval;
    float explosionRadius;
    float bombPreDistEffectRange;
    float lifeTime;
    float preBombTime;
    float preBombStateSpeed;
}
MiniBossWarshipAttackStateParam;

typedef struct
{
    float firstFinishTimer;
    float finishTimer;
    float disableHomingTime;
}
MiniBossWarshipBattleFlagParam;

typedef struct
{
    float distance;
    float minElevation;
    float maxElevation;
    float targetUpOffset;
    float targetMinUpOffsetLimit;
    float targetMaxUpOffsetLimit;
}
MiniBossWarshipNearBattleCameraParam;

typedef struct
{
    const char* pValue;
    INSERT_PADDING(8);
}
cstring;

typedef struct
{
    bool enable;
    float start;
    float end;
}
WarshipPathSectionInfo;

typedef struct
{
    cstring followPaths;
    WarshipPathSectionInfo usePathInfo[50];
    WarshipPathSectionInfo accelInfo[50];
}
WarshipEscapePathInfo;

typedef struct
{
    WarshipEscapePathInfo escapePathInfo[5];
}
MiniBossWarshipEscapePathParam;

typedef struct
{
    float lockonDistance;
    float unlockDistance;
    float duration;
    float distance;
    float minElevation;
    float maxElevation;
    float lockonFrameYOffset;
}
MiniBossWarshipBombAttackCameraParam;

typedef struct
{
    float midCameraPosOffset;
    MiniBossWarshipBombAttackCameraParam firstCamera;
    MiniBossWarshipBombAttackCameraParam secondCamera;
}
MiniBossWarshipAttackStateCameraParam;

typedef struct
{
    MiniBossWarshipCommonParam commonParam;
    MiniBossWarshipLevelParam levelParams[5];
    MiniBossWarshipLevelBand levelBand[5];
    float wanderMoveSpeed;
    float railMaxLength;
    MiniBossWarshipSpeedParam shiftStateMoveSpeedParam;
    float locatorDistance;
    float distanceEscapePathToStart;
    MiniBossWarshipRecoverBoostGaugeParam boostGaugeParam;
    MiniBossWarshipAttackStateParam attackStateParam;
    MiniBossWarshipBattleFlagParam battleFlagParam;
    MiniBossWarshipNearBattleCameraParam nearBattleCameraParam;
    float disableGimmickDistance;
    float warpTime;
    float cameraChangeTime;
    float cameraAppearTime;
    float spreadHomingDistance;
    MiniBossWarshipEscapePathParam escapePathID[5];
    MiniBossWarshipAttackStateCameraParam bombAttackCameraParam[5];
}
MiniBossWarshipConfig;

