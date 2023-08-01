#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    float rangeMin;
    float rangeMax;
}
LargeBitLaserParameter;

typedef struct
{
    float bulletRadius;
    float bulletMoveLimitDistance;
    float bitHp;
    float rotDamageAngleSpeed;
    float rotDamageSize;
    float hitDamageNotAttackTime;
    float blowoffSpeed;
    float outOfControlTime;
    float keepVelocity;
    float muzzleEffectMinTime;
    uint8_t dropRingNum;
}
SmallBitLaserBulletParameter;

typedef struct
{
    const char* pValue;
    INSERT_PADDING(8);
}
cstring;

enum BulletType : uint8_t
{
    Normal = 0,
    Normal2 = 1,
    Laser = 2,
    Homing = 3
};

enum RotType : uint8_t
{
    Rotation = 0,
    RoundTrip = 1,
    Aim = 2,
    Fix = 3
};

enum CameraId : uint8_t
{
    Invalid = 0,
    Rotate = 1,
    Trace = 2,
    Sub = 3,
    Num = 4
};

enum FormationId : uint8_t
{
    Default = 0,
    FanShaped = 1
};

typedef struct
{
    bool isParry;
    float time;
    float angleSpeed;
    BulletType bulletType;
    RotType rotType;
    float rotAngle;
    float phaseRotTime;
    uint32_t shootNum;
    float shootSpeed;
    float addShootSpeed;
    float shootAccel;
    float shootAccelMax;
    float shootAccelDelay;
    uint8_t wayNum;
    float wayAngle;
    float shootTime;
    float phaseShootTime;
    uint32_t periodShootCool;
    float periodShootCoolTime;
    float homingAccuracy;
    float homingDelay;
    float homingLimitAngle;
    bool isHomingLowFly;
    CameraId overlookingId;
    float waveRotationSpeed;
    float flyMoveSpeed;
    FormationId formationId;
}
SmallBitAttackPatternParameter;

typedef struct
{
    cstring text;
    SmallBitAttackPatternParameter param;
}
SmallBitSetPatternParameter;

typedef struct
{
    float distance;
    float height;
    float radius;
    float angleMax;
}
SmallBitFormationFanShaped;

typedef struct
{
    float changeTime;
    float changeDelay;
    float changeOffsetHeight;
    SmallBitFormationFanShaped fanShaped;
}
SmallBitFormationParameter;

typedef struct
{
    LargeBitLaserParameter largeBitLaserParam;
    SmallBitLaserBulletParameter smallBitLaserParam;
    SmallBitSetPatternParameter smallBitPatternDatas[64];
    SmallBitFormationParameter smallBitFormation;
}
BossBitConfig;

