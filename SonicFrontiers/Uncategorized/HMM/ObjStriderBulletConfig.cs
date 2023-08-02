Library "ObjStriderBulletConfig"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    public enum ShootingDirection : byte
{
        Sonic = 0,
        Random = 1,
        NumShootingDirections = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public struct CommonBulletParam
    {
        [FieldOffset(0)]  public ShootingDirection shootingDirection;
        [FieldOffset(4)]  public float lifeTime;
        [FieldOffset(8)]  public float speedToRail;
        [FieldOffset(12)] public float speed;
        [FieldOffset(16)] public float yOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public struct HomingBulletParam
    {
        [FieldOffset(0)]  public CommonBulletParam commonBulletParam;
        [FieldOffset(20)] public float railChangeDelay;
        [FieldOffset(24)] public float turnaroundTime;
        [FieldOffset(28)] public float splinePositionDistance;
        [FieldOffset(32)] public bool changesRails;
    }

    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public struct ReverseHomingBulletParam
    {
        [FieldOffset(0)]  public CommonBulletParam commonBulletParam;
        [FieldOffset(20)] public float railChangeDelay;
        [FieldOffset(24)] public float turnaroundTime;
        [FieldOffset(28)] public float splinePositionDistance;
        [FieldOffset(32)] public bool changesRails;
    }

    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public struct SameBodyRailBulletParam
    {
        [FieldOffset(0)] public CommonBulletParam commonBulletParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 92)]
    public struct ObjStriderBulletConfig
    {
        [FieldOffset(0)]  public HomingBulletParam homingBulletParam;
        [FieldOffset(36)] public ReverseHomingBulletParam reverseHomingBulletParam;
        [FieldOffset(72)] public SameBodyRailBulletParam sameBodyRailBulletParam;
    }

}