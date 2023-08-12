using System.Numerics;
using System.Runtime.InteropServices;

public class MissionInfoClass
{
    public enum TitleKind : sbyte
    {
        TITLEKIND_SONIC1 = 0,
        TITLEKIND_SONIC2 = 1,
        TITLEKIND_SONIC3K = 2,
        TITLEKIND_SONICCD = 3,
        TITLEKIND_NUM = 4,
        TITLEKIND_HITE = 4,
        TITLEKIND_NUM_ADDHITE = 5
    }

    public enum FinishType : int
    {
        NONE = 0,
        GOAL = 1,
        TIME_LIMIT = 2
    }

    public enum Type : int
    {
        NOP = 0,
        RING_COUNT = 1,
        OBJECT_COUNT = 2,
        DAMAGE_COUNT = 3,
        SCORE_COUNT = 4,
        ANIMAL_BOX_COUNT = 5,
        TIME_WARP_COUNT = 6,
        PAST_COUNT = 7,
        FUTURE_COUNT = 8
    }

    public enum OpCode : int
    {
        OpCode_NONE = 0,
        EQUAL = 1,
        GREATER_EQUAL = 2
    }

    public enum EnemyType : sbyte
    {
        ENEMYTYPE_NONE = -1,
        ENEMYTYPE_NAR = 0,
        ENEMYTYPE_MELEON = 1,
        ENEMYTYPE_MOTRA = 2,
        ENEMYTYPE_GANIGANI_AND_BASARAN = 3,
        ENEMYTYPE_STINGER = 4,
        ENEMYTYPE_ANIMALBOX = 5,
        ENEMYTYPE_OCTOR = 6,
        ENEMYTYPE_CYCLONE = 7,
        ENEMYTYPE_HALOGEN = 8,
        ENEMYTYPE_ANIMALCAPSULE = 9,
        ENEMYTYPE_CHULIPPON_AND_CYCLONE = 10,
        ENEMYTYPE_TEFTEF = 11,
        ENEMYTYPE_KECKO = 12,
        ENEMYTYPE_BALLOON = 13,
        ENEMYTYPE_TAGATAGA = 14,
        ENEMYTYPE_KAMAKAMA = 15,
        ENEMYTYPE_SWAP = 16,
        ENEMYTYPE_FUTURE = 17,
        ENEMYTYPE_PAST = 18,
        ENEMYTYPE_BEETON = 19,
        ENEMYTYPE_BASARAN_AND_NAR = 20,
        ENEMYTYPE_KEROPPO = 21,
        ENEMYTYPE_MEBE = 22,
        ENEMYTYPE_NUM = 23
    }

    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public struct MissionCondition
    {
        [FieldOffset(0)]  public Type m_type;
        [FieldOffset(4)]  public int m_value;
        [FieldOffset(8)]  public OpCode m_opCode;
        [FieldOffset(12)] public int m_objectEntityIndex;
        [FieldOffset(16)] public EnemyType m_hintEnemyType;
        [FieldOffset(17)] public bool m_isAlways;
    }

    public enum LevelType : sbyte
    {
        LEVELTYPE_NONE = 0,
        LEVELTYPE_1 = 1,
        LEVELTYPE_2 = 2,
        LEVELTYPE_3 = 3,
        LEVELTYPE_4 = 4,
        LEVELTYPE_5 = 5,
        LEVELTYPE_NUM = 6
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

    public enum PlayerType : sbyte
    {
        SONIC = 0,
        TAILS = 1,
        KNUCKLES = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 136)]
    public struct MissionData
    {
        [FieldOffset(0)]   public bool m_enableMission;
        [FieldOffset(1)]   public TitleKind m_title;
        [FieldOffset(4)]   public int m_stageListPos;
        [FieldOffset(8)]   public FinishType m_finishType;
        [FieldOffset(12)]  public int m_timeLimitSec;
        [FieldOffset(16)]  public MissionCondition m_conditions__arr0;
        [FieldOffset(36)] public MissionCondition m_conditions__arr1;
        [FieldOffset(56)] public MissionCondition m_conditions__arr2;
        [FieldOffset(76)]  public uint m_rankTimes__arr0;
        [FieldOffset(80)] public uint m_rankTimes__arr1;
        [FieldOffset(84)] public uint m_rankTimes__arr2;
        [FieldOffset(88)] public uint m_rankTimes__arr3;
        [FieldOffset(92)]  public int m_rankRings__arr0;
        [FieldOffset(96)] public int m_rankRings__arr1;
        [FieldOffset(100)] public int m_rankRings__arr2;
        [FieldOffset(104)] public int m_rankRings__arr3;
        [FieldOffset(108)] public LevelType m_levelType;
        [FieldOffset(109)] public StageKind m_dispStageKind;
        [FieldOffset(112)] public CString m_debugDescription;
        [FieldOffset(128)] public bool m_enableTails;
        [FieldOffset(129)] public bool m_isMirroring;
        [FieldOffset(130)] public PlayerType m_playerType;
        [FieldOffset(131)] public bool m_enableAttackChain;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct MissionReward
    {
        [FieldOffset(0)] public int m_coinCounts__arr0;
        [FieldOffset(4)] public int m_coinCounts__arr1;
        [FieldOffset(8)] public int m_coinCounts__arr2;
        [FieldOffset(12)] public int m_coinCounts__arr3;
    }

    [StructLayout(LayoutKind.Explicit, Size = 100)]
    public struct MissionRewardData
    {
        [FieldOffset(0)]  public MissionReward m_rewards__arr0;
        [FieldOffset(16)] public MissionReward m_rewards__arr1;
        [FieldOffset(32)] public MissionReward m_rewards__arr2;
        [FieldOffset(48)] public MissionReward m_rewards__arr3;
        [FieldOffset(64)] public MissionReward m_rewards__arr4;
        [FieldOffset(80)] public MissionReward m_rewards__arr5;
        [FieldOffset(96)] public int m_firstClearBonus;
    }

    [StructLayout(LayoutKind.Explicit, Size = 15336)]
    public struct MissionInfo
    {
        [FieldOffset(0)]     public MissionData m_missionData__arr0;
        [FieldOffset(136)] public MissionData m_missionData__arr1;
        [FieldOffset(272)] public MissionData m_missionData__arr2;
        [FieldOffset(408)] public MissionData m_missionData__arr3;
        [FieldOffset(544)] public MissionData m_missionData__arr4;
        [FieldOffset(680)] public MissionData m_missionData__arr5;
        [FieldOffset(816)] public MissionData m_missionData__arr6;
        [FieldOffset(952)] public MissionData m_missionData__arr7;
        [FieldOffset(1088)] public MissionData m_missionData__arr8;
        [FieldOffset(1224)] public MissionData m_missionData__arr9;
        [FieldOffset(1360)] public MissionData m_missionData__arr10;
        [FieldOffset(1496)] public MissionData m_missionData__arr11;
        [FieldOffset(1632)] public MissionData m_missionData__arr12;
        [FieldOffset(1768)] public MissionData m_missionData__arr13;
        [FieldOffset(1904)] public MissionData m_missionData__arr14;
        [FieldOffset(2040)] public MissionData m_missionData__arr15;
        [FieldOffset(2176)] public MissionData m_missionData__arr16;
        [FieldOffset(2312)] public MissionData m_missionData__arr17;
        [FieldOffset(2448)] public MissionData m_missionData__arr18;
        [FieldOffset(2584)] public MissionData m_missionData__arr19;
        [FieldOffset(2720)] public MissionData m_missionData__arr20;
        [FieldOffset(2856)] public MissionData m_missionData__arr21;
        [FieldOffset(2992)] public MissionData m_missionData__arr22;
        [FieldOffset(3128)] public MissionData m_missionData__arr23;
        [FieldOffset(3264)] public MissionData m_missionData__arr24;
        [FieldOffset(3400)] public MissionData m_missionData__arr25;
        [FieldOffset(3536)] public MissionData m_missionData__arr26;
        [FieldOffset(3672)] public MissionData m_missionData__arr27;
        [FieldOffset(3808)] public MissionData m_missionData__arr28;
        [FieldOffset(3944)] public MissionData m_missionData__arr29;
        [FieldOffset(4080)] public MissionData m_missionData__arr30;
        [FieldOffset(4216)] public MissionData m_missionData__arr31;
        [FieldOffset(4352)] public MissionData m_missionData__arr32;
        [FieldOffset(4488)] public MissionData m_missionData__arr33;
        [FieldOffset(4624)] public MissionData m_missionData__arr34;
        [FieldOffset(4760)] public MissionData m_missionData__arr35;
        [FieldOffset(4896)] public MissionData m_missionData__arr36;
        [FieldOffset(5032)] public MissionData m_missionData__arr37;
        [FieldOffset(5168)] public MissionData m_missionData__arr38;
        [FieldOffset(5304)] public MissionData m_missionData__arr39;
        [FieldOffset(5440)] public MissionData m_missionData__arr40;
        [FieldOffset(5576)] public MissionData m_missionData__arr41;
        [FieldOffset(5712)] public MissionData m_missionData__arr42;
        [FieldOffset(5848)] public MissionData m_missionData__arr43;
        [FieldOffset(5984)] public MissionData m_missionData__arr44;
        [FieldOffset(6120)] public MissionData m_missionData__arr45;
        [FieldOffset(6256)] public MissionData m_missionData__arr46;
        [FieldOffset(6392)] public MissionData m_missionData__arr47;
        [FieldOffset(6528)] public MissionData m_missionData__arr48;
        [FieldOffset(6664)] public MissionData m_missionData__arr49;
        [FieldOffset(6800)] public MissionData m_missionData__arr50;
        [FieldOffset(6936)] public MissionData m_missionData__arr51;
        [FieldOffset(7072)] public MissionData m_missionData__arr52;
        [FieldOffset(7208)] public MissionData m_missionData__arr53;
        [FieldOffset(7344)] public MissionData m_missionData__arr54;
        [FieldOffset(7480)] public MissionData m_missionData__arr55;
        [FieldOffset(7616)] public MissionData m_missionData__arr56;
        [FieldOffset(7752)] public MissionData m_missionData__arr57;
        [FieldOffset(7888)] public MissionData m_missionData__arr58;
        [FieldOffset(8024)] public MissionData m_missionData__arr59;
        [FieldOffset(8160)] public MissionData m_missionData__arr60;
        [FieldOffset(8296)] public MissionData m_missionData__arr61;
        [FieldOffset(8432)] public MissionData m_missionData__arr62;
        [FieldOffset(8568)] public MissionData m_missionData__arr63;
        [FieldOffset(8704)] public MissionData m_missionData__arr64;
        [FieldOffset(8840)] public MissionData m_missionData__arr65;
        [FieldOffset(8976)] public MissionData m_missionData__arr66;
        [FieldOffset(9112)] public MissionData m_missionData__arr67;
        [FieldOffset(9248)] public MissionData m_missionData__arr68;
        [FieldOffset(9384)] public MissionData m_missionData__arr69;
        [FieldOffset(9520)] public MissionData m_missionData__arr70;
        [FieldOffset(9656)] public MissionData m_missionData__arr71;
        [FieldOffset(9792)] public MissionData m_missionData__arr72;
        [FieldOffset(9928)] public MissionData m_missionData__arr73;
        [FieldOffset(10064)] public MissionData m_missionData__arr74;
        [FieldOffset(10200)] public MissionData m_missionData__arr75;
        [FieldOffset(10336)] public MissionData m_missionData__arr76;
        [FieldOffset(10472)] public MissionData m_missionData__arr77;
        [FieldOffset(10608)] public MissionData m_missionData__arr78;
        [FieldOffset(10744)] public MissionData m_missionData__arr79;
        [FieldOffset(10880)] public MissionData m_missionData__arr80;
        [FieldOffset(11016)] public MissionData m_missionData__arr81;
        [FieldOffset(11152)] public MissionData m_missionData__arr82;
        [FieldOffset(11288)] public MissionData m_missionData__arr83;
        [FieldOffset(11424)] public MissionData m_missionData__arr84;
        [FieldOffset(11560)] public MissionData m_missionData__arr85;
        [FieldOffset(11696)] public MissionData m_missionData__arr86;
        [FieldOffset(11832)] public MissionData m_missionData__arr87;
        [FieldOffset(11968)] public MissionData m_missionData__arr88;
        [FieldOffset(12104)] public MissionData m_missionData__arr89;
        [FieldOffset(12240)] public MissionData m_missionData__arr90;
        [FieldOffset(12376)] public MissionData m_missionData__arr91;
        [FieldOffset(12512)] public MissionData m_missionData__arr92;
        [FieldOffset(12648)] public MissionData m_missionData__arr93;
        [FieldOffset(12784)] public MissionData m_missionData__arr94;
        [FieldOffset(12920)] public MissionData m_missionData__arr95;
        [FieldOffset(13056)] public MissionData m_missionData__arr96;
        [FieldOffset(13192)] public MissionData m_missionData__arr97;
        [FieldOffset(13328)] public MissionData m_missionData__arr98;
        [FieldOffset(13464)] public MissionData m_missionData__arr99;
        [FieldOffset(13600)] public MissionData m_missionData__arr100;
        [FieldOffset(13736)] public MissionData m_missionData__arr101;
        [FieldOffset(13872)] public MissionData m_missionData__arr102;
        [FieldOffset(14008)] public MissionData m_missionData__arr103;
        [FieldOffset(14144)] public MissionData m_missionData__arr104;
        [FieldOffset(14280)] public MissionData m_missionData__arr105;
        [FieldOffset(14416)] public MissionData m_missionData__arr106;
        [FieldOffset(14552)] public MissionData m_missionData__arr107;
        [FieldOffset(14688)] public MissionData m_missionData__arr108;
        [FieldOffset(14824)] public MissionData m_missionData__arr109;
        [FieldOffset(14960)] public MissionData m_missionData__arr110;
        [FieldOffset(15096)] public MissionData m_missionData__arr111;
        [FieldOffset(15232)] public MissionRewardData m_missionRewardData;
    }

}