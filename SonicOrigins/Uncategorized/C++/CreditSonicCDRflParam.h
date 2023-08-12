#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    const char* pValue;
    INSERT_PADDING(8);
}
cstring;

typedef struct
{
    float timeInMovie;
    float timeInStaffRoll;
    float timeOutStaffRoll;
    float timeInResult;
    float timeOutResult;
    float timeInLogo;
    float timeOutLogo;
    float timeOut;
}
CreditSonicCDTime;

enum SonicCDTextDecoType : int8_t
{
    position = 0,
    name = 1,
    sub = 2,
    category = 3,
    empty = 4,
    num = 5,
    min = 0,
    max = 4
};

typedef struct
{
    cstring string;
    SonicCDTextDecoType decoType;
}
CreditSonicCDStringDataRflParam;

typedef struct
{
    float position;
    float name;
    float sub;
    float category;
    float empty;
}
SonicCDTextDecoTypeSize;

typedef struct
{
    float soundVolume;
    cstring movieNameGoodEnd;
    cstring movieNameBadEnd;
    uint8_t movieGoodEndSoundCount;
    uint8_t movieBadEndSoundCount;
    CreditSonicCDTime creditTime;
    CreditSonicCDStringDataRflParam stringData[2048];
    SonicCDTextDecoTypeSize textDecoTypeSize;
    bool isCanSkip;
}
CreditSonicCDRflParam;

