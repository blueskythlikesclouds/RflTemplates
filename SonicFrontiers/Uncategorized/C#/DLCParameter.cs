using System.Numerics;
using System.Runtime.InteropServices;

public class DLCParameterClass
{
    [StructLayout(LayoutKind.Explicit, Size = 1)]
    public struct DLCParameter
    {
        [FieldOffset(0)] public byte dummy;
    }

}