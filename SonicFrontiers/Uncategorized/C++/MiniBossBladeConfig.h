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
    float backRange;
    float standRange;
    float shortRange;
    float middleRange;
    float runEndDistance;
    float dashEndDistance;
    float parryRange;
    float specialBeginDisappearTime;
    float specialEndDisappearTime;
    float endWarpWaitTime;
    float shiftTimeMin;
    float shiftTimeMax;
}
MiniBossBladeCommonAIParam;

typedef struct
{
    MiniBossCommonConfig commonConfig;
    MiniBossBladeCommonAIParam ai;
}
MiniBossBladeCommonParam;

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
    float angryHpRatio;
    float stunTime;
    float downTime;
    float strikeComboTimer;
    float cyloopComboTimer;
    float blowupComboTimer;
    float attackMotionSpeed;
    float preliminaryMotionSpeed;
    float ghostPreliminaryMotionSpeed;
}
MiniBossBladeLevelCommonParam;

typedef struct
{
    float firstContactWait;
    float specialAttackInterval;
    float shortRangeIntervalMin;
    float shortRangeIntervalMax;
    float middleRangeIntervalMin;
    float middleRangeIntervalMax;
    float counterIntervalMin;
    float counterIntervalMax;
    float afterDashIntervalMin;
    float afterDashIntervalMax;
    float parryIntervalMin;
    float parryIntervalMax;
    float parryDuration;
    float slashComboCoolTime;
    float ghostDashSlashCoolTime;
}
MiniBossBladeLevelAIParam;

typedef struct
{
    uint8_t spawnNum;
}
MiniBossBladeSpecialAttackParam;

typedef struct
{
    int32_t level;
    MiniBossLevelCommonConfig common;
    MiniBossBladeLevelCommonParam general;
    MiniBossBladeLevelAIParam ai;
    MiniBossBladeSpecialAttackParam special;
}
MiniBossBladeLevelParam;

typedef struct
{
    float verticalSlashRate;
    float horizontalSlashRate;
    float slashComboRate;
    float backSlashRate;
    float dashRate;
    float dashSlashRate;
    float ghostDashSlashRate;
    float specialAttackRate;
    bool useTimeStopAttack;
    float guardBeginTime;
    float guardJumpLaserRate;
    float parryJumpLaserRate;
    float cyloopJumpLaserRate;
    float doubleJumpLaserRate;
    bool useParry;
}
MiniBossBladeLevelPhaseAction;

typedef struct
{
    uint32_t level;
    MiniBossBladeLevelPhaseAction phases[2];
}
MiniBossBladeLevelBand;

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
    MiniBossBladeCommonParam commonParam;
    MiniBossBladeLevelParam levelParams[5];
    MiniBossBladeLevelBand levelBands[5];
    RingParameter ringParam;
}
MiniBossBladeConfig;

