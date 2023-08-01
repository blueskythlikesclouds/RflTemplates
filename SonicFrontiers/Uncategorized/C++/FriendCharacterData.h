#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    uint16_t numRings;
    uint8_t ringLevel;
    uint8_t speedLevel;
    uint32_t skill;
    uint32_t expPoint;
    uint16_t skillPoint;
    uint8_t boostGaugeLevel;
    uint8_t padding;
    uint32_t reserved0;
    uint32_t reserved1;
    uint32_t reserved2;
    uint32_t reserved3;
}
FriendCharacterData;

