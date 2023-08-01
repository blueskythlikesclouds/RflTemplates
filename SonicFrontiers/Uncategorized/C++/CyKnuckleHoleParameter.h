#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

enum EasingType : uint8_t
{
    LINEAR_EASEIN = 0,
    LINEAR_EASEOUT = 1,
    LINEAR_EASEINOUT = 2,
    QUADRATIC_EASEIN = 3,
    QUADRATIC_EASEOUT = 4,
    QUADRATIC_EASEINOUT = 5,
    CUBIC_EASEIN = 6,
    CUBIC_EASEOUT = 7,
    CUBIC_EASEINOUT = 8,
    QUARTIC_EASEIN = 9,
    QUARTIC_EASEOUT = 10,
    QUARTIC_EASEINOUT = 11,
    QUINTIC_EASEIN = 12,
    QUINTIC_EASEOUT = 13,
    QUINTIC_EASEINOUT = 14,
    SINE_EASEIN = 15,
    SINE_EASEOUT = 16,
    SINE_EASEINOUT = 17,
    EXPONENTAL_EASEIN = 18,
    EXPONENTAL_EASEOUT = 19,
    EXPONENTAL_EASEINOUT = 20,
    CIRCULAR_EASEIN = 21,
    CIRCULAR_EASEOUT = 22,
    CIRCULAR_EASEINOUT = 23,
    BACK_EASEIN = 24,
    BACK_EASEOUT = 25,
    BACK_EASEINOUT = 26,
    BOUNCE_EASEIN = 27,
    BOUNCE_EASEOUT = 28,
    BOUNCE_EASEINOUT = 29,
    ELASITC_EASEIN = 30,
    ELASITC_EASEOUT = 31,
    ELASITC_EASEINOUT = 32,
    NUM_EASINGTYPES = 33
};

typedef struct
{
    float easeTime;
    EasingType easing;
}
CyKnuckleHoleTransitionParameter;

typedef struct
{
    float radiusOpenSmall;
    float radiusOpen;
    CyKnuckleHoleTransitionParameter closeToOpenSmall;
    CyKnuckleHoleTransitionParameter closeToOpen;
    CyKnuckleHoleTransitionParameter openSmallToClose;
    CyKnuckleHoleTransitionParameter openSmallToOpen;
    CyKnuckleHoleTransitionParameter openToClose;
    CyKnuckleHoleTransitionParameter openToOpenSmall;
}
CyKnuckleHoleParameter;

