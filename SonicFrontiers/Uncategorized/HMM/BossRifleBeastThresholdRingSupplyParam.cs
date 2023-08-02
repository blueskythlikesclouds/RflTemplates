Library "BossRifleBeastThresholdRingSupplyParam"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    public enum LaserType : sbyte
{
        LT_NONE = 0,
        LT_STRAIGHT = 1,
        LT_HOMING = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct BossRifleBeastThresholdRingSupplyParam
    {
        [FieldOffset(0)] public float hpRatio;
        [FieldOffset(4)] public LaserType type;
    }

}