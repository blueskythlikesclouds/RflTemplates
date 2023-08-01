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
    float interval;
    int32_t recordNumWander;
    int32_t recordNumWatch;
    int32_t recordNumBattle;
    float width;
    float wallHeight;
}
FlyerTrailParam;

typedef struct
{
    float speed;
}
FlyerWanderParam;

typedef struct
{
    float interval;
    float readyDuration;
    float shotAnimSpeed;
    uint32_t shotAnimNum;
    float speed;
    float lifeTime;
}
FlyerWatchShotParam;

typedef struct
{
    float speed;
    float changeWanderTime;
    FlyerWatchShotParam shot;
}
FlyerWatchParam;

enum HorizontalType : int8_t
{
    HorzCenter = 0,
    HorzLeft = 1,
    HorzRight = 2
};

typedef struct
{
    HorizontalType horz[6];
}
FlyerEscapeShotTableData;

typedef struct
{
    FlyerEscapeShotTableData posTable[16];
    float interval;
    float waitAfterLoop;
    float readyDuration;
    float shotAnimSpeed;
    uint32_t shotAnimNum;
    float initSpeed;
    float maxSpeed;
    float acc;
    float lifeTime;
    float nearest;
}
FlyerEscapeShotParam;

enum PlayerOffsetType : int8_t
{
    PLAYER_OFFSET_NORMAL = 0,
    PLAYER_OFFSET_ABSOLUTE = 1
};

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
    PlayerOffsetType playerOffsetType;
}
FlyerEscapeCameraParam;

typedef struct
{
    bool enable;
    float speed;
    float boostSpeed;
    float boostSpeedMax;
}
FlyerEscapeQuickStepParam;

typedef struct
{
    float startSpeed;
    float decrease;
    float minSpeed;
    float targetDisableTime;
    float resetByFallTime;
    float resetByDistance;
    FlyerEscapeShotParam shot;
    FlyerEscapeCameraParam camera;
    FlyerEscapeQuickStepParam quickStep;
}
FlyerEscapeParam;

typedef struct
{
    float duration;
    csl::math::Vector3 posOffset;
    float fovy;
    float interpolateTimePush;
    float interpolateTimePop;
}
FlyerNearStartCamParam;

typedef struct
{
    float durationMin;
    float durationMax;
    uint32_t selectRatio[2];
}
FlyerIdlingNearParam;

typedef struct
{
    float duration;
}
FlyerGuardParam;

typedef struct
{
    float lockonDistance;
    float unlockDistance;
    float distance;
    float minElevation;
    float maxElevation;
    float panningSuspensionK;
    float interiorPanningSuspensionK;
}
FlyerAutoLockonParam;

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
FlyerNearEndLaunchParam;

typedef struct
{
    float duration;
    float startHABounceUp;
    float startHABounceBack;
    float preliminaryMotionSpeed;
    float resetByDistance;
    FlyerNearStartCamParam startCam;
    FlyerIdlingNearParam idling;
    FlyerGuardParam guard;
    FlyerAutoLockonParam lockon;
    FlyerNearEndLaunchParam launch;
}
FlyerNearParam;

typedef struct
{
    MiniBossCommonConfig commonConfig;
    FlyerTrailParam trail;
    FlyerWanderParam wander;
    FlyerWatchParam watch;
    FlyerEscapeParam escape;
    FlyerNearParam nearRange;
    float stunTime;
}
MiniBossFlyerCommonParam;

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
MiniBossFlyerLevelParam;

typedef struct
{
    int32_t id;
    float interval;
}
FlayerEscapeShotSequenceTable;

typedef struct
{
    bool isUse;
    FlayerEscapeShotSequenceTable table[8];
}
FlayerEscapeShotSequenceTableData;

typedef struct
{
    int32_t level;
    FlayerEscapeShotSequenceTableData sequence[16];
}
MiniBossFlyerLevelBand;

typedef struct
{
    MiniBossFlyerCommonParam commonParam;
    MiniBossFlyerLevelParam levelParams[5];
    MiniBossFlyerLevelBand levelBand[5];
}
MiniBossFlyerConfig;

