Library "ObjMowingParameter"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct ObjMowingGrassParameter
    {
        [FieldOffset(0)] public float radius;
    }

    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public struct ObjBeeFlowerParameter
    {
        [FieldOffset(0)]  public float modelScale;
        [FieldOffset(4)]  public float capsuleRadiusSprouts;
        [FieldOffset(8)]  public float capsuleRadiusFlower;
        [FieldOffset(12)] public float capsuleHeightSprouts;
        [FieldOffset(16)] public float capsuleHeightFlower;
        [FieldOffset(32)] public Vector3 effectOffsetSprouts;
        [FieldOffset(48)] public Vector3 effectOffsetFlower;
        [FieldOffset(64)] public float beeAttractDist;
        [FieldOffset(68)] public float efficacyTimeFlower;
    }

    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public struct ObjBeeSwarmParameter
    {
        [FieldOffset(0)]  public Vector3 targetOffset;
        [FieldOffset(16)] public Vector3 targetOffsetFlower;
        [FieldOffset(32)] public float collRadius;
        [FieldOffset(36)] public float modelScale;
        [FieldOffset(40)] public float beeMoveSpeed;
        [FieldOffset(44)] public float reflectionAngle;
        [FieldOffset(48)] public float coefAverage;
        [FieldOffset(52)] public float coefCenter;
        [FieldOffset(56)] public float coefRepulse;
        [FieldOffset(60)] public float waitTimeAfterAttack;
        [FieldOffset(64)] public float waitTimeAfterFlower;
    }

    [StructLayout(LayoutKind.Explicit, Size = 176)]
    public struct ObjMowingParameterElement
    {
        [FieldOffset(0)]  public ObjMowingGrassParameter grassParam;
        [FieldOffset(16)] public ObjBeeFlowerParameter beeFlowerParam;
        [FieldOffset(96)] public ObjBeeSwarmParameter beeSwarm;
    }

    [StructLayout(LayoutKind.Explicit, Size = 528)]
    public struct ObjMowingParameter
    {
        [FieldOffset(0)] public unsafe fixed byte /* ObjMowingParameterElement[3] */ _element[528];

        public unsafe ObjMowingParameterElement* element
        {
            get
            {
                fixed (byte* p_element = _element)
                    return (ObjMowingParameterElement*)p_element;
            }
        }
    }

}