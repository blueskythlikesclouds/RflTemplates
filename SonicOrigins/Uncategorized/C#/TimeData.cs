using System.Numerics;
using System.Runtime.InteropServices;

public class TimeDataClass
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct TimeData
    {
        [FieldOffset(0)] public int m_value;
    }

}