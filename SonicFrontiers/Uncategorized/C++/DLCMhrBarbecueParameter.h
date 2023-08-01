#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    uint32_t rawToken;
    uint32_t rawBurnToken;
    uint32_t brownedToken;
    uint32_t charredToken;
}
DLCMhrBarbecueTokenParam;

typedef struct
{
    float rawTime;
    float rawBurnTime;
    float brownedTime;
    float charredTime;
    float startwaitTime;
    float successTime;
    float missTime;
    float resultUIDelaySuccess;
    float resultUIDelayFaild;
    DLCMhrBarbecueTokenParam tokenParam[4];
}
DLCMhrBarbecueParameter;

