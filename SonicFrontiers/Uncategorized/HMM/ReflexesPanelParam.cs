Library "ReflexesPanelParam"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct ReflexesPanelCameraParam
    {
        [FieldOffset(0)] public float interoplateTimeActivate;
        [FieldOffset(4)] public float interoplateTimeDeactivate;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct ReflexesPanelPanelParam
    {
        [FieldOffset(0)]  public Vector3 collisionHalfExtents;
        [FieldOffset(16)] public Vector3 collisionOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct ReflexesPanelParam
    {
        [FieldOffset(0)]  public ReflexesPanelCameraParam cameraParam;
        [FieldOffset(16)] public ReflexesPanelPanelParam panelParam;
    }

}