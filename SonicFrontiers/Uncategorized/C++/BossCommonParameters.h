#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    const char* pValue;
    INSERT_PADDING(8);
}
cstring;

typedef struct
{
    cstring modelName;
    cstring animName;
    csl::math::Vector3 scale;
    cstring stageName;
    csl::math::Vector3 stagePos;
}
BossResourceInfo;

typedef struct
{
    cstring nodeName;
    csl::math::Vector3 offset;
    csl::math::Vector3 rot;
    cstring tagName;
    int32_t nextPointId;
}
HoldPoint;

typedef struct
{
    HoldPoint holdPoints[128];
}
HoldPointParameter;

enum Shape : int8_t
{
    SHAPE_SPHERER = 0,
    SHAPE_BOX = 1,
    SHAPE_CYLINDER = 2,
    SHAPE_CAPCULE = 3
};

typedef struct
{
    cstring nodeName;
    Shape shape;
    bool isPhysics;
    csl::math::Vector3 size;
    csl::math::Vector3 offset;
    csl::math::Vector3 rot;
    cstring tagName;
}
CollisionPart;

typedef struct
{
    CollisionPart colParts[32];
}
CollisionPartParameter;

typedef struct
{
    BossResourceInfo resource;
    HoldPointParameter holdParam;
    CollisionPartParameter colParam;
}
BossCommonParameters;

