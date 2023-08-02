Library "MiniBossChargerAttackParam"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    public enum AttackType : int
{
        AttackTypeInvalid = 0,
        AttackSimpleRotateBullet = 1,
        AttackFollowLaser = 2,
        AttackVortexLaser = 3,
        AttackCrossLaser = 4,
        AttackCrossBullet = 5,
        AttackMassLaser = 6,
        AttackVerticalRoundBullet = 7,
        AttackPyramidRoundBullet = 8,
        AttackPlaneUpDownBullet = 9,
        AttackTriangleBatteryBullet = 10,
        AttackPlayerFallBullet = 11,
        AttackGatlingRevolverBullet = 12,
        AttackWinderBullet = 13,
        AttackShotgunBullet = 14,
        AttackAirDropBullet = 15,
        AttackChaseShotObject = 16,
        AttackDiffuseLaser = 17,
        AttackChaseShot = 18,
        AttackTypeNum = 19
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct MiniBossChargerAttackParam
    {
        [FieldOffset(0)]  public AttackType type;
        [FieldOffset(4)]  public int index;
        [FieldOffset(8)]  public float rate;
        [FieldOffset(12)] public float restTime;
    }

}