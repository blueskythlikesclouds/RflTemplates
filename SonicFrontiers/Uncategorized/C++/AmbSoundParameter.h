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
    cstring cueName;
    float fadeInTime;
    float fadeOutTime;
}
AmbInfo;

typedef struct
{
    cstring cueName;
}
AmbBaseNoiseParameter;

typedef struct
{
    cstring cueName;
    float speedThreshold;
    float fadeTime;
}
AmbRelativeWindParameter;

typedef struct
{
    cstring cueName;
    float sensorRebootTime;
    float sensorRepositionTime;
    float lifeAreaRadius;
    float lifeTime;
    float fadeTime;
}
AmbNearPointParameter;

typedef struct
{
    cstring cueName;
    float sensorRadius;
}
AmbRiverParameter_Nearest;

typedef struct
{
    cstring cueName;
    float attenuationDistance;
    float maxLevelPerPoint;
}
AmbRiverParameter_Multiple3D;

typedef struct
{
    AmbInfo ambSoundInfo[8];
    AmbBaseNoiseParameter baseNoise;
    AmbRelativeWindParameter relativeWind;
    AmbNearPointParameter insect;
    AmbNearPointParameter grass;
    AmbRiverParameter_Nearest riverNearest;
    AmbRiverParameter_Multiple3D riverMultiple3D;
}
AmbSoundParameter;

