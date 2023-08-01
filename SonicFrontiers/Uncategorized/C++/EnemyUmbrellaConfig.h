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
    RingParameter ringParam;
    int32_t codeDropNumMin;
    int32_t codeDropNumMax;
    int32_t codeXDropNumMin;
    int32_t codeXDropNumMax;
    float closeDistance;
    float cameraDistance;
    float cameraElevation;
    float pullStartHeight;
    float pullEndHeight;
}
EnemyUmbrellaCommonConfig;

enum BarrageType : uint8_t
{
    BOX = 0,
    CONE = 1,
    FAN = 2
};

typedef struct
{
    int32_t maxHealthPoint;
    float attackRate;
    uint16_t expItemNum;
    uint16_t exp;
    float backJumpHeight;
    float backJumpDistance;
    float flyingDuration;
    BarrageType barrageType;
    float barrageHeight;
    float barrageWidth;
    float barrageDistance;
    float bombRatio;
    float barrageFallSpeed;
    float barrageLifeTime;
    float barrageLifePassPower;
}
UmbrellaCommonLevelConfig;

typedef struct
{
    int32_t level;
    UmbrellaCommonLevelConfig common;
}
EnemyUmbrellaLevelConfig;

typedef struct
{
    int32_t dummy;
}
UmbrellaCommonActionConfig;

typedef struct
{
    int32_t level;
    UmbrellaCommonActionConfig common;
}
EnemyUmbrellaLevelBandConfig;

typedef struct
{
    EnemyUmbrellaCommonConfig commonParams;
    EnemyUmbrellaLevelConfig levelParams[5];
    EnemyUmbrellaLevelBandConfig levelBands[5];
}
EnemyUmbrellaConfig;

