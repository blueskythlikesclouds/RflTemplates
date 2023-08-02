Library "EnemyTwisterConfig"
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
    public struct DebrisParameter
    {
        [FieldOffset(0)]  public int m_maxNumPieces;
        [FieldOffset(4)]  public float gravity;
        [FieldOffset(8)]  public float lifeTime;
        [FieldOffset(12)] public float force;
    }

    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public struct EnemyTwisterCommonConfig
    {
        [FieldOffset(0)]  public RingParameter ringParam;
        [FieldOffset(28)] public float rigidColliderRadius;
        [FieldOffset(32)] public float damageColliderRadius;
        [FieldOffset(36)] public float battleDistance;
        [FieldOffset(40)] public float cyloopHeight;
        [FieldOffset(44)] public float rotateSpeed;
        [FieldOffset(48)] public bool useUniqueDebrisSetting;
        [FieldOffset(52)] public DebrisParameter debris;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct TwisterCommonLevelConfig
    {
        [FieldOffset(0)]  public int maxHealthPoint;
        [FieldOffset(4)]  public float attackRate;
        [FieldOffset(8)]  public ushort expItemNum;
        [FieldOffset(10)] public ushort exp;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct EnemyTwisterLevelConfig
    {
        [FieldOffset(0)] public int level;
        [FieldOffset(4)] public TwisterCommonLevelConfig common;
    }

    [StructLayout(LayoutKind.Explicit, Size = 148)]
    public struct EnemyTwisterConfig
    {
        [FieldOffset(0)]  public EnemyTwisterCommonConfig commonParams;
        [FieldOffset(68)] public unsafe fixed byte /* EnemyTwisterLevelConfig[5] */ _levelParams[80];

        public unsafe EnemyTwisterLevelConfig* levelParams
        {
            get
            {
                fixed (byte* p_levelParams = _levelParams)
                    return (EnemyTwisterLevelConfig*)p_levelParams;
            }
        }
    }

}