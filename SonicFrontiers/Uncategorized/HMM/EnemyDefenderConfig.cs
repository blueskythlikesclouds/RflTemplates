Library "EnemyDefenderConfig"
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

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct EnemyDefenderPatrolConfig
    {
        [FieldOffset(0)] public float changeTimeIdlePatrolMin;
        [FieldOffset(4)] public float changeTimeIdlePatrolMax;
    }

    [StructLayout(LayoutKind.Explicit, Size = 128)]
    public struct EnemyDefenderCommonConfig
    {
        [FieldOffset(0)]   public RingParameter ringParam;
        [FieldOffset(28)]  public float mass;
        [FieldOffset(32)]  public float slopeAngleMax;
        [FieldOffset(36)]  public float checkBarrierDistance;
        [FieldOffset(40)]  public float colliderRadius;
        [FieldOffset(44)]  public float colliderHeight;
        [FieldOffset(48)]  public float damageColliderRadiusOffset;
        [FieldOffset(52)]  public float boomerangColliderRadius;
        [FieldOffset(56)]  public float boomerangColliderHeight;
        [FieldOffset(60)]  public float boomerangColliderOffset;
        [FieldOffset(64)]  public float boomerangCameraKeepTimeMin;
        [FieldOffset(68)]  public float eyesightDistance;
        [FieldOffset(72)]  public float eyesightLostDelayTime;
        [FieldOffset(76)]  public EnemyDefenderPatrolConfig patrolConfig;
        [FieldOffset(84)]  public float shieldBlowUpTime;
        [FieldOffset(88)]  public float shieldBlowUpHeight;
        [FieldOffset(92)]  public float shieldBoomerangSpeed;
        [FieldOffset(96)]  public float shieldBoomerangMinDistance;
        [FieldOffset(100)] public float shieldBoomerangMaxDistance;
        [FieldOffset(104)] public float killWaitTime;
        [FieldOffset(108)] public float cameraDistance;
        [FieldOffset(112)] public float cameraElevation;
        [FieldOffset(116)] public int parryBoomerangRound;
        [FieldOffset(120)] public float parryBoomerangOffset;
        [FieldOffset(124)] public float parryBoomerangSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct DefenderCommonLevelConfig
    {
        [FieldOffset(0)]  public int maxHealthPoint;
        [FieldOffset(4)]  public float attackRate;
        [FieldOffset(8)]  public ushort expItemNum;
        [FieldOffset(10)] public ushort exp;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct EnemyDefenderLevelConfig
    {
        [FieldOffset(0)] public int level;
        [FieldOffset(4)] public DefenderCommonLevelConfig common;
    }

    [StructLayout(LayoutKind.Explicit, Size = 208)]
    public struct EnemyDefenderConfig
    {
        [FieldOffset(0)]   public EnemyDefenderCommonConfig commonParams;
        [FieldOffset(128)] public unsafe fixed byte /* EnemyDefenderLevelConfig[5] */ _levelParams[80];

        public unsafe EnemyDefenderLevelConfig* levelParams
        {
            get
            {
                fixed (byte* p_levelParams = _levelParams)
                    return (EnemyDefenderLevelConfig*)p_levelParams;
            }
        }
    }

}