Library "BossDragonConfig"
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

    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public struct BossDragonCollisionParamBase
    {
        [FieldOffset(0)]  public CString name;
        [FieldOffset(16)] public CString parentFrame;
        [FieldOffset(32)] public Vector3 size;
        [FieldOffset(48)] public Vector3 localPosition;
        [FieldOffset(64)] public Vector3 localRotation;
    }

    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public struct BossDragonHitBoxParam
    {
        [FieldOffset(0)]  public BossDragonCollisionParamBase bossDragonCollisionParamBase;
        [FieldOffset(80)] public Vector3 damageVelocity;
    }

    [StructLayout(LayoutKind.Explicit, Size = 144)]
    public struct BossDragonHurtBoxParam
    {
        [FieldOffset(0)]   public BossDragonCollisionParamBase bossDragonCollisionParamBase;
        [FieldOffset(80)]  public bool isEnableHoming;
        [FieldOffset(88)]  public CString homingNode;
        [FieldOffset(104)] public CString homingNodeMirror;
        [FieldOffset(128)] public Vector3 homingPosition;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct BossDragonScratchParam
    {
        [FieldOffset(0)] public float aimTime;
        [FieldOffset(4)] public float stunTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public struct BossDragonReflectShotParam
    {
        [FieldOffset(0)]  public float radius;
        [FieldOffset(4)]  public float speed;
        [FieldOffset(8)]  public float maxSpeed;
        [FieldOffset(12)] public float accel;
        [FieldOffset(16)] public float reflectSpeedScale;
        [FieldOffset(20)] public float intervalTime;
        [FieldOffset(24)] public float lifeTime;
        [FieldOffset(28)] public float pitchOffsetRange;
        [FieldOffset(32)] public float yawOffsetRange;
        [FieldOffset(36)] public bool isBound;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct BossDragonShotParam
    {
        [FieldOffset(0)]  public float radius;
        [FieldOffset(4)]  public float speed;
        [FieldOffset(8)]  public float intervalTime;
        [FieldOffset(12)] public float lifeTime;
        [FieldOffset(16)] public float pitchOffsetRange;
        [FieldOffset(20)] public float yawOffsetRange;
        [FieldOffset(24)] public int count;
        [FieldOffset(28)] public float waitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public struct BossDragonSpiralShotParam
    {
        [FieldOffset(0)]  public float radius;
        [FieldOffset(4)]  public float speed;
        [FieldOffset(8)]  public float intervalTime;
        [FieldOffset(12)] public float lifeTime;
        [FieldOffset(16)] public float pitchSpeed;
        [FieldOffset(20)] public float yawSpeed;
        [FieldOffset(24)] public float circleIntervalTime;
        [FieldOffset(28)] public int count;
        [FieldOffset(32)] public int parriableCount;
        [FieldOffset(36)] public float waitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public struct BossDragonSplashShotParam
    {
        [FieldOffset(0)]  public float radius;
        [FieldOffset(4)]  public float speed;
        [FieldOffset(8)]  public float gravity;
        [FieldOffset(12)] public float intervalTime;
        [FieldOffset(16)] public float lifeTime;
        [FieldOffset(20)] public float pitch;
        [FieldOffset(24)] public float pitchInterval;
        [FieldOffset(28)] public float yawInterval;
        [FieldOffset(32)] public int count;
        [FieldOffset(36)] public int parriableCount;
        [FieldOffset(40)] public float waitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public struct BossDragonHomingLaserParam
    {
        [FieldOffset(0)]  public float radius;
        [FieldOffset(4)]  public float speed;
        [FieldOffset(8)]  public float maxAccel;
        [FieldOffset(12)] public float intervalTime;
        [FieldOffset(16)] public float arrivalTime;
        [FieldOffset(20)] public float lifeTime;
        [FieldOffset(24)] public float minPitchOffset;
        [FieldOffset(28)] public float maxPitchOffset;
        [FieldOffset(32)] public float yawOffsetRange;
        [FieldOffset(36)] public int count;
        [FieldOffset(40)] public float waitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public struct BossDragonHomingMissileParam
    {
        [FieldOffset(0)]  public float radius;
        [FieldOffset(4)]  public float length;
        [FieldOffset(8)]  public float speed;
        [FieldOffset(12)] public float intervalTime;
        [FieldOffset(16)] public float lifeTime;
        [FieldOffset(20)] public float minPitchOffset;
        [FieldOffset(24)] public float maxPitchOffset;
        [FieldOffset(28)] public float yawOffsetRange;
        [FieldOffset(32)] public int count;
        [FieldOffset(36)] public float waitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct BossDragonRippleLaserParam
    {
        [FieldOffset(0)]  public float innerRadius;
        [FieldOffset(4)]  public float outerRadius;
        [FieldOffset(8)]  public float speed;
        [FieldOffset(12)] public float intervalTime;
        [FieldOffset(16)] public float lifeTime;
        [FieldOffset(20)] public float pitchOffsetRange;
        [FieldOffset(24)] public float yawOffsetRange;
        [FieldOffset(28)] public int count;
        [FieldOffset(32)] public int parriableCount;
        [FieldOffset(36)] public float intervalTimeInGroup;
        [FieldOffset(40)] public int countInGroup;
        [FieldOffset(44)] public float waitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public struct BossDragonRippleLaserRageParam
    {
        [FieldOffset(0)]  public float innerRadius;
        [FieldOffset(4)]  public float outerRadius;
        [FieldOffset(8)]  public float speed;
        [FieldOffset(12)] public float intervalTime;
        [FieldOffset(16)] public float lifeTime;
        [FieldOffset(20)] public float maxPitch;
        [FieldOffset(24)] public float maxYaw;
        [FieldOffset(28)] public int verticalCount;
        [FieldOffset(32)] public int horizontalCount;
        [FieldOffset(36)] public int extraFrontCount;
        [FieldOffset(40)] public int parriableCount;
        [FieldOffset(44)] public float intervalTimeInGroup;
        [FieldOffset(48)] public int countInGroup;
        [FieldOffset(52)] public float waitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public struct BossDragonRippleLaserDummyParam
    {
        [FieldOffset(0)]  public float innerRadius;
        [FieldOffset(4)]  public float outerRadius;
        [FieldOffset(8)]  public float speed;
        [FieldOffset(12)] public float intervalTime;
        [FieldOffset(16)] public float lifeTime;
        [FieldOffset(20)] public float pitchOffsetRange;
        [FieldOffset(24)] public float yawOffsetRange;
        [FieldOffset(28)] public int count;
        [FieldOffset(32)] public float intervalTimeInGroup;
        [FieldOffset(36)] public int countInGroup;
    }

    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public struct BossDragonWaveParam
    {
        [FieldOffset(0)]  public float speed;
        [FieldOffset(4)]  public float rotSpeed;
        [FieldOffset(8)]  public float accel;
        [FieldOffset(12)] public float rotAccel;
        [FieldOffset(16)] public float intervalTime;
        [FieldOffset(20)] public float lifeTime;
        [FieldOffset(24)] public int segmentCount;
        [FieldOffset(28)] public float waveRate;
        [FieldOffset(32)] public int count;
        [FieldOffset(36)] public float waitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public struct BossDragonLaserParam
    {
        [FieldOffset(0)]  public float radius;
        [FieldOffset(4)]  public float length;
        [FieldOffset(8)]  public float rotSpeed;
        [FieldOffset(12)] public float rotAccel;
        [FieldOffset(16)] public float roll;
        [FieldOffset(20)] public float intervalTime;
        [FieldOffset(24)] public float standbyTime;
        [FieldOffset(28)] public int count;
        [FieldOffset(32)] public float waitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct BossDragonCounterLaserParam
    {
        [FieldOffset(0)] public float radius;
        [FieldOffset(4)] public float speed;
        [FieldOffset(8)] public float lifeTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct BossDragonRingSupplyMissileParam
    {
        [FieldOffset(0)] public int missileNum;
        [FieldOffset(4)] public float missileWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public struct BossDragonRingSupplyParam
    {
        [FieldOffset(0)]  public Vector3 playerPosition;
        [FieldOffset(16)] public float moveTime;
        [FieldOffset(20)] public float moveRange;
        [FieldOffset(24)] public float rotSpeed;
        [FieldOffset(28)] public unsafe fixed byte /* BossDragonRingSupplyMissileParam[3] */ _missile[24];

        public unsafe BossDragonRingSupplyMissileParam* missile
        {
            get
            {
                fixed (byte* p_missile = _missile)
                    return (BossDragonRingSupplyMissileParam*)p_missile;
            }
        }
    }

    public enum BossDragonLayoutParam_EaseType : sbyte
{
        SMOOTH = 0,
        EASE_IN = 1,
        EASE_OUT = 2,
        EASE_IN_OUT = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public struct BossDragonLayoutParam
    {
        [FieldOffset(0)]  public Vector3 bossPosition;
        [FieldOffset(16)] public float bossYaw;
        [FieldOffset(20)] public BossDragonLayoutParam_EaseType bossEaseType;
        [FieldOffset(24)] public float bossEaseTime;
        [FieldOffset(32)] public Vector3 playerPosition;
        [FieldOffset(48)] public float playerFieldRange;
        [FieldOffset(52)] public float playerFieldHeight;
        [FieldOffset(56)] public float playerFieldYaw;
        [FieldOffset(60)] public BossDragonLayoutParam_EaseType playerEaseType;
        [FieldOffset(64)] public float playerEaseTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 112)]
    public struct BossDragonCameraParam
    {
        [FieldOffset(0)]  public CString gazeFrame;
        [FieldOffset(16)] public CString gazeFrameMirror;
        [FieldOffset(32)] public Vector3 gazeOffset;
        [FieldOffset(48)] public float distance;
        [FieldOffset(64)] public Vector3 playerOffset;
        [FieldOffset(80)] public float elevationOffset;
        [FieldOffset(96)] public Vector3 followRate;
    }

    [StructLayout(LayoutKind.Explicit, Size = 272)]
    public struct BossDragonMoveParam
    {
        [FieldOffset(0)]   public unsafe fixed byte /* Vector3[8] */ _playerNodes[128];

        public unsafe Vector3* playerNodes
        {
            get
            {
                fixed (byte* p_playerNodes = _playerNodes)
                    return (Vector3*)p_playerNodes;
            }
        }

        [FieldOffset(128)] public unsafe fixed byte /* Vector3[8] */ _bossNodes[128];

        public unsafe Vector3* bossNodes
        {
            get
            {
                fixed (byte* p_bossNodes = _bossNodes)
                    return (Vector3*)p_bossNodes;
            }
        }

        [FieldOffset(256)] public int playerNodeCount;
        [FieldOffset(260)] public int bossNodeCount;
        [FieldOffset(264)] public float time;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct BossDragonFireBarParam
    {
        [FieldOffset(0)] public float radius;
        [FieldOffset(4)] public float length;
        [FieldOffset(8)] public float rotSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public struct BossDragonEscapeShotParam
    {
        [FieldOffset(0)]  public unsafe fixed uint vertRatio[3];
        [FieldOffset(12)] public float initSpeed;
        [FieldOffset(16)] public float maxSpeed;
        [FieldOffset(20)] public float acc;
        [FieldOffset(24)] public float lifeTime;
    }

    public enum Type : sbyte
{
        None = 0,
        FireBar = 1,
        FireBar4 = 2,
        Spark = 3
    }

    public enum Location : sbyte
{
        Left = 0,
        Center = 1,
        Right = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct BossDragonObstacleParam
    {
        [FieldOffset(0)] public float distance;
        [FieldOffset(4)] public Type type;
        [FieldOffset(5)] public Location location;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct BossDragonHoleParam
    {
        [FieldOffset(0)] public float start;
        [FieldOffset(4)] public float end;
    }

    [StructLayout(LayoutKind.Explicit, Size = 692)]
    public struct BossDragonRoadParam
    {
        [FieldOffset(0)]   public float interval;
        [FieldOffset(4)]   public int recordNum;
        [FieldOffset(8)]   public float width;
        [FieldOffset(12)]  public BossDragonFireBarParam fireBar;
        [FieldOffset(24)]  public BossDragonEscapeShotParam shot;
        [FieldOffset(52)]  public unsafe fixed byte /* BossDragonObstacleParam[64] */ _obstacles[512];

        public unsafe BossDragonObstacleParam* obstacles
        {
            get
            {
                fixed (byte* p_obstacles = _obstacles)
                    return (BossDragonObstacleParam*)p_obstacles;
            }
        }

        [FieldOffset(564)] public unsafe fixed byte /* BossDragonHoleParam[16] */ _holes[128];

        public unsafe BossDragonHoleParam* holes
        {
            get
            {
                fixed (byte* p_holes = _holes)
                    return (BossDragonHoleParam*)p_holes;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 160)]
    public struct BossDragonLaunchParam
    {
        [FieldOffset(0)]   public float outStrength;
        [FieldOffset(4)]   public float inStrength;
        [FieldOffset(8)]   public float outElev;
        [FieldOffset(12)]  public float inElev;
        [FieldOffset(16)]  public float speed;
        [FieldOffset(32)]  public Vector3 targetOffset;
        [FieldOffset(48)]  public float launchCameraInterpolateTime;
        [FieldOffset(64)]  public Vector3 launchCameraPos;
        [FieldOffset(80)]  public Vector3 launchCameraTarget;
        [FieldOffset(96)]  public float launchCameraRoll;
        [FieldOffset(100)] public float launchCameraTime;
        [FieldOffset(104)] public float fallCameraInterpolateTime;
        [FieldOffset(108)] public float fallCameraDistance;
        [FieldOffset(112)] public float fallCameraElavation;
        [FieldOffset(116)] public float landingCameraInterpolateTime;
        [FieldOffset(120)] public float landingCameraDistance;
        [FieldOffset(124)] public float landingCameraElavation;
        [FieldOffset(128)] public float landingCameraAzimuth;
        [FieldOffset(132)] public float landingCameraChangeDistance;
        [FieldOffset(136)] public float landingCameraNearInterpolateTime;
        [FieldOffset(140)] public float landingCameraNearDistance;
        [FieldOffset(144)] public float landingCameraNearElavation;
        [FieldOffset(148)] public float landingCameraNearAzimuth;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct BossDragonQuickStepParam
    {
        [FieldOffset(0)] public float speed;
        [FieldOffset(4)] public float boostSpeed;
        [FieldOffset(8)] public float boostSpeedMax;
    }

    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public struct BossDragonChaseParam
    {
        [FieldOffset(0)]  public float distance;
        [FieldOffset(4)]  public float goalOffset;
        [FieldOffset(8)]  public float speed;
        [FieldOffset(12)] public float boostSpeed;
        [FieldOffset(16)] public float width;
        [FieldOffset(20)] public float height;
        [FieldOffset(24)] public float closeDistance;
        [FieldOffset(28)] public float closeSpeedScale;
        [FieldOffset(32)] public float fastMoveDistance;
        [FieldOffset(36)] public float stunTime;
        [FieldOffset(40)] public float stunSpeedScale;
        [FieldOffset(44)] public float superBoostDelayTime;
        [FieldOffset(48)] public float superBoostTime;
        [FieldOffset(52)] public float superBoostSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct BossDragonMissileIndividualParam
    {
        [FieldOffset(0)]  public bool isValid;
        [FieldOffset(4)]  public float rotForce;
        [FieldOffset(8)]  public float maxRotForce;
        [FieldOffset(12)] public float rotForceSpeed;
        [FieldOffset(16)] public float rotDamper;
        [FieldOffset(20)] public float straightTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public struct BossDragonMissileFirePattern
    {
        [FieldOffset(0)]  public float hpRatioThreshold;
        [FieldOffset(4)]  public int count;
        [FieldOffset(8)]  public float intervalTime;
        [FieldOffset(12)] public float waitTime;
        [FieldOffset(16)] public float badRatio;
    }

    [StructLayout(LayoutKind.Explicit, Size = 760)]
    public struct BossDragonMissileParam
    {
        [FieldOffset(0)]   public float radius;
        [FieldOffset(4)]   public float length;
        [FieldOffset(8)]   public float speed;
        [FieldOffset(12)]  public float maxSpeed;
        [FieldOffset(16)]  public float accel;
        [FieldOffset(20)]  public float lifeTime;
        [FieldOffset(24)]  public unsafe fixed byte /* BossDragonMissileIndividualParam[16] */ _individuals[384];

        public unsafe BossDragonMissileIndividualParam* individuals
        {
            get
            {
                fixed (byte* p_individuals = _individuals)
                    return (BossDragonMissileIndividualParam*)p_individuals;
            }
        }

        [FieldOffset(408)] public unsafe fixed byte /* BossDragonMissileIndividualParam[8] */ _badIndividuals[192];

        public unsafe BossDragonMissileIndividualParam* badIndividuals
        {
            get
            {
                fixed (byte* p_badIndividuals = _badIndividuals)
                    return (BossDragonMissileIndividualParam*)p_badIndividuals;
            }
        }

        [FieldOffset(600)] public unsafe fixed byte /* BossDragonMissileFirePattern[8] */ _firePatterns[160];

        public unsafe BossDragonMissileFirePattern* firePatterns
        {
            get
            {
                fixed (byte* p_firePatterns = _firePatterns)
                    return (BossDragonMissileFirePattern*)p_firePatterns;
            }
        }
    }

    public enum BossDragonSequence : sbyte
{
        NOP = 0,
        BITE = 1,
        LIGHT_SCRATCH = 2,
        SCRATCH = 3,
        SHOOT = 4,
        SHOOT_NORMAL = 5,
        SHOOT_SPIRAL = 6,
        SHOOT_SPIRAL_ALTERNATE = 7,
        SHOOT_SPIRAL_VERTICAL = 8,
        SHOOT_SPLASH = 9,
        SHOOT_HOMING_LASER = 10,
        SHOOT_HOMING_MISSILE = 11,
        SHOOT_RIPPLE_LASER = 12,
        SHOOT_RIPPLE_LASER_RAGE = 13,
        SHOOT_WAVE = 14,
        SHOOT_LASER_WINDER = 15,
        SHOOT_RANDOM_LASER = 16,
        SHOOT_END = 17,
        SWAP_SIDE = 18,
        CHASE = 19
    }

    public enum BossDragonInterrupt : sbyte
{
        BossDragonInterrupt_NOP = 0,
        RAGE = 1,
        SPECIAL_ATTACK = 2,
        SPECIAL_ATTACK2 = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct BossDragonInterruptParam
    {
        [FieldOffset(0)] public float hpRatio;
        [FieldOffset(4)] public BossDragonInterrupt interrupt;
        [FieldOffset(5)] public bool forceInterrupt;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct BossDragonCyloopBindParam
    {
        [FieldOffset(0)] public unsafe fixed float postCameraTime[4];
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct BossDragonParrySlowParam
    {
        [FieldOffset(0)]  public float scale;
        [FieldOffset(4)]  public float time;
        [FieldOffset(8)]  public float easeOutTime;
        [FieldOffset(12)] public bool cameraSlow;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct BossDragonParryParam
    {
        [FieldOffset(0)] public unsafe fixed byte /* BossDragonParrySlowParam[2] */ _slowParams[32];

        public unsafe BossDragonParrySlowParam* slowParams
        {
            get
            {
                fixed (byte* p_slowParams = _slowParams)
                    return (BossDragonParrySlowParam*)p_slowParams;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct BossDragonAttackSignParam
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

    [StructLayout(LayoutKind.Explicit, Size = 6)]
    public struct BossDragonNotifierParam
    {
        [FieldOffset(0)] public EnemyPracticeNotifierConfig notifierConfigClimb;
        [FieldOffset(3)] public EnemyPracticeNotifierConfig notifierConfigBattle;
    }

    [StructLayout(LayoutKind.Explicit, Size = 95632)]
    public struct BossDragonConfig
    {
        [FieldOffset(0)]     public BossBaseConfig bossBaseConfig;
        [FieldOffset(75712)] public float cruisePathSpeed;
        [FieldOffset(75716)] public float patrolPathSpeed;
        [FieldOffset(75720)] public float approachPathSpeedMin;
        [FieldOffset(75724)] public float approachPathSpeedMax;
        [FieldOffset(75728)] public float climbPathSpeed;
        [FieldOffset(75732)] public float pathSpeed;
        [FieldOffset(75736)] public float ringSupplyPathSpeed;
        [FieldOffset(75740)] public float sideDistance;
        [FieldOffset(75744)] public float shootEndTime;
        [FieldOffset(75748)] public int staggerPoint;
        [FieldOffset(75752)] public int staggerPointRage;
        [FieldOffset(75756)] public float staggerTime;
        [FieldOffset(75760)] public float biteParriedTime;
        [FieldOffset(75764)] public float scratchParriedTime;
        [FieldOffset(75768)] public int knockBackStaggerCount;
        [FieldOffset(75772)] public int knockBackPoint;
        [FieldOffset(75776)] public float knockBackTime;
        [FieldOffset(75780)] public float hardStunTime;
        [FieldOffset(75784)] public float cyloopBindTime;
        [FieldOffset(75788)] public float cyloopBind2Time;
        [FieldOffset(75792)] public float cyloopEscapeHpRatio;
        [FieldOffset(75796)] public float cyloopEscapeTime;
        [FieldOffset(75800)] public float fallDeadHeight;
        [FieldOffset(75804)] public int specialAttackDamage;
        [FieldOffset(75808)] public int qte1Damage;
        [FieldOffset(75816)] public unsafe fixed byte /* CString[16] */ _accessNodeNames[4080];

        public unsafe CString* accessNodeNames
        {
            get
            {
                fixed (byte* p_accessNodeNames = _accessNodeNames)
                    return (CString*)p_accessNodeNames;
            }
        }

        [FieldOffset(76080)] public unsafe fixed byte /* BossDragonHitBoxParam[32] */ _hitBoxes[3072];

        public unsafe BossDragonHitBoxParam* hitBoxes
        {
            get
            {
                fixed (byte* p_hitBoxes = _hitBoxes)
                    return (BossDragonHitBoxParam*)p_hitBoxes;
            }
        }

        [FieldOffset(79152)] public unsafe fixed byte /* BossDragonHurtBoxParam[32] */ _hurtBoxes[4608];

        public unsafe BossDragonHurtBoxParam* hurtBoxes
        {
            get
            {
                fixed (byte* p_hurtBoxes = _hurtBoxes)
                    return (BossDragonHurtBoxParam*)p_hurtBoxes;
            }
        }

        [FieldOffset(83760)] public BossDragonScratchParam scratch;
        [FieldOffset(83768)] public BossDragonReflectShotParam reflect;
        [FieldOffset(83808)] public BossDragonShotParam shot;
        [FieldOffset(83840)] public BossDragonSpiralShotParam spiral;
        [FieldOffset(83880)] public BossDragonSpiralShotParam spiralAlternate;
        [FieldOffset(83920)] public BossDragonSpiralShotParam spiralVertical;
        [FieldOffset(83960)] public BossDragonSplashShotParam splash;
        [FieldOffset(84004)] public BossDragonHomingLaserParam homingLaser;
        [FieldOffset(84048)] public BossDragonHomingMissileParam homingMissile;
        [FieldOffset(84088)] public BossDragonRippleLaserParam rippleLaser;
        [FieldOffset(84136)] public BossDragonRippleLaserRageParam rippleLaserRage;
        [FieldOffset(84192)] public BossDragonRippleLaserDummyParam rippleLaserDummy;
        [FieldOffset(84232)] public BossDragonWaveParam wave;
        [FieldOffset(84272)] public BossDragonLaserParam laserWinder;
        [FieldOffset(84308)] public BossDragonLaserParam randomLaser;
        [FieldOffset(84344)] public BossDragonCounterLaserParam counterLaser;
        [FieldOffset(84368)] public BossDragonRingSupplyParam ringSupply;
        [FieldOffset(84432)] public unsafe fixed float damageRates[4];
        [FieldOffset(84448)] public unsafe fixed byte /* BossDragonLayoutParam[46] */ _layouts[3680];

        public unsafe BossDragonLayoutParam* layouts
        {
            get
            {
                fixed (byte* p_layouts = _layouts)
                    return (BossDragonLayoutParam*)p_layouts;
            }
        }

        [FieldOffset(88128)] public unsafe fixed byte /* BossDragonCameraParam[47] */ _cameras[5264];

        public unsafe BossDragonCameraParam* cameras
        {
            get
            {
                fixed (byte* p_cameras = _cameras)
                    return (BossDragonCameraParam*)p_cameras;
            }
        }

        [FieldOffset(93392)] public BossDragonMoveParam swapMove;
        [FieldOffset(93664)] public BossDragonRoadParam road;
        [FieldOffset(94368)] public BossDragonLaunchParam launch;
        [FieldOffset(94528)] public BossDragonQuickStepParam quickStep;
        [FieldOffset(94540)] public BossDragonChaseParam chase;
        [FieldOffset(94596)] public BossDragonMissileParam missile;
        [FieldOffset(95356)] public unsafe fixed byte /* BossDragonSequence[16] */ _seq[16];

        public unsafe BossDragonSequence* seq
        {
            get
            {
                fixed (byte* p_seq = _seq)
                    return (BossDragonSequence*)p_seq;
            }
        }

        [FieldOffset(95372)] public unsafe fixed byte /* BossDragonSequence[16] */ _seq2[16];

        public unsafe BossDragonSequence* seq2
        {
            get
            {
                fixed (byte* p_seq2 = _seq2)
                    return (BossDragonSequence*)p_seq2;
            }
        }

        [FieldOffset(95388)] public unsafe fixed byte /* BossDragonInterruptParam[8] */ _interrupts[64];

        public unsafe BossDragonInterruptParam* interrupts
        {
            get
            {
                fixed (byte* p_interrupts = _interrupts)
                    return (BossDragonInterruptParam*)p_interrupts;
            }
        }

        [FieldOffset(95452)] public BossDragonCyloopBindParam cyloopBind;
        [FieldOffset(95468)] public unsafe fixed byte /* BossDragonParryParam[4] */ _parry[128];

        public unsafe BossDragonParryParam* parry
        {
            get
            {
                fixed (byte* p_parry = _parry)
                    return (BossDragonParryParam*)p_parry;
            }
        }

        [FieldOffset(95596)] public BossDragonAttackSignParam attackSign;
        [FieldOffset(95620)] public BossDragonNotifierParam notifier;
    }

}