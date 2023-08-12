Library "FxPlanarProjectionShadowParameter"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 144)]
    public struct FxPlanarProjectionShadowParameter
    {
        [FieldOffset(0)]   public bool enable;
        [FieldOffset(16)]  public Vector4 projectionPlane;
        [FieldOffset(32)]  public unsafe fixed byte /* Vector3[4] */ _lightPosition[64];

        public unsafe Vector3* lightPosition
        {
            get
            {
                fixed (byte* p_lightPosition = _lightPosition)
                    return (Vector3*)p_lightPosition;
            }
        }

        [FieldOffset(96)]  public sbyte lightCount;
        [FieldOffset(100)] public float vanishStart;
        [FieldOffset(104)] public float vanishDistance;
        [FieldOffset(108)] public float projectionBias;
        [FieldOffset(112)] public Vector3 shadowMapBoxSize;
        [FieldOffset(128)] public Vector3 shadowMapBoxOffset;
    }

}