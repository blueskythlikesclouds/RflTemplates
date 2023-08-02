using System.Numerics;
using System.Runtime.InteropServices;

public class GameExpParameterClass
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct GameExpParameter
    {
        [FieldOffset(0)] public uint maxExpPointBase;
        [FieldOffset(4)] public uint maxExpPointAdd;
    }

}