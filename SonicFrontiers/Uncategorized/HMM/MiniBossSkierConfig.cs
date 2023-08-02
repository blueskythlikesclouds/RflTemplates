Library "MiniBossSkierConfig"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public struct MiniBossCommonConfig
    {
        [FieldOffset(0)]  public float scoutDistance;
        [FieldOffset(4)]  public float scoutDistanceOutside;
        [FieldOffset(8)]  public float zoomDistance;
        [FieldOffset(16)] public Vector3 zoomOffset;
        [FieldOffset(32)] public Vector3 zoomAngle;
        [FieldOffset(48)] public float zoomFov;
    }

    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public struct MiniBossSkierColliderParam
    {
        [FieldOffset(0)]  public float blockRadius;
        [FieldOffset(4)]  public float blockHeight;
        [FieldOffset(8)]  public float damageRadius;
        [FieldOffset(12)] public float damagedBlockRadius;
        [FieldOffset(16)] public float damagedBlockHeight;
        [FieldOffset(20)] public float returnRadius;
        [FieldOffset(24)] public float returnBlockRadius;
        [FieldOffset(28)] public float returnHeight;
        [FieldOffset(32)] public float weakPointRadius;
        [FieldOffset(36)] public float grabRadius;
        [FieldOffset(40)] public float attackRadius;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct MiniBossSkeirTailMoveParam
    {
        [FieldOffset(0)] public float tailRotateMinSpeed;
        [FieldOffset(4)] public float tailRotateMaxSpeed;
        [FieldOffset(8)] public float tailRotateAddSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 52)]
    public struct MiniBossSkierTailParam
    {
        [FieldOffset(0)]  public float tailExtendTime;
        [FieldOffset(4)]  public float tailNodeLenthMin;
        [FieldOffset(8)]  public float tailNodeLenthMax;
        [FieldOffset(12)] public float checkGroundStartDistanceOnSkiing;
        [FieldOffset(16)] public float checkGroundEndDistanceOnSkiing;
        [FieldOffset(20)] public float checkGroundEndDistanceOnSkiingJump;
        [FieldOffset(24)] public float checkGroundEndDistanceOnSkiingCamera;
        [FieldOffset(28)] public MiniBossSkeirTailMoveParam rotateParamNormal;
        [FieldOffset(40)] public MiniBossSkeirTailMoveParam rotateParamAttack;
    }

    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public struct MiniBossSkeirPlayerControlLR
    {
        [FieldOffset(0)]  public float LRFBNormalRatioSpeed;
        [FieldOffset(4)]  public float LRDangerAngle;
        [FieldOffset(8)]  public float LRDangerTime;
        [FieldOffset(12)] public float LRInputInterfere;
        [FieldOffset(16)] public float LRRecoverSpeed;
        [FieldOffset(20)] public float LRDragSpeed;
        [FieldOffset(24)] public float LRRecoverEndRatio;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct MiniBossSkeirPlayerControlUD
    {
        [FieldOffset(0)] public float UDSafeRatio;
        [FieldOffset(4)] public float UDRecoverSpeed;
        [FieldOffset(8)] public float UDDragSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct MiniBossSkeirPlayerControlTail
    {
        [FieldOffset(0)]  public float tailRatioChangeSpeed;
        [FieldOffset(4)]  public float tailRatioRecoverSpeed;
        [FieldOffset(8)]  public float tailAddSpeedMax;
        [FieldOffset(12)] public float tailAddSpeedAttenuation;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct MiniBossSkierMissileParam
    {
        [FieldOffset(0)] public float timeExplodePassed;
        [FieldOffset(4)] public float timeExplodeAuto;
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct MiniBossSkierCustomCameraParam
    {
        [FieldOffset(0)]  public float interoplateTimeActivate;
        [FieldOffset(4)]  public float interoplateTimeDeactivate;
        [FieldOffset(16)] public Vector3 targetOffset;
        [FieldOffset(32)] public Vector3 cameraPosOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 320)]
    public struct MiniBossSkierCommonParam
    {
        [FieldOffset(0)]   public MiniBossCommonConfig commonConfig;
        [FieldOffset(64)]  public MiniBossSkierColliderParam colliderParam;
        [FieldOffset(108)] public MiniBossSkierTailParam tailParam;
        [FieldOffset(160)] public MiniBossSkeirPlayerControlLR LRControlParam;
        [FieldOffset(188)] public MiniBossSkeirPlayerControlUD UDControlParam;
        [FieldOffset(200)] public MiniBossSkeirPlayerControlTail tailControlParam;
        [FieldOffset(216)] public MiniBossSkierMissileParam missileParam;
        [FieldOffset(224)] public MiniBossSkierCustomCameraParam customCameraParam;
        [FieldOffset(272)] public MiniBossSkierCustomCameraParam skiCameraParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 52)]
    public struct MiniBossLevelCommonConfig
    {
        [FieldOffset(0)]  public int maxHealthPoint;
        [FieldOffset(4)]  public unsafe fixed float maxStunPoint[3];
        [FieldOffset(16)] public float stunDecreaseStartTime;
        [FieldOffset(20)] public float stunDecreaseSpeed;
        [FieldOffset(24)] public unsafe fixed float maxStaggerPoint[3];
        [FieldOffset(36)] public float staggerDecreaseStartTime;
        [FieldOffset(40)] public float staggerDecreaseSpeed;
        [FieldOffset(44)] public float attackRate;
        [FieldOffset(48)] public ushort expItemNum;
        [FieldOffset(50)] public ushort exp;
    }

    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public struct MiniBossSkierLevelParam
    {
        [FieldOffset(0)] public int level;
        [FieldOffset(4)] public MiniBossLevelCommonConfig commonConfig;
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct MiniBossSkierSkiAcitionRate
    {
        [FieldOffset(0)]  public float NoActionRate;
        [FieldOffset(4)]  public float SnakeMoveRate;
        [FieldOffset(8)]  public float JumpHighRate;
        [FieldOffset(12)] public float JumpLowRate;
        [FieldOffset(16)] public float PylonRate;
        [FieldOffset(20)] public float MissileRate;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct MiniBossSkierBattlePhaseParam
    {
        [FieldOffset(0)]  public float HPRate;
        [FieldOffset(4)]  public MiniBossSkierSkiAcitionRate actionRate;
        [FieldOffset(28)] public float showWeaknessTimeReTry;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct MiniBossSkierJumpOutParam
    {
        [FieldOffset(0)]  public float attackInterval;
        [FieldOffset(4)]  public float attackSensorRange;
        [FieldOffset(8)]  public float returnToWanderTime;
        [FieldOffset(12)] public float pathPosAngleLimit;
    }

    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public struct MiniBossSkierSkiParam
    {
        [FieldOffset(0)]  public float showWeaknessTime;
        [FieldOffset(4)]  public float skiMoveSpeed;
        [FieldOffset(8)]  public float skiWeakMoveSpeed;
        [FieldOffset(12)] public float skiReturnSpeed;
        [FieldOffset(16)] public float homingSpeed;
        [FieldOffset(20)] public float jumpHighSpeed;
        [FieldOffset(24)] public float jumpLowSpeed;
        [FieldOffset(28)] public float struggleTime;
        [FieldOffset(32)] public float returnUndergroundTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public struct MiniBossSkierSnakeMoveParam
    {
        [FieldOffset(0)]  public float snakeMoveAmplitude;
        [FieldOffset(4)]  public float snakeMovePeriod;
        [FieldOffset(8)]  public float snakeMovePrepareTime;
        [FieldOffset(12)] public float snakeMoveReturnTime;
        [FieldOffset(16)] public float snakeMoveDangerAngleOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public struct MiniBossSkierTailAttackParam
    {
        [FieldOffset(0)]  public float signSpeed;
        [FieldOffset(4)]  public float attackMinSpeed;
        [FieldOffset(8)]  public float attackMaxSpeed;
        [FieldOffset(12)] public float maxWaitTime;
        [FieldOffset(16)] public float driftLenth;
        [FieldOffset(20)] public float driftLenthUIOffset;
        [FieldOffset(24)] public float rotStartAngularSpeed;
        [FieldOffset(28)] public float rotEndAngularSpeed;
        [FieldOffset(32)] public float avoidObjCalMargePylon;
        [FieldOffset(36)] public float avoidObjCalMargeMissile;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct MiniBossSkierTailAttackPylonParam
    {
        [FieldOffset(0)]  public float signSpeed;
        [FieldOffset(4)]  public float signTime;
        [FieldOffset(8)]  public float pylonAppearTime;
        [FieldOffset(12)] public float pylonDisappearTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 228)]
    public struct MiniBossSkierLevelBand
    {
        [FieldOffset(0)]   public int level;
        [FieldOffset(4)]   public unsafe fixed byte /* MiniBossSkierBattlePhaseParam[3] */ _phaseParam[96];

        public unsafe MiniBossSkierBattlePhaseParam* phaseParam
        {
            get
            {
                fixed (byte* p_phaseParam = _phaseParam)
                    return (MiniBossSkierBattlePhaseParam*)p_phaseParam;
            }
        }

        [FieldOffset(100)] public MiniBossSkierJumpOutParam jumpOutParam;
        [FieldOffset(116)] public MiniBossSkierSkiParam skiParam;
        [FieldOffset(152)] public MiniBossSkierSnakeMoveParam snakeMoveParam;
        [FieldOffset(172)] public MiniBossSkierTailAttackParam tailAttackParam;
        [FieldOffset(212)] public MiniBossSkierTailAttackPylonParam pylonParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 1744)]
    public struct MiniBossSkierConfig
    {
        [FieldOffset(0)]   public MiniBossSkierCommonParam commonParam;
        [FieldOffset(320)] public unsafe fixed byte /* MiniBossSkierLevelParam[5] */ _levelParams[280];

        public unsafe MiniBossSkierLevelParam* levelParams
        {
            get
            {
                fixed (byte* p_levelParams = _levelParams)
                    return (MiniBossSkierLevelParam*)p_levelParams;
            }
        }

        [FieldOffset(600)] public unsafe fixed byte /* MiniBossSkierLevelBand[5] */ _levelBand[1140];

        public unsafe MiniBossSkierLevelBand* levelBand
        {
            get
            {
                fixed (byte* p_levelBand = _levelBand)
                    return (MiniBossSkierLevelBand*)p_levelBand;
            }
        }
    }

}