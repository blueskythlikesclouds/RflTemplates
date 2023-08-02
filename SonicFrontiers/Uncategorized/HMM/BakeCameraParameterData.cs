Library "BakeCameraParameterData"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct BakeCameraParameterData
    {
        [FieldOffset(0)]  public Vector3 target;
        [FieldOffset(16)] public Vector3 eye;
    }

}