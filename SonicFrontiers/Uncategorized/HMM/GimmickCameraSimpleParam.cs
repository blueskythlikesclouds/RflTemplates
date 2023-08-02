Library "GimmickCameraSimpleParam"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct GimmickCameraSimpleParam
    {
        [FieldOffset(0)]  public Vector3 targetOffset;
        [FieldOffset(16)] public Vector3 cameraPosOffset;
    }

}