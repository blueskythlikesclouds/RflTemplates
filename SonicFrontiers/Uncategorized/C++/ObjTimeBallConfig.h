#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    float radius;
    float friction;
    float restitution;
}
CollisionConfig;

typedef struct
{
    float CorrectionsMaxDistance;
    float CorrectionsMinDistance;
    float CorrectionsAngle;
    float CorrectionsRatio;
}
CorrectionsConfig;

typedef struct
{
    float mass;
    float linearDamping;
    float angularDamping;
    float maxLinearVelocity;
    float maxLinearAcceleration;
    float linearVelocityTimes;
    float gravity;
    CollisionConfig collisionConfig;
    CorrectionsConfig correctionsConfig;
}
ObjTimeBallConfig;

