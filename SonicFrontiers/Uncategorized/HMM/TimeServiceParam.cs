Library "TimeServiceParam"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct TimeServiceParam
    {
        [FieldOffset(0)] public float speed;
        [FieldOffset(4)] public float timeMagnification;
        [FieldOffset(8)] public int addMinuteReturnFromCyber;
    }

}