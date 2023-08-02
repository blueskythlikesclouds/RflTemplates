Library "ObjBossRingSupplyConfig"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public struct RingParameter
    {
        [FieldOffset(0)]  public float suckedTime;
        [FieldOffset(4)]  public float launchAngle;
        [FieldOffset(8)]  public float launchMaxSpeed;
        [FieldOffset(12)] public float launchMinSpeed;
        [FieldOffset(16)] public float randomRangeMin;
        [FieldOffset(20)] public float randomRangeMax;
        [FieldOffset(24)] public float lifeTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct ObjBossRingSupplyConfig
    {
        [FieldOffset(0)]  public RingParameter ringParam;
        [FieldOffset(28)] public float requestTime;
        [FieldOffset(32)] public float accessDistance;
        [FieldOffset(36)] public unsafe fixed uint numRings[3];
    }

}