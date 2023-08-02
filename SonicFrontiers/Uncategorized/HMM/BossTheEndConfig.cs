Library "BossTheEndConfig"
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
    public struct LaserTargetConfig
    {
        [FieldOffset(0)] public float scale;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct SerifConfig
    {
        [FieldOffset(0)]  public bool useHpBorder;
        [FieldOffset(4)]  public float hpBorder;
        [FieldOffset(8)]  public bool useWaveId;
        [FieldOffset(9)]  public byte waveId;
        [FieldOffset(12)] public float delayTime;
        [FieldOffset(16)] public CString voice;
    }

    [StructLayout(LayoutKind.Explicit, Size = 3)]
    public struct EnemyPracticeNotifierConfig
    {
        [FieldOffset(0)] public bool usePracticeNotifier;
        [FieldOffset(1)] public sbyte practiceNo;
        [FieldOffset(2)] public sbyte tipsNo;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct NotifierConfig
    {
        [FieldOffset(0)] public byte waveId;
        [FieldOffset(1)] public EnemyPracticeNotifierConfig practiceNotifierConfig;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct UIConfig
    {
        [FieldOffset(0)] public float borderLifeRatio;
        [FieldOffset(4)] public float sonicDamageRatio;
    }

    [StructLayout(LayoutKind.Explicit, Size = 76576)]
    public struct BossTheEndConfig
    {
        [FieldOffset(0)]     public BossBaseConfig bossBaseConfig;
        [FieldOffset(75712)] public LaserTargetConfig target;
        [FieldOffset(75720)] public unsafe fixed byte /* SerifConfig[26] */ _serifConfigs[832];

        public unsafe SerifConfig* serifConfigs
        {
            get
            {
                fixed (byte* p_serifConfigs = _serifConfigs)
                    return (SerifConfig*)p_serifConfigs;
            }
        }

        [FieldOffset(76552)] public NotifierConfig notifierConfigStart;
        [FieldOffset(76556)] public NotifierConfig notifierConfigLaser;
        [FieldOffset(76560)] public UIConfig uiConfig;
    }

}