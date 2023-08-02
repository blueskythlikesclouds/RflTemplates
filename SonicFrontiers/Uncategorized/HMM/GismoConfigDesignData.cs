Library "GismoConfigDesignData"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

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

    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public struct GismoBasicParam
    {
        [FieldOffset(0)]  public CString modelName;
        [FieldOffset(16)] public CString skeltonName;
        [FieldOffset(32)] public bool noInstance;
    }

    public enum ShapeType : sbyte
{
        SHAPE_BOX = 0,
        SHAPE_SPHERE = 1,
        SHAPE_CAPSULE = 2,
        SHAPE_CYLINDER = 3,
        SHAPE_MESH = 4,
        SHAPE_NONE = 5
    }

    public enum BasePoint : sbyte
{
        BASE_CENTER = 0,
        BASE_Z_PLANE = 1,
        BASE_X_PLANE = 2,
        BASE_Y_PLANE = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public struct GismoCollision
    {
        [FieldOffset(0)]  public ShapeType shape;
        [FieldOffset(1)]  public BasePoint basePoint;
        [FieldOffset(4)]  public float width;
        [FieldOffset(8)]  public float height;
        [FieldOffset(12)] public float depth;
        [FieldOffset(16)] public CString meshName;
        [FieldOffset(32)] public Vector3 shapeOffset;
        [FieldOffset(48)] public float shapeSizeOffset;
    }

    public enum RigidBodyType : sbyte
{
        RIGID_BODY_NONE = 0,
        RIGID_BODY_STATIC = 1,
        RIGID_BODY_DYNAMIC = 2
    }

    public enum RigidBodyMaterial : sbyte
{
        RIGID_BODY_MAT_NONE = 0,
        RIGID_BODY_MAT_WOOD = 1,
        RIGID_BODY_MAT_IRON = 2,
        NUM_RIGID_BODY_MATS = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public struct PhysicsParam
    {
        [FieldOffset(0)]  public float mass;
        [FieldOffset(4)]  public float friction;
        [FieldOffset(8)]  public float gravityFactor;
        [FieldOffset(12)] public float restitution;
        [FieldOffset(16)] public float linearDamping;
        [FieldOffset(20)] public float angularDamping;
        [FieldOffset(24)] public float maxLinearVelocity;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct GismoRegidBody
    {
        [FieldOffset(0)] public RigidBodyType rigidBodyType;
        [FieldOffset(1)] public RigidBodyMaterial rigidBodyMaterial;
        [FieldOffset(4)] public PhysicsParam physicsParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct MotionData
    {
        [FieldOffset(0)]  public CString motionName;
        [FieldOffset(16)] public bool syncFrame;
        [FieldOffset(17)] public bool stopEndFrame;
    }

    [StructLayout(LayoutKind.Explicit, Size = 144)]
    public struct MirageAnimData
    {
        [FieldOffset(0)]  public unsafe fixed byte /* CString[3] */ _texSrtAnimName[765];

        public unsafe CString* texSrtAnimName
        {
            get
            {
                fixed (byte* p_texSrtAnimName = _texSrtAnimName)
                    return (CString*)p_texSrtAnimName;
            }
        }

        [FieldOffset(48)] public unsafe fixed byte /* CString[3] */ _texPatAnimName[765];

        public unsafe CString* texPatAnimName
        {
            get
            {
                fixed (byte* p_texPatAnimName = _texPatAnimName)
                    return (CString*)p_texPatAnimName;
            }
        }

        [FieldOffset(96)] public unsafe fixed byte /* CString[3] */ _matAnimName[765];

        public unsafe CString* matAnimName
        {
            get
            {
                fixed (byte* p_matAnimName = _matAnimName)
                    return (CString*)p_matAnimName;
            }
        }
    }

    public enum MotionType : byte
{
        MOTION_SWING = 0,
        MOTION_ROTATE = 1,
        MOTION_LINEAR_SWING = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct ProgramMotionData
    {
        [FieldOffset(0)]  public MotionType motionType;
        [FieldOffset(16)] public Vector3 axis;
        [FieldOffset(32)] public float power;
        [FieldOffset(36)] public float speedScale;
        [FieldOffset(40)] public float time;
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct EffectData
    {
        [FieldOffset(0)]  public CString effectName;
        [FieldOffset(16)] public bool linkMotionStop;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct SoundData
    {
        [FieldOffset(0)] public CString cueName;
    }

    public enum KillType : sbyte
{
        KILL_TYPE_NOT_KILL = 0,
        KILL_TYPE_KILL = 1,
        KILL_TYPE_BREAK = 2,
        KILL_TYPE_MOTION = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct DebrisData
    {
        [FieldOffset(0)]  public float gravity;
        [FieldOffset(4)]  public float lifeTime;
        [FieldOffset(8)]  public float mass;
        [FieldOffset(12)] public float friction;
        [FieldOffset(16)] public float explosionScale;
        [FieldOffset(20)] public float impulseScale;
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct KillData
    {
        [FieldOffset(0)]  public KillType killType;
        [FieldOffset(4)]  public float killTime;
        [FieldOffset(8)]  public CString breakMotionName;
        [FieldOffset(24)] public DebrisData debrisData;
    }

    [StructLayout(LayoutKind.Explicit, Size = 320)]
    public struct ReactionData
    {
        [FieldOffset(0)]   public MotionData motionData;
        [FieldOffset(24)]  public MirageAnimData mirageAnimData;
        [FieldOffset(176)] public ProgramMotionData programMotionData;
        [FieldOffset(224)] public EffectData effectData;
        [FieldOffset(248)] public SoundData soundData;
        [FieldOffset(264)] public KillData killData;
    }

    [StructLayout(LayoutKind.Explicit, Size = 2080)]
    public struct GismoConfigDesignData
    {
        [FieldOffset(0)]    public float rangeIn;
        [FieldOffset(4)]    public float rangeDistance;
        [FieldOffset(8)]    public GismoBasicParam basicParam;
        [FieldOffset(48)]   public GismoCollision collision;
        [FieldOffset(112)]  public GismoRegidBody rigidBody;
        [FieldOffset(144)]  public ReactionData reactionIdle;
        [FieldOffset(464)]  public ReactionData reactionEnter;
        [FieldOffset(784)]  public ReactionData reactionLeave;
        [FieldOffset(1104)] public ReactionData reactionStay;
        [FieldOffset(1424)] public ReactionData reactionStayMove;
        [FieldOffset(1744)] public ReactionData reactionDamage;
        [FieldOffset(2064)] public bool ignoreMeteorShowerAndRespawnOnReenterRange;
    }

}