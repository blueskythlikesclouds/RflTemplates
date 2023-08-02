Library "BossKnightConfig"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    public struct CSetObjectID
    {
        public unsafe fixed byte GUID[16];
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct CSetObjectIDArray
    {
        [FieldOffset(0)] public ulong pData;
        [FieldOffset(8)] public ulong Size;
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

    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public struct PlayerMoveableRangeParam
    {
        [FieldOffset(0)]  public CSetObjectIDArray initPositions;
        [FieldOffset(32)] public CString heightTargetNodeName;
        [FieldOffset(48)] public float heightMoveSpeed;
        [FieldOffset(52)] public float bossToPlayerDistanceMin;
        [FieldOffset(56)] public float bossToPlayerDistanceMax;
        [FieldOffset(60)] public float offsetHeightMin;
        [FieldOffset(64)] public float offsetHeightMax;
        [FieldOffset(68)] public float areaDistanceMin;
        [FieldOffset(72)] public float areaDistanceMax;
        [FieldOffset(76)] public float playerSpawnDistance;
        [FieldOffset(80)] public float playerRespawnDistance;
        [FieldOffset(84)] public float playerRespawnDistance2;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct BossPhaseParam
    {
        [FieldOffset(0)] public bool isUse;
        [FieldOffset(1)] public bool isUsePillar;
        [FieldOffset(4)] public float phaseChangeHpRatio;
    }

    public enum EaseType : sbyte
{
        ET_Sin = 0,
        ET_Cubic = 1,
        ET_Quadratic = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 112)]
    public struct BossLockOnCameraParam
    {
        [FieldOffset(0)]  public float easeTime;
        [FieldOffset(4)]  public EaseType easeType;
        [FieldOffset(8)]  public CString mainLookAtNodeName;
        [FieldOffset(32)] public Vector3 mainLookOffsetPos;
        [FieldOffset(48)] public CString subLookAtNodeName;
        [FieldOffset(64)] public Vector3 subLookOffsetPos;
        [FieldOffset(80)] public float distance;
        [FieldOffset(96)] public Vector3 playerOffsetPos;
    }

    [StructLayout(LayoutKind.Explicit, Size = 416)]
    public struct BossStatusConfig
    {
        [FieldOffset(0)]   public uint healthPoint;
        [FieldOffset(4)]   public float stunTime;
        [FieldOffset(8)]   public unsafe fixed float maxStunPoint[3];
        [FieldOffset(20)]  public unsafe fixed float maxStaggerPoint[5];
        [FieldOffset(40)]  public ushort exp;
        [FieldOffset(48)]  public PlayerMoveableRangeParam moveRangeParam;
        [FieldOffset(136)] public PlayerMoveableRangeParam cyloopDamageMoveRangeParam;
        [FieldOffset(224)] public unsafe fixed byte /* BossPhaseParam[8] */ _phaseParams[64];

        public unsafe BossPhaseParam* phaseParams
        {
            get
            {
                fixed (byte* p_phaseParams = _phaseParams)
                    return (BossPhaseParam*)p_phaseParams;
            }
        }

        [FieldOffset(288)] public BossLockOnCameraParam cameraParam;
        [FieldOffset(400)] public bool isDebugDraw;
        [FieldOffset(404)] public uint debugDrawPhaseIndex;
    }

    public enum GimmickType : sbyte
{
        GT_A = 0,
        GT_B = 1,
        GT_C = 2,
        GT_D = 3,
        GT_E = 4,
        NUM_GIMMICK_TYPE = 5
    }

    public enum AttackType : sbyte
{
        AT_A = 0,
        AT_B = 1,
        AT_C = 2,
        AT_D = 3,
        AT_E = 4,
        NUM_ATTACK_TYPE = 5
    }

    public enum BossPillarParam_GimmickType : sbyte
{
        BossPillarParam_GimmickType_GT_A = 0,
        BossPillarParam_GimmickType_GT_B = 1,
        BossPillarParam_GimmickType_GT_C = 2,
        BossPillarParam_GimmickType_GT_D = 3,
        BossPillarParam_GimmickType_GT_E = 4,
        BossPillarParam_GimmickType_NUM_GIMMICK_TYPE = 5
    }

    public enum BossPillarParam_AttackType : sbyte
{
        BossPillarParam_AttackType_AT_A = 0,
        BossPillarParam_AttackType_AT_B = 1,
        BossPillarParam_AttackType_AT_C = 2,
        BossPillarParam_AttackType_AT_D = 3,
        BossPillarParam_AttackType_AT_E = 4,
        BossPillarParam_AttackType_NUM_ATTACK_TYPE = 5
    }

    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public struct BossPillarParam
    {
        [FieldOffset(0)]  public bool isUse;
        [FieldOffset(4)]  public float gimmickPhaseTime;
        [FieldOffset(8)]  public float attackPhaseTime;
        [FieldOffset(12)] public bool isUnique;
        [FieldOffset(13)] public BossPillarParam_GimmickType gimmickType;
        [FieldOffset(16)] public float gimmickIntervalTime;
        [FieldOffset(20)] public BossPillarParam_AttackType attackType;
        [FieldOffset(24)] public float attackIntervalTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 952)]
    public struct BossPillarConfig
    {
        [FieldOffset(0)]   public GimmickType gimmickTypeAll;
        [FieldOffset(4)]   public float gimmickIntervalTimeAll;
        [FieldOffset(8)]   public AttackType attackTypeAll;
        [FieldOffset(12)]  public float attackIntervalTimeAll;
        [FieldOffset(16)]  public unsafe fixed byte /* BossPillarParam[32] */ _pillars[896];

        public unsafe BossPillarParam* pillars
        {
            get
            {
                fixed (byte* p_pillars = _pillars)
                    return (BossPillarParam*)p_pillars;
            }
        }

        [FieldOffset(912)] public CString spawnPositionName;
        [FieldOffset(928)] public uint pillarHealthPoint;
        [FieldOffset(932)] public uint pillarBreakDamage;
        [FieldOffset(936)] public float pillarBreakStun;
        [FieldOffset(940)] public bool isDebugDraw;
        [FieldOffset(944)] public uint DebugDrawType;
    }

    public enum CollisionType : sbyte
{
        CT_SPHERE = 0,
        CT_CAPSULE = 1,
        CT_CYLINDER = 2,
        CT_BOX = 3,
        NUM_COLLISION_TYPE = 4
    }

    public enum ColliderActiveType : sbyte
{
        Always = 0,
        OnContactActive = 1,
        OnContactInactive = 2,
        OnMotionActive = 3,
        OnMotionInactive = 4,
        Manual = 5,
        NUM_COLLIDER_ACTIVE_TYPE = 6
    }

    public enum ColliderProperty : short
{
        CpNone = 0,
        CpBattleUse = 1,
        CpBattleUnuse = 2,
        CpRestPoint = 3,
        CpHomingTarget = 4,
        CpPerceive = 5,
        CpDamage = 6,
        CpAttack = 7,
        CpContactActive = 8,
        CpContactInactive = 9,
        CpMotionActive = 10,
        CpMotionInactive = 11,
        CpManual = 12,
        CpUpperSide = 13,
        CpLowerSide = 14,
        CpFrontSide = 15,
        CpBackSide = 16,
        CpLeftSide = 17,
        CpRightSide = 18,
        CpPointA = 19,
        CpPointB = 20,
        CpPointC = 21,
        CpPointD = 22,
        CpCyloopDownUnuse = 23,
        CpDummyDamage = 24,
        NUM_COLLIDER_PROPERTY = 25
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct BossColliderStatus
    {
        [FieldOffset(0)]  public ColliderActiveType type;
        [FieldOffset(2)]  public unsafe fixed byte /* ColliderProperty[4] */ _propertys[8];

        public unsafe ColliderProperty* propertys
        {
            get
            {
                fixed (byte* p_propertys = _propertys)
                    return (ColliderProperty*)p_propertys;
            }
        }

        [FieldOffset(16)] public CString text;
    }

    [StructLayout(LayoutKind.Explicit, Size = 128)]
    public struct BossPerceiveCollisionParam
    {
        [FieldOffset(0)]   public bool isUse;
        [FieldOffset(2)]   public short priority;
        [FieldOffset(4)]   public CollisionType type;
        [FieldOffset(8)]   public CString attachNodeName;
        [FieldOffset(24)]  public CString name;
        [FieldOffset(40)]  public BossColliderStatus status;
        [FieldOffset(80)]  public Vector3 size;
        [FieldOffset(96)]  public Vector3 offset;
        [FieldOffset(112)] public Vector3 rotation;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8208)]
    public struct BossPerceivePartsWithCollisionConfig
    {
        [FieldOffset(0)]    public unsafe fixed byte /* BossPerceiveCollisionParam[64] */ _perceiveCollisions[8192];

        public unsafe BossPerceiveCollisionParam* perceiveCollisions
        {
            get
            {
                fixed (byte* p_perceiveCollisions = _perceiveCollisions)
                    return (BossPerceiveCollisionParam*)p_perceiveCollisions;
            }
        }

        [FieldOffset(8192)] public bool isDebugDraw;
    }

    public enum PointType : sbyte
{
        PT_HOMINGPOINT = 0,
        PT_HEROSAGE = 1,
        PT_MINIONGENERATOR = 2,
        PT_TRIGGER = 3,
        PT_ANCHOR = 4,
        PT_DAMAGEPOINT = 5,
        PT_STICK = 6,
        PT_DAMAGEEFFECT = 7,
        PT_DASHCIRCLE = 8,
        NUM_POINT_TYPE = 9
    }

    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public struct BossHomingPointParam
    {
        [FieldOffset(0)]  public BossColliderStatus status;
        [FieldOffset(32)] public float distance;
        [FieldOffset(36)] public float nextSearchDistance;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct BossMinionParam
    {
        [FieldOffset(0)]  public uint num;
        [FieldOffset(4)]  public float interval;
        [FieldOffset(8)]  public float liveTime;
        [FieldOffset(12)] public float waitTime;
    }

    public enum Shape : sbyte
{
        SHAPE_BOX = 0,
        SHAPE_SPHERE = 1,
        SHAPE_CYLINDER = 2,
        SHAPE_CAPSULE = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct BossTrigerParam
    {
        [FieldOffset(0)]  public Shape ShapeType;
        [FieldOffset(4)]  public float CollisionWidth;
        [FieldOffset(8)]  public float CollisionHeight;
        [FieldOffset(12)] public float CollisionDepth;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct BossStickParam
    {
        [FieldOffset(0)] public float phaseTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct BossDamagePointParam
    {
        [FieldOffset(0)] public bool isCyloopDownUnuse;
        [FieldOffset(8)] public CString text;
    }

    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public struct BossDashCirclPointParam
    {
        [FieldOffset(0)]  public int focusGeometryIndex;
        [FieldOffset(4)]  public int focusTriangleIndex;
        [FieldOffset(8)]  public float sizeScale;
        [FieldOffset(12)] public float impulseSpeed;
        [FieldOffset(16)] public float ocTime;
        [FieldOffset(20)] public float slowRateBoss;
        [FieldOffset(24)] public float slowRatePlayer;
        [FieldOffset(28)] public float slowTime;
        [FieldOffset(32)] public float slowEaseInTime;
        [FieldOffset(36)] public float slowEaseOutTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 224)]
    public struct BossMeshFrameParam
    {
        [FieldOffset(0)]   public bool isUse;
        [FieldOffset(4)]   public uint geometryIndex;
        [FieldOffset(8)]   public uint triangleIndex;
        [FieldOffset(12)]  public PointType type;
        [FieldOffset(16)]  public BossHomingPointParam homingPoint;
        [FieldOffset(56)]  public BossMinionParam minionParam;
        [FieldOffset(72)]  public BossTrigerParam trigger;
        [FieldOffset(88)]  public BossStickParam stickParam;
        [FieldOffset(96)]  public BossDamagePointParam damagePoint;
        [FieldOffset(120)] public BossDashCirclPointParam dashCirclPoint;
        [FieldOffset(160)] public unsafe fixed int linkNums[5];
        [FieldOffset(192)] public Vector3 offsetPos;
        [FieldOffset(208)] public Vector3 offsetRot;
    }

    [StructLayout(LayoutKind.Explicit, Size = 57360)]
    public struct BossMeshFrameConfig
    {
        [FieldOffset(0)]     public unsafe fixed byte /* BossMeshFrameParam[256] */ _meshShapeKeyFrames[57344];

        public unsafe BossMeshFrameParam* meshShapeKeyFrames
        {
            get
            {
                fixed (byte* p_meshShapeKeyFrames = _meshShapeKeyFrames)
                    return (BossMeshFrameParam*)p_meshShapeKeyFrames;
            }
        }

        [FieldOffset(57344)] public bool isDebugDraw;
        [FieldOffset(57345)] public bool isDebugDrawPoint;
        [FieldOffset(57346)] public bool isDebugDrawMesh;
        [FieldOffset(57347)] public bool isDebugDrawMeshIndivid;
        [FieldOffset(57348)] public float debugDrawMeshTriangleDistance;
        [FieldOffset(57352)] public uint debugDrawMeshTriangleNum;
    }

    public enum BossAttackCollisionParam_AttackType : sbyte
{
        AT_NONE = 0,
        AT_BLOWOFF = 1,
        AT_SLAMDOWNWARD = 2,
        AT_KILLING = 3,
        AT_NOTPARRY = 4,
        AT_NOTDAMAGE = 5,
        BossAttackCollisionParam_AttackType_NUM_ATTACK_TYPE = 6
    }

    [StructLayout(LayoutKind.Explicit, Size = 112)]
    public struct BossAttackCollisionParam
    {
        [FieldOffset(0)]  public bool isUse;
        [FieldOffset(8)]  public CString attachNodeName;
        [FieldOffset(24)] public float damageVelocityRaito;
        [FieldOffset(28)] public unsafe fixed byte /* BossAttackCollisionParam_AttackType[4] */ _types[4];

        public unsafe BossAttackCollisionParam_AttackType* types
        {
            get
            {
                fixed (byte* p_types = _types)
                    return (BossAttackCollisionParam_AttackType*)p_types;
            }
        }

        [FieldOffset(32)] public BossColliderStatus status;
        [FieldOffset(64)] public float size;
        [FieldOffset(80)] public Vector3 offset;
        [FieldOffset(96)] public CString parryCounterTargetCollisionName;
    }

    [StructLayout(LayoutKind.Explicit, Size = 7184)]
    public struct BossAttackCollisionConfig
    {
        [FieldOffset(0)]    public unsafe fixed byte /* BossAttackCollisionParam[64] */ _attackCollisions[7168];

        public unsafe BossAttackCollisionParam* attackCollisions
        {
            get
            {
                fixed (byte* p_attackCollisions = _attackCollisions)
                    return (BossAttackCollisionParam*)p_attackCollisions;
            }
        }

        [FieldOffset(7168)] public bool isDebugDraw;
    }

    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public struct BossBattlePhaseCollisionParam
    {
        [FieldOffset(0)]  public bool isUse;
        [FieldOffset(8)]  public CString attachNodeName;
        [FieldOffset(24)] public CString name;
        [FieldOffset(40)] public float size;
        [FieldOffset(48)] public Vector3 offset;
        [FieldOffset(64)] public Vector3 rotation;
        [FieldOffset(80)] public bool isParryActive;
        [FieldOffset(84)] public float cyloopRadius;
        [FieldOffset(88)] public bool onlyRigidBody;
    }

    [StructLayout(LayoutKind.Explicit, Size = 1552)]
    public struct BossBattlePhaseCollisionConfig
    {
        [FieldOffset(0)]    public unsafe fixed byte /* BossBattlePhaseCollisionParam[16] */ _battleCollisions[1536];

        public unsafe BossBattlePhaseCollisionParam* battleCollisions
        {
            get
            {
                fixed (byte* p_battleCollisions = _battleCollisions)
                    return (BossBattlePhaseCollisionParam*)p_battleCollisions;
            }
        }

        [FieldOffset(1536)] public bool isDebugDraw;
    }

    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public struct BossDropRingConfig
    {
        [FieldOffset(0)]  public uint ringNumQuickCyloopUp;
        [FieldOffset(4)]  public uint ringNumQuickCyloopDown;
        [FieldOffset(8)]  public uint ringNumSonicSpecial;
        [FieldOffset(12)] public float ringSpawnDistance;
        [FieldOffset(16)] public float ringSuckedVelocity;
    }

    [StructLayout(LayoutKind.Explicit, Size = 75712)]
    public struct BossBaseConfig
    {
        [FieldOffset(0)]     public BossStatusConfig status;
        [FieldOffset(416)]   public BossPillarConfig pillar;
        [FieldOffset(1376)]  public BossPerceivePartsWithCollisionConfig perceivPartsWithCollision;
        [FieldOffset(9584)]  public BossMeshFrameConfig meshShapeKeyFrame;
        [FieldOffset(66944)] public BossAttackCollisionConfig attackCollision;
        [FieldOffset(74128)] public BossBattlePhaseCollisionConfig battleCollision;
        [FieldOffset(75680)] public BossDropRingConfig dropRing;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct KnightIdleConfig
    {
        [FieldOffset(0)] public float runSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct KnightClimbIdleConfig
    {
        [FieldOffset(0)] public float moveIntervalAfterSlam;
        [FieldOffset(4)] public float moveIntervalAfterMove;
        [FieldOffset(8)] public float moveIntervalAfterFall;
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct KnightClimbMoveConfig
    {
        [FieldOffset(0)]  public float speedAvg;
        [FieldOffset(4)]  public float angle1Min;
        [FieldOffset(8)]  public float angle1Max;
        [FieldOffset(12)] public float angle2Min;
        [FieldOffset(16)] public float angle2Max;
        [FieldOffset(20)] public float move2WaitDuration;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct KnightClimbSlamLookupCameraConfig
    {
        [FieldOffset(0)]  public float duration;
        [FieldOffset(4)]  public float lockonDistance;
        [FieldOffset(8)]  public float unlockDistance;
        [FieldOffset(12)] public float distance;
        [FieldOffset(16)] public float minElevation;
        [FieldOffset(20)] public float maxElevation;
        [FieldOffset(24)] public float panningSuspensionK;
        [FieldOffset(28)] public float interiorPanningSuspensionK;
    }

    [StructLayout(LayoutKind.Explicit, Size = 52)]
    public struct KnightClimbSlamWaveConfig
    {
        [FieldOffset(0)]  public float interval;
        [FieldOffset(4)]  public uint generateNum;
        [FieldOffset(8)]  public float coolTime;
        [FieldOffset(12)] public float radius;
        [FieldOffset(16)] public float appearRadius;
        [FieldOffset(20)] public float keepRadius;
        [FieldOffset(24)] public float disappearRadius;
        [FieldOffset(28)] public float heightMin;
        [FieldOffset(32)] public float heightMax;
        [FieldOffset(36)] public float lifeTime;
        [FieldOffset(40)] public float modelScale;
        [FieldOffset(44)] public float modelDiameter;
        [FieldOffset(48)] public float effectDistance;
    }

    [StructLayout(LayoutKind.Explicit, Size = 112)]
    public struct KnightClimbSlamConfig
    {
        [FieldOffset(0)]  public float rotateSpeedBeforeSlam;
        [FieldOffset(4)]  public float slamAnimSpeed;
        [FieldOffset(8)]  public float waitTimeAfterSlam;
        [FieldOffset(12)] public float liftUpStartAnimSpeed;
        [FieldOffset(16)] public float liftUpEndAnimSpeed;
        [FieldOffset(20)] public float liftUpStartAnimSpeedMiss;
        [FieldOffset(24)] public float liftUpEndAnimSpeedMiss;
        [FieldOffset(28)] public KnightClimbSlamLookupCameraConfig lookupCam;
        [FieldOffset(60)] public KnightClimbSlamWaveConfig wave;
    }

    public enum PlayerOffsetType : sbyte
{
        PLAYER_OFFSET_NORMAL = 0,
        PLAYER_OFFSET_ABSOLUTE = 1
    }

    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public struct KnightGrindCameraConfig
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

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct KnightGrindTrapConfig
    {
        [FieldOffset(0)] public int damage;
        [FieldOffset(4)] public bool blowOff;
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct KnightGrindLaunchCameraConfig
    {
        [FieldOffset(0)]  public Vector3 lookAtOffset;
        [FieldOffset(16)] public Vector3 eyeOffset;
        [FieldOffset(32)] public float duration;
        [FieldOffset(36)] public float easeTimeBegin;
        [FieldOffset(40)] public float easeTimeEnd;
    }

    [StructLayout(LayoutKind.Explicit, Size = 144)]
    public struct KnightGrindLaunchConfig
    {
        [FieldOffset(0)]  public float outStrength;
        [FieldOffset(4)]  public float inStrength;
        [FieldOffset(8)]  public float outElev;
        [FieldOffset(12)] public float inElev;
        [FieldOffset(16)] public float speed;
        [FieldOffset(24)] public CString landFrameName;
        [FieldOffset(48)] public Vector3 landOffset;
        [FieldOffset(64)] public Vector3 landRayOffset;
        [FieldOffset(80)] public Vector3 landOffsetAfterRaycast;
        [FieldOffset(96)] public KnightGrindLaunchCameraConfig camera;
    }

    [StructLayout(LayoutKind.Explicit, Size = 240)]
    public struct KnightClimbGrindConfig
    {
        [FieldOffset(0)]  public KnightGrindCameraConfig camera;
        [FieldOffset(80)] public float playerSpeed;
        [FieldOffset(84)] public KnightGrindTrapConfig trap;
        [FieldOffset(96)] public KnightGrindLaunchConfig launch;
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct KnightClimbTraceWaveConfig
    {
        [FieldOffset(0)]  public float traceSpeed;
        [FieldOffset(4)]  public float traceRotSpeed;
        [FieldOffset(8)]  public float traceLifeTime;
        [FieldOffset(12)] public float traceWidth;
        [FieldOffset(16)] public float traceHeight;
        [FieldOffset(20)] public float traceAppearDistance;
        [FieldOffset(24)] public float traceKeepDistance;
        [FieldOffset(28)] public float traceDisappearDistance;
        [FieldOffset(32)] public float traceModelScale;
        [FieldOffset(36)] public float traceModelDiameter;
        [FieldOffset(40)] public float traceModelInterval;
        [FieldOffset(44)] public float traceCollisionDistance;
    }

    [StructLayout(LayoutKind.Explicit, Size = 464)]
    public struct KnightClimbConfig
    {
        [FieldOffset(0)]   public KnightClimbIdleConfig idle;
        [FieldOffset(12)]  public KnightClimbMoveConfig move;
        [FieldOffset(36)]  public KnightClimbSlamConfig slam;
        [FieldOffset(160)] public KnightClimbGrindConfig grind;
        [FieldOffset(400)] public float climbTimeLimit;
        [FieldOffset(404)] public KnightClimbTraceWaveConfig trace;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct KnightBattle1IdleConfig
    {
        [FieldOffset(0)] public float moveInterval;
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct KnightBattle1MoveConfig
    {
        [FieldOffset(0)]  public float speedAvg;
        [FieldOffset(4)]  public float angle1Min;
        [FieldOffset(8)]  public float angle1Max;
        [FieldOffset(12)] public float angle2Min;
        [FieldOffset(16)] public float angle2Max;
        [FieldOffset(20)] public float move2WaitDuration;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct KnightBattle1GuardConfig
    {
        [FieldOffset(0)] public float guardStaggerMax;
        [FieldOffset(4)] public float damageStaggerMax;
    }

    [StructLayout(LayoutKind.Explicit, Size = 288)]
    public struct KnightShieldRideConfig
    {
        [FieldOffset(0)]   public float startDistance;
        [FieldOffset(4)]   public float startXOffset;
        [FieldOffset(8)]   public float startYOffset;
        [FieldOffset(12)]  public float startAngle;
        [FieldOffset(16)]  public float speed;
        [FieldOffset(20)]  public float turnAcc;
        [FieldOffset(24)]  public float turnSpeedMax;
        [FieldOffset(28)]  public float areaRadius;
        [FieldOffset(32)]  public float windPowerMin;
        [FieldOffset(36)]  public float windPowerMax;
        [FieldOffset(40)]  public float windTimeMin;
        [FieldOffset(44)]  public float windTimeMax;
        [FieldOffset(48)]  public float windInterval;
        [FieldOffset(52)]  public float camRideElevation;
        [FieldOffset(56)]  public float camRideDistance;
        [FieldOffset(64)]  public Vector3 camRideOffset;
        [FieldOffset(80)]  public float camCompeteElevation;
        [FieldOffset(84)]  public float camCompeteAzimuth;
        [FieldOffset(88)]  public float camCompeteDistance;
        [FieldOffset(92)]  public float camHitElevation;
        [FieldOffset(96)]  public float camHitAzimuth;
        [FieldOffset(100)] public float camHitDistance;
        [FieldOffset(104)] public float camShakeHitLoopMagnitude;
        [FieldOffset(108)] public int camShakeHitLoopFreq;
        [FieldOffset(112)] public float camShakeRejectLoopMagnitude;
        [FieldOffset(116)] public int camShakeRejectLoopFreq;
        [FieldOffset(120)] public byte missileNum;
        [FieldOffset(124)] public float missileInterval;
        [FieldOffset(128)] public float missileStartTime;
        [FieldOffset(132)] public float missileSpeed;
        [FieldOffset(136)] public float missileRotateSpeed;
        [FieldOffset(140)] public float missileMidPosDistance;
        [FieldOffset(144)] public float missileMidPosHeightOffset;
        [FieldOffset(148)] public float missileShotAngle;
        [FieldOffset(152)] public float missileShotStartWait;
        [FieldOffset(156)] public float missileRiseSpeed;
        [FieldOffset(160)] public float missileRiseTime;
        [FieldOffset(164)] public float missileHideTime;
        [FieldOffset(168)] public float missileAppearDistance;
        [FieldOffset(172)] public float missileAppearHeight;
        [FieldOffset(176)] public float missileAppearWidth;
        [FieldOffset(180)] public float missileLifeTime;
        [FieldOffset(184)] public float missileLifeTimeNoHit;
        [FieldOffset(188)] public float missileHitPower;
        [FieldOffset(192)] public float missileHitPowerRateDown;
        [FieldOffset(196)] public float missileHitPowerKeepTime;
        [FieldOffset(200)] public float missileHeightShakeMax;
        [FieldOffset(204)] public float missileHeightShakeMin;
        [FieldOffset(208)] public float missileWidthShake;
        [FieldOffset(212)] public float rejectCompeteDuration;
        [FieldOffset(216)] public float hitShaveDamageSum;
        [FieldOffset(220)] public uint hitShaveHitNum;
        [FieldOffset(224)] public float hitShaveHitInterval;
        [FieldOffset(228)] public float damageRatio;
        [FieldOffset(232)] public float staggerValue;
        [FieldOffset(236)] public float knockbackDistance;
        [FieldOffset(240)] public float durationAfterHit;
        [FieldOffset(244)] public unsafe fixed uint missileHitPattern[10];
    }

    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public struct KnightBattle1InterruptConfig
    {
        [FieldOffset(0)]  public float parriedDuration;
        [FieldOffset(4)]  public float slowRate;
        [FieldOffset(8)]  public float slowTime;
        [FieldOffset(12)] public float cameraOffset;
        [FieldOffset(16)] public float cameraFade;
    }

    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public struct KnightBattle1CyFloat
    {
        [FieldOffset(0)]  public float height;
        [FieldOffset(4)]  public float riseDuration;
        [FieldOffset(8)]  public float floatDuration;
        [FieldOffset(12)] public float fallDuration;
        [FieldOffset(16)] public float cyFallDuration;
        [FieldOffset(20)] public float cyFallDelay;
        [FieldOffset(24)] public float downDuration;
        [FieldOffset(28)] public float enableDownCounterHPRatio;
        [FieldOffset(32)] public float enableGuardHPRatio;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct KnightThresholdRingSupplyParam
    {
        [FieldOffset(0)] public float hpRatio;
        [FieldOffset(4)] public int missileNum;
        [FieldOffset(8)] public float missileWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct KnightRageShieldAttackCameraConfig
    {
        [FieldOffset(0)] public float interpolateTimeBegin;
        [FieldOffset(4)] public float interpolateTimeEnd;
    }

    [StructLayout(LayoutKind.Explicit, Size = 144)]
    public struct KnightRageShieldConfig
    {
        [FieldOffset(0)]   public float modelScale;
        [FieldOffset(4)]   public float hitEffectScale;
        [FieldOffset(8)]   public float actionGuideOffsetX;
        [FieldOffset(12)]  public float actionGuideOffsetY;
        [FieldOffset(16)]  public float heightOffset;
        [FieldOffset(20)]  public float flySpeed;
        [FieldOffset(24)]  public float flyLineWidth;
        [FieldOffset(28)]  public float flyLineAfterHitWallLength;
        [FieldOffset(32)]  public float flyLineDuration;
        [FieldOffset(36)]  public float hitWallTargetingStart;
        [FieldOffset(40)]  public float hitWallTargetingAdd;
        [FieldOffset(44)]  public float hitWallTargetingSub;
        [FieldOffset(48)]  public float hitWallTargeting;
        [FieldOffset(52)]  public byte hitWallTargetingCycle;
        [FieldOffset(56)]  public float hitWallTargetAreaRadius;
        [FieldOffset(60)]  public float hitWallStopDuration;
        [FieldOffset(64)]  public float hitWallFlySpeed;
        [FieldOffset(68)]  public float hitWallAccStartTime;
        [FieldOffset(72)]  public float hitWallAccDuration;
        [FieldOffset(76)]  public float parryTargetRange;
        [FieldOffset(80)]  public float parryTargetAngVel;
        [FieldOffset(84)]  public float parryTargetTimeLimit;
        [FieldOffset(88)]  public float parryTargetLineWidth;
        [FieldOffset(92)]  public float parryTargetLineLength;
        [FieldOffset(96)]  public float parryFlySpeedStart;
        [FieldOffset(100)] public float parryFlySpeed;
        [FieldOffset(104)] public float parryAccStartTime;
        [FieldOffset(108)] public float parryAccDuration;
        [FieldOffset(112)] public float parryFlyLineWidth;
        [FieldOffset(116)] public float parryFlyLineDuration;
        [FieldOffset(120)] public float parryFlySuspendDuration;
        [FieldOffset(124)] public float parryFlySuspendEndDistance;
        [FieldOffset(128)] public KnightRageShieldAttackCameraConfig attackCamera;
        [FieldOffset(136)] public float damageRatio;
        [FieldOffset(140)] public float damageVelocity;
    }

    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public struct KnightRageOverlookCameraConfig
    {
        [FieldOffset(0)]  public float azimuth;
        [FieldOffset(4)]  public float elevation;
        [FieldOffset(8)]  public float distance;
        [FieldOffset(12)] public float zRoll;
        [FieldOffset(16)] public float fovy;
        [FieldOffset(32)] public Vector3 offset;
        [FieldOffset(48)] public float followPlayerRatio;
        [FieldOffset(52)] public float lookCenterRatio;
        [FieldOffset(56)] public float interpolateTimeBegin;
        [FieldOffset(60)] public float interpolateTimeEnd;
        [FieldOffset(64)] public float controlAngAcc;
        [FieldOffset(68)] public float controlAngVel;
    }

    [StructLayout(LayoutKind.Explicit, Size = 320)]
    public struct KnightBattle1Rage
    {
        [FieldOffset(0)]   public KnightRageShieldConfig shield;
        [FieldOffset(144)] public KnightRageOverlookCameraConfig normalCamera;
        [FieldOffset(224)] public KnightRageOverlookCameraConfig targetingCamera;
        [FieldOffset(304)] public float moveRestartAnimSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public struct KnightAerialCamera
    {
        [FieldOffset(0)]  public float downTime;
        [FieldOffset(4)]  public unsafe fixed float downCutChangeTime[2];
        [FieldOffset(16)] public Vector3 downCamOffset;
        [FieldOffset(32)] public float riseTime;
        [FieldOffset(48)] public Vector3 riseCamOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 848)]
    public struct KnightBattle1Config
    {
        [FieldOffset(0)]   public float closedAreaRadius;
        [FieldOffset(4)]   public KnightBattle1IdleConfig idle;
        [FieldOffset(8)]   public KnightBattle1MoveConfig move;
        [FieldOffset(32)]  public KnightBattle1GuardConfig guard;
        [FieldOffset(48)]  public KnightShieldRideConfig shieldRide;
        [FieldOffset(336)] public KnightBattle1InterruptConfig interrupt;
        [FieldOffset(356)] public float normalKnockbackDistance;
        [FieldOffset(360)] public KnightBattle1CyFloat cyFloat;
        [FieldOffset(396)] public unsafe fixed byte /* KnightThresholdRingSupplyParam[3] */ _ringSupply[36];

        public unsafe KnightThresholdRingSupplyParam* ringSupply
        {
            get
            {
                fixed (byte* p_ringSupply = _ringSupply)
                    return (KnightThresholdRingSupplyParam*)p_ringSupply;
            }
        }

        [FieldOffset(432)] public KnightBattle1Rage rage;
        [FieldOffset(752)] public float rageHPRatio;
        [FieldOffset(756)] public float atkSpecialHPRatio;
        [FieldOffset(768)] public KnightAerialCamera aerialCamera;
        [FieldOffset(832)] public float damageEventTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct KnightBattle2RunCamera
    {
        [FieldOffset(0)]  public float azimuth;
        [FieldOffset(4)]  public float elevation;
        [FieldOffset(8)]  public float distance;
        [FieldOffset(12)] public float zRoll;
        [FieldOffset(16)] public float fovy;
        [FieldOffset(32)] public Vector3 frameOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 144)]
    public struct KnightBattle2RunConfig
    {
        [FieldOffset(0)]  public float speed;
        [FieldOffset(4)]  public float moveWidth;
        [FieldOffset(8)]  public float moveHeight;
        [FieldOffset(16)] public Vector3 playerOffset;
        [FieldOffset(32)] public Vector3 playerOffsetFar;
        [FieldOffset(48)] public Vector3 playerOffsetNear;
        [FieldOffset(64)] public Vector3 playerOffsetTackle;
        [FieldOffset(80)] public float attackInterval;
        [FieldOffset(84)] public float attackIntervalDelayOnHit;
        [FieldOffset(96)] public KnightBattle2RunCamera camera;
    }

    public enum XType : byte
{
        Zero = 0,
        HitPosX = 1,
        Indivisual = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct KnightBattle2ShieldSplineNode
    {
        [FieldOffset(0)]  public bool enable;
        [FieldOffset(1)]  public XType xType;
        [FieldOffset(4)]  public float xIndivisual;
        [FieldOffset(8)]  public float y;
        [FieldOffset(12)] public float z;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct KnightBattle2ShieldUTurnCameraConfig
    {
        [FieldOffset(0)] public float duration;
        [FieldOffset(4)] public float interpolateTimeBegin;
        [FieldOffset(8)] public float interpolateTimeEnd;
    }

    [StructLayout(LayoutKind.Explicit, Size = 368)]
    public struct KnightBattle2ShieldConfig
    {
        [FieldOffset(0)]   public unsafe fixed byte /* KnightBattle2ShieldSplineNode[8] */ _nodesStraight[128];

        public unsafe KnightBattle2ShieldSplineNode* nodesStraight
        {
            get
            {
                fixed (byte* p_nodesStraight = _nodesStraight)
                    return (KnightBattle2ShieldSplineNode*)p_nodesStraight;
            }
        }

        [FieldOffset(128)] public float stopPosRatioStraight;
        [FieldOffset(132)] public float stopDecStartPosRatioStraight;
        [FieldOffset(136)] public float stopAccEndPosRatioStraight;
        [FieldOffset(140)] public float stopDurationStraight;
        [FieldOffset(144)] public float speedStraight1;
        [FieldOffset(148)] public float speedStraight2;
        [FieldOffset(152)] public float hitPosXStraight;
        [FieldOffset(156)] public float uTurnEndPosStraight;
        [FieldOffset(160)] public float swordDelayStraight;
        [FieldOffset(164)] public unsafe fixed byte /* KnightBattle2ShieldSplineNode[8] */ _nodesSlalom[128];

        public unsafe KnightBattle2ShieldSplineNode* nodesSlalom
        {
            get
            {
                fixed (byte* p_nodesSlalom = _nodesSlalom)
                    return (KnightBattle2ShieldSplineNode*)p_nodesSlalom;
            }
        }

        [FieldOffset(292)] public float stopPosRatioSlalom;
        [FieldOffset(296)] public float stopDecStartPosRatioSlalom;
        [FieldOffset(300)] public float stopAccEndPosRatioSlalom;
        [FieldOffset(304)] public float stopDurationSlalom;
        [FieldOffset(308)] public float speedSlalom1;
        [FieldOffset(312)] public float speedSlalom2;
        [FieldOffset(316)] public float hitPosXSlalom;
        [FieldOffset(320)] public float uTurnEndPosSlalom;
        [FieldOffset(324)] public float magnitudeSlalomFar;
        [FieldOffset(328)] public float magnitudeSlalomNear;
        [FieldOffset(332)] public byte slalomNumMin;
        [FieldOffset(333)] public byte slalomNumMax;
        [FieldOffset(336)] public float slalomEndPosRatio;
        [FieldOffset(340)] public float swordDelaySlalom;
        [FieldOffset(344)] public float uTurnSpeedRatioDuringCam;
        [FieldOffset(348)] public float uTurnSpeedRatioAfterCam;
        [FieldOffset(352)] public KnightBattle2ShieldUTurnCameraConfig uTurnCamera;
        [FieldOffset(364)] public float attackLineWidth;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct KnightBattle2SwordConfig
    {
        [FieldOffset(0)] public float parriedDuration;
        [FieldOffset(4)] public float animSpeedOnDoubleAtkParried;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct KnightBattle2InterruptConfig
    {
        [FieldOffset(0)] public float parriedDuration;
    }

    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public struct KnightBattle2CyFloat
    {
        [FieldOffset(0)]  public float height;
        [FieldOffset(4)]  public float riseDuration;
        [FieldOffset(8)]  public float floatDuration;
        [FieldOffset(12)] public float fallDuration;
        [FieldOffset(16)] public float cyFallDuration;
        [FieldOffset(20)] public float cyFallDelay;
        [FieldOffset(24)] public float downDuration;
        [FieldOffset(28)] public float enableDownCounterHPRatio;
        [FieldOffset(32)] public float enableGuardHPRatio;
    }

    [StructLayout(LayoutKind.Explicit, Size = 640)]
    public struct KnightBattle2Config
    {
        [FieldOffset(0)]   public KnightBattle2RunConfig run;
        [FieldOffset(144)] public KnightBattle2ShieldConfig shield;
        [FieldOffset(512)] public KnightBattle2SwordConfig sword;
        [FieldOffset(520)] public KnightBattle2InterruptConfig interrupt;
        [FieldOffset(524)] public float knockbackDistance;
        [FieldOffset(528)] public KnightBattle2CyFloat cyFloat;
        [FieldOffset(576)] public KnightAerialCamera aerialCamera;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct KnightSonicSpecialConfig
    {
        [FieldOffset(0)] public float damageRatio;
    }

    [StructLayout(LayoutKind.Explicit, Size = 320)]
    public struct KnightCyFloatSpearConfig
    {
        [FieldOffset(0)]   public unsafe fixed byte /* Vector3[8] */ _upOffset[128];

        public unsafe Vector3* upOffset
        {
            get
            {
                fixed (byte* p_upOffset = _upOffset)
                    return (Vector3*)p_upOffset;
            }
        }

        [FieldOffset(128)] public unsafe fixed byte /* Vector3[8] */ _upRotationAngle[128];

        public unsafe Vector3* upRotationAngle
        {
            get
            {
                fixed (byte* p_upRotationAngle = _upRotationAngle)
                    return (Vector3*)p_upRotationAngle;
            }
        }

        [FieldOffset(256)] public float upMoveDistanceOffset;
        [FieldOffset(272)] public Vector3 downOffset;
        [FieldOffset(288)] public float downMoveDelay;
        [FieldOffset(292)] public unsafe fixed float downMoveDistance[3];
        [FieldOffset(304)] public unsafe fixed float downMoveDuration[3];
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct KnightAttackSignParam
    {
        [FieldOffset(0)] public unsafe fixed float delayTime[6];
    }

    [StructLayout(LayoutKind.Explicit, Size = 3)]
    public struct EnemyPracticeNotifierConfig
    {
        [FieldOffset(0)] public bool usePracticeNotifier;
        [FieldOffset(1)] public sbyte practiceNo;
        [FieldOffset(2)] public sbyte tipsNo;
    }

    [StructLayout(LayoutKind.Explicit, Size = 9)]
    public struct BossKnightNotifierParam
    {
        [FieldOffset(0)] public EnemyPracticeNotifierConfig notifierConfigClimb;
        [FieldOffset(3)] public EnemyPracticeNotifierConfig notifierConfigBattle1;
        [FieldOffset(6)] public EnemyPracticeNotifierConfig notifierConfigBattle2;
    }

    [StructLayout(LayoutKind.Explicit, Size = 78080)]
    public struct BossKnightConfig
    {
        [FieldOffset(0)]     public BossBaseConfig bossBaseConfig;
        [FieldOffset(75712)] public KnightIdleConfig idle;
        [FieldOffset(75728)] public KnightClimbConfig climb;
        [FieldOffset(76192)] public KnightBattle1Config battle1;
        [FieldOffset(77040)] public KnightBattle2Config battle2;
        [FieldOffset(77680)] public KnightSonicSpecialConfig sonicSpecial;
        [FieldOffset(77696)] public KnightCyFloatSpearConfig cyFloatSpear;
        [FieldOffset(78016)] public byte knockbackStaggerCount;
        [FieldOffset(78020)] public unsafe fixed float thresholdDamageEffectHPRatio[3];
        [FieldOffset(78032)] public KnightAttackSignParam attackSign;
        [FieldOffset(78056)] public BossKnightNotifierParam notifier;
    }

}