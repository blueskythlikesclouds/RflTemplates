#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

enum RenderTargetSize : int32_t
{
    RTSIZE_FULL_SCALE = 0,
    RTSIZE_HALF_SCALE = 1,
    RTSIZE_QUARTER_SCALE = 2,
    RTSIZE_COUNT = 3,
    RTSIZE_INVALID = 3
};

typedef struct
{
    bool enable;
    bool useFocusLookAt;
    float foregroundBokehMaxDepth;
    float foregroundBokehStartDepth;
    float backgroundBokehStartDepth;
    float backgroundBokehMaxDepth;
    bool enableCircleDOF;
    float cocMaxRadius;
    float bokehRadiusScale;
    int32_t bokehSampleCount;
    float skyFocusDistance;
    float bokehBias;
    bool drawFocalPlane;
    RenderTargetSize rtScale;
    bool enableSWA;
    float swaFocus;
    float swaFocusRange;
    float swaNear;
    float swaFar;
    bool enableEnhancedForeBokeh;
    float foreBokehScale;
    float foreBokehMaxLuminance;
}
FxDOFParameter;

typedef struct
{
    csl::math::Vector3 camerapos;
    float lineAlpha;
    float noiseScale;
    float noiseSpeed;
    float moveWidth;
    FxDOFParameter dofparam;
}
UIWireframeParameter;

