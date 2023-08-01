#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

enum SequenceType : uint8_t
{
    SequenceSensor = 0,
    ObjItem = 1
};

typedef struct
{
    float suckedTime;
    SequenceType sequenceType;
}
SequenceParameter;

