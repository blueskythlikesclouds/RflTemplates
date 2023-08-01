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

enum BarrageType : int8_t
{
    TYPE_LASER = 0,
    TYPE_BALL = 1,
    TYPE_BALL_L = 2,
    TYPE_BALL_LL = 3,
    TYPE_AIR_DROP = 4
};

typedef struct
{
    const char* pValue;
    INSERT_PADDING(8);
}
cstring;

typedef struct
{
    BarrageType type;
    cstring damageTag;
    float startSpeed;
    float decelePower;
    float minSpeed;
    float lifeTime;
    float waitTime;
    float lineTime;
    float scale;
    float hitVelocity;
    float parriedSpeed;
    int32_t parriedDamage;
    float parriedStaggerValue;
    float parriedStunValue;
    cstring hitEffName;
}
MiniBossChagerBarrageParam;

typedef struct
{
    int32_t barrageIndex;
    float startWaitTime;
    int32_t muzzleNum;
    float yOffset;
    float zOffset;
    float heightLength;
    float rotSpeed;
    float shakeSpeed;
    float intervalTime;
    float activeTime;
    float endWaitTime;
}
MiniBossChagerSimpleRotateBullet;

typedef struct
{
    float startWaitTime;
    float yOffset;
    float zOffset;
    float moveSpeed;
    float followDeg;
    int32_t shotNum;
    float intervalTime;
    float lifeTime;
    float endWaitTime;
}
MiniBossChagerFollowLaser;

typedef struct
{
    float startWaitTime;
    int32_t muzzleNum;
    float yOffset;
    float zOffset;
    float rotSpeed;
    float moveSpeed;
    float activeTime;
    float endWaitTime;
}
MiniBossChagerVortexLaser;

typedef struct
{
    float startWaitTime;
    float moveSpeed;
    float setDeg;
    float lifeTime;
    float endWaitTime;
}
MiniBossChagerCrossLaser;

typedef struct
{
    int32_t barrageIndex;
    float yOffset;
    float zOffset;
    bool isFollowPlayer;
    float startWaitTime;
    float shotIntarval;
    float maxAngle;
    float rotateSpeed;
    float rotateAngle;
    float endWaitTime;
}
MiniBossChagerCrossBullet;

typedef struct
{
    float startWaitTime;
    float yOffset;
    float scale;
    float lifeTime;
    float endWaitTime;
}
MiniBossChagerMassLaser;

typedef struct
{
    int32_t barrageIndex;
    float startWaitTime;
    int32_t muzzleNum;
    int32_t verticalNum;
    float radius;
    float spaceRate;
    float verticalWaitTime;
    float endWaitTime;
}
MiniBossChagerVerticalRoundBullet;

typedef struct
{
    int32_t barrageIndex;
    float startWaitTime;
    int32_t muzzleNum;
    float radius;
    float height;
    float scale;
    int32_t sideNum;
    int32_t attackNum;
    float intervalTime;
    float nextDeg;
    float shotWaitTime;
    float endWaitTime;
}
MiniBossPyramidRoundBullet;

typedef struct
{
    int32_t barrageIndex;
    float startWaitTime;
    float yOffset;
    float scale;
    float step;
    int32_t allNum;
    float upRate;
    float downRate;
    float frontRate;
    float shotWaitTimeMin;
    float shotWaitTimeMax;
    float endWaitTime;
}
MiniBossPlaneUpDownBullet;

typedef struct
{
    int32_t barrageIndex;
    float startWaitTime;
    float yOffset;
    float edgeLength;
    float activeTime;
    float intervalTime;
    float endWaitTime;
}
MiniBossTriangleBatteryBullet;

typedef struct
{
    int32_t barrageIndex;
    float startWaitTime;
    float yOffset;
    float scale;
    float lengthMin;
    float lengthMax;
    float intervalTime;
    float shotWaitTime;
    float activeTime;
    float endWaitTime;
}
MiniBossPlayerFallBullet;

typedef struct
{
    int32_t barrageIndex;
    float startWaitTime;
    float yOffset;
    float zOffset;
    float scale;
    int32_t muzzleNum;
    float bulletRad;
    float intervalTime;
    float activeTime;
    float endWaitTime;
}
MiniBossGatlingRevolverBullet;

typedef struct
{
    int32_t barrageIndex;
    float yOffset;
    float zOffset;
    bool isFollowPlayer;
    float shotIntarval;
    float maxAngle;
    float rotateSpeed;
    float rotateAngle;
    float barrageAngleDiff;
    float startWaitTime;
    float endWaitTime;
}
MiniBossWinderBullet;

typedef struct
{
    int32_t barrageIndex;
    float yOffset;
    float zOffset;
    bool isFollowPlayer;
    float shotIntarval;
    float maxAngle;
    float yAngleOffset;
    float shotTime;
    float addSpeedMax;
    float startWaitTime;
    float endWaitTime;
}
MiniBossShotgunBullet;

typedef struct
{
    int32_t barrageIndex;
    float yOffset;
    float zOffset;
    float upRotOffset;
    float yAngleOffset;
    float maxAngle;
    float shotTime;
    float addSpeedMax;
    float lineTime;
    float fallPower;
    float startWaitTime;
    float endWaitTime;
}
MiniBossChagerAirDrop;

typedef struct
{
    int32_t bulletDamage;
    float bulletStaggerPoint;
    float bulletSpeed;
    float bulletFallSpeed;
    float bulletCyloopSpeed;
    float bulletGroundTime;
    float bulletFallTime;
    float yOffset;
    float zOffset;
    float upRotOffset;
    float yAngleOffset;
    float maxAngle;
    float shotTime;
    float startWaitTime;
    float endWaitTime;
}
MiniBossChagerGroundObj;

typedef struct
{
    float startWaitTime;
    float yOffset;
    float scale;
    int32_t muzzleNum;
    csl::math::Vector3 muzzlePosOffset[10];
    float muzzleRotOffset[10];
    float muzzleTimeOffset[10];
    float muzzleLaserStartOffset[10];
    int32_t laserNum;
    int32_t attackNum;
    float laserRandomRange;
    float laserTime;
    float laserEndTime;
    float laserNextTime;
    float endWaitTime;
}
MiniBossChagerDiffuseLaser;

typedef struct
{
    float startWaitTime;
    int32_t muzzleNum;
    csl::math::Vector3 muzzlePosOffset[10];
    float muzzleRotOffsetX[10];
    float muzzleRotOffsetY[10];
    float muzzleTimeOffset[10];
    float muzzleLaserStartOffset[10];
    float laserShotTimeMin;
    float laserShotTimeMax;
    int32_t laserNum;
    float laserRange;
    float laserEndTime;
    float laserSpeed;
    float laserRandomRangeMin;
    float laserRandomRangeMax;
    float laserHomingTime;
    float endWaitTime;
}
MiniBossChagerChaseShot;

typedef struct
{
    float hitDistance;
    float durationBind;
    float distanceStartBlackOut;
    float timeEaseBlackOut;
    float timeDelayEndtBlackOut;
    csl::math::Vector3 tangentFrom;
    csl::math::Vector3 tangentTo;
}
MiniBossChargerCatchParam;

typedef struct
{
    MiniBossCommonConfig commonConfig;
    MiniBossChagerBarrageParam barrage[16];
    MiniBossChagerSimpleRotateBullet simpleRotateBullet[3];
    MiniBossChagerFollowLaser followLaser[3];
    MiniBossChagerVortexLaser vortexLaser[3];
    MiniBossChagerCrossLaser crossLaser[3];
    MiniBossChagerCrossBullet crossBullet[3];
    MiniBossChagerMassLaser massLaser[3];
    MiniBossChagerVerticalRoundBullet verticalRoundBullet[3];
    MiniBossPyramidRoundBullet pyramidRoundBullet[3];
    MiniBossPlaneUpDownBullet planeUpDownBullet[3];
    MiniBossTriangleBatteryBullet triangleBatteryBullet[3];
    MiniBossPlayerFallBullet playerFallBullet[3];
    MiniBossGatlingRevolverBullet gatlingRevolverBullet[3];
    MiniBossWinderBullet winderBullet[3];
    MiniBossShotgunBullet shotgunBullet[3];
    MiniBossChagerAirDrop airDrop[3];
    MiniBossChagerGroundObj groundObj[3];
    MiniBossChagerDiffuseLaser diffuseLaser[3];
    MiniBossChagerChaseShot chaseShot[3];
    MiniBossChargerCatchParam atkCatch;
}
MiniBossChargerCommonParam;

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
    float stunTime;
}
MiniBossChargerLevelParam;

enum AttackType : int32_t
{
    AttackTypeInvalid = 0,
    AttackSimpleRotateBullet = 1,
    AttackFollowLaser = 2,
    AttackVortexLaser = 3,
    AttackCrossLaser = 4,
    AttackCrossBullet = 5,
    AttackMassLaser = 6,
    AttackVerticalRoundBullet = 7,
    AttackPyramidRoundBullet = 8,
    AttackPlaneUpDownBullet = 9,
    AttackTriangleBatteryBullet = 10,
    AttackPlayerFallBullet = 11,
    AttackGatlingRevolverBullet = 12,
    AttackWinderBullet = 13,
    AttackShotgunBullet = 14,
    AttackAirDropBullet = 15,
    AttackChaseShotObject = 16,
    AttackDiffuseLaser = 17,
    AttackChaseShot = 18,
    AttackTypeNum = 19
};

typedef struct
{
    int32_t rateHp;
    cstring grindSetName;
}
MiniBossChargerHPRateParam;

typedef struct
{
    int32_t level;
    float rate;
    float chanceTime;
    float chanceTimeMoveSpeed;
    float chanceTimeDecSpeed;
    float chanceTimeSpeedMin;
    float damageTime;
    float chanceTimeAddSpeed;
    AttackType attackTable[10];
    int32_t attackIndexTable[10];
    MiniBossChargerHPRateParam hpRateParams[3];
}
MiniBossChargerLevelBand;

enum MiniBossChargerLevel1_AttackType : int32_t
{
    MiniBossChargerLevel1_AttackType_AttackTypeInvalid = 0,
    MiniBossChargerLevel1_AttackType_AttackSimpleRotateBullet = 1,
    MiniBossChargerLevel1_AttackType_AttackFollowLaser = 2,
    MiniBossChargerLevel1_AttackType_AttackVortexLaser = 3,
    MiniBossChargerLevel1_AttackType_AttackCrossLaser = 4,
    MiniBossChargerLevel1_AttackType_AttackCrossBullet = 5,
    MiniBossChargerLevel1_AttackType_AttackMassLaser = 6,
    MiniBossChargerLevel1_AttackType_AttackVerticalRoundBullet = 7,
    MiniBossChargerLevel1_AttackType_AttackPyramidRoundBullet = 8,
    MiniBossChargerLevel1_AttackType_AttackPlaneUpDownBullet = 9,
    MiniBossChargerLevel1_AttackType_AttackTriangleBatteryBullet = 10,
    MiniBossChargerLevel1_AttackType_AttackPlayerFallBullet = 11,
    MiniBossChargerLevel1_AttackType_AttackGatlingRevolverBullet = 12,
    MiniBossChargerLevel1_AttackType_AttackWinderBullet = 13,
    MiniBossChargerLevel1_AttackType_AttackShotgunBullet = 14,
    MiniBossChargerLevel1_AttackType_AttackAirDropBullet = 15,
    MiniBossChargerLevel1_AttackType_AttackChaseShotObject = 16,
    MiniBossChargerLevel1_AttackType_AttackDiffuseLaser = 17,
    MiniBossChargerLevel1_AttackType_AttackChaseShot = 18,
    MiniBossChargerLevel1_AttackType_AttackTypeNum = 19
};

typedef struct
{
    float range;
    MiniBossChargerLevel1_AttackType attackTable[2];
    int32_t attackIndexTable[2];
}
MiniBossChargerLevel1;

typedef struct
{
    MiniBossChargerCommonParam commonParam;
    MiniBossChargerLevelParam levelParams[5];
    MiniBossChargerLevelBand levelBands[5];
    MiniBossChargerLevel1 level1Params[2];
}
MiniBossChargerConfig;

