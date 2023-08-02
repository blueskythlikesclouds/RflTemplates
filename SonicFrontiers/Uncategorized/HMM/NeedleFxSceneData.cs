Library "NeedleFxSceneData"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    public enum DOFRenderTargetSize : int
{
        DOF_RTSIZE_FULL_SCALE = 0,
        DOF_RTSIZE_HALF_SCALE = 1,
        DOF_RTSIZE_QUARTER_SCALE = 2,
        DOF_RTSIZE_COUNT = 3,
        DOF_RTSIZE_INVALID = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct FxRenderTargetSetting
    {
        [FieldOffset(0)] public DOFRenderTargetSize dofRenderTargetScale;
        [FieldOffset(4)] public int shadowMapWidth;
        [FieldOffset(8)] public int shadowMapHeight;
    }

    public enum AntiAliasingType : sbyte
{
        AATYPE_NONE = 0,
        AATYPE_TAA = 1,
        AATYPE_FXAA = 2,
        AATYPE_SMAA = 3,
        AATYPE_LAST = 4
    }

    public enum UpscaleType : sbyte
{
        USTYPE_LINEAR = 0,
        USTYPE_FSR_FAST = 1,
        USTYPE_FSR_EASU = 2,
        USTYPE_FSR_RCAS = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct FxAntiAliasing
    {
        [FieldOffset(0)] public AntiAliasingType aaType;
        [FieldOffset(1)] public UpscaleType usType;
        [FieldOffset(4)] public float fsrSharpness;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct StageCommonAtmosphereParameter
    {
        [FieldOffset(0)] public float illuminanceScale;
    }

    [StructLayout(LayoutKind.Explicit, Size = 132)]
    public struct FxLODParameter
    {
        [FieldOffset(0)] public bool enableDebugDrawLayerRange;
        [FieldOffset(4)] public unsafe fixed float layerRange[32];
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct FxDetailParameter
    {
        [FieldOffset(0)] public float detailDistance;
        [FieldOffset(4)] public float detailFadeRange;
    }

    public enum Mode : sbyte
{
        DISABLE = 0,
        ENABLE = 1,
        FIXED_RESOLUTION = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public struct FxDynamicResolutionParameter
    {
        [FieldOffset(0)]  public Mode mode;
        [FieldOffset(4)]  public float fixedResolutionRatio;
        [FieldOffset(8)]  public float minResolutionRatio;
        [FieldOffset(12)] public float minTargetTimeDifference;
        [FieldOffset(16)] public float maxTargetTimeDifference;
        [FieldOffset(20)] public float increaseRate;
        [FieldOffset(24)] public float decreaseRate;
        [FieldOffset(28)] public float increaseMaxScaleDelta;
        [FieldOffset(32)] public float decreaseMaxScaleDelta;
        [FieldOffset(36)] public bool debugSineFluctuation;
    }

    [StructLayout(LayoutKind.Explicit, Size = 2)]
    public struct HourMinuteData
    {
        [FieldOffset(0)] public byte hour;
        [FieldOffset(1)] public byte minute;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct TimeIntervalData
    {
        [FieldOffset(0)] public HourMinuteData beginTime;
        [FieldOffset(2)] public HourMinuteData endTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct ProgressTimePairData
    {
        [FieldOffset(0)] public TimeIntervalData timeIntervalData;
        [FieldOffset(4)] public float hourlyTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 104)]
    public struct StageCommonTimeProgressParameter
    {
        [FieldOffset(0)]   public bool enable;
        [FieldOffset(4)]   public float solarRadiusScale;
        [FieldOffset(8)]   public float azimuthAngle;
        [FieldOffset(12)]  public float latitude;
        [FieldOffset(16)]  public float longitude;
        [FieldOffset(20)]  public int month;
        [FieldOffset(24)]  public int day;
        [FieldOffset(28)]  public float time;
        [FieldOffset(32)]  public float hourlyTime;
        [FieldOffset(36)]  public unsafe fixed byte /* ProgressTimePairData[8] */ _overrideSpeeds[64];

        public unsafe ProgressTimePairData* overrideSpeeds
        {
            get
            {
                fixed (byte* p_overrideSpeeds = _overrideSpeeds)
                    return (ProgressTimePairData*)p_overrideSpeeds;
            }
        }

        [FieldOffset(100)] public TimeIntervalData night;
    }

    [StructLayout(LayoutKind.Explicit, Size = 1)]
    public struct StageCommonWeatherProgressParameter
    {
        [FieldOffset(0)] public bool enable;
    }

    [StructLayout(LayoutKind.Explicit, Size = 1)]
    public struct FxTerrainParameter
    {
        [FieldOffset(0)] public bool enableDrawGrid;
    }

    [StructLayout(LayoutKind.Explicit, Size = 2)]
    public struct FxModelParameter
    {
        [FieldOffset(0)] public bool zprepass;
        [FieldOffset(1)] public bool ditherAsBlueNoize;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct StageCommonDecalModelParameter
    {
        [FieldOffset(0)] public float cullingRange;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct PerformanceSetting
    {
        [FieldOffset(0)] public float smallCullingThreshold;
    }

    [StructLayout(LayoutKind.Explicit, Size = 320)]
    public struct NeedleFxSceneConfig
    {
        [FieldOffset(0)]   public FxRenderTargetSetting rendertarget;
        [FieldOffset(12)]  public FxAntiAliasing antialiasing;
        [FieldOffset(20)]  public StageCommonAtmosphereParameter atmosphere;
        [FieldOffset(24)]  public FxLODParameter lod;
        [FieldOffset(156)] public FxDetailParameter detail;
        [FieldOffset(164)] public FxDynamicResolutionParameter dynamicResolution;
        [FieldOffset(204)] public StageCommonTimeProgressParameter timeProgress;
        [FieldOffset(308)] public StageCommonWeatherProgressParameter weatherProgress;
        [FieldOffset(309)] public FxTerrainParameter terrain;
        [FieldOffset(310)] public FxModelParameter modelParam;
        [FieldOffset(312)] public StageCommonDecalModelParameter decalModelParam;
        [FieldOffset(316)] public PerformanceSetting performance;
    }

    public enum DebugViewType : sbyte
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
    }

    public enum Type : sbyte
{
        NONE = 0,
        SHADOW_LIGHT = 1,
        SHADOW_AND_DISTANT_LIGHT = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct GlobalLightAngleLimit
    {
        [FieldOffset(0)] public Type type;
        [FieldOffset(4)] public float minLightElevationAngle;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct GlobalLightParameter
    {
        [FieldOffset(0)] public bool enable;
        [FieldOffset(4)] public GlobalLightAngleLimit limit;
    }

    public enum LocalLightCullingType : sbyte
{
        LOCAL_LIGHT_CULLING_TYPE_NONE = 0,
        LOCAL_LIGHT_CULLING_TYPE_CPU_TILE = 1,
        LOCAL_LIGHT_CULLING_TYPE_GPU_TILE = 2,
        LOCAL_LIGHT_CULLING_TYPE_GPU_CLUSTER = 3,
        LOCAL_LIGHT_CULLING_TYPE_COUNT = 4,
        LOCAL_LIGHT_CULLING_TYPE_DEFAULT = 0
    }

    public enum TextureViewType : sbyte
{
        TEXTURE_VIEW_NONE = 0,
        TEXTURE_VIEW_DEPTH = 1,
        TEXTURE_VIEW_LUMINANCE = 2,
        TEXTURE_VIEW_DOF_BOKEH = 3,
        TEXTURE_VIEW_DOF_BOKEH_NEAR = 4,
        TEXTURE_VIEW_SSAO_SOURCE = 5,
        TEXTURE_VIEW_DOWNSAMPLE = 6,
        TEXTURE_VIEW_COUNT = 7
    }

    public enum AmbientSpecularType : sbyte
{
        AMBIENT_SPECULAR_NONE = 0,
        AMBIENT_SPECULAR_SG = 1,
        AMBIENT_SPECULAR_IBL = 2,
        AMBIENT_SPECULAR_BLEND = 3
    }

    public enum ChannelMode : sbyte
{
        CHANNELMODE_RGB = 0,
        CHANNELMODE_RRR = 1,
        CHANNELMODE_GGG = 2,
        CHANNELMODE_BBB = 3,
        CHANNELMODE_AAA = 4,
        CHANNELMODE_RG = 5,
        CHANNELMODE_BA = 6
    }

    public enum DebugScreenType : sbyte
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
    }

    public enum ErrorCheckType : sbyte
{
        ERROR_CHECK_NONE = 0,
        ERROR_CHECK_NAN = 1,
        ERROR_CHECK_ALBEDO = 2,
        ERROR_CHECK_NORMAL = 3
    }

    public enum VisualizeMode : sbyte
{
        DEFAULT = 0,
        HEATMAP_TYPE0 = 1,
        HEATMAP_TYPE1 = 2,
        HEATMAP_TYPE2 = 3,
        VECTOR2D_TYPE0 = 4,
        VECTOR2D_TYPE1 = 5,
        VECTOR2D_TYPE2 = 6
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct DebugScreenOption
    {
        [FieldOffset(0)]  public bool enable;
        [FieldOffset(1)]  public bool fullScreen;
        [FieldOffset(2)]  public ChannelMode channelMode;
        [FieldOffset(4)]  public float min;
        [FieldOffset(8)]  public float max;
        [FieldOffset(12)] public int renderTargetType;
        [FieldOffset(16)] public int depthTargetType;
        [FieldOffset(20)] public DebugScreenType screenType;
        [FieldOffset(21)] public ErrorCheckType errorCheck;
        [FieldOffset(22)] public VisualizeMode visualizeMode;
    }

    public enum DebugScreenView : sbyte
{
        DEBUG_SCREEN_VIEW_DEFAULT = 0,
        DEBUG_SCREEN_VIEW_ALL_ENABLE = 1,
        DEBUG_SCREEN_VIEW_ALL_DISABLE = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct GlobalUserParamOption
    {
        [FieldOffset(0)]  public bool enable;
        [FieldOffset(16)] public Vector4 value;
    }

    [StructLayout(LayoutKind.Explicit, Size = 592)]
    public struct FxRenderOption
    {
        [FieldOffset(0)]   public DebugViewType debugViewType;
        [FieldOffset(1)]   public bool clearRenderTarget;
        [FieldOffset(2)]   public bool enableDrawCubeProbe;
        [FieldOffset(4)]   public GlobalLightParameter globalLight;
        [FieldOffset(16)]  public bool enablePointLight;
        [FieldOffset(17)]  public bool enableEffectDeformation;
        [FieldOffset(18)]  public bool enablePreMergeIBL;
        [FieldOffset(19)]  public bool enableLitePostEffect;
        [FieldOffset(20)]  public LocalLightCullingType localLightCullingType;
        [FieldOffset(24)]  public float localLightScale;
        [FieldOffset(28)]  public float shadowIBLAttenuation;
        [FieldOffset(32)]  public int maxCubeProbe;
        [FieldOffset(36)]  public bool debugEnableDrawLocalLight;
        [FieldOffset(37)]  public TextureViewType debugTextureViewType;
        [FieldOffset(38)]  public bool debugEnableOutputTextureView;
        [FieldOffset(40)]  public int debugScreenshotResolutionHeight;
        [FieldOffset(44)]  public float debugScreenshotDepthNear;
        [FieldOffset(48)]  public float debugScreenshotDepthFar;
        [FieldOffset(52)]  public AmbientSpecularType debugAmbientSpecularType;
        [FieldOffset(53)]  public bool debugEnableSGGIVer2nd;
        [FieldOffset(54)]  public bool debugEnableAOGI;
        [FieldOffset(56)]  public unsafe fixed byte /* DebugScreenOption[16] */ _debugScreen[384];

        public unsafe DebugScreenOption* debugScreen
        {
            get
            {
                fixed (byte* p_debugScreen = _debugScreen)
                    return (DebugScreenOption*)p_debugScreen;
            }
        }

        [FieldOffset(440)] public DebugScreenView debugScreenView;
        [FieldOffset(441)] public bool enableMSAA;
        [FieldOffset(442)] public bool debugEnableDrawFrustumCullFrustum;
        [FieldOffset(443)] public bool debugEnableFixFrustumCullFrustum;
        [FieldOffset(444)] public int debugDrawFrustumCullGroupSettingIndex;
        [FieldOffset(448)] public bool debugEnableOcclusionCullingView;
        [FieldOffset(452)] public int debugOccluderVertThreshold;
        [FieldOffset(464)] public unsafe fixed byte /* GlobalUserParamOption[4] */ _globalUserParam[128];

        public unsafe GlobalUserParamOption* globalUserParam
        {
            get
            {
                fixed (byte* p_globalUserParam = _globalUserParam)
                    return (GlobalUserParamOption*)p_globalUserParam;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct FxSGGIParameter
    {
        [FieldOffset(0)]  public float sgStartSmoothness;
        [FieldOffset(4)]  public float sgEndSmoothness;
        [FieldOffset(8)]  public float doStartSmoothness;
        [FieldOffset(12)] public float doEndSmoothness;
        [FieldOffset(16)] public float doOffset;
        [FieldOffset(20)] public float aoOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public struct FxRLRParameter
    {
        [FieldOffset(0)]  public bool enable;
        [FieldOffset(1)]  public bool traceSky;
        [FieldOffset(2)]  public bool useTrans;
        [FieldOffset(3)]  public bool usePenet;
        [FieldOffset(4)]  public bool useQuat;
        [FieldOffset(5)]  public bool useNormal;
        [FieldOffset(8)]  public float rayMarchingCount;
        [FieldOffset(12)] public float planeNormalDist;
        [FieldOffset(16)] public float traceThreshold;
        [FieldOffset(20)] public float resolveReproj;
        [FieldOffset(24)] public float overrideRatio;
        [FieldOffset(28)] public float maxRoughness;
        [FieldOffset(32)] public float roughnessLevel;
        [FieldOffset(36)] public float uvOffsetScale;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct FxSSGIDebugParameter
    {
        [FieldOffset(0)] public bool useDenoise;
        [FieldOffset(4)] public float rayLength;
    }

    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public struct FxSSGIParameter
    {
        [FieldOffset(0)]  public bool enable;
        [FieldOffset(4)]  public float intensity;
        [FieldOffset(8)]  public bool useAlbedo;
        [FieldOffset(9)]  public bool useParameter;
        [FieldOffset(12)] public FxSSGIDebugParameter debugParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct FxPlanarReflectionParameter
    {
        [FieldOffset(0)]  public bool enable;
        [FieldOffset(16)] public Vector4 plane;
        [FieldOffset(32)] public uint width;
        [FieldOffset(36)] public uint height;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct FxBloomParameter
    {
        [FieldOffset(0)]  public bool enable;
        [FieldOffset(1)]  public bool fast;
        [FieldOffset(4)]  public float bloomScale;
        [FieldOffset(8)]  public float sampleRadiusScale;
        [FieldOffset(12)] public int blurQuality;
    }

    public enum Exposure : sbyte
{
        EXPOSURE_MANUAL = 0,
        EXPOSURE_AUTO = 1
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct FxManualExposureParameter
    {
        [FieldOffset(0)] public float exposureValue;
    }

    public enum LUMINANCE_RANGE : sbyte
{
        LUMINANCE_RANGE_CLAMP = 0,
        LUMINANCE_RANGE_CUTOFF = 1,
        LUMINANCE_RANGE_CUTOFF_PCT_RATE = 2,
        LUMINANCE_RANGE_CUTOFF_PCT_AREA = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public struct FxAutoExposureParameter
    {
        [FieldOffset(0)]  public float middleGray;
        [FieldOffset(4)]  public float lumMax;
        [FieldOffset(8)]  public float lumMin;
        [FieldOffset(12)] public float cutMax;
        [FieldOffset(16)] public float cutMin;
        [FieldOffset(20)] public float pctMax;
        [FieldOffset(24)] public float pctMin;
        [FieldOffset(28)] public float adaptedRatio;
        [FieldOffset(32)] public LUMINANCE_RANGE luminanceRangeType;
    }

    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public struct FxCameraControlParameter
    {
        [FieldOffset(0)] public Exposure exposureType;
        [FieldOffset(4)] public FxManualExposureParameter manualExposure;
        [FieldOffset(8)] public FxAutoExposureParameter autoExposure;
    }

    public enum Tonemap : sbyte
{
        TONEMAP_DISNEY = 0,
        TONEMAP_FILMIC = 1,
        TONEMAP_ACES = 2,
        TONEMAP_GT = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public struct FxToneMapParameterFilmic
    {
        [FieldOffset(0)]  public float whitePoint;
        [FieldOffset(4)]  public float toeStrength;
        [FieldOffset(8)]  public float linearAngle;
        [FieldOffset(12)] public float linearStrength;
        [FieldOffset(16)] public float shoulderStrength;
    }

    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public struct FxToneMapParameterGT
    {
        [FieldOffset(0)]  public float maxDisplayBrightness;
        [FieldOffset(4)]  public float contrast;
        [FieldOffset(8)]  public float linearSectionStart;
        [FieldOffset(12)] public float linearSectionLength;
        [FieldOffset(16)] public float black;
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct FxToneMapParameter
    {
        [FieldOffset(0)]  public Tonemap tonemapType;
        [FieldOffset(4)]  public FxToneMapParameterFilmic tonemapParamFilmic;
        [FieldOffset(24)] public FxToneMapParameterGT tonemapParamGT;
        [FieldOffset(44)] public bool updateLuminance;
    }

    public enum LutIndex : int
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
    }

    [StructLayout(LayoutKind.Explicit, Size = 76)]
    public struct FxColorContrastParameter
    {
        [FieldOffset(0)]  public bool enable;
        [FieldOffset(4)]  public float contrast;
        [FieldOffset(8)]  public float dynamicRange;
        [FieldOffset(12)] public float crushShadows;
        [FieldOffset(16)] public float crushHilights;
        [FieldOffset(20)] public bool useLut;
        [FieldOffset(24)] public LutIndex lutIndex0;
        [FieldOffset(28)] public LutIndex lutIndex1;
        [FieldOffset(32)] public float blendRatio;
        [FieldOffset(36)] public float lutRatio;
        [FieldOffset(40)] public bool useHlsCorrection;
        [FieldOffset(44)] public float hlsHueOffset;
        [FieldOffset(48)] public float hlsLightnessOffset;
        [FieldOffset(52)] public float hlsSaturationOffset;
        [FieldOffset(56)] public unsafe fixed int hlsColorOffset[3];
        [FieldOffset(68)] public float hlsColorizeRate;
        [FieldOffset(72)] public float hlsColorizeHue;
    }

    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public struct FxLightScatteringParameter
    {
        [FieldOffset(0)]  public bool enable;
        [FieldOffset(16)] public Vector3 color;
        [FieldOffset(32)] public float inScatteringScale;
        [FieldOffset(48)] public Vector3 betaRayleigh;
        [FieldOffset(64)] public float betaMie;
        [FieldOffset(68)] public float g;
        [FieldOffset(72)] public float znear;
        [FieldOffset(76)] public float zfar;
        [FieldOffset(80)] public float depthScale;
    }

    public enum RenderTargetSize : int
{
        RTSIZE_FULL_SCALE = 0,
        RTSIZE_HALF_SCALE = 1,
        RTSIZE_QUARTER_SCALE = 2,
        RTSIZE_COUNT = 3,
        RTSIZE_INVALID = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 84)]
    public struct FxDOFParameter
    {
        [FieldOffset(0)]  public bool enable;
        [FieldOffset(1)]  public bool useFocusLookAt;
        [FieldOffset(4)]  public float foregroundBokehMaxDepth;
        [FieldOffset(8)]  public float foregroundBokehStartDepth;
        [FieldOffset(12)] public float backgroundBokehStartDepth;
        [FieldOffset(16)] public float backgroundBokehMaxDepth;
        [FieldOffset(20)] public bool enableCircleDOF;
        [FieldOffset(24)] public float cocMaxRadius;
        [FieldOffset(28)] public float bokehRadiusScale;
        [FieldOffset(32)] public int bokehSampleCount;
        [FieldOffset(36)] public float skyFocusDistance;
        [FieldOffset(40)] public float bokehBias;
        [FieldOffset(44)] public bool drawFocalPlane;
        [FieldOffset(48)] public RenderTargetSize rtScale;
        [FieldOffset(52)] public bool enableSWA;
        [FieldOffset(56)] public float swaFocus;
        [FieldOffset(60)] public float swaFocusRange;
        [FieldOffset(64)] public float swaNear;
        [FieldOffset(68)] public float swaFar;
        [FieldOffset(72)] public bool enableEnhancedForeBokeh;
        [FieldOffset(76)] public float foreBokehScale;
        [FieldOffset(80)] public float foreBokehMaxLuminance;
    }

    public enum ShadowRenderingType : sbyte
{
        SHADOW_RENDERING_TYPE_SHADOW_MAP = 0,
        SHADOW_RENDERING_TYPE_PLANAR_PROJECTION = 1,
        SHADOW_RENDERING_TYPE_PLANAR_PROJECTION_SHADOW_MAP = 2,
        SHADOW_RENDERING_TYPE_MULTI_SHADOW_MAP = 3,
        SHADOW_RENDERING_TYPE_COUNT = 4
    }

    public enum ShadowFilter : sbyte
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
    }

    public enum ShadowRangeType : sbyte
{
        SHADOW_RANGE_TYPE_CAMERA_LOOKAT = 0,
        SHADOW_RANGE_TYPE_POSITION_MANUAL = 1,
        SHADOW_RANGE_TYPE_FULL_MANUAL = 2,
        SHADOW_RANGE_TYPE_COUNT = 3,
        SHADOW_RANGE_TYPE_DEFAULT = 0
    }

    public enum FitProjection : sbyte
{
        FIT_PROJECTION_TO_CASCADES = 0,
        FIT_PROJECTION_TO_SCENE = 1,
        FIT_PROJECTION_TO_ROTATE_CASCADES = 2
    }

    public enum FitNearFar : sbyte
{
        FIT_NEARFAR_ZERO_ONE = 0,
        FIT_NEARFAR_AABB = 1,
        FIT_NEARFAR_SCENE_AABB = 2
    }

    public enum PartitionType : sbyte
{
        PARTITION_PSSM = 0,
        PARTITION_MANUAL = 1
    }

    [StructLayout(LayoutKind.Explicit, Size = 336)]
    public struct FxShadowMapParameter
    {
        [FieldOffset(0)]   public ShadowRenderingType renderingType;
        [FieldOffset(1)]   public bool enable;
        [FieldOffset(2)]   public ShadowFilter shadowFilter;
        [FieldOffset(3)]   public ShadowRangeType shadowRangeType;
        [FieldOffset(4)]   public FitProjection fitProjection;
        [FieldOffset(5)]   public FitNearFar fitNearFar;
        [FieldOffset(6)]   public PartitionType partitionType;
        [FieldOffset(8)]   public float sceneRange;
        [FieldOffset(12)]  public unsafe fixed float sceneCenter[3];
        [FieldOffset(24)]  public unsafe fixed float manualLightPos[3];
        [FieldOffset(36)]  public float pssmLambda;
        [FieldOffset(40)]  public float cascadeOffset;
        [FieldOffset(44)]  public int cascadeLevel;
        [FieldOffset(48)]  public unsafe fixed float cascadeSplits[4];
        [FieldOffset(64)]  public unsafe fixed float cascadeBias[4];
        [FieldOffset(80)]  public float bias;
        [FieldOffset(84)]  public float offset;
        [FieldOffset(88)]  public float normalBias;
        [FieldOffset(92)]  public int width;
        [FieldOffset(96)]  public int height;
        [FieldOffset(100)] public int blurQuality;
        [FieldOffset(104)] public int blurSize;
        [FieldOffset(108)] public float fadeoutDistance;
        [FieldOffset(112)] public float cascadeTransitionfadeDistance;
        [FieldOffset(116)] public bool enableCSMCache;
        [FieldOffset(120)] public float csmCacheMaxHeight;
        [FieldOffset(124)] public float csmCacheMinHeight;
        [FieldOffset(128)] public int csmCacheMaxRenderPass;
        [FieldOffset(132)] public float csmCacheFixedFovy;
        [FieldOffset(136)] public float csmCacheLightDirectionThreshold;
        [FieldOffset(140)] public bool csmCacheParallaxCorrectionEnabled;
        [FieldOffset(144)] public float csmCacheParallaxCorrectionHorizontalBias;
        [FieldOffset(148)] public float csmCacheParallaxCorrectionVerticalBias;
        [FieldOffset(152)] public unsafe fixed int csmCacheFramesToRender[3];
        [FieldOffset(164)] public float csmCacheFadeLightElevationAngle;
        [FieldOffset(168)] public float csmCacheMinLightElevationAngle;
        [FieldOffset(176)] public Matrix4x4 shadowCameraViewMatrix;
        [FieldOffset(240)] public Matrix4x4 shadowCameraProjectionMatrix;
        [FieldOffset(304)] public float shadowCameraNearDepth;
        [FieldOffset(308)] public float shadowCameraFarDepth;
        [FieldOffset(312)] public float shadowCameraLookAtDepth;
        [FieldOffset(316)] public bool enableBackFaceShadow;
        [FieldOffset(317)] public bool enableShadowCamera;
        [FieldOffset(318)] public bool enableDrawSceneAABB;
        [FieldOffset(319)] public bool enableDrawShadowFrustum;
        [FieldOffset(320)] public bool enableDrawCascade;
        [FieldOffset(321)] public bool enableDrawCameraFrustum;
        [FieldOffset(322)] public bool enableDrawCSMCache;
        [FieldOffset(323)] public bool enableClearOnCSMCacheIsInvalidated;
        [FieldOffset(324)] public bool enablePauseCamera;
    }

    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public struct FxShadowHeightMapParameter
    {
        [FieldOffset(0)]  public bool enable;
        [FieldOffset(4)]  public float bias;
        [FieldOffset(8)]  public float distanceFalloff;
        [FieldOffset(12)] public float heightFalloffMinHeight;
        [FieldOffset(16)] public float heightFalloffDistance;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct FxVolumetricShadowParameter
    {
        [FieldOffset(0)] public bool enable;
        [FieldOffset(1)] public bool isForceUseShadowmap;
        [FieldOffset(2)] public bool isUseCloudShadow;
        [FieldOffset(3)] public bool isUseHeightmapShadow;
    }

    public enum SSAOType : sbyte
{
        SSAO = 0,
        HBAO = 1,
        HBAO_SSS = 2,
        SSS = 3,
        TYPE_COUNT = 4
    }

    public enum FxSSAOParameter_RenderTargetSize : sbyte
{
        RTSIZE_SAME_AS_FRAMEBUFFER = 0,
        RTSIZE_ONE_SECOND = 1,
        RTSIZE_ONE_FORTH = 2,
        FxSSAOParameter_RenderTargetSize_RTSIZE_COUNT = 3
    }

    public enum BLURType : sbyte
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
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct FxSSAO_Parameter
    {
        [FieldOffset(0)]  public float intensity;
        [FieldOffset(4)]  public float radius;
        [FieldOffset(8)]  public float fadeoutDistance;
        [FieldOffset(12)] public float fadeoutRadius;
        [FieldOffset(16)] public float power;
        [FieldOffset(20)] public float bias;
        [FieldOffset(24)] public float occlusionDistance;
        [FieldOffset(28)] public float directLightingInfluence;
    }

    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public struct FxHBAO_Parameter
    {
        [FieldOffset(0)]  public float hbaoPower;
        [FieldOffset(4)]  public float hbaoBias;
        [FieldOffset(8)]  public float hbaoRadius;
        [FieldOffset(12)] public float hbaoFalloff;
        [FieldOffset(16)] public float hbaoSteps;
        [FieldOffset(20)] public float hbaoGitter;
        [FieldOffset(24)] public sbyte hbaoRaycount;
        [FieldOffset(25)] public bool hbaoGiMaskEnable;
    }

    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public struct FxSSS_Parameter
    {
        [FieldOffset(0)]  public float sssRayLength;
        [FieldOffset(4)]  public sbyte sssRaycount;
        [FieldOffset(8)]  public float sssBias;
        [FieldOffset(12)] public float sssIntensity;
        [FieldOffset(16)] public float sssDepthMin;
        [FieldOffset(20)] public float sssDepthMax;
        [FieldOffset(24)] public float sssLightDistance;
        [FieldOffset(28)] public float sssThickness;
        [FieldOffset(32)] public bool sssGiMaskEnable;
        [FieldOffset(36)] public float sssLimit;
        [FieldOffset(40)] public bool sssDitherEnable;
    }

    [StructLayout(LayoutKind.Explicit, Size = 112)]
    public struct FxSSAOParameter
    {
        [FieldOffset(0)]  public bool enable;
        [FieldOffset(1)]  public SSAOType postType;
        [FieldOffset(2)]  public FxSSAOParameter_RenderTargetSize renderTargetSize;
        [FieldOffset(3)]  public BLURType blurStep;
        [FieldOffset(4)]  public float bilateralThreshold;
        [FieldOffset(8)]  public FxSSAO_Parameter ssaoParam;
        [FieldOffset(40)] public FxHBAO_Parameter hbaoParam;
        [FieldOffset(68)] public FxSSS_Parameter sssParam;
    }

    public enum DebugDrawType : sbyte
{
        DEBUG_DRAW_NONE = 0,
        DEBUG_DRAW_ONLY_ENABLED = 1,
        DEBUG_DRAW_ALL = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct FxLightFieldMergeParameter
    {
        [FieldOffset(0)] public bool enable;
        [FieldOffset(4)] public float blendRatio;
    }

    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public struct FxSHLightFieldParameter
    {
        [FieldOffset(0)]  public bool enable;
        [FieldOffset(1)]  public DebugDrawType debugDrawType;
        [FieldOffset(2)]  public bool showSkyVisibility;
        [FieldOffset(4)]  public float debugProbeSize;
        [FieldOffset(16)] public Vector3 multiplyColorUp;
        [FieldOffset(32)] public Vector3 multiplyColorDown;
        [FieldOffset(48)] public float normalBias;
        [FieldOffset(52)] public FxLightFieldMergeParameter lfMerge;
    }

    public enum BlurType : sbyte
{
        BLURTYPE_PREV_SURFACE = 0,
        BLURTYPE_RADIAL = 1,
        BLURTYPE_CAMERA = 2,
        BLURTYPE_COUNT = 3
    }

    public enum FocusType : sbyte
{
        FOCUSTYPE_CENTER = 0,
        FOCUSTYPE_LOOKAT = 1,
        FOCUSTYPE_USER_SETTING = 2,
        FOCUSTYPE_COUNT = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct FxScreenBlurParameter
    {
        [FieldOffset(0)]  public bool enable;
        [FieldOffset(1)]  public BlurType blurType;
        [FieldOffset(4)]  public float blurPower;
        [FieldOffset(8)]  public FocusType focusType;
        [FieldOffset(16)] public Vector3 focusPosition;
        [FieldOffset(32)] public float focusRange;
        [FieldOffset(36)] public float alphaSlope;
        [FieldOffset(40)] public int sampleNum;
        [FieldOffset(44)] public bool singleDirectionOpt;
    }

    public struct Color8
    {
        public byte A;
        public byte R;
        public byte G;
        public byte B;
    }

    [StructLayout(LayoutKind.Explicit, Size = 144)]
    public struct FxOcclusionCapsuleParameter
    {
        [FieldOffset(0)]   public bool enable;
        [FieldOffset(1)]   public bool enableOcclusion;
        [FieldOffset(4)]   public Color8 occlusionColor;
        [FieldOffset(8)]   public float occlusionPower;
        [FieldOffset(12)]  public bool enableSpecularOcclusion;
        [FieldOffset(16)]  public float specularOcclusionAlpha;
        [FieldOffset(20)]  public float specularOcclusionPower;
        [FieldOffset(24)]  public float specularOcclusionConeAngle;
        [FieldOffset(28)]  public bool enableShadow;
        [FieldOffset(32)]  public Color8 shadowColor;
        [FieldOffset(36)]  public float shadowPower;
        [FieldOffset(40)]  public float shadowConeAngle;
        [FieldOffset(44)]  public float cullingDistance;
        [FieldOffset(48)]  public bool enableManualLight;
        [FieldOffset(52)]  public int manualLightCount;
        [FieldOffset(64)]  public unsafe fixed byte /* Vector3[4] */ _manualLightPos[64];

        public unsafe Vector3* manualLightPos
        {
            get
            {
                fixed (byte* p_manualLightPos = _manualLightPos)
                    return (Vector3*)p_manualLightPos;
            }
        }

        [FieldOffset(128)] public bool debugDraw;
    }

    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public struct FxEffectParameter
    {
        [FieldOffset(0)]  public float lightFieldColorCoefficient;
        [FieldOffset(4)]  public float invTonemapCoefficient;
        [FieldOffset(16)] public Vector3 shadowColor;
        [FieldOffset(32)] public Vector3 directionalLightOverwrite;
        [FieldOffset(48)] public float directionalLightIntensityOverwrite;
        [FieldOffset(52)] public bool overwriteDirectionalLight;
        [FieldOffset(56)] public float localLightIntensityScale;
        [FieldOffset(60)] public unsafe fixed float lodDistances[8];
        [FieldOffset(92)] public bool enableVisualizeOverdraw;
        [FieldOffset(93)] public bool renderWireframe;
        [FieldOffset(94)] public bool upsampleBilateral;
    }

    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public struct FxScreenSpaceGodrayParameter
    {
        [FieldOffset(0)]  public bool enable;
        [FieldOffset(4)]  public float rayMarchingCount;
        [FieldOffset(8)]  public float density;
        [FieldOffset(12)] public float decay;
        [FieldOffset(16)] public float threshold;
        [FieldOffset(20)] public float lumMax;
        [FieldOffset(24)] public float intensity;
        [FieldOffset(28)] public bool enableDither;
        [FieldOffset(32)] public Vector3 lightPos;
        [FieldOffset(48)] public Vector3 lightDir;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct FxGodrayVolumeTexture
    {
        [FieldOffset(0)]  public bool enableVolumeTexture;
        [FieldOffset(4)]  public float uvScale;
        [FieldOffset(8)]  public float timeScale;
        [FieldOffset(12)] public float animationAngle;
    }

    [StructLayout(LayoutKind.Explicit, Size = 240)]
    public struct FxGodrayParameter
    {
        [FieldOffset(0)]   public bool enable;
        [FieldOffset(1)]   public bool isUseShadowmap;
        [FieldOffset(2)]   public bool isVariableStep;
        [FieldOffset(16)]  public Matrix4x4 shadow;
        [FieldOffset(80)]  public Matrix4x4 box;
        [FieldOffset(144)] public Vector3 color;
        [FieldOffset(160)] public float density;
        [FieldOffset(164)] public float anisotropy;
        [FieldOffset(168)] public float range;
        [FieldOffset(172)] public float rayMarchingCount;
        [FieldOffset(176)] public float rayMarchingStep;
        [FieldOffset(180)] public float shadowEdge;
        [FieldOffset(184)] public bool isScanFromBack;
        [FieldOffset(188)] public int boxCount;
        [FieldOffset(192)] public bool isNewMode;
        [FieldOffset(196)] public FxGodrayVolumeTexture volumeTexture;
        [FieldOffset(212)] public float transparency;
        [FieldOffset(216)] public bool enable3d;
        [FieldOffset(220)] public float reProject3d;
        [FieldOffset(224)] public float logNear3d;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct FxHeatHazeParameter
    {
        [FieldOffset(0)]  public bool enable;
        [FieldOffset(4)]  public float speed;
        [FieldOffset(8)]  public float scale;
        [FieldOffset(12)] public float cycle;
        [FieldOffset(16)] public float nearDepth;
        [FieldOffset(20)] public float farDepth;
        [FieldOffset(24)] public float maxHeight;
        [FieldOffset(28)] public float parallaxCorrectFactor;
    }

    public enum SunPosType : sbyte
{
        SUN_POS_TYPE_NONE = 0,
        SUN_POS_TYPE_ANGLE = 1,
        SUN_POS_TYPE_EARTH = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct FxSunPosAngle
    {
        [FieldOffset(0)] public float azimuthAngle;
        [FieldOffset(4)] public float elevationAngle;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct FxSunPosEarth
    {
        [FieldOffset(0)]  public float azimuthAngle;
        [FieldOffset(4)]  public float latitude;
        [FieldOffset(8)]  public float longitude;
        [FieldOffset(12)] public int month;
        [FieldOffset(16)] public int day;
        [FieldOffset(20)] public float time;
        [FieldOffset(24)] public bool enableAnimation;
        [FieldOffset(28)] public float animationSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct FxSun
    {
        [FieldOffset(0)]  public float solarRadiusScale;
        [FieldOffset(4)]  public SunPosType sunPosType;
        [FieldOffset(8)]  public FxSunPosAngle posTypeAngle;
        [FieldOffset(16)] public FxSunPosEarth posTypeEarth;
    }

    public enum MoonPosType : sbyte
{
        MOON_POS_TYPE_NONE = 0,
        MOON_POS_TYPE_INV_SUN = 1,
        MOON_POS_TYPE_EARTH = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 1)]
    public struct FxMoon
    {
        [FieldOffset(0)] public MoonPosType moonPosType;
    }

    public enum SkyModel : sbyte
{
        BRUNETON = 0,
        SEBASTIEN = 1
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct FxSkyCommon
    {
        [FieldOffset(0)]  public SkyModel skyModel;
        [FieldOffset(4)]  public float illuminanceScale;
        [FieldOffset(8)]  public bool enableScattering;
        [FieldOffset(12)] public float scatteringRatio;
    }

    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public struct FxBrunetonSkyNight
    {
        [FieldOffset(0)]  public float lunarIntensityInSky;
        [FieldOffset(4)]  public float starIntensityInSky;
        [FieldOffset(8)]  public float lunarIntensityInCloud;
        [FieldOffset(12)] public float lunarIntensity;
        [FieldOffset(16)] public float skyIntensity;
        [FieldOffset(20)] public Color8 lunarLightColor;
        [FieldOffset(32)] public Vector4 lunarLightColorOffset;
        [FieldOffset(48)] public float lunarLightPower;
    }

    [StructLayout(LayoutKind.Explicit, Size = 144)]
    public struct FxBrunetonSky
    {
        [FieldOffset(0)]   public float illuminanceScale;
        [FieldOffset(4)]   public Color8 rayleighColor;
        [FieldOffset(8)]   public Color8 lightColorScale;
        [FieldOffset(12)]  public float miePhaseFunctionG;
        [FieldOffset(16)]  public Color8 mieScatteringColor;
        [FieldOffset(20)]  public float mieScatteringScale;
        [FieldOffset(24)]  public Color8 mieAbsorptionColor;
        [FieldOffset(28)]  public float mieAbsorptionScale;
        [FieldOffset(32)]  public Color8 rayleighScatteringColor;
        [FieldOffset(36)]  public float rayleighScatteringScale;
        [FieldOffset(40)]  public Color8 groundAlbedo;
        [FieldOffset(44)]  public Color8 groundIrradianceScale;
        [FieldOffset(48)]  public Color8 cubemapColorScale;
        [FieldOffset(52)]  public float cubemapColorAngleRatio;
        [FieldOffset(56)]  public bool enableScattering;
        [FieldOffset(60)]  public float scatteringRatio;
        [FieldOffset(64)]  public FxBrunetonSkyNight night;
        [FieldOffset(128)] public bool enableLimitY;
        [FieldOffset(132)] public float debugSkyCubeIntensity;
    }

    [StructLayout(LayoutKind.Explicit, Size = 144)]
    public struct FxSebastienSky
    {
        [FieldOffset(0)]   public float miePhaseFunctionG;
        [FieldOffset(4)]   public Color8 mieScatteringColor;
        [FieldOffset(16)]  public Vector4 mieScatteringColorOffset;
        [FieldOffset(32)]  public float mieScatteringScale;
        [FieldOffset(36)]  public Color8 mieAbsorptionColor;
        [FieldOffset(48)]  public Vector4 mieAbsorptionColorOffset;
        [FieldOffset(64)]  public float mieAbsorptionScale;
        [FieldOffset(68)]  public Color8 rayleighScatteringColor;
        [FieldOffset(80)]  public Vector4 rayleighScatteringColorOffset;
        [FieldOffset(96)]  public float rayleighScatteringScale;
        [FieldOffset(100)] public Color8 groundAlbedo;
        [FieldOffset(112)] public Vector4 groundAlbedoOffset;
        [FieldOffset(128)] public bool enableGround;
        [FieldOffset(132)] public int numScatteringOrder;
        [FieldOffset(136)] public bool enableScattering;
        [FieldOffset(137)] public bool enableLimitY;
    }

    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public struct FxCloudProcedural
    {
        [FieldOffset(0)]  public Vector3 uvScale;
        [FieldOffset(16)] public Vector3 colorGamma;
        [FieldOffset(32)] public Vector3 colorScale;
        [FieldOffset(48)] public Vector3 colorOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public struct FxCloudBlendParameter
    {
        [FieldOffset(0)]  public bool enable;
        [FieldOffset(4)]  public float probability;
        [FieldOffset(8)]  public float cloudiness;
        [FieldOffset(16)] public FxCloudProcedural proceduralCloud;
    }

    [StructLayout(LayoutKind.Explicit, Size = 256)]
    public struct FxCloudParameter
    {
        [FieldOffset(0)]   public bool enable;
        [FieldOffset(1)]   public bool enableAnimation;
        [FieldOffset(4)]   public float animationFrame;
        [FieldOffset(8)]   public float animationSpeed;
        [FieldOffset(12)]  public float animationAngle;
        [FieldOffset(16)]  public float animationSpeedCirrus;
        [FieldOffset(20)]  public float animationAngleCirrus;
        [FieldOffset(24)]  public float skyHorizonOffset;
        [FieldOffset(28)]  public float cloudStartHeight;
        [FieldOffset(32)]  public float cloudCoverageSpeed;
        [FieldOffset(36)]  public float cloudTypeSpeed;
        [FieldOffset(40)]  public float cloudWetnessSpeed;
        [FieldOffset(44)]  public float miePhaseFunctionG;
        [FieldOffset(48)]  public float silverIntensity;
        [FieldOffset(52)]  public float silverSpread;
        [FieldOffset(56)]  public float scale;
        [FieldOffset(60)]  public float density;
        [FieldOffset(64)]  public float densityThreshold;
        [FieldOffset(68)]  public Color8 cloudsExtinctionColor1;
        [FieldOffset(80)]  public Vector4 cloudsExtinctionColor1Offset;
        [FieldOffset(96)]  public Color8 cloudsExtinctionColor2;
        [FieldOffset(112)] public Vector4 cloudsExtinctionColor2Offset;
        [FieldOffset(128)] public Color8 cloudsExtinctionColor3;
        [FieldOffset(144)] public Vector4 cloudsExtinctionColor3Offset;
        [FieldOffset(160)] public float cloudExtinctionBlend;
        [FieldOffset(164)] public bool enableShadow;
        [FieldOffset(168)] public int shadowCoverage;
        [FieldOffset(172)] public float shadowValueMin;
        [FieldOffset(176)] public FxCloudBlendParameter blendParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct FxCrepuscularRay
    {
        [FieldOffset(0)]  public bool enable;
        [FieldOffset(4)]  public float density;
        [FieldOffset(8)]  public float decay;
        [FieldOffset(12)] public float weight;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct FxManualHeightFog
    {
        [FieldOffset(0)]  public Vector3 sunColor;
        [FieldOffset(16)] public Vector3 ambColor;
    }

    [StructLayout(LayoutKind.Explicit, Size = 112)]
    public struct FxHeightFog
    {
        [FieldOffset(0)]  public bool enable;
        [FieldOffset(1)]  public bool enableFogMap;
        [FieldOffset(4)]  public float heightScale;
        [FieldOffset(8)]  public float distanceOffset;
        [FieldOffset(12)] public float distanceScale;
        [FieldOffset(16)] public Vector3 rayleighScale;
        [FieldOffset(32)] public Vector3 mieScale;
        [FieldOffset(48)] public float noiseBlend;
        [FieldOffset(52)] public float noiseScale;
        [FieldOffset(56)] public float noiseDistance;
        [FieldOffset(60)] public float animationSpeed;
        [FieldOffset(64)] public float animationAngle;
        [FieldOffset(68)] public bool isAtmospheric;
        [FieldOffset(80)] public FxManualHeightFog manualFog;
    }

    [StructLayout(LayoutKind.Explicit, Size = 752)]
    public struct FxAtmosphereParameter
    {
        [FieldOffset(0)]   public bool enable;
        [FieldOffset(4)]   public FxSun sunParam;
        [FieldOffset(52)]  public FxMoon moonParam;
        [FieldOffset(56)]  public FxSkyCommon commonSkyParam;
        [FieldOffset(80)]  public FxBrunetonSky brunetonSkyParam;
        [FieldOffset(224)] public FxSebastienSky sebastienSkyParam;
        [FieldOffset(368)] public FxCloudParameter cloudParam;
        [FieldOffset(624)] public FxCrepuscularRay crepuscularRayParam;
        [FieldOffset(640)] public FxHeightFog heightFogParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct FxPuddleParameter
    {
        [FieldOffset(0)]  public float heightThreshold;
        [FieldOffset(4)]  public float slopeThreshold;
        [FieldOffset(8)]  public float noiseScaleXZ;
        [FieldOffset(12)] public float noiseScaleY;
        [FieldOffset(16)] public float noiseThreshold;
        [FieldOffset(20)] public float noiseAttenuationRange;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct FxRippleParameter
    {
        [FieldOffset(0)]  public float intensity;
        [FieldOffset(4)]  public float uvScale;
        [FieldOffset(8)]  public float timeScale;
        [FieldOffset(12)] public float normalIntensity;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct FxDropParameter
    {
        [FieldOffset(0)] public float uvScale;
        [FieldOffset(4)] public float timeScale;
        [FieldOffset(8)] public float normalIntensity;
    }

    [StructLayout(LayoutKind.Explicit, Size = 128)]
    public struct FxRainParameter
    {
        [FieldOffset(0)]   public bool enableDrop;
        [FieldOffset(1)]   public bool enableFilter;
        [FieldOffset(2)]   public bool enableRipple;
        [FieldOffset(4)]   public float intensity;
        [FieldOffset(16)]  public Vector4 dropColor;
        [FieldOffset(32)]  public bool dropRotTarget;
        [FieldOffset(33)]  public bool enableDropOcc;
        [FieldOffset(36)]  public float dropCameraLerp;
        [FieldOffset(40)]  public float dropCameraRate;
        [FieldOffset(44)]  public float dropCameraRotation;
        [FieldOffset(48)]  public float dropWidth;
        [FieldOffset(52)]  public float dropLength;
        [FieldOffset(56)]  public float dropWind;
        [FieldOffset(60)]  public float dropRange;
        [FieldOffset(64)]  public Vector4 filterColor;
        [FieldOffset(80)]  public float filterRange;
        [FieldOffset(84)]  public float filterEdge;
        [FieldOffset(88)]  public float filterAngle;
        [FieldOffset(92)]  public FxRippleParameter ripple;
        [FieldOffset(108)] public FxDropParameter drop;
    }

    [StructLayout(LayoutKind.Explicit, Size = 160)]
    public struct FxWeatherParameter
    {
        [FieldOffset(0)]  public float wetness;
        [FieldOffset(4)]  public FxPuddleParameter puddle;
        [FieldOffset(32)] public FxRainParameter rain;
    }

    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public struct FxSceneEnvironmentParameter
    {
        [FieldOffset(0)]  public float windRotationY;
        [FieldOffset(4)]  public float windStrength;
        [FieldOffset(8)]  public float windNoise;
        [FieldOffset(12)] public float windAmplitude;
        [FieldOffset(16)] public unsafe fixed float windFrequencies[4];
        [FieldOffset(32)] public bool enableTreadGrass;
        [FieldOffset(48)] public Vector4 grassLodDistance;
        [FieldOffset(64)] public bool enableHighLight;
        [FieldOffset(68)] public float highLightThreshold;
        [FieldOffset(72)] public float highLightObjectAmbientScale;
        [FieldOffset(76)] public float highLightObjectAlbedoHeighten;
        [FieldOffset(80)] public float highLightCharaAmbientScale;
        [FieldOffset(84)] public float highLightCharaAlbedoHeighten;
        [FieldOffset(88)] public float highLightCharaFalloffScale;
    }

    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public struct FxTAAParameter
    {
        [FieldOffset(0)]  public bool enableUpscaling;
        [FieldOffset(4)]  public float jitterScale;
        [FieldOffset(8)]  public float mipBias;
        [FieldOffset(12)] public float sharpnessPower;
        [FieldOffset(16)] public float baseWeight;
        [FieldOffset(20)] public float velocityVarianceBasedWeightBias;
        [FieldOffset(24)] public float colorSpaceClippingScale;
        [FieldOffset(28)] public float colorSpaceClippingScaleForStatic;
        [FieldOffset(32)] public float velocityVarianceMin;
        [FieldOffset(36)] public float velocityVarianceMax;
        [FieldOffset(40)] public bool enableCharaStencilMask;
        [FieldOffset(41)] public bool enableLiteMode;
        [FieldOffset(42)] public bool enablePassThrough;
        [FieldOffset(43)] public bool debugVisualizeVelcotiyVariance;
        [FieldOffset(48)] public Vector4 debug;
    }

    public enum PlacementType : sbyte
{
        CirclePacking = 0,
        RandomPos = 1,
        PT_COUNT = 2
    }

    public enum ShadowCullingType : sbyte
{
        Normal = 0,
        AabbUpScale2 = 1,
        ShadowFrustum = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public struct FxDensityLodParameter
    {
        [FieldOffset(0)]  public float lodRatio;
        [FieldOffset(4)]  public float lodRise;
        [FieldOffset(8)]  public float lodDecrease;
        [FieldOffset(12)] public float lodThreshold;
        [FieldOffset(16)] public bool lodFadeEnable;
    }

    [StructLayout(LayoutKind.Explicit, Size = 204)]
    public struct FxDensityDebugParameter
    {
        [FieldOffset(0)]   public bool underSelect;
        [FieldOffset(4)]   public float factor;
        [FieldOffset(8)]   public unsafe fixed float unit[32];
        [FieldOffset(136)] public unsafe fixed sbyte chunk[32];
        [FieldOffset(168)] public float lodAddition;
        [FieldOffset(172)] public int chunkAddition;
        [FieldOffset(176)] public float drawLimitLenght;
        [FieldOffset(180)] public bool drawCallReduction;
        [FieldOffset(181)] public bool enableDither;
        [FieldOffset(184)] public int ditherGrass;
        [FieldOffset(188)] public int ditherOther;
        [FieldOffset(192)] public int ditherPreComputeGrass;
        [FieldOffset(196)] public int ditherPreComputeOther;
        [FieldOffset(200)] public int computeMode;
    }

    [StructLayout(LayoutKind.Explicit, Size = 268)]
    public struct FxDensityParameter
    {
        [FieldOffset(0)]  public bool enable;
        [FieldOffset(1)]  public bool precomputeEnable;
        [FieldOffset(2)]  public bool cameraUpdate;
        [FieldOffset(3)]  public PlacementType placement;
        [FieldOffset(4)]  public float placementScale;
        [FieldOffset(8)]  public bool alphaEnable;
        [FieldOffset(12)] public float alphaThreshold;
        [FieldOffset(16)] public float alphaScale;
        [FieldOffset(20)] public bool complementEnable;
        [FieldOffset(21)] public bool disableCut;
        [FieldOffset(22)] public ShadowCullingType shadowCulling;
        [FieldOffset(23)] public bool occlusionCulling;
        [FieldOffset(24)] public float occlusionSize;
        [FieldOffset(28)] public float occlusionShadowSize;
        [FieldOffset(32)] public float occlusionBias;
        [FieldOffset(36)] public FxDensityLodParameter lodParam;
        [FieldOffset(56)] public bool angleCulling;
        [FieldOffset(60)] public float angleCullingParam;
        [FieldOffset(64)] public FxDensityDebugParameter debugParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public struct FxChromaticAberrationParameter
    {
        [FieldOffset(0)]  public bool enable;
        [FieldOffset(4)]  public float offsetR;
        [FieldOffset(8)]  public float offsetG;
        [FieldOffset(12)] public float offsetB;
        [FieldOffset(16)] public float curve;
        [FieldOffset(20)] public float scaleX;
        [FieldOffset(24)] public float scaleY;
        [FieldOffset(28)] public float centerX;
        [FieldOffset(32)] public float centerY;
    }

    public enum GradationMode : sbyte
{
        GRADATION_MODE_CIRCLE = 0,
        GRADATION_MODE_LINE = 1
    }

    public enum BlendMode : sbyte
{
        BLEND_MODE_ALPHA_BLEND = 0,
        BLEND_MODE_ADD = 1,
        BLEND_MODE_MUL = 2,
        BLEND_MODE_SCREEN = 3,
        BLEND_MODE_OVERLAY = 4
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct FxVfImageCircleParameter
    {
        [FieldOffset(0)]  public float centerX;
        [FieldOffset(4)]  public float centerY;
        [FieldOffset(8)]  public float scaleX;
        [FieldOffset(12)] public float scaleY;
        [FieldOffset(16)] public float scale;
        [FieldOffset(20)] public float rotation;
    }

    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public struct FxVfLineParameter
    {
        [FieldOffset(0)]  public float centerX;
        [FieldOffset(4)]  public float centerY;
        [FieldOffset(8)]  public float directionX;
        [FieldOffset(12)] public float directionY;
        [FieldOffset(16)] public float rotation;
    }

    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public struct FxVfDepthParameter
    {
        [FieldOffset(0)]  public bool enable;
        [FieldOffset(4)]  public float minPenumbraScale;
        [FieldOffset(8)]  public float maxPenumbraScale;
        [FieldOffset(12)] public float bokehScale;
        [FieldOffset(16)] public float minDofOpacityScale;
        [FieldOffset(20)] public float maxDofOpacityScale;
        [FieldOffset(24)] public float minOpacityScale;
        [FieldOffset(28)] public float maxOpacityScale;
        [FieldOffset(32)] public float minOpacityDist;
        [FieldOffset(36)] public float maxOpacityDist;
    }

    [StructLayout(LayoutKind.Explicit, Size = 128)]
    public struct FxVignetteParameter
    {
        [FieldOffset(0)]  public bool enable;
        [FieldOffset(1)]  public GradationMode gradationType;
        [FieldOffset(2)]  public BlendMode blendMode;
        [FieldOffset(16)] public Vector3 color;
        [FieldOffset(32)] public float opacity;
        [FieldOffset(36)] public FxVfImageCircleParameter imageCircle;
        [FieldOffset(60)] public FxVfLineParameter line;
        [FieldOffset(80)] public float penumbraScale;
        [FieldOffset(84)] public float intensity;
        [FieldOffset(88)] public FxVfDepthParameter depth;
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct FxWindComputeDebugParameter
    {
        [FieldOffset(0)]  public bool debugEnable;
        [FieldOffset(1)]  public bool debugSpace;
        [FieldOffset(2)]  public bool debugGlobal;
        [FieldOffset(3)]  public bool debugGlobalMap;
        [FieldOffset(4)]  public bool debugSpaceAll;
        [FieldOffset(8)]  public int spaceIndex;
        [FieldOffset(12)] public float spaceThreshold;
        [FieldOffset(16)] public float min;
        [FieldOffset(20)] public float max;
    }

    [StructLayout(LayoutKind.Explicit, Size = 160)]
    public struct FxWindComputeParameter
    {
        [FieldOffset(0)]   public bool enableAll;
        [FieldOffset(1)]   public bool enableDynamicWind;
        [FieldOffset(2)]   public bool enableGlobalWind;
        [FieldOffset(4)]   public float timeScale;
        [FieldOffset(8)]   public float decreaseRate;
        [FieldOffset(16)]  public Vector3 globalWind;
        [FieldOffset(32)]  public float globalWindPower;
        [FieldOffset(36)]  public float globalWindSpeed;
        [FieldOffset(40)]  public float globalWindOffset;
        [FieldOffset(48)]  public Vector3 globalSecondWind;
        [FieldOffset(64)]  public float globalSecondWindPower;
        [FieldOffset(68)]  public float globalSecondWindSpeed;
        [FieldOffset(72)]  public float globalSecondWindOffset;
        [FieldOffset(80)]  public Vector3 globalWindMapSize;
        [FieldOffset(96)]  public Vector3 globalWindMapCenter;
        [FieldOffset(112)] public Vector3 globalWindMapOffset;
        [FieldOffset(128)] public float globalWindMapPower;
        [FieldOffset(132)] public float globalWindMapTimeScale;
        [FieldOffset(136)] public FxWindComputeDebugParameter debugParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct FxTerrainMaterialBlendingParameter
    {
        [FieldOffset(0)]  public bool enable;
        [FieldOffset(4)]  public float blendPower;
        [FieldOffset(8)]  public float blendHightPower;
        [FieldOffset(12)] public float cullingDistance;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct FxInteractionDebugParameter
    {
        [FieldOffset(0)] public bool enable;
        [FieldOffset(1)] public bool collisionEnable;
        [FieldOffset(4)] public float threshold;
    }

    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public struct FxInteractionParameter
    {
        [FieldOffset(0)]  public bool enable;
        [FieldOffset(4)]  public float power;
        [FieldOffset(8)]  public float decrease;
        [FieldOffset(12)] public float timeScale;
        [FieldOffset(16)] public FxInteractionDebugParameter debug;
        [FieldOffset(24)] public float tremorPower;
        [FieldOffset(28)] public float tremorSpeed;
        [FieldOffset(32)] public float tremorScaleCriterion;
        [FieldOffset(36)] public float tremorScaleReduce;
    }

    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public struct FxGpuEnvironmentParameter
    {
        [FieldOffset(0)]  public float grassDitherStart;
        [FieldOffset(4)]  public float grassDitherEnd;
        [FieldOffset(8)]  public FxInteractionParameter interaction;
        [FieldOffset(48)] public bool enableZoomBias;
        [FieldOffset(52)] public float zoomBias;
    }

    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public struct FxInteractiveWaveParameter
    {
        [FieldOffset(0)]  public bool enable;
        [FieldOffset(1)]  public bool enableDebugDisplay;
        [FieldOffset(4)]  public float waveDamping;
        [FieldOffset(8)]  public float waveReduceRange;
        [FieldOffset(12)] public float waveSpeed;
        [FieldOffset(16)] public float simurationScale;
        [FieldOffset(20)] public float playerMaxSpeed;
        [FieldOffset(24)] public bool isInWaterDummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 60)]
    public struct FxCyberNoiseEffectParameter
    {
        [FieldOffset(0)]  public bool enable;
        [FieldOffset(4)]  public float tileX;
        [FieldOffset(8)]  public float tileY;
        [FieldOffset(12)] public float tileScrollSpeed;
        [FieldOffset(16)] public float noiseScrollSpeed;
        [FieldOffset(20)] public float thresholdSpeed;
        [FieldOffset(24)] public float thredholdMin;
        [FieldOffset(28)] public float thredholdMax;
        [FieldOffset(32)] public float selectRate;
        [FieldOffset(36)] public float scanLineRSpeed;
        [FieldOffset(40)] public float scanLineRBlend;
        [FieldOffset(44)] public float scanLineGSpeed;
        [FieldOffset(48)] public float scanLineGBlend;
        [FieldOffset(52)] public float rgbLineScale;
        [FieldOffset(56)] public float rgbLineBlend;
    }

    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public struct UVShift
    {
        [FieldOffset(0)]  public float blockLNoiseSizeX;
        [FieldOffset(4)]  public float blockLNoiseSizeY;
        [FieldOffset(8)]  public float blockHNoiseSizeX;
        [FieldOffset(12)] public float blockHNoiseSizeY;
        [FieldOffset(16)] public float bNoiseHighRate;
        [FieldOffset(20)] public float intensity;
        [FieldOffset(24)] public float pixelShiftIntensity;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct ColorShift
    {
        [FieldOffset(0)]  public float blockLNoiseSize;
        [FieldOffset(4)]  public float blockHNoiseSize;
        [FieldOffset(8)]  public float bNoiseHighRate;
        [FieldOffset(12)] public float intensity;
    }

    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public struct InterlaceNoise
    {
        [FieldOffset(0)]  public float blockLNoiseSize;
        [FieldOffset(4)]  public float blockHNoiseSize;
        [FieldOffset(8)]  public float bNoiseHighRate;
        [FieldOffset(12)] public float intensity;
        [FieldOffset(16)] public float dropout;
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct ColorDropout
    {
        [FieldOffset(0)]  public float blockLNoiseSizeX;
        [FieldOffset(4)]  public float blockLNoiseSizeY;
        [FieldOffset(8)]  public float blockHNoiseSizeX;
        [FieldOffset(12)] public float blockHNoiseSizeY;
        [FieldOffset(16)] public float bNoiseHighRate;
        [FieldOffset(20)] public float intensity;
    }

    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public struct InvertColor
    {
        [FieldOffset(0)]  public float blockLNoiseSizeX;
        [FieldOffset(4)]  public float blockLNoiseSizeY;
        [FieldOffset(8)]  public float blockHNoiseSizeX;
        [FieldOffset(12)] public float blockHNoiseSizeY;
        [FieldOffset(16)] public float bNoiseHighRate;
        [FieldOffset(20)] public float intensity;
        [FieldOffset(24)] public float invertAllRate;
    }

    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public struct GlayScaleColor
    {
        [FieldOffset(0)]  public float blockLNoiseSizeX;
        [FieldOffset(4)]  public float blockLNoiseSizeY;
        [FieldOffset(8)]  public float blockHNoiseSizeX;
        [FieldOffset(12)] public float blockHNoiseSizeY;
        [FieldOffset(16)] public float bNoiseHighRate;
        [FieldOffset(20)] public float intensity;
        [FieldOffset(24)] public float invertAllRate;
    }

    [StructLayout(LayoutKind.Explicit, Size = 164)]
    public struct FxCyberSpaceStartNoiseParameter
    {
        [FieldOffset(0)]   public bool enable;
        [FieldOffset(4)]   public UVShift uvShift;
        [FieldOffset(32)]  public ColorShift colorShift;
        [FieldOffset(48)]  public InterlaceNoise interlaceNoise;
        [FieldOffset(68)]  public ColorDropout colorDrop;
        [FieldOffset(92)]  public InvertColor invertColor;
        [FieldOffset(120)] public GlayScaleColor glayscaleColor;
        [FieldOffset(148)] public float noiseSpeed;
        [FieldOffset(152)] public float noiseBias;
        [FieldOffset(156)] public float noiseWaveAmplitude;
        [FieldOffset(160)] public float noiseWaveCycle;
    }

    [StructLayout(LayoutKind.Explicit, Size = 1)]
    public struct FxCyberNPCSSEffectRenderParameter
    {
        [FieldOffset(0)] public bool enable;
    }

    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public struct FxFieldScanEffectRenderParameter
    {
        [FieldOffset(0)]  public bool enable;
        [FieldOffset(16)] public Vector3 centerPos;
        [FieldOffset(32)] public Color8 color;
        [FieldOffset(36)] public float radius1;
        [FieldOffset(40)] public float radius2;
        [FieldOffset(44)] public float radius3;
        [FieldOffset(48)] public float intensity1;
        [FieldOffset(52)] public float intensity2;
        [FieldOffset(56)] public float intensity3;
        [FieldOffset(60)] public float gridIntensity;
        [FieldOffset(64)] public float innerWidth;
        [FieldOffset(68)] public float gridLineWidth;
        [FieldOffset(72)] public float gridLineSpan;
    }

    public enum ColorblinidSimulationType : sbyte
{
        COLORBLIND_SIM_NONE = 0,
        COLORBLIND_SIM_PROTANOPIA = 1,
        COLORBLIND_SIM_DEUTERANOPIA = 2,
        COLORBLIND_SIM_TRITANOPIA = 3,
        COLORBLIND_SIM_ALL = 4
    }

    [StructLayout(LayoutKind.Explicit, Size = 52)]
    public struct FxColorAccessibilityFilterParameter
    {
        [FieldOffset(0)]  public bool enable;
        [FieldOffset(4)]  public float daltonizeFactor;
        [FieldOffset(8)]  public float protanopiaFactor;
        [FieldOffset(12)] public float deuteranopiaFactor;
        [FieldOffset(16)] public float tritanopiaFactor;
        [FieldOffset(20)] public float brightness;
        [FieldOffset(24)] public float contrast;
        [FieldOffset(28)] public unsafe fixed float maskIntensity[5];
        [FieldOffset(48)] public ColorblinidSimulationType simulationType;
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct FxDentParameter
    {
        [FieldOffset(0)]  public bool enable;
        [FieldOffset(4)]  public float simRadius;
        [FieldOffset(8)]  public float dentDepth;
        [FieldOffset(12)] public float normalIntensity;
        [FieldOffset(16)] public float edgeBulge;
        [FieldOffset(20)] public float fade;
    }

    [StructLayout(LayoutKind.Explicit, Size = 272)]
    public struct FxSeparableSSSParameter
    {
        [FieldOffset(0)]  public bool enable;
        [FieldOffset(4)]  public float width;
        [FieldOffset(8)]  public float normalOffset;
        [FieldOffset(12)] public float blurOffsetMax;
        [FieldOffset(16)] public unsafe fixed byte /* Vector4[16] */ _strength[256];

        public unsafe Vector4* strength
        {
            get
            {
                fixed (byte* p_strength = _strength)
                    return (Vector4*)p_strength;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 4720)]
    public struct NeedleFxParameter
    {
        [FieldOffset(0)]    public FxRenderOption renderOption;
        [FieldOffset(592)]  public FxSGGIParameter sggi;
        [FieldOffset(616)]  public FxRLRParameter rlr;
        [FieldOffset(656)]  public FxSSGIParameter ssgi;
        [FieldOffset(688)]  public FxPlanarReflectionParameter planarReflection;
        [FieldOffset(736)]  public FxBloomParameter bloom;
        [FieldOffset(752)]  public FxCameraControlParameter cameraControl;
        [FieldOffset(796)]  public FxToneMapParameter tonemap;
        [FieldOffset(844)]  public FxColorContrastParameter colorContrast;
        [FieldOffset(928)]  public FxLightScatteringParameter lightscattering;
        [FieldOffset(1024)] public FxDOFParameter dof;
        [FieldOffset(1120)] public FxShadowMapParameter shadowmap;
        [FieldOffset(1456)] public FxShadowHeightMapParameter shadowHeightMap;
        [FieldOffset(1476)] public FxVolumetricShadowParameter volShadow;
        [FieldOffset(1480)] public FxSSAOParameter ssao;
        [FieldOffset(1600)] public FxSHLightFieldParameter shlightfield;
        [FieldOffset(1664)] public FxScreenBlurParameter blur;
        [FieldOffset(1712)] public FxOcclusionCapsuleParameter occlusionCapsule;
        [FieldOffset(1856)] public FxEffectParameter effect;
        [FieldOffset(1952)] public FxScreenSpaceGodrayParameter ssGodray;
        [FieldOffset(2016)] public FxGodrayParameter godray;
        [FieldOffset(2256)] public FxHeatHazeParameter heatHaze;
        [FieldOffset(2288)] public FxAtmosphereParameter atmosphere;
        [FieldOffset(3040)] public FxWeatherParameter weather;
        [FieldOffset(3200)] public FxSceneEnvironmentParameter sceneEnv;
        [FieldOffset(3296)] public FxTAAParameter taa;
        [FieldOffset(3360)] public FxDensityParameter density;
        [FieldOffset(3628)] public FxChromaticAberrationParameter chromaticAberration;
        [FieldOffset(3664)] public FxVignetteParameter vignette;
        [FieldOffset(3792)] public FxWindComputeParameter wind;
        [FieldOffset(3952)] public FxTerrainMaterialBlendingParameter terrainBlend;
        [FieldOffset(3968)] public FxGpuEnvironmentParameter gpuEnvironment;
        [FieldOffset(4024)] public FxInteractiveWaveParameter interactiveWave;
        [FieldOffset(4052)] public FxCyberNoiseEffectParameter cyberNoise;
        [FieldOffset(4112)] public FxCyberSpaceStartNoiseParameter cyberStartNoise;
        [FieldOffset(4276)] public FxCyberNPCSSEffectRenderParameter cyberNPCSS;
        [FieldOffset(4288)] public FxFieldScanEffectRenderParameter fieldScan;
        [FieldOffset(4368)] public FxColorAccessibilityFilterParameter colorAccessibility;
        [FieldOffset(4420)] public FxDentParameter dent;
        [FieldOffset(4448)] public FxSeparableSSSParameter ssss;
    }

    [StructLayout(LayoutKind.Explicit, Size = 688)]
    public struct TimeProgressAtmosphereParameter
    {
        [FieldOffset(0)]   public FxSkyCommon commonSkyParam;
        [FieldOffset(16)]  public FxBrunetonSky brunetonSkyParam;
        [FieldOffset(160)] public FxSebastienSky sebastienSkyParam;
        [FieldOffset(304)] public FxCloudParameter cloudParam;
        [FieldOffset(560)] public FxCrepuscularRay crepuscularRayParam;
        [FieldOffset(576)] public FxHeightFog heightFogParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 1616)]
    public struct TimeProgressNeedleFxParam
    {
        [FieldOffset(0)]    public bool enable;
        [FieldOffset(4)]    public float time;
        [FieldOffset(8)]    public FxBloomParameter bloom;
        [FieldOffset(24)]   public FxCameraControlParameter cameraControl;
        [FieldOffset(68)]   public FxCameraControlParameter cameraControlEvent;
        [FieldOffset(112)]  public FxToneMapParameter tonemap;
        [FieldOffset(160)]  public FxColorContrastParameter colorContrast;
        [FieldOffset(240)]  public FxLightScatteringParameter lightscattering;
        [FieldOffset(336)]  public FxEffectParameter effect;
        [FieldOffset(432)]  public FxScreenSpaceGodrayParameter ssGodray;
        [FieldOffset(496)]  public FxGodrayParameter godray;
        [FieldOffset(736)]  public FxHeatHazeParameter heatHaze;
        [FieldOffset(768)]  public TimeProgressAtmosphereParameter atmosphere;
        [FieldOffset(1456)] public FxWeatherParameter weather;
    }

    [StructLayout(LayoutKind.Explicit, Size = 1776)]
    public struct WeatherFxParameter
    {
        [FieldOffset(0)]    public bool enable;
        [FieldOffset(4)]    public FxBloomParameter bloom;
        [FieldOffset(20)]   public FxCameraControlParameter cameraControl;
        [FieldOffset(64)]   public FxCameraControlParameter cameraControlEvent;
        [FieldOffset(108)]  public FxToneMapParameter tonemap;
        [FieldOffset(156)]  public FxColorContrastParameter colorContrast;
        [FieldOffset(240)]  public FxLightScatteringParameter lightscattering;
        [FieldOffset(336)]  public FxEffectParameter effect;
        [FieldOffset(432)]  public FxScreenSpaceGodrayParameter ssGodray;
        [FieldOffset(496)]  public FxGodrayParameter godray;
        [FieldOffset(736)]  public FxHeatHazeParameter heatHaze;
        [FieldOffset(768)]  public TimeProgressAtmosphereParameter atmosphere;
        [FieldOffset(1456)] public FxWeatherParameter weather;
        [FieldOffset(1616)] public FxWindComputeParameter wind;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct StageCommonParameter
    {
        [FieldOffset(0)] public float deadline;
        [FieldOffset(4)] public float oceanSurface;
        [FieldOffset(8)] public float deadFallTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct StageCameraParameter
    {
        [FieldOffset(0)] public float zNear;
        [FieldOffset(4)] public float zFar;
        [FieldOffset(8)] public float fovy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct StageTerrainPrecisionParameter
    {
        [FieldOffset(0)] public float heightRange;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct StageTerrainMaterialParameter
    {
        [FieldOffset(0)]  public float uvScaleDetail;
        [FieldOffset(4)]  public float uvScaleBase;
        [FieldOffset(8)]  public float detailDistance;
        [FieldOffset(12)] public float detailFadeRange;
    }

    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public struct StageTerrainParameter
    {
        [FieldOffset(0)]  public bool useHeightMapTerrain;
        [FieldOffset(1)]  public bool useHalfPrecision;
        [FieldOffset(4)]  public StageTerrainPrecisionParameter precision;
        [FieldOffset(8)]  public int worldSize;
        [FieldOffset(12)] public int heightMapTexelDensity;
        [FieldOffset(16)] public float heightScale;
        [FieldOffset(20)] public float smallestCellSize;
        [FieldOffset(24)] public float slopeClipThrethold;
        [FieldOffset(28)] public Vector2 aabbMin;
        [FieldOffset(36)] public Vector2 aabbMax;
        [FieldOffset(44)] public StageTerrainMaterialParameter material;
        [FieldOffset(60)] public bool enableGbufferBlending;
    }

    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public struct StageConfig
    {
        [FieldOffset(0)]  public StageCommonParameter common;
        [FieldOffset(12)] public StageCameraParameter camera;
        [FieldOffset(24)] public StageTerrainParameter terrain;
    }

    [StructLayout(LayoutKind.Explicit, Size = 127152)]
    public struct NeedleFxSceneData
    {
        [FieldOffset(0)]      public NeedleFxSceneConfig config;
        [FieldOffset(320)]    public unsafe fixed byte /* NeedleFxParameter[16] */ _items[75520];

        public unsafe NeedleFxParameter* items
        {
            get
            {
                fixed (byte* p_items = _items)
                    return (NeedleFxParameter*)p_items;
            }
        }

        [FieldOffset(75840)]  public unsafe fixed byte /* TimeProgressNeedleFxParam[24] */ _timeItems[38784];

        public unsafe TimeProgressNeedleFxParam* timeItems
        {
            get
            {
                fixed (byte* p_timeItems = _timeItems)
                    return (TimeProgressNeedleFxParam*)p_timeItems;
            }
        }

        [FieldOffset(114624)] public unsafe fixed byte /* WeatherFxParameter[7] */ _weatherItems[12432];

        public unsafe WeatherFxParameter* weatherItems
        {
            get
            {
                fixed (byte* p_weatherItems = _weatherItems)
                    return (WeatherFxParameter*)p_weatherItems;
            }
        }

        [FieldOffset(127056)] public StageConfig stageConfig;
    }

}