#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

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
    float rotateSpeedMin;
    float rotateSpeedMax;
    float rotateSpeedMaxSpeedMin;
    float rotateSpeedMinSpeedMax;
}
WolfMovementParam;

typedef struct
{
    float distance;
    float angle;
}
WolfEyesightParam;

typedef struct
{
    const char* pValue;
    INSERT_PADDING(8);
}
cstring;

enum WolfVolumeShape : int8_t
{
    SPHERE = 0,
    BOX = 1,
    CYLINDER = 2,
    CAPSULE = 3,
    NUM = 4
};

typedef struct
{
    csl::math::Vector3 volumeSize;
    csl::math::Vector3 volumeOffset;
    csl::math::Vector3 volumeRotation;
}
WolfVolumeInfo;

typedef struct
{
    cstring tagName;
    int8_t pieceNum;
    float pieceFuncFactor;
    WolfVolumeShape volumeShape;
    cstring wolfNodeName;
    WolfVolumeInfo wolfVolume;
    bool effectActive;
    bool debugDraw;
    bool debugDrawVolumeAxis;
    bool debugDrawAxis;
}
WolfMappingPairInfo;

typedef struct
{
    RingParameter ringParam;
    WolfMovementParam movement;
    WolfEyesightParam eyesight;
    float killWaitTime;
    float blockColliderRadius;
    float blockColliderHeight;
    float damageColliderRadius;
    float damageColliderHeight;
    float eyesightDistance;
    csl::math::Vector3 cursorOffset;
    WolfMappingPairInfo mappingPairInfo[32];
}
EnemyWolfCommonParam;

typedef struct
{
    int32_t maxHealthPoint;
    float attackRate;
    uint16_t expItemNum;
    uint16_t exp;
}
EnemyWolfCommonLevelParam;

typedef struct
{
    int32_t level;
    EnemyWolfCommonLevelParam common;
}
EnemyWolfLevelParam;

typedef struct
{
    int32_t level;
}
EnemyWolfLevelBand;

typedef struct
{
    EnemyWolfCommonParam commonParam;
    EnemyWolfLevelParam levelParams[5];
    EnemyWolfLevelBand levelBand[5];
}
EnemyWolfConfig;

