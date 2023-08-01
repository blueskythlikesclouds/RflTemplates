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
    float eyesightDistance;
    float idlingSpeed;
    float chasingSpeed;
    float escapeSpeed;
    float escapeSpeedPlayerOnPath;
    float onBoardSpeed;
    float restTime;
    float railMaxLength;
}
EnemyRobberCommonConfig;

typedef struct
{
    int32_t maxHealthPoint;
    float attackRate;
    uint16_t expItemNum;
    uint16_t exp;
}
RobbberCommonLevelConfig;

typedef struct
{
    int32_t level;
    RobbberCommonLevelConfig common;
}
EnemyRobberLevelConfig;

typedef struct
{
    EnemyRobberCommonConfig commonParams;
    EnemyRobberLevelConfig levelParams[5];
}
EnemyRobberConfig;

