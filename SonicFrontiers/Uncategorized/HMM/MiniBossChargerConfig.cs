Library "MiniBossChargerConfig"
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

    public enum BarrageType : sbyte
{
        TYPE_LASER = 0,
        TYPE_BALL = 1,
        TYPE_BALL_L = 2,
        TYPE_BALL_LL = 3,
        TYPE_AIR_DROP = 4
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

    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public struct MiniBossChagerBarrageParam
    {
        [FieldOffset(0)]  public BarrageType type;
        [FieldOffset(8)]  public CString damageTag;
        [FieldOffset(24)] public float startSpeed;
        [FieldOffset(28)] public float decelePower;
        [FieldOffset(32)] public float minSpeed;
        [FieldOffset(36)] public float lifeTime;
        [FieldOffset(40)] public float waitTime;
        [FieldOffset(44)] public float lineTime;
        [FieldOffset(48)] public float scale;
        [FieldOffset(52)] public float hitVelocity;
        [FieldOffset(56)] public float parriedSpeed;
        [FieldOffset(60)] public int parriedDamage;
        [FieldOffset(64)] public float parriedStaggerValue;
        [FieldOffset(68)] public float parriedStunValue;
        [FieldOffset(72)] public CString hitEffName;
    }

    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public struct MiniBossChagerSimpleRotateBullet
    {
        [FieldOffset(0)]  public int barrageIndex;
        [FieldOffset(4)]  public float startWaitTime;
        [FieldOffset(8)]  public int muzzleNum;
        [FieldOffset(12)] public float yOffset;
        [FieldOffset(16)] public float zOffset;
        [FieldOffset(20)] public float heightLength;
        [FieldOffset(24)] public float rotSpeed;
        [FieldOffset(28)] public float shakeSpeed;
        [FieldOffset(32)] public float intervalTime;
        [FieldOffset(36)] public float activeTime;
        [FieldOffset(40)] public float endWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public struct MiniBossChagerFollowLaser
    {
        [FieldOffset(0)]  public float startWaitTime;
        [FieldOffset(4)]  public float yOffset;
        [FieldOffset(8)]  public float zOffset;
        [FieldOffset(12)] public float moveSpeed;
        [FieldOffset(16)] public float followDeg;
        [FieldOffset(20)] public int shotNum;
        [FieldOffset(24)] public float intervalTime;
        [FieldOffset(28)] public float lifeTime;
        [FieldOffset(32)] public float endWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct MiniBossChagerVortexLaser
    {
        [FieldOffset(0)]  public float startWaitTime;
        [FieldOffset(4)]  public int muzzleNum;
        [FieldOffset(8)]  public float yOffset;
        [FieldOffset(12)] public float zOffset;
        [FieldOffset(16)] public float rotSpeed;
        [FieldOffset(20)] public float moveSpeed;
        [FieldOffset(24)] public float activeTime;
        [FieldOffset(28)] public float endWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public struct MiniBossChagerCrossLaser
    {
        [FieldOffset(0)]  public float startWaitTime;
        [FieldOffset(4)]  public float moveSpeed;
        [FieldOffset(8)]  public float setDeg;
        [FieldOffset(12)] public float lifeTime;
        [FieldOffset(16)] public float endWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public struct MiniBossChagerCrossBullet
    {
        [FieldOffset(0)]  public int barrageIndex;
        [FieldOffset(4)]  public float yOffset;
        [FieldOffset(8)]  public float zOffset;
        [FieldOffset(12)] public bool isFollowPlayer;
        [FieldOffset(16)] public float startWaitTime;
        [FieldOffset(20)] public float shotIntarval;
        [FieldOffset(24)] public float maxAngle;
        [FieldOffset(28)] public float rotateSpeed;
        [FieldOffset(32)] public float rotateAngle;
        [FieldOffset(36)] public float endWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public struct MiniBossChagerMassLaser
    {
        [FieldOffset(0)]  public float startWaitTime;
        [FieldOffset(4)]  public float yOffset;
        [FieldOffset(8)]  public float scale;
        [FieldOffset(12)] public float lifeTime;
        [FieldOffset(16)] public float endWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct MiniBossChagerVerticalRoundBullet
    {
        [FieldOffset(0)]  public int barrageIndex;
        [FieldOffset(4)]  public float startWaitTime;
        [FieldOffset(8)]  public int muzzleNum;
        [FieldOffset(12)] public int verticalNum;
        [FieldOffset(16)] public float radius;
        [FieldOffset(20)] public float spaceRate;
        [FieldOffset(24)] public float verticalWaitTime;
        [FieldOffset(28)] public float endWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct MiniBossPyramidRoundBullet
    {
        [FieldOffset(0)]  public int barrageIndex;
        [FieldOffset(4)]  public float startWaitTime;
        [FieldOffset(8)]  public int muzzleNum;
        [FieldOffset(12)] public float radius;
        [FieldOffset(16)] public float height;
        [FieldOffset(20)] public float scale;
        [FieldOffset(24)] public int sideNum;
        [FieldOffset(28)] public int attackNum;
        [FieldOffset(32)] public float intervalTime;
        [FieldOffset(36)] public float nextDeg;
        [FieldOffset(40)] public float shotWaitTime;
        [FieldOffset(44)] public float endWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct MiniBossPlaneUpDownBullet
    {
        [FieldOffset(0)]  public int barrageIndex;
        [FieldOffset(4)]  public float startWaitTime;
        [FieldOffset(8)]  public float yOffset;
        [FieldOffset(12)] public float scale;
        [FieldOffset(16)] public float step;
        [FieldOffset(20)] public int allNum;
        [FieldOffset(24)] public float upRate;
        [FieldOffset(28)] public float downRate;
        [FieldOffset(32)] public float frontRate;
        [FieldOffset(36)] public float shotWaitTimeMin;
        [FieldOffset(40)] public float shotWaitTimeMax;
        [FieldOffset(44)] public float endWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public struct MiniBossTriangleBatteryBullet
    {
        [FieldOffset(0)]  public int barrageIndex;
        [FieldOffset(4)]  public float startWaitTime;
        [FieldOffset(8)]  public float yOffset;
        [FieldOffset(12)] public float edgeLength;
        [FieldOffset(16)] public float activeTime;
        [FieldOffset(20)] public float intervalTime;
        [FieldOffset(24)] public float endWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public struct MiniBossPlayerFallBullet
    {
        [FieldOffset(0)]  public int barrageIndex;
        [FieldOffset(4)]  public float startWaitTime;
        [FieldOffset(8)]  public float yOffset;
        [FieldOffset(12)] public float scale;
        [FieldOffset(16)] public float lengthMin;
        [FieldOffset(20)] public float lengthMax;
        [FieldOffset(24)] public float intervalTime;
        [FieldOffset(28)] public float shotWaitTime;
        [FieldOffset(32)] public float activeTime;
        [FieldOffset(36)] public float endWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public struct MiniBossGatlingRevolverBullet
    {
        [FieldOffset(0)]  public int barrageIndex;
        [FieldOffset(4)]  public float startWaitTime;
        [FieldOffset(8)]  public float yOffset;
        [FieldOffset(12)] public float zOffset;
        [FieldOffset(16)] public float scale;
        [FieldOffset(20)] public int muzzleNum;
        [FieldOffset(24)] public float bulletRad;
        [FieldOffset(28)] public float intervalTime;
        [FieldOffset(32)] public float activeTime;
        [FieldOffset(36)] public float endWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public struct MiniBossWinderBullet
    {
        [FieldOffset(0)]  public int barrageIndex;
        [FieldOffset(4)]  public float yOffset;
        [FieldOffset(8)]  public float zOffset;
        [FieldOffset(12)] public bool isFollowPlayer;
        [FieldOffset(16)] public float shotIntarval;
        [FieldOffset(20)] public float maxAngle;
        [FieldOffset(24)] public float rotateSpeed;
        [FieldOffset(28)] public float rotateAngle;
        [FieldOffset(32)] public float barrageAngleDiff;
        [FieldOffset(36)] public float startWaitTime;
        [FieldOffset(40)] public float endWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public struct MiniBossShotgunBullet
    {
        [FieldOffset(0)]  public int barrageIndex;
        [FieldOffset(4)]  public float yOffset;
        [FieldOffset(8)]  public float zOffset;
        [FieldOffset(12)] public bool isFollowPlayer;
        [FieldOffset(16)] public float shotIntarval;
        [FieldOffset(20)] public float maxAngle;
        [FieldOffset(24)] public float yAngleOffset;
        [FieldOffset(28)] public float shotTime;
        [FieldOffset(32)] public float addSpeedMax;
        [FieldOffset(36)] public float startWaitTime;
        [FieldOffset(40)] public float endWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct MiniBossChagerAirDrop
    {
        [FieldOffset(0)]  public int barrageIndex;
        [FieldOffset(4)]  public float yOffset;
        [FieldOffset(8)]  public float zOffset;
        [FieldOffset(12)] public float upRotOffset;
        [FieldOffset(16)] public float yAngleOffset;
        [FieldOffset(20)] public float maxAngle;
        [FieldOffset(24)] public float shotTime;
        [FieldOffset(28)] public float addSpeedMax;
        [FieldOffset(32)] public float lineTime;
        [FieldOffset(36)] public float fallPower;
        [FieldOffset(40)] public float startWaitTime;
        [FieldOffset(44)] public float endWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 60)]
    public struct MiniBossChagerGroundObj
    {
        [FieldOffset(0)]  public int bulletDamage;
        [FieldOffset(4)]  public float bulletStaggerPoint;
        [FieldOffset(8)]  public float bulletSpeed;
        [FieldOffset(12)] public float bulletFallSpeed;
        [FieldOffset(16)] public float bulletCyloopSpeed;
        [FieldOffset(20)] public float bulletGroundTime;
        [FieldOffset(24)] public float bulletFallTime;
        [FieldOffset(28)] public float yOffset;
        [FieldOffset(32)] public float zOffset;
        [FieldOffset(36)] public float upRotOffset;
        [FieldOffset(40)] public float yAngleOffset;
        [FieldOffset(44)] public float maxAngle;
        [FieldOffset(48)] public float shotTime;
        [FieldOffset(52)] public float startWaitTime;
        [FieldOffset(56)] public float endWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 336)]
    public struct MiniBossChagerDiffuseLaser
    {
        [FieldOffset(0)]   public float startWaitTime;
        [FieldOffset(4)]   public float yOffset;
        [FieldOffset(8)]   public float scale;
        [FieldOffset(12)]  public int muzzleNum;
        [FieldOffset(16)]  public unsafe fixed byte /* Vector3[10] */ _muzzlePosOffset[160];

        public unsafe Vector3* muzzlePosOffset
        {
            get
            {
                fixed (byte* p_muzzlePosOffset = _muzzlePosOffset)
                    return (Vector3*)p_muzzlePosOffset;
            }
        }

        [FieldOffset(176)] public unsafe fixed float muzzleRotOffset[10];
        [FieldOffset(216)] public unsafe fixed float muzzleTimeOffset[10];
        [FieldOffset(256)] public unsafe fixed float muzzleLaserStartOffset[10];
        [FieldOffset(296)] public int laserNum;
        [FieldOffset(300)] public int attackNum;
        [FieldOffset(304)] public float laserRandomRange;
        [FieldOffset(308)] public float laserTime;
        [FieldOffset(312)] public float laserEndTime;
        [FieldOffset(316)] public float laserNextTime;
        [FieldOffset(320)] public float endWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 384)]
    public struct MiniBossChagerChaseShot
    {
        [FieldOffset(0)]   public float startWaitTime;
        [FieldOffset(4)]   public int muzzleNum;
        [FieldOffset(16)]  public unsafe fixed byte /* Vector3[10] */ _muzzlePosOffset[160];

        public unsafe Vector3* muzzlePosOffset
        {
            get
            {
                fixed (byte* p_muzzlePosOffset = _muzzlePosOffset)
                    return (Vector3*)p_muzzlePosOffset;
            }
        }

        [FieldOffset(176)] public unsafe fixed float muzzleRotOffsetX[10];
        [FieldOffset(216)] public unsafe fixed float muzzleRotOffsetY[10];
        [FieldOffset(256)] public unsafe fixed float muzzleTimeOffset[10];
        [FieldOffset(296)] public unsafe fixed float muzzleLaserStartOffset[10];
        [FieldOffset(336)] public float laserShotTimeMin;
        [FieldOffset(340)] public float laserShotTimeMax;
        [FieldOffset(344)] public int laserNum;
        [FieldOffset(348)] public float laserRange;
        [FieldOffset(352)] public float laserEndTime;
        [FieldOffset(356)] public float laserSpeed;
        [FieldOffset(360)] public float laserRandomRangeMin;
        [FieldOffset(364)] public float laserRandomRangeMax;
        [FieldOffset(368)] public float laserHomingTime;
        [FieldOffset(372)] public float endWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public struct MiniBossChargerCatchParam
    {
        [FieldOffset(0)]  public float hitDistance;
        [FieldOffset(4)]  public float durationBind;
        [FieldOffset(8)]  public float distanceStartBlackOut;
        [FieldOffset(12)] public float timeEaseBlackOut;
        [FieldOffset(16)] public float timeDelayEndtBlackOut;
        [FieldOffset(32)] public Vector3 tangentFrom;
        [FieldOffset(48)] public Vector3 tangentTo;
    }

    [StructLayout(LayoutKind.Explicit, Size = 5568)]
    public struct MiniBossChargerCommonParam
    {
        [FieldOffset(0)]    public MiniBossCommonConfig commonConfig;
        [FieldOffset(64)]   public unsafe fixed byte /* MiniBossChagerBarrageParam[16] */ _barrage[1408];

        public unsafe MiniBossChagerBarrageParam* barrage
        {
            get
            {
                fixed (byte* p_barrage = _barrage)
                    return (MiniBossChagerBarrageParam*)p_barrage;
            }
        }

        [FieldOffset(1472)] public unsafe fixed byte /* MiniBossChagerSimpleRotateBullet[3] */ _simpleRotateBullet[132];

        public unsafe MiniBossChagerSimpleRotateBullet* simpleRotateBullet
        {
            get
            {
                fixed (byte* p_simpleRotateBullet = _simpleRotateBullet)
                    return (MiniBossChagerSimpleRotateBullet*)p_simpleRotateBullet;
            }
        }

        [FieldOffset(1604)] public unsafe fixed byte /* MiniBossChagerFollowLaser[3] */ _followLaser[108];

        public unsafe MiniBossChagerFollowLaser* followLaser
        {
            get
            {
                fixed (byte* p_followLaser = _followLaser)
                    return (MiniBossChagerFollowLaser*)p_followLaser;
            }
        }

        [FieldOffset(1712)] public unsafe fixed byte /* MiniBossChagerVortexLaser[3] */ _vortexLaser[96];

        public unsafe MiniBossChagerVortexLaser* vortexLaser
        {
            get
            {
                fixed (byte* p_vortexLaser = _vortexLaser)
                    return (MiniBossChagerVortexLaser*)p_vortexLaser;
            }
        }

        [FieldOffset(1808)] public unsafe fixed byte /* MiniBossChagerCrossLaser[3] */ _crossLaser[60];

        public unsafe MiniBossChagerCrossLaser* crossLaser
        {
            get
            {
                fixed (byte* p_crossLaser = _crossLaser)
                    return (MiniBossChagerCrossLaser*)p_crossLaser;
            }
        }

        [FieldOffset(1868)] public unsafe fixed byte /* MiniBossChagerCrossBullet[3] */ _crossBullet[120];

        public unsafe MiniBossChagerCrossBullet* crossBullet
        {
            get
            {
                fixed (byte* p_crossBullet = _crossBullet)
                    return (MiniBossChagerCrossBullet*)p_crossBullet;
            }
        }

        [FieldOffset(1988)] public unsafe fixed byte /* MiniBossChagerMassLaser[3] */ _massLaser[60];

        public unsafe MiniBossChagerMassLaser* massLaser
        {
            get
            {
                fixed (byte* p_massLaser = _massLaser)
                    return (MiniBossChagerMassLaser*)p_massLaser;
            }
        }

        [FieldOffset(2048)] public unsafe fixed byte /* MiniBossChagerVerticalRoundBullet[3] */ _verticalRoundBullet[96];

        public unsafe MiniBossChagerVerticalRoundBullet* verticalRoundBullet
        {
            get
            {
                fixed (byte* p_verticalRoundBullet = _verticalRoundBullet)
                    return (MiniBossChagerVerticalRoundBullet*)p_verticalRoundBullet;
            }
        }

        [FieldOffset(2144)] public unsafe fixed byte /* MiniBossPyramidRoundBullet[3] */ _pyramidRoundBullet[144];

        public unsafe MiniBossPyramidRoundBullet* pyramidRoundBullet
        {
            get
            {
                fixed (byte* p_pyramidRoundBullet = _pyramidRoundBullet)
                    return (MiniBossPyramidRoundBullet*)p_pyramidRoundBullet;
            }
        }

        [FieldOffset(2288)] public unsafe fixed byte /* MiniBossPlaneUpDownBullet[3] */ _planeUpDownBullet[144];

        public unsafe MiniBossPlaneUpDownBullet* planeUpDownBullet
        {
            get
            {
                fixed (byte* p_planeUpDownBullet = _planeUpDownBullet)
                    return (MiniBossPlaneUpDownBullet*)p_planeUpDownBullet;
            }
        }

        [FieldOffset(2432)] public unsafe fixed byte /* MiniBossTriangleBatteryBullet[3] */ _triangleBatteryBullet[84];

        public unsafe MiniBossTriangleBatteryBullet* triangleBatteryBullet
        {
            get
            {
                fixed (byte* p_triangleBatteryBullet = _triangleBatteryBullet)
                    return (MiniBossTriangleBatteryBullet*)p_triangleBatteryBullet;
            }
        }

        [FieldOffset(2516)] public unsafe fixed byte /* MiniBossPlayerFallBullet[3] */ _playerFallBullet[120];

        public unsafe MiniBossPlayerFallBullet* playerFallBullet
        {
            get
            {
                fixed (byte* p_playerFallBullet = _playerFallBullet)
                    return (MiniBossPlayerFallBullet*)p_playerFallBullet;
            }
        }

        [FieldOffset(2636)] public unsafe fixed byte /* MiniBossGatlingRevolverBullet[3] */ _gatlingRevolverBullet[120];

        public unsafe MiniBossGatlingRevolverBullet* gatlingRevolverBullet
        {
            get
            {
                fixed (byte* p_gatlingRevolverBullet = _gatlingRevolverBullet)
                    return (MiniBossGatlingRevolverBullet*)p_gatlingRevolverBullet;
            }
        }

        [FieldOffset(2756)] public unsafe fixed byte /* MiniBossWinderBullet[3] */ _winderBullet[132];

        public unsafe MiniBossWinderBullet* winderBullet
        {
            get
            {
                fixed (byte* p_winderBullet = _winderBullet)
                    return (MiniBossWinderBullet*)p_winderBullet;
            }
        }

        [FieldOffset(2888)] public unsafe fixed byte /* MiniBossShotgunBullet[3] */ _shotgunBullet[132];

        public unsafe MiniBossShotgunBullet* shotgunBullet
        {
            get
            {
                fixed (byte* p_shotgunBullet = _shotgunBullet)
                    return (MiniBossShotgunBullet*)p_shotgunBullet;
            }
        }

        [FieldOffset(3020)] public unsafe fixed byte /* MiniBossChagerAirDrop[3] */ _airDrop[144];

        public unsafe MiniBossChagerAirDrop* airDrop
        {
            get
            {
                fixed (byte* p_airDrop = _airDrop)
                    return (MiniBossChagerAirDrop*)p_airDrop;
            }
        }

        [FieldOffset(3164)] public unsafe fixed byte /* MiniBossChagerGroundObj[3] */ _groundObj[180];

        public unsafe MiniBossChagerGroundObj* groundObj
        {
            get
            {
                fixed (byte* p_groundObj = _groundObj)
                    return (MiniBossChagerGroundObj*)p_groundObj;
            }
        }

        [FieldOffset(3344)] public unsafe fixed byte /* MiniBossChagerDiffuseLaser[3] */ _diffuseLaser[1008];

        public unsafe MiniBossChagerDiffuseLaser* diffuseLaser
        {
            get
            {
                fixed (byte* p_diffuseLaser = _diffuseLaser)
                    return (MiniBossChagerDiffuseLaser*)p_diffuseLaser;
            }
        }

        [FieldOffset(4352)] public unsafe fixed byte /* MiniBossChagerChaseShot[3] */ _chaseShot[1152];

        public unsafe MiniBossChagerChaseShot* chaseShot
        {
            get
            {
                fixed (byte* p_chaseShot = _chaseShot)
                    return (MiniBossChagerChaseShot*)p_chaseShot;
            }
        }

        [FieldOffset(5504)] public MiniBossChargerCatchParam atkCatch;
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

    [StructLayout(LayoutKind.Explicit, Size = 60)]
    public struct MiniBossChargerLevelParam
    {
        [FieldOffset(0)]  public int level;
        [FieldOffset(4)]  public MiniBossLevelCommonConfig commonConfig;
        [FieldOffset(56)] public float stunTime;
    }

    public enum AttackType : int
{
        AttackTypeInvalid = 0,
        AttackSimpleRotateBullet = 1,
        AttackFollowLaser = 2,
        AttackVortexLaser = 3,
        AttackCrossLaser = 4,
        AttackCrossBullet = 5,
        AttackMassLaser = 6,
        AttackVerticalRoundBullet = 7,
        AttackPyramidRoundBullet = 8,
        AttackPlaneUpDownBullet = 9,
        AttackTriangleBatteryBullet = 10,
        AttackPlayerFallBullet = 11,
        AttackGatlingRevolverBullet = 12,
        AttackWinderBullet = 13,
        AttackShotgunBullet = 14,
        AttackAirDropBullet = 15,
        AttackChaseShotObject = 16,
        AttackDiffuseLaser = 17,
        AttackChaseShot = 18,
        AttackTypeNum = 19
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct MiniBossChargerHPRateParam
    {
        [FieldOffset(0)] public int rateHp;
        [FieldOffset(8)] public CString grindSetName;
    }

    [StructLayout(LayoutKind.Explicit, Size = 184)]
    public struct MiniBossChargerLevelBand
    {
        [FieldOffset(0)]   public int level;
        [FieldOffset(4)]   public float rate;
        [FieldOffset(8)]   public float chanceTime;
        [FieldOffset(12)]  public float chanceTimeMoveSpeed;
        [FieldOffset(16)]  public float chanceTimeDecSpeed;
        [FieldOffset(20)]  public float chanceTimeSpeedMin;
        [FieldOffset(24)]  public float damageTime;
        [FieldOffset(28)]  public float chanceTimeAddSpeed;
        [FieldOffset(32)]  public unsafe fixed byte /* AttackType[10] */ _attackTable[40];

        public unsafe AttackType* attackTable
        {
            get
            {
                fixed (byte* p_attackTable = _attackTable)
                    return (AttackType*)p_attackTable;
            }
        }

        [FieldOffset(72)]  public unsafe fixed int attackIndexTable[10];
        [FieldOffset(112)] public unsafe fixed byte /* MiniBossChargerHPRateParam[3] */ _hpRateParams[72];

        public unsafe MiniBossChargerHPRateParam* hpRateParams
        {
            get
            {
                fixed (byte* p_hpRateParams = _hpRateParams)
                    return (MiniBossChargerHPRateParam*)p_hpRateParams;
            }
        }
    }

    public enum MiniBossChargerLevel1_AttackType : int
{
        MiniBossChargerLevel1_AttackType_AttackTypeInvalid = 0,
        MiniBossChargerLevel1_AttackType_AttackSimpleRotateBullet = 1,
        MiniBossChargerLevel1_AttackType_AttackFollowLaser = 2,
        MiniBossChargerLevel1_AttackType_AttackVortexLaser = 3,
        MiniBossChargerLevel1_AttackType_AttackCrossLaser = 4,
        MiniBossChargerLevel1_AttackType_AttackCrossBullet = 5,
        MiniBossChargerLevel1_AttackType_AttackMassLaser = 6,
        MiniBossChargerLevel1_AttackType_AttackVerticalRoundBullet = 7,
        MiniBossChargerLevel1_AttackType_AttackPyramidRoundBullet = 8,
        MiniBossChargerLevel1_AttackType_AttackPlaneUpDownBullet = 9,
        MiniBossChargerLevel1_AttackType_AttackTriangleBatteryBullet = 10,
        MiniBossChargerLevel1_AttackType_AttackPlayerFallBullet = 11,
        MiniBossChargerLevel1_AttackType_AttackGatlingRevolverBullet = 12,
        MiniBossChargerLevel1_AttackType_AttackWinderBullet = 13,
        MiniBossChargerLevel1_AttackType_AttackShotgunBullet = 14,
        MiniBossChargerLevel1_AttackType_AttackAirDropBullet = 15,
        MiniBossChargerLevel1_AttackType_AttackChaseShotObject = 16,
        MiniBossChargerLevel1_AttackType_AttackDiffuseLaser = 17,
        MiniBossChargerLevel1_AttackType_AttackChaseShot = 18,
        MiniBossChargerLevel1_AttackType_AttackTypeNum = 19
    }

    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public struct MiniBossChargerLevel1
    {
        [FieldOffset(0)]  public float range;
        [FieldOffset(4)]  public unsafe fixed byte /* MiniBossChargerLevel1_AttackType[2] */ _attackTable[8];

        public unsafe MiniBossChargerLevel1_AttackType* attackTable
        {
            get
            {
                fixed (byte* p_attackTable = _attackTable)
                    return (MiniBossChargerLevel1_AttackType*)p_attackTable;
            }
        }

        [FieldOffset(12)] public unsafe fixed int attackIndexTable[2];
    }

    [StructLayout(LayoutKind.Explicit, Size = 6832)]
    public struct MiniBossChargerConfig
    {
        [FieldOffset(0)]    public MiniBossChargerCommonParam commonParam;
        [FieldOffset(5568)] public unsafe fixed byte /* MiniBossChargerLevelParam[5] */ _levelParams[300];

        public unsafe MiniBossChargerLevelParam* levelParams
        {
            get
            {
                fixed (byte* p_levelParams = _levelParams)
                    return (MiniBossChargerLevelParam*)p_levelParams;
            }
        }

        [FieldOffset(5872)] public unsafe fixed byte /* MiniBossChargerLevelBand[5] */ _levelBands[920];

        public unsafe MiniBossChargerLevelBand* levelBands
        {
            get
            {
                fixed (byte* p_levelBands = _levelBands)
                    return (MiniBossChargerLevelBand*)p_levelBands;
            }
        }

        [FieldOffset(6792)] public unsafe fixed byte /* MiniBossChargerLevel1[2] */ _level1Params[40];

        public unsafe MiniBossChargerLevel1* level1Params
        {
            get
            {
                fixed (byte* p_level1Params = _level1Params)
                    return (MiniBossChargerLevel1*)p_level1Params;
            }
        }
    }

}