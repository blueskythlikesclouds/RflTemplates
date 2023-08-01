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
    float distance;
    float noiseTextureScrollSpeed;
    float blurScale;
    float colorGain;
    float noiseGain;
}
AuraEffectLerpNode;

typedef struct
{
    cstring name;
    AuraEffectLerpNode node[2];
}
AuraEffectLerpParameter;

typedef struct
{
    AuraEffectLerpParameter params[4];
}
AuraEffectParameters;

typedef struct
{
    float localLightIntensityScale;
    bool dropPriorityEnabled;
    int8_t dropPriority;
}
EffectParameters;

typedef struct
{
    uint8_t blockWeights[5];
}
WeatherBlockParameter;

typedef struct
{
    uint8_t transitWeights[5];
    WeatherBlockParameter blockParams[5];
}
WeatherTypeParameter;

typedef struct
{
    uint8_t hour;
    uint8_t minute;
}
WeatherTimeParameter;

typedef struct
{
    WeatherTimeParameter sunriseBeginTime;
    WeatherTimeParameter dayBeginTime;
    WeatherTimeParameter sunsetBeginTime;
    WeatherTimeParameter nightBeginTime;
    WeatherTimeParameter blockTime;
}
WeatherTimeControlParameter;

typedef struct
{
    WeatherTypeParameter type[5];
    WeatherTimeControlParameter timeControl;
}
WeatherParameters;

typedef struct
{
    AuraEffectParameters aura;
    EffectParameters effect;
    WeatherParameters weather;
}
GraphicsParameters;

