using System.Numerics;
using System.Runtime.InteropServices;

public class ObjTimeBallConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct CollisionConfig
    {
        [FieldOffset(0)] public float radius;
        [FieldOffset(4)] public float friction;
        [FieldOffset(8)] public float restitution;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct CorrectionsConfig
    {
        [FieldOffset(0)]  public float CorrectionsMaxDistance;
        [FieldOffset(4)]  public float CorrectionsMinDistance;
        [FieldOffset(8)]  public float CorrectionsAngle;
        [FieldOffset(12)] public float CorrectionsRatio;
    }

    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public struct ObjTimeBallConfig
    {
        [FieldOffset(0)]  public float mass;
        [FieldOffset(4)]  public float linearDamping;
        [FieldOffset(8)]  public float angularDamping;
        [FieldOffset(12)] public float maxLinearVelocity;
        [FieldOffset(16)] public float maxLinearAcceleration;
        [FieldOffset(20)] public float linearVelocityTimes;
        [FieldOffset(24)] public float gravity;
        [FieldOffset(28)] public CollisionConfig collisionConfig;
        [FieldOffset(40)] public CorrectionsConfig correctionsConfig;
    }

}