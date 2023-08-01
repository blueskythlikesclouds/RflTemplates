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
    uint8_t alpha;
    uint8_t red;
    uint8_t green;
    uint8_t blue;
}
color8;

enum Orientation : int8_t
{
    ORIENTATION_NONE = 0,
    ORIENTATION_HORIZONTAL = 1,
    ORIENTATION_VERTICAL = 2,
    ORIENTATION_DIAGONAL = 3
};

typedef struct
{
    Orientation orientation;
    int8_t srcPosX;
    int8_t srcPosY;
    int8_t dstPosX;
    int8_t dstPosY;
    color8 srcColor;
    color8 dstColor;
}
DecoGradationParam;

enum DecoLayerBlendOp : int8_t
{
    DECO_LAYER_BLEND_OP_BLEND = 0,
    DECO_LAYER_BLEND_OP_SUBTRACT_ALPHA = 1
};

typedef struct
{
    color8 color;
    uint8_t size;
    uint8_t spread;
    int8_t distanceX;
    int8_t distanceY;
}
DecoDropShadowParam;

typedef struct
{
    color8 color;
    int32_t thickness;
    int32_t offsetX;
    int32_t offsetY;
}
DecoRimParam;

typedef struct
{
    int32_t radius;
}
DecoBlurParam;

typedef struct
{
    DecoDropShadowParam dropShadow;
    DecoRimParam rim;
    DecoGradationParam gradation;
    DecoBlurParam blur;
    bool avoidEdgeArtifact;
}
DecoPassParam;

typedef struct
{
    cstring name;
    color8 fontColor;
    DecoGradationParam fontGradParam;
    DecoLayerBlendOp layerBlendOp;
    int32_t numPasses;
    DecoPassParam passParams[5];
}
DecoTechParam;

typedef struct
{
    DecoTechParam params[512];
}
DecoTechParams;

