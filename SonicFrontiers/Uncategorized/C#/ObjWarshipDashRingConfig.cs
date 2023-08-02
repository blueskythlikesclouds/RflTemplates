using System.Numerics;
using System.Runtime.InteropServices;

public class ObjWarshipDashRingConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct ObjWarshipDashRingConfig
    {
        [FieldOffset(0)] public float baseHeight;
    }

}