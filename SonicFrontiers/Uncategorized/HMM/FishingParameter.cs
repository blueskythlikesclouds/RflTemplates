Library "FishingParameter"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public struct FishingCommonParam
    {
        [FieldOffset(0)]  public float baseWaveThickness;
        [FieldOffset(4)]  public float baseWaveSuccessRatioNormal;
        [FieldOffset(8)]  public float baseWaveSuccessRatioHold;
        [FieldOffset(12)] public float singleWaveThickness;
        [FieldOffset(16)] public float baseWaveEdgeThickness;
        [FieldOffset(20)] public float timingEdgeThickness;
        [FieldOffset(24)] public uint fishShadowNum;
        [FieldOffset(28)] public float fishApproachIntervalMin;
        [FieldOffset(32)] public float fishApproachIntervalMax;
        [FieldOffset(36)] public float fishEscapeDistance;
        [FieldOffset(40)] public uint buoyTwitchNumMin;
        [FieldOffset(44)] public uint buoyTwitchNumMax;
        [FieldOffset(48)] public float buoyTwitchIntervalMin;
        [FieldOffset(52)] public float buoyTwitchIntervalMax;
        [FieldOffset(56)] public float inputValidTime;
        [FieldOffset(60)] public float fishingCameraTransitDelay;
        [FieldOffset(64)] public float cutinDelay;
        [FieldOffset(68)] public float cutinDuration;
        [FieldOffset(72)] public float successPullUpDelay;
        [FieldOffset(76)] public uint goldenChestLimitNum;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct FishingSuccessPatternParam
    {
        [FieldOffset(0)] public uint successNum;
        [FieldOffset(4)] public uint failureNum;
    }

    public enum Type : sbyte
{
        TYPE_INVALID = 0,
        TYPE_NORMAL = 1,
        TYPE_HOLD = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct FishingWaveParam
    {
        [FieldOffset(0)] public Type type;
        [FieldOffset(4)] public float radius;
        [FieldOffset(8)] public float thickness;
    }

    [StructLayout(LayoutKind.Explicit, Size = 60)]
    public struct FishingWaveGroupParam
    {
        [FieldOffset(0)] public unsafe fixed byte /* FishingWaveParam[5] */ _waves[60];

        public unsafe FishingWaveParam* waves
        {
            get
            {
                fixed (byte* p_waves = _waves)
                    return (FishingWaveParam*)p_waves;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 632)]
    public struct FishingWavePatternParam
    {
        [FieldOffset(0)]  public float speed;
        [FieldOffset(4)]  public float intervalMinFirst;
        [FieldOffset(8)]  public float intervalMaxFirst;
        [FieldOffset(12)] public float intervalMin;
        [FieldOffset(16)] public float intervalMax;
        [FieldOffset(20)] public float addRadiusMin;
        [FieldOffset(24)] public float addRadiusMax;
        [FieldOffset(28)] public uint waveGroupNum;
        [FieldOffset(32)] public unsafe fixed byte /* FishingWaveGroupParam[10] */ _waveGroups[600];

        public unsafe FishingWaveGroupParam* waveGroups
        {
            get
            {
                fixed (byte* p_waveGroups = _waveGroups)
                    return (FishingWaveGroupParam*)p_waveGroups;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct FishingFishGroupParam
    {
        [FieldOffset(0)] public float rate;
    }

    public enum FishShadowType : sbyte
{
        SMALL = 0,
        MEDIUM = 1,
        LARGE = 2
    }

    public enum CatchUpMotionType : sbyte
{
        SHADOW_SIZE = 0,
        LARGE_GOOD_FISH = 1,
        LARGE_GOOD_ITEM = 2,
        LARGE_BAD = 3,
        CatchUpMotionType_LARGE = 4,
        CatchUpMotionType_MEDIUM = 5,
        CatchUpMotionType_SMALL = 6,
        CHEST_GOOD = 7,
        CHEST_VERYGOOD = 8,
        SCROLL = 9
    }

    public enum ToastType : sbyte
{
        MOTION = 0,
        PATTERN_1 = 1,
        PATTERN_2 = 2,
        PATTERN_3 = 3,
        PATTERN_4 = 4
    }

    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public struct FishingFishParam
    {
        [FieldOffset(0)]  public int fishGroupId;
        [FieldOffset(4)]  public FishShadowType shadowType;
        [FieldOffset(8)]  public uint successPatternId;
        [FieldOffset(12)] public uint wavePatternId;
        [FieldOffset(16)] public uint expPoint;
        [FieldOffset(20)] public uint tokenNum;
        [FieldOffset(24)] public bool isRare;
        [FieldOffset(25)] public CatchUpMotionType catchUpMotionType;
        [FieldOffset(26)] public ToastType toastType;
        [FieldOffset(32)] public Vector3 catchUpOffsetPos;
        [FieldOffset(48)] public Vector3 catchUpOffsetRot;
    }

    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public struct FishingSpotSpawnFishParam
    {
        [FieldOffset(0)] public unsafe fixed int spawnFishId[20];
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct FishingFixedResultParam
    {
        [FieldOffset(0)] public int count;
        [FieldOffset(4)] public int fishId;
    }

    [StructLayout(LayoutKind.Explicit, Size = 408)]
    public struct FishingSpotFixedResultParam
    {
        [FieldOffset(0)] public uint tableSize;
        [FieldOffset(4)] public uint achievementUnlockCount;
        [FieldOffset(8)] public unsafe fixed byte /* FishingFixedResultParam[50] */ _fixedResultList[400];

        public unsafe FishingFixedResultParam* fixedResultList
        {
            get
            {
                fixed (byte* p_fixedResultList = _fixedResultList)
                    return (FishingFixedResultParam*)p_fixedResultList;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 1984)]
    public struct FishingSpotParam
    {
        [FieldOffset(0)]    public unsafe fixed byte /* FishingSpotSpawnFishParam[4] */ _spawnFish[320];

        public unsafe FishingSpotSpawnFishParam* spawnFish
        {
            get
            {
                fixed (byte* p_spawnFish = _spawnFish)
                    return (FishingSpotSpawnFishParam*)p_spawnFish;
            }
        }

        [FieldOffset(320)]  public unsafe fixed byte /* FishingSpotFixedResultParam[4] */ _fixedResults[1632];

        public unsafe FishingSpotFixedResultParam* fixedResults
        {
            get
            {
                fixed (byte* p_fixedResults = _fixedResults)
                    return (FishingSpotFixedResultParam*)p_fixedResults;
            }
        }

        [FieldOffset(1952)] public unsafe fixed uint useFishCoinNum[4];
        [FieldOffset(1968)] public unsafe fixed uint tokenRate[4];
    }

    [StructLayout(LayoutKind.Explicit, Size = 1272)]
    public struct FishingTutorialParam
    {
        [FieldOffset(0)]   public uint singleWaveSuccessCount;
        [FieldOffset(4)]   public uint holdWaveSuccessCount;
        [FieldOffset(8)]   public FishingWavePatternParam singleWave;
        [FieldOffset(640)] public FishingWavePatternParam holdWave;
    }

    [StructLayout(LayoutKind.Explicit, Size = 9)]
    public struct FishingTradeTableParma
    {
        [FieldOffset(0)] public unsafe fixed byte sales[9];
    }

    [StructLayout(LayoutKind.Explicit, Size = 63)]
    public struct FishingTradeParam
    {
        [FieldOffset(0)]  public unsafe fixed byte /* FishingTradeTableParma[4] */ _spot[36];

        public unsafe FishingTradeTableParma* spot
        {
            get
            {
                fixed (byte* p_spot = _spot)
                    return (FishingTradeTableParma*)p_spot;
            }
        }

        [FieldOffset(36)] public unsafe fixed byte prices[9];
        [FieldOffset(45)] public unsafe fixed byte pricesVeryHard[9];
        [FieldOffset(54)] public unsafe fixed byte counts[9];
    }

    [StructLayout(LayoutKind.Explicit, Size = 18176)]
    public struct FishingParameter
    {
        [FieldOffset(0)]     public FishingCommonParam common;
        [FieldOffset(80)]    public unsafe fixed byte /* FishingSuccessPatternParam[10] */ _successPattern[80];

        public unsafe FishingSuccessPatternParam* successPattern
        {
            get
            {
                fixed (byte* p_successPattern = _successPattern)
                    return (FishingSuccessPatternParam*)p_successPattern;
            }
        }

        [FieldOffset(160)]   public unsafe fixed byte /* FishingWavePatternParam[10] */ _wavePattern[6320];

        public unsafe FishingWavePatternParam* wavePattern
        {
            get
            {
                fixed (byte* p_wavePattern = _wavePattern)
                    return (FishingWavePatternParam*)p_wavePattern;
            }
        }

        [FieldOffset(6480)]  public unsafe fixed byte /* FishingFishGroupParam[10] */ _fishGroup[40];

        public unsafe FishingFishGroupParam* fishGroup
        {
            get
            {
                fixed (byte* p_fishGroup = _fishGroup)
                    return (FishingFishGroupParam*)p_fishGroup;
            }
        }

        [FieldOffset(6528)]  public unsafe fixed byte /* FishingFishParam[130] */ _fish[8320];

        public unsafe FishingFishParam* fish
        {
            get
            {
                fixed (byte* p_fish = _fish)
                    return (FishingFishParam*)p_fish;
            }
        }

        [FieldOffset(14848)] public FishingSpotParam spot;
        [FieldOffset(16832)] public FishingTutorialParam tutorial;
        [FieldOffset(18104)] public FishingTradeParam trade;
    }

}