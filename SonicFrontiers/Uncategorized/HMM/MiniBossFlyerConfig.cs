Library "MiniBossFlyerConfig"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public struct MiniBossCommonConfig
    {
        [FieldOffset(0)]  public float scoutDistance;
        [FieldOffset(4)]  public float scoutDistanceOutside;
        [FieldOffset(8)]  public float zoomDistance;
        [FieldOffset(16)] public Vector3 zoomOffset;
        [FieldOffset(32)] public Vector3 zoomAngle;
        [FieldOffset(48)] public float zoomFov;
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct FlyerTrailParam
    {
        [FieldOffset(0)]  public float interval;
        [FieldOffset(4)]  public int recordNumWander;
        [FieldOffset(8)]  public int recordNumWatch;
        [FieldOffset(12)] public int recordNumBattle;
        [FieldOffset(16)] public float width;
        [FieldOffset(20)] public float wallHeight;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct FlyerWanderParam
    {
        [FieldOffset(0)] public float speed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct FlyerWatchShotParam
    {
        [FieldOffset(0)]  public float interval;
        [FieldOffset(4)]  public float readyDuration;
        [FieldOffset(8)]  public float shotAnimSpeed;
        [FieldOffset(12)] public uint shotAnimNum;
        [FieldOffset(16)] public float speed;
        [FieldOffset(20)] public float lifeTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct FlyerWatchParam
    {
        [FieldOffset(0)] public float speed;
        [FieldOffset(4)] public float changeWanderTime;
        [FieldOffset(8)] public FlyerWatchShotParam shot;
    }

    public enum HorizontalType : sbyte
{
        HorzCenter = 0,
        HorzLeft = 1,
        HorzRight = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 6)]
    public struct FlyerEscapeShotTableData
    {
        [FieldOffset(0)] public unsafe fixed byte /* HorizontalType[6] */ _horz[6];

        public unsafe HorizontalType* horz
        {
            get
            {
                fixed (byte* p_horz = _horz)
                    return (HorizontalType*)p_horz;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 136)]
    public struct FlyerEscapeShotParam
    {
        [FieldOffset(0)]   public unsafe fixed byte /* FlyerEscapeShotTableData[16] */ _posTable[96];

        public unsafe FlyerEscapeShotTableData* posTable
        {
            get
            {
                fixed (byte* p_posTable = _posTable)
                    return (FlyerEscapeShotTableData*)p_posTable;
            }
        }

        [FieldOffset(96)]  public float interval;
        [FieldOffset(100)] public float waitAfterLoop;
        [FieldOffset(104)] public float readyDuration;
        [FieldOffset(108)] public float shotAnimSpeed;
        [FieldOffset(112)] public uint shotAnimNum;
        [FieldOffset(116)] public float initSpeed;
        [FieldOffset(120)] public float maxSpeed;
        [FieldOffset(124)] public float acc;
        [FieldOffset(128)] public float lifeTime;
        [FieldOffset(132)] public float nearest;
    }

    public enum PlayerOffsetType : sbyte
{
        PLAYER_OFFSET_NORMAL = 0,
        PLAYER_OFFSET_ABSOLUTE = 1
    }

    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public struct FlyerEscapeCameraParam
    {
        [FieldOffset(0)]  public float fovy;
        [FieldOffset(4)]  public float zRot;
        [FieldOffset(8)]  public float distance;
        [FieldOffset(12)] public float pathOffset;
        [FieldOffset(16)] public bool usePathVerticalComponent;
        [FieldOffset(17)] public bool usePathNormal;
        [FieldOffset(20)] public float angleSensitivity;
        [FieldOffset(24)] public float angleSensitivityBoost;
        [FieldOffset(28)] public float azimuthOffsetDeg;
        [FieldOffset(32)] public float elevationOffsetDeg;
        [FieldOffset(36)] public float gravityOffset;
        [FieldOffset(48)] public Vector3 playerOffset;
        [FieldOffset(64)] public PlayerOffsetType playerOffsetType;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct FlyerEscapeQuickStepParam
    {
        [FieldOffset(0)]  public bool enable;
        [FieldOffset(4)]  public float speed;
        [FieldOffset(8)]  public float boostSpeed;
        [FieldOffset(12)] public float boostSpeedMax;
    }

    [StructLayout(LayoutKind.Explicit, Size = 256)]
    public struct FlyerEscapeParam
    {
        [FieldOffset(0)]   public float startSpeed;
        [FieldOffset(4)]   public float decrease;
        [FieldOffset(8)]   public float minSpeed;
        [FieldOffset(12)]  public float targetDisableTime;
        [FieldOffset(16)]  public float resetByFallTime;
        [FieldOffset(20)]  public float resetByDistance;
        [FieldOffset(24)]  public FlyerEscapeShotParam shot;
        [FieldOffset(160)] public FlyerEscapeCameraParam camera;
        [FieldOffset(240)] public FlyerEscapeQuickStepParam quickStep;
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct FlyerNearStartCamParam
    {
        [FieldOffset(0)]  public float duration;
        [FieldOffset(16)] public Vector3 posOffset;
        [FieldOffset(32)] public float fovy;
        [FieldOffset(36)] public float interpolateTimePush;
        [FieldOffset(40)] public float interpolateTimePop;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct FlyerIdlingNearParam
    {
        [FieldOffset(0)] public float durationMin;
        [FieldOffset(4)] public float durationMax;
        [FieldOffset(8)] public unsafe fixed uint selectRatio[2];
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct FlyerGuardParam
    {
        [FieldOffset(0)] public float duration;
    }

    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public struct FlyerAutoLockonParam
    {
        [FieldOffset(0)]  public float lockonDistance;
        [FieldOffset(4)]  public float unlockDistance;
        [FieldOffset(8)]  public float distance;
        [FieldOffset(12)] public float minElevation;
        [FieldOffset(16)] public float maxElevation;
        [FieldOffset(20)] public float panningSuspensionK;
        [FieldOffset(24)] public float interiorPanningSuspensionK;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct FlyerNearEndLaunchParam
    {
        [FieldOffset(0)]  public float outStrength;
        [FieldOffset(4)]  public float inStrength;
        [FieldOffset(8)]  public float outElev;
        [FieldOffset(12)] public float inElev;
        [FieldOffset(16)] public float speedMin;
        [FieldOffset(20)] public float speedMax;
        [FieldOffset(24)] public float speedMinLength;
        [FieldOffset(28)] public float speedMaxLength;
    }

    [StructLayout(LayoutKind.Explicit, Size = 160)]
    public struct FlyerNearParam
    {
        [FieldOffset(0)]   public float duration;
        [FieldOffset(4)]   public float startHABounceUp;
        [FieldOffset(8)]   public float startHABounceBack;
        [FieldOffset(12)]  public float preliminaryMotionSpeed;
        [FieldOffset(16)]  public float resetByDistance;
        [FieldOffset(32)]  public FlyerNearStartCamParam startCam;
        [FieldOffset(80)]  public FlyerIdlingNearParam idling;
        [FieldOffset(96)]  public FlyerGuardParam guard;
        [FieldOffset(100)] public FlyerAutoLockonParam lockon;
        [FieldOffset(128)] public FlyerNearEndLaunchParam launch;
    }

    [StructLayout(LayoutKind.Explicit, Size = 560)]
    public struct MiniBossFlyerCommonParam
    {
        [FieldOffset(0)]   public MiniBossCommonConfig commonConfig;
        [FieldOffset(64)]  public FlyerTrailParam trail;
        [FieldOffset(88)]  public FlyerWanderParam wander;
        [FieldOffset(92)]  public FlyerWatchParam watch;
        [FieldOffset(128)] public FlyerEscapeParam escape;
        [FieldOffset(384)] public FlyerNearParam nearRange;
        [FieldOffset(544)] public float stunTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 52)]
    public struct MiniBossLevelCommonConfig
    {
        [FieldOffset(0)]  public int maxHealthPoint;
        [FieldOffset(4)]  public unsafe fixed float maxStunPoint[3];
        [FieldOffset(16)] public float stunDecreaseStartTime;
        [FieldOffset(20)] public float stunDecreaseSpeed;
        [FieldOffset(24)] public unsafe fixed float maxStaggerPoint[3];
        [FieldOffset(36)] public float staggerDecreaseStartTime;
        [FieldOffset(40)] public float staggerDecreaseSpeed;
        [FieldOffset(44)] public float attackRate;
        [FieldOffset(48)] public ushort expItemNum;
        [FieldOffset(50)] public ushort exp;
    }

    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public struct MiniBossFlyerLevelParam
    {
        [FieldOffset(0)] public int level;
        [FieldOffset(4)] public MiniBossLevelCommonConfig commonConfig;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct FlayerEscapeShotSequenceTable
    {
        [FieldOffset(0)] public int id;
        [FieldOffset(4)] public float interval;
    }

    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public struct FlayerEscapeShotSequenceTableData
    {
        [FieldOffset(0)] public bool isUse;
        [FieldOffset(4)] public unsafe fixed byte /* FlayerEscapeShotSequenceTable[8] */ _table[64];

        public unsafe FlayerEscapeShotSequenceTable* table
        {
            get
            {
                fixed (byte* p_table = _table)
                    return (FlayerEscapeShotSequenceTable*)p_table;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 1092)]
    public struct MiniBossFlyerLevelBand
    {
        [FieldOffset(0)] public int level;
        [FieldOffset(4)] public unsafe fixed byte /* FlayerEscapeShotSequenceTableData[16] */ _sequence[1088];

        public unsafe FlayerEscapeShotSequenceTableData* sequence
        {
            get
            {
                fixed (byte* p_sequence = _sequence)
                    return (FlayerEscapeShotSequenceTableData*)p_sequence;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 6304)]
    public struct MiniBossFlyerConfig
    {
        [FieldOffset(0)]   public MiniBossFlyerCommonParam commonParam;
        [FieldOffset(560)] public unsafe fixed byte /* MiniBossFlyerLevelParam[5] */ _levelParams[280];

        public unsafe MiniBossFlyerLevelParam* levelParams
        {
            get
            {
                fixed (byte* p_levelParams = _levelParams)
                    return (MiniBossFlyerLevelParam*)p_levelParams;
            }
        }

        [FieldOffset(840)] public unsafe fixed byte /* MiniBossFlyerLevelBand[5] */ _levelBand[5460];

        public unsafe MiniBossFlyerLevelBand* levelBand
        {
            get
            {
                fixed (byte* p_levelBand = _levelBand)
                    return (MiniBossFlyerLevelBand*)p_levelBand;
            }
        }
    }

}