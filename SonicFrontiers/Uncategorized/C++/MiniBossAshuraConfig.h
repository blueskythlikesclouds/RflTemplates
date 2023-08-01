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
MiniBossAshuraCommonParam;

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
MiniBossAshuraLevelParam;

typedef struct
{
    int32_t level;
}
MiniBossAshuraLevelBand;

typedef struct
{
    float rotationSpeed;
    float moveRadiusMin;
    float moveRadiusMax;
    float initKeepTime;
    float scaleUpTime;
    float scaleUpKeepTime;
    float scaleDownTime;
    float scaleDownKeepTime;
    int32_t num;
}
MiniBossAshuraObjectCircleLaser;

typedef struct
{
    int32_t createNum;
    int32_t createParkourNum;
    float createCycleTime;
    float moveSpeed;
    float lifeTime;
    float homingMaxAngle;
    float homingStartTime;
    float homingPowerMaxTime;
    float meanderingPower;
    float meanderingCycleTime;
}
MiniBossAshuraObjectCrawlSpark;

typedef struct
{
    float ocTime;
    float dashSpeed;
    float ocTimeOnGround;
    float dashSpeedOnGround;
}
MiniBossAshuraObjectDashCircleBulletParamByType;

typedef struct
{
    float moveSpeed;
    float lifeTime;
    MiniBossAshuraObjectDashCircleBulletParamByType frontType;
    MiniBossAshuraObjectDashCircleBulletParamByType backType;
}
MiniBossAshuraObjectDashCircleBullet;

typedef struct
{
    float blowOffRadius;
    float blowOffHeight;
    float killRadius;
}
MiniBossAshuraObjectSlamWave;

typedef struct
{
    MiniBossAshuraObjectCircleLaser circleLaser;
    MiniBossAshuraObjectCrawlSpark crawlSpark;
    MiniBossAshuraObjectDashCircleBullet dashCircleBullet;
    MiniBossAshuraObjectSlamWave slamWave;
}
MiniBossAshuraObjectParam;

enum OnArmCircleBulletType : int8_t
{
    CBT_NONE = 0,
    CBT_FRONT = 1,
    CBT_BACK = 2,
    NUM_CBT = 3
};

typedef struct
{
    OnArmCircleBulletType left;
    OnArmCircleBulletType center;
    OnArmCircleBulletType right;
    float leftOffsetAngle;
    float centerOffsetAngle;
    float rightOffsetAngle;
}
MiniBossAshuraPhaseOnArmCircleBulletPos;

typedef struct
{
    bool isCircleLaser;
    bool isCrawlSpark;
    bool isAttackArmWave;
    bool isAttackArmCircleBulletOnArm;
    MiniBossAshuraPhaseOnArmCircleBulletPos onArmCircleBullets[8];
    bool isAttackArmCircleBullet;
    int32_t circleBulletBackTypeFreq;
    int32_t circleBulletCreateNum;
    float circleBulletCreateAngle;
    float circleJumpTargetDistace;
    float circleBulletCreateIntervalTime;
    int32_t armAttackConsecutiveNum;
}
MiniBossAshuraPhaseParam;

typedef struct
{
    MiniBossAshuraCommonParam commonParam;
    MiniBossAshuraLevelParam levelParams[5];
    MiniBossAshuraLevelBand levelBand[5];
    MiniBossAshuraObjectParam objectParam;
    MiniBossAshuraPhaseParam phaseParam[3];
}
MiniBossAshuraConfig;

