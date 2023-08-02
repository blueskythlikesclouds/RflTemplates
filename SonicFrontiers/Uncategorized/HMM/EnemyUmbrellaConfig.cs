Library "EnemyUmbrellaConfig"
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

    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public struct EnemyUmbrellaCommonConfig
    {
        [FieldOffset(0)]  public RingParameter ringParam;
        [FieldOffset(28)] public int codeDropNumMin;
        [FieldOffset(32)] public int codeDropNumMax;
        [FieldOffset(36)] public int codeXDropNumMin;
        [FieldOffset(40)] public int codeXDropNumMax;
        [FieldOffset(44)] public float closeDistance;
        [FieldOffset(48)] public float cameraDistance;
        [FieldOffset(52)] public float cameraElevation;
        [FieldOffset(56)] public float pullStartHeight;
        [FieldOffset(60)] public float pullEndHeight;
    }

    public enum BarrageType : byte
{
        BOX = 0,
        CONE = 1,
        FAN = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public struct UmbrellaCommonLevelConfig
    {
        [FieldOffset(0)]  public int maxHealthPoint;
        [FieldOffset(4)]  public float attackRate;
        [FieldOffset(8)]  public ushort expItemNum;
        [FieldOffset(10)] public ushort exp;
        [FieldOffset(12)] public float backJumpHeight;
        [FieldOffset(16)] public float backJumpDistance;
        [FieldOffset(20)] public float flyingDuration;
        [FieldOffset(24)] public BarrageType barrageType;
        [FieldOffset(28)] public float barrageHeight;
        [FieldOffset(32)] public float barrageWidth;
        [FieldOffset(36)] public float barrageDistance;
        [FieldOffset(40)] public float bombRatio;
        [FieldOffset(44)] public float barrageFallSpeed;
        [FieldOffset(48)] public float barrageLifeTime;
        [FieldOffset(52)] public float barrageLifePassPower;
    }

    [StructLayout(LayoutKind.Explicit, Size = 60)]
    public struct EnemyUmbrellaLevelConfig
    {
        [FieldOffset(0)] public int level;
        [FieldOffset(4)] public UmbrellaCommonLevelConfig common;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct UmbrellaCommonActionConfig
    {
        [FieldOffset(0)] public int dummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct EnemyUmbrellaLevelBandConfig
    {
        [FieldOffset(0)] public int level;
        [FieldOffset(4)] public UmbrellaCommonActionConfig common;
    }

    [StructLayout(LayoutKind.Explicit, Size = 404)]
    public struct EnemyUmbrellaConfig
    {
        [FieldOffset(0)]   public EnemyUmbrellaCommonConfig commonParams;
        [FieldOffset(64)]  public unsafe fixed byte /* EnemyUmbrellaLevelConfig[5] */ _levelParams[300];

        public unsafe EnemyUmbrellaLevelConfig* levelParams
        {
            get
            {
                fixed (byte* p_levelParams = _levelParams)
                    return (EnemyUmbrellaLevelConfig*)p_levelParams;
            }
        }

        [FieldOffset(364)] public unsafe fixed byte /* EnemyUmbrellaLevelBandConfig[5] */ _levelBands[40];

        public unsafe EnemyUmbrellaLevelBandConfig* levelBands
        {
            get
            {
                fixed (byte* p_levelBands = _levelBands)
                    return (EnemyUmbrellaLevelBandConfig*)p_levelBands;
            }
        }
    }

}