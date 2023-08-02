Library "MiniBossTrackerConfig"
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
    public struct MiniBossTrackerCommonParam
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
    public struct MiniBossTrackerLevelParam
    {
        [FieldOffset(0)] public int level;
        [FieldOffset(4)] public MiniBossLevelCommonConfig commonConfig;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct MiniBossTrackerLevelBand
    {
        [FieldOffset(0)] public int level;
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct MiniBossTrackerCameraLockOn
    {
        [FieldOffset(0)]  public float time;
        [FieldOffset(4)]  public float distance;
        [FieldOffset(8)]  public float minElevation;
        [FieldOffset(12)] public float maxElevation;
        [FieldOffset(16)] public float panningSuspensionK;
        [FieldOffset(20)] public float interiorPanningSuspensionK;
    }

    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public struct MiniBossTrackerMoveParam
    {
        [FieldOffset(0)]  public float facingSpeed;
        [FieldOffset(4)]  public float facingSpeed2;
        [FieldOffset(8)]  public float steeringSpeed;
        [FieldOffset(12)] public float chaseSpeed;
        [FieldOffset(16)] public float roundSpeed;
        [FieldOffset(20)] public float changeBaseSpeed;
        [FieldOffset(24)] public float returnSpeed;
        [FieldOffset(28)] public float minSpeed;
        [FieldOffset(32)] public float turnSpeed;
        [FieldOffset(36)] public float accel;
        [FieldOffset(40)] public float brake;
        [FieldOffset(44)] public float brakeDistance;
        [FieldOffset(48)] public float damper;
        [FieldOffset(52)] public float springFactor;
        [FieldOffset(56)] public float verticalWidth;
        [FieldOffset(60)] public float verticalDamper;
        [FieldOffset(64)] public float verticalSpringFactor;
        [FieldOffset(68)] public float verticalRotateSpeed;
        [FieldOffset(72)] public float checkChaseRadius;
        [FieldOffset(76)] public float checkRoundRadius;
        [FieldOffset(80)] public float checkReturnRadius;
        [FieldOffset(84)] public float chaseRadius;
        [FieldOffset(88)] public float chaseHeight;
        [FieldOffset(92)] public float chaseWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct MiniBossTrackerBulletParam
    {
        [FieldOffset(0)]  public float time;
        [FieldOffset(4)]  public float interval;
        [FieldOffset(8)]  public float speed;
        [FieldOffset(12)] public float steeringSpeed;
        [FieldOffset(16)] public float startSteeringTime;
        [FieldOffset(20)] public float life;
    }

    [StructLayout(LayoutKind.Explicit, Size = 52)]
    public struct MiniBossTrackerMineParam
    {
        [FieldOffset(0)]  public int num;
        [FieldOffset(4)]  public int num2;
        [FieldOffset(8)]  public float height;
        [FieldOffset(12)] public float deviationTime;
        [FieldOffset(16)] public float searchRadius;
        [FieldOffset(20)] public float playerRadius;
        [FieldOffset(24)] public float playerHeight;
        [FieldOffset(28)] public float setInterval;
        [FieldOffset(32)] public float life;
        [FieldOffset(36)] public float lifeEx;
        [FieldOffset(40)] public float timer;
        [FieldOffset(44)] public float explosionLife;
        [FieldOffset(48)] public float targetEffectiveDistance;
    }

    [StructLayout(LayoutKind.Explicit, Size = 76)]
    public struct MiniBossTrackerRingHoleParam
    {
        [FieldOffset(0)]  public float minRadius;
        [FieldOffset(4)]  public float maxRadius;
        [FieldOffset(8)]  public float maxDistance;
        [FieldOffset(12)] public float minHeight;
        [FieldOffset(16)] public float maxHeight;
        [FieldOffset(20)] public float deviationTime;
        [FieldOffset(24)] public float maxSpeed;
        [FieldOffset(28)] public float minSpeed;
        [FieldOffset(32)] public float accel;
        [FieldOffset(36)] public float stopTime;
        [FieldOffset(40)] public float damperDistance;
        [FieldOffset(44)] public float damper;
        [FieldOffset(48)] public float chaseRadius;
        [FieldOffset(52)] public float chaseSpeed;
        [FieldOffset(56)] public float disappearTime;
        [FieldOffset(60)] public float life;
        [FieldOffset(64)] public float interval;
        [FieldOffset(68)] public float radius;
        [FieldOffset(72)] public float targetEffectiveDistance;
    }

    public enum ActionType : sbyte
{
        BULLET = 0,
        MINE = 1,
        BASEMINE = 2,
        RINGHOLE = 3,
        LOOP = 4,
        END = 5
    }

    [StructLayout(LayoutKind.Explicit, Size = 104)]
    public struct MiniBossTrackerActionParam
    {
        [FieldOffset(0)]   public unsafe fixed float intervalTable[20];
        [FieldOffset(80)]  public unsafe fixed byte /* ActionType[20] */ _actionTable[20];

        public unsafe ActionType* actionTable
        {
            get
            {
                fixed (byte* p_actionTable = _actionTable)
                    return (ActionType*)p_actionTable;
            }
        }

        [FieldOffset(100)] public int nextPoint;
    }

    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public struct MiniBossTrackerGameParam
    {
        [FieldOffset(0)]  public int hp;
        [FieldOffset(4)]  public float lossRingTime;
        [FieldOffset(8)]  public float pursuitTime;
        [FieldOffset(12)] public int baseDebuffCount;
        [FieldOffset(16)] public int addDebuffCount;
        [FieldOffset(20)] public float cameraDistance;
        [FieldOffset(24)] public float cameraDistance2;
        [FieldOffset(28)] public float cameraMinElevation;
        [FieldOffset(32)] public float cameraMaxElevation;
        [FieldOffset(36)] public float cameraTargetUpOffset;
        [FieldOffset(40)] public float cameraTargetUpOffset2;
    }

    [StructLayout(LayoutKind.Explicit, Size = 1200)]
    public struct MiniBossTrackerConfig
    {
        [FieldOffset(0)]    public MiniBossTrackerCommonParam commonParam;
        [FieldOffset(64)]   public unsafe fixed byte /* MiniBossTrackerLevelParam[5] */ _levelParams[280];

        public unsafe MiniBossTrackerLevelParam* levelParams
        {
            get
            {
                fixed (byte* p_levelParams = _levelParams)
                    return (MiniBossTrackerLevelParam*)p_levelParams;
            }
        }

        [FieldOffset(344)]  public unsafe fixed byte /* MiniBossTrackerLevelBand[5] */ _levelBand[20];

        public unsafe MiniBossTrackerLevelBand* levelBand
        {
            get
            {
                fixed (byte* p_levelBand = _levelBand)
                    return (MiniBossTrackerLevelBand*)p_levelBand;
            }
        }

        [FieldOffset(364)]  public MiniBossTrackerCameraLockOn cameraLockDamage;
        [FieldOffset(388)]  public MiniBossTrackerMoveParam move;
        [FieldOffset(484)]  public MiniBossTrackerBulletParam bullet;
        [FieldOffset(508)]  public MiniBossTrackerMineParam mine;
        [FieldOffset(560)]  public MiniBossTrackerRingHoleParam ringHole;
        [FieldOffset(636)]  public MiniBossTrackerActionParam action1;
        [FieldOffset(740)]  public MiniBossTrackerActionParam action2;
        [FieldOffset(844)]  public MiniBossTrackerActionParam action3;
        [FieldOffset(948)]  public MiniBossTrackerActionParam action4;
        [FieldOffset(1052)] public MiniBossTrackerActionParam action5;
        [FieldOffset(1156)] public MiniBossTrackerGameParam game;
    }

}