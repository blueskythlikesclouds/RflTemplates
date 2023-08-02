using System.Numerics;
using System.Runtime.InteropServices;

public class StatsDataContainerClass
{

public enum StatsType : int
{
    TYPE_INVALID = 0,
    TYPE_UINT64 = 1,
    TYPE_UINT32 = 2,
    TYPE_SINT32 = 3,
    TYPE_FLOAT = 4
}

[StructLayout(LayoutKind.Explicit, Size = 16)]
public struct StatsDataValue
{
    [FieldOffset(0)] public StatsType type;
    [FieldOffset(8)] public ulong value;
}

[StructLayout(LayoutKind.Explicit, Size = 32)]
public struct StatsDataContainer
{
    [FieldOffset(0)] public StatsDataValue data;
}

} // StatsDataContainerClass