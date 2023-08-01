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
    float time;
    float magnitude;
    int32_t freq;
    float attnRatio;
    float shakeRange;
}
MiniBossSpiderCameraShake;

typedef struct
{
    float suckedTime;
    float launchAngle;
    float launchMaxSpeed;
    float launchMinSpeed;
    float randomRangeMin;
    float randomRangeMax;
    float lifeTime;
}
RingParameter;

typedef struct
{
    float radius;
    float appearRadius;
    float keepRadius;
    float disappearRadius;
    float heightMin;
    float heightMax;
    float lifeTime;
    float pauseBeginTime;
    float pauseTime;
}
MiniBossSpiderWaveParam;

typedef struct
{
    float time;
    float distance;
    float minElevation;
    float maxElevation;
    float panningSuspensionK;
    float interiorPanningSuspensionK;
}
MiniBossSpiderCameraLockOn;

typedef struct
{
    int32_t m_maxNumPieces;
    float gravity;
    float lifeTime;
    float force;
}
DebrisParameter;

enum MiniBossSpiderBreakType : int8_t
{
    BREAK_NONE = 0,
    BREAK_LEG = 1,
    BREAK_AIR_LEG = 2,
    BREAK_BOUNCE_LEG = 3,
    BREAK_GIMMICK = 4,
    BREAK_ALL = 5
};

typedef struct
{
    float pressRate;
    float stompRate;
    float shotRate;
    float chainRate;
    float traceRate;
    float laserStraightRate;
    float laserTraceRate;
    float jumpRate;
}
MiniBossSpiderLevelBandRate;

typedef struct
{
    float pressInterval;
    float stompInterval;
    float shotInterval;
    float chainInterval;
    float traceInterval;
    float laserStaightInterval;
    float laserTraceInterval;
    float jumpInterval;
}
MiniBossSpiderLevelBandInterval;

typedef struct
{
    float nearRange;
    MiniBossSpiderLevelBandRate nearRates[2];
    MiniBossSpiderLevelBandRate farRates[2];
    MiniBossSpiderLevelBandInterval interval[2];
}
MiniBossSpiderActionParam;

typedef struct
{
    MiniBossCommonConfig commonConfig;
    float patrolWalkWaitTimeMin;
    float patrolWalkWaitTimeMax;
    float jumpSpeed;
    float pressDistance;
    float waveDistance;
    float waveModelScale;
    float waveModelDiameter;
    float waveWaitTime;
    float mineDistance;
    float shotWaitTime;
    float walkWaitTime;
    float laserStraightDistance;
    float laserStraightPrepairTime;
    float laserStraightTime;
    float laserStraightAngle;
    float laserStraightWaitTime;
    float laserTraceDistance;
    float laserTracePrepairTime;
    float laserTraceTime;
    float laserTraceSpeed;
    float laserTraceWaitTime;
    float chainDistance;
    float chainJumpDistance;
    float chainWaitTime;
    float traceDistance;
    float traceJumpDistance;
    float traceSpeed;
    float traceRotSpeed;
    float traceLifeTime;
    float traceWidth;
    float traceHeight;
    float traceAppearDistance;
    float traceKeepDistance;
    float traceDisappearDistance;
    float traceWaitTime;
    float thornSpawnSpeed;
    float thornSpawnRadiusMax;
    float thornLifeTime;
    float thornFlyingSpeed;
    int32_t protecterHp;
    MiniBossSpiderCameraShake cameraShakeWalk;
    MiniBossSpiderCameraShake cameraShakeAttack;
    RingParameter ringParam;
    MiniBossSpiderWaveParam waveParams[8];
    MiniBossSpiderCameraLockOn cameraLockBreakArmor;
    MiniBossSpiderCameraLockOn cameraLockBlownUp;
    MiniBossSpiderCameraLockOn cameraLockBlownDown;
    MiniBossSpiderCameraLockOn cameraLockFootUp;
    MiniBossSpiderCameraLockOn cameraLockFall;
    DebrisParameter debrisSet;
    MiniBossSpiderBreakType rotationTypeTable[8];
    MiniBossSpiderActionParam rotationActionTable[4];
}
MiniBossSpiderCommonParam;

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
    float attackRate;
    float stunTime;
    float downTime;
    float downTime2;
    float reProtectWaitTime;
    float patrolWalkWaitTimeMin;
    float patrolWalkWaitTimeMax;
}
MiniBossSpiderLevelParam;

enum MiniBossSpiderLevelBand_MiniBossSpiderBreakType : int8_t
{
    MiniBossSpiderLevelBand_MiniBossSpiderBreakType_BREAK_NONE = 0,
    MiniBossSpiderLevelBand_MiniBossSpiderBreakType_BREAK_LEG = 1,
    MiniBossSpiderLevelBand_MiniBossSpiderBreakType_BREAK_AIR_LEG = 2,
    MiniBossSpiderLevelBand_MiniBossSpiderBreakType_BREAK_BOUNCE_LEG = 3,
    MiniBossSpiderLevelBand_MiniBossSpiderBreakType_BREAK_GIMMICK = 4,
    MiniBossSpiderLevelBand_MiniBossSpiderBreakType_BREAK_ALL = 5
};

typedef struct
{
    int8_t pressType;
    uint8_t pressNum;
    float pressWaitTime;
    int8_t stompType;
}
MiniBossSpiderLevelPhaseAction;

typedef struct
{
    float divingEndHeight;
}
MiniBossSpiderLevelPhaseDiving;

typedef struct
{
    int32_t level;
    float phaseChangeHpRatio;
    int32_t walkWaveId;
    int32_t stompWaveId;
    int32_t pressWaveId;
    bool enableCounterKick;
    MiniBossSpiderLevelBand_MiniBossSpiderBreakType breakType;
    float mineRadius;
    float mineExplodeRadius;
    int32_t mineNum;
    float mineStartSpeed;
    float mineDecelePower;
    float mineMinSpeed;
    float mineParriedSpeed;
    float mineLifeTime;
    float mineEnableParryRate;
    int32_t mineHorizonMaxNum;
    int32_t mineVerticalNum;
    int32_t shotCount;
    float chainLifeTime;
    float chainTraceTime;
    float chainSpeed;
    float chainWaitTime;
    float chainRotateSpeed;
    int32_t chainWaveNum;
    bool enableReProtect;
    float nearRange;
    MiniBossSpiderLevelBandRate nearRates[2];
    MiniBossSpiderLevelBandRate farRates[2];
    MiniBossSpiderLevelPhaseAction phases[2];
    MiniBossSpiderLevelBandInterval interval[2];
    MiniBossSpiderLevelPhaseDiving diving[2];
    float slowRate[2];
}
MiniBossSpiderLevelBand;

typedef struct
{
    MiniBossSpiderCommonParam commonParam;
    MiniBossSpiderLevelParam levelParams[5];
    MiniBossSpiderLevelBand levelBands[5];
}
MiniBossSpiderConfig;

