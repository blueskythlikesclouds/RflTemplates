Library "IslandParameter"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 2)]
    public struct ChaosEmeraldStorageParam
    {
        [FieldOffset(0)] public bool isEnable;
        [FieldOffset(1)] public sbyte useKeyNum;
    }

    [StructLayout(LayoutKind.Explicit, Size = 14)]
    public struct IslandParam
    {
        [FieldOffset(0)] public unsafe fixed byte /* ChaosEmeraldStorageParam[7] */ _storages[14];

        public unsafe ChaosEmeraldStorageParam* storages
        {
            get
            {
                fixed (byte* p_storages = _storages)
                    return (ChaosEmeraldStorageParam*)p_storages;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct KodamaCommonParam
    {
        [FieldOffset(0)]  public float takableRange;
        [FieldOffset(4)]  public float fadeTime;
        [FieldOffset(8)]  public float chestJumpOutFadeTime;
        [FieldOffset(12)] public float tutorialDelayTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct KodamaFollowParam
    {
        [FieldOffset(0)]  public sbyte maxFollowNum;
        [FieldOffset(4)]  public float speed;
        [FieldOffset(8)]  public float rotateSpeed;
        [FieldOffset(12)] public float stopDistance;
        [FieldOffset(16)] public float vanishDistance;
        [FieldOffset(20)] public float respawnStandTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public struct KodamaNormalParam
    {
        [FieldOffset(0)]  public KodamaCommonParam common;
        [FieldOffset(16)] public KodamaFollowParam follow;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct KodamaElderParam
    {
        [FieldOffset(0)] public unsafe fixed int levelupKodamaNum[3];
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct KodamaHermitLvUpParam
    {
        [FieldOffset(0)] public unsafe fixed int difficulty[3];
    }

    [StructLayout(LayoutKind.Explicit, Size = 1188)]
    public struct KodamaHermitParam
    {
        [FieldOffset(0)] public unsafe fixed byte /* KodamaHermitLvUpParam[99] */ _levelupSeedNum[1188];

        public unsafe KodamaHermitLvUpParam* levelupSeedNum
        {
            get
            {
                fixed (byte* p_levelupSeedNum = _levelupSeedNum)
                    return (KodamaHermitLvUpParam*)p_levelupSeedNum;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public struct KodamaNewFormParam
    {
        [FieldOffset(0)]  public float takableRange;
        [FieldOffset(4)]  public float colliderRange;
        [FieldOffset(8)]  public float fadeTime;
        [FieldOffset(12)] public float spaceVertical;
        [FieldOffset(16)] public float spaceHorizontal;
    }

    [StructLayout(LayoutKind.Explicit, Size = 1400)]
    public struct KodamaParam
    {
        [FieldOffset(0)]    public KodamaNormalParam normal;
        [FieldOffset(40)]   public KodamaElderParam elder;
        [FieldOffset(52)]   public KodamaHermitParam hermit;
        [FieldOffset(1240)] public unsafe fixed byte /* KodamaNewFormParam[8] */ _newform[160];

        public unsafe KodamaNewFormParam* newform
        {
            get
            {
                fixed (byte* p_newform = _newform)
                    return (KodamaNewFormParam*)p_newform;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct NpcParam
    {
        [FieldOffset(0)] public int inputSequenceItemNumShort;
        [FieldOffset(4)] public int inputSequenceItemNumMiddle;
    }

    [StructLayout(LayoutKind.Explicit, Size = 1484)]
    public struct IslandParameter
    {
        [FieldOffset(0)]    public unsafe fixed byte /* IslandParam[5] */ _islands[70];

        public unsafe IslandParam* islands
        {
            get
            {
                fixed (byte* p_islands = _islands)
                    return (IslandParam*)p_islands;
            }
        }

        [FieldOffset(72)]   public KodamaParam kodama;
        [FieldOffset(1472)] public NpcParam npc;
        [FieldOffset(1480)] public int portalExtraKeyNum;
    }

}