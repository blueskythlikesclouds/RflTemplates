using System.Numerics;
using System.Runtime.InteropServices;

public class EnemyHelicopterConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct HeliDamageCol
    {
        [FieldOffset(0)]  public float radius;
        [FieldOffset(16)] public Vector3 pos;
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct HeliCommon
    {
        [FieldOffset(0)]  public float followRotateSpeed;
        [FieldOffset(16)] public HeliDamageCol damageCol;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct HeliAttackBase
    {
        [FieldOffset(0)] public float life;
        [FieldOffset(4)] public float attackInterval;
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct HeliBullet
    {
        [FieldOffset(0)]  public HeliAttackBase heliAttackBase;
        [FieldOffset(8)]  public float bulletSpeed;
        [FieldOffset(12)] public float gunRotateSpeed;
        [FieldOffset(16)] public byte attackChainNum;
        [FieldOffset(20)] public float attackChainInterval;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct HeliBomb
    {
        [FieldOffset(0)] public HeliAttackBase heliAttackBase;
        [FieldOffset(8)] public float bombSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public struct EnemyHelicopterConfig
    {
        [FieldOffset(0)]  public HeliCommon common;
        [FieldOffset(48)] public HeliBullet attackBullet;
        [FieldOffset(72)] public HeliBomb attackBomb;
    }

}