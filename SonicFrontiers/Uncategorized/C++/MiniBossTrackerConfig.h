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
MiniBossTrackerCommonParam;

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
MiniBossTrackerLevelParam;

typedef struct
{
    int32_t level;
}
MiniBossTrackerLevelBand;

typedef struct
{
    float time;
    float distance;
    float minElevation;
    float maxElevation;
    float panningSuspensionK;
    float interiorPanningSuspensionK;
}
MiniBossTrackerCameraLockOn;

typedef struct
{
    float facingSpeed;
    float facingSpeed2;
    float steeringSpeed;
    float chaseSpeed;
    float roundSpeed;
    float changeBaseSpeed;
    float returnSpeed;
    float minSpeed;
    float turnSpeed;
    float accel;
    float brake;
    float brakeDistance;
    float damper;
    float springFactor;
    float verticalWidth;
    float verticalDamper;
    float verticalSpringFactor;
    float verticalRotateSpeed;
    float checkChaseRadius;
    float checkRoundRadius;
    float checkReturnRadius;
    float chaseRadius;
    float chaseHeight;
    float chaseWaitTime;
}
MiniBossTrackerMoveParam;

typedef struct
{
    float time;
    float interval;
    float speed;
    float steeringSpeed;
    float startSteeringTime;
    float life;
}
MiniBossTrackerBulletParam;

typedef struct
{
    int32_t num;
    int32_t num2;
    float height;
    float deviationTime;
    float searchRadius;
    float playerRadius;
    float playerHeight;
    float setInterval;
    float life;
    float lifeEx;
    float timer;
    float explosionLife;
    float targetEffectiveDistance;
}
MiniBossTrackerMineParam;

typedef struct
{
    float minRadius;
    float maxRadius;
    float maxDistance;
    float minHeight;
    float maxHeight;
    float deviationTime;
    float maxSpeed;
    float minSpeed;
    float accel;
    float stopTime;
    float damperDistance;
    float damper;
    float chaseRadius;
    float chaseSpeed;
    float disappearTime;
    float life;
    float interval;
    float radius;
    float targetEffectiveDistance;
}
MiniBossTrackerRingHoleParam;

enum ActionType : int8_t
{
    BULLET = 0,
    MINE = 1,
    BASEMINE = 2,
    RINGHOLE = 3,
    LOOP = 4,
    END = 5
};

typedef struct
{
    float intervalTable[20];
    ActionType actionTable[20];
    int32_t nextPoint;
}
MiniBossTrackerActionParam;

typedef struct
{
    int32_t hp;
    float lossRingTime;
    float pursuitTime;
    int32_t baseDebuffCount;
    int32_t addDebuffCount;
    float cameraDistance;
    float cameraDistance2;
    float cameraMinElevation;
    float cameraMaxElevation;
    float cameraTargetUpOffset;
    float cameraTargetUpOffset2;
}
MiniBossTrackerGameParam;

typedef struct
{
    MiniBossTrackerCommonParam commonParam;
    MiniBossTrackerLevelParam levelParams[5];
    MiniBossTrackerLevelBand levelBand[5];
    MiniBossTrackerCameraLockOn cameraLockDamage;
    MiniBossTrackerMoveParam move;
    MiniBossTrackerBulletParam bullet;
    MiniBossTrackerMineParam mine;
    MiniBossTrackerRingHoleParam ringHole;
    MiniBossTrackerActionParam action1;
    MiniBossTrackerActionParam action2;
    MiniBossTrackerActionParam action3;
    MiniBossTrackerActionParam action4;
    MiniBossTrackerActionParam action5;
    MiniBossTrackerGameParam game;
}
MiniBossTrackerConfig;

