#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

enum OffMeshLinkDirection : uint8_t
{
    OffMeshLinkUnidirectional = 0,
    OffMeshLinkBidirectional = 1
};

typedef struct
{
    csl::math::Vector3 source;
    csl::math::Vector3 destination;
    float radius;
    uint16_t flags;
    uint8_t area;
    OffMeshLinkDirection direction;
    uint32_t userID;
}
OffMeshLinkElement;

typedef struct
{
    OffMeshLinkElement elements;
}
OffMeshLinkParameter;

