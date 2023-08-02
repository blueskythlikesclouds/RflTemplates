Library "BossStatusParameterBase"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct BossStatusParameterBase
    {
        [FieldOffset(0)] public int maxHp;
    }

}