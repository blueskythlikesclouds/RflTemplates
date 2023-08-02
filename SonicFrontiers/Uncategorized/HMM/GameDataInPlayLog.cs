Library "GameDataInPlayLog"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    public enum Status : sbyte
{
        STATUS_ZERO_FILL = 0,
        STATUS_INITIALIZED = 1
    }

    public enum Sequence : sbyte
{
        Island1 = 0,
        Island2 = 1,
        Island3 = 2,
        Island4 = 3,
        Island5 = 4,
        FinalBossBefore = 5,
        FinalBossAfter = 6
    }

    public enum SaveDataIcon : sbyte
{
        IconNoData = 0,
        IconIsland1 = 1,
        IconIsland2 = 2,
        IconIsland3 = 3,
        IconIsland4 = 4,
        IconIsland5 = 5,
        IconLastBoss = 6
    }

    public enum AppVersion : byte
{
        AppVersion_1_10 = 0,
        AppVersion_1_20 = 1,
        AppVersion_1_30 = 2,
        AppVersion_1_40 = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public struct HeaderData
    {
        [FieldOffset(0)]  public uint signature;
        [FieldOffset(4)]  public byte version;
        [FieldOffset(5)]  public Status status;
        [FieldOffset(6)]  public byte config;
        [FieldOffset(7)]  public Sequence sequence;
        [FieldOffset(8)]  public uint playTime;
        [FieldOffset(12)] public SaveDataIcon icon;
        [FieldOffset(13)] public AppVersion appVersion;
        [FieldOffset(14)] public byte config2;
        [FieldOffset(15)] public byte reserved1;
        [FieldOffset(16)] public uint saveDate;
        [FieldOffset(20)] public byte index;
        [FieldOffset(24)] public unsafe fixed uint reserved[4];
    }

    public enum GamePlayData_Status : sbyte
{
        STATUS_NEWGAME = 0,
        STATUS_CONTINUE = 1
    }

    public enum SequenceDeprecated : sbyte
{
        SequenceDeprecated_Island1 = 0,
        SequenceDeprecated_Island2 = 1,
        SequenceDeprecated_Island3 = 2,
        SequenceDeprecated_Island4 = 3,
        SequenceDeprecated_Island5 = 4,
        SequenceDeprecated_FinalBossBefore = 5,
        SequenceDeprecated_FinalBossAfter = 6
    }

    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public struct GamePlayData
    {
        [FieldOffset(0)]  public GamePlayData_Status status;
        [FieldOffset(1)]  public sbyte lastPlayedStageNo;
        [FieldOffset(2)]  public byte flags;
        [FieldOffset(3)]  public SequenceDeprecated sequence;
        [FieldOffset(16)] public Vector3 position;
        [FieldOffset(32)] public Quaternion rotation;
        [FieldOffset(48)] public uint day;
        [FieldOffset(52)] public uint hour;
        [FieldOffset(56)] public uint minute;
        [FieldOffset(60)] public float second;
        [FieldOffset(64)] public unsafe fixed uint reserved[4];
    }

    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public struct CharacterData
    {
        [FieldOffset(0)]  public ushort numRings;
        [FieldOffset(2)]  public byte ringLevel;
        [FieldOffset(3)]  public byte speedLevel;
        [FieldOffset(4)]  public byte obtainChaosEmeralds;
        [FieldOffset(5)]  public byte hasChaosEmeralds;
        [FieldOffset(6)]  public unsafe fixed byte skillLevel[30];
        [FieldOffset(36)] public byte skillPointOld;
        [FieldOffset(37)] public byte levelOld;
        [FieldOffset(38)] public ushort padding0;
        [FieldOffset(40)] public uint expPoint;
        [FieldOffset(44)] public byte powerLevel;
        [FieldOffset(45)] public byte guardLevel;
        [FieldOffset(46)] public ushort boostGaugeLevel;
        [FieldOffset(48)] public uint numPowerSeeds;
        [FieldOffset(52)] public uint numGuardSeeds;
        [FieldOffset(56)] public ushort numFishCoins;
        [FieldOffset(58)] public ushort numFishTokens;
        [FieldOffset(60)] public ushort numGoldCards;
        [FieldOffset(62)] public ushort numSlotStars;
        [FieldOffset(64)] public float quickCyloopGauge;
        [FieldOffset(68)] public uint practiceMaxCleared;
        [FieldOffset(72)] public uint practiceMaxCombos;
        [FieldOffset(76)] public uint flags;
        [FieldOffset(80)] public short skillPoint;
        [FieldOffset(82)] public short level;
        [FieldOffset(84)] public uint dlcrsvExpPoint;
        [FieldOffset(88)] public uint dlcrsvNumPowerSeeds;
        [FieldOffset(92)] public uint dlcrsvNumGuardSeeds;
    }

    [StructLayout(LayoutKind.Explicit, Size = 2)]
    public struct IslandMapGridData
    {
        [FieldOffset(0)] public byte x;
        [FieldOffset(1)] public byte y;
    }

    [StructLayout(LayoutKind.Explicit, Size = 274)]
    public struct IslandMapData
    {
        [FieldOffset(0)]   public unsafe fixed byte /* IslandMapGridData[136] */ _grid[272];

        public unsafe IslandMapGridData* grid
        {
            get
            {
                fixed (byte* p_grid = _grid)
                    return (IslandMapGridData*)p_grid;
            }
        }

        [FieldOffset(272)] public ushort numReleaseGrids;
    }

    [StructLayout(LayoutKind.Explicit, Size = 320)]
    public struct IslandStageData
    {
        [FieldOffset(0)]   public Vector3 destination;
        [FieldOffset(16)]  public uint flags;
        [FieldOffset(20)]  public IslandMapData map;
        [FieldOffset(296)] public unsafe fixed uint reserved[4];
    }

    [StructLayout(LayoutKind.Explicit, Size = 1600)]
    public struct IslandStageContainerData
    {
        [FieldOffset(0)] public unsafe fixed byte /* IslandStageData[5] */ _islands[1600];

        public unsafe IslandStageData* islands
        {
            get
            {
                fixed (byte* p_islands = _islands)
                    return (IslandStageData*)p_islands;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct CyberStageData
    {
        [FieldOffset(0)] public ushort flags;
        [FieldOffset(4)] public uint bestTime;
        [FieldOffset(8)] public unsafe fixed uint reserved[4];
    }

    [StructLayout(LayoutKind.Explicit, Size = 768)]
    public struct CyberStageContainerData
    {
        [FieldOffset(0)] public unsafe fixed byte /* CyberStageData[32] */ _actStages[768];

        public unsafe CyberStageData* actStages
        {
            get
            {
                fixed (byte* p_actStages = _actStages)
                    return (CyberStageData*)p_actStages;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 288)]
    public struct FlagContainerData
    {
        [FieldOffset(0)]   public unsafe fixed uint bitFlags[24];
        [FieldOffset(96)]  public unsafe fixed sbyte byteFlags[128];
        [FieldOffset(224)] public unsafe fixed uint intDatas[16];
    }

    [StructLayout(LayoutKind.Explicit, Size = 7168)]
    public struct WorldFlagData
    {
        [FieldOffset(0)]    public unsafe fixed uint bitFlags[1024];
        [FieldOffset(4096)] public unsafe fixed sbyte byteFlags[1024];
        [FieldOffset(5120)] public unsafe fixed uint intDatas[512];
    }

    [StructLayout(LayoutKind.Explicit, Size = 43008)]
    public struct WorldFlagContainerData
    {
        [FieldOffset(0)]     public unsafe fixed byte /* WorldFlagData[5] */ _worldDatas[35840];

        public unsafe WorldFlagData* worldDatas
        {
            get
            {
                fixed (byte* p_worldDatas = _worldDatas)
                    return (WorldFlagData*)p_worldDatas;
            }
        }

        [FieldOffset(35840)] public WorldFlagData debugWorldData;
    }

    [StructLayout(LayoutKind.Explicit, Size = 6)]
    public struct PlayLogCoordData
    {
        [FieldOffset(0)] public ushort time;
        [FieldOffset(2)] public ushort x;
        [FieldOffset(4)] public ushort z;
    }

    public enum EventType : sbyte
{
        InvalidEvent = -1,
        Dead = 0,
        BeginStage = 1,
        EndStage = 2,
        ReleaseLightPillar = 3,
        ObtainChaosEmerald = 4,
        ContactMiniboss = 5,
        DefeatMiniboss = 6,
        BeginCyberStage = 7,
        EndCyberStage = 8,
        CompleteCyberStage = 9,
        RestartCyberStage = 10,
        GiveupCyberStage = 11,
        OpenTreasureChest = 12,
        AccessRingSensor = 13
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct PlayLogEventData
    {
        [FieldOffset(0)] public PlayLogCoordData coord;
        [FieldOffset(6)] public EventType eventType;
        [FieldOffset(7)] public sbyte option;
    }

    [StructLayout(LayoutKind.Explicit, Size = 616016)]
    public struct PlayLogData
    {
        [FieldOffset(0)]      public uint numFootMarks;
        [FieldOffset(4)]      public uint footMarksIndex;
        [FieldOffset(8)]      public unsafe fixed byte /* PlayLogCoordData[36000] */ _footmarks[216000];

        public unsafe PlayLogCoordData* footmarks
        {
            get
            {
                fixed (byte* p_footmarks = _footmarks)
                    return (PlayLogCoordData*)p_footmarks;
            }
        }

        [FieldOffset(216008)] public uint numEvents;
        [FieldOffset(216012)] public uint eventsIndex;
        [FieldOffset(216016)] public unsafe fixed byte /* PlayLogEventData[50000] */ _events[400000];

        public unsafe PlayLogEventData* events
        {
            get
            {
                fixed (byte* p_events = _events)
                    return (PlayLogEventData*)p_events;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct StatValue
    {
        [FieldOffset(0)] public int value;
        [FieldOffset(4)] public bool assigned;
    }

    [StructLayout(LayoutKind.Explicit, Size = 27144)]
    public struct StatsContainerData
    {
        [FieldOffset(0)] public unsafe fixed byte /* StatValue[3393] */ _stats[27144];

        public unsafe StatValue* stats
        {
            get
            {
                fixed (byte* p_stats = _stats)
                    return (StatValue*)p_stats;
            }
        }
    }

    public enum Type : sbyte
{
        Sunny = 0,
        Cloudy = 1,
        Rainy = 2,
        SandStorm = 3,
        MeteorShower = 4,
        Num = 5
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct WeatherTimerData
    {
        [FieldOffset(0)] public float duration;
        [FieldOffset(4)] public float time;
    }

    public enum WeatherBlockData_Type : sbyte
{
        WeatherBlockData_Type_Sunny = 0,
        WeatherBlockData_Type_Cloudy = 1,
        WeatherBlockData_Type_Rainy = 2,
        WeatherBlockData_Type_SandStorm = 3,
        WeatherBlockData_Type_MeteorShower = 4,
        WeatherBlockData_Type_Num = 5
    }

    public enum WeatherBlockData_Status : sbyte
{
        None = 0,
        Wait = 1,
        Active = 2,
        External = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public struct WeatherBlockData
    {
        [FieldOffset(0)]  public WeatherBlockData_Type weather;
        [FieldOffset(4)]  public uint hour;
        [FieldOffset(8)]  public uint minute;
        [FieldOffset(12)] public float second;
        [FieldOffset(16)] public WeatherBlockData_Status status;
    }

    [StructLayout(LayoutKind.Explicit, Size = 52)]
    public struct WeatherData
    {
        [FieldOffset(0)]  public Type currentWeather;
        [FieldOffset(1)]  public Type prevWeather;
        [FieldOffset(4)]  public WeatherTimerData timer;
        [FieldOffset(12)] public WeatherBlockData block;
        [FieldOffset(32)] public int stageNo;
        [FieldOffset(36)] public unsafe fixed uint reserved[4];
    }

    [StructLayout(LayoutKind.Explicit, Size = 689104)]
    public struct GameDataInPlayLog
    {
        [FieldOffset(0)]      public HeaderData header;
        [FieldOffset(48)]     public GamePlayData gameplay;
        [FieldOffset(128)]    public CharacterData character;
        [FieldOffset(224)]    public IslandStageContainerData islands;
        [FieldOffset(1824)]   public CyberStageContainerData stages;
        [FieldOffset(2592)]   public FlagContainerData flags;
        [FieldOffset(2880)]   public WorldFlagContainerData worldFlags;
        [FieldOffset(45888)]  public PlayLogData playlog;
        [FieldOffset(661904)] public StatsContainerData stats;
        [FieldOffset(689048)] public WeatherData weather;
    }

}