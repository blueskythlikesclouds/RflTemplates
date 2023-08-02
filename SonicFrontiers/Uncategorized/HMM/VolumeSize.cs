Library "VolumeSize"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct VolumeSize
    {
        [FieldOffset(0)] public float width;
        [FieldOffset(4)] public float height;
        [FieldOffset(8)] public float depth;
    }

}