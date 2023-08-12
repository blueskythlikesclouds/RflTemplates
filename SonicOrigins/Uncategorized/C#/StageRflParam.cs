using System.Numerics;
using System.Runtime.InteropServices;

public class StageRflParamClass
{
    public enum BootTitle : sbyte
    {
        BOOT_TITLE_V5 = 0,
        BOOT_TITLE_SONICMANIA = 0,
        BOOT_TITLE_SONIC1 = 0,
        BOOT_TITLE_SONIC2 = 1,
        BOOT_TITLE_SONIC3K = 2,
        BOOT_TITLE_SONICCD = 3,
        BOOT_TITLE_NUM = 4,
        BOOT_TITLE_UNKNOWN = -1
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

    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public struct StageKindParam
    {
        [FieldOffset(0)]  public BootTitle title;
        [FieldOffset(4)]  public uint category;
        [FieldOffset(8)]  public StageKind stageKind;
        [FieldOffset(12)] public uint stageNo;
        [FieldOffset(16)] public uint listPos;
        [FieldOffset(20)] public uint progress;
        [FieldOffset(24)] public uint branchDeathEggProgress;
    }

    [StructLayout(LayoutKind.Explicit, Size = 5040)]
    public struct StageRflParam
    {
        [FieldOffset(0)] public StageKindParam stageKindInfos__arr0;
        [FieldOffset(28)] public StageKindParam stageKindInfos__arr1;
        [FieldOffset(56)] public StageKindParam stageKindInfos__arr2;
        [FieldOffset(84)] public StageKindParam stageKindInfos__arr3;
        [FieldOffset(112)] public StageKindParam stageKindInfos__arr4;
        [FieldOffset(140)] public StageKindParam stageKindInfos__arr5;
        [FieldOffset(168)] public StageKindParam stageKindInfos__arr6;
        [FieldOffset(196)] public StageKindParam stageKindInfos__arr7;
        [FieldOffset(224)] public StageKindParam stageKindInfos__arr8;
        [FieldOffset(252)] public StageKindParam stageKindInfos__arr9;
        [FieldOffset(280)] public StageKindParam stageKindInfos__arr10;
        [FieldOffset(308)] public StageKindParam stageKindInfos__arr11;
        [FieldOffset(336)] public StageKindParam stageKindInfos__arr12;
        [FieldOffset(364)] public StageKindParam stageKindInfos__arr13;
        [FieldOffset(392)] public StageKindParam stageKindInfos__arr14;
        [FieldOffset(420)] public StageKindParam stageKindInfos__arr15;
        [FieldOffset(448)] public StageKindParam stageKindInfos__arr16;
        [FieldOffset(476)] public StageKindParam stageKindInfos__arr17;
        [FieldOffset(504)] public StageKindParam stageKindInfos__arr18;
        [FieldOffset(532)] public StageKindParam stageKindInfos__arr19;
        [FieldOffset(560)] public StageKindParam stageKindInfos__arr20;
        [FieldOffset(588)] public StageKindParam stageKindInfos__arr21;
        [FieldOffset(616)] public StageKindParam stageKindInfos__arr22;
        [FieldOffset(644)] public StageKindParam stageKindInfos__arr23;
        [FieldOffset(672)] public StageKindParam stageKindInfos__arr24;
        [FieldOffset(700)] public StageKindParam stageKindInfos__arr25;
        [FieldOffset(728)] public StageKindParam stageKindInfos__arr26;
        [FieldOffset(756)] public StageKindParam stageKindInfos__arr27;
        [FieldOffset(784)] public StageKindParam stageKindInfos__arr28;
        [FieldOffset(812)] public StageKindParam stageKindInfos__arr29;
        [FieldOffset(840)] public StageKindParam stageKindInfos__arr30;
        [FieldOffset(868)] public StageKindParam stageKindInfos__arr31;
        [FieldOffset(896)] public StageKindParam stageKindInfos__arr32;
        [FieldOffset(924)] public StageKindParam stageKindInfos__arr33;
        [FieldOffset(952)] public StageKindParam stageKindInfos__arr34;
        [FieldOffset(980)] public StageKindParam stageKindInfos__arr35;
        [FieldOffset(1008)] public StageKindParam stageKindInfos__arr36;
        [FieldOffset(1036)] public StageKindParam stageKindInfos__arr37;
        [FieldOffset(1064)] public StageKindParam stageKindInfos__arr38;
        [FieldOffset(1092)] public StageKindParam stageKindInfos__arr39;
        [FieldOffset(1120)] public StageKindParam stageKindInfos__arr40;
        [FieldOffset(1148)] public StageKindParam stageKindInfos__arr41;
        [FieldOffset(1176)] public StageKindParam stageKindInfos__arr42;
        [FieldOffset(1204)] public StageKindParam stageKindInfos__arr43;
        [FieldOffset(1232)] public StageKindParam stageKindInfos__arr44;
        [FieldOffset(1260)] public StageKindParam stageKindInfos__arr45;
        [FieldOffset(1288)] public StageKindParam stageKindInfos__arr46;
        [FieldOffset(1316)] public StageKindParam stageKindInfos__arr47;
        [FieldOffset(1344)] public StageKindParam stageKindInfos__arr48;
        [FieldOffset(1372)] public StageKindParam stageKindInfos__arr49;
        [FieldOffset(1400)] public StageKindParam stageKindInfos__arr50;
        [FieldOffset(1428)] public StageKindParam stageKindInfos__arr51;
        [FieldOffset(1456)] public StageKindParam stageKindInfos__arr52;
        [FieldOffset(1484)] public StageKindParam stageKindInfos__arr53;
        [FieldOffset(1512)] public StageKindParam stageKindInfos__arr54;
        [FieldOffset(1540)] public StageKindParam stageKindInfos__arr55;
        [FieldOffset(1568)] public StageKindParam stageKindInfos__arr56;
        [FieldOffset(1596)] public StageKindParam stageKindInfos__arr57;
        [FieldOffset(1624)] public StageKindParam stageKindInfos__arr58;
        [FieldOffset(1652)] public StageKindParam stageKindInfos__arr59;
        [FieldOffset(1680)] public StageKindParam stageKindInfos__arr60;
        [FieldOffset(1708)] public StageKindParam stageKindInfos__arr61;
        [FieldOffset(1736)] public StageKindParam stageKindInfos__arr62;
        [FieldOffset(1764)] public StageKindParam stageKindInfos__arr63;
        [FieldOffset(1792)] public StageKindParam stageKindInfos__arr64;
        [FieldOffset(1820)] public StageKindParam stageKindInfos__arr65;
        [FieldOffset(1848)] public StageKindParam stageKindInfos__arr66;
        [FieldOffset(1876)] public StageKindParam stageKindInfos__arr67;
        [FieldOffset(1904)] public StageKindParam stageKindInfos__arr68;
        [FieldOffset(1932)] public StageKindParam stageKindInfos__arr69;
        [FieldOffset(1960)] public StageKindParam stageKindInfos__arr70;
        [FieldOffset(1988)] public StageKindParam stageKindInfos__arr71;
        [FieldOffset(2016)] public StageKindParam stageKindInfos__arr72;
        [FieldOffset(2044)] public StageKindParam stageKindInfos__arr73;
        [FieldOffset(2072)] public StageKindParam stageKindInfos__arr74;
        [FieldOffset(2100)] public StageKindParam stageKindInfos__arr75;
        [FieldOffset(2128)] public StageKindParam stageKindInfos__arr76;
        [FieldOffset(2156)] public StageKindParam stageKindInfos__arr77;
        [FieldOffset(2184)] public StageKindParam stageKindInfos__arr78;
        [FieldOffset(2212)] public StageKindParam stageKindInfos__arr79;
        [FieldOffset(2240)] public StageKindParam stageKindInfos__arr80;
        [FieldOffset(2268)] public StageKindParam stageKindInfos__arr81;
        [FieldOffset(2296)] public StageKindParam stageKindInfos__arr82;
        [FieldOffset(2324)] public StageKindParam stageKindInfos__arr83;
        [FieldOffset(2352)] public StageKindParam stageKindInfos__arr84;
        [FieldOffset(2380)] public StageKindParam stageKindInfos__arr85;
        [FieldOffset(2408)] public StageKindParam stageKindInfos__arr86;
        [FieldOffset(2436)] public StageKindParam stageKindInfos__arr87;
        [FieldOffset(2464)] public StageKindParam stageKindInfos__arr88;
        [FieldOffset(2492)] public StageKindParam stageKindInfos__arr89;
        [FieldOffset(2520)] public StageKindParam stageKindInfos__arr90;
        [FieldOffset(2548)] public StageKindParam stageKindInfos__arr91;
        [FieldOffset(2576)] public StageKindParam stageKindInfos__arr92;
        [FieldOffset(2604)] public StageKindParam stageKindInfos__arr93;
        [FieldOffset(2632)] public StageKindParam stageKindInfos__arr94;
        [FieldOffset(2660)] public StageKindParam stageKindInfos__arr95;
        [FieldOffset(2688)] public StageKindParam stageKindInfos__arr96;
        [FieldOffset(2716)] public StageKindParam stageKindInfos__arr97;
        [FieldOffset(2744)] public StageKindParam stageKindInfos__arr98;
        [FieldOffset(2772)] public StageKindParam stageKindInfos__arr99;
        [FieldOffset(2800)] public StageKindParam stageKindInfos__arr100;
        [FieldOffset(2828)] public StageKindParam stageKindInfos__arr101;
        [FieldOffset(2856)] public StageKindParam stageKindInfos__arr102;
        [FieldOffset(2884)] public StageKindParam stageKindInfos__arr103;
        [FieldOffset(2912)] public StageKindParam stageKindInfos__arr104;
        [FieldOffset(2940)] public StageKindParam stageKindInfos__arr105;
        [FieldOffset(2968)] public StageKindParam stageKindInfos__arr106;
        [FieldOffset(2996)] public StageKindParam stageKindInfos__arr107;
        [FieldOffset(3024)] public StageKindParam stageKindInfos__arr108;
        [FieldOffset(3052)] public StageKindParam stageKindInfos__arr109;
        [FieldOffset(3080)] public StageKindParam stageKindInfos__arr110;
        [FieldOffset(3108)] public StageKindParam stageKindInfos__arr111;
        [FieldOffset(3136)] public StageKindParam stageKindInfos__arr112;
        [FieldOffset(3164)] public StageKindParam stageKindInfos__arr113;
        [FieldOffset(3192)] public StageKindParam stageKindInfos__arr114;
        [FieldOffset(3220)] public StageKindParam stageKindInfos__arr115;
        [FieldOffset(3248)] public StageKindParam stageKindInfos__arr116;
        [FieldOffset(3276)] public StageKindParam stageKindInfos__arr117;
        [FieldOffset(3304)] public StageKindParam stageKindInfos__arr118;
        [FieldOffset(3332)] public StageKindParam stageKindInfos__arr119;
        [FieldOffset(3360)] public StageKindParam stageKindInfos__arr120;
        [FieldOffset(3388)] public StageKindParam stageKindInfos__arr121;
        [FieldOffset(3416)] public StageKindParam stageKindInfos__arr122;
        [FieldOffset(3444)] public StageKindParam stageKindInfos__arr123;
        [FieldOffset(3472)] public StageKindParam stageKindInfos__arr124;
        [FieldOffset(3500)] public StageKindParam stageKindInfos__arr125;
        [FieldOffset(3528)] public StageKindParam stageKindInfos__arr126;
        [FieldOffset(3556)] public StageKindParam stageKindInfos__arr127;
        [FieldOffset(3584)] public StageKindParam stageKindInfos__arr128;
        [FieldOffset(3612)] public StageKindParam stageKindInfos__arr129;
        [FieldOffset(3640)] public StageKindParam stageKindInfos__arr130;
        [FieldOffset(3668)] public StageKindParam stageKindInfos__arr131;
        [FieldOffset(3696)] public StageKindParam stageKindInfos__arr132;
        [FieldOffset(3724)] public StageKindParam stageKindInfos__arr133;
        [FieldOffset(3752)] public StageKindParam stageKindInfos__arr134;
        [FieldOffset(3780)] public StageKindParam stageKindInfos__arr135;
        [FieldOffset(3808)] public StageKindParam stageKindInfos__arr136;
        [FieldOffset(3836)] public StageKindParam stageKindInfos__arr137;
        [FieldOffset(3864)] public StageKindParam stageKindInfos__arr138;
        [FieldOffset(3892)] public StageKindParam stageKindInfos__arr139;
        [FieldOffset(3920)] public StageKindParam stageKindInfos__arr140;
        [FieldOffset(3948)] public StageKindParam stageKindInfos__arr141;
        [FieldOffset(3976)] public StageKindParam stageKindInfos__arr142;
        [FieldOffset(4004)] public StageKindParam stageKindInfos__arr143;
        [FieldOffset(4032)] public StageKindParam stageKindInfos__arr144;
        [FieldOffset(4060)] public StageKindParam stageKindInfos__arr145;
        [FieldOffset(4088)] public StageKindParam stageKindInfos__arr146;
        [FieldOffset(4116)] public StageKindParam stageKindInfos__arr147;
        [FieldOffset(4144)] public StageKindParam stageKindInfos__arr148;
        [FieldOffset(4172)] public StageKindParam stageKindInfos__arr149;
        [FieldOffset(4200)] public StageKindParam stageKindInfos__arr150;
        [FieldOffset(4228)] public StageKindParam stageKindInfos__arr151;
        [FieldOffset(4256)] public StageKindParam stageKindInfos__arr152;
        [FieldOffset(4284)] public StageKindParam stageKindInfos__arr153;
        [FieldOffset(4312)] public StageKindParam stageKindInfos__arr154;
        [FieldOffset(4340)] public StageKindParam stageKindInfos__arr155;
        [FieldOffset(4368)] public StageKindParam stageKindInfos__arr156;
        [FieldOffset(4396)] public StageKindParam stageKindInfos__arr157;
        [FieldOffset(4424)] public StageKindParam stageKindInfos__arr158;
        [FieldOffset(4452)] public StageKindParam stageKindInfos__arr159;
        [FieldOffset(4480)] public StageKindParam stageKindInfos__arr160;
        [FieldOffset(4508)] public StageKindParam stageKindInfos__arr161;
        [FieldOffset(4536)] public StageKindParam stageKindInfos__arr162;
        [FieldOffset(4564)] public StageKindParam stageKindInfos__arr163;
        [FieldOffset(4592)] public StageKindParam stageKindInfos__arr164;
        [FieldOffset(4620)] public StageKindParam stageKindInfos__arr165;
        [FieldOffset(4648)] public StageKindParam stageKindInfos__arr166;
        [FieldOffset(4676)] public StageKindParam stageKindInfos__arr167;
        [FieldOffset(4704)] public StageKindParam stageKindInfos__arr168;
        [FieldOffset(4732)] public StageKindParam stageKindInfos__arr169;
        [FieldOffset(4760)] public StageKindParam stageKindInfos__arr170;
        [FieldOffset(4788)] public StageKindParam stageKindInfos__arr171;
        [FieldOffset(4816)] public StageKindParam stageKindInfos__arr172;
        [FieldOffset(4844)] public StageKindParam stageKindInfos__arr173;
        [FieldOffset(4872)] public StageKindParam stageKindInfos__arr174;
        [FieldOffset(4900)] public StageKindParam stageKindInfos__arr175;
        [FieldOffset(4928)] public StageKindParam stageKindInfos__arr176;
        [FieldOffset(4956)] public StageKindParam stageKindInfos__arr177;
        [FieldOffset(4984)] public StageKindParam stageKindInfos__arr178;
        [FieldOffset(5012)] public StageKindParam stageKindInfos__arr179;
    }

}