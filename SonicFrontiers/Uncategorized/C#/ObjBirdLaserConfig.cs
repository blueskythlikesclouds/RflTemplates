using System.Numerics;
using System.Runtime.InteropServices;

public class ObjBirdLaserConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct SpeedInfo
    {
        [FieldOffset(0)] public float speed;
        [FieldOffset(4)] public float maxSpeed;
        [FieldOffset(8)] public float acceleration;
    }

    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public struct ObjBirdLaserConfig
    {
        [FieldOffset(0)]  public SpeedInfo speedInfoToSonic;
        [FieldOffset(12)] public SpeedInfo speedInfoToBird;
        [FieldOffset(24)] public float colliderLength;
        [FieldOffset(28)] public float colliderRadius;
        [FieldOffset(32)] public float lifeTime;
        [FieldOffset(48)] public Vector3 laserScale;
    }

}