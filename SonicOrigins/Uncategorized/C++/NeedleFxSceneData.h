#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

enum DOFRenderTargetSize : int32_t
{
    DOF_RTSIZE_FULL_SCALE = 0,
    DOF_RTSIZE_HALF_SCALE = 1,
    DOF_RTSIZE_QUARTER_SCALE = 2,
    DOF_RTSIZE_COUNT = 3,
    DOF_RTSIZE_INVALID = 3
};

typedef struct
{
    DOFRenderTargetSize dofRenderTargetScale;
    int32_t shadowMapWidth;
    int32_t shadowMapHeight;
}
FxRenderTargetSetting;

enum AntiAliasingType : int8_t
{
    AATYPE_NONE = 0,
    AATYPE_TAA = 1,
    AATYPE_FXAA = 2,
    AATYPE_SMAA = 3,
    AATYPE_LAST = 4
};

enum UpscaleType : int8_t
{
    USTYPE_LINEAR = 0,
    USTYPE_FSR = 1,
    USTYPE_FSR_FAST = 2,
    USTYPE_FSR_EASU = 3,
    USTYPE_FSR_RCAS = 4
};

typedef struct
{
    AntiAliasingType aaType;
    UpscaleType usType;
}
FxAntiAliasing;

typedef struct
{
    float illuminanceScale;
}
StageCommonAtmosphereParameter;

typedef struct
{
    bool enableDebugDrawLayerRange;
    float layerRange[32];
}
FxLODParameter;

typedef struct
{
    float detailDistance;
    float detailFadeRange;
}
FxDetailParameter;

enum Mode : int8_t
{
    DISABLE = 0,
    ENABLE = 1,
    FIXED_RESOLUTION = 2
};

typedef struct
{
    Mode mode;
    float fixedResolutionRatio;
    float minResolutionRatio;
    float minTargetTimeDifference;
    float maxTargetTimeDifference;
    float increaseRate;
    float decreaseRate;
    float increaseMaxScaleDelta;
    float decreaseMaxScaleDelta;
    bool debugSineFluctuation;
}
FxDynamicResolutionParameter;

typedef struct
{
    uint8_t hour;
    uint8_t minute;
}
HourMinuteData;

typedef struct
{
    HourMinuteData beginTime;
    HourMinuteData endTime;
}
TimeIntervalData;

typedef struct
{
    TimeIntervalData timeIntervalData;
    float hourlyTime;
}
ProgressTimePairData;

typedef struct
{
    bool enable;
    float solarRadiusScale;
    float azimuthAngle;
    float latitude;
    float longitude;
    int32_t month;
    int32_t day;
    float time;
    float hourlyTime;
    ProgressTimePairData overrideSpeeds[8];
    TimeIntervalData night;
}
StageCommonTimeProgressParameter;

typedef struct
{
    bool enableDrawGrid;
}
FxTerrainParameter;

typedef struct
{
    bool zprepass;
}
FxModelParameter;

typedef struct
{
    FxRenderTargetSetting rendertarget;
    FxAntiAliasing antialiasing;
    StageCommonAtmosphereParameter atmosphere;
    FxLODParameter lod;
    FxDetailParameter detail;
    FxDynamicResolutionParameter dynamicResolution;
    StageCommonTimeProgressParameter timeProgress;
    FxTerrainParameter terrain;
    FxModelParameter modelParam;
}
NeedleFxSceneConfig;

enum DebugViewType : int8_t
{
    DEBUG_VIEW_DEFAULT = 0,
    DEBUG_VIEW_DIR_DIFFUSE = 1,
    DEBUG_VIEW_DIR_SPECULAR = 2,
    DEBUG_VIEW_AMB_DIFFUSE = 3,
    DEBUG_VIEW_AMB_SPECULAR = 4,
    DEBUG_VIEW_ONLY_IBL = 5,
    DEBUG_VIEW_ONLY_IBL_SURF_NORMAL = 6,
    DEBUG_VIEW_SHADOW = 7,
    DEBUG_VIEW_WHITE_ALBEDO = 8,
    DEBUG_VIEW_WHITE_ALBEDO_NO_AO = 9,
    DEBUG_VIEW_USER0 = 10,
    DEBUG_VIEW_USER1 = 11,
    DEBUG_VIEW_USER2 = 12,
    DEBUG_VIEW_USER3 = 13,
    DEBUG_VIEW_ALBEDO = 14,
    DEBUG_VIEW_ALBEDO_CHECK_OUTLIER = 15,
    DEBUG_VIEW_OPACITY = 16,
    DEBUG_VIEW_NORMAL = 17,
    DEBUG_VIEW_ROUGHNESS = 18,
    DEBUG_VIEW_AMBIENT = 19,
    DEBUG_VIEW_CAVITY = 20,
    DEBUG_VIEW_REFLECTANCE = 21,
    DEBUG_VIEW_METALLIC = 22,
    DEBUG_VIEW_LOCAL_LIGHT = 23,
    DEBUG_VIEW_SCATTERING_FEX = 24,
    DEBUG_VIEW_SCATTERING_LIN = 25,
    DEBUG_VIEW_SSAO = 26,
    DEBUG_VIEW_RLR = 27,
    DEBUG_VIEW_IBL_DIFFUSE = 28,
    DEBUG_VIEW_IBL_SPECULAR = 29,
    DEBUG_VIEW_ENV_BRDF = 30,
    DEBUG_VIEW_WORLD_POSITION = 31,
    DEBUG_VIEW_SHADING_MODEL_ID = 32,
    DEBUG_VIEW_IBL_CAPTURE = 33,
    DEBUG_VIEW_IBL_SKY_TERRAIN = 34,
    DEBUG_VIEW_WRITE_DEPTH_TO_ALPHA = 35,
    DEBUG_VIEW_SMOOTHNESS = 36,
    DEBUG_VIEW_OCCLUSION_CAPSULE = 37,
    DEBUG_VIEW_PROBE = 38,
    DEBUG_VIEW_COUNT = 39,
    DEBUG_VIEW_INVALID = 39
};

enum LocalLightCullingType : int8_t
{
    LOCAL_LIGHT_CULLING_TYPE_NONE = 0,
    LOCAL_LIGHT_CULLING_TYPE_CPU_TILE = 1,
    LOCAL_LIGHT_CULLING_TYPE_GPU_TILE = 2,
    LOCAL_LIGHT_CULLING_TYPE_GPU_CLUSTER = 3,
    LOCAL_LIGHT_CULLING_TYPE_COUNT = 4,
    LOCAL_LIGHT_CULLING_TYPE_DEFAULT = 0
};

enum TextureViewType : int8_t
{
    TEXTURE_VIEW_NONE = 0,
    TEXTURE_VIEW_DEPTH = 1,
    TEXTURE_VIEW_LUMINANCE = 2,
    TEXTURE_VIEW_DOF_BOKEH = 3,
    TEXTURE_VIEW_DOF_BOKEH_NEAR = 4,
    TEXTURE_VIEW_SSAO_SOURCE = 5,
    TEXTURE_VIEW_DOWNSAMPLE = 6,
    TEXTURE_VIEW_COUNT = 7
};

enum AmbientSpecularType : int8_t
{
    AMBIENT_SPECULAR_NONE = 0,
    AMBIENT_SPECULAR_SG = 1,
    AMBIENT_SPECULAR_IBL = 2,
    AMBIENT_SPECULAR_BLEND = 3
};

enum ChannelMode : int8_t
{
    CHANNELMODE_RGB = 0,
    CHANNELMODE_RRR = 1,
    CHANNELMODE_GGG = 2,
    CHANNELMODE_BBB = 3,
    CHANNELMODE_AAA = 4,
    CHANNELMODE_RG = 5,
    CHANNELMODE_BA = 6
};

enum DebugScreenType : int8_t
{
    DEBUG_SCREEN_GBUFFER0 = 0,
    DEBUG_SCREEN_GBUFFER1 = 1,
    DEBUG_SCREEN_GBUFFER2 = 2,
    DEBUG_SCREEN_GBUFFER3 = 3,
    DEBUG_SCREEN_DEPTHBUFFER = 4,
    DEBUG_SCREEN_CSM0 = 5,
    DEBUG_SCREEN_CSM1 = 6,
    DEBUG_SCREEN_CSM2 = 7,
    DEBUG_SCREEN_CSM3 = 8,
    DEBUG_SCREEN_HDR = 9,
    DEBUG_SCREEN_BLOOM = 10,
    DEBUG_SCREEN_RLR = 11,
    DEBUG_SCREEN_GODRAY = 12,
    DEBUG_SCREEN_SSAO = 13,
    DEBUG_SCREEN_CSM_CACHE0 = 14,
    DEBUG_SCREEN_CSM_CACHE1 = 15,
    DEBUG_SCREEN_CSM_CACHE2 = 16,
    DEBUG_SCREEN_CSM_CACHE3 = 17,
    DEBUG_SCREEN_CSM_CACHE4 = 18,
    DEBUG_SCREEN_CSM_CACHE5 = 19,
    DEBUG_SCREEN_CUSTOM0 = 20,
    DEBUG_SCREEN_CUSTOM1 = 21,
    DEBUG_SCREEN_CUSTOM2 = 22,
    DEBUG_SCREEN_CUSTOM3 = 23
};

enum ErrorCheckType : int8_t
{
    ERROR_CHECK_NONE = 0,
    ERROR_CHECK_NAN = 1,
    ERROR_CHECK_ALBEDO = 2,
    ERROR_CHECK_NORMAL = 3
};

enum VisualizeMode : int8_t
{
    DEFAULT = 0,
    HEATMAP_TYPE0 = 1,
    HEATMAP_TYPE1 = 2,
    HEATMAP_TYPE2 = 3,
    VECTOR2D_TYPE0 = 4,
    VECTOR2D_TYPE1 = 5,
    VECTOR2D_TYPE2 = 6
};

typedef struct
{
    bool enable;
    bool fullScreen;
    ChannelMode channelMode;
    float min;
    float max;
    int32_t renderTargetType;
    int32_t depthTargetType;
    DebugScreenType screenType;
    ErrorCheckType errorCheck;
    VisualizeMode visualizeMode;
}
DebugScreenOption;

enum DebugScreenView : int8_t
{
    DEBUG_SCREEN_VIEW_DEFAULT = 0,
    DEBUG_SCREEN_VIEW_ALL_ENABLE = 1,
    DEBUG_SCREEN_VIEW_ALL_DISABLE = 2
};

typedef struct
{
    bool enable;
    csl::math::Vector4 value;
}
GlobalUserParamOption;

typedef struct
{
    DebugViewType debugViewType;
    bool clearRenderTarget;
    bool enableDrawCubeProbe;
    bool enableDirectionalLight;
    bool enablePointLight;
    bool enableEffectDeformation;
    bool enableLitePostEffect;
    LocalLightCullingType localLightCullingType;
    float localLightScale;
    float shadowIBLAttenuation;
    int32_t maxCubeProbe;
    bool debugEnableDrawLocalLight;
    TextureViewType debugTextureViewType;
    bool debugEnableOutputTextureView;
    int32_t debugScreenshotResolutionHeight;
    float debugScreenshotDepthNear;
    float debugScreenshotDepthFar;
    AmbientSpecularType debugAmbientSpecularType;
    bool debugEnableSGGIVer2nd;
    bool debugEnableAOGI;
    DebugScreenOption debugScreen[16];
    DebugScreenView debugScreenView;
    bool enableMSAA;
    bool debugEnableDrawFrustumCullFrustum;
    bool debugEnableFixFrustumCullFrustum;
    int32_t debugDrawFrustumCullGroupSettingIndex;
    bool debugEnableOcclusionCullingView;
    int32_t debugOccluderVertThreshold;
    GlobalUserParamOption globalUserParam[4];
}
FxRenderOption;

typedef struct
{
    float sgStartSmoothness;
    float sgEndSmoothness;
    float doStartSmoothness;
    float doEndSmoothness;
    float doOffset;
    float aoOffset;
}
FxSGGIParameter;

typedef struct
{
    bool enable;
    bool traceSky;
    bool useTrans;
    bool usePenet;
    bool useQuat;
    bool useNormal;
    float rayMarchingCount;
    float planeNormalDist;
    float traceThreshold;
    float resolveReproj;
    float overrideRatio;
    float maxRoughness;
    float roughnessLevel;
    float uvOffsetScale;
}
FxRLRParameter;

typedef struct
{
    bool enable;
    csl::math::Vector4 plane;
    uint32_t width;
    uint32_t height;
}
FxPlanarReflectionParameter;

typedef struct
{
    bool enable;
    float bloomScale;
    float sampleRadiusScale;
    int32_t blurQuality;
}
FxBloomParameter;

enum Exposure : int8_t
{
    EXPOSURE_MANUAL = 0,
    EXPOSURE_AUTO = 1
};

typedef struct
{
    float exposureValue;
}
FxManualExposureParameter;

enum LUMINANCE_RANGE : int8_t
{
    LUMINANCE_RANGE_CLAMP = 0,
    LUMINANCE_RANGE_CUTOFF = 1,
    LUMINANCE_RANGE_CUTOFF_PCT_RATE = 2,
    LUMINANCE_RANGE_CUTOFF_PCT_AREA = 3
};

typedef struct
{
    float middleGray;
    float lumMax;
    float lumMin;
    float cutMax;
    float cutMin;
    float pctMax;
    float pctMin;
    float adaptedRatio;
    LUMINANCE_RANGE luminanceRangeType;
}
FxAutoExposureParameter;

typedef struct
{
    Exposure exposureType;
    FxManualExposureParameter manualExposure;
    FxAutoExposureParameter autoExposure;
}
FxCameraControlParameter;

enum Tonemap : int8_t
{
    TONEMAP_DISNEY = 0,
    TONEMAP_FILMIC = 1,
    TONEMAP_ACES = 2,
    TONEMAP_GT = 3
};

typedef struct
{
    float whitePoint;
    float toeStrength;
    float linearAngle;
    float linearStrength;
    float shoulderStrength;
}
FxToneMapParameterFilmic;

typedef struct
{
    float maxDisplayBrightness;
    float contrast;
    float linearSectionStart;
    float linearSectionLength;
    float black;
}
FxToneMapParameterGT;

typedef struct
{
    Tonemap tonemapType;
    FxToneMapParameterFilmic tonemapParamFilmic;
    FxToneMapParameterGT tonemapParamGT;
    bool updateLuminance;
}
FxToneMapParameter;

enum LutIndex : int32_t
{
    LUT_INDEX_DEFAULT = 0,
    LUT_INDEX_WB = 1,
    LUT_INDEX_USER_0 = 2,
    LUT_INDEX_USER_1 = 3,
    LUT_INDEX_USER_2 = 4,
    LUT_INDEX_USER_3 = 5,
    LUT_INDEX_USER_4 = 6,
    LUT_INDEX_USER_5 = 7,
    LUT_INDEX_COUNT = 8
};

typedef struct
{
    bool enable;
    float contrast;
    float dynamicRange;
    float crushShadows;
    float crushHilights;
    bool useLut;
    LutIndex lutIndex0;
    LutIndex lutIndex1;
    float blendRatio;
    float lutRatio;
    bool useHlsCorrection;
    float hlsHueOffset;
    float hlsLightnessOffset;
    float hlsSaturationOffset;
    int32_t hlsColorOffset[3];
    float hlsColorizeRate;
    float hlsColorizeHue;
}
FxColorContrastParameter;

typedef struct
{
    bool enable;
    csl::math::Vector3 color;
    float inScatteringScale;
    csl::math::Vector3 betaRayleigh;
    float betaMie;
    float g;
    float znear;
    float zfar;
    float depthScale;
}
FxLightScatteringParameter;

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

enum ShadowRenderingType : int8_t
{
    SHADOW_RENDERING_TYPE_SHADOW_MAP = 0,
    SHADOW_RENDERING_TYPE_PLANAR_PROJECTION = 1,
    SHADOW_RENDERING_TYPE_PLANAR_PROJECTION_SHADOW_MAP = 2,
    SHADOW_RENDERING_TYPE_MULTI_SHADOW_MAP = 3,
    SHADOW_RENDERING_TYPE_COUNT = 4
};

enum ShadowFilter : int8_t
{
    SHADOW_FILTER_POINT = 0,
    SHADOW_FILTER_PCF = 1,
    SHADOW_FILTER_PCSS = 2,
    SHADOW_FILTER_ESM = 3,
    SHADOW_FILTER_MSM = 4,
    SHADOW_FILTER_VSM_POINT = 5,
    SHADOW_FILTER_VSM_LINEAR = 6,
    SHADOW_FILTER_VSM_ANISO_2 = 7,
    SHADOW_FILTER_VSM_ANISO_4 = 8,
    SHADOW_FILTER_VSM_ANISO_8 = 9,
    SHADOW_FILTER_VSM_ANISO_16 = 10,
    SHADOW_FILTER_COUNT = 11,
    SHADOW_FILTER_VSM_FIRST = 5,
    SHADOW_FILTER_VSM_LAST = 10
};

enum ShadowRangeType : int8_t
{
    SHADOW_RANGE_TYPE_CAMERA_LOOKAT = 0,
    SHADOW_RANGE_TYPE_POSITION_MANUAL = 1,
    SHADOW_RANGE_TYPE_FULL_MANUAL = 2,
    SHADOW_RANGE_TYPE_COUNT = 3,
    SHADOW_RANGE_TYPE_DEFAULT = 0
};

enum FitProjection : int8_t
{
    FIT_PROJECTION_TO_CASCADES = 0,
    FIT_PROJECTION_TO_SCENE = 1
};

enum FitNearFar : int8_t
{
    FIT_NEARFAR_ZERO_ONE = 0,
    FIT_NEARFAR_AABB = 1,
    FIT_NEARFAR_SCENE_AABB = 2
};

enum PartitionType : int8_t
{
    PARTITION_PSSM = 0,
    PARTITION_MANUAL = 1
};

typedef struct
{
    ShadowRenderingType renderingType;
    bool enable;
    ShadowFilter shadowFilter;
    ShadowRangeType shadowRangeType;
    FitProjection fitProjection;
    FitNearFar fitNearFar;
    PartitionType partitionType;
    float sceneRange;
    float sceneCenter[3];
    float manualLightPos[3];
    float pssmLambda;
    float cascadeOffset;
    int32_t cascadeLevel;
    float cascadeSplits[4];
    float cascadeBias[4];
    float bias;
    float offset;
    float normalBias;
    int32_t width;
    int32_t height;
    int32_t blurQuality;
    int32_t blurSize;
    float fadeoutDistance;
    float cascadeTransitionfadeDistance;
    bool enableCSMCache;
    float csmCacheMaxHeight;
    float csmCacheMinHeight;
    int32_t csmCacheMaxRenderPass;
    float csmCacheFixedFovy;
    float csmCacheLightDirectionThreshold;
    bool csmCacheParallaxCorrectionEnabled;
    float csmCacheParallaxCorrectionHorizontalBias;
    float csmCacheParallaxCorrectionVerticalBias;
    int32_t csmCacheFramesToRender[3];
    float csmCacheFadeLightElevationAngle;
    float csmCacheMinLightElevationAngle;
    csl::math::Matrix44 shadowCameraViewMatrix;
    csl::math::Matrix44 shadowCameraProjectionMatrix;
    float shadowCameraNearDepth;
    float shadowCameraFarDepth;
    float shadowCameraLookAtDepth;
    bool enableBackFaceShadow;
    bool enableShadowCamera;
    bool enableDrawSceneAABB;
    bool enableDrawShadowFrustum;
    bool enableDrawCascade;
    bool enableDrawCameraFrustum;
    bool enableDrawCSMCache;
    bool enableClearOnCSMCacheIsInvalidated;
    bool enablePauseCamera;
}
FxShadowMapParameter;

typedef struct
{
    bool enable;
    float bias;
    float distanceFalloff;
    float heightFalloffMinHeight;
    float heightFalloffDistance;
}
FxShadowHeightMapParameter;

enum SSAOType : int8_t
{
    SSAO = 0,
    HBAO = 1,
    HBAO_SSS = 2,
    SSS = 3,
    TYPE_COUNT = 4
};

enum FxSSAOParameter_RenderTargetSize : int8_t
{
    RTSIZE_SAME_AS_FRAMEBUFFER = 0,
    RTSIZE_ONE_SECOND = 1,
    RTSIZE_ONE_FORTH = 2,
    FxSSAOParameter_RenderTargetSize_RTSIZE_COUNT = 3
};

enum BLURType : int8_t
{
    None = 1,
    Gauss2x2 = 2,
    Gauss3x3 = 3,
    Gauss4x4 = 4,
    Gauss5x5 = 5,
    Gauss6x6 = 6,
    Gauss7x7 = 7,
    Gauss8x8 = 8,
    Gauss9x9 = 9,
    Bilateral = 10,
    BLUR_COUNT = 11
};

typedef struct
{
    float intensity;
    float radius;
    float fadeoutDistance;
    float fadeoutRadius;
    float power;
    float bias;
    float occlusionDistance;
    float directLightingInfluence;
}
FxSSAO_Parameter;

typedef struct
{
    float hbaoPower;
    float hbaoBias;
    float hbaoRadius;
    float hbaoFalloff;
    float hbaoSteps;
    float hbaoGitter;
    int8_t hbaoRaycount;
    bool hbaoGiMaskEnable;
}
FxHBAO_Parameter;

typedef struct
{
    float sssRayLength;
    int8_t sssRaycount;
    float sssBias;
    float sssIntensity;
    float sssDepthMin;
    float sssDepthMax;
    float sssLightDistance;
    float sssThickness;
    bool sssGiMaskEnable;
    float sssLimit;
    bool sssDitherEnable;
}
FxSSS_Parameter;

typedef struct
{
    bool enable;
    SSAOType postType;
    FxSSAOParameter_RenderTargetSize renderTargetSize;
    BLURType blurStep;
    float bilateralThreshold;
    FxSSAO_Parameter ssaoParam;
    FxHBAO_Parameter hbaoParam;
    FxSSS_Parameter sssParam;
}
FxSSAOParameter;

enum DebugDrawType : int8_t
{
    DEBUG_DRAW_NONE = 0,
    DEBUG_DRAW_ONLY_ENABLED = 1,
    DEBUG_DRAW_ALL = 2
};

typedef struct
{
    bool enable;
    float blendRatio;
}
FxLightFieldMergeParameter;

typedef struct
{
    bool enable;
    DebugDrawType debugDrawType;
    bool showSkyVisibility;
    float debugProbeSize;
    csl::math::Vector3 multiplyColorUp;
    csl::math::Vector3 multiplyColorDown;
    float normalBias;
    FxLightFieldMergeParameter lfMerge;
}
FxSHLightFieldParameter;

enum BlurType : int8_t
{
    BLURTYPE_PREV_SURFACE = 0,
    BLURTYPE_RADIAL = 1,
    BLURTYPE_CAMERA = 2,
    BLURTYPE_COUNT = 3
};

enum FocusType : int8_t
{
    FOCUSTYPE_CENTER = 0,
    FOCUSTYPE_LOOKAT = 1,
    FOCUSTYPE_USER_SETTING = 2,
    FOCUSTYPE_COUNT = 3
};

typedef struct
{
    bool enable;
    BlurType blurType;
    float blurPower;
    FocusType focusType;
    csl::math::Vector3 focusPosition;
    float focusRange;
    float alphaSlope;
    int32_t sampleNum;
    bool singleDirectionOpt;
}
FxScreenBlurParameter;

typedef struct
{
    uint8_t alpha;
    uint8_t red;
    uint8_t green;
    uint8_t blue;
}
color8;

typedef struct
{
    bool enable;
    bool enableOcclusion;
    color8 occlusionColor;
    float occlusionPower;
    bool enableSpecularOcclusion;
    float specularOcclusionAlpha;
    float specularOcclusionPower;
    float specularOcclusionConeAngle;
    bool enableShadow;
    color8 shadowColor;
    float shadowPower;
    float shadowConeAngle;
    float cullingDistance;
    bool enableManualLight;
    int32_t manualLightCount;
    csl::math::Vector3 manualLightPos[4];
    bool debugDraw;
}
FxOcclusionCapsuleParameter;

typedef struct
{
    float lightFieldColorCoefficient;
    float invTonemapCoefficient;
    csl::math::Vector3 shadowColor;
    csl::math::Vector3 directionalLightOverwrite;
    float directionalLightIntensityOverwrite;
    bool overwriteDirectionalLight;
    float localLightIntensityScale;
    float lodDistances[8];
    bool enableVisualizeOverdraw;
    bool renderWireframe;
}
FxEffectParameter;

typedef struct
{
    bool enable;
    float rayMarchingCount;
    float density;
    float decay;
    float threshold;
    float lumMax;
    float intensity;
    bool enableDither;
    csl::math::Vector3 lightPos;
    csl::math::Vector3 lightDir;
}
FxScreenSpaceGodrayParameter;

typedef struct
{
    bool enableVolumeTexture;
    float uvScale;
    float timeScale;
    float animationAngle;
}
FxGodrayVolumeTexture;

typedef struct
{
    bool enable;
    bool isUseShadowmap;
    bool isVariableStep;
    csl::math::Matrix44 shadow;
    csl::math::Matrix34 box;
    csl::math::Vector3 color;
    float density;
    float anisotropy;
    float range;
    float rayMarchingCount;
    float rayMarchingStep;
    float shadowEdge;
    bool isScanFromBack;
    int32_t boxCount;
    bool isNewMode;
    FxGodrayVolumeTexture volumeTexture;
    float transparency;
    bool enable3d;
    float reProject3d;
    float logNear3d;
}
FxGodrayParameter;

typedef struct
{
    bool enable;
    float speed;
    float scale;
    float cycle;
    float nearDepth;
    float farDepth;
    float maxHeight;
    float parallaxCorrectFactor;
}
FxHeatHazeParameter;

enum SunPosType : int8_t
{
    SUN_POS_TYPE_NONE = 0,
    SUN_POS_TYPE_ANGLE = 1,
    SUN_POS_TYPE_EARTH = 2
};

typedef struct
{
    float azimuthAngle;
    float elevationAngle;
}
FxSunPosAngle;

typedef struct
{
    float azimuthAngle;
    float latitude;
    float longitude;
    int32_t month;
    int32_t day;
    float time;
    bool enableAnimation;
    float animationSpeed;
}
FxSunPosEarth;

typedef struct
{
    float solarRadiusScale;
    SunPosType sunPosType;
    FxSunPosAngle posTypeAngle;
    FxSunPosEarth posTypeEarth;
}
FxSun;

enum MoonPosType : int8_t
{
    MOON_POS_TYPE_NONE = 0,
    MOON_POS_TYPE_INV_SUN = 1,
    MOON_POS_TYPE_EARTH = 2
};

typedef struct
{
    MoonPosType moonPosType;
}
FxMoon;

enum SkyModel : int8_t
{
    BRUNETON = 0,
    SEBASTIEN = 1
};

typedef struct
{
    SkyModel skyModel;
    float illuminanceScale;
    bool enableScattering;
    float scatteringRatio;
}
FxSkyCommon;

typedef struct
{
    float lunarIntensityInSky;
    float starIntensityInSky;
    float lunarIntensityInCloud;
    float lunarIntensity;
    float skyIntensity;
    color8 lunarLightColor;
    csl::math::Vector4 lunarLightColorOffset;
    float lunarLightPower;
}
FxBrunetonSkyNight;

typedef struct
{
    float illuminanceScale;
    color8 rayleighColor;
    color8 lightColorScale;
    float miePhaseFunctionG;
    color8 mieScatteringColor;
    float mieScatteringScale;
    color8 mieAbsorptionColor;
    float mieAbsorptionScale;
    color8 rayleighScatteringColor;
    float rayleighScatteringScale;
    color8 groundAlbedo;
    color8 groundIrradianceScale;
    color8 cubemapColorScale;
    float cubemapColorAngleRatio;
    bool enableScattering;
    float scatteringRatio;
    FxBrunetonSkyNight night;
    bool enableLimitY;
    float debugSkyCubeIntensity;
}
FxBrunetonSky;

typedef struct
{
    float miePhaseFunctionG;
    color8 mieScatteringColor;
    csl::math::Vector4 mieScatteringColorOffset;
    float mieScatteringScale;
    color8 mieAbsorptionColor;
    csl::math::Vector4 mieAbsorptionColorOffset;
    float mieAbsorptionScale;
    color8 rayleighScatteringColor;
    csl::math::Vector4 rayleighScatteringColorOffset;
    float rayleighScatteringScale;
    color8 groundAlbedo;
    csl::math::Vector4 groundAlbedoOffset;
    bool enableGround;
    int32_t numScatteringOrder;
    bool enableScattering;
    bool enableLimitY;
}
FxSebastienSky;

typedef struct
{
    csl::math::Vector3 uvScale;
    csl::math::Vector3 colorGamma;
    csl::math::Vector3 colorScale;
    csl::math::Vector3 colorOffset;
}
FxCloudProcedural;

typedef struct
{
    bool enable;
    float probability;
    float cloudiness;
    FxCloudProcedural proceduralCloud;
}
FxCloudBlendParameter;

typedef struct
{
    bool enable;
    bool enableAnimation;
    float animationFrame;
    float animationSpeed;
    float animationAngle;
    float animationSpeedCirrus;
    float animationAngleCirrus;
    float skyHorizonOffset;
    float cloudStartHeight;
    float cloudCoverageSpeed;
    float cloudTypeSpeed;
    float cloudWetnessSpeed;
    float miePhaseFunctionG;
    float silverIntensity;
    float silverSpread;
    float scale;
    float density;
    float densityThreshold;
    color8 cloudsExtinctionColor1;
    csl::math::Vector4 cloudsExtinctionColor1Offset;
    color8 cloudsExtinctionColor2;
    csl::math::Vector4 cloudsExtinctionColor2Offset;
    color8 cloudsExtinctionColor3;
    csl::math::Vector4 cloudsExtinctionColor3Offset;
    float cloudExtinctionBlend;
    bool enableShadow;
    int32_t shadowCoverage;
    float shadowValueMin;
    FxCloudBlendParameter blendParam;
}
FxCloudParameter;

typedef struct
{
    bool enable;
    float density;
    float decay;
    float weight;
}
FxCrepuscularRay;

typedef struct
{
    csl::math::Vector3 sunColor;
    csl::math::Vector3 ambColor;
}
FxManualHeightFog;

typedef struct
{
    bool enable;
    bool enableFogMap;
    float heightScale;
    float distanceOffset;
    float distanceScale;
    csl::math::Vector3 rayleighScale;
    csl::math::Vector3 mieScale;
    float noiseBlend;
    float noiseScale;
    float noiseDistance;
    float animationSpeed;
    float animationAngle;
    bool isAtmospheric;
    FxManualHeightFog manualFog;
}
FxHeightFog;

typedef struct
{
    bool enable;
    FxSun sunParam;
    FxMoon moonParam;
    FxSkyCommon commonSkyParam;
    FxBrunetonSky brunetonSkyParam;
    FxSebastienSky sebastienSkyParam;
    FxCloudParameter cloudParam;
    FxCrepuscularRay crepuscularRayParam;
    FxHeightFog heightFogParam;
}
FxAtmosphereParameter;

typedef struct
{
    float heightThreshold;
    float slopeThreshold;
    float noiseScaleXZ;
    float noiseScaleY;
    float noiseThreshold;
    float noiseAttenuationRange;
}
FxPuddleParameter;

typedef struct
{
    float wetness;
    FxPuddleParameter puddle;
}
FxWeatherParameter;

typedef struct
{
    float windRotationY;
    float windStrength;
    float windNoise;
    float windAmplitude;
    float windFrequencies[4];
    bool enableTreadGrass;
    csl::math::Vector4 grassLodDistance;
    bool enableHighLight;
    float highLightThreshold;
    float highLightObjectAmbientScale;
    float highLightObjectAlbedoHeighten;
    float highLightCharaAmbientScale;
    float highLightCharaAlbedoHeighten;
    float highLightCharaFalloffScale;
}
FxSceneEnvironmentParameter;

typedef struct
{
    bool enableUpscaling;
    float jitterScale;
    float mipBias;
    float sharpnessPower;
    float baseWeight;
    float velocityVarianceBasedWeightBias;
    float colorSpaceClippingScale;
    float colorSpaceClippingScaleForStatic;
    float velocityVarianceMin;
    float velocityVarianceMax;
    bool debugVisualizeVelcotiyVariance;
    csl::math::Vector4 debug;
}
FxTAAParameter;

enum PlacementType : int8_t
{
    CirclePacking = 0,
    RandomPos = 1,
    PT_COUNT = 2
};

enum ShadowCullingType : int8_t
{
    Normal = 0,
    AabbUpScale2 = 1,
    ShadowFrustum = 2
};

typedef struct
{
    float lodRatio;
    float lodRise;
    float lodDecrease;
    float lodThreshold;
}
FxDensityLodParameter;

typedef struct
{
    bool underSelect;
    float factor;
    float unit[32];
    int8_t chunk[32];
    float lodAddition;
    int32_t chunkAddition;
    float drawLimitLenght;
    bool drawCallReduction;
    bool enableDither;
    int32_t ditherGrass;
    int32_t ditherOther;
    int32_t ditherPreComputeGrass;
    int32_t ditherPreComputeOther;
}
FxDensityDebugParameter;

typedef struct
{
    bool enable;
    bool precomputeEnable;
    bool cameraUpdate;
    PlacementType placement;
    float placementScale;
    bool alphaEnable;
    float alphaThreshold;
    float alphaScale;
    bool complementEnable;
    bool disableCut;
    ShadowCullingType shadowCulling;
    bool occlusionCulling;
    float occlusionSize;
    float occlusionShadowSize;
    float occlusionBias;
    FxDensityLodParameter lodParam;
    FxDensityDebugParameter debugParam;
}
FxDensityParameter;

typedef struct
{
    bool enable;
    float offsetR;
    float offsetG;
    float offsetB;
    float curve;
    float scaleX;
    float scaleY;
    float centerX;
    float centerY;
}
FxChromaticAberrationParameter;

enum GradationMode : int8_t
{
    GRADATION_MODE_CIRCLE = 0,
    GRADATION_MODE_LINE = 1
};

enum BlendMode : int8_t
{
    BLEND_MODE_ALPHA_BLEND = 0,
    BLEND_MODE_ADD = 1,
    BLEND_MODE_MUL = 2,
    BLEND_MODE_SCREEN = 3,
    BLEND_MODE_OVERLAY = 4
};

typedef struct
{
    float centerX;
    float centerY;
    float scaleX;
    float scaleY;
    float scale;
    float rotation;
}
FxVfImageCircleParameter;

typedef struct
{
    float centerX;
    float centerY;
    float directionX;
    float directionY;
    float rotation;
}
FxVfLineParameter;

typedef struct
{
    bool enable;
    float minPenumbraScale;
    float maxPenumbraScale;
    float bokehScale;
    float minDofOpacityScale;
    float maxDofOpacityScale;
    float minOpacityScale;
    float maxOpacityScale;
    float minOpacityDist;
    float maxOpacityDist;
}
FxVfDepthParameter;

typedef struct
{
    bool enable;
    GradationMode gradationType;
    BlendMode blendMode;
    csl::math::Vector3 color;
    float opacity;
    FxVfImageCircleParameter imageCircle;
    FxVfLineParameter line;
    float penumbraScale;
    float intensity;
    FxVfDepthParameter depth;
}
FxVignetteParameter;

typedef struct
{
    bool debugEnable;
    bool debugSpace;
    bool debugGlobal;
    bool debugGlobalMap;
    bool debugSpaceAll;
    int32_t spaceIndex;
    float spaceThreshold;
    float min;
    float max;
}
FxWindComputeDebugParameter;

typedef struct
{
    bool enableAll;
    bool enableDynamicWind;
    bool enableGlobalWind;
    float timeScale;
    float decreaseRate;
    csl::math::Vector3 globalWind;
    float globalWindPower;
    float globalWindSpeed;
    float globalWindOffset;
    csl::math::Vector3 globalSecondWind;
    float globalSecondWindPower;
    float globalSecondWindSpeed;
    float globalSecondWindOffset;
    csl::math::Vector3 globalWindMapSize;
    csl::math::Vector3 globalWindMapCenter;
    csl::math::Vector3 globalWindMapOffset;
    float globalWindMapPower;
    float globalWindMapTimeScale;
    FxWindComputeDebugParameter debugParam;
}
FxWindComputeParameter;

typedef struct
{
    bool enable;
    float blendPower;
    float blendHightPower;
    float cullingDistance;
}
FxTerrainMaterialBlendingParameter;

typedef struct
{
    bool enable;
    bool collisionEnable;
    float threshold;
}
FxInteractionDebugParameter;

typedef struct
{
    bool enable;
    float power;
    float decrease;
    float timeScale;
    FxInteractionDebugParameter debug;
    float tremorPower;
    float tremorSpeed;
    float tremorScaleCriterion;
    float tremorScaleReduce;
}
FxInteractionParameter;

typedef struct
{
    float grassDitherStart;
    float grassDitherEnd;
    FxInteractionParameter interaction;
    bool enableZoomBias;
    float zoomBias;
}
FxGpuEnvironmentParameter;

typedef struct
{
    bool enable;
    bool enableDebugDisplay;
    float waveDamping;
    float waveReduceRange;
    float waveSpeed;
    float simurationScale;
    float playerMaxSpeed;
    bool isInWaterDummy;
}
FxInteractiveWaveParameter;

typedef struct
{
    bool enable;
    float tileX;
    float tileY;
    float tileScrollSpeed;
    float noiseScrollSpeed;
    float thresholdSpeed;
    float thredholdMin;
    float thredholdMax;
    float selectRate;
    float scanLineRSpeed;
    float scanLineRBlend;
    float scanLineGSpeed;
    float scanLineGBlend;
    float rgbLineScale;
    float rgbLineBlend;
}
FxCyberNoiseEffectParameter;

enum ColorblinidSimulationType : int8_t
{
    COLORBLIND_SIM_NONE = 0,
    COLORBLIND_SIM_PROTANOPIA = 1,
    COLORBLIND_SIM_DEUTERANOPIA = 2,
    COLORBLIND_SIM_TRITANOPIA = 3,
    COLORBLIND_SIM_ALL = 4
};

typedef struct
{
    bool enable;
    float daltonizeFactor;
    float protanopiaFactor;
    float deuteranopiaFactor;
    float tritanopiaFactor;
    float brightness;
    float contrast;
    float maskIntensity[5];
    ColorblinidSimulationType simulationType;
}
FxColorAccessibilityFilterParameter;

typedef struct
{
    FxRenderOption renderOption;
    FxSGGIParameter sggi;
    FxRLRParameter rlr;
    FxPlanarReflectionParameter planarReflection;
    FxBloomParameter bloom;
    FxCameraControlParameter cameraControl;
    FxToneMapParameter tonemap;
    FxColorContrastParameter colorContrast;
    FxLightScatteringParameter lightscattering;
    FxDOFParameter dof;
    FxShadowMapParameter shadowmap;
    FxShadowHeightMapParameter shadowHeightMap;
    FxSSAOParameter ssao;
    FxSHLightFieldParameter shlightfield;
    FxScreenBlurParameter blur;
    FxOcclusionCapsuleParameter occlusionCapsule;
    FxEffectParameter effect;
    FxScreenSpaceGodrayParameter ssGodray;
    FxGodrayParameter godray;
    FxHeatHazeParameter heatHaze;
    FxAtmosphereParameter atmosphere;
    FxWeatherParameter weather;
    FxSceneEnvironmentParameter sceneEnv;
    FxTAAParameter taa;
    FxDensityParameter density;
    FxChromaticAberrationParameter chromaticAberration;
    FxVignetteParameter vignette;
    FxWindComputeParameter wind;
    FxTerrainMaterialBlendingParameter terrainBlend;
    FxGpuEnvironmentParameter gpuEnvironment;
    FxInteractiveWaveParameter interactiveWave;
    FxCyberNoiseEffectParameter cyberNoise;
    FxColorAccessibilityFilterParameter colorAccessibility;
}
NeedleFxParameter;

typedef struct
{
    FxSkyCommon commonSkyParam;
    FxBrunetonSky brunetonSkyParam;
    FxSebastienSky sebastienSkyParam;
    FxCloudParameter cloudParam;
    FxCrepuscularRay crepuscularRayParam;
    FxHeightFog heightFogParam;
}
TimeProgressAtmosphereParameter;

typedef struct
{
    bool enable;
    float time;
    FxBloomParameter bloom;
    FxCameraControlParameter cameraControl;
    FxCameraControlParameter cameraControlEvent;
    FxToneMapParameter tonemap;
    FxColorContrastParameter colorContrast;
    FxSHLightFieldParameter shlightfield;
    FxLightScatteringParameter lightscattering;
    FxEffectParameter effect;
    FxScreenSpaceGodrayParameter ssGodray;
    FxGodrayParameter godray;
    FxHeatHazeParameter heatHaze;
    TimeProgressAtmosphereParameter atmosphere;
    FxWeatherParameter weather;
}
TimeProgressNeedleFxParam;

typedef struct
{
    float deadline;
    float deadFallTime;
}
StageCommonParameter;

typedef struct
{
    float zNear;
    float zFar;
    float fovy;
}
StageCameraParameter;

typedef struct
{
    float heightRange;
}
StageTerrainPrecisionParameter;

typedef struct
{
    float uvScaleDetail;
    float uvScaleBase;
    float detailDistance;
    float detailFadeRange;
}
StageTerrainMaterialParameter;

typedef struct
{
    bool useHeightMapTerrain;
    bool useHalfPrecision;
    StageTerrainPrecisionParameter precision;
    int32_t worldSize;
    float heightScale;
    float smallestCellSize;
    StageTerrainMaterialParameter material;
    bool enableGbufferBlending;
}
StageTerrainParameter;

typedef struct
{
    StageCommonParameter common;
    StageCameraParameter camera;
    StageTerrainParameter terrain;
}
StageConfig;

typedef struct
{
    NeedleFxSceneConfig config;
    NeedleFxParameter items[16];
    TimeProgressNeedleFxParam timeItems[24];
    StageConfig stageConfig;
}
NeedleFxSceneData;

