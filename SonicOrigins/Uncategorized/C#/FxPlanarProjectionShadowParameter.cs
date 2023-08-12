using System.Numerics;
using System.Runtime.InteropServices;

public class FxPlanarProjectionShadowParameterClass
{
    [StructLayout(LayoutKind.Explicit, Size = 144)]
    public struct FxPlanarProjectionShadowParameter
    {
        [FieldOffset(0)]   public bool enable;
        [FieldOffset(16)]  public Vector4 projectionPlane;
        [FieldOffset(32)]  public Vector3 lightPosition__arr0;
        [FieldOffset(48)] public Vector3 lightPosition__arr1;
        [FieldOffset(64)] public Vector3 lightPosition__arr2;
        [FieldOffset(80)] public Vector3 lightPosition__arr3;
        [FieldOffset(96)]  public sbyte lightCount;
        [FieldOffset(100)] public float vanishStart;
        [FieldOffset(104)] public float vanishDistance;
        [FieldOffset(108)] public float projectionBias;
        [FieldOffset(112)] public Vector3 shadowMapBoxSize;
        [FieldOffset(128)] public Vector3 shadowMapBoxOffset;
    }

}