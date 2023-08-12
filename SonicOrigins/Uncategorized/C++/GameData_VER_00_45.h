#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

enum Status : int8_t
{
    STATUS_ZERO_FILL = 0,
    STATUS_INITIALIZED = 1
};

typedef struct
{
    uint32_t signature;
    uint8_t version;
    uint8_t minorVersion;
    Status status;
    uint8_t config;
    uint32_t playTime;
    uint32_t playCount;
    uint32_t saveDate;
    uint8_t index;
    uint8_t flags;
    uint8_t padding1[2];
    uint32_t crc;
    uint8_t padding2[32];
}
HeaderData;

typedef struct
{
    uint32_t gameDataCompressSize;
}
HeaderSubData;

enum GameModeData_VER_00_45_Status : int8_t
{
    STATUS_NONE = 0
};

enum MainMenuMode : int8_t
{
    MAINMENU_MODE_SONIC1 = 0,
    MAINMENU_MODE_SONICCD = 1,
    MAINMENU_MODE_SONIC2 = 2,
    MAINMENU_MODE_SONIC3K = 3,
    MAINMENU_MODE_MISSION = 4,
    MAINMENU_MODE_DATA = 5,
    MAINMENU_MODE_NUM = 6
};

enum BootPlayMode : int8_t
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
};

enum BootPlayer : int8_t
{
    BOOT_PLAYER_SONIC = 0,
    BOOT_PLAYER_TAILS = 1,
    BOOT_PLAYER_KNUCKLES = 2,
    BOOT_PLAYER_SONIC_TAILS = 3,
    BOOT_PLAYER_KNUCKLES_TAILS = 4,
    BOOT_PLAYER_AMY = 5,
    BOOT_PLAYER_AMY_TAILS = 6,
    BOOT_PLAYER_NUM = 7,
    BOOT_PLAYER_NONE = -1
};

enum TerrainLevel : int32_t
{
    LEVEL0 = 0,
    LEVEL1 = 1,
    LEVEL2 = 2,
    LEVEL3 = 3,
    NUM_LEVEL_TYPES = 4
};

typedef struct
{
    TerrainLevel terrainLevel;
    bool userManual;
    int8_t dym[3];
}
TerrainLevelData;

enum GamePlayData_Status : int8_t
{
    STATUS_NEWGAME = 0,
    STATUS_CONTINUE = 1
};

enum GamePlayData_BootPlayer : int8_t
{
    GamePlayData_BootPlayer_BOOT_PLAYER_SONIC = 0,
    GamePlayData_BootPlayer_BOOT_PLAYER_TAILS = 1,
    GamePlayData_BootPlayer_BOOT_PLAYER_KNUCKLES = 2,
    GamePlayData_BootPlayer_BOOT_PLAYER_SONIC_TAILS = 3,
    GamePlayData_BootPlayer_BOOT_PLAYER_KNUCKLES_TAILS = 4,
    GamePlayData_BootPlayer_BOOT_PLAYER_AMY = 5,
    GamePlayData_BootPlayer_BOOT_PLAYER_AMY_TAILS = 6,
    GamePlayData_BootPlayer_BOOT_PLAYER_NUM = 7,
    GamePlayData_BootPlayer_BOOT_PLAYER_NONE = -1
};

typedef struct
{
    uint32_t allEmeraldFlags;
    int32_t currentSlotNo;
}
Sonic3KSlotPlayData;

typedef struct
{
    GamePlayData_Status status;
    uint8_t lastPlayedStageNo;
    uint8_t lastPlayedBossRushStageIndex;
    GamePlayData_BootPlayer player;
    uint32_t flags;
    Sonic3KSlotPlayData sonic3KSlotPlayData;
}
GamePlayData;

enum LegacyModeData_Status : int8_t
{
    STATUS_SAVED = 0
};

typedef struct
{
    LegacyModeData_Status status;
    uint8_t legacySaveData[65536];
}
LegacyModeData;

typedef struct
{
    GameModeData_VER_00_45_Status status;
    MainMenuMode lastMainMenuMode;
    BootPlayMode lastPlayedMode[4];
    BootPlayer lastPlayerClassic[4];
    BootPlayer lastPlayerAnniversary[4];
    BootPlayer lastPlayerMirroring[4];
    BootPlayer lastPlayerBossRush[4];
    uint8_t storyProgress;
    TerrainLevelData terrainLevelData[7];
    uint32_t spinDashType;
    uint8_t reserved[4];
    uint32_t flags;
    GamePlayData gamePlayData[74];
    LegacyModeData legacyModeData[55];
    bool clearStoryStage[125];
}
GameModeData_VER_00_45;

typedef struct
{
    uint32_t coin;
}
CollectionData;

typedef struct
{
    int8_t data[160];
}
CheckPointSave;

typedef struct
{
    CheckPointSave checkPointSave[71];
}
CheckPointSaveData_VER_00_45;

typedef struct
{
    int8_t data[32768];
}
AnywareSave;

typedef struct
{
    AnywareSave anywareSave[71];
}
AnywareSaveData_VER_00_45;

typedef struct
{
    int32_t value;
    bool assigned;
}
StatValue;

typedef struct
{
    StatValue stats[64];
    StatValue barrierStats[3];
}
StatsContainerData;

enum RankType : int8_t
{
    RANKTYPE_S = 0,
    RANKTYPE_A = 1,
    RANKTYPE_B = 2,
    RANKTYPE_C = 3,
    RANKTYPE_NUM = 4,
    RANKTYPE_INVALID = 4
};

typedef struct
{
    uint32_t playCount;
    uint32_t clearCount;
    uint32_t clearCountSRank;
    RankType clearRank;
    bool unlocked;
    uint16_t dmy;
}
MissionStageSaveData;

enum MissionKind : int8_t
{
    MISSIONKIND_NONE = 0,
    MISSIONKIND_SONIC1_START = 1,
    MISSIONKIND_SONIC1_1 = 1,
    MISSIONKIND_SONIC1_2 = 2,
    MISSIONKIND_SONIC1_3 = 3,
    MISSIONKIND_SONIC1_4 = 4,
    MISSIONKIND_SONIC1_5 = 5,
    MISSIONKIND_SONIC1_6 = 6,
    MISSIONKIND_SONIC1_7 = 7,
    MISSIONKIND_SONIC1_8 = 8,
    MISSIONKIND_SONIC1_9 = 9,
    MISSIONKIND_SONIC1_10 = 10,
    MISSIONKIND_SONIC1_11 = 11,
    MISSIONKIND_SONIC1_12 = 12,
    MISSIONKIND_SONIC1_13 = 13,
    MISSIONKIND_SONIC1_14 = 14,
    MISSIONKIND_SONIC1_15 = 15,
    MISSIONKIND_SONIC1_16 = 16,
    MISSIONKIND_SONIC1_17 = 17,
    MISSIONKIND_SONIC1_18 = 18,
    MISSIONKIND_SONIC1_19 = 19,
    MISSIONKIND_SONIC1_20 = 20,
    MISSIONKIND_SONIC1_21 = 21,
    MISSIONKIND_SONIC1_22 = 22,
    MISSIONKIND_SONIC1_23 = 23,
    MISSIONKIND_SONIC1_24 = 24,
    MISSIONKIND_SONIC1_25 = 25,
    MISSIONKIND_SONIC1_END = 26,
    MISSIONKIND_SONIC2_START = 26,
    MISSIONKIND_SONIC2_1 = 26,
    MISSIONKIND_SONIC2_2 = 27,
    MISSIONKIND_SONIC2_3 = 28,
    MISSIONKIND_SONIC2_4 = 29,
    MISSIONKIND_SONIC2_5 = 30,
    MISSIONKIND_SONIC2_6 = 31,
    MISSIONKIND_SONIC2_7 = 32,
    MISSIONKIND_SONIC2_8 = 33,
    MISSIONKIND_SONIC2_9 = 34,
    MISSIONKIND_SONIC2_10 = 35,
    MISSIONKIND_SONIC2_11 = 36,
    MISSIONKIND_SONIC2_12 = 37,
    MISSIONKIND_SONIC2_13 = 38,
    MISSIONKIND_SONIC2_14 = 39,
    MISSIONKIND_SONIC2_15 = 40,
    MISSIONKIND_SONIC2_16 = 41,
    MISSIONKIND_SONIC2_17 = 42,
    MISSIONKIND_SONIC2_18 = 43,
    MISSIONKIND_SONIC2_19 = 44,
    MISSIONKIND_SONIC2_20 = 45,
    MISSIONKIND_SONIC2_21 = 46,
    MISSIONKIND_SONIC2_22 = 47,
    MISSIONKIND_SONIC2_23 = 48,
    MISSIONKIND_SONIC2_24 = 49,
    MISSIONKIND_SONIC2_25 = 50,
    MISSIONKIND_SONIC2_END = 51,
    MISSIONKIND_SONIC3K_START = 51,
    MISSIONKIND_SONIC3K_1 = 51,
    MISSIONKIND_SONIC3K_2 = 52,
    MISSIONKIND_SONIC3K_3 = 53,
    MISSIONKIND_SONIC3K_4 = 54,
    MISSIONKIND_SONIC3K_5 = 55,
    MISSIONKIND_SONIC3K_6 = 56,
    MISSIONKIND_SONIC3K_7 = 57,
    MISSIONKIND_SONIC3K_8 = 58,
    MISSIONKIND_SONIC3K_9 = 59,
    MISSIONKIND_SONIC3K_10 = 60,
    MISSIONKIND_SONIC3K_11 = 61,
    MISSIONKIND_SONIC3K_12 = 62,
    MISSIONKIND_SONIC3K_13 = 63,
    MISSIONKIND_SONIC3K_14 = 64,
    MISSIONKIND_SONIC3K_15 = 65,
    MISSIONKIND_SONIC3K_16 = 66,
    MISSIONKIND_SONIC3K_17 = 67,
    MISSIONKIND_SONIC3K_18 = 68,
    MISSIONKIND_SONIC3K_19 = 69,
    MISSIONKIND_SONIC3K_20 = 70,
    MISSIONKIND_SONIC3K_21 = 71,
    MISSIONKIND_SONIC3K_22 = 72,
    MISSIONKIND_SONIC3K_23 = 73,
    MISSIONKIND_SONIC3K_24 = 74,
    MISSIONKIND_SONIC3K_25 = 75,
    MISSIONKIND_SONIC3K_END = 76,
    MISSIONKIND_SONICCD_START = 76,
    MISSIONKIND_SONICCD_1 = 76,
    MISSIONKIND_SONICCD_2 = 77,
    MISSIONKIND_SONICCD_3 = 78,
    MISSIONKIND_SONICCD_4 = 79,
    MISSIONKIND_SONICCD_5 = 80,
    MISSIONKIND_SONICCD_6 = 81,
    MISSIONKIND_SONICCD_7 = 82,
    MISSIONKIND_SONICCD_8 = 83,
    MISSIONKIND_SONICCD_9 = 84,
    MISSIONKIND_SONICCD_10 = 85,
    MISSIONKIND_SONICCD_11 = 86,
    MISSIONKIND_SONICCD_12 = 87,
    MISSIONKIND_SONICCD_13 = 88,
    MISSIONKIND_SONICCD_14 = 89,
    MISSIONKIND_SONICCD_15 = 90,
    MISSIONKIND_SONICCD_16 = 91,
    MISSIONKIND_SONICCD_17 = 92,
    MISSIONKIND_SONICCD_18 = 93,
    MISSIONKIND_SONICCD_19 = 94,
    MISSIONKIND_SONICCD_20 = 95,
    MISSIONKIND_SONICCD_21 = 96,
    MISSIONKIND_SONICCD_22 = 97,
    MISSIONKIND_SONICCD_23 = 98,
    MISSIONKIND_SONICCD_24 = 99,
    MISSIONKIND_SONICCD_25 = 100,
    MISSIONKIND_SONICCD_END = 101,
    MISSIONKIND_DLC_START = 101,
    MISSIONKIND_DLC_1 = 101,
    MISSIONKIND_DLC_2 = 102,
    MISSIONKIND_DLC_3 = 103,
    MISSIONKIND_DLC_4 = 104,
    MISSIONKIND_DLC_5 = 105,
    MISSIONKIND_DLC_6 = 106,
    MISSIONKIND_DLC_7 = 107,
    MISSIONKIND_DLC_8 = 108,
    MISSIONKIND_DLC_9 = 109,
    MISSIONKIND_DLC_10 = 110,
    MISSIONKIND_DLC_11 = 111,
    MISSIONKIND_DLC_END = 112,
    MISSIONKIND_NUM = 112,
    MISSIONKIND_SONIC1_NUM = 25,
    MISSIONKIND_SONIC2_NUM = 25,
    MISSIONKIND_SONIC3K_NUM = 25,
    MISSIONKIND_SONICCD_NUM = 25,
    MISSIONKIND_DLC_NUM = 11,
    MISSIONKIND_ALL_START = 1,
    MISSIONKIND_ALL_END = 112
};

typedef struct
{
    MissionStageSaveData missionStages[112];
    MissionKind lastPlayedMissionKind;
    uint8_t dmy[3];
}
MissionSaveData;

typedef struct
{
    int32_t clearTime;
    uint8_t charaKind;
    bool cleared;
    bool displayed;
    bool uploaded;
}
ClearData;

typedef struct
{
    ClearData clearData[441];
    int32_t bossRushSonicWork[4];
    int32_t bossRushTailsWork[4];
    int32_t bossRushKnucklesWork[4];
    int32_t bossRushAmyWork[4];
}
StageClearData_VER_00_45;

typedef struct
{
    bool unlocked;
    bool unlockedInfo;
    bool displayed;
    uint8_t dmy;
}
UnlockData;

typedef struct
{
    uint16_t musicKind;
    uint8_t reserved[2];
}
PlayListItem;

typedef struct
{
    PlayListItem items[300];
}
PlayListInfo;

typedef struct
{
    uint8_t artProgress;
    uint8_t movieProgress;
    uint8_t musicProgress;
    uint8_t museumChara;
    uint8_t movieSoundRegion;
    uint8_t reserved[3];
    UnlockData artParam[260];
    UnlockData movieParam[60];
    UnlockData musicParam[420];
    PlayListInfo musicPlayList[5];
}
MuseumData;

typedef struct
{
    bool displayed;
    uint8_t reserved[3];
}
TutorialParam_VER_00_45;

typedef struct
{
    TutorialParam_VER_00_45 params[64];
}
TutorialData_VER_00_45;

typedef struct
{
    uint32_t holdValue[130];
}
HoldValues_VER_00_45;

typedef struct
{
    bool isSended[130];
    uint8_t reserved[3];
}
SendFlags_VER_00_45;

typedef struct
{
    HoldValues_VER_00_45 holdValues[54];
    SendFlags_VER_00_45 sendFlags[54];
}
PlayReportData_VER_00_45;

typedef struct
{
    uint32_t flags;
    int32_t bonusCoinCount;
    uint8_t reserved[252];
}
ContentData;

typedef struct
{
    uint64_t sonic1;
    uint64_t sonic2;
    uint64_t sonicTails;
    uint64_t sonicDrift;
    uint64_t sonicSpin;
    uint64_t sonicTails2;
    uint64_t sonicDrift2;
    uint64_t skyPatrol;
    uint64_t tailsAdv;
    uint64_t sonicLabyrinth;
    uint64_t gSonic;
    uint64_t eggMan;
    uint64_t sonicTails_US;
    uint64_t sonicTails2_US;
    uint64_t tailsAdv_US;
    uint64_t gSonic_US;
    uint64_t sonicDriftSRAM;
}
GameGearBackupData;

typedef struct
{
    uint32_t playRomType;
    GameGearBackupData backupData;
}
GameGearData;

typedef struct
{
    uint16_t playreportIndex;
    uint16_t playreportSubIndex;
    int32_t value;
}
PlayReportQueueObject;

typedef struct
{
    int16_t queuePointer;
    int16_t queueStackPointer;
    PlayReportQueueObject queue[256];
}
PlayReportQueueData;

typedef struct
{
    uint16_t pieceOpenFlags;
    uint16_t pieceShowFlags;
    bool completed;
    uint8_t padding[3];
}
PuzzleData;

typedef struct
{
    HeaderData header;
    HeaderSubData headerSub;
    GameModeData_VER_00_45 gameModeData;
    CollectionData collection;
    CheckPointSaveData_VER_00_45 checkPointSaveData;
    AnywareSaveData_VER_00_45 anywareSaveData;
    StatsContainerData stats;
    MissionSaveData mission;
    StageClearData_VER_00_45 stageClear;
    MuseumData museumData;
    TutorialData_VER_00_45 tutorialData;
    PlayReportData_VER_00_45 playreportData;
    ContentData contentData;
    GameGearData gamegearData;
    PlayReportQueueData playreportQueueData;
    PuzzleData puzzleData;
}
GameData_VER_00_45;

