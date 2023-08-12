#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    float blockLNoiseSizeX;
    float blockLNoiseSizeY;
    float blockHNoiseSizeX;
    float blockHNoiseSizeY;
    float bNoiseHighRate;
    float intensity;
    float pixelShiftIntensity;
}
UVShift;

typedef struct
{
    float blockLNoiseSize;
    float blockHNoiseSize;
    float bNoiseHighRate;
    float intensity;
}
ColorShift;

typedef struct
{
    float blockLNoiseSize;
    float blockHNoiseSize;
    float bNoiseHighRate;
    float intensity;
    float dropout;
}
InterlaceNoise;

typedef struct
{
    float blockLNoiseSizeX;
    float blockLNoiseSizeY;
    float blockHNoiseSizeX;
    float blockHNoiseSizeY;
    float bNoiseHighRate;
    float intensity;
}
ColorDropout;

typedef struct
{
    float blockLNoiseSizeX;
    float blockLNoiseSizeY;
    float blockHNoiseSizeX;
    float blockHNoiseSizeY;
    float bNoiseHighRate;
    float intensity;
    float invertAllRate;
}
InvertColor;

typedef struct
{
    float blockLNoiseSizeX;
    float blockLNoiseSizeY;
    float blockHNoiseSizeX;
    float blockHNoiseSizeY;
    float bNoiseHighRate;
    float intensity;
    float invertAllRate;
}
GlayScaleColor;

typedef struct
{
    bool enable;
    UVShift uvShift;
    ColorShift colorShift;
    InterlaceNoise interlaceNoise;
    ColorDropout colorDrop;
    InvertColor invertColor;
    GlayScaleColor glayscaleColor;
    float noiseSpeed;
    float noiseBias;
    float noiseWaveAmplitude;
    float noiseWaveCycle;
}
FxCyberSpaceStartNoiseParameter;

