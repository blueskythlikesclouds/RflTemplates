Library "EnemyBirdConfig"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 112)]
    public struct EnemyBirdCommonParam
    {
        [FieldOffset(0)]   public Vector3 backColliderExtents;
        [FieldOffset(16)]  public Vector3 backColliderOffset;
        [FieldOffset(32)]  public Vector3 backDamageColliderExtents;
        [FieldOffset(48)]  public Vector3 backDamageColliderOffset;
        [FieldOffset(64)]  public Vector3 chargeColliderExtents;
        [FieldOffset(80)]  public Vector3 chargeColliderOffset;
        [FieldOffset(96)]  public float eyesightAngle;
        [FieldOffset(100)] public float eyesightDistance;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct EnemyBirdCommonLevelParam
    {
        [FieldOffset(0)]  public int maxHealthPoint;
        [FieldOffset(4)]  public float attackRate;
        [FieldOffset(8)]  public ushort expItemNum;
        [FieldOffset(10)] public ushort exp;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct EnemyBirdLevelParam
    {
        [FieldOffset(0)] public int level;
        [FieldOffset(4)] public EnemyBirdCommonLevelParam common;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct EnemyBirdLevelBand
    {
        [FieldOffset(0)] public int level;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct BirdWanderParam
    {
        [FieldOffset(0)] public float speedOnPath;
        [FieldOffset(4)] public float speedToPath;
        [FieldOffset(8)] public float eyesightDelayAfterBarAction;
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct BirdApproachParam
    {
        [FieldOffset(0)]  public float speed;
        [FieldOffset(4)]  public float maxSpeed;
        [FieldOffset(8)]  public float acceleration;
        [FieldOffset(12)] public float rotateDegreeToSonic;
        [FieldOffset(16)] public float stopDistanceFromSonic;
        [FieldOffset(32)] public Vector3 offsetFromSonic;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct BirdLaserStateParam
    {
        [FieldOffset(0)] public float laserInterval;
        [FieldOffset(4)] public float rotateDegreeToSonic;
    }

    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public struct BirdChargeParam
    {
        [FieldOffset(0)]  public float waitTime;
        [FieldOffset(4)]  public float speed;
        [FieldOffset(8)]  public float maxSpeed;
        [FieldOffset(12)] public float acceleration;
        [FieldOffset(16)] public Vector3 offsetFromSonic;
        [FieldOffset(32)] public float duration;
        [FieldOffset(36)] public float distance;
        [FieldOffset(40)] public float minElevation;
        [FieldOffset(44)] public float maxElevation;
        [FieldOffset(48)] public float panningSuspensionK;
        [FieldOffset(52)] public float interiorPanningSuspensionK;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct BirdBackupParam
    {
        [FieldOffset(0)]  public float speed;
        [FieldOffset(4)]  public float maxSpeed;
        [FieldOffset(8)]  public float acceleration;
        [FieldOffset(12)] public float backupTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct BirdBarParam
    {
        [FieldOffset(0)]  public float haWaitTime;
        [FieldOffset(4)]  public float degreeOnPath;
        [FieldOffset(8)]  public float speedOnPath;
        [FieldOffset(12)] public float speedToPath;
        [FieldOffset(16)] public float splineTension;
        [FieldOffset(20)] public float splineSpeed;
        [FieldOffset(32)] public Vector3 velocityOnFail;
    }

    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public struct BirdGlidingParam
    {
        [FieldOffset(0)]  public float moveSpeed;
        [FieldOffset(4)]  public float gidingVelocityY;
        [FieldOffset(8)]  public float limitTime;
        [FieldOffset(12)] public float rotateSpeed;
        [FieldOffset(16)] public float rotateSpeedMin;
        [FieldOffset(20)] public float rotateSpeedMax;
        [FieldOffset(24)] public float rotateSpeedMaxSpeedMin;
        [FieldOffset(28)] public float rotateSpeedMinSpeedMax;
        [FieldOffset(32)] public float heightOfChangeShake;
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct BirdDeadParam
    {
        [FieldOffset(0)]  public float minWaitTime;
        [FieldOffset(4)]  public float maxWaitTime;
        [FieldOffset(8)]  public float raycastDistance;
        [FieldOffset(12)] public float fallSpeedOnStomp;
        [FieldOffset(16)] public float maxFallSpeedOnStomp;
        [FieldOffset(20)] public float fallAccelerationOnStomp;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct BirdRaycastParam
    {
        [FieldOffset(0)] public float distanceFront;
        [FieldOffset(4)] public float distanceBack;
        [FieldOffset(8)] public float distanceDown;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct BirdOnBackCameraParam
    {
        [FieldOffset(0)] public float distToConsiderSonicAsOnBird;
        [FieldOffset(4)] public float distance;
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct BirdCameraParam
    {
        [FieldOffset(0)]  public float azimuth;
        [FieldOffset(4)]  public float elevation;
        [FieldOffset(8)]  public float distance;
        [FieldOffset(12)] public float zRoll;
        [FieldOffset(16)] public float fovy;
        [FieldOffset(32)] public Vector3 frameOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 416)]
    public struct EnemyBirdParam
    {
        [FieldOffset(0)]   public Vector3 haColliderExtents;
        [FieldOffset(16)]  public Vector3 haColliderOffset;
        [FieldOffset(32)]  public Vector3 haTargetOffset;
        [FieldOffset(48)]  public float haTargetRadius;
        [FieldOffset(52)]  public float haTargetHeight;
        [FieldOffset(56)]  public BirdWanderParam wanderParam;
        [FieldOffset(80)]  public BirdApproachParam approachParam;
        [FieldOffset(128)] public BirdLaserStateParam laserStateParam;
        [FieldOffset(144)] public BirdChargeParam chargeParam;
        [FieldOffset(208)] public BirdBackupParam backupParam;
        [FieldOffset(224)] public BirdBarParam barParam;
        [FieldOffset(272)] public BirdGlidingParam glidingParam;
        [FieldOffset(308)] public BirdDeadParam deadParam;
        [FieldOffset(332)] public BirdRaycastParam raycastParam;
        [FieldOffset(344)] public bool useCamera;
        [FieldOffset(348)] public BirdOnBackCameraParam onBackCameraParam;
        [FieldOffset(368)] public BirdCameraParam cameraParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 640)]
    public struct EnemyBirdConfig
    {
        [FieldOffset(0)]   public EnemyBirdCommonParam commonParam;
        [FieldOffset(112)] public unsafe fixed byte /* EnemyBirdLevelParam[5] */ _levelParams[80];

        public unsafe EnemyBirdLevelParam* levelParams
        {
            get
            {
                fixed (byte* p_levelParams = _levelParams)
                    return (EnemyBirdLevelParam*)p_levelParams;
            }
        }

        [FieldOffset(192)] public unsafe fixed byte /* EnemyBirdLevelBand[5] */ _levelBand[20];

        public unsafe EnemyBirdLevelBand* levelBand
        {
            get
            {
                fixed (byte* p_levelBand = _levelBand)
                    return (EnemyBirdLevelBand*)p_levelBand;
            }
        }

        [FieldOffset(224)] public EnemyBirdParam birdParam;
    }

}