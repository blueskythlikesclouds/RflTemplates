#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

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
    AttackType type;
    int32_t index;
    float rate;
    float restTime;
}
MiniBossChargerAttackParam;

