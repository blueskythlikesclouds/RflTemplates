Library "ObjShotGunTouchParam"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public struct ObjShotGunTouchTargetParam
    {
        [FieldOffset(0)]  public float targetRadius;
        [FieldOffset(4)]  public float catchDistance;
        [FieldOffset(8)]  public float linearDamping;
        [FieldOffset(12)] public float angularDamping;
        [FieldOffset(16)] public float appearDelay;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct ObjShotGunTouchCameraParam
    {
        [FieldOffset(0)]  public Vector3 cameraOffset;
        [FieldOffset(16)] public float cameraHoldTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public struct ObjShotGunTouchParam
    {
        [FieldOffset(0)]  public ObjShotGunTouchTargetParam targetParam;
        [FieldOffset(32)] public ObjShotGunTouchCameraParam cameraParam;
    }

}