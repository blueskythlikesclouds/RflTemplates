Library "DLCParameter"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 1)]
    public struct DLCParameter
    {
        [FieldOffset(0)] public byte dummy;
    }

}