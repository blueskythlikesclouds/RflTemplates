#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    float bulletRadius;
    float bulletModelScale;
    float bulletRadiusLastBoss;
    float bulletModelScaleLastBoss;
    float bulletModelOffsetRateLastBoss;
    float laserNormalRadius;
    float laserThickRadius;
}
HackingBulletParameter;

typedef struct
{
    const char* pValue;
    INSERT_PADDING(8);
}
cstring;

enum Type : uint8_t
{
    BulletFixed = 0,
    BulletAimPlayer = 1,
    LaserNormal = 2,
    LaserThick = 3,
    LaserAimPlayer = 4
};

enum ElementType : uint8_t
{
    Hacking1 = 0,
    Hacking2 = 1
};

typedef struct
{
    float angle;
    float time;
}
AnimationParameter;

typedef struct
{
    Type type;
    ElementType element;
    float startAngle;
    float endAngle;
    uint8_t shootNum;
    float shootSpeed;
    uint8_t wayNum;
    float wayAngle;
    float laserLength;
    float lifeTime;
    bool animation;
    AnimationParameter animParam[8];
}
BulletPatternParameter;

typedef struct
{
    cstring name;
    BulletPatternParameter param;
}
BulletPatternSetParameter;

typedef struct
{
    HackingBulletParameter bulletParam;
    BulletPatternSetParameter data[256];
}
BulletPatternSetParameters;

