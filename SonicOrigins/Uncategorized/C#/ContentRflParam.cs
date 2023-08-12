using System.Numerics;
using System.Runtime.InteropServices;

public class ContentRflParamClass
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct BonusDLCParam
    {
        [FieldOffset(0)] public int addCoin;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct ContentRflParam
    {
        [FieldOffset(0)] public BonusDLCParam bonusDLCParam;
    }

}