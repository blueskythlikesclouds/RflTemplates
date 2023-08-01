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
    int32_t count;
    float intervalTime;
    float pitchMin;
    float pitchMax;
    float pitchOffsetMin;
    float pitchOffsetMax;
    float yawOffsetRange;
    bool sweepFire;
    bool predict;
    float radius;
    float speed;
    float lifeTime;
    float waitTime;
}
MiniBossDarumaShotParam;

enum ScatterType : int8_t
{
    RANDOM = 0,
    HOMING = 1,
    SPIRAL = 2
};

typedef struct
{
    int32_t count;
    float intervalTime;
    float shootPitchMin;
    float shootPitchMax;
    float initialSpeedMin;
    float initialSpeedMax;
    float maxAngle;
    float moveRadius;
    float maxMoveSpeed;
    float accel;
    float waitTime;
    float featherLifeTime;
    ScatterType m_scatterTypeTable[6];
}
MiniBossDarumaSpecialShotParamBase;

typedef struct
{
    MiniBossDarumaSpecialShotParamBase miniBossDarumaSpecialShotParamBase;
    float explosionRadius;
    float explosionEffectScale;
    float explosionTime;
}
MiniBossDarumaBombParam;

typedef struct
{
    MiniBossDarumaSpecialShotParamBase miniBossDarumaSpecialShotParamBase;
    float burnLifeTime;
}
MiniBossDarumaFlamePillarParam;

typedef struct
{
    MiniBossDarumaSpecialShotParamBase miniBossDarumaSpecialShotParamBase;
    float burnLifeTime;
    float cycleTime;
    float cycleDistance;
    float homingLimitAngle;
    float maxTurnAngle;
    uint32_t cycleCount;
}
MiniBossDarumaWaveBombParam;

typedef struct
{
    float range;
    float riseDistance;
    float riseTime;
    float chaseSpeed;
    float chaseTime;
    float speed;
    float rotationSpeed;
    float timingGap;
    float spinTime;
    float ringRiseTime;
    float waitTime;
    float staggerTime;
    float staggerDistance;
    float groundImpactRadius;
    float waveRadius;
    float waveAppearRadius;
    float waveKeepRadius;
    float waveDisappearRadius;
    float waveHeightMin;
    float waveHeightMax;
    float waveLifeTime;
    float waveVelocityX;
    float waveVelocityY;
    float laserRadius;
    float laserLength;
    float laserTime;
    float laserRotationInitialSpeed;
    float laserRotationAccel;
    float laserRotationMaxSpeed;
    float laserAccelDelayTime;
}
MiniBossDarumaStompingParam;

typedef struct
{
    csl::math::Vector3 targetOffSet;
    float azimuth;
    float elevation;
    float distance;
    float zRoll;
    float fovy;
    csl::math::Vector3 cameraMoveDir;
    float cameraMoveSpeed;
    float interpolateTime;
    float bodyBreakWaitTime;
    float changeStateWaitTime;
}
MiniBossDarumaCyloopReactionParam;

typedef struct
{
    float lifeTime;
    float forceScale;
    float forceMin;
    float forceMax;
    float forceCyloopExplode;
    float gravity;
    float weight;
    float friction;
    int8_t maxPieceNum;
    csl::math::Vector3 centerOffset;
}
MiniBossDarumaDebrisBodySmallParam;

typedef struct
{
    float damageVelocityScale;
    float minSpeed;
    float maxSpeed;
    MiniBossDarumaDebrisBodySmallParam body;
    MiniBossDarumaDebrisBodySmallParam cyloop;
}
MiniBossDarumaDebrisParam;

typedef struct
{
    float time;
    float magnitude;
    int32_t freq;
    float attnRatio;
    float shakeRange;
}
MiniBossDarumaCameraShakeParam;

typedef struct
{
    MiniBossCommonConfig commonConfig;
    float headHeight;
    int32_t bodyMaxHealthPoint;
    float bodyRadius;
    float bodyHeight;
    float baseHeight;
    float partSpace;
    float ringRadius;
    float ringHeight;
    float ringRotationSpeed;
    float gravity;
    float stunTime;
    float maxSpeed;
    float stompingTransitRange;
    int32_t questKodamaMaxNum[3];
    MiniBossDarumaShotParam shot;
    MiniBossDarumaShotParam shot3way;
    MiniBossDarumaShotParam shot5way;
    MiniBossDarumaBombParam bomb;
    MiniBossDarumaFlamePillarParam flamePillar;
    MiniBossDarumaWaveBombParam waveBomb;
    MiniBossDarumaStompingParam stomping;
    MiniBossDarumaStompingParam stompingThorn;
    MiniBossDarumaStompingParam stompingQuest[3];
    MiniBossDarumaStompingParam stompingQuestHigh[3];
    MiniBossDarumaStompingParam stompingQuest2[3];
    MiniBossDarumaStompingParam stompingQuest2High[3];
    MiniBossDarumaCyloopReactionParam cyloopReaction;
    MiniBossDarumaShotParam shotBerserk;
    MiniBossDarumaShotParam shotBerserk3way;
    MiniBossDarumaShotParam shotBerserk5way;
    MiniBossDarumaStompingParam hop;
    MiniBossDarumaStompingParam stompingBerserk;
    MiniBossDarumaFlamePillarParam flamePillarBerserk;
    MiniBossDarumaDebrisParam debris;
    MiniBossDarumaCameraShakeParam cameraShakeStomping;
    MiniBossDarumaCameraShakeParam cameraShakeStompingQuest;
    MiniBossDarumaCameraShakeParam cameraShakeStompingQuest2;
    MiniBossDarumaCameraShakeParam cameraShakeDrop;
}
MiniBossDarumaCommonParam;

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
MiniBossDarumaLevelParam;

enum StompingType : int8_t
{
    WEEK = 0,
    WAVE = 1
};

enum BulletType : int8_t
{
    NORMAL = 0,
    THREE_WAY = 1,
    FIVE_WAY = 2
};

enum SpecialBulletType : int8_t
{
    BOMB = 0,
    PILLAR = 1,
    WAVE_BOMB = 2
};

typedef struct
{
    uint32_t level;
    StompingType stompingType;
    int8_t laserCount;
    bool isBarrier;
    StompingType stompingTypeThorn;
    int8_t laserCountThorn;
    bool isBarrierThorn;
    BulletType bulletType;
    SpecialBulletType specialBulletType;
    int8_t stompingMaxBreakBodyCount;
    bool isThorn;
    csl::math::Vector3 headRigidColliderExtents;
    csl::math::Vector3 headRigidCollHeightOffset;
}
MiniBossDarumaLevelBand;

typedef struct
{
    MiniBossDarumaCommonParam commonParam;
    MiniBossDarumaLevelParam levelParams[5];
    MiniBossDarumaLevelBand levelBands[5];
    MiniBossDarumaLevelParam levelParamQuest;
    MiniBossDarumaLevelBand levelBandQuest;
}
MiniBossDarumaConfig;

