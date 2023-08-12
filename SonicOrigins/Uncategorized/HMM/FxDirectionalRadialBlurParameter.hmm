Library "FxDirectionalRadialBlurParameter"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public struct FxDirectionalRadialBlurParameter
    {
        [FieldOffset(0)]  public bool enable;
        [FieldOffset(16)] public Vector3 center;
        [FieldOffset(32)] public Vector3 direction;
        [FieldOffset(48)] public float blurPowerMax;
        [FieldOffset(52)] public float blurPowerMin;
        [FieldOffset(56)] public float focusRange;
        [FieldOffset(60)] public float alphaSlope;
        [FieldOffset(64)] public int sampleNum;
    }

}