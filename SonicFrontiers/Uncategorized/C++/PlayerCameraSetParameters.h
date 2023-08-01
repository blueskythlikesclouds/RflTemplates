#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    const char* pValue;
    INSERT_PADDING(8);
}
cstring;

enum Priority : uint8_t
{
    Default = 0,
    High = 1
};

enum CameraType : uint8_t
{
    None = 0,
    Fixed = 1,
    Offset = 2,
    Follow = 3,
    Pan = 4,
    StaticPan = 5,
    PanUpByFront = 6
};

enum CameraCoordType : uint8_t
{
    Orthgonal = 0,
    Spherical = 1
};

typedef struct
{
    CameraType type;
    float time;
    float easeinTime;
    CameraCoordType lookAtCoord;
    csl::math::Vector3 localLookAtOffset;
    csl::math::Vector3 worldLookAtOffset;
    CameraCoordType eyeCoord;
    csl::math::Vector3 localEyeOffset;
    csl::math::Vector3 worldEyeOffset;
    float roll;
}
PlayerCameraParameter;

typedef struct
{
    cstring name;
    float easeoutTime;
    Priority priority;
    PlayerCameraParameter param[8];
}
PlayerCameraSetParameter;

typedef struct
{
    PlayerCameraSetParameter data[45];
}
PlayerCameraSetParameters;

