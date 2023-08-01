#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    float translationLimit;
    float translationSpeedXZ;
    float translationSpeedY;
    float elevLimit;
    float rotationSpeed;
    float rollRange;
    float rollSpeed;
    float fovyRange;
    float fovySpeed;
    float speedRatioFast;
    float speedRatioSlow;
    float distance;
}
PhotoModeCameraParameters;

typedef struct
{
    float sepiaSaturationOffset;
    float sepiaColorizeRate;
    float sepiaColorizeHue;
    float increaseSaturationOffset;
    int32_t warmColorROffset;
    int32_t warmColorGOffset;
    int32_t warmColorBOffset;
    int32_t coldColorROffset;
    int32_t coldColorGOffset;
    int32_t coldColorBOffset;
    float retroContrastOffset;
    int32_t retroROffset;
    int32_t retroGOffset;
    int32_t retroBOffset;
    float retroSaturationOffset;
}
PhotoModeFilterParameters;

typedef struct
{
    PhotoModeCameraParameters camera;
    PhotoModeFilterParameters filter;
}
PhotoModeParameters;

