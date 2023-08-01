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
    bool enable;
    float gravity;
    float resist;
    float resist_decay;
    float recover;
    float recover_decay;
    float spring;
    float radius;
    float transmit;
    float inertia;
    float angle_limit;
    cstring nodeName;
}
SwayParamNode;

enum CollisionType : int8_t
{
    SWAY_COLLISTION_TYPE_NONE = 0,
    SWAY_COLLISTION_TYPE_SPHERE = 1
};

typedef struct
{
    CollisionType type;
    csl::math::Vector3 translation;
    csl::math::Vector3 rotation;
    csl::math::Vector3 scale;
    int32_t modelPartId;
    cstring modelNodeName;
}
SwayParamCollision;

typedef struct
{
    SwayParamCollision collisionParam[8];
}
SwayParamNodeCollision;

typedef struct
{
    cstring idName;
    SwayParamNode nodeParam[16];
    SwayParamNodeCollision collisionParam[16];
}
SwayParamIndivisual;

