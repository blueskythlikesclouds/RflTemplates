#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

enum Status : int8_t
{
    STATUS_ZERO_FILL = 0,
    STATUS_INITIALIZED = 1
};

enum Sequence : int8_t
{
    Island1 = 0,
    Island2 = 1,
    Island3 = 2,
    Island4 = 3,
    Island5 = 4,
    FinalBossBefore = 5,
    FinalBossAfter = 6
};

enum SaveDataIcon : int8_t
{
    IconNoData = 0,
    IconIsland1 = 1,
    IconIsland2 = 2,
    IconIsland3 = 3,
    IconIsland4 = 4,
    IconIsland5 = 5,
    IconLastBoss = 6
};

enum AppVersion : uint8_t
{
    AppVersion_1_10 = 0,
    AppVersion_1_20 = 1,
    AppVersion_1_30 = 2,
    AppVersion_1_40 = 3
};

typedef struct
{
    uint32_t signature;
    uint8_t version;
    Status status;
    uint8_t config;
    Sequence sequence;
    uint32_t playTime;
    SaveDataIcon icon;
    AppVersion appVersion;
    uint8_t config2;
    uint8_t reserved1;
    uint32_t saveDate;
    uint8_t index;
    uint32_t reserved[4];
}
HeaderData;

enum GamePlayData_Status : int8_t
{
    STATUS_NEWGAME = 0,
    STATUS_CONTINUE = 1
};

enum SequenceDeprecated : int8_t
{
    SequenceDeprecated_Island1 = 0,
    SequenceDeprecated_Island2 = 1,
    SequenceDeprecated_Island3 = 2,
    SequenceDeprecated_Island4 = 3,
    SequenceDeprecated_Island5 = 4,
    SequenceDeprecated_FinalBossBefore = 5,
    SequenceDeprecated_FinalBossAfter = 6
};

typedef struct
{
    GamePlayData_Status status;
    int8_t lastPlayedStageNo;
    uint8_t flags;
    SequenceDeprecated sequence;
    csl::math::Vector3 position;
    csl::math::Quaternion rotation;
    uint32_t day;
    uint32_t hour;
    uint32_t minute;
    float second;
    uint32_t reserved[4];
}
GamePlayData;

typedef struct
{
    uint16_t numRings;
    uint8_t ringLevel;
    uint8_t speedLevel;
    uint8_t obtainChaosEmeralds;
    uint8_t hasChaosEmeralds;
    uint8_t skillLevel[30];
    uint8_t skillPointOld;
    uint8_t levelOld;
    uint16_t padding0;
    uint32_t expPoint;
    uint8_t powerLevel;
    uint8_t guardLevel;
    uint16_t boostGaugeLevel;
    uint32_t numPowerSeeds;
    uint32_t numGuardSeeds;
    uint16_t numFishCoins;
    uint16_t numFishTokens;
    uint16_t numGoldCards;
    uint16_t numSlotStars;
    float quickCyloopGauge;
    uint32_t practiceMaxCleared;
    uint32_t practiceMaxCombos;
    uint32_t flags;
    int16_t skillPoint;
    int16_t level;
    uint32_t dlcrsvExpPoint;
    uint32_t dlcrsvNumPowerSeeds;
    uint32_t dlcrsvNumGuardSeeds;
}
CharacterData;

typedef struct
{
    uint8_t x;
    uint8_t y;
}
IslandMapGridData;

typedef struct
{
    IslandMapGridData grid[136];
    uint16_t numReleaseGrids;
}
IslandMapData;

typedef struct
{
    csl::math::Vector3 destination;
    uint32_t flags;
    IslandMapData map;
    uint32_t reserved[4];
}
IslandStageData;

typedef struct
{
    IslandStageData islands[5];
}
IslandStageContainerData;

typedef struct
{
    uint16_t flags;
    uint32_t bestTime;
    uint32_t reserved[4];
}
CyberStageData;

typedef struct
{
    CyberStageData actStages[32];
}
CyberStageContainerData;

typedef struct
{
    uint32_t bitFlags[24];
    int8_t byteFlags[128];
    uint32_t intDatas[16];
}
FlagContainerData;

typedef struct
{
    uint32_t bitFlags[1024];
    int8_t byteFlags[1024];
    uint32_t intDatas[512];
}
WorldFlagData;

typedef struct
{
    WorldFlagData worldDatas[5];
    WorldFlagData debugWorldData;
}
WorldFlagContainerData;

typedef struct
{
    uint16_t time;
    uint16_t x;
    uint16_t z;
}
PlayLogCoordData;

enum EventType : int8_t
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
};

typedef struct
{
    PlayLogCoordData coord;
    EventType eventType;
    int8_t option;
}
PlayLogEventData;

typedef struct
{
    uint32_t numFootMarks;
    uint32_t footMarksIndex;
    PlayLogCoordData footmarks[36000];
    uint32_t numEvents;
    uint32_t eventsIndex;
    PlayLogEventData events[50000];
}
PlayLogData;

typedef struct
{
    int32_t value;
    bool assigned;
}
StatValue;

typedef struct
{
    StatValue stats[3393];
}
StatsContainerData;

enum Type : int8_t
{
    Sunny = 0,
    Cloudy = 1,
    Rainy = 2,
    SandStorm = 3,
    MeteorShower = 4,
    Num = 5
};

typedef struct
{
    float duration;
    float time;
}
WeatherTimerData;

enum WeatherBlockData_Type : int8_t
{
    WeatherBlockData_Type_Sunny = 0,
    WeatherBlockData_Type_Cloudy = 1,
    WeatherBlockData_Type_Rainy = 2,
    WeatherBlockData_Type_SandStorm = 3,
    WeatherBlockData_Type_MeteorShower = 4,
    WeatherBlockData_Type_Num = 5
};

enum WeatherBlockData_Status : int8_t
{
    None = 0,
    Wait = 1,
    Active = 2,
    External = 3
};

typedef struct
{
    WeatherBlockData_Type weather;
    uint32_t hour;
    uint32_t minute;
    float second;
    WeatherBlockData_Status status;
}
WeatherBlockData;

typedef struct
{
    Type currentWeather;
    Type prevWeather;
    WeatherTimerData timer;
    WeatherBlockData block;
    int32_t stageNo;
    uint32_t reserved[4];
}
WeatherData;

typedef struct
{
    HeaderData header;
    GamePlayData gameplay;
    CharacterData character;
    IslandStageContainerData islands;
    CyberStageContainerData stages;
    FlagContainerData flags;
    WorldFlagContainerData worldFlags;
    PlayLogData playlog;
    StatsContainerData stats;
    WeatherData weather;
}
GameDataInPlayLog;

