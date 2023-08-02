Library "UIWireframeParameter"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

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

    [StructLayout(LayoutKind.Explicit, Size = 128)]
    public struct UIWireframeParameter
    {
        [FieldOffset(0)]  public Vector3 camerapos;
        [FieldOffset(16)] public float lineAlpha;
        [FieldOffset(20)] public float noiseScale;
        [FieldOffset(24)] public float noiseSpeed;
        [FieldOffset(28)] public float moveWidth;
        [FieldOffset(32)] public FxDOFParameter dofparam;
    }

}