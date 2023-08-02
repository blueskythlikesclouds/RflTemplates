using System.Numerics;
using System.Runtime.InteropServices;

public class ObjSumoPuckConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public struct ObjSumoPuckConfig
    {
        [FieldOffset(0)]  public float mass;
        [FieldOffset(4)]  public float slopeAngleMax;
        [FieldOffset(8)]  public float stairHeightMax;
        [FieldOffset(12)] public float colliderRigidHeight;
        [FieldOffset(16)] public float colliderRigidRadius;
        [FieldOffset(20)] public float colliderEventHeight;
        [FieldOffset(24)] public float colliderEventRadius;
        [FieldOffset(28)] public float colliderOffsetHeightSlingshot;
        [FieldOffset(32)] public float explodeRadius;
        [FieldOffset(36)] public float bumperBlowSpeed;
        [FieldOffset(40)] public float bumperOCTime;
        [FieldOffset(44)] public int damageToEnemy;
        [FieldOffset(48)] public float lifeTimeParried;
        [FieldOffset(52)] public float decelerationParried;
    }

}