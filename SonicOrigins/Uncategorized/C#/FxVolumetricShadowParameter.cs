using System.Numerics;
using System.Runtime.InteropServices;

public class FxVolumetricShadowParameterClass
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct FxVolumetricShadowParameter
    {
        [FieldOffset(0)] public bool enable;
        [FieldOffset(1)] public bool isUseShadowmap;
        [FieldOffset(2)] public bool isUseCloudShadow;
        [FieldOffset(3)] public bool isUseHeightmapShadow;
    }

}