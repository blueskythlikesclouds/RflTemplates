Library "EnemyLaserConfig"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct EnemyLaserConfig
    {
        [FieldOffset(0)]  public float rotLaserVanishTime;
        [FieldOffset(4)]  public float rotLaserOmenTime;
        [FieldOffset(8)]  public float bigLaserVanishTime;
        [FieldOffset(12)] public float bigLaserOmenTime;
    }

}