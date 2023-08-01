#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    float dropBoxProbabilly;
    float boxHpSmall;
    float boxHpMiddle;
    float boxHpLarge;
    float friction;
    float mass;
    float gravity;
    float linearDamping;
    float angularDamping;
    csl::math::Vector3 maxSpeed;
}
ObjQuestBoxParameter;

