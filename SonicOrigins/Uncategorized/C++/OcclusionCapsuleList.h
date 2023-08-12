#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    const char* pValue;
    INSERT_PADDING(8);
}
cstring;

enum VolumeType : int8_t
{
    VOLUME_SPHERE = 0,
    VOLUME_CAPSULE = 1
};

enum LODLevel : int8_t
{
    LOD_HIGH = 0,
    LOD_MIDDLE = 1,
    LOD_LOW = 2
};

typedef struct
{
    cstring type;
    VolumeType volume;
    int32_t priority;
    csl::math::Vector3 translation;
    csl::math::Vector3 rotation;
    csl::math::Vector3 scale;
    csl::math::Vector3 rate;
    float radius;
    LODLevel lod;
}
CapsuleParam;

typedef struct
{
    CapsuleParam capsules[64];
}
OcclusionCapsuleList;

