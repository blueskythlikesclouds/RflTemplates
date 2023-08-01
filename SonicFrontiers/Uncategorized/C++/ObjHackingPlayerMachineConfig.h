#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    int32_t baseHp;
    int32_t lifeCount;
    int32_t lifeUpFailedCount[6];
    int32_t lifeMax;
    float gageUpVolume;
    float gageMax;
    int32_t laserNum;
    float laserInterval;
    float bulletInterval;
    float moveSpeed;
    float nodamageTime;
    float specialmoveTime;
    float bodyCol;
    float barrierCol;
    float attackRangeTime;
    float expandAttackCol;
    csl::math::Vector3 hitPos;
    csl::math::Vector3 barrierPos;
    csl::math::Vector3 expandAttackPos;
}
PlayerMachineConfig;

typedef struct
{
    float length;
    float minLength;
    float texWidth;
}
HomingLaserTrailConfig;

typedef struct
{
    float radius;
    float speed;
    float maxAccel;
    float arrivalTime;
    float lifeTime;
    float minYaw;
    float maxYaw;
    float depthVelocity;
    uint32_t power;
    HomingLaserTrailConfig trail;
}
HomingLaserConfig;

typedef struct
{
    float radius;
    float speed;
    float scale;
    uint32_t power;
}
ElementBulletConfig;

typedef struct
{
    uint32_t dummy;
}
HackingConfig;

typedef struct
{
    PlayerMachineConfig machine;
    HomingLaserConfig laser;
    ElementBulletConfig bullet;
    HackingConfig hacking;
}
ObjHackingPlayerMachineConfig;

