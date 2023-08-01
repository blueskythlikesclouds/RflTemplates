#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    float spawnIntervalMax;
    float spawnIntervalMin;
    float spawnHeightMax;
    float spawnHeightMin;
    float spawnHorizonMax;
    float spawnHorizonMin;
    float speedMax;
    float speedMin;
    float lengthMax;
    float lengthMin;
    float width;
    float angleMax;
    float angleMin;
    float moveTimeMax;
    float moveTimeMin;
    float fadeTimeMax;
    float fadeTimeMin;
    float spawnAngle;
    csl::math::Vector3 color;
}
MeteorShowerEffectParameter;

enum Symbol : int8_t
{
    Invalid = -1,
    Seven = 0,
    Bar = 1,
    Fruit = 2,
    Bell = 3,
    NumSymbols = 4
};

typedef struct
{
    Symbol symbols[16];
    float spinSpeedMin;
    float spinSpeedMax;
    float autoStopTimeMin;
    float autoStopTimeMax;
}
ReelParam;

enum RateInfo_Symbol : int8_t
{
    RateInfo_Symbol_Invalid = -1,
    RateInfo_Symbol_Seven = 0,
    RateInfo_Symbol_Bar = 1,
    RateInfo_Symbol_Fruit = 2,
    RateInfo_Symbol_Bell = 3,
    RateInfo_Symbol_NumSymbols = 4
};

typedef struct
{
    RateInfo_Symbol symbols[3];
    float rate;
}
RateInfo;

enum CeilingInfo_Symbol : int8_t
{
    CeilingInfo_Symbol_Invalid = -1,
    CeilingInfo_Symbol_Seven = 0,
    CeilingInfo_Symbol_Bar = 1,
    CeilingInfo_Symbol_Fruit = 2,
    CeilingInfo_Symbol_Bell = 3,
    CeilingInfo_Symbol_NumSymbols = 4
};

typedef struct
{
    CeilingInfo_Symbol symbols[3];
    uint32_t rollCount;
}
CeilingInfo;

enum PayoutInfo_Symbol : int8_t
{
    PayoutInfo_Symbol_Invalid = -1,
    PayoutInfo_Symbol_Seven = 0,
    PayoutInfo_Symbol_Bar = 1,
    PayoutInfo_Symbol_Fruit = 2,
    PayoutInfo_Symbol_Bell = 3,
    PayoutInfo_Symbol_NumSymbols = 4
};

typedef struct
{
    PayoutInfo_Symbol symbols[3];
    uint32_t payout;
}
PayoutInfo;

typedef struct
{
    ReelParam reelParams[3];
    float spinInterval;
    RateInfo rateInfos[4];
    CeilingInfo ceilingInfos[4];
    PayoutInfo payoutInfos[4];
    uint32_t payoutOnBlank;
    bool WinEvenWithPush;
    float retrySpeed;
    float backSpeed;
    float stepSpeed;
}
ObjBonusSlotConfig;

typedef struct
{
    float rangeFromSonicObjectsDontRespawn;
    uint32_t intervalDay;
    uint32_t startHour;
    uint32_t startMinute;
    uint32_t durationHour;
    uint32_t durationMinute;
    MeteorShowerEffectParameter effect;
    ObjBonusSlotConfig bonusSlotConfig;
}
MeteorShowerParameter;

