Library "ObjKodamaQuestParameter"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct QuestKodamaCollectionBaseParameter
    {
        [FieldOffset(0)]  public int clearKodamaNum;
        [FieldOffset(4)]  public float modelScale;
        [FieldOffset(8)]  public float capsuleRadius;
        [FieldOffset(12)] public float capsuleHeight;
        [FieldOffset(16)] public Vector3 capsuleOffset;
        [FieldOffset(32)] public float searchRadius;
        [FieldOffset(36)] public float collectTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public struct QuestKodamaCollectionMoveParameter
    {
        [FieldOffset(0)]  public float rotationAnglePerSec;
        [FieldOffset(4)]  public float moveSpeed;
        [FieldOffset(8)]  public float moveStopSpeed;
        [FieldOffset(12)] public float moveStopeTime;
        [FieldOffset(16)] public float groupRadius;
        [FieldOffset(20)] public float groupMoveAdjustRangeOffset;
        [FieldOffset(24)] public float groupLeaderFixTime;
        [FieldOffset(28)] public float returnToCenterDistance;
        [FieldOffset(32)] public float returnToCenterRotationAngle;
    }

    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public struct QuestKodamaCollectionBombParameter
    {
        [FieldOffset(0)]  public float bombSpawnTrialTime;
        [FieldOffset(4)]  public ushort numKodamasNeededForBombSpawnRate2;
        [FieldOffset(6)]  public ushort numKodamasNeededForBombSpawnRate3;
        [FieldOffset(8)]  public float bombSpawnRate1;
        [FieldOffset(12)] public float bombSpawnRate2;
        [FieldOffset(16)] public float bombSpawnRate3;
        [FieldOffset(20)] public byte maxAliveBombNum;
        [FieldOffset(24)] public float bombSpawnRange;
    }

    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public struct QuestKodamaCollectionTimerParameter
    {
        [FieldOffset(0)]  public bool isTimeUp;
        [FieldOffset(4)]  public float timeLimitSeconds;
        [FieldOffset(8)]  public float cautionTime;
        [FieldOffset(12)] public float warningTime;
        [FieldOffset(16)] public bool useCautionAnimation;
        [FieldOffset(17)] public bool useWarningAnimation;
    }

    [StructLayout(LayoutKind.Explicit, Size = 160)]
    public struct ObjKodamaQuestGrassIslandParameter
    {
        [FieldOffset(0)]   public int applicableFailedCount;
        [FieldOffset(16)]  public QuestKodamaCollectionBaseParameter baseParam;
        [FieldOffset(64)]  public QuestKodamaCollectionMoveParameter moveParam;
        [FieldOffset(100)] public QuestKodamaCollectionBombParameter bombParam;
        [FieldOffset(128)] public QuestKodamaCollectionTimerParameter timerParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public struct QuestKodamaCollectionSandBombParameter
    {
        [FieldOffset(0)]  public QuestKodamaCollectionBombParameter questKodamaCollectionBombParameter;
        [FieldOffset(28)] public float sandStormTime;
        [FieldOffset(32)] public float noBombsTime;
        [FieldOffset(36)] public float sandStormInLerpTime;
        [FieldOffset(40)] public float sandStormOutLerpTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 176)]
    public struct ObjKodamaQuestDesertIslandParameter
    {
        [FieldOffset(0)]   public int applicableFailedCount;
        [FieldOffset(16)]  public QuestKodamaCollectionBaseParameter baseParam;
        [FieldOffset(64)]  public QuestKodamaCollectionMoveParameter moveParam;
        [FieldOffset(100)] public QuestKodamaCollectionSandBombParameter bombParam;
        [FieldOffset(144)] public QuestKodamaCollectionTimerParameter timerParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 1008)]
    public struct ObjKodamaQuestParameter
    {
        [FieldOffset(0)]   public unsafe fixed byte /* ObjKodamaQuestGrassIslandParameter[3] */ _grassIslandParam[480];

        public unsafe ObjKodamaQuestGrassIslandParameter* grassIslandParam
        {
            get
            {
                fixed (byte* p_grassIslandParam = _grassIslandParam)
                    return (ObjKodamaQuestGrassIslandParameter*)p_grassIslandParam;
            }
        }

        [FieldOffset(480)] public unsafe fixed byte /* ObjKodamaQuestDesertIslandParameter[3] */ _desertIslandParam[528];

        public unsafe ObjKodamaQuestDesertIslandParameter* desertIslandParam
        {
            get
            {
                fixed (byte* p_desertIslandParam = _desertIslandParam)
                    return (ObjKodamaQuestDesertIslandParameter*)p_desertIslandParam;
            }
        }
    }

}