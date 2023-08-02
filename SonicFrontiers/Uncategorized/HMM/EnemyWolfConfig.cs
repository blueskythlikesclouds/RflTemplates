Library "EnemyWolfConfig"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

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

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct WolfMovementParam
    {
        [FieldOffset(0)]  public float rotateSpeedMin;
        [FieldOffset(4)]  public float rotateSpeedMax;
        [FieldOffset(8)]  public float rotateSpeedMaxSpeedMin;
        [FieldOffset(12)] public float rotateSpeedMinSpeedMax;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct WolfEyesightParam
    {
        [FieldOffset(0)] public float distance;
        [FieldOffset(4)] public float angle;
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

    public enum WolfVolumeShape : sbyte
{
        SPHERE = 0,
        BOX = 1,
        CYLINDER = 2,
        CAPSULE = 3,
        NUM = 4
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct WolfVolumeInfo
    {
        [FieldOffset(0)]  public Vector3 volumeSize;
        [FieldOffset(16)] public Vector3 volumeOffset;
        [FieldOffset(32)] public Vector3 volumeRotation;
    }

    [StructLayout(LayoutKind.Explicit, Size = 112)]
    public struct WolfMappingPairInfo
    {
        [FieldOffset(0)]  public CString tagName;
        [FieldOffset(16)] public sbyte pieceNum;
        [FieldOffset(20)] public float pieceFuncFactor;
        [FieldOffset(24)] public WolfVolumeShape volumeShape;
        [FieldOffset(32)] public CString wolfNodeName;
        [FieldOffset(48)] public WolfVolumeInfo wolfVolume;
        [FieldOffset(96)] public bool effectActive;
        [FieldOffset(97)] public bool debugDraw;
        [FieldOffset(98)] public bool debugDrawVolumeAxis;
        [FieldOffset(99)] public bool debugDrawAxis;
    }

    [StructLayout(LayoutKind.Explicit, Size = 3680)]
    public struct EnemyWolfCommonParam
    {
        [FieldOffset(0)]  public RingParameter ringParam;
        [FieldOffset(28)] public WolfMovementParam movement;
        [FieldOffset(44)] public WolfEyesightParam eyesight;
        [FieldOffset(52)] public float killWaitTime;
        [FieldOffset(56)] public float blockColliderRadius;
        [FieldOffset(60)] public float blockColliderHeight;
        [FieldOffset(64)] public float damageColliderRadius;
        [FieldOffset(68)] public float damageColliderHeight;
        [FieldOffset(72)] public float eyesightDistance;
        [FieldOffset(80)] public Vector3 cursorOffset;
        [FieldOffset(96)] public unsafe fixed byte /* WolfMappingPairInfo[32] */ _mappingPairInfo[3584];

        public unsafe WolfMappingPairInfo* mappingPairInfo
        {
            get
            {
                fixed (byte* p_mappingPairInfo = _mappingPairInfo)
                    return (WolfMappingPairInfo*)p_mappingPairInfo;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct EnemyWolfCommonLevelParam
    {
        [FieldOffset(0)]  public int maxHealthPoint;
        [FieldOffset(4)]  public float attackRate;
        [FieldOffset(8)]  public ushort expItemNum;
        [FieldOffset(10)] public ushort exp;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct EnemyWolfLevelParam
    {
        [FieldOffset(0)] public int level;
        [FieldOffset(4)] public EnemyWolfCommonLevelParam common;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct EnemyWolfLevelBand
    {
        [FieldOffset(0)] public int level;
    }

    [StructLayout(LayoutKind.Explicit, Size = 3792)]
    public struct EnemyWolfConfig
    {
        [FieldOffset(0)]    public EnemyWolfCommonParam commonParam;
        [FieldOffset(3680)] public unsafe fixed byte /* EnemyWolfLevelParam[5] */ _levelParams[80];

        public unsafe EnemyWolfLevelParam* levelParams
        {
            get
            {
                fixed (byte* p_levelParams = _levelParams)
                    return (EnemyWolfLevelParam*)p_levelParams;
            }
        }

        [FieldOffset(3760)] public unsafe fixed byte /* EnemyWolfLevelBand[5] */ _levelBand[20];

        public unsafe EnemyWolfLevelBand* levelBand
        {
            get
            {
                fixed (byte* p_levelBand = _levelBand)
                    return (EnemyWolfLevelBand*)p_levelBand;
            }
        }
    }

}