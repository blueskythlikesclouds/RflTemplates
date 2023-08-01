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
    HeaderData header;
    bool unlocked;
    CyberStageContainerData stages;
    uint32_t reserved[4];
}
ArcadeData;

