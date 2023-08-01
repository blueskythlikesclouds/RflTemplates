#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    float radius;
    csl::math::Vector3 pos;
}
HeliDamageCol;

typedef struct
{
    float followRotateSpeed;
    HeliDamageCol damageCol;
}
HeliCommon;

typedef struct
{
    float life;
    float attackInterval;
}
HeliAttackBase;

typedef struct
{
    HeliAttackBase heliAttackBase;
    float bulletSpeed;
    float gunRotateSpeed;
    uint8_t attackChainNum;
    float attackChainInterval;
}
HeliBullet;

typedef struct
{
    HeliAttackBase heliAttackBase;
    float bombSpeed;
}
HeliBomb;

typedef struct
{
    HeliCommon common;
    HeliBullet attackBullet;
    HeliBomb attackBomb;
}
EnemyHelicopterConfig;

