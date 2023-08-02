Library "MiniBossAshuraConfig"
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

    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public struct MiniBossAshuraCommonParam
    {
        [FieldOffset(0)] public MiniBossCommonConfig commonConfig;
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
    public struct MiniBossAshuraLevelParam
    {
        [FieldOffset(0)] public int level;
        [FieldOffset(4)] public MiniBossLevelCommonConfig commonConfig;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct MiniBossAshuraLevelBand
    {
        [FieldOffset(0)] public int level;
    }

    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public struct MiniBossAshuraObjectCircleLaser
    {
        [FieldOffset(0)]  public float rotationSpeed;
        [FieldOffset(4)]  public float moveRadiusMin;
        [FieldOffset(8)]  public float moveRadiusMax;
        [FieldOffset(12)] public float initKeepTime;
        [FieldOffset(16)] public float scaleUpTime;
        [FieldOffset(20)] public float scaleUpKeepTime;
        [FieldOffset(24)] public float scaleDownTime;
        [FieldOffset(28)] public float scaleDownKeepTime;
        [FieldOffset(32)] public int num;
    }

    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public struct MiniBossAshuraObjectCrawlSpark
    {
        [FieldOffset(0)]  public int createNum;
        [FieldOffset(4)]  public int createParkourNum;
        [FieldOffset(8)]  public float createCycleTime;
        [FieldOffset(12)] public float moveSpeed;
        [FieldOffset(16)] public float lifeTime;
        [FieldOffset(20)] public float homingMaxAngle;
        [FieldOffset(24)] public float homingStartTime;
        [FieldOffset(28)] public float homingPowerMaxTime;
        [FieldOffset(32)] public float meanderingPower;
        [FieldOffset(36)] public float meanderingCycleTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct MiniBossAshuraObjectDashCircleBulletParamByType
    {
        [FieldOffset(0)]  public float ocTime;
        [FieldOffset(4)]  public float dashSpeed;
        [FieldOffset(8)]  public float ocTimeOnGround;
        [FieldOffset(12)] public float dashSpeedOnGround;
    }

    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public struct MiniBossAshuraObjectDashCircleBullet
    {
        [FieldOffset(0)]  public float moveSpeed;
        [FieldOffset(4)]  public float lifeTime;
        [FieldOffset(8)]  public MiniBossAshuraObjectDashCircleBulletParamByType frontType;
        [FieldOffset(24)] public MiniBossAshuraObjectDashCircleBulletParamByType backType;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct MiniBossAshuraObjectSlamWave
    {
        [FieldOffset(0)] public float blowOffRadius;
        [FieldOffset(4)] public float blowOffHeight;
        [FieldOffset(8)] public float killRadius;
    }

    [StructLayout(LayoutKind.Explicit, Size = 128)]
    public struct MiniBossAshuraObjectParam
    {
        [FieldOffset(0)]   public MiniBossAshuraObjectCircleLaser circleLaser;
        [FieldOffset(36)]  public MiniBossAshuraObjectCrawlSpark crawlSpark;
        [FieldOffset(76)]  public MiniBossAshuraObjectDashCircleBullet dashCircleBullet;
        [FieldOffset(116)] public MiniBossAshuraObjectSlamWave slamWave;
    }

    public enum OnArmCircleBulletType : sbyte
{
        CBT_NONE = 0,
        CBT_FRONT = 1,
        CBT_BACK = 2,
        NUM_CBT = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct MiniBossAshuraPhaseOnArmCircleBulletPos
    {
        [FieldOffset(0)]  public OnArmCircleBulletType left;
        [FieldOffset(1)]  public OnArmCircleBulletType center;
        [FieldOffset(2)]  public OnArmCircleBulletType right;
        [FieldOffset(4)]  public float leftOffsetAngle;
        [FieldOffset(8)]  public float centerOffsetAngle;
        [FieldOffset(12)] public float rightOffsetAngle;
    }

    [StructLayout(LayoutKind.Explicit, Size = 160)]
    public struct MiniBossAshuraPhaseParam
    {
        [FieldOffset(0)]   public bool isCircleLaser;
        [FieldOffset(1)]   public bool isCrawlSpark;
        [FieldOffset(2)]   public bool isAttackArmWave;
        [FieldOffset(3)]   public bool isAttackArmCircleBulletOnArm;
        [FieldOffset(4)]   public unsafe fixed byte /* MiniBossAshuraPhaseOnArmCircleBulletPos[8] */ _onArmCircleBullets[128];

        public unsafe MiniBossAshuraPhaseOnArmCircleBulletPos* onArmCircleBullets
        {
            get
            {
                fixed (byte* p_onArmCircleBullets = _onArmCircleBullets)
                    return (MiniBossAshuraPhaseOnArmCircleBulletPos*)p_onArmCircleBullets;
            }
        }

        [FieldOffset(132)] public bool isAttackArmCircleBullet;
        [FieldOffset(136)] public int circleBulletBackTypeFreq;
        [FieldOffset(140)] public int circleBulletCreateNum;
        [FieldOffset(144)] public float circleBulletCreateAngle;
        [FieldOffset(148)] public float circleJumpTargetDistace;
        [FieldOffset(152)] public float circleBulletCreateIntervalTime;
        [FieldOffset(156)] public int armAttackConsecutiveNum;
    }

    [StructLayout(LayoutKind.Explicit, Size = 976)]
    public struct MiniBossAshuraConfig
    {
        [FieldOffset(0)]   public MiniBossAshuraCommonParam commonParam;
        [FieldOffset(64)]  public unsafe fixed byte /* MiniBossAshuraLevelParam[5] */ _levelParams[280];

        public unsafe MiniBossAshuraLevelParam* levelParams
        {
            get
            {
                fixed (byte* p_levelParams = _levelParams)
                    return (MiniBossAshuraLevelParam*)p_levelParams;
            }
        }

        [FieldOffset(344)] public unsafe fixed byte /* MiniBossAshuraLevelBand[5] */ _levelBand[20];

        public unsafe MiniBossAshuraLevelBand* levelBand
        {
            get
            {
                fixed (byte* p_levelBand = _levelBand)
                    return (MiniBossAshuraLevelBand*)p_levelBand;
            }
        }

        [FieldOffset(364)] public MiniBossAshuraObjectParam objectParam;
        [FieldOffset(492)] public unsafe fixed byte /* MiniBossAshuraPhaseParam[3] */ _phaseParam[480];

        public unsafe MiniBossAshuraPhaseParam* phaseParam
        {
            get
            {
                fixed (byte* p_phaseParam = _phaseParam)
                    return (MiniBossAshuraPhaseParam*)p_phaseParam;
            }
        }
    }

}