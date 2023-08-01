#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    int32_t challengeNo0;
    int32_t challengeNo1;
}
ElectricLineConnectData;

typedef struct
{
    int32_t challengeNo0;
    int32_t challengeNo1;
    ElectricLineConnectData data[3];
}
ElectricLineConnectParameter;

typedef struct
{
    ElectricLineConnectParameter connect[200];
}
ElectricLineParameter;

