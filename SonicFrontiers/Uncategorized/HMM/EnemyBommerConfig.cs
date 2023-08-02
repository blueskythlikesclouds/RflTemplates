Library "EnemyBommerConfig"
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
    public struct EnemyBommerPatrolConfig
    {
        [FieldOffset(0)]  public float rotationDeceleration;
        [FieldOffset(4)]  public float rotationAngleMax;
        [FieldOffset(8)]  public float changeTimeIdlePatrolMin;
        [FieldOffset(12)] public float changeTimeIdlePatrolMax;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct EnemyBommerAimingConfig
    {
        [FieldOffset(0)]  public float moveDecerleration;
        [FieldOffset(4)]  public float rotationAngleMax;
        [FieldOffset(8)]  public float chargeTime;
        [FieldOffset(12)] public float rotateSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public struct EnemyBommerAttackConfig
    {
        [FieldOffset(0)]  public float moveVelocity;
        [FieldOffset(4)]  public float moveDecerleration;
        [FieldOffset(8)]  public float moveDecelerationDamaged;
        [FieldOffset(12)] public float cooldownTime;
        [FieldOffset(16)] public float colliderOffsetRate;
    }

    [StructLayout(LayoutKind.Explicit, Size = 52)]
    public struct EnemyBommerChaseConfig
    {
        [FieldOffset(0)]  public float moveVelocity;
        [FieldOffset(4)]  public float moveAccerleration;
        [FieldOffset(8)]  public float amplitude;
        [FieldOffset(12)] public float period;
        [FieldOffset(16)] public float rotateSpeedInFront;
        [FieldOffset(20)] public float rotateSpeedOnBack;
        [FieldOffset(24)] public float chaseTime;
        [FieldOffset(28)] public float parriedMoveDistance;
        [FieldOffset(32)] public float parriedShortenTime;
        [FieldOffset(36)] public float parriedCoolDownTime;
        [FieldOffset(40)] public float colliderOffsetRate;
        [FieldOffset(44)] public float cameraDistance;
        [FieldOffset(48)] public float cameraElevation;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct DebrisParameter
    {
        [FieldOffset(0)]  public int m_maxNumPieces;
        [FieldOffset(4)]  public float gravity;
        [FieldOffset(8)]  public float lifeTime;
        [FieldOffset(12)] public float force;
    }

    [StructLayout(LayoutKind.Explicit, Size = 208)]
    public struct EnemyBommerCommonConfig
    {
        [FieldOffset(0)]   public RingParameter ringParam;
        [FieldOffset(28)]  public float mass;
        [FieldOffset(32)]  public float slopeAngleMax;
        [FieldOffset(36)]  public float checkBarrierDistance;
        [FieldOffset(40)]  public float colliderRadius;
        [FieldOffset(44)]  public float colliderHeight;
        [FieldOffset(48)]  public float damageColliderRadiusOffset;
        [FieldOffset(52)]  public float eyesightDistance;
        [FieldOffset(56)]  public float eyesightDistanceMargin;
        [FieldOffset(60)]  public EnemyBommerPatrolConfig patrolConfig;
        [FieldOffset(76)]  public EnemyBommerAimingConfig aimingConfig;
        [FieldOffset(92)]  public EnemyBommerAttackConfig attackConfig;
        [FieldOffset(112)] public EnemyBommerChaseConfig chaseConfig;
        [FieldOffset(164)] public float explodeSignalTime;
        [FieldOffset(168)] public float explodeColliderRadius;
        [FieldOffset(172)] public bool useUniqueDebrisSetting;
        [FieldOffset(176)] public DebrisParameter debrisExplode;
        [FieldOffset(192)] public DebrisParameter debrisCyloop;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct BommerCommonLevelConfig
    {
        [FieldOffset(0)]  public int maxHealthPoint;
        [FieldOffset(4)]  public float attackRate;
        [FieldOffset(8)]  public ushort expItemNum;
        [FieldOffset(10)] public ushort exp;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct EnemyBommerLevelConfig
    {
        [FieldOffset(0)] public int level;
        [FieldOffset(4)] public BommerCommonLevelConfig common;
    }

    [StructLayout(LayoutKind.Explicit, Size = 288)]
    public struct EnemyBommerConfig
    {
        [FieldOffset(0)]   public EnemyBommerCommonConfig commonParams;
        [FieldOffset(208)] public unsafe fixed byte /* EnemyBommerLevelConfig[5] */ _levelParams[80];

        public unsafe EnemyBommerLevelConfig* levelParams
        {
            get
            {
                fixed (byte* p_levelParams = _levelParams)
                    return (EnemyBommerLevelConfig*)p_levelParams;
            }
        }
    }

}