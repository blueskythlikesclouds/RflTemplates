using System.Numerics;
using System.Runtime.InteropServices;

public class EnemyEggRoboConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 112)]
    public struct EnemyEggRoboConfig
    {
        [FieldOffset(0)]  public float scaleSv;
        [FieldOffset(4)]  public float scaleFv;
        [FieldOffset(8)]  public float appearEffTimer;
        [FieldOffset(12)] public float colliderRadius;
        [FieldOffset(16)] public float colliderHeight;
        [FieldOffset(32)] public Vector3 colliderOffset;
        [FieldOffset(48)] public float laserColliderRadius;
        [FieldOffset(52)] public float laserColliderHeight;
        [FieldOffset(64)] public Vector3 laserColliderSizeSV;
        [FieldOffset(80)] public float missileColliderRadius;
        [FieldOffset(84)] public float missileColliderHeight;
        [FieldOffset(96)] public Vector3 missileColliderOffset;
    }

}