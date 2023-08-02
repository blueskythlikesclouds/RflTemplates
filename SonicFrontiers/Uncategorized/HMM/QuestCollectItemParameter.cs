Library "QuestCollectItemParameter"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct QuestCollectitemTimerParameter
    {
        [FieldOffset(0)]  public float timeLimitSeconds;
        [FieldOffset(4)]  public float cautionTime;
        [FieldOffset(8)]  public float warningTime;
        [FieldOffset(12)] public bool useCautionAnimation;
        [FieldOffset(13)] public bool useWarningAnimation;
    }

    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public struct QuestCameraParameter
    {
        [FieldOffset(0)]  public float distance;
        [FieldOffset(4)]  public float azimuthSensitivity;
        [FieldOffset(8)]  public float elevationUpSensitivity;
        [FieldOffset(12)] public float elevationDownSensitivity;
        [FieldOffset(16)] public float elevationOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public struct QuestCollectItemParameterElement
    {
        [FieldOffset(0)]  public int applicableFailedCount;
        [FieldOffset(4)]  public int RequestItemNum;
        [FieldOffset(8)]  public QuestCollectitemTimerParameter timerParam;
        [FieldOffset(24)] public QuestCameraParameter cameraParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 132)]
    public struct QuestCollectItemParameter
    {
        [FieldOffset(0)] public unsafe fixed byte /* QuestCollectItemParameterElement[3] */ _element[132];

        public unsafe QuestCollectItemParameterElement* element
        {
            get
            {
                fixed (byte* p_element = _element)
                    return (QuestCollectItemParameterElement*)p_element;
            }
        }
    }

}