#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

enum ContactDamageType : int8_t
{
    CONTACT_DAMAGE_NONE = 0,
    CONTACT_DAMAGE_LOW_SPEED = 1,
    CONTACT_DAMAGE_MIDDLE_SPEED = 2,
    CONTACT_DAMAGE_HIGH_SPEED = 3
};

typedef struct
{
    ContactDamageType contactDamageType;
    bool noneDamageSpin;
    bool rideOnDamage;
    bool aerialBounce;
}
GismoConfigPlanData;

