using System.Numerics;
using System.Runtime.InteropServices;

public class ObjBattingMachineConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct GimmickCameraParam
    {
        [FieldOffset(0)]  public float interoplateTimeActivate;
        [FieldOffset(4)]  public float interoplateTimeDeactivate;
        [FieldOffset(16)] public Vector3 targetOffset;
        [FieldOffset(32)] public Vector3 cameraPosOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct ObjBattingMachineConfig
    {
        [FieldOffset(0)] public GimmickCameraParam cameraParam;
    }

}