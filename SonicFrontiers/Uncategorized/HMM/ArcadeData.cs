Library "ArcadeData"
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

    [StructLayout(LayoutKind.Explicit, Size = 828)]
    public struct ArcadeData
    {
        [FieldOffset(0)]   public HeaderData header;
        [FieldOffset(40)]  public bool unlocked;
        [FieldOffset(44)]  public CyberStageContainerData stages;
        [FieldOffset(812)] public unsafe fixed uint reserved[4];
    }

}