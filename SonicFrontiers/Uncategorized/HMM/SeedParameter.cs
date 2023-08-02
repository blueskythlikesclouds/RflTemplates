Library "SeedParameter"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    public enum SeedType : byte
{
        SeedSensor = 0,
        ObjItem = 1
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct SeedParameter
    {
        [FieldOffset(0)] public float suckedTime;
        [FieldOffset(4)] public SeedType seedType;
    }

}