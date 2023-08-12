using System.Numerics;
using System.Runtime.InteropServices;

public class RankingRflParamClass
{
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

    public enum BootPlayMode : sbyte
    {
        BOOT_PLAYMODE_CLASSIC = 0,
        BOOT_PLAYMODE_ANNIVERSARY = 1,
        BOOT_PLAYMODE_BOSSRUSH = 2,
        BOOT_PLAYMODE_MIRRORING = 3,
        BOOT_PLAYMODE_MISSION = 4,
        BOOT_PLAYMODE_STORY = 5,
        BOOT_PLAYMODE_BLUE_SPHERES_ORIGINAL = 6,
        BOOT_PLAYMODE_BLUE_SPHERES_NEW = 7,
        BOOT_PLAYMODE_GAMEPLAY_COUNT = 8,
        BOOT_PLAYMODE_MUSEUM = 8,
        BOOT_PLAYMODE_RANKING = 9,
        BOOT_PLAYMODE_OPTION = 10,
        BOOT_PLAYMODE_TO_DLC = 11,
        BOOT_PLAYMODE_GAMEGEAR = 12,
        BOOT_PLAYMODE_PUZZLE = 13,
        BOOT_PLAYMODE_NUM = 14,
        BOOT_PLAYMODE_NONE = -1
    }

    public enum StagePlayerType : sbyte
    {
        TYPE_SONIC = 0,
        TYPE_KNUCKLES = 1,
        TYPE_ANYONE = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct RankingKindParam
    {
        [FieldOffset(0)] public StageKind stageKind;
        [FieldOffset(1)] public BootPlayMode playMode;
        [FieldOffset(2)] public StagePlayerType stagePlayer;
        [FieldOffset(3)] public bool valid;
        [FieldOffset(4)] public int minTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 3528)]
    public struct RankingRflParam
    {
        [FieldOffset(0)] public RankingKindParam rankingKindInfos__arr0;
        [FieldOffset(8)] public RankingKindParam rankingKindInfos__arr1;
        [FieldOffset(16)] public RankingKindParam rankingKindInfos__arr2;
        [FieldOffset(24)] public RankingKindParam rankingKindInfos__arr3;
        [FieldOffset(32)] public RankingKindParam rankingKindInfos__arr4;
        [FieldOffset(40)] public RankingKindParam rankingKindInfos__arr5;
        [FieldOffset(48)] public RankingKindParam rankingKindInfos__arr6;
        [FieldOffset(56)] public RankingKindParam rankingKindInfos__arr7;
        [FieldOffset(64)] public RankingKindParam rankingKindInfos__arr8;
        [FieldOffset(72)] public RankingKindParam rankingKindInfos__arr9;
        [FieldOffset(80)] public RankingKindParam rankingKindInfos__arr10;
        [FieldOffset(88)] public RankingKindParam rankingKindInfos__arr11;
        [FieldOffset(96)] public RankingKindParam rankingKindInfos__arr12;
        [FieldOffset(104)] public RankingKindParam rankingKindInfos__arr13;
        [FieldOffset(112)] public RankingKindParam rankingKindInfos__arr14;
        [FieldOffset(120)] public RankingKindParam rankingKindInfos__arr15;
        [FieldOffset(128)] public RankingKindParam rankingKindInfos__arr16;
        [FieldOffset(136)] public RankingKindParam rankingKindInfos__arr17;
        [FieldOffset(144)] public RankingKindParam rankingKindInfos__arr18;
        [FieldOffset(152)] public RankingKindParam rankingKindInfos__arr19;
        [FieldOffset(160)] public RankingKindParam rankingKindInfos__arr20;
        [FieldOffset(168)] public RankingKindParam rankingKindInfos__arr21;
        [FieldOffset(176)] public RankingKindParam rankingKindInfos__arr22;
        [FieldOffset(184)] public RankingKindParam rankingKindInfos__arr23;
        [FieldOffset(192)] public RankingKindParam rankingKindInfos__arr24;
        [FieldOffset(200)] public RankingKindParam rankingKindInfos__arr25;
        [FieldOffset(208)] public RankingKindParam rankingKindInfos__arr26;
        [FieldOffset(216)] public RankingKindParam rankingKindInfos__arr27;
        [FieldOffset(224)] public RankingKindParam rankingKindInfos__arr28;
        [FieldOffset(232)] public RankingKindParam rankingKindInfos__arr29;
        [FieldOffset(240)] public RankingKindParam rankingKindInfos__arr30;
        [FieldOffset(248)] public RankingKindParam rankingKindInfos__arr31;
        [FieldOffset(256)] public RankingKindParam rankingKindInfos__arr32;
        [FieldOffset(264)] public RankingKindParam rankingKindInfos__arr33;
        [FieldOffset(272)] public RankingKindParam rankingKindInfos__arr34;
        [FieldOffset(280)] public RankingKindParam rankingKindInfos__arr35;
        [FieldOffset(288)] public RankingKindParam rankingKindInfos__arr36;
        [FieldOffset(296)] public RankingKindParam rankingKindInfos__arr37;
        [FieldOffset(304)] public RankingKindParam rankingKindInfos__arr38;
        [FieldOffset(312)] public RankingKindParam rankingKindInfos__arr39;
        [FieldOffset(320)] public RankingKindParam rankingKindInfos__arr40;
        [FieldOffset(328)] public RankingKindParam rankingKindInfos__arr41;
        [FieldOffset(336)] public RankingKindParam rankingKindInfos__arr42;
        [FieldOffset(344)] public RankingKindParam rankingKindInfos__arr43;
        [FieldOffset(352)] public RankingKindParam rankingKindInfos__arr44;
        [FieldOffset(360)] public RankingKindParam rankingKindInfos__arr45;
        [FieldOffset(368)] public RankingKindParam rankingKindInfos__arr46;
        [FieldOffset(376)] public RankingKindParam rankingKindInfos__arr47;
        [FieldOffset(384)] public RankingKindParam rankingKindInfos__arr48;
        [FieldOffset(392)] public RankingKindParam rankingKindInfos__arr49;
        [FieldOffset(400)] public RankingKindParam rankingKindInfos__arr50;
        [FieldOffset(408)] public RankingKindParam rankingKindInfos__arr51;
        [FieldOffset(416)] public RankingKindParam rankingKindInfos__arr52;
        [FieldOffset(424)] public RankingKindParam rankingKindInfos__arr53;
        [FieldOffset(432)] public RankingKindParam rankingKindInfos__arr54;
        [FieldOffset(440)] public RankingKindParam rankingKindInfos__arr55;
        [FieldOffset(448)] public RankingKindParam rankingKindInfos__arr56;
        [FieldOffset(456)] public RankingKindParam rankingKindInfos__arr57;
        [FieldOffset(464)] public RankingKindParam rankingKindInfos__arr58;
        [FieldOffset(472)] public RankingKindParam rankingKindInfos__arr59;
        [FieldOffset(480)] public RankingKindParam rankingKindInfos__arr60;
        [FieldOffset(488)] public RankingKindParam rankingKindInfos__arr61;
        [FieldOffset(496)] public RankingKindParam rankingKindInfos__arr62;
        [FieldOffset(504)] public RankingKindParam rankingKindInfos__arr63;
        [FieldOffset(512)] public RankingKindParam rankingKindInfos__arr64;
        [FieldOffset(520)] public RankingKindParam rankingKindInfos__arr65;
        [FieldOffset(528)] public RankingKindParam rankingKindInfos__arr66;
        [FieldOffset(536)] public RankingKindParam rankingKindInfos__arr67;
        [FieldOffset(544)] public RankingKindParam rankingKindInfos__arr68;
        [FieldOffset(552)] public RankingKindParam rankingKindInfos__arr69;
        [FieldOffset(560)] public RankingKindParam rankingKindInfos__arr70;
        [FieldOffset(568)] public RankingKindParam rankingKindInfos__arr71;
        [FieldOffset(576)] public RankingKindParam rankingKindInfos__arr72;
        [FieldOffset(584)] public RankingKindParam rankingKindInfos__arr73;
        [FieldOffset(592)] public RankingKindParam rankingKindInfos__arr74;
        [FieldOffset(600)] public RankingKindParam rankingKindInfos__arr75;
        [FieldOffset(608)] public RankingKindParam rankingKindInfos__arr76;
        [FieldOffset(616)] public RankingKindParam rankingKindInfos__arr77;
        [FieldOffset(624)] public RankingKindParam rankingKindInfos__arr78;
        [FieldOffset(632)] public RankingKindParam rankingKindInfos__arr79;
        [FieldOffset(640)] public RankingKindParam rankingKindInfos__arr80;
        [FieldOffset(648)] public RankingKindParam rankingKindInfos__arr81;
        [FieldOffset(656)] public RankingKindParam rankingKindInfos__arr82;
        [FieldOffset(664)] public RankingKindParam rankingKindInfos__arr83;
        [FieldOffset(672)] public RankingKindParam rankingKindInfos__arr84;
        [FieldOffset(680)] public RankingKindParam rankingKindInfos__arr85;
        [FieldOffset(688)] public RankingKindParam rankingKindInfos__arr86;
        [FieldOffset(696)] public RankingKindParam rankingKindInfos__arr87;
        [FieldOffset(704)] public RankingKindParam rankingKindInfos__arr88;
        [FieldOffset(712)] public RankingKindParam rankingKindInfos__arr89;
        [FieldOffset(720)] public RankingKindParam rankingKindInfos__arr90;
        [FieldOffset(728)] public RankingKindParam rankingKindInfos__arr91;
        [FieldOffset(736)] public RankingKindParam rankingKindInfos__arr92;
        [FieldOffset(744)] public RankingKindParam rankingKindInfos__arr93;
        [FieldOffset(752)] public RankingKindParam rankingKindInfos__arr94;
        [FieldOffset(760)] public RankingKindParam rankingKindInfos__arr95;
        [FieldOffset(768)] public RankingKindParam rankingKindInfos__arr96;
        [FieldOffset(776)] public RankingKindParam rankingKindInfos__arr97;
        [FieldOffset(784)] public RankingKindParam rankingKindInfos__arr98;
        [FieldOffset(792)] public RankingKindParam rankingKindInfos__arr99;
        [FieldOffset(800)] public RankingKindParam rankingKindInfos__arr100;
        [FieldOffset(808)] public RankingKindParam rankingKindInfos__arr101;
        [FieldOffset(816)] public RankingKindParam rankingKindInfos__arr102;
        [FieldOffset(824)] public RankingKindParam rankingKindInfos__arr103;
        [FieldOffset(832)] public RankingKindParam rankingKindInfos__arr104;
        [FieldOffset(840)] public RankingKindParam rankingKindInfos__arr105;
        [FieldOffset(848)] public RankingKindParam rankingKindInfos__arr106;
        [FieldOffset(856)] public RankingKindParam rankingKindInfos__arr107;
        [FieldOffset(864)] public RankingKindParam rankingKindInfos__arr108;
        [FieldOffset(872)] public RankingKindParam rankingKindInfos__arr109;
        [FieldOffset(880)] public RankingKindParam rankingKindInfos__arr110;
        [FieldOffset(888)] public RankingKindParam rankingKindInfos__arr111;
        [FieldOffset(896)] public RankingKindParam rankingKindInfos__arr112;
        [FieldOffset(904)] public RankingKindParam rankingKindInfos__arr113;
        [FieldOffset(912)] public RankingKindParam rankingKindInfos__arr114;
        [FieldOffset(920)] public RankingKindParam rankingKindInfos__arr115;
        [FieldOffset(928)] public RankingKindParam rankingKindInfos__arr116;
        [FieldOffset(936)] public RankingKindParam rankingKindInfos__arr117;
        [FieldOffset(944)] public RankingKindParam rankingKindInfos__arr118;
        [FieldOffset(952)] public RankingKindParam rankingKindInfos__arr119;
        [FieldOffset(960)] public RankingKindParam rankingKindInfos__arr120;
        [FieldOffset(968)] public RankingKindParam rankingKindInfos__arr121;
        [FieldOffset(976)] public RankingKindParam rankingKindInfos__arr122;
        [FieldOffset(984)] public RankingKindParam rankingKindInfos__arr123;
        [FieldOffset(992)] public RankingKindParam rankingKindInfos__arr124;
        [FieldOffset(1000)] public RankingKindParam rankingKindInfos__arr125;
        [FieldOffset(1008)] public RankingKindParam rankingKindInfos__arr126;
        [FieldOffset(1016)] public RankingKindParam rankingKindInfos__arr127;
        [FieldOffset(1024)] public RankingKindParam rankingKindInfos__arr128;
        [FieldOffset(1032)] public RankingKindParam rankingKindInfos__arr129;
        [FieldOffset(1040)] public RankingKindParam rankingKindInfos__arr130;
        [FieldOffset(1048)] public RankingKindParam rankingKindInfos__arr131;
        [FieldOffset(1056)] public RankingKindParam rankingKindInfos__arr132;
        [FieldOffset(1064)] public RankingKindParam rankingKindInfos__arr133;
        [FieldOffset(1072)] public RankingKindParam rankingKindInfos__arr134;
        [FieldOffset(1080)] public RankingKindParam rankingKindInfos__arr135;
        [FieldOffset(1088)] public RankingKindParam rankingKindInfos__arr136;
        [FieldOffset(1096)] public RankingKindParam rankingKindInfos__arr137;
        [FieldOffset(1104)] public RankingKindParam rankingKindInfos__arr138;
        [FieldOffset(1112)] public RankingKindParam rankingKindInfos__arr139;
        [FieldOffset(1120)] public RankingKindParam rankingKindInfos__arr140;
        [FieldOffset(1128)] public RankingKindParam rankingKindInfos__arr141;
        [FieldOffset(1136)] public RankingKindParam rankingKindInfos__arr142;
        [FieldOffset(1144)] public RankingKindParam rankingKindInfos__arr143;
        [FieldOffset(1152)] public RankingKindParam rankingKindInfos__arr144;
        [FieldOffset(1160)] public RankingKindParam rankingKindInfos__arr145;
        [FieldOffset(1168)] public RankingKindParam rankingKindInfos__arr146;
        [FieldOffset(1176)] public RankingKindParam rankingKindInfos__arr147;
        [FieldOffset(1184)] public RankingKindParam rankingKindInfos__arr148;
        [FieldOffset(1192)] public RankingKindParam rankingKindInfos__arr149;
        [FieldOffset(1200)] public RankingKindParam rankingKindInfos__arr150;
        [FieldOffset(1208)] public RankingKindParam rankingKindInfos__arr151;
        [FieldOffset(1216)] public RankingKindParam rankingKindInfos__arr152;
        [FieldOffset(1224)] public RankingKindParam rankingKindInfos__arr153;
        [FieldOffset(1232)] public RankingKindParam rankingKindInfos__arr154;
        [FieldOffset(1240)] public RankingKindParam rankingKindInfos__arr155;
        [FieldOffset(1248)] public RankingKindParam rankingKindInfos__arr156;
        [FieldOffset(1256)] public RankingKindParam rankingKindInfos__arr157;
        [FieldOffset(1264)] public RankingKindParam rankingKindInfos__arr158;
        [FieldOffset(1272)] public RankingKindParam rankingKindInfos__arr159;
        [FieldOffset(1280)] public RankingKindParam rankingKindInfos__arr160;
        [FieldOffset(1288)] public RankingKindParam rankingKindInfos__arr161;
        [FieldOffset(1296)] public RankingKindParam rankingKindInfos__arr162;
        [FieldOffset(1304)] public RankingKindParam rankingKindInfos__arr163;
        [FieldOffset(1312)] public RankingKindParam rankingKindInfos__arr164;
        [FieldOffset(1320)] public RankingKindParam rankingKindInfos__arr165;
        [FieldOffset(1328)] public RankingKindParam rankingKindInfos__arr166;
        [FieldOffset(1336)] public RankingKindParam rankingKindInfos__arr167;
        [FieldOffset(1344)] public RankingKindParam rankingKindInfos__arr168;
        [FieldOffset(1352)] public RankingKindParam rankingKindInfos__arr169;
        [FieldOffset(1360)] public RankingKindParam rankingKindInfos__arr170;
        [FieldOffset(1368)] public RankingKindParam rankingKindInfos__arr171;
        [FieldOffset(1376)] public RankingKindParam rankingKindInfos__arr172;
        [FieldOffset(1384)] public RankingKindParam rankingKindInfos__arr173;
        [FieldOffset(1392)] public RankingKindParam rankingKindInfos__arr174;
        [FieldOffset(1400)] public RankingKindParam rankingKindInfos__arr175;
        [FieldOffset(1408)] public RankingKindParam rankingKindInfos__arr176;
        [FieldOffset(1416)] public RankingKindParam rankingKindInfos__arr177;
        [FieldOffset(1424)] public RankingKindParam rankingKindInfos__arr178;
        [FieldOffset(1432)] public RankingKindParam rankingKindInfos__arr179;
        [FieldOffset(1440)] public RankingKindParam rankingKindInfos__arr180;
        [FieldOffset(1448)] public RankingKindParam rankingKindInfos__arr181;
        [FieldOffset(1456)] public RankingKindParam rankingKindInfos__arr182;
        [FieldOffset(1464)] public RankingKindParam rankingKindInfos__arr183;
        [FieldOffset(1472)] public RankingKindParam rankingKindInfos__arr184;
        [FieldOffset(1480)] public RankingKindParam rankingKindInfos__arr185;
        [FieldOffset(1488)] public RankingKindParam rankingKindInfos__arr186;
        [FieldOffset(1496)] public RankingKindParam rankingKindInfos__arr187;
        [FieldOffset(1504)] public RankingKindParam rankingKindInfos__arr188;
        [FieldOffset(1512)] public RankingKindParam rankingKindInfos__arr189;
        [FieldOffset(1520)] public RankingKindParam rankingKindInfos__arr190;
        [FieldOffset(1528)] public RankingKindParam rankingKindInfos__arr191;
        [FieldOffset(1536)] public RankingKindParam rankingKindInfos__arr192;
        [FieldOffset(1544)] public RankingKindParam rankingKindInfos__arr193;
        [FieldOffset(1552)] public RankingKindParam rankingKindInfos__arr194;
        [FieldOffset(1560)] public RankingKindParam rankingKindInfos__arr195;
        [FieldOffset(1568)] public RankingKindParam rankingKindInfos__arr196;
        [FieldOffset(1576)] public RankingKindParam rankingKindInfos__arr197;
        [FieldOffset(1584)] public RankingKindParam rankingKindInfos__arr198;
        [FieldOffset(1592)] public RankingKindParam rankingKindInfos__arr199;
        [FieldOffset(1600)] public RankingKindParam rankingKindInfos__arr200;
        [FieldOffset(1608)] public RankingKindParam rankingKindInfos__arr201;
        [FieldOffset(1616)] public RankingKindParam rankingKindInfos__arr202;
        [FieldOffset(1624)] public RankingKindParam rankingKindInfos__arr203;
        [FieldOffset(1632)] public RankingKindParam rankingKindInfos__arr204;
        [FieldOffset(1640)] public RankingKindParam rankingKindInfos__arr205;
        [FieldOffset(1648)] public RankingKindParam rankingKindInfos__arr206;
        [FieldOffset(1656)] public RankingKindParam rankingKindInfos__arr207;
        [FieldOffset(1664)] public RankingKindParam rankingKindInfos__arr208;
        [FieldOffset(1672)] public RankingKindParam rankingKindInfos__arr209;
        [FieldOffset(1680)] public RankingKindParam rankingKindInfos__arr210;
        [FieldOffset(1688)] public RankingKindParam rankingKindInfos__arr211;
        [FieldOffset(1696)] public RankingKindParam rankingKindInfos__arr212;
        [FieldOffset(1704)] public RankingKindParam rankingKindInfos__arr213;
        [FieldOffset(1712)] public RankingKindParam rankingKindInfos__arr214;
        [FieldOffset(1720)] public RankingKindParam rankingKindInfos__arr215;
        [FieldOffset(1728)] public RankingKindParam rankingKindInfos__arr216;
        [FieldOffset(1736)] public RankingKindParam rankingKindInfos__arr217;
        [FieldOffset(1744)] public RankingKindParam rankingKindInfos__arr218;
        [FieldOffset(1752)] public RankingKindParam rankingKindInfos__arr219;
        [FieldOffset(1760)] public RankingKindParam rankingKindInfos__arr220;
        [FieldOffset(1768)] public RankingKindParam rankingKindInfos__arr221;
        [FieldOffset(1776)] public RankingKindParam rankingKindInfos__arr222;
        [FieldOffset(1784)] public RankingKindParam rankingKindInfos__arr223;
        [FieldOffset(1792)] public RankingKindParam rankingKindInfos__arr224;
        [FieldOffset(1800)] public RankingKindParam rankingKindInfos__arr225;
        [FieldOffset(1808)] public RankingKindParam rankingKindInfos__arr226;
        [FieldOffset(1816)] public RankingKindParam rankingKindInfos__arr227;
        [FieldOffset(1824)] public RankingKindParam rankingKindInfos__arr228;
        [FieldOffset(1832)] public RankingKindParam rankingKindInfos__arr229;
        [FieldOffset(1840)] public RankingKindParam rankingKindInfos__arr230;
        [FieldOffset(1848)] public RankingKindParam rankingKindInfos__arr231;
        [FieldOffset(1856)] public RankingKindParam rankingKindInfos__arr232;
        [FieldOffset(1864)] public RankingKindParam rankingKindInfos__arr233;
        [FieldOffset(1872)] public RankingKindParam rankingKindInfos__arr234;
        [FieldOffset(1880)] public RankingKindParam rankingKindInfos__arr235;
        [FieldOffset(1888)] public RankingKindParam rankingKindInfos__arr236;
        [FieldOffset(1896)] public RankingKindParam rankingKindInfos__arr237;
        [FieldOffset(1904)] public RankingKindParam rankingKindInfos__arr238;
        [FieldOffset(1912)] public RankingKindParam rankingKindInfos__arr239;
        [FieldOffset(1920)] public RankingKindParam rankingKindInfos__arr240;
        [FieldOffset(1928)] public RankingKindParam rankingKindInfos__arr241;
        [FieldOffset(1936)] public RankingKindParam rankingKindInfos__arr242;
        [FieldOffset(1944)] public RankingKindParam rankingKindInfos__arr243;
        [FieldOffset(1952)] public RankingKindParam rankingKindInfos__arr244;
        [FieldOffset(1960)] public RankingKindParam rankingKindInfos__arr245;
        [FieldOffset(1968)] public RankingKindParam rankingKindInfos__arr246;
        [FieldOffset(1976)] public RankingKindParam rankingKindInfos__arr247;
        [FieldOffset(1984)] public RankingKindParam rankingKindInfos__arr248;
        [FieldOffset(1992)] public RankingKindParam rankingKindInfos__arr249;
        [FieldOffset(2000)] public RankingKindParam rankingKindInfos__arr250;
        [FieldOffset(2008)] public RankingKindParam rankingKindInfos__arr251;
        [FieldOffset(2016)] public RankingKindParam rankingKindInfos__arr252;
        [FieldOffset(2024)] public RankingKindParam rankingKindInfos__arr253;
        [FieldOffset(2032)] public RankingKindParam rankingKindInfos__arr254;
        [FieldOffset(2040)] public RankingKindParam rankingKindInfos__arr255;
        [FieldOffset(2048)] public RankingKindParam rankingKindInfos__arr256;
        [FieldOffset(2056)] public RankingKindParam rankingKindInfos__arr257;
        [FieldOffset(2064)] public RankingKindParam rankingKindInfos__arr258;
        [FieldOffset(2072)] public RankingKindParam rankingKindInfos__arr259;
        [FieldOffset(2080)] public RankingKindParam rankingKindInfos__arr260;
        [FieldOffset(2088)] public RankingKindParam rankingKindInfos__arr261;
        [FieldOffset(2096)] public RankingKindParam rankingKindInfos__arr262;
        [FieldOffset(2104)] public RankingKindParam rankingKindInfos__arr263;
        [FieldOffset(2112)] public RankingKindParam rankingKindInfos__arr264;
        [FieldOffset(2120)] public RankingKindParam rankingKindInfos__arr265;
        [FieldOffset(2128)] public RankingKindParam rankingKindInfos__arr266;
        [FieldOffset(2136)] public RankingKindParam rankingKindInfos__arr267;
        [FieldOffset(2144)] public RankingKindParam rankingKindInfos__arr268;
        [FieldOffset(2152)] public RankingKindParam rankingKindInfos__arr269;
        [FieldOffset(2160)] public RankingKindParam rankingKindInfos__arr270;
        [FieldOffset(2168)] public RankingKindParam rankingKindInfos__arr271;
        [FieldOffset(2176)] public RankingKindParam rankingKindInfos__arr272;
        [FieldOffset(2184)] public RankingKindParam rankingKindInfos__arr273;
        [FieldOffset(2192)] public RankingKindParam rankingKindInfos__arr274;
        [FieldOffset(2200)] public RankingKindParam rankingKindInfos__arr275;
        [FieldOffset(2208)] public RankingKindParam rankingKindInfos__arr276;
        [FieldOffset(2216)] public RankingKindParam rankingKindInfos__arr277;
        [FieldOffset(2224)] public RankingKindParam rankingKindInfos__arr278;
        [FieldOffset(2232)] public RankingKindParam rankingKindInfos__arr279;
        [FieldOffset(2240)] public RankingKindParam rankingKindInfos__arr280;
        [FieldOffset(2248)] public RankingKindParam rankingKindInfos__arr281;
        [FieldOffset(2256)] public RankingKindParam rankingKindInfos__arr282;
        [FieldOffset(2264)] public RankingKindParam rankingKindInfos__arr283;
        [FieldOffset(2272)] public RankingKindParam rankingKindInfos__arr284;
        [FieldOffset(2280)] public RankingKindParam rankingKindInfos__arr285;
        [FieldOffset(2288)] public RankingKindParam rankingKindInfos__arr286;
        [FieldOffset(2296)] public RankingKindParam rankingKindInfos__arr287;
        [FieldOffset(2304)] public RankingKindParam rankingKindInfos__arr288;
        [FieldOffset(2312)] public RankingKindParam rankingKindInfos__arr289;
        [FieldOffset(2320)] public RankingKindParam rankingKindInfos__arr290;
        [FieldOffset(2328)] public RankingKindParam rankingKindInfos__arr291;
        [FieldOffset(2336)] public RankingKindParam rankingKindInfos__arr292;
        [FieldOffset(2344)] public RankingKindParam rankingKindInfos__arr293;
        [FieldOffset(2352)] public RankingKindParam rankingKindInfos__arr294;
        [FieldOffset(2360)] public RankingKindParam rankingKindInfos__arr295;
        [FieldOffset(2368)] public RankingKindParam rankingKindInfos__arr296;
        [FieldOffset(2376)] public RankingKindParam rankingKindInfos__arr297;
        [FieldOffset(2384)] public RankingKindParam rankingKindInfos__arr298;
        [FieldOffset(2392)] public RankingKindParam rankingKindInfos__arr299;
        [FieldOffset(2400)] public RankingKindParam rankingKindInfos__arr300;
        [FieldOffset(2408)] public RankingKindParam rankingKindInfos__arr301;
        [FieldOffset(2416)] public RankingKindParam rankingKindInfos__arr302;
        [FieldOffset(2424)] public RankingKindParam rankingKindInfos__arr303;
        [FieldOffset(2432)] public RankingKindParam rankingKindInfos__arr304;
        [FieldOffset(2440)] public RankingKindParam rankingKindInfos__arr305;
        [FieldOffset(2448)] public RankingKindParam rankingKindInfos__arr306;
        [FieldOffset(2456)] public RankingKindParam rankingKindInfos__arr307;
        [FieldOffset(2464)] public RankingKindParam rankingKindInfos__arr308;
        [FieldOffset(2472)] public RankingKindParam rankingKindInfos__arr309;
        [FieldOffset(2480)] public RankingKindParam rankingKindInfos__arr310;
        [FieldOffset(2488)] public RankingKindParam rankingKindInfos__arr311;
        [FieldOffset(2496)] public RankingKindParam rankingKindInfos__arr312;
        [FieldOffset(2504)] public RankingKindParam rankingKindInfos__arr313;
        [FieldOffset(2512)] public RankingKindParam rankingKindInfos__arr314;
        [FieldOffset(2520)] public RankingKindParam rankingKindInfos__arr315;
        [FieldOffset(2528)] public RankingKindParam rankingKindInfos__arr316;
        [FieldOffset(2536)] public RankingKindParam rankingKindInfos__arr317;
        [FieldOffset(2544)] public RankingKindParam rankingKindInfos__arr318;
        [FieldOffset(2552)] public RankingKindParam rankingKindInfos__arr319;
        [FieldOffset(2560)] public RankingKindParam rankingKindInfos__arr320;
        [FieldOffset(2568)] public RankingKindParam rankingKindInfos__arr321;
        [FieldOffset(2576)] public RankingKindParam rankingKindInfos__arr322;
        [FieldOffset(2584)] public RankingKindParam rankingKindInfos__arr323;
        [FieldOffset(2592)] public RankingKindParam rankingKindInfos__arr324;
        [FieldOffset(2600)] public RankingKindParam rankingKindInfos__arr325;
        [FieldOffset(2608)] public RankingKindParam rankingKindInfos__arr326;
        [FieldOffset(2616)] public RankingKindParam rankingKindInfos__arr327;
        [FieldOffset(2624)] public RankingKindParam rankingKindInfos__arr328;
        [FieldOffset(2632)] public RankingKindParam rankingKindInfos__arr329;
        [FieldOffset(2640)] public RankingKindParam rankingKindInfos__arr330;
        [FieldOffset(2648)] public RankingKindParam rankingKindInfos__arr331;
        [FieldOffset(2656)] public RankingKindParam rankingKindInfos__arr332;
        [FieldOffset(2664)] public RankingKindParam rankingKindInfos__arr333;
        [FieldOffset(2672)] public RankingKindParam rankingKindInfos__arr334;
        [FieldOffset(2680)] public RankingKindParam rankingKindInfos__arr335;
        [FieldOffset(2688)] public RankingKindParam rankingKindInfos__arr336;
        [FieldOffset(2696)] public RankingKindParam rankingKindInfos__arr337;
        [FieldOffset(2704)] public RankingKindParam rankingKindInfos__arr338;
        [FieldOffset(2712)] public RankingKindParam rankingKindInfos__arr339;
        [FieldOffset(2720)] public RankingKindParam rankingKindInfos__arr340;
        [FieldOffset(2728)] public RankingKindParam rankingKindInfos__arr341;
        [FieldOffset(2736)] public RankingKindParam rankingKindInfos__arr342;
        [FieldOffset(2744)] public RankingKindParam rankingKindInfos__arr343;
        [FieldOffset(2752)] public RankingKindParam rankingKindInfos__arr344;
        [FieldOffset(2760)] public RankingKindParam rankingKindInfos__arr345;
        [FieldOffset(2768)] public RankingKindParam rankingKindInfos__arr346;
        [FieldOffset(2776)] public RankingKindParam rankingKindInfos__arr347;
        [FieldOffset(2784)] public RankingKindParam rankingKindInfos__arr348;
        [FieldOffset(2792)] public RankingKindParam rankingKindInfos__arr349;
        [FieldOffset(2800)] public RankingKindParam rankingKindInfos__arr350;
        [FieldOffset(2808)] public RankingKindParam rankingKindInfos__arr351;
        [FieldOffset(2816)] public RankingKindParam rankingKindInfos__arr352;
        [FieldOffset(2824)] public RankingKindParam rankingKindInfos__arr353;
        [FieldOffset(2832)] public RankingKindParam rankingKindInfos__arr354;
        [FieldOffset(2840)] public RankingKindParam rankingKindInfos__arr355;
        [FieldOffset(2848)] public RankingKindParam rankingKindInfos__arr356;
        [FieldOffset(2856)] public RankingKindParam rankingKindInfos__arr357;
        [FieldOffset(2864)] public RankingKindParam rankingKindInfos__arr358;
        [FieldOffset(2872)] public RankingKindParam rankingKindInfos__arr359;
        [FieldOffset(2880)] public RankingKindParam rankingKindInfos__arr360;
        [FieldOffset(2888)] public RankingKindParam rankingKindInfos__arr361;
        [FieldOffset(2896)] public RankingKindParam rankingKindInfos__arr362;
        [FieldOffset(2904)] public RankingKindParam rankingKindInfos__arr363;
        [FieldOffset(2912)] public RankingKindParam rankingKindInfos__arr364;
        [FieldOffset(2920)] public RankingKindParam rankingKindInfos__arr365;
        [FieldOffset(2928)] public RankingKindParam rankingKindInfos__arr366;
        [FieldOffset(2936)] public RankingKindParam rankingKindInfos__arr367;
        [FieldOffset(2944)] public RankingKindParam rankingKindInfos__arr368;
        [FieldOffset(2952)] public RankingKindParam rankingKindInfos__arr369;
        [FieldOffset(2960)] public RankingKindParam rankingKindInfos__arr370;
        [FieldOffset(2968)] public RankingKindParam rankingKindInfos__arr371;
        [FieldOffset(2976)] public RankingKindParam rankingKindInfos__arr372;
        [FieldOffset(2984)] public RankingKindParam rankingKindInfos__arr373;
        [FieldOffset(2992)] public RankingKindParam rankingKindInfos__arr374;
        [FieldOffset(3000)] public RankingKindParam rankingKindInfos__arr375;
        [FieldOffset(3008)] public RankingKindParam rankingKindInfos__arr376;
        [FieldOffset(3016)] public RankingKindParam rankingKindInfos__arr377;
        [FieldOffset(3024)] public RankingKindParam rankingKindInfos__arr378;
        [FieldOffset(3032)] public RankingKindParam rankingKindInfos__arr379;
        [FieldOffset(3040)] public RankingKindParam rankingKindInfos__arr380;
        [FieldOffset(3048)] public RankingKindParam rankingKindInfos__arr381;
        [FieldOffset(3056)] public RankingKindParam rankingKindInfos__arr382;
        [FieldOffset(3064)] public RankingKindParam rankingKindInfos__arr383;
        [FieldOffset(3072)] public RankingKindParam rankingKindInfos__arr384;
        [FieldOffset(3080)] public RankingKindParam rankingKindInfos__arr385;
        [FieldOffset(3088)] public RankingKindParam rankingKindInfos__arr386;
        [FieldOffset(3096)] public RankingKindParam rankingKindInfos__arr387;
        [FieldOffset(3104)] public RankingKindParam rankingKindInfos__arr388;
        [FieldOffset(3112)] public RankingKindParam rankingKindInfos__arr389;
        [FieldOffset(3120)] public RankingKindParam rankingKindInfos__arr390;
        [FieldOffset(3128)] public RankingKindParam rankingKindInfos__arr391;
        [FieldOffset(3136)] public RankingKindParam rankingKindInfos__arr392;
        [FieldOffset(3144)] public RankingKindParam rankingKindInfos__arr393;
        [FieldOffset(3152)] public RankingKindParam rankingKindInfos__arr394;
        [FieldOffset(3160)] public RankingKindParam rankingKindInfos__arr395;
        [FieldOffset(3168)] public RankingKindParam rankingKindInfos__arr396;
        [FieldOffset(3176)] public RankingKindParam rankingKindInfos__arr397;
        [FieldOffset(3184)] public RankingKindParam rankingKindInfos__arr398;
        [FieldOffset(3192)] public RankingKindParam rankingKindInfos__arr399;
        [FieldOffset(3200)] public RankingKindParam rankingKindInfos__arr400;
        [FieldOffset(3208)] public RankingKindParam rankingKindInfos__arr401;
        [FieldOffset(3216)] public RankingKindParam rankingKindInfos__arr402;
        [FieldOffset(3224)] public RankingKindParam rankingKindInfos__arr403;
        [FieldOffset(3232)] public RankingKindParam rankingKindInfos__arr404;
        [FieldOffset(3240)] public RankingKindParam rankingKindInfos__arr405;
        [FieldOffset(3248)] public RankingKindParam rankingKindInfos__arr406;
        [FieldOffset(3256)] public RankingKindParam rankingKindInfos__arr407;
        [FieldOffset(3264)] public RankingKindParam rankingKindInfos__arr408;
        [FieldOffset(3272)] public RankingKindParam rankingKindInfos__arr409;
        [FieldOffset(3280)] public RankingKindParam rankingKindInfos__arr410;
        [FieldOffset(3288)] public RankingKindParam rankingKindInfos__arr411;
        [FieldOffset(3296)] public RankingKindParam rankingKindInfos__arr412;
        [FieldOffset(3304)] public RankingKindParam rankingKindInfos__arr413;
        [FieldOffset(3312)] public RankingKindParam rankingKindInfos__arr414;
        [FieldOffset(3320)] public RankingKindParam rankingKindInfos__arr415;
        [FieldOffset(3328)] public RankingKindParam rankingKindInfos__arr416;
        [FieldOffset(3336)] public RankingKindParam rankingKindInfos__arr417;
        [FieldOffset(3344)] public RankingKindParam rankingKindInfos__arr418;
        [FieldOffset(3352)] public RankingKindParam rankingKindInfos__arr419;
        [FieldOffset(3360)] public RankingKindParam rankingKindInfos__arr420;
        [FieldOffset(3368)] public RankingKindParam rankingKindInfos__arr421;
        [FieldOffset(3376)] public RankingKindParam rankingKindInfos__arr422;
        [FieldOffset(3384)] public RankingKindParam rankingKindInfos__arr423;
        [FieldOffset(3392)] public RankingKindParam rankingKindInfos__arr424;
        [FieldOffset(3400)] public RankingKindParam rankingKindInfos__arr425;
        [FieldOffset(3408)] public RankingKindParam rankingKindInfos__arr426;
        [FieldOffset(3416)] public RankingKindParam rankingKindInfos__arr427;
        [FieldOffset(3424)] public RankingKindParam rankingKindInfos__arr428;
        [FieldOffset(3432)] public RankingKindParam rankingKindInfos__arr429;
        [FieldOffset(3440)] public RankingKindParam rankingKindInfos__arr430;
        [FieldOffset(3448)] public RankingKindParam rankingKindInfos__arr431;
        [FieldOffset(3456)] public RankingKindParam rankingKindInfos__arr432;
        [FieldOffset(3464)] public RankingKindParam rankingKindInfos__arr433;
        [FieldOffset(3472)] public RankingKindParam rankingKindInfos__arr434;
        [FieldOffset(3480)] public RankingKindParam rankingKindInfos__arr435;
        [FieldOffset(3488)] public RankingKindParam rankingKindInfos__arr436;
        [FieldOffset(3496)] public RankingKindParam rankingKindInfos__arr437;
        [FieldOffset(3504)] public RankingKindParam rankingKindInfos__arr438;
        [FieldOffset(3512)] public RankingKindParam rankingKindInfos__arr439;
        [FieldOffset(3520)] public RankingKindParam rankingKindInfos__arr440;
    }

}