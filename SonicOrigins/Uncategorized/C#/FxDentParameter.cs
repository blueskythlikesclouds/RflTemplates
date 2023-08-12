using System.Numerics;
using System.Runtime.InteropServices;

public class FxDentParameterClass
{
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public struct FxDentParameter
    {
        [FieldOffset(0)]  public bool enable;
        [FieldOffset(4)]  public float simRadius;
        [FieldOffset(8)]  public float dentDepth;
        [FieldOffset(12)] public float normalIntensity;
        [FieldOffset(16)] public float edgeBulge;
    }

}