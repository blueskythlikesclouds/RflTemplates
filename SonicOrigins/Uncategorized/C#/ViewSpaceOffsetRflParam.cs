using System.Numerics;
using System.Runtime.InteropServices;

public class ViewSpaceOffsetRflParamClass
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct ViewSpaceOffsetRflParam
    {
        [FieldOffset(0)]  public Vector3 targetOffset;
        [FieldOffset(16)] public Vector3 eyeOffset;
    }

}