Library "EnemyAquaballConfig"
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

    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public struct EnemyAquaballPatrolConfig
    {
        [FieldOffset(0)]  public float rotateSpeedMin;
        [FieldOffset(4)]  public float rotateSpeedMax;
        [FieldOffset(8)]  public float speedMin;
        [FieldOffset(12)] public float speedMax;
        [FieldOffset(16)] public float moveSpeed;
        [FieldOffset(20)] public float bounceHeight;
        [FieldOffset(24)] public float bounceInterval;
        [FieldOffset(28)] public float movePointUpdateInterval;
        [FieldOffset(32)] public float addForceOfHA;
    }

    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public struct EnemyAquaballActionConfig
    {
        [FieldOffset(0)]  public int maxSuccessCount;
        [FieldOffset(4)] public unsafe fixed byte /* Vector2[3] */ _bounceSuccessTiming[3];

        public unsafe Vector2* bounceSuccessTiming
        {
            get
            {
                fixed (byte* p_bounceSuccessTiming = _bounceSuccessTiming)
                    return (Vector2*)p_bounceSuccessTiming;
            }
        }

        [FieldOffset(28)] public float captureLimitTime;
        [FieldOffset(32)] public float captureLimitHeight;
        [FieldOffset(36)] public float failLimitTime;
        [FieldOffset(40)] public float failNoticeTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 136)]
    public struct EnemyAquaballCommonParam
    {
        [FieldOffset(0)]  public float killWaitTime;
        [FieldOffset(4)]  public float colliderRadius;
        [FieldOffset(8)]  public float colliderHeight;
        [FieldOffset(12)] public float damageColliderRadiusOffset;
        [FieldOffset(16)] public float hitPlayerColliderRadiusOffset;
        [FieldOffset(20)] public float checkBarrierDistance;
        [FieldOffset(24)] public float battleDistance;
        [FieldOffset(28)] public RingParameter ringParam;
        [FieldOffset(56)] public EnemyAquaballPatrolConfig patrolConfig;
        [FieldOffset(92)] public EnemyAquaballActionConfig actionConfig;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct EnemyAquaballCommonLevelParam
    {
        [FieldOffset(0)]  public int maxHealthPoint;
        [FieldOffset(4)]  public float attackRate;
        [FieldOffset(8)]  public ushort expItemNum;
        [FieldOffset(10)] public ushort exp;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct EnemyAquaballLevelParam
    {
        [FieldOffset(0)] public int level;
        [FieldOffset(4)] public EnemyAquaballCommonLevelParam common;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct EnemyAquaballLevelBand
    {
        [FieldOffset(0)] public int level;
    }

    [StructLayout(LayoutKind.Explicit, Size = 236)]
    public struct EnemyAquaballConfig
    {
        [FieldOffset(0)]   public EnemyAquaballCommonParam commonParam;
        [FieldOffset(136)] public unsafe fixed byte /* EnemyAquaballLevelParam[5] */ _levelParams[80];

        public unsafe EnemyAquaballLevelParam* levelParams
        {
            get
            {
                fixed (byte* p_levelParams = _levelParams)
                    return (EnemyAquaballLevelParam*)p_levelParams;
            }
        }

        [FieldOffset(216)] public unsafe fixed byte /* EnemyAquaballLevelBand[5] */ _levelBand[20];

        public unsafe EnemyAquaballLevelBand* levelBand
        {
            get
            {
                fixed (byte* p_levelBand = _levelBand)
                    return (EnemyAquaballLevelBand*)p_levelBand;
            }
        }
    }

}