Library "MiniBossWarshipConfig"
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

    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public struct MiniBossWarshipSpeedParam
    {
        [FieldOffset(0)]  public float highSpeed;
        [FieldOffset(4)]  public float lowSpeed;
        [FieldOffset(8)]  public float changeLowSpeedDistance;
        [FieldOffset(12)] public float disableDistanceMaxSpeed;
        [FieldOffset(16)] public float relativeSpeedDisableDistance;
        [FieldOffset(20)] public float speedOnJump;
        [FieldOffset(24)] public float speedDownOnJumpDistance;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct MiniBossWarshipAccelSpeed
    {
        [FieldOffset(0)] public float min;
        [FieldOffset(4)] public float max;
    }

    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public struct MiniBossWarshipWarpCameraParam
    {
        [FieldOffset(0)]  public float zoomDistance;
        [FieldOffset(16)] public Vector3 zoomOffset;
        [FieldOffset(32)] public Vector3 zoomAngle;
        [FieldOffset(48)] public float zoomFov;
    }

    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public struct MiniBossWarshipEscapeCameraParam
    {
        [FieldOffset(0)]  public float fovy;
        [FieldOffset(4)]  public float zRot;
        [FieldOffset(8)]  public float distance;
        [FieldOffset(12)] public float pathOffset;
        [FieldOffset(16)] public bool usePathVerticalComponent;
        [FieldOffset(17)] public bool usePathNormal;
        [FieldOffset(20)] public float angleSensitivity;
        [FieldOffset(24)] public float angleSensitivityBoost;
        [FieldOffset(28)] public float azimuthOffsetDeg;
        [FieldOffset(32)] public float elevationOffsetDeg;
        [FieldOffset(36)] public float gravityOffset;
        [FieldOffset(48)] public Vector3 playerOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct MiniBossWarshipObjectParam
    {
        [FieldOffset(0)]  public float dashRingAppearDistance;
        [FieldOffset(4)]  public float dashRingDisappearDistance;
        [FieldOffset(8)]  public float birdAppearDistance;
        [FieldOffset(12)] public float birdDisappearDistance;
        [FieldOffset(16)] public float bulletAppearDistance;
        [FieldOffset(20)] public float bulletDisappearDistance;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct WarshipNearLaunchParam
    {
        [FieldOffset(0)]  public float outStrength;
        [FieldOffset(4)]  public float inStrength;
        [FieldOffset(8)]  public float outElev;
        [FieldOffset(12)] public float inElev;
        [FieldOffset(16)] public float speedMin;
        [FieldOffset(20)] public float speedMax;
        [FieldOffset(24)] public float speedMinLength;
        [FieldOffset(28)] public float speedMaxLength;
    }

    [StructLayout(LayoutKind.Explicit, Size = 304)]
    public struct MiniBossWarshipCommonParam
    {
        [FieldOffset(0)]   public MiniBossCommonConfig commonConfig;
        [FieldOffset(64)]  public MiniBossWarshipSpeedParam speedParam;
        [FieldOffset(92)]  public MiniBossWarshipAccelSpeed normalSpeedParam;
        [FieldOffset(100)] public MiniBossWarshipAccelSpeed boostSpeedParam;
        [FieldOffset(112)] public MiniBossWarshipWarpCameraParam warpCameraParam;
        [FieldOffset(176)] public MiniBossWarshipEscapeCameraParam escapeCameraParam;
        [FieldOffset(240)] public MiniBossWarshipObjectParam objectParam;
        [FieldOffset(264)] public WarshipNearLaunchParam launchParam;
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
    public struct MiniBossWarshipLevelParam
    {
        [FieldOffset(0)] public int level;
        [FieldOffset(4)] public MiniBossLevelCommonConfig commonConfig;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct MiniBossWarshipLevelBand
    {
        [FieldOffset(0)] public int level;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct MiniBossWarshipRecoverBoostGaugeParam
    {
        [FieldOffset(0)] public float normal;
        [FieldOffset(4)] public float boost;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct MiniBossWarshipAttackStateParam
    {
        [FieldOffset(0)]  public float moveSpeed;
        [FieldOffset(4)]  public float bombDropSpeed;
        [FieldOffset(8)]  public float bombInterval;
        [FieldOffset(12)] public float explosionRadius;
        [FieldOffset(16)] public float bombPreDistEffectRange;
        [FieldOffset(20)] public float lifeTime;
        [FieldOffset(24)] public float preBombTime;
        [FieldOffset(28)] public float preBombStateSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct MiniBossWarshipBattleFlagParam
    {
        [FieldOffset(0)] public float firstFinishTimer;
        [FieldOffset(4)] public float finishTimer;
        [FieldOffset(8)] public float disableHomingTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct MiniBossWarshipNearBattleCameraParam
    {
        [FieldOffset(0)]  public float distance;
        [FieldOffset(4)]  public float minElevation;
        [FieldOffset(8)]  public float maxElevation;
        [FieldOffset(12)] public float targetUpOffset;
        [FieldOffset(16)] public float targetMinUpOffsetLimit;
        [FieldOffset(20)] public float targetMaxUpOffsetLimit;
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

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct WarshipPathSectionInfo
    {
        [FieldOffset(0)] public bool enable;
        [FieldOffset(4)] public float start;
        [FieldOffset(8)] public float end;
    }

    [StructLayout(LayoutKind.Explicit, Size = 1216)]
    public struct WarshipEscapePathInfo
    {
        [FieldOffset(0)]   public CString followPaths;
        [FieldOffset(16)]  public unsafe fixed byte /* WarshipPathSectionInfo[50] */ _usePathInfo[600];

        public unsafe WarshipPathSectionInfo* usePathInfo
        {
            get
            {
                fixed (byte* p_usePathInfo = _usePathInfo)
                    return (WarshipPathSectionInfo*)p_usePathInfo;
            }
        }

        [FieldOffset(616)] public unsafe fixed byte /* WarshipPathSectionInfo[50] */ _accelInfo[600];

        public unsafe WarshipPathSectionInfo* accelInfo
        {
            get
            {
                fixed (byte* p_accelInfo = _accelInfo)
                    return (WarshipPathSectionInfo*)p_accelInfo;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 6080)]
    public struct MiniBossWarshipEscapePathParam
    {
        [FieldOffset(0)] public unsafe fixed byte /* WarshipEscapePathInfo[5] */ _escapePathInfo[6080];

        public unsafe WarshipEscapePathInfo* escapePathInfo
        {
            get
            {
                fixed (byte* p_escapePathInfo = _escapePathInfo)
                    return (WarshipEscapePathInfo*)p_escapePathInfo;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public struct MiniBossWarshipBombAttackCameraParam
    {
        [FieldOffset(0)]  public float lockonDistance;
        [FieldOffset(4)]  public float unlockDistance;
        [FieldOffset(8)]  public float duration;
        [FieldOffset(12)] public float distance;
        [FieldOffset(16)] public float minElevation;
        [FieldOffset(20)] public float maxElevation;
        [FieldOffset(24)] public float lockonFrameYOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 60)]
    public struct MiniBossWarshipAttackStateCameraParam
    {
        [FieldOffset(0)]  public float midCameraPosOffset;
        [FieldOffset(4)]  public MiniBossWarshipBombAttackCameraParam firstCamera;
        [FieldOffset(32)] public MiniBossWarshipBombAttackCameraParam secondCamera;
    }

    [StructLayout(LayoutKind.Explicit, Size = 31456)]
    public struct MiniBossWarshipConfig
    {
        [FieldOffset(0)]     public MiniBossWarshipCommonParam commonParam;
        [FieldOffset(304)]   public unsafe fixed byte /* MiniBossWarshipLevelParam[5] */ _levelParams[280];

        public unsafe MiniBossWarshipLevelParam* levelParams
        {
            get
            {
                fixed (byte* p_levelParams = _levelParams)
                    return (MiniBossWarshipLevelParam*)p_levelParams;
            }
        }

        [FieldOffset(584)]   public unsafe fixed byte /* MiniBossWarshipLevelBand[5] */ _levelBand[20];

        public unsafe MiniBossWarshipLevelBand* levelBand
        {
            get
            {
                fixed (byte* p_levelBand = _levelBand)
                    return (MiniBossWarshipLevelBand*)p_levelBand;
            }
        }

        [FieldOffset(604)]   public float wanderMoveSpeed;
        [FieldOffset(608)]   public float railMaxLength;
        [FieldOffset(612)]   public MiniBossWarshipSpeedParam shiftStateMoveSpeedParam;
        [FieldOffset(640)]   public float locatorDistance;
        [FieldOffset(644)]   public float distanceEscapePathToStart;
        [FieldOffset(648)]   public MiniBossWarshipRecoverBoostGaugeParam boostGaugeParam;
        [FieldOffset(656)]   public MiniBossWarshipAttackStateParam attackStateParam;
        [FieldOffset(688)]   public MiniBossWarshipBattleFlagParam battleFlagParam;
        [FieldOffset(700)]   public MiniBossWarshipNearBattleCameraParam nearBattleCameraParam;
        [FieldOffset(724)]   public float disableGimmickDistance;
        [FieldOffset(728)]   public float warpTime;
        [FieldOffset(732)]   public float cameraChangeTime;
        [FieldOffset(736)]   public float cameraAppearTime;
        [FieldOffset(740)]   public float spreadHomingDistance;
        [FieldOffset(744)]   public unsafe fixed byte /* MiniBossWarshipEscapePathParam[5] */ _escapePathID[30400];

        public unsafe MiniBossWarshipEscapePathParam* escapePathID
        {
            get
            {
                fixed (byte* p_escapePathID = _escapePathID)
                    return (MiniBossWarshipEscapePathParam*)p_escapePathID;
            }
        }

        [FieldOffset(31144)] public unsafe fixed byte /* MiniBossWarshipAttackStateCameraParam[5] */ _bombAttackCameraParam[300];

        public unsafe MiniBossWarshipAttackStateCameraParam* bombAttackCameraParam
        {
            get
            {
                fixed (byte* p_bombAttackCameraParam = _bombAttackCameraParam)
                    return (MiniBossWarshipAttackStateCameraParam*)p_bombAttackCameraParam;
            }
        }
    }

}