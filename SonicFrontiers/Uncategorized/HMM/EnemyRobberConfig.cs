Library "EnemyRobberConfig"
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

    [StructLayout(LayoutKind.Explicit, Size = 60)]
    public struct EnemyRobberCommonConfig
    {
        [FieldOffset(0)]  public RingParameter ringParam;
        [FieldOffset(28)] public float eyesightDistance;
        [FieldOffset(32)] public float idlingSpeed;
        [FieldOffset(36)] public float chasingSpeed;
        [FieldOffset(40)] public float escapeSpeed;
        [FieldOffset(44)] public float escapeSpeedPlayerOnPath;
        [FieldOffset(48)] public float onBoardSpeed;
        [FieldOffset(52)] public float restTime;
        [FieldOffset(56)] public float railMaxLength;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct RobbberCommonLevelConfig
    {
        [FieldOffset(0)]  public int maxHealthPoint;
        [FieldOffset(4)]  public float attackRate;
        [FieldOffset(8)]  public ushort expItemNum;
        [FieldOffset(10)] public ushort exp;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct EnemyRobberLevelConfig
    {
        [FieldOffset(0)] public int level;
        [FieldOffset(4)] public RobbberCommonLevelConfig common;
    }

    [StructLayout(LayoutKind.Explicit, Size = 140)]
    public struct EnemyRobberConfig
    {
        [FieldOffset(0)]  public EnemyRobberCommonConfig commonParams;
        [FieldOffset(60)] public unsafe fixed byte /* EnemyRobberLevelConfig[5] */ _levelParams[80];

        public unsafe EnemyRobberLevelConfig* levelParams
        {
            get
            {
                fixed (byte* p_levelParams = _levelParams)
                    return (EnemyRobberLevelConfig*)p_levelParams;
            }
        }
    }

}