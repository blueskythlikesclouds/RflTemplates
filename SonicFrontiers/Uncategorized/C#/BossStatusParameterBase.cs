using System.Numerics;
using System.Runtime.InteropServices;

public class BossStatusParameterBaseClass
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct BossStatusParameterBase
    {
        [FieldOffset(0)] public int maxHp;
    }

}