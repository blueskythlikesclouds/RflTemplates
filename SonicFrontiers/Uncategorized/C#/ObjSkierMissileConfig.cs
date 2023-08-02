using System.Numerics;
using System.Runtime.InteropServices;

public class ObjSkierMissileConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct ObjSkierMissileConfig
    {
        [FieldOffset(0)]  public float colliderHeight;
        [FieldOffset(4)]  public float colliderRadius;
        [FieldOffset(16)] public Vector3 colliderOffset;
        [FieldOffset(32)] public float explodeRadius;
        [FieldOffset(36)] public float distanceStartCurve;
        [FieldOffset(40)] public float distanceEndCurve;
        [FieldOffset(44)] public float inducedExplosionTimePerDistance;
    }

}