#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    float baseWaveThickness;
    float baseWaveSuccessRatioNormal;
    float baseWaveSuccessRatioHold;
    float singleWaveThickness;
    float baseWaveEdgeThickness;
    float timingEdgeThickness;
    uint32_t fishShadowNum;
    float fishApproachIntervalMin;
    float fishApproachIntervalMax;
    float fishEscapeDistance;
    uint32_t buoyTwitchNumMin;
    uint32_t buoyTwitchNumMax;
    float buoyTwitchIntervalMin;
    float buoyTwitchIntervalMax;
    float inputValidTime;
    float fishingCameraTransitDelay;
    float cutinDelay;
    float cutinDuration;
    float successPullUpDelay;
    uint32_t goldenChestLimitNum;
}
FishingCommonParam;

typedef struct
{
    uint32_t successNum;
    uint32_t failureNum;
}
FishingSuccessPatternParam;

enum Type : int8_t
{
    TYPE_INVALID = 0,
    TYPE_NORMAL = 1,
    TYPE_HOLD = 2
};

typedef struct
{
    Type type;
    float radius;
    float thickness;
}
FishingWaveParam;

typedef struct
{
    FishingWaveParam waves[5];
}
FishingWaveGroupParam;

typedef struct
{
    float speed;
    float intervalMinFirst;
    float intervalMaxFirst;
    float intervalMin;
    float intervalMax;
    float addRadiusMin;
    float addRadiusMax;
    uint32_t waveGroupNum;
    FishingWaveGroupParam waveGroups[10];
}
FishingWavePatternParam;

typedef struct
{
    float rate;
}
FishingFishGroupParam;

enum FishShadowType : int8_t
{
    SMALL = 0,
    MEDIUM = 1,
    LARGE = 2
};

enum CatchUpMotionType : int8_t
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
};

enum ToastType : int8_t
{
    MOTION = 0,
    PATTERN_1 = 1,
    PATTERN_2 = 2,
    PATTERN_3 = 3,
    PATTERN_4 = 4
};

typedef struct
{
    int32_t fishGroupId;
    FishShadowType shadowType;
    uint32_t successPatternId;
    uint32_t wavePatternId;
    uint32_t expPoint;
    uint32_t tokenNum;
    bool isRare;
    CatchUpMotionType catchUpMotionType;
    ToastType toastType;
    csl::math::Vector3 catchUpOffsetPos;
    csl::math::Vector3 catchUpOffsetRot;
}
FishingFishParam;

typedef struct
{
    int32_t spawnFishId[20];
}
FishingSpotSpawnFishParam;

typedef struct
{
    int32_t count;
    int32_t fishId;
}
FishingFixedResultParam;

typedef struct
{
    uint32_t tableSize;
    uint32_t achievementUnlockCount;
    FishingFixedResultParam fixedResultList[50];
}
FishingSpotFixedResultParam;

typedef struct
{
    FishingSpotSpawnFishParam spawnFish[4];
    FishingSpotFixedResultParam fixedResults[4];
    uint32_t useFishCoinNum[4];
    uint32_t tokenRate[4];
}
FishingSpotParam;

typedef struct
{
    uint32_t singleWaveSuccessCount;
    uint32_t holdWaveSuccessCount;
    FishingWavePatternParam singleWave;
    FishingWavePatternParam holdWave;
}
FishingTutorialParam;

typedef struct
{
    uint8_t sales[9];
}
FishingTradeTableParma;

typedef struct
{
    FishingTradeTableParma spot[4];
    uint8_t prices[9];
    uint8_t pricesVeryHard[9];
    uint8_t counts[9];
}
FishingTradeParam;

typedef struct
{
    FishingCommonParam common;
    FishingSuccessPatternParam successPattern[10];
    FishingWavePatternParam wavePattern[10];
    FishingFishGroupParam fishGroup[10];
    FishingFishParam fish[130];
    FishingSpotParam spot;
    FishingTutorialParam tutorial;
    FishingTradeParam trade;
}
FishingParameter;

