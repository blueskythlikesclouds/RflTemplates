Library "FxHeightMapParameter"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 160)]
    public struct FxHeightMapParameter
    {
        [FieldOffset(0)]  public bool enable;
        [FieldOffset(1)]  public bool enableMultiHeightmap;
        [FieldOffset(2)]  public bool debugDrawFrustum;
        [FieldOffset(3)]  public bool reprojection;
        [FieldOffset(4)]  public uint renderTargetWidth;
        [FieldOffset(8)]  public uint renderTargetHeight;
        [FieldOffset(12)] public float referenceValue;
        [FieldOffset(16)] public float heightScale;
        [FieldOffset(20)] public float fadeTime;
        [FieldOffset(24)] public float colorMask;
        [FieldOffset(32)] public Matrix4x4 viewMatrix;
        [FieldOffset(96)] public Matrix4x4 projMatrix;
    }

}