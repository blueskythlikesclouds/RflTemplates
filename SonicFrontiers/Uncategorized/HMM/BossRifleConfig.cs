Library "BossRifleConfig"
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

    public enum ActionType : sbyte
{
        ActionType_AT_NONE = 0,
        AT_HAND_L = 1,
        AT_HAND_R = 2,
        AT_SHOT1 = 3,
        AT_SHOT2 = 4,
        AT_SHOT3 = 5,
        AT_SHOT4 = 6,
        AT_QTE_NONE = 7,
        AT_WAIT = 8,
        AT_LASER = 9,
        AT_HOMINGLASER_NORMAL = 10,
        AT_HOMINGLASER_FLY = 11,
        AT_BIT_WAVE = 12,
        AT_BIT_WAVE_END = 13,
        AT_COUNTER_BLOW = 14,
        AT_SP01 = 15,
        AT_SP02 = 16,
        NUM_ACTION_TYPE = 17
    }

    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public struct BossRifleAttackData
    {
        [FieldOffset(0)]  public ActionType attackType;
        [FieldOffset(8)]  public CString waveName;
        [FieldOffset(24)] public CString subWaveName;
        [FieldOffset(40)] public float actionTime;
        [FieldOffset(44)] public short nextStep;
        [FieldOffset(46)] public bool isBitActionReset;
        [FieldOffset(47)] public bool isFlyMoveReverse;
        [FieldOffset(48)] public bool isFlyWait;
    }

    [StructLayout(LayoutKind.Explicit, Size = 1016)]
    public struct BossRifleAttackPatternParam
    {
        [FieldOffset(0)]    public unsafe fixed byte /* BossRifleAttackData[16] */ _attackDatas[896];

        public unsafe BossRifleAttackData* attackDatas
        {
            get
            {
                fixed (byte* p_attackDatas = _attackDatas)
                    return (BossRifleAttackData*)p_attackDatas;
            }
        }

        [FieldOffset(896)]  public unsafe fixed byte /* BossRifleAttackData[2] */ _bitBreakAttackDatas[112];

        public unsafe BossRifleAttackData* bitBreakAttackDatas
        {
            get
            {
                fixed (byte* p_bitBreakAttackDatas = _bitBreakAttackDatas)
                    return (BossRifleAttackData*)p_bitBreakAttackDatas;
            }
        }

        [FieldOffset(1008)] public uint breakBitNum;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4096)]
    public struct BossRiflePhaseParam
    {
        [FieldOffset(0)]    public float attackWaitTime;
        [FieldOffset(4)]    public float attackSpeedRatio;
        [FieldOffset(8)]    public uint knockbackCountMax;
        [FieldOffset(16)]   public unsafe fixed byte /* BossRifleAttackPatternParam[4] */ _patterns[4064];

        public unsafe BossRifleAttackPatternParam* patterns
        {
            get
            {
                fixed (byte* p_patterns = _patterns)
                    return (BossRifleAttackPatternParam*)p_patterns;
            }
        }

        [FieldOffset(4080)] public unsafe fixed float patternChangeHpRatios[4];
    }

    public enum ActionAttribute : sbyte
{
        AA_NONE = 0,
        AA_ALL = 1,
        AA_FRONT = 2,
        AA_BACK = 3,
        AA_LEFT = 4,
        AA_RIGHT = 5
    }

    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public struct BossRiflePhaseAttackActionParam
    {
        [FieldOffset(0)]  public ActionAttribute attribute1;
        [FieldOffset(1)]  public ActionAttribute attribute2;
        [FieldOffset(4)]  public float useDistanceMin;
        [FieldOffset(8)]  public float useDistanceMax;
        [FieldOffset(12)] public float useHeightMin;
        [FieldOffset(16)] public float useHeightMax;
        [FieldOffset(20)] public float useAngleMin;
        [FieldOffset(24)] public float useAngleMax;
        [FieldOffset(28)] public float useAbsAngleOver;
        [FieldOffset(32)] public float useHpRatioMin;
        [FieldOffset(36)] public float useHpRatioMax;
        [FieldOffset(40)] public float useAreaOver;
        [FieldOffset(44)] public uint priority;
        [FieldOffset(48)] public float coolTime;
        [FieldOffset(52)] public float initCoolTime;
        [FieldOffset(56)] public float readyTime;
        [FieldOffset(60)] public uint consecutiveUsesLimit;
        [FieldOffset(64)] public float consecutiveUsesLimitCoolTime;
        [FieldOffset(68)] public bool isCounterUse;
        [FieldOffset(69)] public bool isCounterOnly;
    }

    public enum BossRifleBattleParam_ActionType : sbyte
{
        BossRifleBattleParam_ActionType_AT_NONE = 0,
        BossRifleBattleParam_ActionType_AT_HAND_L = 1,
        BossRifleBattleParam_ActionType_AT_HAND_R = 2,
        BossRifleBattleParam_ActionType_AT_SHOT1 = 3,
        BossRifleBattleParam_ActionType_AT_SHOT2 = 4,
        BossRifleBattleParam_ActionType_AT_SHOT3 = 5,
        BossRifleBattleParam_ActionType_AT_SHOT4 = 6,
        BossRifleBattleParam_ActionType_AT_QTE_NONE = 7,
        BossRifleBattleParam_ActionType_AT_WAIT = 8,
        BossRifleBattleParam_ActionType_AT_LASER = 9,
        BossRifleBattleParam_ActionType_AT_HOMINGLASER_NORMAL = 10,
        BossRifleBattleParam_ActionType_AT_HOMINGLASER_FLY = 11,
        BossRifleBattleParam_ActionType_AT_BIT_WAVE = 12,
        BossRifleBattleParam_ActionType_AT_BIT_WAVE_END = 13,
        BossRifleBattleParam_ActionType_AT_COUNTER_BLOW = 14,
        BossRifleBattleParam_ActionType_AT_SP01 = 15,
        BossRifleBattleParam_ActionType_AT_SP02 = 16,
        BossRifleBattleParam_ActionType_NUM_ACTION_TYPE = 17
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct BossRifleCyloopFloatActionParam
    {
        [FieldOffset(0)] public float landingCounterHPRatio;
        [FieldOffset(4)] public float floatCounterHPRatio;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct BossRifleBattleAttackHomingLaserShotPoint
    {
        [FieldOffset(0)] public bool isParry;
        [FieldOffset(1)] public bool isUse;
        [FieldOffset(4)] public float shotDirElevation;
        [FieldOffset(8)] public float shotDirRoll;
    }

    [StructLayout(LayoutKind.Explicit, Size = 624)]
    public struct BossRifleBattleAttackHomingLaserAttackParam
    {
        [FieldOffset(0)]   public CString nodeName;
        [FieldOffset(16)]  public Vector3 nodePos;
        [FieldOffset(32)]  public Vector3 nodeFront;
        [FieldOffset(48)]  public Vector3 nodeAxis;
        [FieldOffset(64)]  public float straightKeepTime;
        [FieldOffset(68)]  public uint parryMax;
        [FieldOffset(72)]  public uint num;
        [FieldOffset(76)]  public uint countMax;
        [FieldOffset(80)]  public float initSpeed;
        [FieldOffset(84)]  public float speed;
        [FieldOffset(88)]  public float acceleDelay;
        [FieldOffset(92)]  public float acceleTime;
        [FieldOffset(96)]  public float interval;
        [FieldOffset(100)] public unsafe fixed float intervals[8];
        [FieldOffset(132)] public float delay;
        [FieldOffset(136)] public unsafe fixed byte /* BossRifleBattleAttackHomingLaserShotPoint[32] */ _points[384];

        public unsafe BossRifleBattleAttackHomingLaserShotPoint* points
        {
            get
            {
                fixed (byte* p_points = _points)
                    return (BossRifleBattleAttackHomingLaserShotPoint*)p_points;
            }
        }

        [FieldOffset(528)] public Vector3 fixedCameraEyePos;
        [FieldOffset(544)] public Vector3 fixedCameraLookAtPos;
        [FieldOffset(560)] public float fixedCameraDelay;
        [FieldOffset(564)] public float fixedCameraTime;
        [FieldOffset(568)] public float fixedCameraStartEaseTime;
        [FieldOffset(572)] public float fixedCameraEndEaseTime;
        [FieldOffset(576)] public Vector3 parryCameraEyePos;
        [FieldOffset(592)] public Vector3 parryCameraLookAtPos;
        [FieldOffset(608)] public float parryCameraStartEaseTime;
        [FieldOffset(612)] public float parryCameraEndEaseTime;
        [FieldOffset(616)] public bool isParrySlow;
    }

    [StructLayout(LayoutKind.Explicit, Size = 1904)]
    public struct BossRifleBattleAttackHomingLaser
    {
        [FieldOffset(0)]    public float bulletScale;
        [FieldOffset(4)]    public float parryMoveTime;
        [FieldOffset(16)]   public BossRifleBattleAttackHomingLaserAttackParam headShotParam;
        [FieldOffset(640)]  public BossRifleBattleAttackHomingLaserAttackParam headShotFlyParam;
        [FieldOffset(1264)] public BossRifleBattleAttackHomingLaserAttackParam normalShotParam;
        [FieldOffset(1888)] public bool isDebugDraw;
    }

    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public struct BossRifleBattleAttackHandLaserPatternParam
    {
        [FieldOffset(0)]  public float intarvalDistance;
        [FieldOffset(4)]  public float delay;
        [FieldOffset(16)] public Vector3 localStartPos;
        [FieldOffset(32)] public Vector3 localEndPos;
        [FieldOffset(48)] public Vector3 localStartDir;
        [FieldOffset(64)] public Vector3 localEndDir;
    }

    [StructLayout(LayoutKind.Explicit, Size = 672)]
    public struct BossRifleBattleAttackHandLaser
    {
        [FieldOffset(0)]   public float bulletRadius;
        [FieldOffset(4)]   public float bulletSpeed;
        [FieldOffset(8)]   public float wayAngle;
        [FieldOffset(12)]  public uint wayNum;
        [FieldOffset(16)]  public float limitDistance;
        [FieldOffset(20)]  public float blowoffSpeed;
        [FieldOffset(24)]  public float outOfControlTime;
        [FieldOffset(28)]  public float keepVelocity;
        [FieldOffset(32)]  public unsafe fixed byte /* BossRifleBattleAttackHandLaserPatternParam[4] */ _handLeftPatterns[320];

        public unsafe BossRifleBattleAttackHandLaserPatternParam* handLeftPatterns
        {
            get
            {
                fixed (byte* p_handLeftPatterns = _handLeftPatterns)
                    return (BossRifleBattleAttackHandLaserPatternParam*)p_handLeftPatterns;
            }
        }

        [FieldOffset(352)] public unsafe fixed byte /* BossRifleBattleAttackHandLaserPatternParam[4] */ _handRightPatterns[320];

        public unsafe BossRifleBattleAttackHandLaserPatternParam* handRightPatterns
        {
            get
            {
                fixed (byte* p_handRightPatterns = _handRightPatterns)
                    return (BossRifleBattleAttackHandLaserPatternParam*)p_handRightPatterns;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct BossRifleBattleFlyParam
    {
        [FieldOffset(0)]  public float flyHeight;
        [FieldOffset(4)]  public float flyRotationSpeed;
        [FieldOffset(8)]  public float flyMoveHitDamageDownSpeedRatio;
        [FieldOffset(12)] public float flyMoveHitDamageDownSpeedTime;
        [FieldOffset(16)] public float flyMoveSpeed;
        [FieldOffset(20)] public float flyMoveCircleRadius;
    }

    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public struct BossRifleBattleZoomCamera
    {
        [FieldOffset(0)]  public float distance;
        [FieldOffset(4)]  public float elevation;
        [FieldOffset(8)]  public float playerHeight;
        [FieldOffset(12)] public float easeInTime;
        [FieldOffset(16)] public float easeOutTime;
        [FieldOffset(20)] public float changeParamDistanceMin;
        [FieldOffset(24)] public float changeParamDistanceMax;
        [FieldOffset(28)] public float addDistance;
        [FieldOffset(32)] public float addElevation;
        [FieldOffset(36)] public float addPlayerHeight;
    }

    [StructLayout(LayoutKind.Explicit, Size = 160)]
    public struct BossRifleBattleCameraParam
    {
        [FieldOffset(0)]  public unsafe fixed byte /* BossRifleBattleZoomCamera[2] */ _normalCamera[80];

        public unsafe BossRifleBattleZoomCamera* normalCamera
        {
            get
            {
                fixed (byte* p_normalCamera = _normalCamera)
                    return (BossRifleBattleZoomCamera*)p_normalCamera;
            }
        }

        [FieldOffset(80)] public unsafe fixed byte /* BossRifleBattleZoomCamera[2] */ _flyCamera[80];

        public unsafe BossRifleBattleZoomCamera* flyCamera
        {
            get
            {
                fixed (byte* p_flyCamera = _flyCamera)
                    return (BossRifleBattleZoomCamera*)p_flyCamera;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct BossRifleParrySlowParam
    {
        [FieldOffset(0)]  public float scale;
        [FieldOffset(4)]  public float time;
        [FieldOffset(8)]  public float easeOutTime;
        [FieldOffset(12)] public bool cameraSlow;
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct BossRifleParryParam
    {
        [FieldOffset(0)]  public BossRifleParrySlowParam homingLaserParrySlow;
        [FieldOffset(16)] public BossRifleParrySlowParam homingLaserLastParrySlow;
        [FieldOffset(32)] public BossRifleParrySlowParam homingLaserOneShotParrySlow;
    }

    [StructLayout(LayoutKind.Explicit, Size = 20416)]
    public struct BossRifleBattleParam
    {
        [FieldOffset(0)]     public unsafe fixed byte /* BossRiflePhaseParam[4] */ _giantPhaseParams[16384];

        public unsafe BossRiflePhaseParam* giantPhaseParams
        {
            get
            {
                fixed (byte* p_giantPhaseParams = _giantPhaseParams)
                    return (BossRiflePhaseParam*)p_giantPhaseParams;
            }
        }

        [FieldOffset(16384)] public unsafe fixed byte /* BossRiflePhaseAttackActionParam[16] */ _actionParams[1152];

        public unsafe BossRiflePhaseAttackActionParam* actionParams
        {
            get
            {
                fixed (byte* p_actionParams = _actionParams)
                    return (BossRiflePhaseAttackActionParam*)p_actionParams;
            }
        }

        [FieldOffset(17536)] public unsafe fixed byte /* BossRifleBattleParam_ActionType[20] */ _immediateActions[20];

        public unsafe BossRifleBattleParam_ActionType* immediateActions
        {
            get
            {
                fixed (byte* p_immediateActions = _immediateActions)
                    return (BossRifleBattleParam_ActionType*)p_immediateActions;
            }
        }

        [FieldOffset(17556)] public BossRifleCyloopFloatActionParam cyloopFloatAction;
        [FieldOffset(17568)] public BossRifleBattleAttackHomingLaser attackHomingLaser;
        [FieldOffset(19472)] public BossRifleBattleAttackHandLaser attackHandLaser;
        [FieldOffset(20144)] public BossRifleBattleFlyParam flyParam;
        [FieldOffset(20168)] public BossRifleBattleCameraParam cameraParam;
        [FieldOffset(20328)] public BossRifleParryParam parryParam;
        [FieldOffset(20376)] public unsafe fixed float thresholdDamageEffectHPRatio[3];
        [FieldOffset(20388)] public unsafe fixed float qteSucceedWaitTimes[4];
        [FieldOffset(20404)] public bool isDebugDraw;
        [FieldOffset(20405)] public bool isSkip;
    }

    [StructLayout(LayoutKind.Explicit, Size = 3)]
    public struct EnemyPracticeNotifierConfig
    {
        [FieldOffset(0)] public bool usePracticeNotifier;
        [FieldOffset(1)] public sbyte practiceNo;
        [FieldOffset(2)] public sbyte tipsNo;
    }

    [StructLayout(LayoutKind.Explicit, Size = 6)]
    public struct BossRifleNotifierParam
    {
        [FieldOffset(0)] public EnemyPracticeNotifierConfig notifierConfigBattle1;
        [FieldOffset(3)] public EnemyPracticeNotifierConfig notifierConfigBattle2;
    }

    [StructLayout(LayoutKind.Explicit, Size = 96144)]
    public struct BossRifleConfig
    {
        [FieldOffset(0)]     public BossBaseConfig bossBaseConfig;
        [FieldOffset(75712)] public BossRifleBattleParam battleParam;
        [FieldOffset(96128)] public BossRifleNotifierParam notifierParam;
    }

}