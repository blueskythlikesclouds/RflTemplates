Library "QuestDarumaBattleParameter"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct QuestDarumaTimerParameter
    {
        [FieldOffset(0)]  public float timeLimitSeconds;
        [FieldOffset(4)]  public float cautionTime;
        [FieldOffset(8)]  public float warningTime;
        [FieldOffset(12)] public bool useCautionAnimation;
        [FieldOffset(13)] public bool useWarningAnimation;
    }

    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public struct QuestDarumaBattleParameterElement
    {
        [FieldOffset(0)]  public int applicableFailedCount;
        [FieldOffset(4)]  public float collectionColliderRadius;
        [FieldOffset(8)]  public float collectionColliderHeight;
        [FieldOffset(12)] public QuestDarumaTimerParameter timerParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 84)]
    public struct QuestDarumaBattleParameter
    {
        [FieldOffset(0)] public unsafe fixed byte /* QuestDarumaBattleParameterElement[3] */ _element[84];

        public unsafe QuestDarumaBattleParameterElement* element
        {
            get
            {
                fixed (byte* p_element = _element)
                    return (QuestDarumaBattleParameterElement*)p_element;
            }
        }
    }

}