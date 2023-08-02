Library "MiniBossSumoConfig"
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
    public struct MiniBossSumoBaseConfig
    {
        [FieldOffset(0)]  public float mass;
        [FieldOffset(4)]  public float slopeAngleMax;
        [FieldOffset(8)]  public float timeStun;
        [FieldOffset(12)] public float timeExpend;
        [FieldOffset(16)] public float timeGuardBreak;
        [FieldOffset(20)] public float visualOffset;
        [FieldOffset(32)] public Vector3 hpGaugeOffset;
        [FieldOffset(48)] public float guardEffectCoolTime;
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

    public enum ColliderProperty : uint
{
        None = 0,
        Damaged = 1,
        DamageToPlayer = 2,
        Block = 4,
        DetectPuck = 8,
        Cyloop = 16,
        BlockBody = 32,
        SensorArm = 64,
        PressBlow = 128,
        PressBlowBody = 256,
        PressBlowArm = 512
    }

    public struct Color8
    {
        public byte A;
        public byte R;
        public byte G;
        public byte B;
    }

    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public struct MiniBossSumoColliderParam
    {
        [FieldOffset(0)]  public bool enabled;
        [FieldOffset(4)]  public float height;
        [FieldOffset(8)]  public float radius;
        [FieldOffset(16)] public CString attachNodeName;
        [FieldOffset(32)] public Vector3 offset;
        [FieldOffset(48)] public Vector3 rotation;
        [FieldOffset(64)] public CString tag;
        [FieldOffset(80)] public unsafe fixed byte /* ColliderProperty[2] */ _properties[8];

        public unsafe ColliderProperty* properties
        {
            get
            {
                fixed (byte* p_properties = _properties)
                    return (ColliderProperty*)p_properties;
            }
        }

        [FieldOffset(88)] public bool debugDraw;
        [FieldOffset(92)] public Color8 color;
    }

    [StructLayout(LayoutKind.Explicit, Size = 1584)]
    public struct MiniBossSumoColliderConfig
    {
        [FieldOffset(0)]    public unsafe fixed byte /* MiniBossSumoColliderParam[6] */ _damaged[576];

        public unsafe MiniBossSumoColliderParam* damaged
        {
            get
            {
                fixed (byte* p_damaged = _damaged)
                    return (MiniBossSumoColliderParam*)p_damaged;
            }
        }

        [FieldOffset(576)]  public unsafe fixed byte /* MiniBossSumoColliderParam[2] */ _damage[192];

        public unsafe MiniBossSumoColliderParam* damage
        {
            get
            {
                fixed (byte* p_damage = _damage)
                    return (MiniBossSumoColliderParam*)p_damage;
            }
        }

        [FieldOffset(768)]  public MiniBossSumoColliderParam detectPuck;
        [FieldOffset(864)]  public MiniBossSumoColliderParam cyloop;
        [FieldOffset(960)]  public unsafe fixed byte /* MiniBossSumoColliderParam[3] */ _pressBlow[288];

        public unsafe MiniBossSumoColliderParam* pressBlow
        {
            get
            {
                fixed (byte* p_pressBlow = _pressBlow)
                    return (MiniBossSumoColliderParam*)p_pressBlow;
            }
        }

        [FieldOffset(1248)] public unsafe fixed byte /* MiniBossSumoColliderParam[2] */ _sensorArm[192];

        public unsafe MiniBossSumoColliderParam* sensorArm
        {
            get
            {
                fixed (byte* p_sensorArm = _sensorArm)
                    return (MiniBossSumoColliderParam*)p_sensorArm;
            }
        }

        [FieldOffset(1440)] public MiniBossSumoColliderParam simpleBody;
        [FieldOffset(1536)] public float moveRadius;
        [FieldOffset(1540)] public float moveHeight;
        [FieldOffset(1552)] public Vector3 targetMarkerOffset;
        [FieldOffset(1568)] public float comboRadiusMin;
        [FieldOffset(1572)] public float comboRadiusMax;
        [FieldOffset(1576)] public float comboHeight;
    }

    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public struct MiniBossSumoRopeConfig
    {
        [FieldOffset(0)]  public float coolDownTimeToChangeElectric;
        [FieldOffset(4)]  public float timeToWaitChangeAfterDamage;
        [FieldOffset(8)]  public float blowOffSpeedDamagedElectricRope;
        [FieldOffset(12)] public float decelerationDamagedElectricRope;
        [FieldOffset(16)] public float timeElectricReaction;
        [FieldOffset(20)] public unsafe fixed int damageByReflectCount[5];
        [FieldOffset(40)] public float bendLengthOnHit;
        [FieldOffset(44)] public int expansionBoundCount;
        [FieldOffset(48)] public float blowOffSpeedExpansionBoundRope;
        [FieldOffset(52)] public float decelerationExpansionBoundRope;
        [FieldOffset(56)] public float lockonPanningSuspensionKExpansionBoundRope;
        [FieldOffset(60)] public float reflectAngleMaxExpansionBoundRope;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct MiniBossSumoSlingShotConfig
    {
        [FieldOffset(0)]  public unsafe fixed float backInitialSpeeds[5];
        [FieldOffset(20)] public float backDeccelation;
        [FieldOffset(24)] public float frontAngle;
        [FieldOffset(28)] public float timeTurn;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct MiniBossSumoMoveConfig
    {
        [FieldOffset(0)] public float moveHorzLimitAngle;
        [FieldOffset(4)] public float moveRotateDeceleration;
    }

    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public struct MiniBossSumoThrowPuckParam
    {
        [FieldOffset(0)]  public float distanceThrow;
        [FieldOffset(4)]  public float coolTime;
        [FieldOffset(16)] public Vector3 attachOffset;
        [FieldOffset(32)] public Vector3 attachRotateL;
        [FieldOffset(48)] public Vector3 attachRotateR;
        [FieldOffset(64)] public float throwAngleLimit;
        [FieldOffset(80)] public Vector3 throwOffsetMulti;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct MiniBossSumoSlingshotComboParam
    {
        [FieldOffset(0)] public int count;
        [FieldOffset(4)] public bool reflectBack;
        [FieldOffset(8)] public float reflectRagWidth;
    }

    [StructLayout(LayoutKind.Explicit, Size = 160)]
    public struct MiniBossSumoIKFootParam
    {
        [FieldOffset(0)]   public Vector3 kneeAxisLS;
        [FieldOffset(16)]  public Vector3 footEndLS;
        [FieldOffset(32)]  public float footPlantedAnkleHeightMS;
        [FieldOffset(36)]  public float footRaisedAnkleHeightMS;
        [FieldOffset(40)]  public float maxAnkleHeightMS;
        [FieldOffset(44)]  public float minAnkleHeightMS;
        [FieldOffset(48)]  public float maxKneeAngleDegrees;
        [FieldOffset(52)]  public float minKneeAngleDegrees;
        [FieldOffset(56)]  public float onOffGain;
        [FieldOffset(60)]  public float groundAscendingGain;
        [FieldOffset(64)]  public float groundDescendingGain;
        [FieldOffset(68)]  public float footPlantedGain;
        [FieldOffset(72)]  public float footRaisedGain;
        [FieldOffset(76)]  public float footLockingGain;
        [FieldOffset(80)]  public float ankleRotationGain;
        [FieldOffset(88)]  public CString hipName;
        [FieldOffset(104)] public CString kneeName;
        [FieldOffset(120)] public CString ankleName;
        [FieldOffset(136)] public CString toeName;
    }

    [StructLayout(LayoutKind.Explicit, Size = 112)]
    public struct MiniBossSumoIKHandParam
    {
        [FieldOffset(0)]  public Vector3 elbowAxisLS;
        [FieldOffset(16)] public Vector3 handOffsetLS;
        [FieldOffset(32)] public Vector3 backHandNormalLS;
        [FieldOffset(48)] public float maxElbowAngleDegrees;
        [FieldOffset(52)] public float minElbowAngleDegrees;
        [FieldOffset(56)] public bool enforceWristRotation;
        [FieldOffset(64)] public CString shoulderName;
        [FieldOffset(80)] public CString elbowName;
        [FieldOffset(96)] public CString wristName;
    }

    [StructLayout(LayoutKind.Explicit, Size = 592)]
    public struct MiniBossSumoIKParam
    {
        [FieldOffset(0)]   public float footRaycastDistanceUp;
        [FieldOffset(4)]   public float footRaycastDistanceDown;
        [FieldOffset(16)]  public unsafe fixed byte /* MiniBossSumoIKFootParam[2] */ _feet[320];

        public unsafe MiniBossSumoIKFootParam* feet
        {
            get
            {
                fixed (byte* p_feet = _feet)
                    return (MiniBossSumoIKFootParam*)p_feet;
            }
        }

        [FieldOffset(336)] public float handRaycastDistanceUp;
        [FieldOffset(340)] public float handRaycastDistanceDown;
        [FieldOffset(344)] public float handSweepRadius;
        [FieldOffset(348)] public float handGain;
        [FieldOffset(352)] public float easeInTimeHandIk;
        [FieldOffset(356)] public float easeOutTimeHandIk;
        [FieldOffset(368)] public unsafe fixed byte /* MiniBossSumoIKHandParam[2] */ _hands[224];

        public unsafe MiniBossSumoIKHandParam* hands
        {
            get
            {
                fixed (byte* p_hands = _hands)
                    return (MiniBossSumoIKHandParam*)p_hands;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct MiniBossSumoCyloopConfig
    {
        [FieldOffset(0)]  public float puckSpeed;
        [FieldOffset(4)]  public float puckTimeStartDecelerate;
        [FieldOffset(8)]  public float puckDeceleration;
        [FieldOffset(12)] public float puckLifeTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct MiniBossSumoLockonConfig
    {
        [FieldOffset(0)]  public float distance;
        [FieldOffset(4)]  public float minElevation;
        [FieldOffset(8)]  public float maxElevation;
        [FieldOffset(12)] public float elevationOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 2560)]
    public struct MiniBossSumoCommonParam
    {
        [FieldOffset(0)]    public MiniBossCommonConfig common;
        [FieldOffset(64)]   public MiniBossSumoBaseConfig _base;
        [FieldOffset(128)]  public MiniBossSumoColliderConfig collider;
        [FieldOffset(1712)] public MiniBossSumoRopeConfig rope;
        [FieldOffset(1776)] public MiniBossSumoSlingShotConfig slingShot;
        [FieldOffset(1808)] public MiniBossSumoMoveConfig move;
        [FieldOffset(1824)] public MiniBossSumoThrowPuckParam throwPuck;
        [FieldOffset(1920)] public MiniBossSumoSlingshotComboParam combo;
        [FieldOffset(1936)] public MiniBossSumoIKParam ik;
        [FieldOffset(2528)] public MiniBossSumoCyloopConfig cyloop;
        [FieldOffset(2544)] public MiniBossSumoLockonConfig lockon;
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
    public struct MiniBossSumoLevelParam
    {
        [FieldOffset(0)] public int level;
        [FieldOffset(4)] public MiniBossLevelCommonConfig commonConfig;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct MiniBossSumoPuckParam
    {
        [FieldOffset(0)] public int puckCount;
        [FieldOffset(4)] public float speed;
        [FieldOffset(8)] public float lifeTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 9)]
    public struct MiniBossSumoElectricRopePattern
    {
        [FieldOffset(0)] public bool enabled;
        [FieldOffset(1)] public unsafe fixed bool electriced[8];
    }

    [StructLayout(LayoutKind.Explicit, Size = 90)]
    public struct MiniBossSumoRotationElectricRopeParam
    {
        [FieldOffset(0)] public unsafe fixed byte /* MiniBossSumoElectricRopePattern[10] */ _patterns[90];

        public unsafe MiniBossSumoElectricRopePattern* patterns
        {
            get
            {
                fixed (byte* p_patterns = _patterns)
                    return (MiniBossSumoElectricRopePattern*)p_patterns;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 468)]
    public struct MiniBossSumoBehaviorHPRateParam
    {
        [FieldOffset(0)]   public int rateHp;
        [FieldOffset(4)]   public MiniBossSumoPuckParam puck;
        [FieldOffset(16)]  public MiniBossSumoRotationElectricRopeParam rotation8;
        [FieldOffset(106)] public MiniBossSumoRotationElectricRopeParam rotation7;
        [FieldOffset(196)] public MiniBossSumoRotationElectricRopeParam rotation6;
        [FieldOffset(286)] public MiniBossSumoRotationElectricRopeParam rotation5;
        [FieldOffset(376)] public MiniBossSumoRotationElectricRopeParam rotation4;
    }

    [StructLayout(LayoutKind.Explicit, Size = 1408)]
    public struct MiniBossSumoLevelBand
    {
        [FieldOffset(0)] public int level;
        [FieldOffset(4)] public unsafe fixed byte /* MiniBossSumoBehaviorHPRateParam[3] */ _hpRateParams[1404];

        public unsafe MiniBossSumoBehaviorHPRateParam* hpRateParams
        {
            get
            {
                fixed (byte* p_hpRateParams = _hpRateParams)
                    return (MiniBossSumoBehaviorHPRateParam*)p_hpRateParams;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 9888)]
    public struct MiniBossSumoConfig
    {
        [FieldOffset(0)]    public MiniBossSumoCommonParam commonParam;
        [FieldOffset(2560)] public unsafe fixed byte /* MiniBossSumoLevelParam[5] */ _levelParams[280];

        public unsafe MiniBossSumoLevelParam* levelParams
        {
            get
            {
                fixed (byte* p_levelParams = _levelParams)
                    return (MiniBossSumoLevelParam*)p_levelParams;
            }
        }

        [FieldOffset(2840)] public unsafe fixed byte /* MiniBossSumoLevelBand[5] */ _levelBand[7040];

        public unsafe MiniBossSumoLevelBand* levelBand
        {
            get
            {
                fixed (byte* p_levelBand = _levelBand)
                    return (MiniBossSumoLevelBand*)p_levelBand;
            }
        }
    }

}