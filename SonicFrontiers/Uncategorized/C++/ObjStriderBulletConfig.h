#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

enum ShootingDirection : uint8_t
{
    Sonic = 0,
    Random = 1,
    NumShootingDirections = 2
};

typedef struct
{
    ShootingDirection shootingDirection;
    float lifeTime;
    float speedToRail;
    float speed;
    float yOffset;
}
CommonBulletParam;

typedef struct
{
    CommonBulletParam commonBulletParam;
    float railChangeDelay;
    float turnaroundTime;
    float splinePositionDistance;
    bool changesRails;
}
HomingBulletParam;

typedef struct
{
    CommonBulletParam commonBulletParam;
    float railChangeDelay;
    float turnaroundTime;
    float splinePositionDistance;
    bool changesRails;
}
ReverseHomingBulletParam;

typedef struct
{
    CommonBulletParam commonBulletParam;
}
SameBodyRailBulletParam;

typedef struct
{
    HomingBulletParam homingBulletParam;
    ReverseHomingBulletParam reverseHomingBulletParam;
    SameBodyRailBulletParam sameBodyRailBulletParam;
}
ObjStriderBulletConfig;

