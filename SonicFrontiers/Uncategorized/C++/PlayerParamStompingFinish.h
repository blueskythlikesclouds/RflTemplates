#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

enum Condition : int8_t
{
    Time = 0,
    Animation = 1
};

enum Shape : int8_t
{
    Sphere = 0,
    Cylinder = 1,
    Box = 2
};

typedef struct
{
    Condition condition;
    int8_t count;
    float spanTime;
    Shape shape;
    csl::math::Vector3 shapeSize;
    csl::math::Vector3 shapeOffset;
}
PlayerParamAttackCollider;

typedef struct
{
    PlayerParamAttackCollider hit;
    float ignoreSwingingTime;
}
PlayerParamStompingFinish;

