Library "FxFogParameter"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct FxDistanceFogParameter
    {
        [FieldOffset(0)]  public bool enable;
        [FieldOffset(16)] public Vector3 color;
        [FieldOffset(32)] public float intensity;
        [FieldOffset(36)] public float nearDist;
        [FieldOffset(40)] public float farDist;
        [FieldOffset(44)] public float influence;
    }

    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public struct FxHeightFogParameter
    {
        [FieldOffset(0)]  public bool enable;
        [FieldOffset(16)] public Vector3 color;
        [FieldOffset(32)] public float intensity;
        [FieldOffset(36)] public float minHeight;
        [FieldOffset(40)] public float maxHeight;
        [FieldOffset(44)] public float nearDist;
        [FieldOffset(48)] public float farDist;
        [FieldOffset(52)] public float influence;
    }

    [StructLayout(LayoutKind.Explicit, Size = 112)]
    public struct FxFogParameter
    {
        [FieldOffset(0)]  public FxDistanceFogParameter distanceFogParam;
        [FieldOffset(48)] public FxHeightFogParameter heightFogParam;
    }

}