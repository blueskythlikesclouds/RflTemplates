Library "QuestMowingParameter"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct QuestMowingPlayerParameter
    {
        [FieldOffset(0)] public float playerBoostRatio;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct QuestMowingPointParameter
    {
        [FieldOffset(0)] public uint collisionNum;
        [FieldOffset(4)] public uint pointLine;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct QuestMowingTimerParameter
    {
        [FieldOffset(0)]  public float timeLimitSeconds;
        [FieldOffset(4)]  public float cautionTime;
        [FieldOffset(8)]  public float warningTime;
        [FieldOffset(12)] public bool useCautionAnimation;
        [FieldOffset(13)] public bool useWarningAnimation;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct QuestMowingEarnedScoreParameter
    {
        [FieldOffset(0)]  public float visibleSize;
        [FieldOffset(4)]  public float visibleTime;
        [FieldOffset(16)] public Vector3 viewOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct QuestMowingResultCameraParameter
    {
        [FieldOffset(0)] public float resultCameraEaseTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 128)]
    public struct QuestMowingParameterElement
    {
        [FieldOffset(0)]   public int applicableFailedCount;
        [FieldOffset(4)]   public uint questClearPoint;
        [FieldOffset(8)]   public QuestMowingPlayerParameter playerParam;
        [FieldOffset(12)]  public uint pointParamNum;
        [FieldOffset(16)]  public unsafe fixed byte /* QuestMowingPointParameter[5] */ _pointParam[40];

        public unsafe QuestMowingPointParameter* pointParam
        {
            get
            {
                fixed (byte* p_pointParam = _pointParam)
                    return (QuestMowingPointParameter*)p_pointParam;
            }
        }

        [FieldOffset(56)]  public QuestMowingTimerParameter timerParam;
        [FieldOffset(80)]  public QuestMowingEarnedScoreParameter scoreUIParam;
        [FieldOffset(112)] public QuestMowingResultCameraParameter resultCameraParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 384)]
    public struct QuestMowingParameter
    {
        [FieldOffset(0)] public unsafe fixed byte /* QuestMowingParameterElement[3] */ _element[384];

        public unsafe QuestMowingParameterElement* element
        {
            get
            {
                fixed (byte* p_element = _element)
                    return (QuestMowingParameterElement*)p_element;
            }
        }
    }

}