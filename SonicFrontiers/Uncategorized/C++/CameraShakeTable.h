#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    const char* pValue;
    INSERT_PADDING(8);
}
cstring;

enum ShakeType : uint8_t
{
    Directional = 0,
    WorldY = 1,
    Random = 2
};

typedef struct
{
    cstring name;
    ShakeType type;
    float zRot;
    float duration;
    float frequency;
    float amplitude;
    float timeAttenuationRate;
    bool enableDistanceAttenuation;
    float attenuationDistance;
}
CameraShakeRecord;

typedef struct
{
    CameraShakeRecord records[64];
}
CameraShakeTable;

