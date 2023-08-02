Library "DecoTechParams"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct CString
    {
        [FieldOffset(0)] public long pValue;

        public string Value
        {
        	get => Marshal.PtrToStringAnsi((IntPtr)pValue);
        	set => pValue = (long)Marshal.StringToHGlobalAnsi(value);
        }
    }

    public struct Color8
    {
        public byte A;
        public byte R;
        public byte G;
        public byte B;
    }

    public enum Orientation : sbyte
{
        ORIENTATION_NONE = 0,
        ORIENTATION_HORIZONTAL = 1,
        ORIENTATION_VERTICAL = 2,
        ORIENTATION_DIAGONAL = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct DecoGradationParam
    {
        [FieldOffset(0)]  public Orientation orientation;
        [FieldOffset(1)]  public sbyte srcPosX;
        [FieldOffset(2)]  public sbyte srcPosY;
        [FieldOffset(3)]  public sbyte dstPosX;
        [FieldOffset(4)]  public sbyte dstPosY;
        [FieldOffset(8)]  public Color8 srcColor;
        [FieldOffset(12)] public Color8 dstColor;
    }

    public enum DecoLayerBlendOp : sbyte
{
        DECO_LAYER_BLEND_OP_BLEND = 0,
        DECO_LAYER_BLEND_OP_SUBTRACT_ALPHA = 1
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct DecoDropShadowParam
    {
        [FieldOffset(0)] public Color8 color;
        [FieldOffset(4)] public byte size;
        [FieldOffset(5)] public byte spread;
        [FieldOffset(6)] public sbyte distanceX;
        [FieldOffset(7)] public sbyte distanceY;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct DecoRimParam
    {
        [FieldOffset(0)]  public Color8 color;
        [FieldOffset(4)]  public int thickness;
        [FieldOffset(8)]  public int offsetX;
        [FieldOffset(12)] public int offsetY;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct DecoBlurParam
    {
        [FieldOffset(0)] public int radius;
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct DecoPassParam
    {
        [FieldOffset(0)]  public DecoDropShadowParam dropShadow;
        [FieldOffset(8)]  public DecoRimParam rim;
        [FieldOffset(24)] public DecoGradationParam gradation;
        [FieldOffset(40)] public DecoBlurParam blur;
        [FieldOffset(44)] public bool avoidEdgeArtifact;
    }

    [StructLayout(LayoutKind.Explicit, Size = 288)]
    public struct DecoTechParam
    {
        [FieldOffset(0)]  public CString name;
        [FieldOffset(16)] public Color8 fontColor;
        [FieldOffset(20)] public DecoGradationParam fontGradParam;
        [FieldOffset(36)] public DecoLayerBlendOp layerBlendOp;
        [FieldOffset(40)] public int numPasses;
        [FieldOffset(44)] public unsafe fixed byte /* DecoPassParam[5] */ _passParams[240];

        public unsafe DecoPassParam* passParams
        {
            get
            {
                fixed (byte* p_passParams = _passParams)
                    return (DecoPassParam*)p_passParams;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 147456)]
    public struct DecoTechParams
    {
        [FieldOffset(0)] public unsafe fixed byte /* DecoTechParam[512] */ __params[147456];

        public unsafe DecoTechParam* _params
        {
            get
            {
                fixed (byte* p__params = __params)
                    return (DecoTechParam*)p__params;
            }
        }
    }

}