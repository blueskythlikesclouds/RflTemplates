using System.Numerics;
using System.Runtime.InteropServices;

public class WolfVolumeSizeClass
{
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct WolfVolumeSize
    {
        [FieldOffset(0)] public float width;
        [FieldOffset(4)] public float height;
        [FieldOffset(8)] public float depth;
    }

}