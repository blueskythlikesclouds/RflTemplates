using System.Numerics;
using System.Runtime.InteropServices;

public class RetroRflParamClass
{
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

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct RetroSfxData
    {
        [FieldOffset(0)]  public CString m_sfx;
        [FieldOffset(16)] public CString m_cue;
        [FieldOffset(32)] public CString m_music;
    }

    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public struct RetroMusicData
    {
        [FieldOffset(0)]  public CString m_music;
        [FieldOffset(16)] public CString m_cue;
        [FieldOffset(32)] public float m_speed;
    }

    public enum StageKind : sbyte
    {
        STAGEKIND_NONE = 0,
        STAGEKIND_SONIC1_START = 1,
        STAGEKIND_GREEN_HILL_ZONE_ACT_1 = 1,
        STAGEKIND_GREEN_HILL_ZONE_ACT_2 = 2,
        STAGEKIND_GREEN_HILL_ZONE_ACT_3 = 3,
        STAGEKIND_MARBLE_ZONE_ACT_1 = 4,
        STAGEKIND_MARBLE_ZONE_ACT_2 = 5,
        STAGEKIND_MARBLE_ZONE_ACT_3 = 6,
        STAGEKIND_SPRING_YARD_ZONE_ACT_1 = 7,
        STAGEKIND_SPRING_YARD_ZONE_ACT_2 = 8,
        STAGEKIND_SPRING_YARD_ZONE_ACT_3 = 9,
        STAGEKIND_LABYRINTH_ZONE_ACT_1 = 10,
        STAGEKIND_LABYRINTH_ZONE_ACT_2 = 11,
        STAGEKIND_LABYRINTH_ZONE_ACT_3 = 12,
        STAGEKIND_STAR_LIGHT_ZONE_ACT_1 = 13,
        STAGEKIND_STAR_LIGHT_ZONE_ACT_2 = 14,
        STAGEKIND_STAR_LIGHT_ZONE_ACT_3 = 15,
        STAGEKIND_SCRAP_BRAIN_ZONE_ACT_1 = 16,
        STAGEKIND_SCRAP_BRAIN_ZONE_ACT_2 = 17,
        STAGEKIND_SCRAP_BRAIN_ZONE_ACT_3 = 18,
        STAGEKIND_FINAL_ZONE = 19,
        STAGEKIND_SONIC1_SPECIAL_STAGE_1 = 20,
        STAGEKIND_SONIC1_SPECIAL_STAGE_2 = 21,
        STAGEKIND_SONIC1_SPECIAL_STAGE_3 = 22,
        STAGEKIND_SONIC1_SPECIAL_STAGE_4 = 23,
        STAGEKIND_SONIC1_SPECIAL_STAGE_5 = 24,
        STAGEKIND_SONIC1_SPECIAL_STAGE_6 = 25,
        STAGEKIND_SONIC1_ALL_STAGE = 26,
        STAGEKIND_SONIC1_END = 27,
        STAGEKIND_SONIC2_START = 27,
        STAGEKIND_EMERALD_HILL_ZONE_ACT_1 = 27,
        STAGEKIND_EMERALD_HILL_ZONE_ACT_2 = 28,
        STAGEKIND_CHEMICAL_PLANT_ZONE_ACT_1 = 29,
        STAGEKIND_CHEMICAL_PLANT_ZONE_ACT_2 = 30,
        STAGEKIND_AQUATIC_RUIN_ZONE_ACT_1 = 31,
        STAGEKIND_AQUATIC_RUIN_ZONE_ACT_2 = 32,
        STAGEKIND_CASINO_NIGHT_ZONE_ACT_1 = 33,
        STAGEKIND_CASINO_NIGHT_ZONE_ACT_2 = 34,
        STAGEKIND_HILL_TOP_ZONE_ACT_1 = 35,
        STAGEKIND_HILL_TOP_ZONE_ACT_2 = 36,
        STAGEKIND_MYSTIC_CAVE_ZONE_ACT_1 = 37,
        STAGEKIND_MYSTIC_CAVE_ZONE_ACT_2 = 38,
        STAGEKIND_OIL_OCEAN_ZONE_ACT_1 = 39,
        STAGEKIND_OIL_OCEAN_ZONE_ACT_2 = 40,
        STAGEKIND_METROPOLIS_ZONE_ACT_1 = 41,
        STAGEKIND_METROPOLIS_ZONE_ACT_2 = 42,
        STAGEKIND_METROPOLIS_ZONE_ACT_3 = 43,
        STAGEKIND_SKY_CHASE_ZONE = 44,
        STAGEKIND_WING_FORTRESS_ZONE = 45,
        STAGEKIND_DEATH_EGG_ZONE = 46,
        STAGEKIND_SONIC2_SPECIAL_STAGE_1 = 47,
        STAGEKIND_SONIC2_SPECIAL_STAGE_2 = 48,
        STAGEKIND_SONIC2_SPECIAL_STAGE_3 = 49,
        STAGEKIND_SONIC2_SPECIAL_STAGE_4 = 50,
        STAGEKIND_SONIC2_SPECIAL_STAGE_5 = 51,
        STAGEKIND_SONIC2_SPECIAL_STAGE_6 = 52,
        STAGEKIND_SONIC2_SPECIAL_STAGE_7 = 53,
        STAGEKIND_SONIC2_ALL_STAGE = 54,
        STAGEKIND_SONIC2_END = 55,
        STAGEKIND_SONIC3K_START = 55,
        STAGEKIND_ANGEL_ISLAND_ZONE_ACT_1 = 55,
        STAGEKIND_ANGEL_ISLAND_ZONE_ACT_2 = 56,
        STAGEKIND_HYDROCITY_ZONE_ACT_1 = 57,
        STAGEKIND_HYDROCITY_ZONE_ACT_2 = 58,
        STAGEKIND_MARBLE_GARDEN_ZONE_ACT_1 = 59,
        STAGEKIND_MARBLE_GARDEN_ZONE_ACT_2 = 60,
        STAGEKIND_CARNIVAL_NIGHT_ZONE_ACT_1 = 61,
        STAGEKIND_CARNIVAL_NIGHT_ZONE_ACT_2 = 62,
        STAGEKIND_ICE_CAP_ZONE_ACT_1 = 63,
        STAGEKIND_ICE_CAP_ZONE_ACT_2 = 64,
        STAGEKIND_LAUNCH_BASE_ZONE_ACT_1 = 65,
        STAGEKIND_LAUNCH_BASE_ZONE_ACT_2 = 66,
        STAGEKIND_MUSHROOM_HILL_ZONE_ACT_1 = 67,
        STAGEKIND_MUSHROOM_HILL_ZONE_ACT_2 = 68,
        STAGEKIND_FLYING_BATTERY_ZONE_ACT_1 = 69,
        STAGEKIND_FLYING_BATTERY_ZONE_ACT_2 = 70,
        STAGEKIND_SANDOPOLIS_ZONE_ACT_1 = 71,
        STAGEKIND_SANDOPOLIS_ZONE_ACT_2 = 72,
        STAGEKIND_LAVA_REEF_ZONE_ACT_1 = 73,
        STAGEKIND_LAVA_REEF_ZONE_ACT_2 = 74,
        STAGEKIND_HIDDEN_PALACE_ZONE = 75,
        STAGEKIND_SKY_SANCTUARY_ZONE_ACT_1 = 76,
        STAGEKIND_SKY_SANCTUARY_ZONE_ACT_2 = 77,
        STAGEKIND_DEATH_EGG_ZONE_ACT_1 = 78,
        STAGEKIND_DEATH_EGG_ZONE_ACT_2 = 79,
        STAGEKIND_THE_DOOMSDAY_ZONE = 80,
        STAGEKIND_SONIC3K_SPECIAL_STAGE_1 = 81,
        STAGEKIND_SONIC3K_SPECIAL_STAGE_2 = 82,
        STAGEKIND_SONIC3K_SPECIAL_STAGE_3 = 83,
        STAGEKIND_SONIC3K_SPECIAL_STAGE_4 = 84,
        STAGEKIND_SONIC3K_SPECIAL_STAGE_5 = 85,
        STAGEKIND_SONIC3K_SPECIAL_STAGE_6 = 86,
        STAGEKIND_SONIC3K_SPECIAL_STAGE_7 = 87,
        STAGEKIND_SONIC3K_SPECIAL_STAGE_8 = 88,
        STAGEKIND_SONIC3K_SPECIAL_STAGE_9 = 89,
        STAGEKIND_SONIC3K_SPECIAL_STAGE_10 = 90,
        STAGEKIND_SONIC3K_SPECIAL_STAGE_11 = 91,
        STAGEKIND_SONIC3K_SPECIAL_STAGE_12 = 92,
        STAGEKIND_SONIC3K_SPECIAL_STAGE_13 = 93,
        STAGEKIND_SONIC3K_SPECIAL_STAGE_14 = 94,
        STAGEKIND_SONIC3K_ALL_STAGE = 95,
        STAGEKIND_SONIC3K_END = 96,
        STAGEKIND_SONICCD_START = 96,
        STAGEKIND_PALMTREE_PANIC_ZONE1 = 96,
        STAGEKIND_PALMTREE_PANIC_ZONE2 = 97,
        STAGEKIND_PALMTREE_PANIC_ZONE3 = 98,
        STAGEKIND_COLLISION_CHAOS_ZONE1 = 99,
        STAGEKIND_COLLISION_CHAOS_ZONE2 = 100,
        STAGEKIND_COLLISION_CHAOS_ZONE3 = 101,
        STAGEKIND_TIDAL_TEMPEST_ZONE1 = 102,
        STAGEKIND_TIDAL_TEMPEST_ZONE2 = 103,
        STAGEKIND_TIDAL_TEMPEST_ZONE3 = 104,
        STAGEKIND_QUARTZ_QUADRANT_ZONE1 = 105,
        STAGEKIND_QUARTZ_QUADRANT_ZONE2 = 106,
        STAGEKIND_QUARTZ_QUADRANT_ZONE3 = 107,
        STAGEKIND_WACKY_WORKBENCH_ZONE1 = 108,
        STAGEKIND_WACKY_WORKBENCH_ZONE2 = 109,
        STAGEKIND_WACKY_WORKBENCH_ZONE3 = 110,
        STAGEKIND_STARDUST_SPEEDWAY_ZONE1 = 111,
        STAGEKIND_STARDUST_SPEEDWAY_ZONE2 = 112,
        STAGEKIND_STARDUST_SPEEDWAY_ZONE3 = 113,
        STAGEKIND_METALLIC_MADNESS_ZONE1 = 114,
        STAGEKIND_METALLIC_MADNESS_ZONE2 = 115,
        STAGEKIND_METALLIC_MADNESS_ZONE3 = 116,
        STAGEKIND_SONICCD_SPECIAL_STAGE_1 = 117,
        STAGEKIND_SONICCD_SPECIAL_STAGE_2 = 118,
        STAGEKIND_SONICCD_SPECIAL_STAGE_3 = 119,
        STAGEKIND_SONICCD_SPECIAL_STAGE_4 = 120,
        STAGEKIND_SONICCD_SPECIAL_STAGE_5 = 121,
        STAGEKIND_SONICCD_SPECIAL_STAGE_6 = 122,
        STAGEKIND_SONICCD_SPECIAL_STAGE_7 = 123,
        STAGEKIND_SONICCD_ALL_STAGE = 124,
        STAGEKIND_SONICCD_END = 125,
        STAGEKIND_NUM = 125,
        STAGEKIND_SONIC1_NUM = 26,
        STAGEKIND_SONIC2_NUM = 28,
        STAGEKIND_SONIC3K_NUM = 41,
        STAGEKIND_SONICCD_NUM = 29,
        STAGEKIND_ALL_START = 1,
        STAGEKIND_ALL_END = 125,
        STAGEKIND_STORY_END = 80
    }

    public enum BossKind : sbyte
    {
        BOSSKIND_NONE = 0,
        BOSSKIND_EGG_WRECKER = 1,
        BOSSKIND_EGG_SCORCHER = 2,
        BOSSKIND_EGG_STINGER = 3,
        BOSSKIND_EGG_MOBILE_ = 4,
        BOSSKIND_EGG_SPIKER = 5,
        BOSSKIND_EGG_CRUSHER = 6,
        BOSSKIND_EGG_DRILLSTER = 7,
        BOSSKIND_EGG_POISON = 8,
        BOSSKIND_EGG_HAMMER = 9,
        BOSSKIND_EGG_CLAW = 10,
        BOSSKIND_EGG_SCORCHER_MK_II = 11,
        BOSSKIND_EGG_DIGGER = 12,
        BOSSKIND_EGGMARINE = 13,
        BOSSKIND_EGG_BOUNCER = 14,
        BOSSKIND_LASER_PRISON = 15,
        BOSSKIND_MECHA_SONIC = 16,
        BOSSKIND_DEATH_EGG_ROBO = 17,
        BOSSKIND_EGG_SCORCHER_MK_III = 18,
        BOSSKIND_EGG_VORTEX = 19,
        BOSSKIND_EGG_DRILLSTER_MK_II = 20,
        BOSSKIND_EGG_GRAVITRON = 21,
        BOSSKIND_EGG_FROSTER = 22,
        BOSSKIND_EGG_CANNON = 23,
        BOSSKIND_EGG_ROCKET = 24,
        BOSSKIND_BIG_ARMS = 25,
        BOSSKIND_EGG_SCRAMBLER = 26,
        BOSSKIND_EGG_HANGER = 27,
        BOSSKIND_EGG_GOLEM = 28,
        BOSSKIND_EGG_INFERNO = 29,
        BOSSKIND_GIANT_EGGMAN_ROBO = 30,
        BOSSKIND_DEATH_EGG_ROCKET = 31,
        BOSSKIND_EGG_HVC_001 = 32,
        BOSSKIND_EGG_TILTER = 33,
        BOSSKIND_EGG_BUBBLE = 34,
        BOSSKIND_EGG_CONVEYER = 35,
        BOSSKIND_EGG_RAZER = 36,
        BOSSKIND_METAL_SONIC = 37,
        BOSSKIND_EGG_SPINNER = 38,
        BOSSKIND_MECHA_SONIC_MK_II = 39,
        BOSSKIND_SUPER_MECHA_SONIC_MK_II = 40,
        BOSSKIND_NUM = 41
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct RetroBossrushData
    {
        [FieldOffset(0)]  public byte m_category;
        [FieldOffset(1)]  public byte m_stage;
        [FieldOffset(2)]  public ushort m_entity;
        [FieldOffset(4)]  public ushort m_waterstate;
        [FieldOffset(8)]  public uint m_waterlevel;
        [FieldOffset(12)] public StageKind m_hiteStageKind;
        [FieldOffset(13)] public BossKind m_hiteBossKind;
        [FieldOffset(14)] public BossKind m_hiteBossKind2;
        [FieldOffset(15)] public BossKind m_hiteBossKind3;
    }

    [StructLayout(LayoutKind.Explicit, Size = 38088)]
    public struct RetroRflParam
    {
        [FieldOffset(0)]     public RetroSfxData m_RetroSfxSonic1__arr0;
        [FieldOffset(48)] public RetroSfxData m_RetroSfxSonic1__arr1;
        [FieldOffset(96)] public RetroSfxData m_RetroSfxSonic1__arr2;
        [FieldOffset(144)] public RetroSfxData m_RetroSfxSonic1__arr3;
        [FieldOffset(192)] public RetroSfxData m_RetroSfxSonic1__arr4;
        [FieldOffset(240)] public RetroSfxData m_RetroSfxSonic1__arr5;
        [FieldOffset(288)] public RetroSfxData m_RetroSfxSonic1__arr6;
        [FieldOffset(336)] public RetroSfxData m_RetroSfxSonic1__arr7;
        [FieldOffset(384)] public RetroSfxData m_RetroSfxSonic1__arr8;
        [FieldOffset(432)] public RetroSfxData m_RetroSfxSonic1__arr9;
        [FieldOffset(480)] public RetroSfxData m_RetroSfxSonic1__arr10;
        [FieldOffset(528)] public RetroSfxData m_RetroSfxSonic1__arr11;
        [FieldOffset(576)] public RetroSfxData m_RetroSfxSonic1__arr12;
        [FieldOffset(624)] public RetroSfxData m_RetroSfxSonic1__arr13;
        [FieldOffset(672)] public RetroSfxData m_RetroSfxSonic1__arr14;
        [FieldOffset(720)] public RetroSfxData m_RetroSfxSonic1__arr15;
        [FieldOffset(768)] public RetroSfxData m_RetroSfxSonic1__arr16;
        [FieldOffset(816)] public RetroSfxData m_RetroSfxSonic1__arr17;
        [FieldOffset(864)] public RetroSfxData m_RetroSfxSonic1__arr18;
        [FieldOffset(912)] public RetroSfxData m_RetroSfxSonic1__arr19;
        [FieldOffset(960)] public RetroSfxData m_RetroSfxSonic1__arr20;
        [FieldOffset(1008)] public RetroSfxData m_RetroSfxSonic1__arr21;
        [FieldOffset(1056)] public RetroSfxData m_RetroSfxSonic1__arr22;
        [FieldOffset(1104)] public RetroSfxData m_RetroSfxSonic1__arr23;
        [FieldOffset(1152)] public RetroSfxData m_RetroSfxSonic1__arr24;
        [FieldOffset(1200)] public RetroSfxData m_RetroSfxSonic1__arr25;
        [FieldOffset(1248)] public RetroSfxData m_RetroSfxSonic1__arr26;
        [FieldOffset(1296)] public RetroSfxData m_RetroSfxSonic1__arr27;
        [FieldOffset(1344)] public RetroSfxData m_RetroSfxSonic1__arr28;
        [FieldOffset(1392)] public RetroSfxData m_RetroSfxSonic1__arr29;
        [FieldOffset(1440)] public RetroSfxData m_RetroSfxSonic1__arr30;
        [FieldOffset(1488)] public RetroSfxData m_RetroSfxSonic1__arr31;
        [FieldOffset(1536)] public RetroSfxData m_RetroSfxSonic1__arr32;
        [FieldOffset(1584)] public RetroSfxData m_RetroSfxSonic1__arr33;
        [FieldOffset(1632)] public RetroSfxData m_RetroSfxSonic1__arr34;
        [FieldOffset(1680)] public RetroSfxData m_RetroSfxSonic1__arr35;
        [FieldOffset(1728)] public RetroSfxData m_RetroSfxSonic1__arr36;
        [FieldOffset(1776)] public RetroSfxData m_RetroSfxSonic1__arr37;
        [FieldOffset(1824)] public RetroSfxData m_RetroSfxSonic1__arr38;
        [FieldOffset(1872)] public RetroSfxData m_RetroSfxSonic1__arr39;
        [FieldOffset(1920)] public RetroSfxData m_RetroSfxSonic1__arr40;
        [FieldOffset(1968)] public RetroSfxData m_RetroSfxSonic1__arr41;
        [FieldOffset(2016)] public RetroSfxData m_RetroSfxSonic1__arr42;
        [FieldOffset(2064)] public RetroSfxData m_RetroSfxSonic1__arr43;
        [FieldOffset(2112)] public RetroSfxData m_RetroSfxSonic1__arr44;
        [FieldOffset(2160)] public RetroSfxData m_RetroSfxSonic1__arr45;
        [FieldOffset(2208)] public RetroSfxData m_RetroSfxSonic1__arr46;
        [FieldOffset(2256)] public RetroSfxData m_RetroSfxSonic1__arr47;
        [FieldOffset(2304)] public RetroSfxData m_RetroSfxSonic1__arr48;
        [FieldOffset(2352)] public RetroSfxData m_RetroSfxSonic1__arr49;
        [FieldOffset(2400)] public RetroSfxData m_RetroSfxSonic1__arr50;
        [FieldOffset(2448)] public RetroSfxData m_RetroSfxSonic1__arr51;
        [FieldOffset(2496)] public RetroSfxData m_RetroSfxSonic1__arr52;
        [FieldOffset(2544)] public RetroSfxData m_RetroSfxSonic1__arr53;
        [FieldOffset(2592)] public RetroSfxData m_RetroSfxSonic1__arr54;
        [FieldOffset(2640)] public RetroSfxData m_RetroSfxSonic1__arr55;
        [FieldOffset(2688)] public RetroSfxData m_RetroSfxSonic1__arr56;
        [FieldOffset(2736)] public RetroSfxData m_RetroSfxSonic1__arr57;
        [FieldOffset(2784)] public RetroSfxData m_RetroSfxSonic1__arr58;
        [FieldOffset(2832)] public RetroSfxData m_RetroSfxSonic1__arr59;
        [FieldOffset(2880)] public RetroSfxData m_RetroSfxSonic1__arr60;
        [FieldOffset(2928)] public RetroSfxData m_RetroSfxSonic1__arr61;
        [FieldOffset(2976)] public RetroSfxData m_RetroSfxSonic1__arr62;
        [FieldOffset(3024)] public RetroSfxData m_RetroSfxSonic1__arr63;
        [FieldOffset(3072)] public RetroSfxData m_RetroSfxSonic1__arr64;
        [FieldOffset(3120)] public RetroSfxData m_RetroSfxSonic1__arr65;
        [FieldOffset(3168)] public RetroSfxData m_RetroSfxSonic1__arr66;
        [FieldOffset(3216)] public RetroSfxData m_RetroSfxSonic1__arr67;
        [FieldOffset(3264)] public RetroSfxData m_RetroSfxSonic1__arr68;
        [FieldOffset(3312)] public RetroSfxData m_RetroSfxSonic1__arr69;
        [FieldOffset(3360)] public RetroSfxData m_RetroSfxSonic1__arr70;
        [FieldOffset(3408)] public RetroSfxData m_RetroSfxSonic1__arr71;
        [FieldOffset(3456)] public RetroSfxData m_RetroSfxSonic1__arr72;
        [FieldOffset(3504)] public RetroSfxData m_RetroSfxSonic1__arr73;
        [FieldOffset(3552)] public RetroSfxData m_RetroSfxSonic1__arr74;
        [FieldOffset(3600)] public RetroSfxData m_RetroSfxSonic1__arr75;
        [FieldOffset(3648)] public RetroSfxData m_RetroSfxSonic1__arr76;
        [FieldOffset(3696)] public RetroSfxData m_RetroSfxSonic1__arr77;
        [FieldOffset(3744)] public RetroSfxData m_RetroSfxSonic1__arr78;
        [FieldOffset(3792)] public RetroSfxData m_RetroSfxSonic1__arr79;
        [FieldOffset(3840)] public RetroSfxData m_RetroSfxSonic1__arr80;
        [FieldOffset(3888)] public RetroSfxData m_RetroSfxSonic1__arr81;
        [FieldOffset(3936)] public RetroSfxData m_RetroSfxSonic1__arr82;
        [FieldOffset(3984)] public RetroSfxData m_RetroSfxSonic1__arr83;
        [FieldOffset(4032)]  public RetroSfxData m_RetroSfxSonic2__arr0;
        [FieldOffset(4080)] public RetroSfxData m_RetroSfxSonic2__arr1;
        [FieldOffset(4128)] public RetroSfxData m_RetroSfxSonic2__arr2;
        [FieldOffset(4176)] public RetroSfxData m_RetroSfxSonic2__arr3;
        [FieldOffset(4224)] public RetroSfxData m_RetroSfxSonic2__arr4;
        [FieldOffset(4272)] public RetroSfxData m_RetroSfxSonic2__arr5;
        [FieldOffset(4320)] public RetroSfxData m_RetroSfxSonic2__arr6;
        [FieldOffset(4368)] public RetroSfxData m_RetroSfxSonic2__arr7;
        [FieldOffset(4416)] public RetroSfxData m_RetroSfxSonic2__arr8;
        [FieldOffset(4464)] public RetroSfxData m_RetroSfxSonic2__arr9;
        [FieldOffset(4512)] public RetroSfxData m_RetroSfxSonic2__arr10;
        [FieldOffset(4560)] public RetroSfxData m_RetroSfxSonic2__arr11;
        [FieldOffset(4608)] public RetroSfxData m_RetroSfxSonic2__arr12;
        [FieldOffset(4656)] public RetroSfxData m_RetroSfxSonic2__arr13;
        [FieldOffset(4704)] public RetroSfxData m_RetroSfxSonic2__arr14;
        [FieldOffset(4752)] public RetroSfxData m_RetroSfxSonic2__arr15;
        [FieldOffset(4800)] public RetroSfxData m_RetroSfxSonic2__arr16;
        [FieldOffset(4848)] public RetroSfxData m_RetroSfxSonic2__arr17;
        [FieldOffset(4896)] public RetroSfxData m_RetroSfxSonic2__arr18;
        [FieldOffset(4944)] public RetroSfxData m_RetroSfxSonic2__arr19;
        [FieldOffset(4992)] public RetroSfxData m_RetroSfxSonic2__arr20;
        [FieldOffset(5040)] public RetroSfxData m_RetroSfxSonic2__arr21;
        [FieldOffset(5088)] public RetroSfxData m_RetroSfxSonic2__arr22;
        [FieldOffset(5136)] public RetroSfxData m_RetroSfxSonic2__arr23;
        [FieldOffset(5184)] public RetroSfxData m_RetroSfxSonic2__arr24;
        [FieldOffset(5232)] public RetroSfxData m_RetroSfxSonic2__arr25;
        [FieldOffset(5280)] public RetroSfxData m_RetroSfxSonic2__arr26;
        [FieldOffset(5328)] public RetroSfxData m_RetroSfxSonic2__arr27;
        [FieldOffset(5376)] public RetroSfxData m_RetroSfxSonic2__arr28;
        [FieldOffset(5424)] public RetroSfxData m_RetroSfxSonic2__arr29;
        [FieldOffset(5472)] public RetroSfxData m_RetroSfxSonic2__arr30;
        [FieldOffset(5520)] public RetroSfxData m_RetroSfxSonic2__arr31;
        [FieldOffset(5568)] public RetroSfxData m_RetroSfxSonic2__arr32;
        [FieldOffset(5616)] public RetroSfxData m_RetroSfxSonic2__arr33;
        [FieldOffset(5664)] public RetroSfxData m_RetroSfxSonic2__arr34;
        [FieldOffset(5712)] public RetroSfxData m_RetroSfxSonic2__arr35;
        [FieldOffset(5760)] public RetroSfxData m_RetroSfxSonic2__arr36;
        [FieldOffset(5808)] public RetroSfxData m_RetroSfxSonic2__arr37;
        [FieldOffset(5856)] public RetroSfxData m_RetroSfxSonic2__arr38;
        [FieldOffset(5904)] public RetroSfxData m_RetroSfxSonic2__arr39;
        [FieldOffset(5952)] public RetroSfxData m_RetroSfxSonic2__arr40;
        [FieldOffset(6000)] public RetroSfxData m_RetroSfxSonic2__arr41;
        [FieldOffset(6048)] public RetroSfxData m_RetroSfxSonic2__arr42;
        [FieldOffset(6096)] public RetroSfxData m_RetroSfxSonic2__arr43;
        [FieldOffset(6144)] public RetroSfxData m_RetroSfxSonic2__arr44;
        [FieldOffset(6192)] public RetroSfxData m_RetroSfxSonic2__arr45;
        [FieldOffset(6240)] public RetroSfxData m_RetroSfxSonic2__arr46;
        [FieldOffset(6288)] public RetroSfxData m_RetroSfxSonic2__arr47;
        [FieldOffset(6336)] public RetroSfxData m_RetroSfxSonic2__arr48;
        [FieldOffset(6384)] public RetroSfxData m_RetroSfxSonic2__arr49;
        [FieldOffset(6432)] public RetroSfxData m_RetroSfxSonic2__arr50;
        [FieldOffset(6480)] public RetroSfxData m_RetroSfxSonic2__arr51;
        [FieldOffset(6528)] public RetroSfxData m_RetroSfxSonic2__arr52;
        [FieldOffset(6576)] public RetroSfxData m_RetroSfxSonic2__arr53;
        [FieldOffset(6624)] public RetroSfxData m_RetroSfxSonic2__arr54;
        [FieldOffset(6672)] public RetroSfxData m_RetroSfxSonic2__arr55;
        [FieldOffset(6720)] public RetroSfxData m_RetroSfxSonic2__arr56;
        [FieldOffset(6768)] public RetroSfxData m_RetroSfxSonic2__arr57;
        [FieldOffset(6816)] public RetroSfxData m_RetroSfxSonic2__arr58;
        [FieldOffset(6864)] public RetroSfxData m_RetroSfxSonic2__arr59;
        [FieldOffset(6912)] public RetroSfxData m_RetroSfxSonic2__arr60;
        [FieldOffset(6960)] public RetroSfxData m_RetroSfxSonic2__arr61;
        [FieldOffset(7008)] public RetroSfxData m_RetroSfxSonic2__arr62;
        [FieldOffset(7056)] public RetroSfxData m_RetroSfxSonic2__arr63;
        [FieldOffset(7104)] public RetroSfxData m_RetroSfxSonic2__arr64;
        [FieldOffset(7152)] public RetroSfxData m_RetroSfxSonic2__arr65;
        [FieldOffset(7200)] public RetroSfxData m_RetroSfxSonic2__arr66;
        [FieldOffset(7248)] public RetroSfxData m_RetroSfxSonic2__arr67;
        [FieldOffset(7296)] public RetroSfxData m_RetroSfxSonic2__arr68;
        [FieldOffset(7344)] public RetroSfxData m_RetroSfxSonic2__arr69;
        [FieldOffset(7392)] public RetroSfxData m_RetroSfxSonic2__arr70;
        [FieldOffset(7440)] public RetroSfxData m_RetroSfxSonic2__arr71;
        [FieldOffset(7488)] public RetroSfxData m_RetroSfxSonic2__arr72;
        [FieldOffset(7536)] public RetroSfxData m_RetroSfxSonic2__arr73;
        [FieldOffset(7584)] public RetroSfxData m_RetroSfxSonic2__arr74;
        [FieldOffset(7632)] public RetroSfxData m_RetroSfxSonic2__arr75;
        [FieldOffset(7680)] public RetroSfxData m_RetroSfxSonic2__arr76;
        [FieldOffset(7728)] public RetroSfxData m_RetroSfxSonic2__arr77;
        [FieldOffset(7776)] public RetroSfxData m_RetroSfxSonic2__arr78;
        [FieldOffset(7824)] public RetroSfxData m_RetroSfxSonic2__arr79;
        [FieldOffset(7872)] public RetroSfxData m_RetroSfxSonic2__arr80;
        [FieldOffset(7920)] public RetroSfxData m_RetroSfxSonic2__arr81;
        [FieldOffset(7968)] public RetroSfxData m_RetroSfxSonic2__arr82;
        [FieldOffset(8016)] public RetroSfxData m_RetroSfxSonic2__arr83;
        [FieldOffset(8064)] public RetroSfxData m_RetroSfxSonic2__arr84;
        [FieldOffset(8112)] public RetroSfxData m_RetroSfxSonic2__arr85;
        [FieldOffset(8160)] public RetroSfxData m_RetroSfxSonic2__arr86;
        [FieldOffset(8208)] public RetroSfxData m_RetroSfxSonic2__arr87;
        [FieldOffset(8256)] public RetroSfxData m_RetroSfxSonic2__arr88;
        [FieldOffset(8304)] public RetroSfxData m_RetroSfxSonic2__arr89;
        [FieldOffset(8352)] public RetroSfxData m_RetroSfxSonic2__arr90;
        [FieldOffset(8400)] public RetroSfxData m_RetroSfxSonic2__arr91;
        [FieldOffset(8448)] public RetroSfxData m_RetroSfxSonic2__arr92;
        [FieldOffset(8496)] public RetroSfxData m_RetroSfxSonic2__arr93;
        [FieldOffset(8544)] public RetroSfxData m_RetroSfxSonic2__arr94;
        [FieldOffset(8592)] public RetroSfxData m_RetroSfxSonic2__arr95;
        [FieldOffset(8640)] public RetroSfxData m_RetroSfxSonic2__arr96;
        [FieldOffset(8688)] public RetroSfxData m_RetroSfxSonic2__arr97;
        [FieldOffset(8736)] public RetroSfxData m_RetroSfxSonic2__arr98;
        [FieldOffset(8784)] public RetroSfxData m_RetroSfxSonic2__arr99;
        [FieldOffset(8832)] public RetroSfxData m_RetroSfxSonic2__arr100;
        [FieldOffset(8880)] public RetroSfxData m_RetroSfxSonic2__arr101;
        [FieldOffset(8928)] public RetroSfxData m_RetroSfxSonic2__arr102;
        [FieldOffset(8976)] public RetroSfxData m_RetroSfxSonic2__arr103;
        [FieldOffset(9024)] public RetroSfxData m_RetroSfxSonic2__arr104;
        [FieldOffset(9072)] public RetroSfxData m_RetroSfxSonic2__arr105;
        [FieldOffset(9120)] public RetroSfxData m_RetroSfxSonic2__arr106;
        [FieldOffset(9168)] public RetroSfxData m_RetroSfxSonic2__arr107;
        [FieldOffset(9216)] public RetroSfxData m_RetroSfxSonic2__arr108;
        [FieldOffset(9264)] public RetroSfxData m_RetroSfxSonic2__arr109;
        [FieldOffset(9312)] public RetroSfxData m_RetroSfxSonic2__arr110;
        [FieldOffset(9360)] public RetroSfxData m_RetroSfxSonic2__arr111;
        [FieldOffset(9408)] public RetroSfxData m_RetroSfxSonic2__arr112;
        [FieldOffset(9456)] public RetroSfxData m_RetroSfxSonic2__arr113;
        [FieldOffset(9504)] public RetroSfxData m_RetroSfxSonic2__arr114;
        [FieldOffset(9552)] public RetroSfxData m_RetroSfxSonic2__arr115;
        [FieldOffset(9600)] public RetroSfxData m_RetroSfxSonic2__arr116;
        [FieldOffset(9648)] public RetroSfxData m_RetroSfxSonic2__arr117;
        [FieldOffset(9696)] public RetroSfxData m_RetroSfxSonic2__arr118;
        [FieldOffset(9744)] public RetroSfxData m_RetroSfxSonic2__arr119;
        [FieldOffset(9792)] public RetroSfxData m_RetroSfxSonic2__arr120;
        [FieldOffset(9840)] public RetroSfxData m_RetroSfxSonic2__arr121;
        [FieldOffset(9888)] public RetroSfxData m_RetroSfxSonic2__arr122;
        [FieldOffset(9936)] public RetroSfxData m_RetroSfxSonic2__arr123;
        [FieldOffset(9984)] public RetroSfxData m_RetroSfxSonic2__arr124;
        [FieldOffset(10032)] public RetroSfxData m_RetroSfxSonic2__arr125;
        [FieldOffset(10080)] public RetroSfxData m_RetroSfxSonic2__arr126;
        [FieldOffset(10128)] public RetroSfxData m_RetroSfxSonic3k__arr0;
        [FieldOffset(10176)] public RetroSfxData m_RetroSfxSonic3k__arr1;
        [FieldOffset(10224)] public RetroSfxData m_RetroSfxSonic3k__arr2;
        [FieldOffset(10272)] public RetroSfxData m_RetroSfxSonic3k__arr3;
        [FieldOffset(10320)] public RetroSfxData m_RetroSfxSonic3k__arr4;
        [FieldOffset(10368)] public RetroSfxData m_RetroSfxSonic3k__arr5;
        [FieldOffset(10416)] public RetroSfxData m_RetroSfxSonic3k__arr6;
        [FieldOffset(10464)] public RetroSfxData m_RetroSfxSonic3k__arr7;
        [FieldOffset(10512)] public RetroSfxData m_RetroSfxSonic3k__arr8;
        [FieldOffset(10560)] public RetroSfxData m_RetroSfxSonic3k__arr9;
        [FieldOffset(10608)] public RetroSfxData m_RetroSfxSonic3k__arr10;
        [FieldOffset(10656)] public RetroSfxData m_RetroSfxSonic3k__arr11;
        [FieldOffset(10704)] public RetroSfxData m_RetroSfxSonic3k__arr12;
        [FieldOffset(10752)] public RetroSfxData m_RetroSfxSonic3k__arr13;
        [FieldOffset(10800)] public RetroSfxData m_RetroSfxSonic3k__arr14;
        [FieldOffset(10848)] public RetroSfxData m_RetroSfxSonic3k__arr15;
        [FieldOffset(10896)] public RetroSfxData m_RetroSfxSonic3k__arr16;
        [FieldOffset(10944)] public RetroSfxData m_RetroSfxSonic3k__arr17;
        [FieldOffset(10992)] public RetroSfxData m_RetroSfxSonic3k__arr18;
        [FieldOffset(11040)] public RetroSfxData m_RetroSfxSonic3k__arr19;
        [FieldOffset(11088)] public RetroSfxData m_RetroSfxSonic3k__arr20;
        [FieldOffset(11136)] public RetroSfxData m_RetroSfxSonic3k__arr21;
        [FieldOffset(11184)] public RetroSfxData m_RetroSfxSonic3k__arr22;
        [FieldOffset(11232)] public RetroSfxData m_RetroSfxSonic3k__arr23;
        [FieldOffset(11280)] public RetroSfxData m_RetroSfxSonic3k__arr24;
        [FieldOffset(11328)] public RetroSfxData m_RetroSfxSonic3k__arr25;
        [FieldOffset(11376)] public RetroSfxData m_RetroSfxSonic3k__arr26;
        [FieldOffset(11424)] public RetroSfxData m_RetroSfxSonic3k__arr27;
        [FieldOffset(11472)] public RetroSfxData m_RetroSfxSonic3k__arr28;
        [FieldOffset(11520)] public RetroSfxData m_RetroSfxSonic3k__arr29;
        [FieldOffset(11568)] public RetroSfxData m_RetroSfxSonic3k__arr30;
        [FieldOffset(11616)] public RetroSfxData m_RetroSfxSonic3k__arr31;
        [FieldOffset(11664)] public RetroSfxData m_RetroSfxSonic3k__arr32;
        [FieldOffset(11712)] public RetroSfxData m_RetroSfxSonic3k__arr33;
        [FieldOffset(11760)] public RetroSfxData m_RetroSfxSonic3k__arr34;
        [FieldOffset(11808)] public RetroSfxData m_RetroSfxSonic3k__arr35;
        [FieldOffset(11856)] public RetroSfxData m_RetroSfxSonic3k__arr36;
        [FieldOffset(11904)] public RetroSfxData m_RetroSfxSonic3k__arr37;
        [FieldOffset(11952)] public RetroSfxData m_RetroSfxSonic3k__arr38;
        [FieldOffset(12000)] public RetroSfxData m_RetroSfxSonic3k__arr39;
        [FieldOffset(12048)] public RetroSfxData m_RetroSfxSonic3k__arr40;
        [FieldOffset(12096)] public RetroSfxData m_RetroSfxSonic3k__arr41;
        [FieldOffset(12144)] public RetroSfxData m_RetroSfxSonic3k__arr42;
        [FieldOffset(12192)] public RetroSfxData m_RetroSfxSonic3k__arr43;
        [FieldOffset(12240)] public RetroSfxData m_RetroSfxSonic3k__arr44;
        [FieldOffset(12288)] public RetroSfxData m_RetroSfxSonic3k__arr45;
        [FieldOffset(12336)] public RetroSfxData m_RetroSfxSonic3k__arr46;
        [FieldOffset(12384)] public RetroSfxData m_RetroSfxSonic3k__arr47;
        [FieldOffset(12432)] public RetroSfxData m_RetroSfxSonic3k__arr48;
        [FieldOffset(12480)] public RetroSfxData m_RetroSfxSonic3k__arr49;
        [FieldOffset(12528)] public RetroSfxData m_RetroSfxSonic3k__arr50;
        [FieldOffset(12576)] public RetroSfxData m_RetroSfxSonic3k__arr51;
        [FieldOffset(12624)] public RetroSfxData m_RetroSfxSonic3k__arr52;
        [FieldOffset(12672)] public RetroSfxData m_RetroSfxSonic3k__arr53;
        [FieldOffset(12720)] public RetroSfxData m_RetroSfxSonic3k__arr54;
        [FieldOffset(12768)] public RetroSfxData m_RetroSfxSonic3k__arr55;
        [FieldOffset(12816)] public RetroSfxData m_RetroSfxSonic3k__arr56;
        [FieldOffset(12864)] public RetroSfxData m_RetroSfxSonic3k__arr57;
        [FieldOffset(12912)] public RetroSfxData m_RetroSfxSonic3k__arr58;
        [FieldOffset(12960)] public RetroSfxData m_RetroSfxSonic3k__arr59;
        [FieldOffset(13008)] public RetroSfxData m_RetroSfxSonic3k__arr60;
        [FieldOffset(13056)] public RetroSfxData m_RetroSfxSonic3k__arr61;
        [FieldOffset(13104)] public RetroSfxData m_RetroSfxSonic3k__arr62;
        [FieldOffset(13152)] public RetroSfxData m_RetroSfxSonic3k__arr63;
        [FieldOffset(13200)] public RetroSfxData m_RetroSfxSonic3k__arr64;
        [FieldOffset(13248)] public RetroSfxData m_RetroSfxSonic3k__arr65;
        [FieldOffset(13296)] public RetroSfxData m_RetroSfxSonic3k__arr66;
        [FieldOffset(13344)] public RetroSfxData m_RetroSfxSonic3k__arr67;
        [FieldOffset(13392)] public RetroSfxData m_RetroSfxSonic3k__arr68;
        [FieldOffset(13440)] public RetroSfxData m_RetroSfxSonic3k__arr69;
        [FieldOffset(13488)] public RetroSfxData m_RetroSfxSonic3k__arr70;
        [FieldOffset(13536)] public RetroSfxData m_RetroSfxSonic3k__arr71;
        [FieldOffset(13584)] public RetroSfxData m_RetroSfxSonic3k__arr72;
        [FieldOffset(13632)] public RetroSfxData m_RetroSfxSonic3k__arr73;
        [FieldOffset(13680)] public RetroSfxData m_RetroSfxSonic3k__arr74;
        [FieldOffset(13728)] public RetroSfxData m_RetroSfxSonic3k__arr75;
        [FieldOffset(13776)] public RetroSfxData m_RetroSfxSonic3k__arr76;
        [FieldOffset(13824)] public RetroSfxData m_RetroSfxSonic3k__arr77;
        [FieldOffset(13872)] public RetroSfxData m_RetroSfxSonic3k__arr78;
        [FieldOffset(13920)] public RetroSfxData m_RetroSfxSonic3k__arr79;
        [FieldOffset(13968)] public RetroSfxData m_RetroSfxSonic3k__arr80;
        [FieldOffset(14016)] public RetroSfxData m_RetroSfxSonic3k__arr81;
        [FieldOffset(14064)] public RetroSfxData m_RetroSfxSonic3k__arr82;
        [FieldOffset(14112)] public RetroSfxData m_RetroSfxSonic3k__arr83;
        [FieldOffset(14160)] public RetroSfxData m_RetroSfxSonic3k__arr84;
        [FieldOffset(14208)] public RetroSfxData m_RetroSfxSonic3k__arr85;
        [FieldOffset(14256)] public RetroSfxData m_RetroSfxSonic3k__arr86;
        [FieldOffset(14304)] public RetroSfxData m_RetroSfxSonic3k__arr87;
        [FieldOffset(14352)] public RetroSfxData m_RetroSfxSonic3k__arr88;
        [FieldOffset(14400)] public RetroSfxData m_RetroSfxSonic3k__arr89;
        [FieldOffset(14448)] public RetroSfxData m_RetroSfxSonic3k__arr90;
        [FieldOffset(14496)] public RetroSfxData m_RetroSfxSonic3k__arr91;
        [FieldOffset(14544)] public RetroSfxData m_RetroSfxSonic3k__arr92;
        [FieldOffset(14592)] public RetroSfxData m_RetroSfxSonic3k__arr93;
        [FieldOffset(14640)] public RetroSfxData m_RetroSfxSonic3k__arr94;
        [FieldOffset(14688)] public RetroSfxData m_RetroSfxSonic3k__arr95;
        [FieldOffset(14736)] public RetroSfxData m_RetroSfxSonic3k__arr96;
        [FieldOffset(14784)] public RetroSfxData m_RetroSfxSonic3k__arr97;
        [FieldOffset(14832)] public RetroSfxData m_RetroSfxSonic3k__arr98;
        [FieldOffset(14880)] public RetroSfxData m_RetroSfxSonic3k__arr99;
        [FieldOffset(14928)] public RetroSfxData m_RetroSfxSonic3k__arr100;
        [FieldOffset(14976)] public RetroSfxData m_RetroSfxSonic3k__arr101;
        [FieldOffset(15024)] public RetroSfxData m_RetroSfxSonic3k__arr102;
        [FieldOffset(15072)] public RetroSfxData m_RetroSfxSonic3k__arr103;
        [FieldOffset(15120)] public RetroSfxData m_RetroSfxSonic3k__arr104;
        [FieldOffset(15168)] public RetroSfxData m_RetroSfxSonic3k__arr105;
        [FieldOffset(15216)] public RetroSfxData m_RetroSfxSonic3k__arr106;
        [FieldOffset(15264)] public RetroSfxData m_RetroSfxSonic3k__arr107;
        [FieldOffset(15312)] public RetroSfxData m_RetroSfxSonic3k__arr108;
        [FieldOffset(15360)] public RetroSfxData m_RetroSfxSonic3k__arr109;
        [FieldOffset(15408)] public RetroSfxData m_RetroSfxSonic3k__arr110;
        [FieldOffset(15456)] public RetroSfxData m_RetroSfxSonic3k__arr111;
        [FieldOffset(15504)] public RetroSfxData m_RetroSfxSonic3k__arr112;
        [FieldOffset(15552)] public RetroSfxData m_RetroSfxSonic3k__arr113;
        [FieldOffset(15600)] public RetroSfxData m_RetroSfxSonic3k__arr114;
        [FieldOffset(15648)] public RetroSfxData m_RetroSfxSonic3k__arr115;
        [FieldOffset(15696)] public RetroSfxData m_RetroSfxSonic3k__arr116;
        [FieldOffset(15744)] public RetroSfxData m_RetroSfxSonic3k__arr117;
        [FieldOffset(15792)] public RetroSfxData m_RetroSfxSonic3k__arr118;
        [FieldOffset(15840)] public RetroSfxData m_RetroSfxSonic3k__arr119;
        [FieldOffset(15888)] public RetroSfxData m_RetroSfxSonic3k__arr120;
        [FieldOffset(15936)] public RetroSfxData m_RetroSfxSonic3k__arr121;
        [FieldOffset(15984)] public RetroSfxData m_RetroSfxSonic3k__arr122;
        [FieldOffset(16032)] public RetroSfxData m_RetroSfxSonic3k__arr123;
        [FieldOffset(16080)] public RetroSfxData m_RetroSfxSonic3k__arr124;
        [FieldOffset(16128)] public RetroSfxData m_RetroSfxSonic3k__arr125;
        [FieldOffset(16176)] public RetroSfxData m_RetroSfxSonic3k__arr126;
        [FieldOffset(16224)] public RetroSfxData m_RetroSfxSonic3k__arr127;
        [FieldOffset(16272)] public RetroSfxData m_RetroSfxSonic3k__arr128;
        [FieldOffset(16320)] public RetroSfxData m_RetroSfxSonic3k__arr129;
        [FieldOffset(16368)] public RetroSfxData m_RetroSfxSonic3k__arr130;
        [FieldOffset(16416)] public RetroSfxData m_RetroSfxSonic3k__arr131;
        [FieldOffset(16464)] public RetroSfxData m_RetroSfxSonic3k__arr132;
        [FieldOffset(16512)] public RetroSfxData m_RetroSfxSonic3k__arr133;
        [FieldOffset(16560)] public RetroSfxData m_RetroSfxSonic3k__arr134;
        [FieldOffset(16608)] public RetroSfxData m_RetroSfxSonic3k__arr135;
        [FieldOffset(16656)] public RetroSfxData m_RetroSfxSonic3k__arr136;
        [FieldOffset(16704)] public RetroSfxData m_RetroSfxSonic3k__arr137;
        [FieldOffset(16752)] public RetroSfxData m_RetroSfxSonic3k__arr138;
        [FieldOffset(16800)] public RetroSfxData m_RetroSfxSonic3k__arr139;
        [FieldOffset(16848)] public RetroSfxData m_RetroSfxSonic3k__arr140;
        [FieldOffset(16896)] public RetroSfxData m_RetroSfxSonic3k__arr141;
        [FieldOffset(16944)] public RetroSfxData m_RetroSfxSonic3k__arr142;
        [FieldOffset(16992)] public RetroSfxData m_RetroSfxSonic3k__arr143;
        [FieldOffset(17040)] public RetroSfxData m_RetroSfxSonic3k__arr144;
        [FieldOffset(17088)] public RetroSfxData m_RetroSfxSonic3k__arr145;
        [FieldOffset(17136)] public RetroSfxData m_RetroSfxSonic3k__arr146;
        [FieldOffset(17184)] public RetroSfxData m_RetroSfxSonic3k__arr147;
        [FieldOffset(17232)] public RetroSfxData m_RetroSfxSonic3k__arr148;
        [FieldOffset(17280)] public RetroSfxData m_RetroSfxSonic3k__arr149;
        [FieldOffset(17328)] public RetroSfxData m_RetroSfxSonic3k__arr150;
        [FieldOffset(17376)] public RetroSfxData m_RetroSfxSonic3k__arr151;
        [FieldOffset(17424)] public RetroSfxData m_RetroSfxSonic3k__arr152;
        [FieldOffset(17472)] public RetroSfxData m_RetroSfxSonic3k__arr153;
        [FieldOffset(17520)] public RetroSfxData m_RetroSfxSonic3k__arr154;
        [FieldOffset(17568)] public RetroSfxData m_RetroSfxSonic3k__arr155;
        [FieldOffset(17616)] public RetroSfxData m_RetroSfxSonic3k__arr156;
        [FieldOffset(17664)] public RetroSfxData m_RetroSfxSonic3k__arr157;
        [FieldOffset(17712)] public RetroSfxData m_RetroSfxSonic3k__arr158;
        [FieldOffset(17760)] public RetroSfxData m_RetroSfxSonic3k__arr159;
        [FieldOffset(17808)] public RetroSfxData m_RetroSfxSonic3k__arr160;
        [FieldOffset(17856)] public RetroSfxData m_RetroSfxSonic3k__arr161;
        [FieldOffset(17904)] public RetroSfxData m_RetroSfxSonic3k__arr162;
        [FieldOffset(17952)] public RetroSfxData m_RetroSfxSonic3k__arr163;
        [FieldOffset(18000)] public RetroSfxData m_RetroSfxSonic3k__arr164;
        [FieldOffset(18048)] public RetroSfxData m_RetroSfxSonic3k__arr165;
        [FieldOffset(18096)] public RetroSfxData m_RetroSfxSonic3k__arr166;
        [FieldOffset(18144)] public RetroSfxData m_RetroSfxSonic3k__arr167;
        [FieldOffset(18192)] public RetroSfxData m_RetroSfxSonic3k__arr168;
        [FieldOffset(18240)] public RetroSfxData m_RetroSfxSonic3k__arr169;
        [FieldOffset(18288)] public RetroSfxData m_RetroSfxSonic3k__arr170;
        [FieldOffset(18336)] public RetroSfxData m_RetroSfxSonic3k__arr171;
        [FieldOffset(18384)] public RetroSfxData m_RetroSfxSonic3k__arr172;
        [FieldOffset(18432)] public RetroSfxData m_RetroSfxSonic3k__arr173;
        [FieldOffset(18480)] public RetroSfxData m_RetroSfxSonic3k__arr174;
        [FieldOffset(18528)] public RetroSfxData m_RetroSfxSonic3k__arr175;
        [FieldOffset(18576)] public RetroSfxData m_RetroSfxSonic3k__arr176;
        [FieldOffset(18624)] public RetroSfxData m_RetroSfxSonic3k__arr177;
        [FieldOffset(18672)] public RetroSfxData m_RetroSfxSonic3k__arr178;
        [FieldOffset(18720)] public RetroSfxData m_RetroSfxSonic3k__arr179;
        [FieldOffset(18768)] public RetroSfxData m_RetroSfxSonic3k__arr180;
        [FieldOffset(18816)] public RetroSfxData m_RetroSfxSonic3k__arr181;
        [FieldOffset(18864)] public RetroSfxData m_RetroSfxSonic3k__arr182;
        [FieldOffset(18912)] public RetroSfxData m_RetroSfxSonic3k__arr183;
        [FieldOffset(18960)] public RetroSfxData m_RetroSfxSonic3k__arr184;
        [FieldOffset(19008)] public RetroSfxData m_RetroSfxSonic3k__arr185;
        [FieldOffset(19056)] public RetroSfxData m_RetroSfxSonic3k__arr186;
        [FieldOffset(19104)] public RetroSfxData m_RetroSfxSonic3k__arr187;
        [FieldOffset(19152)] public RetroSfxData m_RetroSfxSonic3k__arr188;
        [FieldOffset(19200)] public RetroSfxData m_RetroSfxSonic3k__arr189;
        [FieldOffset(19248)] public RetroSfxData m_RetroSfxSonic3k__arr190;
        [FieldOffset(19296)] public RetroSfxData m_RetroSfxSonic3k__arr191;
        [FieldOffset(19344)] public RetroSfxData m_RetroSfxSonic3k__arr192;
        [FieldOffset(19392)] public RetroSfxData m_RetroSfxSonic3k__arr193;
        [FieldOffset(19440)] public RetroSfxData m_RetroSfxSonic3k__arr194;
        [FieldOffset(19488)] public RetroSfxData m_RetroSfxSonic3k__arr195;
        [FieldOffset(19536)] public RetroSfxData m_RetroSfxSonic3k__arr196;
        [FieldOffset(19584)] public RetroSfxData m_RetroSfxSonic3k__arr197;
        [FieldOffset(19632)] public RetroSfxData m_RetroSfxSonic3k__arr198;
        [FieldOffset(19680)] public RetroSfxData m_RetroSfxSonic3k__arr199;
        [FieldOffset(19728)] public RetroSfxData m_RetroSfxSonic3k__arr200;
        [FieldOffset(19776)] public RetroSfxData m_RetroSfxSonic3k__arr201;
        [FieldOffset(19824)] public RetroSfxData m_RetroSfxSonic3k__arr202;
        [FieldOffset(19872)] public RetroSfxData m_RetroSfxSonic3k__arr203;
        [FieldOffset(19920)] public RetroSfxData m_RetroSfxSonic3k__arr204;
        [FieldOffset(19968)] public RetroSfxData m_RetroSfxSonic3k__arr205;
        [FieldOffset(20016)] public RetroSfxData m_RetroSfxSonic3k__arr206;
        [FieldOffset(20064)] public RetroSfxData m_RetroSfxSonic3k__arr207;
        [FieldOffset(20112)] public RetroSfxData m_RetroSfxSonic3k__arr208;
        [FieldOffset(20160)] public RetroSfxData m_RetroSfxSonic3k__arr209;
        [FieldOffset(20208)] public RetroSfxData m_RetroSfxSonic3k__arr210;
        [FieldOffset(20256)] public RetroSfxData m_RetroSfxSonic3k__arr211;
        [FieldOffset(20304)] public RetroSfxData m_RetroSfxSonic3k__arr212;
        [FieldOffset(20352)] public RetroSfxData m_RetroSfxSonic3k__arr213;
        [FieldOffset(20400)] public RetroSfxData m_RetroSfxSonic3k__arr214;
        [FieldOffset(20448)] public RetroSfxData m_RetroSfxSonic3k__arr215;
        [FieldOffset(20496)] public RetroSfxData m_RetroSfxSonic3k__arr216;
        [FieldOffset(20544)] public RetroSfxData m_RetroSfxSonic3k__arr217;
        [FieldOffset(20592)] public RetroSfxData m_RetroSfxSonic3k__arr218;
        [FieldOffset(20640)] public RetroSfxData m_RetroSfxSonic3k__arr219;
        [FieldOffset(20688)] public RetroSfxData m_RetroSfxSonic3k__arr220;
        [FieldOffset(20736)] public RetroSfxData m_RetroSfxSonic3k__arr221;
        [FieldOffset(20784)] public RetroSfxData m_RetroSfxSonic3k__arr222;
        [FieldOffset(20832)] public RetroSfxData m_RetroSfxSonic3k__arr223;
        [FieldOffset(20880)] public RetroSfxData m_RetroSfxSonic3k__arr224;
        [FieldOffset(20928)] public RetroSfxData m_RetroSfxSonic3k__arr225;
        [FieldOffset(20976)] public RetroSfxData m_RetroSfxSonic3k__arr226;
        [FieldOffset(21024)] public RetroSfxData m_RetroSfxSonic3k__arr227;
        [FieldOffset(21072)] public RetroSfxData m_RetroSfxSonic3k__arr228;
        [FieldOffset(21120)] public RetroSfxData m_RetroSfxSonic3k__arr229;
        [FieldOffset(21168)] public RetroSfxData m_RetroSfxSonic3k__arr230;
        [FieldOffset(21216)] public RetroSfxData m_RetroSfxSonic3k__arr231;
        [FieldOffset(21264)] public RetroSfxData m_RetroSfxSonic3k__arr232;
        [FieldOffset(21312)] public RetroSfxData m_RetroSfxSonic3k__arr233;
        [FieldOffset(21360)] public RetroSfxData m_RetroSfxSonic3k__arr234;
        [FieldOffset(21408)] public RetroSfxData m_RetroSfxSonic3k__arr235;
        [FieldOffset(21456)] public RetroSfxData m_RetroSfxSonic3k__arr236;
        [FieldOffset(21504)] public RetroSfxData m_RetroSfxSonic3k__arr237;
        [FieldOffset(21552)] public RetroSfxData m_RetroSfxSonic3k__arr238;
        [FieldOffset(21600)] public RetroSfxData m_RetroSfxSonic3k__arr239;
        [FieldOffset(21648)] public RetroSfxData m_RetroSfxSonic3k__arr240;
        [FieldOffset(21696)] public RetroSfxData m_RetroSfxSonic3k__arr241;
        [FieldOffset(21744)] public RetroSfxData m_RetroSfxSonic3k__arr242;
        [FieldOffset(21792)] public RetroSfxData m_RetroSfxSonic3k__arr243;
        [FieldOffset(21840)] public RetroSfxData m_RetroSfxSonic3k__arr244;
        [FieldOffset(21888)] public RetroSfxData m_RetroSfxSonic3k__arr245;
        [FieldOffset(21936)] public RetroSfxData m_RetroSfxSonic3k__arr246;
        [FieldOffset(21984)] public RetroSfxData m_RetroSfxSonic3k__arr247;
        [FieldOffset(22032)] public RetroSfxData m_RetroSfxSonic3k__arr248;
        [FieldOffset(22080)] public RetroSfxData m_RetroSfxSonic3k__arr249;
        [FieldOffset(22128)] public RetroSfxData m_RetroSfxSonic3k__arr250;
        [FieldOffset(22176)] public RetroSfxData m_RetroSfxSonic3k__arr251;
        [FieldOffset(22224)] public RetroSfxData m_RetroSfxSonic3k__arr252;
        [FieldOffset(22272)] public RetroSfxData m_RetroSfxSonic3k__arr253;
        [FieldOffset(22320)] public RetroSfxData m_RetroSfxSonic3k__arr254;
        [FieldOffset(22368)] public RetroSfxData m_RetroSfxSonic3k__arr255;
        [FieldOffset(22416)] public RetroSfxData m_RetroSfxSonic3k__arr256;
        [FieldOffset(22464)] public RetroSfxData m_RetroSfxSonic3k__arr257;
        [FieldOffset(22512)] public RetroSfxData m_RetroSfxSonic3k__arr258;
        [FieldOffset(22560)] public RetroSfxData m_RetroSfxSonic3k__arr259;
        [FieldOffset(22608)] public RetroSfxData m_RetroSfxSonic3k__arr260;
        [FieldOffset(22656)] public RetroSfxData m_RetroSfxSonic3k__arr261;
        [FieldOffset(22704)] public RetroSfxData m_RetroSfxSonicCD__arr0;
        [FieldOffset(22752)] public RetroSfxData m_RetroSfxSonicCD__arr1;
        [FieldOffset(22800)] public RetroSfxData m_RetroSfxSonicCD__arr2;
        [FieldOffset(22848)] public RetroSfxData m_RetroSfxSonicCD__arr3;
        [FieldOffset(22896)] public RetroSfxData m_RetroSfxSonicCD__arr4;
        [FieldOffset(22944)] public RetroSfxData m_RetroSfxSonicCD__arr5;
        [FieldOffset(22992)] public RetroSfxData m_RetroSfxSonicCD__arr6;
        [FieldOffset(23040)] public RetroSfxData m_RetroSfxSonicCD__arr7;
        [FieldOffset(23088)] public RetroSfxData m_RetroSfxSonicCD__arr8;
        [FieldOffset(23136)] public RetroSfxData m_RetroSfxSonicCD__arr9;
        [FieldOffset(23184)] public RetroSfxData m_RetroSfxSonicCD__arr10;
        [FieldOffset(23232)] public RetroSfxData m_RetroSfxSonicCD__arr11;
        [FieldOffset(23280)] public RetroSfxData m_RetroSfxSonicCD__arr12;
        [FieldOffset(23328)] public RetroSfxData m_RetroSfxSonicCD__arr13;
        [FieldOffset(23376)] public RetroSfxData m_RetroSfxSonicCD__arr14;
        [FieldOffset(23424)] public RetroSfxData m_RetroSfxSonicCD__arr15;
        [FieldOffset(23472)] public RetroSfxData m_RetroSfxSonicCD__arr16;
        [FieldOffset(23520)] public RetroSfxData m_RetroSfxSonicCD__arr17;
        [FieldOffset(23568)] public RetroSfxData m_RetroSfxSonicCD__arr18;
        [FieldOffset(23616)] public RetroSfxData m_RetroSfxSonicCD__arr19;
        [FieldOffset(23664)] public RetroSfxData m_RetroSfxSonicCD__arr20;
        [FieldOffset(23712)] public RetroSfxData m_RetroSfxSonicCD__arr21;
        [FieldOffset(23760)] public RetroSfxData m_RetroSfxSonicCD__arr22;
        [FieldOffset(23808)] public RetroSfxData m_RetroSfxSonicCD__arr23;
        [FieldOffset(23856)] public RetroSfxData m_RetroSfxSonicCD__arr24;
        [FieldOffset(23904)] public RetroSfxData m_RetroSfxSonicCD__arr25;
        [FieldOffset(23952)] public RetroSfxData m_RetroSfxSonicCD__arr26;
        [FieldOffset(24000)] public RetroSfxData m_RetroSfxSonicCD__arr27;
        [FieldOffset(24048)] public RetroSfxData m_RetroSfxSonicCD__arr28;
        [FieldOffset(24096)] public RetroSfxData m_RetroSfxSonicCD__arr29;
        [FieldOffset(24144)] public RetroSfxData m_RetroSfxSonicCD__arr30;
        [FieldOffset(24192)] public RetroSfxData m_RetroSfxSonicCD__arr31;
        [FieldOffset(24240)] public RetroSfxData m_RetroSfxSonicCD__arr32;
        [FieldOffset(24288)] public RetroSfxData m_RetroSfxSonicCD__arr33;
        [FieldOffset(24336)] public RetroSfxData m_RetroSfxSonicCD__arr34;
        [FieldOffset(24384)] public RetroSfxData m_RetroSfxSonicCD__arr35;
        [FieldOffset(24432)] public RetroSfxData m_RetroSfxSonicCD__arr36;
        [FieldOffset(24480)] public RetroSfxData m_RetroSfxSonicCD__arr37;
        [FieldOffset(24528)] public RetroSfxData m_RetroSfxSonicCD__arr38;
        [FieldOffset(24576)] public RetroSfxData m_RetroSfxSonicCD__arr39;
        [FieldOffset(24624)] public RetroSfxData m_RetroSfxSonicCD__arr40;
        [FieldOffset(24672)] public RetroSfxData m_RetroSfxSonicCD__arr41;
        [FieldOffset(24720)] public RetroSfxData m_RetroSfxSonicCD__arr42;
        [FieldOffset(24768)] public RetroSfxData m_RetroSfxSonicCD__arr43;
        [FieldOffset(24816)] public RetroSfxData m_RetroSfxSonicCD__arr44;
        [FieldOffset(24864)] public RetroSfxData m_RetroSfxSonicCD__arr45;
        [FieldOffset(24912)] public RetroSfxData m_RetroSfxSonicCD__arr46;
        [FieldOffset(24960)] public RetroSfxData m_RetroSfxSonicCD__arr47;
        [FieldOffset(25008)] public RetroSfxData m_RetroSfxSonicCD__arr48;
        [FieldOffset(25056)] public RetroSfxData m_RetroSfxSonicCD__arr49;
        [FieldOffset(25104)] public RetroSfxData m_RetroSfxSonicCD__arr50;
        [FieldOffset(25152)] public RetroSfxData m_RetroSfxSonicCD__arr51;
        [FieldOffset(25200)] public RetroSfxData m_RetroSfxSonicCD__arr52;
        [FieldOffset(25248)] public RetroSfxData m_RetroSfxSonicCD__arr53;
        [FieldOffset(25296)] public RetroSfxData m_RetroSfxSonicCD__arr54;
        [FieldOffset(25344)] public RetroSfxData m_RetroSfxSonicCD__arr55;
        [FieldOffset(25392)] public RetroSfxData m_RetroSfxSonicCD__arr56;
        [FieldOffset(25440)] public RetroSfxData m_RetroSfxSonicCD__arr57;
        [FieldOffset(25488)] public RetroSfxData m_RetroSfxSonicCD__arr58;
        [FieldOffset(25536)] public RetroSfxData m_RetroSfxSonicCD__arr59;
        [FieldOffset(25584)] public RetroSfxData m_RetroSfxSonicCD__arr60;
        [FieldOffset(25632)] public RetroSfxData m_RetroSfxSonicCD__arr61;
        [FieldOffset(25680)] public RetroSfxData m_RetroSfxSonicCD__arr62;
        [FieldOffset(25728)] public RetroSfxData m_RetroSfxSonicCD__arr63;
        [FieldOffset(25776)] public RetroSfxData m_RetroSfxSonicCD__arr64;
        [FieldOffset(25824)] public RetroSfxData m_RetroSfxSonicCD__arr65;
        [FieldOffset(25872)] public RetroSfxData m_RetroSfxSonicCD__arr66;
        [FieldOffset(25920)] public RetroSfxData m_RetroSfxSonicCD__arr67;
        [FieldOffset(25968)] public RetroSfxData m_RetroSfxSonicCD__arr68;
        [FieldOffset(26016)] public RetroSfxData m_RetroSfxSonicCD__arr69;
        [FieldOffset(26064)] public RetroSfxData m_RetroSfxSonicCD__arr70;
        [FieldOffset(26112)] public RetroSfxData m_RetroSfxSonicCD__arr71;
        [FieldOffset(26160)] public RetroSfxData m_RetroSfxSonicCD__arr72;
        [FieldOffset(26208)] public RetroSfxData m_RetroSfxSonicCD__arr73;
        [FieldOffset(26256)] public RetroSfxData m_RetroSfxSonicCD__arr74;
        [FieldOffset(26304)] public RetroSfxData m_RetroSfxSonicCD__arr75;
        [FieldOffset(26352)] public RetroSfxData m_RetroSfxSonicCD__arr76;
        [FieldOffset(26400)] public RetroSfxData m_RetroSfxSonicCD__arr77;
        [FieldOffset(26448)] public RetroSfxData m_RetroSfxSonicCD__arr78;
        [FieldOffset(26496)] public RetroSfxData m_RetroSfxSonicCD__arr79;
        [FieldOffset(26544)] public RetroSfxData m_RetroSfxSonicCD__arr80;
        [FieldOffset(26592)] public RetroSfxData m_RetroSfxSonicCD__arr81;
        [FieldOffset(26640)] public RetroSfxData m_RetroSfxSonicCD__arr82;
        [FieldOffset(26688)] public RetroSfxData m_RetroSfxSonicCD__arr83;
        [FieldOffset(26736)] public RetroSfxData m_RetroSfxSonicCD__arr84;
        [FieldOffset(26784)] public RetroSfxData m_RetroSfxSonicCD__arr85;
        [FieldOffset(26832)] public RetroSfxData m_RetroSfxSonicCD__arr86;
        [FieldOffset(26880)] public RetroSfxData m_RetroSfxSonicCD__arr87;
        [FieldOffset(26928)] public RetroSfxData m_RetroSfxSonicCD__arr88;
        [FieldOffset(26976)] public RetroSfxData m_RetroSfxSonicCD__arr89;
        [FieldOffset(27024)] public RetroSfxData m_RetroSfxSonicCD__arr90;
        [FieldOffset(27072)] public RetroSfxData m_RetroSfxSonicCD__arr91;
        [FieldOffset(27120)] public RetroMusicData m_RetroMusicSonic1__arr0;
        [FieldOffset(27160)] public RetroMusicData m_RetroMusicSonic1__arr1;
        [FieldOffset(27200)] public RetroMusicData m_RetroMusicSonic1__arr2;
        [FieldOffset(27240)] public RetroMusicData m_RetroMusicSonic1__arr3;
        [FieldOffset(27280)] public RetroMusicData m_RetroMusicSonic1__arr4;
        [FieldOffset(27320)] public RetroMusicData m_RetroMusicSonic1__arr5;
        [FieldOffset(27360)] public RetroMusicData m_RetroMusicSonic1__arr6;
        [FieldOffset(27400)] public RetroMusicData m_RetroMusicSonic1__arr7;
        [FieldOffset(27440)] public RetroMusicData m_RetroMusicSonic1__arr8;
        [FieldOffset(27480)] public RetroMusicData m_RetroMusicSonic1__arr9;
        [FieldOffset(27520)] public RetroMusicData m_RetroMusicSonic1__arr10;
        [FieldOffset(27560)] public RetroMusicData m_RetroMusicSonic1__arr11;
        [FieldOffset(27600)] public RetroMusicData m_RetroMusicSonic1__arr12;
        [FieldOffset(27640)] public RetroMusicData m_RetroMusicSonic1__arr13;
        [FieldOffset(27680)] public RetroMusicData m_RetroMusicSonic1__arr14;
        [FieldOffset(27720)] public RetroMusicData m_RetroMusicSonic1__arr15;
        [FieldOffset(27760)] public RetroMusicData m_RetroMusicSonic1__arr16;
        [FieldOffset(27800)] public RetroMusicData m_RetroMusicSonic1__arr17;
        [FieldOffset(27840)] public RetroMusicData m_RetroMusicSonic1__arr18;
        [FieldOffset(27880)] public RetroMusicData m_RetroMusicSonic1__arr19;
        [FieldOffset(27920)] public RetroMusicData m_RetroMusicSonic1__arr20;
        [FieldOffset(27960)] public RetroMusicData m_RetroMusicSonic1__arr21;
        [FieldOffset(28000)] public RetroMusicData m_RetroMusicSonic1__arr22;
        [FieldOffset(28040)] public RetroMusicData m_RetroMusicSonic1__arr23;
        [FieldOffset(28080)] public RetroMusicData m_RetroMusicSonic1__arr24;
        [FieldOffset(28120)] public RetroMusicData m_RetroMusicSonic1__arr25;
        [FieldOffset(28160)] public RetroMusicData m_RetroMusicSonic1__arr26;
        [FieldOffset(28200)] public RetroMusicData m_RetroMusicSonic1__arr27;
        [FieldOffset(28240)] public RetroMusicData m_RetroMusicSonic1__arr28;
        [FieldOffset(28280)] public RetroMusicData m_RetroMusicSonic2__arr0;
        [FieldOffset(28320)] public RetroMusicData m_RetroMusicSonic2__arr1;
        [FieldOffset(28360)] public RetroMusicData m_RetroMusicSonic2__arr2;
        [FieldOffset(28400)] public RetroMusicData m_RetroMusicSonic2__arr3;
        [FieldOffset(28440)] public RetroMusicData m_RetroMusicSonic2__arr4;
        [FieldOffset(28480)] public RetroMusicData m_RetroMusicSonic2__arr5;
        [FieldOffset(28520)] public RetroMusicData m_RetroMusicSonic2__arr6;
        [FieldOffset(28560)] public RetroMusicData m_RetroMusicSonic2__arr7;
        [FieldOffset(28600)] public RetroMusicData m_RetroMusicSonic2__arr8;
        [FieldOffset(28640)] public RetroMusicData m_RetroMusicSonic2__arr9;
        [FieldOffset(28680)] public RetroMusicData m_RetroMusicSonic2__arr10;
        [FieldOffset(28720)] public RetroMusicData m_RetroMusicSonic2__arr11;
        [FieldOffset(28760)] public RetroMusicData m_RetroMusicSonic2__arr12;
        [FieldOffset(28800)] public RetroMusicData m_RetroMusicSonic2__arr13;
        [FieldOffset(28840)] public RetroMusicData m_RetroMusicSonic2__arr14;
        [FieldOffset(28880)] public RetroMusicData m_RetroMusicSonic2__arr15;
        [FieldOffset(28920)] public RetroMusicData m_RetroMusicSonic2__arr16;
        [FieldOffset(28960)] public RetroMusicData m_RetroMusicSonic2__arr17;
        [FieldOffset(29000)] public RetroMusicData m_RetroMusicSonic2__arr18;
        [FieldOffset(29040)] public RetroMusicData m_RetroMusicSonic2__arr19;
        [FieldOffset(29080)] public RetroMusicData m_RetroMusicSonic2__arr20;
        [FieldOffset(29120)] public RetroMusicData m_RetroMusicSonic2__arr21;
        [FieldOffset(29160)] public RetroMusicData m_RetroMusicSonic2__arr22;
        [FieldOffset(29200)] public RetroMusicData m_RetroMusicSonic2__arr23;
        [FieldOffset(29240)] public RetroMusicData m_RetroMusicSonic2__arr24;
        [FieldOffset(29280)] public RetroMusicData m_RetroMusicSonic2__arr25;
        [FieldOffset(29320)] public RetroMusicData m_RetroMusicSonic2__arr26;
        [FieldOffset(29360)] public RetroMusicData m_RetroMusicSonic2__arr27;
        [FieldOffset(29400)] public RetroMusicData m_RetroMusicSonic2__arr28;
        [FieldOffset(29440)] public RetroMusicData m_RetroMusicSonic2__arr29;
        [FieldOffset(29480)] public RetroMusicData m_RetroMusicSonic2__arr30;
        [FieldOffset(29520)] public RetroMusicData m_RetroMusicSonic2__arr31;
        [FieldOffset(29560)] public RetroMusicData m_RetroMusicSonic2__arr32;
        [FieldOffset(29600)] public RetroMusicData m_RetroMusicSonic2__arr33;
        [FieldOffset(29640)] public RetroMusicData m_RetroMusicSonic2__arr34;
        [FieldOffset(29680)] public RetroMusicData m_RetroMusicSonic2__arr35;
        [FieldOffset(29720)] public RetroMusicData m_RetroMusicSonic2__arr36;
        [FieldOffset(29760)] public RetroMusicData m_RetroMusicSonic2__arr37;
        [FieldOffset(29800)] public RetroMusicData m_RetroMusicSonic2__arr38;
        [FieldOffset(29840)] public RetroMusicData m_RetroMusicSonic2__arr39;
        [FieldOffset(29880)] public RetroMusicData m_RetroMusicSonic2__arr40;
        [FieldOffset(29920)] public RetroMusicData m_RetroMusicSonic2__arr41;
        [FieldOffset(29960)] public RetroMusicData m_RetroMusicSonic2__arr42;
        [FieldOffset(30000)] public RetroMusicData m_RetroMusicSonic2__arr43;
        [FieldOffset(30040)] public RetroMusicData m_RetroMusicSonic2__arr44;
        [FieldOffset(30080)] public RetroMusicData m_RetroMusicSonic2__arr45;
        [FieldOffset(30120)] public RetroMusicData m_RetroMusicSonic2__arr46;
        [FieldOffset(30160)] public RetroMusicData m_RetroMusicSonic3k__arr0;
        [FieldOffset(30200)] public RetroMusicData m_RetroMusicSonic3k__arr1;
        [FieldOffset(30240)] public RetroMusicData m_RetroMusicSonic3k__arr2;
        [FieldOffset(30280)] public RetroMusicData m_RetroMusicSonic3k__arr3;
        [FieldOffset(30320)] public RetroMusicData m_RetroMusicSonic3k__arr4;
        [FieldOffset(30360)] public RetroMusicData m_RetroMusicSonic3k__arr5;
        [FieldOffset(30400)] public RetroMusicData m_RetroMusicSonic3k__arr6;
        [FieldOffset(30440)] public RetroMusicData m_RetroMusicSonic3k__arr7;
        [FieldOffset(30480)] public RetroMusicData m_RetroMusicSonic3k__arr8;
        [FieldOffset(30520)] public RetroMusicData m_RetroMusicSonic3k__arr9;
        [FieldOffset(30560)] public RetroMusicData m_RetroMusicSonic3k__arr10;
        [FieldOffset(30600)] public RetroMusicData m_RetroMusicSonic3k__arr11;
        [FieldOffset(30640)] public RetroMusicData m_RetroMusicSonic3k__arr12;
        [FieldOffset(30680)] public RetroMusicData m_RetroMusicSonic3k__arr13;
        [FieldOffset(30720)] public RetroMusicData m_RetroMusicSonic3k__arr14;
        [FieldOffset(30760)] public RetroMusicData m_RetroMusicSonic3k__arr15;
        [FieldOffset(30800)] public RetroMusicData m_RetroMusicSonic3k__arr16;
        [FieldOffset(30840)] public RetroMusicData m_RetroMusicSonic3k__arr17;
        [FieldOffset(30880)] public RetroMusicData m_RetroMusicSonic3k__arr18;
        [FieldOffset(30920)] public RetroMusicData m_RetroMusicSonic3k__arr19;
        [FieldOffset(30960)] public RetroMusicData m_RetroMusicSonic3k__arr20;
        [FieldOffset(31000)] public RetroMusicData m_RetroMusicSonic3k__arr21;
        [FieldOffset(31040)] public RetroMusicData m_RetroMusicSonic3k__arr22;
        [FieldOffset(31080)] public RetroMusicData m_RetroMusicSonic3k__arr23;
        [FieldOffset(31120)] public RetroMusicData m_RetroMusicSonic3k__arr24;
        [FieldOffset(31160)] public RetroMusicData m_RetroMusicSonic3k__arr25;
        [FieldOffset(31200)] public RetroMusicData m_RetroMusicSonic3k__arr26;
        [FieldOffset(31240)] public RetroMusicData m_RetroMusicSonic3k__arr27;
        [FieldOffset(31280)] public RetroMusicData m_RetroMusicSonic3k__arr28;
        [FieldOffset(31320)] public RetroMusicData m_RetroMusicSonic3k__arr29;
        [FieldOffset(31360)] public RetroMusicData m_RetroMusicSonic3k__arr30;
        [FieldOffset(31400)] public RetroMusicData m_RetroMusicSonic3k__arr31;
        [FieldOffset(31440)] public RetroMusicData m_RetroMusicSonic3k__arr32;
        [FieldOffset(31480)] public RetroMusicData m_RetroMusicSonic3k__arr33;
        [FieldOffset(31520)] public RetroMusicData m_RetroMusicSonic3k__arr34;
        [FieldOffset(31560)] public RetroMusicData m_RetroMusicSonic3k__arr35;
        [FieldOffset(31600)] public RetroMusicData m_RetroMusicSonic3k__arr36;
        [FieldOffset(31640)] public RetroMusicData m_RetroMusicSonic3k__arr37;
        [FieldOffset(31680)] public RetroMusicData m_RetroMusicSonic3k__arr38;
        [FieldOffset(31720)] public RetroMusicData m_RetroMusicSonic3k__arr39;
        [FieldOffset(31760)] public RetroMusicData m_RetroMusicSonic3k__arr40;
        [FieldOffset(31800)] public RetroMusicData m_RetroMusicSonic3k__arr41;
        [FieldOffset(31840)] public RetroMusicData m_RetroMusicSonic3k__arr42;
        [FieldOffset(31880)] public RetroMusicData m_RetroMusicSonic3k__arr43;
        [FieldOffset(31920)] public RetroMusicData m_RetroMusicSonic3k__arr44;
        [FieldOffset(31960)] public RetroMusicData m_RetroMusicSonic3k__arr45;
        [FieldOffset(32000)] public RetroMusicData m_RetroMusicSonic3k__arr46;
        [FieldOffset(32040)] public RetroMusicData m_RetroMusicSonic3k__arr47;
        [FieldOffset(32080)] public RetroMusicData m_RetroMusicSonic3k__arr48;
        [FieldOffset(32120)] public RetroMusicData m_RetroMusicSonic3k__arr49;
        [FieldOffset(32160)] public RetroMusicData m_RetroMusicSonic3k__arr50;
        [FieldOffset(32200)] public RetroMusicData m_RetroMusicSonic3k__arr51;
        [FieldOffset(32240)] public RetroMusicData m_RetroMusicSonic3k__arr52;
        [FieldOffset(32280)] public RetroMusicData m_RetroMusicSonic3k__arr53;
        [FieldOffset(32320)] public RetroMusicData m_RetroMusicSonic3k__arr54;
        [FieldOffset(32360)] public RetroMusicData m_RetroMusicSonic3k__arr55;
        [FieldOffset(32400)] public RetroMusicData m_RetroMusicSonic3k__arr56;
        [FieldOffset(32440)] public RetroMusicData m_RetroMusicSonic3k__arr57;
        [FieldOffset(32480)] public RetroMusicData m_RetroMusicSonic3k__arr58;
        [FieldOffset(32520)] public RetroMusicData m_RetroMusicSonic3k__arr59;
        [FieldOffset(32560)] public RetroMusicData m_RetroMusicSonic3k__arr60;
        [FieldOffset(32600)] public RetroMusicData m_RetroMusicSonic3k__arr61;
        [FieldOffset(32640)] public RetroMusicData m_RetroMusicSonic3k__arr62;
        [FieldOffset(32680)] public RetroMusicData m_RetroMusicSonic3k__arr63;
        [FieldOffset(32720)] public RetroMusicData m_RetroMusicSonic3k__arr64;
        [FieldOffset(32760)] public RetroMusicData m_RetroMusicSonic3k__arr65;
        [FieldOffset(32800)] public RetroMusicData m_RetroMusicSonic3k__arr66;
        [FieldOffset(32840)] public RetroMusicData m_RetroMusicSonic3k__arr67;
        [FieldOffset(32880)] public RetroMusicData m_RetroMusicSonic3k__arr68;
        [FieldOffset(32920)] public RetroMusicData m_RetroMusicSonic3k__arr69;
        [FieldOffset(32960)] public RetroMusicData m_RetroMusicSonic3k__arr70;
        [FieldOffset(33000)] public RetroMusicData m_RetroMusicSonic3k__arr71;
        [FieldOffset(33040)] public RetroMusicData m_RetroMusicSonic3k__arr72;
        [FieldOffset(33080)] public RetroMusicData m_RetroMusicSonic3k__arr73;
        [FieldOffset(33120)] public RetroMusicData m_RetroMusicSonic3k__arr74;
        [FieldOffset(33160)] public RetroMusicData m_RetroMusicSonic3k__arr75;
        [FieldOffset(33200)] public RetroMusicData m_RetroMusicSonic3k__arr76;
        [FieldOffset(33240)] public RetroMusicData m_RetroMusicSonic3k__arr77;
        [FieldOffset(33280)] public RetroMusicData m_RetroMusicSonic3k__arr78;
        [FieldOffset(33320)] public RetroMusicData m_RetroMusicSonic3k__arr79;
        [FieldOffset(33360)] public RetroMusicData m_RetroMusicSonic3k__arr80;
        [FieldOffset(33400)] public RetroMusicData m_RetroMusicSonic3k__arr81;
        [FieldOffset(33440)] public RetroMusicData m_RetroMusicSonic3k__arr82;
        [FieldOffset(33480)] public RetroMusicData m_RetroMusicSonic3k__arr83;
        [FieldOffset(33520)] public RetroMusicData m_RetroMusicSonic3k__arr84;
        [FieldOffset(33560)] public RetroMusicData m_RetroMusicSonic3k__arr85;
        [FieldOffset(33600)] public RetroMusicData m_RetroMusicSonic3k__arr86;
        [FieldOffset(33640)] public RetroMusicData m_RetroMusicSonic3k__arr87;
        [FieldOffset(33680)] public RetroMusicData m_RetroMusicSonic3k__arr88;
        [FieldOffset(33720)] public RetroMusicData m_RetroMusicSonic3k__arr89;
        [FieldOffset(33760)] public RetroMusicData m_RetroMusicSonic3k__arr90;
        [FieldOffset(33800)] public RetroMusicData m_RetroMusicSonic3k__arr91;
        [FieldOffset(33840)] public RetroMusicData m_RetroMusicSonic3k__arr92;
        [FieldOffset(33880)] public RetroMusicData m_RetroMusicSonic3k__arr93;
        [FieldOffset(33920)] public RetroMusicData m_RetroMusicSonic3k__arr94;
        [FieldOffset(33960)] public RetroMusicData m_RetroMusicSonic3k__arr95;
        [FieldOffset(34000)] public RetroMusicData m_RetroMusicSonic3k__arr96;
        [FieldOffset(34040)] public RetroMusicData m_RetroMusicSonic3k__arr97;
        [FieldOffset(34080)] public RetroMusicData m_RetroMusicSonic3k__arr98;
        [FieldOffset(34120)] public RetroMusicData m_RetroMusicSonic3k__arr99;
        [FieldOffset(34160)] public RetroMusicData m_RetroMusicSonic3k__arr100;
        [FieldOffset(34200)] public RetroMusicData m_RetroMusicSonic3k__arr101;
        [FieldOffset(34240)] public RetroMusicData m_RetroMusicSonic3k__arr102;
        [FieldOffset(34280)] public RetroMusicData m_RetroMusicSonic3k__arr103;
        [FieldOffset(34320)] public RetroMusicData m_RetroMusicSonic3k__arr104;
        [FieldOffset(34360)] public RetroMusicData m_RetroMusicSonic3k__arr105;
        [FieldOffset(34400)] public RetroMusicData m_RetroMusicSonic3k__arr106;
        [FieldOffset(34440)] public RetroMusicData m_RetroMusicSonic3k__arr107;
        [FieldOffset(34480)] public RetroMusicData m_RetroMusicSonic3k__arr108;
        [FieldOffset(34520)] public RetroMusicData m_RetroMusicSonic3k__arr109;
        [FieldOffset(34560)] public RetroMusicData m_RetroMusicSonic3k__arr110;
        [FieldOffset(34600)] public RetroMusicData m_RetroMusicSonic3k__arr111;
        [FieldOffset(34640)] public RetroMusicData m_RetroMusicSonic3k__arr112;
        [FieldOffset(34680)] public RetroMusicData m_RetroMusicSonicCD__arr0;
        [FieldOffset(34720)] public RetroMusicData m_RetroMusicSonicCD__arr1;
        [FieldOffset(34760)] public RetroMusicData m_RetroMusicSonicCD__arr2;
        [FieldOffset(34800)] public RetroMusicData m_RetroMusicSonicCD__arr3;
        [FieldOffset(34840)] public RetroMusicData m_RetroMusicSonicCD__arr4;
        [FieldOffset(34880)] public RetroMusicData m_RetroMusicSonicCD__arr5;
        [FieldOffset(34920)] public RetroMusicData m_RetroMusicSonicCD__arr6;
        [FieldOffset(34960)] public RetroMusicData m_RetroMusicSonicCD__arr7;
        [FieldOffset(35000)] public RetroMusicData m_RetroMusicSonicCD__arr8;
        [FieldOffset(35040)] public RetroMusicData m_RetroMusicSonicCD__arr9;
        [FieldOffset(35080)] public RetroMusicData m_RetroMusicSonicCD__arr10;
        [FieldOffset(35120)] public RetroMusicData m_RetroMusicSonicCD__arr11;
        [FieldOffset(35160)] public RetroMusicData m_RetroMusicSonicCD__arr12;
        [FieldOffset(35200)] public RetroMusicData m_RetroMusicSonicCD__arr13;
        [FieldOffset(35240)] public RetroMusicData m_RetroMusicSonicCD__arr14;
        [FieldOffset(35280)] public RetroMusicData m_RetroMusicSonicCD__arr15;
        [FieldOffset(35320)] public RetroMusicData m_RetroMusicSonicCD__arr16;
        [FieldOffset(35360)] public RetroMusicData m_RetroMusicSonicCD__arr17;
        [FieldOffset(35400)] public RetroMusicData m_RetroMusicSonicCD__arr18;
        [FieldOffset(35440)] public RetroMusicData m_RetroMusicSonicCD__arr19;
        [FieldOffset(35480)] public RetroMusicData m_RetroMusicSonicCD__arr20;
        [FieldOffset(35520)] public RetroMusicData m_RetroMusicSonicCD__arr21;
        [FieldOffset(35560)] public RetroMusicData m_RetroMusicSonicCD__arr22;
        [FieldOffset(35600)] public RetroMusicData m_RetroMusicSonicCD__arr23;
        [FieldOffset(35640)] public RetroMusicData m_RetroMusicSonicCD__arr24;
        [FieldOffset(35680)] public RetroMusicData m_RetroMusicSonicCD__arr25;
        [FieldOffset(35720)] public RetroMusicData m_RetroMusicSonicCD__arr26;
        [FieldOffset(35760)] public RetroMusicData m_RetroMusicSonicCD__arr27;
        [FieldOffset(35800)] public RetroMusicData m_RetroMusicSonicCD__arr28;
        [FieldOffset(35840)] public RetroMusicData m_RetroMusicSonicCD__arr29;
        [FieldOffset(35880)] public RetroMusicData m_RetroMusicSonicCD__arr30;
        [FieldOffset(35920)] public RetroMusicData m_RetroMusicSonicCD__arr31;
        [FieldOffset(35960)] public RetroMusicData m_RetroMusicSonicCD__arr32;
        [FieldOffset(36000)] public RetroMusicData m_RetroMusicSonicCD__arr33;
        [FieldOffset(36040)] public RetroMusicData m_RetroMusicSonicCD__arr34;
        [FieldOffset(36080)] public RetroMusicData m_RetroMusicSonicCD__arr35;
        [FieldOffset(36120)] public RetroMusicData m_RetroMusicSonicCD__arr36;
        [FieldOffset(36160)] public RetroMusicData m_RetroMusicSonicCD__arr37;
        [FieldOffset(36200)] public RetroMusicData m_RetroMusicSonicCD__arr38;
        [FieldOffset(36240)] public RetroMusicData m_RetroMusicSonicCD__arr39;
        [FieldOffset(36280)] public RetroMusicData m_RetroMusicSonicCD__arr40;
        [FieldOffset(36320)] public RetroMusicData m_RetroMusicSonicCD__arr41;
        [FieldOffset(36360)] public RetroMusicData m_RetroMusicSonicCD__arr42;
        [FieldOffset(36400)] public RetroMusicData m_RetroMusicSonicCD__arr43;
        [FieldOffset(36440)] public RetroMusicData m_RetroMusicSonicCD__arr44;
        [FieldOffset(36480)] public RetroMusicData m_RetroMusicSonicCD__arr45;
        [FieldOffset(36520)] public RetroMusicData m_RetroMusicSonicCD__arr46;
        [FieldOffset(36560)] public RetroMusicData m_RetroMusicSonicCD__arr47;
        [FieldOffset(36600)] public RetroMusicData m_RetroMusicSonicCD__arr48;
        [FieldOffset(36640)] public RetroMusicData m_RetroMusicSonicCD__arr49;
        [FieldOffset(36680)] public RetroMusicData m_RetroMusicSonicCD__arr50;
        [FieldOffset(36720)] public RetroMusicData m_RetroMusicSonicCD__arr51;
        [FieldOffset(36760)] public RetroMusicData m_RetroMusicSonicCD__arr52;
        [FieldOffset(36800)] public RetroMusicData m_RetroMusicSonicCD__arr53;
        [FieldOffset(36840)] public RetroMusicData m_RetroMusicSonicCD__arr54;
        [FieldOffset(36880)] public RetroMusicData m_RetroMusicSonicCD__arr55;
        [FieldOffset(36920)] public RetroMusicData m_RetroMusicSonicCD__arr56;
        [FieldOffset(36960)] public RetroMusicData m_RetroMusicSonicCD__arr57;
        [FieldOffset(37000)] public RetroMusicData m_RetroMusicSonicCD__arr58;
        [FieldOffset(37040)] public RetroMusicData m_RetroMusicSonicCD__arr59;
        [FieldOffset(37080)] public RetroMusicData m_RetroMusicSonicCD__arr60;
        [FieldOffset(37120)] public RetroMusicData m_RetroMusicSonicCD__arr61;
        [FieldOffset(37160)] public RetroMusicData m_RetroMusicSonicCD__arr62;
        [FieldOffset(37200)] public RetroMusicData m_RetroMusicSonicCD__arr63;
        [FieldOffset(37240)] public RetroMusicData m_RetroMusicSonicCD__arr64;
        [FieldOffset(37280)] public RetroMusicData m_RetroMusicSonicCD__arr65;
        [FieldOffset(37320)] public RetroMusicData m_RetroMusicSonicCD__arr66;
        [FieldOffset(37360)] public RetroMusicData m_RetroMusicSonicCD__arr67;
        [FieldOffset(37400)] public RetroBossrushData m_RetroBossrushSonic1__arr0;
        [FieldOffset(37416)] public RetroBossrushData m_RetroBossrushSonic1__arr1;
        [FieldOffset(37432)] public RetroBossrushData m_RetroBossrushSonic1__arr2;
        [FieldOffset(37448)] public RetroBossrushData m_RetroBossrushSonic1__arr3;
        [FieldOffset(37464)] public RetroBossrushData m_RetroBossrushSonic1__arr4;
        [FieldOffset(37480)] public RetroBossrushData m_RetroBossrushSonic1__arr5;
        [FieldOffset(37496)] public RetroBossrushData m_RetroBossrushSonic2__arr0;
        [FieldOffset(37512)] public RetroBossrushData m_RetroBossrushSonic2__arr1;
        [FieldOffset(37528)] public RetroBossrushData m_RetroBossrushSonic2__arr2;
        [FieldOffset(37544)] public RetroBossrushData m_RetroBossrushSonic2__arr3;
        [FieldOffset(37560)] public RetroBossrushData m_RetroBossrushSonic2__arr4;
        [FieldOffset(37576)] public RetroBossrushData m_RetroBossrushSonic2__arr5;
        [FieldOffset(37592)] public RetroBossrushData m_RetroBossrushSonic2__arr6;
        [FieldOffset(37608)] public RetroBossrushData m_RetroBossrushSonic2__arr7;
        [FieldOffset(37624)] public RetroBossrushData m_RetroBossrushSonic2__arr8;
        [FieldOffset(37640)] public RetroBossrushData m_RetroBossrushSonic2__arr9;
        [FieldOffset(37656)] public RetroBossrushData m_RetroBossrushSonic3k__arr0;
        [FieldOffset(37672)] public RetroBossrushData m_RetroBossrushSonic3k__arr1;
        [FieldOffset(37688)] public RetroBossrushData m_RetroBossrushSonic3k__arr2;
        [FieldOffset(37704)] public RetroBossrushData m_RetroBossrushSonic3k__arr3;
        [FieldOffset(37720)] public RetroBossrushData m_RetroBossrushSonic3k__arr4;
        [FieldOffset(37736)] public RetroBossrushData m_RetroBossrushSonic3k__arr5;
        [FieldOffset(37752)] public RetroBossrushData m_RetroBossrushSonic3k__arr6;
        [FieldOffset(37768)] public RetroBossrushData m_RetroBossrushSonic3k__arr7;
        [FieldOffset(37784)] public RetroBossrushData m_RetroBossrushSonic3k__arr8;
        [FieldOffset(37800)] public RetroBossrushData m_RetroBossrushSonic3k__arr9;
        [FieldOffset(37816)] public RetroBossrushData m_RetroBossrushSonic3k__arr10;
        [FieldOffset(37832)] public RetroBossrushData m_RetroBossrushSonic3kk__arr0;
        [FieldOffset(37848)] public RetroBossrushData m_RetroBossrushSonic3kk__arr1;
        [FieldOffset(37864)] public RetroBossrushData m_RetroBossrushSonic3kk__arr2;
        [FieldOffset(37880)] public RetroBossrushData m_RetroBossrushSonic3kk__arr3;
        [FieldOffset(37896)] public RetroBossrushData m_RetroBossrushSonic3kk__arr4;
        [FieldOffset(37912)] public RetroBossrushData m_RetroBossrushSonic3kk__arr5;
        [FieldOffset(37928)] public RetroBossrushData m_RetroBossrushSonic3kk__arr6;
        [FieldOffset(37944)] public RetroBossrushData m_RetroBossrushSonic3kk__arr7;
        [FieldOffset(37960)] public RetroBossrushData m_RetroBossrushSonic3kk__arr8;
        [FieldOffset(37976)] public RetroBossrushData m_RetroBossrushSonicCD__arr0;
        [FieldOffset(37992)] public RetroBossrushData m_RetroBossrushSonicCD__arr1;
        [FieldOffset(38008)] public RetroBossrushData m_RetroBossrushSonicCD__arr2;
        [FieldOffset(38024)] public RetroBossrushData m_RetroBossrushSonicCD__arr3;
        [FieldOffset(38040)] public RetroBossrushData m_RetroBossrushSonicCD__arr4;
        [FieldOffset(38056)] public RetroBossrushData m_RetroBossrushSonicCD__arr5;
        [FieldOffset(38072)] public RetroBossrushData m_RetroBossrushSonicCD__arr6;
    }

}