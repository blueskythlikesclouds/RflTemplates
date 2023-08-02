Library "ObjRotatableStatueConfig"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct GimmickCameraParam
    {
        [FieldOffset(0)]  public float interoplateTimeActivate;
        [FieldOffset(4)]  public float interoplateTimeDeactivate;
        [FieldOffset(16)] public Vector3 targetOffset;
        [FieldOffset(32)] public Vector3 cameraPosOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct ObjRotatableStatueConfig
    {
        [FieldOffset(0)] public GimmickCameraParam cameraParam;
    }

}