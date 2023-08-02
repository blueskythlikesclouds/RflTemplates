Library "FxCloudShadowParameter"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct FxCloudShadowParameter
    {
        [FieldOffset(0)] public bool enableShadow;
        [FieldOffset(4)] public int shadowCoverage;
        [FieldOffset(8)] public float shadowValueMin;
    }

}