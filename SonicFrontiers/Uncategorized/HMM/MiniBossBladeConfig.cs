Library "MiniBossBladeConfig"
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

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct MiniBossBladeCommonAIParam
    {
        [FieldOffset(0)]  public float backRange;
        [FieldOffset(4)]  public float standRange;
        [FieldOffset(8)]  public float shortRange;
        [FieldOffset(12)] public float middleRange;
        [FieldOffset(16)] public float runEndDistance;
        [FieldOffset(20)] public float dashEndDistance;
        [FieldOffset(24)] public float parryRange;
        [FieldOffset(28)] public float specialBeginDisappearTime;
        [FieldOffset(32)] public float specialEndDisappearTime;
        [FieldOffset(36)] public float endWarpWaitTime;
        [FieldOffset(40)] public float shiftTimeMin;
        [FieldOffset(44)] public float shiftTimeMax;
    }

    [StructLayout(LayoutKind.Explicit, Size = 112)]
    public struct MiniBossBladeCommonParam
    {
        [FieldOffset(0)]  public MiniBossCommonConfig commonConfig;
        [FieldOffset(64)] public MiniBossBladeCommonAIParam ai;
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

    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public struct MiniBossBladeLevelCommonParam
    {
        [FieldOffset(0)]  public float angryHpRatio;
        [FieldOffset(4)]  public float stunTime;
        [FieldOffset(8)]  public float downTime;
        [FieldOffset(12)] public float strikeComboTimer;
        [FieldOffset(16)] public float cyloopComboTimer;
        [FieldOffset(20)] public float blowupComboTimer;
        [FieldOffset(24)] public float attackMotionSpeed;
        [FieldOffset(28)] public float preliminaryMotionSpeed;
        [FieldOffset(32)] public float ghostPreliminaryMotionSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 60)]
    public struct MiniBossBladeLevelAIParam
    {
        [FieldOffset(0)]  public float firstContactWait;
        [FieldOffset(4)]  public float specialAttackInterval;
        [FieldOffset(8)]  public float shortRangeIntervalMin;
        [FieldOffset(12)] public float shortRangeIntervalMax;
        [FieldOffset(16)] public float middleRangeIntervalMin;
        [FieldOffset(20)] public float middleRangeIntervalMax;
        [FieldOffset(24)] public float counterIntervalMin;
        [FieldOffset(28)] public float counterIntervalMax;
        [FieldOffset(32)] public float afterDashIntervalMin;
        [FieldOffset(36)] public float afterDashIntervalMax;
        [FieldOffset(40)] public float parryIntervalMin;
        [FieldOffset(44)] public float parryIntervalMax;
        [FieldOffset(48)] public float parryDuration;
        [FieldOffset(52)] public float slashComboCoolTime;
        [FieldOffset(56)] public float ghostDashSlashCoolTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 1)]
    public struct MiniBossBladeSpecialAttackParam
    {
        [FieldOffset(0)] public byte spawnNum;
    }

    [StructLayout(LayoutKind.Explicit, Size = 156)]
    public struct MiniBossBladeLevelParam
    {
        [FieldOffset(0)]   public int level;
        [FieldOffset(4)]   public MiniBossLevelCommonConfig common;
        [FieldOffset(56)]  public MiniBossBladeLevelCommonParam general;
        [FieldOffset(92)]  public MiniBossBladeLevelAIParam ai;
        [FieldOffset(152)] public MiniBossBladeSpecialAttackParam special;
    }

    [StructLayout(LayoutKind.Explicit, Size = 60)]
    public struct MiniBossBladeLevelPhaseAction
    {
        [FieldOffset(0)]  public float verticalSlashRate;
        [FieldOffset(4)]  public float horizontalSlashRate;
        [FieldOffset(8)]  public float slashComboRate;
        [FieldOffset(12)] public float backSlashRate;
        [FieldOffset(16)] public float dashRate;
        [FieldOffset(20)] public float dashSlashRate;
        [FieldOffset(24)] public float ghostDashSlashRate;
        [FieldOffset(28)] public float specialAttackRate;
        [FieldOffset(32)] public bool useTimeStopAttack;
        [FieldOffset(36)] public float guardBeginTime;
        [FieldOffset(40)] public float guardJumpLaserRate;
        [FieldOffset(44)] public float parryJumpLaserRate;
        [FieldOffset(48)] public float cyloopJumpLaserRate;
        [FieldOffset(52)] public float doubleJumpLaserRate;
        [FieldOffset(56)] public bool useParry;
    }

    [StructLayout(LayoutKind.Explicit, Size = 124)]
    public struct MiniBossBladeLevelBand
    {
        [FieldOffset(0)] public uint level;
        [FieldOffset(4)] public unsafe fixed byte /* MiniBossBladeLevelPhaseAction[2] */ _phases[120];

        public unsafe MiniBossBladeLevelPhaseAction* phases
        {
            get
            {
                fixed (byte* p_phases = _phases)
                    return (MiniBossBladeLevelPhaseAction*)p_phases;
            }
        }
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

    [StructLayout(LayoutKind.Explicit, Size = 1552)]
    public struct MiniBossBladeConfig
    {
        [FieldOffset(0)]    public MiniBossBladeCommonParam commonParam;
        [FieldOffset(112)]  public unsafe fixed byte /* MiniBossBladeLevelParam[5] */ _levelParams[780];

        public unsafe MiniBossBladeLevelParam* levelParams
        {
            get
            {
                fixed (byte* p_levelParams = _levelParams)
                    return (MiniBossBladeLevelParam*)p_levelParams;
            }
        }

        [FieldOffset(892)]  public unsafe fixed byte /* MiniBossBladeLevelBand[5] */ _levelBands[620];

        public unsafe MiniBossBladeLevelBand* levelBands
        {
            get
            {
                fixed (byte* p_levelBands = _levelBands)
                    return (MiniBossBladeLevelBand*)p_levelBands;
            }
        }

        [FieldOffset(1512)] public RingParameter ringParam;
    }

}