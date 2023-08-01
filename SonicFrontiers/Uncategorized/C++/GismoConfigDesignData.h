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
    cstring skeltonName;
    bool noInstance;
}
GismoBasicParam;

enum ShapeType : int8_t
{
    SHAPE_BOX = 0,
    SHAPE_SPHERE = 1,
    SHAPE_CAPSULE = 2,
    SHAPE_CYLINDER = 3,
    SHAPE_MESH = 4,
    SHAPE_NONE = 5
};

enum BasePoint : int8_t
{
    BASE_CENTER = 0,
    BASE_Z_PLANE = 1,
    BASE_X_PLANE = 2,
    BASE_Y_PLANE = 3
};

typedef struct
{
    ShapeType shape;
    BasePoint basePoint;
    float width;
    float height;
    float depth;
    cstring meshName;
    csl::math::Vector3 shapeOffset;
    float shapeSizeOffset;
}
GismoCollision;

enum RigidBodyType : int8_t
{
    RIGID_BODY_NONE = 0,
    RIGID_BODY_STATIC = 1,
    RIGID_BODY_DYNAMIC = 2
};

enum RigidBodyMaterial : int8_t
{
    RIGID_BODY_MAT_NONE = 0,
    RIGID_BODY_MAT_WOOD = 1,
    RIGID_BODY_MAT_IRON = 2,
    NUM_RIGID_BODY_MATS = 3
};

typedef struct
{
    float mass;
    float friction;
    float gravityFactor;
    float restitution;
    float linearDamping;
    float angularDamping;
    float maxLinearVelocity;
}
PhysicsParam;

typedef struct
{
    RigidBodyType rigidBodyType;
    RigidBodyMaterial rigidBodyMaterial;
    PhysicsParam physicsParam;
}
GismoRegidBody;

typedef struct
{
    cstring motionName;
    bool syncFrame;
    bool stopEndFrame;
}
MotionData;

typedef struct
{
    cstring texSrtAnimName[3];
    cstring texPatAnimName[3];
    cstring matAnimName[3];
}
MirageAnimData;

enum MotionType : uint8_t
{
    MOTION_SWING = 0,
    MOTION_ROTATE = 1,
    MOTION_LINEAR_SWING = 2
};

typedef struct
{
    MotionType motionType;
    csl::math::Vector3 axis;
    float power;
    float speedScale;
    float time;
}
ProgramMotionData;

typedef struct
{
    cstring effectName;
    bool linkMotionStop;
}
EffectData;

typedef struct
{
    cstring cueName;
}
SoundData;

enum KillType : int8_t
{
    KILL_TYPE_NOT_KILL = 0,
    KILL_TYPE_KILL = 1,
    KILL_TYPE_BREAK = 2,
    KILL_TYPE_MOTION = 3
};

typedef struct
{
    float gravity;
    float lifeTime;
    float mass;
    float friction;
    float explosionScale;
    float impulseScale;
}
DebrisData;

typedef struct
{
    KillType killType;
    float killTime;
    cstring breakMotionName;
    DebrisData debrisData;
}
KillData;

typedef struct
{
    MotionData motionData;
    MirageAnimData mirageAnimData;
    ProgramMotionData programMotionData;
    EffectData effectData;
    SoundData soundData;
    KillData killData;
}
ReactionData;

typedef struct
{
    float rangeIn;
    float rangeDistance;
    GismoBasicParam basicParam;
    GismoCollision collision;
    GismoRegidBody rigidBody;
    ReactionData reactionIdle;
    ReactionData reactionEnter;
    ReactionData reactionLeave;
    ReactionData reactionStay;
    ReactionData reactionStayMove;
    ReactionData reactionDamage;
    bool ignoreMeteorShowerAndRespawnOnReenterRange;
}
GismoConfigDesignData;

