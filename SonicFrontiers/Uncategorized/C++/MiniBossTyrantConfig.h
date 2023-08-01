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
    float nonBattleRange;
    float miniDamageRange;
    float miniComboRange;
    float miniOffsetY;
    float bodyDamageRange;
    float bodyComboRange;
    float bodyOffsetY;
}
MiniBossTyrantCommonParam;

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
MiniBossTyrantLevelParam;

typedef struct
{
    int32_t level;
}
MiniBossTyrantLevelBand;

typedef struct
{
    float speed;
    float time;
    float waitTime;
    float rotSpeed;
}
MiniBossTyrantAttackSpinParam;

typedef struct
{
    float speed;
    int32_t attackNum;
}
MiniBossTyrantAttackAirSpinParam;

typedef struct
{
    float time;
}
MiniBossTyrantAttackRouletteParam;

typedef struct
{
    csl::math::Vector3 muzzlePosOffset;
    float time;
    float rotSpeed;
    float waitTime;
}
MiniBossTyrantAttackLaserParam;

enum BarrageType : int8_t
{
    TYPE_AIM_PLAYER = 0,
    TYPE_NO_AIM = 1
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
}
MiniBossTyrantBarrageParam;

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
MiniBossTyrantShotgunBullet;

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
MiniBossTyrantWinderBullet;

typedef struct
{
    int32_t barrageIndex;
    float yOffset;
    float zOffset;
    int32_t num;
    float waitTime;
    bool isFollowPlayer;
    float startWaitTime;
    float endWaitTime;
}
MiniBossTyrantLineBullet;

typedef struct
{
    int32_t barrageIndex;
    float yOffset;
    float zOffset;
    bool isFollowPlayer;
    float waitTime;
    float sideAngle;
    int32_t arrayNum;
    float arrayTime;
    float startWaitTime;
    float endWaitTime;
}
MiniBossTyrantWaveBullet;

typedef struct
{
    int32_t barrageIndex;
    float yOffset;
    float zOffset;
    int32_t num;
    float speed;
    float rotSpeed;
    int32_t arrayNum;
    float arrayTime;
    float startWaitTime;
    float endWaitTime;
}
MiniBossTyrantAttackCircleBullet;

typedef struct
{
    float airBattleRate;
    float nextRoundRate;
    float airBattleRateSecond;
    float chanceTime;
    float chanceTimeSecond;
    bool isSpin;
    bool isSecondAttack;
}
MiniBossTyrantSequenceParameter;

typedef struct
{
    float upPower;
    float upTime;
    float attackTime;
    float downPower;
}
MiniBossTyrantCyloopDamageParameter;

enum ActionType : int8_t
{
    ACTION_TYPE_NONE = 0,
    ACTION_TYPE_SPIN = 1,
    ACTION_TYPE_ROULETTE = 2,
    ACTION_TYPE_LASER = 3,
    ACTION_TYPE_SHOTGUN = 4,
    ACTION_TYPE_WINDER = 5,
    ACTION_TYPE_LINE = 6,
    ACTION_TYPE_WAVE = 7,
    ACTION_TYPE_CIRCLE = 8
};

typedef struct
{
    MiniBossTyrantAttackSpinParam spin;
    MiniBossTyrantAttackAirSpinParam airSpin;
    MiniBossTyrantAttackRouletteParam roulette;
    MiniBossTyrantAttackLaserParam laser;
    float rotSpeed;
    MiniBossTyrantBarrageParam barrage[16];
    MiniBossTyrantShotgunBullet shotgunBullet;
    MiniBossTyrantWinderBullet winderBullet;
    MiniBossTyrantLineBullet lineBullet;
    MiniBossTyrantWaveBullet waveBullet;
    MiniBossTyrantAttackCircleBullet circleBullet;
    MiniBossTyrantSequenceParameter sequenceParam;
    MiniBossTyrantCyloopDamageParameter cyloopParam;
    ActionType actionListGround[10];
    ActionType actionListAir[10];
}
MiniBossTyrantAttackParam;

typedef struct
{
    float speed;
    float accel;
    float rotate_speed_min;
    float rotate_speed_max;
    float rotate_speed_fast;
    float rotate_accel;
    float life;
    float spawn_offset;
    float spawn_interval;
    int32_t spawn_num;
}
MiniBossTyrantDebrisParam;

typedef struct
{
    MiniBossTyrantDebrisParam debris;
}
MiniBossTyrantStormEffectParam;

typedef struct
{
    MiniBossTyrantCommonParam commonParam;
    MiniBossTyrantLevelParam levelParams[5];
    MiniBossTyrantLevelBand levelBand[5];
    MiniBossTyrantAttackParam attackParam;
    MiniBossTyrantStormEffectParam stormEffectParam;
}
MiniBossTyrantConfig;

