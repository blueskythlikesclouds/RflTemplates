Library "EnemyJellymanConfig"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct Movement
    {
        [FieldOffset(0)]  public float rotateSpeedMin;
        [FieldOffset(4)]  public float rotateSpeedMax;
        [FieldOffset(8)]  public float rotateSpeedMaxSpeedMin;
        [FieldOffset(12)] public float rotateSpeedMinSpeedMax;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct Eyesight
    {
        [FieldOffset(0)] public float distance;
        [FieldOffset(4)] public float angle;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct Fight
    {
        [FieldOffset(0)] public float attackRange;
        [FieldOffset(4)] public float attackAngle;
        [FieldOffset(8)] public float attackSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public struct EnemyJellymanModeConfig
    {
        [FieldOffset(0)]  public Movement movement;
        [FieldOffset(16)] public Eyesight eyesight;
        [FieldOffset(24)] public Fight fight;
        [FieldOffset(36)] public float transformRate;
    }

    [StructLayout(LayoutKind.Explicit, Size = 60)]
    public struct JellymanHumanCommonConfig
    {
        [FieldOffset(0)]  public EnemyJellymanModeConfig common;
        [FieldOffset(40)] public unsafe fixed float actionDistance[5];
    }

    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public struct RingParameter
    {
        [FieldOffset(0)]  public float suckedTime;
        [FieldOffset(4)]  public float launchAngle;
        [FieldOffset(8)]  public float launchMaxSpeed;
        [FieldOffset(12)] public float launchMinSpeed;
        [FieldOffset(16)] public float randomRangeMin;
        [FieldOffset(20)] public float randomRangeMax;
        [FieldOffset(24)] public float lifeTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct CString
    {
        [FieldOffset(0)] public long pValue;

        public string Value
        {
        	get => Marshal.PtrToStringAnsi((IntPtr)pValue);
        	set => pValue = (long)Marshal.StringToHGlobalAnsi(value);
        }
    }

    public enum VolumeShape : sbyte
{
        SPHERE = 0,
        BOX = 1,
        CYLINDER = 2,
        CAPSULE = 3,
        NUM = 4
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct VolumeInfo
    {
        [FieldOffset(0)]  public Vector3 volumeSize;
        [FieldOffset(16)] public Vector3 volumeOffset;
        [FieldOffset(32)] public Vector3 volumeRotation;
    }

    [StructLayout(LayoutKind.Explicit, Size = 176)]
    public struct MappingPairInfo
    {
        [FieldOffset(0)]   public CString tagName;
        [FieldOffset(16)]  public sbyte pieceNum;
        [FieldOffset(20)]  public float pieceFuncFactor;
        [FieldOffset(24)]  public VolumeShape volumeShape;
        [FieldOffset(32)]  public CString humanNodeName;
        [FieldOffset(48)]  public VolumeInfo humanVolume;
        [FieldOffset(96)]  public CString eggNodeName;
        [FieldOffset(112)] public VolumeInfo eggVolume;
        [FieldOffset(160)] public bool effectActive;
        [FieldOffset(161)] public bool debugDraw;
        [FieldOffset(162)] public bool debugDrawVolumeAxis;
        [FieldOffset(163)] public bool debugDrawAxis;
    }

    [StructLayout(LayoutKind.Explicit, Size = 5744)]
    public struct EnemyCommonConfig
    {
        [FieldOffset(0)]   public JellymanHumanCommonConfig human;
        [FieldOffset(60)]  public RingParameter ringParam;
        [FieldOffset(88)]  public int codeDropNumMin;
        [FieldOffset(92)]  public int codeDropNumMax;
        [FieldOffset(96)]  public int codeXDropNumMin;
        [FieldOffset(100)] public int codeXDropNumMax;
        [FieldOffset(112)] public unsafe fixed byte /* MappingPairInfo[32] */ _mappingPairInfo[5632];

        public unsafe MappingPairInfo* mappingPairInfo
        {
            get
            {
                fixed (byte* p_mappingPairInfo = _mappingPairInfo)
                    return (MappingPairInfo*)p_mappingPairInfo;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 60)]
    public struct JellymanCommonLevelConfig
    {
        [FieldOffset(0)]  public int maxHealthPoint;
        [FieldOffset(4)]  public unsafe fixed float maxStunPoint[3];
        [FieldOffset(16)] public float stunDecreaseStartTime;
        [FieldOffset(20)] public float stunDecreaseSpeed;
        [FieldOffset(24)] public unsafe fixed float maxStaggerPoint[3];
        [FieldOffset(36)] public float staggerDecreaseStartTime;
        [FieldOffset(40)] public float staggerDecreaseSpeed;
        [FieldOffset(44)] public float stunTime;
        [FieldOffset(48)] public float attackRate;
        [FieldOffset(52)] public float attackMotionSpeed;
        [FieldOffset(56)] public ushort expItemNum;
        [FieldOffset(58)] public ushort exp;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct JellymanHumanLevelConfig
    {
        [FieldOffset(0)]  public float wallTime;
        [FieldOffset(4)]  public int wallLife;
        [FieldOffset(8)]  public float guardTime;
        [FieldOffset(12)] public float guardCoolTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public struct EnemyLevelConfig
    {
        [FieldOffset(0)]  public int level;
        [FieldOffset(4)]  public JellymanCommonLevelConfig common;
        [FieldOffset(64)] public JellymanHumanLevelConfig human;
    }

    public enum SuperArmorType : sbyte
{
        None = 0,
        Attack = 1,
        Always = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct JellymanCommonActionConfig
    {
        [FieldOffset(0)] public SuperArmorType superArmor;
        [FieldOffset(1)] public bool isTransform;
        [FieldOffset(4)] public float downTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public struct JellymanHumanActionRate
    {
        [FieldOffset(0)] public unsafe fixed float actionRate[5];
    }

    [StructLayout(LayoutKind.Explicit, Size = 160)]
    public struct JellymanHumanActionConfig
    {
        [FieldOffset(0)]   public unsafe fixed byte /* JellymanHumanActionRate[4] */ _rateTable[80];

        public unsafe JellymanHumanActionRate* rateTable
        {
            get
            {
                fixed (byte* p_rateTable = _rateTable)
                    return (JellymanHumanActionRate*)p_rateTable;
            }
        }

        [FieldOffset(80)]  public unsafe fixed float coolTime[5];
        [FieldOffset(100)] public float attackCoolTime;
        [FieldOffset(104)] public float nearRange;
        [FieldOffset(108)] public int nearRateId;
        [FieldOffset(112)] public int farRateId;
        [FieldOffset(116)] public bool isCounterGuard;
        [FieldOffset(117)] public bool isCounterWall;
        [FieldOffset(118)] public bool isSpikeWall;
        [FieldOffset(120)] public int waveNum;
        [FieldOffset(124)] public float waveUpTime;
        [FieldOffset(128)] public float waveLifeTime;
        [FieldOffset(132)] public float waveDownTime;
        [FieldOffset(136)] public float waveRadius;
        [FieldOffset(140)] public float waveAddRadius;
        [FieldOffset(144)] public float waveSpawnTime;
        [FieldOffset(148)] public float waveKeepRadius;
        [FieldOffset(152)] public float waveHeight;
        [FieldOffset(156)] public int rushNum;
    }

    [StructLayout(LayoutKind.Explicit, Size = 172)]
    public struct EnemyLevelBandConfig
    {
        [FieldOffset(0)]  public int level;
        [FieldOffset(4)]  public JellymanCommonActionConfig common;
        [FieldOffset(12)] public JellymanHumanActionConfig human;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct EnemySquadAvarageLevelConfig
    {
        [FieldOffset(0)]  public int level;
        [FieldOffset(4)]  public int maxActionCount;
        [FieldOffset(8)]  public float spAttackWaitTime;
        [FieldOffset(12)] public unsafe fixed int humanMaxActionCount[5];
    }

    [StructLayout(LayoutKind.Explicit, Size = 160)]
    public struct EnemySquadConfig
    {
        [FieldOffset(0)] public unsafe fixed byte /* EnemySquadAvarageLevelConfig[5] */ _averageLevelConfig[160];

        public unsafe EnemySquadAvarageLevelConfig* averageLevelConfig
        {
            get
            {
                fixed (byte* p_averageLevelConfig = _averageLevelConfig)
                    return (EnemySquadAvarageLevelConfig*)p_averageLevelConfig;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 7408)]
    public struct EnemyJellymanConfig
    {
        [FieldOffset(0)]    public EnemyCommonConfig commonParams;
        [FieldOffset(5744)] public unsafe fixed byte /* EnemyLevelConfig[8] */ _levelParams[640];

        public unsafe EnemyLevelConfig* levelParams
        {
            get
            {
                fixed (byte* p_levelParams = _levelParams)
                    return (EnemyLevelConfig*)p_levelParams;
            }
        }

        [FieldOffset(6384)] public unsafe fixed byte /* EnemyLevelBandConfig[5] */ _levelBands[860];

        public unsafe EnemyLevelBandConfig* levelBands
        {
            get
            {
                fixed (byte* p_levelBands = _levelBands)
                    return (EnemyLevelBandConfig*)p_levelBands;
            }
        }

        [FieldOffset(7244)] public EnemySquadConfig squadParams;
    }

}