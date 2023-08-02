Library "ObjKodamaEscortParameter"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 144)]
    public struct ObjKodamaEscortParameterElement
    {
        [FieldOffset(0)]   public int applicableFailedCount;
        [FieldOffset(4)]   public float stackingHeight;
        [FieldOffset(8)]   public float blowAwayLengthMin;
        [FieldOffset(12)]  public float blowAwayLengthMax;
        [FieldOffset(16)]  public float blowAwayHeightMin;
        [FieldOffset(20)]  public float blowAwayHeightMax;
        [FieldOffset(24)]  public float modelScale;
        [FieldOffset(28)]  public float modelScaleSticking;
        [FieldOffset(32)]  public float capsuleRadius;
        [FieldOffset(36)]  public float capsuleHeight;
        [FieldOffset(48)]  public Vector3 capsuleOffset;
        [FieldOffset(64)]  public float searchRadius;
        [FieldOffset(68)]  public float rotationAnglePerSec;
        [FieldOffset(72)]  public float verticalJumpSpeedMin;
        [FieldOffset(76)]  public float verticalJumpSpeedMax;
        [FieldOffset(80)]  public float horizontalJumpSpeedMin;
        [FieldOffset(84)]  public float horizontalJumpSpeedMax;
        [FieldOffset(88)]  public float jumpInterval;
        [FieldOffset(92)]  public float contactRadius;
        [FieldOffset(96)]  public float collectTime;
        [FieldOffset(100)] public float splineVelocityY;
        [FieldOffset(104)] public float splineVelocityMultiplier;
        [FieldOffset(108)] public float splineJumpTime;
        [FieldOffset(112)] public float flockRange;
        [FieldOffset(116)] public float spaceHA;
        [FieldOffset(120)] public float maxTiltOfEachKodamaBending;
        [FieldOffset(124)] public float bendingTimeDuringStop;
        [FieldOffset(128)] public float maxTiltOfEachKodamaBendingStop;
        [FieldOffset(132)] public float bendingCycleTimeDuringStay;
        [FieldOffset(136)] public float maxTiltOfEachKodamaBendingStay;
    }

    [StructLayout(LayoutKind.Explicit, Size = 432)]
    public struct ObjKodamaEscortParameter
    {
        [FieldOffset(0)] public unsafe fixed byte /* ObjKodamaEscortParameterElement[3] */ _element[432];

        public unsafe ObjKodamaEscortParameterElement* element
        {
            get
            {
                fixed (byte* p_element = _element)
                    return (ObjKodamaEscortParameterElement*)p_element;
            }
        }
    }

}