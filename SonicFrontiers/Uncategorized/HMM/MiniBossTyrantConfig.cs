Library "MiniBossTyrantConfig"
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

    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public struct MiniBossTyrantCommonParam
    {
        [FieldOffset(0)]  public MiniBossCommonConfig commonConfig;
        [FieldOffset(64)] public float nonBattleRange;
        [FieldOffset(68)] public float miniDamageRange;
        [FieldOffset(72)] public float miniComboRange;
        [FieldOffset(76)] public float miniOffsetY;
        [FieldOffset(80)] public float bodyDamageRange;
        [FieldOffset(84)] public float bodyComboRange;
        [FieldOffset(88)] public float bodyOffsetY;
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
    public struct MiniBossTyrantLevelParam
    {
        [FieldOffset(0)] public int level;
        [FieldOffset(4)] public MiniBossLevelCommonConfig commonConfig;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct MiniBossTyrantLevelBand
    {
        [FieldOffset(0)] public int level;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct MiniBossTyrantAttackSpinParam
    {
        [FieldOffset(0)]  public float speed;
        [FieldOffset(4)]  public float time;
        [FieldOffset(8)]  public float waitTime;
        [FieldOffset(12)] public float rotSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct MiniBossTyrantAttackAirSpinParam
    {
        [FieldOffset(0)] public float speed;
        [FieldOffset(4)] public int attackNum;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct MiniBossTyrantAttackRouletteParam
    {
        [FieldOffset(0)] public float time;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct MiniBossTyrantAttackLaserParam
    {
        [FieldOffset(0)]  public Vector3 muzzlePosOffset;
        [FieldOffset(16)] public float time;
        [FieldOffset(20)] public float rotSpeed;
        [FieldOffset(24)] public float waitTime;
    }

    public enum BarrageType : sbyte
{
        TYPE_AIM_PLAYER = 0,
        TYPE_NO_AIM = 1
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

    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public struct MiniBossTyrantBarrageParam
    {
        [FieldOffset(0)]  public BarrageType type;
        [FieldOffset(8)]  public CString damageTag;
        [FieldOffset(24)] public float startSpeed;
        [FieldOffset(28)] public float decelePower;
        [FieldOffset(32)] public float minSpeed;
        [FieldOffset(36)] public float lifeTime;
        [FieldOffset(40)] public float waitTime;
        [FieldOffset(44)] public float lineTime;
        [FieldOffset(48)] public float scale;
        [FieldOffset(52)] public float hitVelocity;
        [FieldOffset(56)] public float parriedSpeed;
        [FieldOffset(60)] public int parriedDamage;
        [FieldOffset(64)] public float parriedStaggerValue;
        [FieldOffset(68)] public float parriedStunValue;
    }

    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public struct MiniBossTyrantShotgunBullet
    {
        [FieldOffset(0)]  public int barrageIndex;
        [FieldOffset(4)]  public float yOffset;
        [FieldOffset(8)]  public float zOffset;
        [FieldOffset(12)] public bool isFollowPlayer;
        [FieldOffset(16)] public float shotIntarval;
        [FieldOffset(20)] public float maxAngle;
        [FieldOffset(24)] public float yAngleOffset;
        [FieldOffset(28)] public float shotTime;
        [FieldOffset(32)] public float addSpeedMax;
        [FieldOffset(36)] public float startWaitTime;
        [FieldOffset(40)] public float endWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public struct MiniBossTyrantWinderBullet
    {
        [FieldOffset(0)]  public int barrageIndex;
        [FieldOffset(4)]  public float yOffset;
        [FieldOffset(8)]  public float zOffset;
        [FieldOffset(12)] public bool isFollowPlayer;
        [FieldOffset(16)] public float shotIntarval;
        [FieldOffset(20)] public float maxAngle;
        [FieldOffset(24)] public float rotateSpeed;
        [FieldOffset(28)] public float rotateAngle;
        [FieldOffset(32)] public float barrageAngleDiff;
        [FieldOffset(36)] public float startWaitTime;
        [FieldOffset(40)] public float endWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct MiniBossTyrantLineBullet
    {
        [FieldOffset(0)]  public int barrageIndex;
        [FieldOffset(4)]  public float yOffset;
        [FieldOffset(8)]  public float zOffset;
        [FieldOffset(12)] public int num;
        [FieldOffset(16)] public float waitTime;
        [FieldOffset(20)] public bool isFollowPlayer;
        [FieldOffset(24)] public float startWaitTime;
        [FieldOffset(28)] public float endWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public struct MiniBossTyrantWaveBullet
    {
        [FieldOffset(0)]  public int barrageIndex;
        [FieldOffset(4)]  public float yOffset;
        [FieldOffset(8)]  public float zOffset;
        [FieldOffset(12)] public bool isFollowPlayer;
        [FieldOffset(16)] public float waitTime;
        [FieldOffset(20)] public float sideAngle;
        [FieldOffset(24)] public int arrayNum;
        [FieldOffset(28)] public float arrayTime;
        [FieldOffset(32)] public float startWaitTime;
        [FieldOffset(36)] public float endWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public struct MiniBossTyrantAttackCircleBullet
    {
        [FieldOffset(0)]  public int barrageIndex;
        [FieldOffset(4)]  public float yOffset;
        [FieldOffset(8)]  public float zOffset;
        [FieldOffset(12)] public int num;
        [FieldOffset(16)] public float speed;
        [FieldOffset(20)] public float rotSpeed;
        [FieldOffset(24)] public int arrayNum;
        [FieldOffset(28)] public float arrayTime;
        [FieldOffset(32)] public float startWaitTime;
        [FieldOffset(36)] public float endWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct MiniBossTyrantSequenceParameter
    {
        [FieldOffset(0)]  public float airBattleRate;
        [FieldOffset(4)]  public float nextRoundRate;
        [FieldOffset(8)]  public float airBattleRateSecond;
        [FieldOffset(12)] public float chanceTime;
        [FieldOffset(16)] public float chanceTimeSecond;
        [FieldOffset(20)] public bool isSpin;
        [FieldOffset(21)] public bool isSecondAttack;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct MiniBossTyrantCyloopDamageParameter
    {
        [FieldOffset(0)]  public float upPower;
        [FieldOffset(4)]  public float upTime;
        [FieldOffset(8)]  public float attackTime;
        [FieldOffset(12)] public float downPower;
    }

    public enum ActionType : sbyte
{
        ACTION_TYPE_NONE = 0,
        ACTION_TYPE_SPIN = 1,
        ACTION_TYPE_ROULETTE = 2,
        ACTION_TYPE_LASER = 3,
        ACTION_TYPE_SHOTGUN = 4,
        ACTION_TYPE_WINDER = 5,
        ACTION_TYPE_LINE = 6,
        ACTION_TYPE_WAVE = 7,
        ACTION_TYPE_CIRCLE = 8
    }

    [StructLayout(LayoutKind.Explicit, Size = 1488)]
    public struct MiniBossTyrantAttackParam
    {
        [FieldOffset(0)]    public MiniBossTyrantAttackSpinParam spin;
        [FieldOffset(16)]   public MiniBossTyrantAttackAirSpinParam airSpin;
        [FieldOffset(24)]   public MiniBossTyrantAttackRouletteParam roulette;
        [FieldOffset(32)]   public MiniBossTyrantAttackLaserParam laser;
        [FieldOffset(64)]   public float rotSpeed;
        [FieldOffset(72)]   public unsafe fixed byte /* MiniBossTyrantBarrageParam[16] */ _barrage[1152];

        public unsafe MiniBossTyrantBarrageParam* barrage
        {
            get
            {
                fixed (byte* p_barrage = _barrage)
                    return (MiniBossTyrantBarrageParam*)p_barrage;
            }
        }

        [FieldOffset(1224)] public MiniBossTyrantShotgunBullet shotgunBullet;
        [FieldOffset(1268)] public MiniBossTyrantWinderBullet winderBullet;
        [FieldOffset(1312)] public MiniBossTyrantLineBullet lineBullet;
        [FieldOffset(1344)] public MiniBossTyrantWaveBullet waveBullet;
        [FieldOffset(1384)] public MiniBossTyrantAttackCircleBullet circleBullet;
        [FieldOffset(1424)] public MiniBossTyrantSequenceParameter sequenceParam;
        [FieldOffset(1448)] public MiniBossTyrantCyloopDamageParameter cyloopParam;
        [FieldOffset(1464)] public unsafe fixed byte /* ActionType[10] */ _actionListGround[10];

        public unsafe ActionType* actionListGround
        {
            get
            {
                fixed (byte* p_actionListGround = _actionListGround)
                    return (ActionType*)p_actionListGround;
            }
        }

        [FieldOffset(1474)] public unsafe fixed byte /* ActionType[10] */ _actionListAir[10];

        public unsafe ActionType* actionListAir
        {
            get
            {
                fixed (byte* p_actionListAir = _actionListAir)
                    return (ActionType*)p_actionListAir;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public struct MiniBossTyrantDebrisParam
    {
        [FieldOffset(0)]  public float speed;
        [FieldOffset(4)]  public float accel;
        [FieldOffset(8)]  public float rotate_speed_min;
        [FieldOffset(12)] public float rotate_speed_max;
        [FieldOffset(16)] public float rotate_speed_fast;
        [FieldOffset(20)] public float rotate_accel;
        [FieldOffset(24)] public float life;
        [FieldOffset(28)] public float spawn_offset;
        [FieldOffset(32)] public float spawn_interval;
        [FieldOffset(36)] public int spawn_num;
    }

    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public struct MiniBossTyrantStormEffectParam
    {
        [FieldOffset(0)] public MiniBossTyrantDebrisParam debris;
    }

    [StructLayout(LayoutKind.Explicit, Size = 1936)]
    public struct MiniBossTyrantConfig
    {
        [FieldOffset(0)]    public MiniBossTyrantCommonParam commonParam;
        [FieldOffset(96)]   public unsafe fixed byte /* MiniBossTyrantLevelParam[5] */ _levelParams[280];

        public unsafe MiniBossTyrantLevelParam* levelParams
        {
            get
            {
                fixed (byte* p_levelParams = _levelParams)
                    return (MiniBossTyrantLevelParam*)p_levelParams;
            }
        }

        [FieldOffset(376)]  public unsafe fixed byte /* MiniBossTyrantLevelBand[5] */ _levelBand[20];

        public unsafe MiniBossTyrantLevelBand* levelBand
        {
            get
            {
                fixed (byte* p_levelBand = _levelBand)
                    return (MiniBossTyrantLevelBand*)p_levelBand;
            }
        }

        [FieldOffset(400)]  public MiniBossTyrantAttackParam attackParam;
        [FieldOffset(1888)] public MiniBossTyrantStormEffectParam stormEffectParam;
    }

}