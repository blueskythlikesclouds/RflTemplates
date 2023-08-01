#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    csl::math::Vector3 aabbMin;
    csl::math::Vector3 aabbMax;
}
World;

typedef struct
{
    float voxelSize;
    float voxelHeight;
}
Rasterization;

typedef struct
{
    float radius;
    float height;
    float maxClimb;
    float maxSlope;
}
Agent;

typedef struct
{
    int32_t minArea;
    int32_t mergeArea;
}
Region;

enum Partition : uint8_t
{
    Watershed = 0,
    Monotone = 1,
    Layers = 2
};

typedef struct
{
    Partition type;
}
Partitioning;

typedef struct
{
    bool lowHangingObstacles;
    bool ledgeSpans;
    bool walkableLowHeightSpans;
}
Filtering;

typedef struct
{
    float edgeMaxLength;
    float maxSimplificationError;
    int32_t vertsPerPoly;
}
Polygonization;

typedef struct
{
    float sampleDistance;
    float sampleMaxError;
}
DetailMesh;

typedef struct
{
    float size;
    int32_t maxTiles;
    bool cache;
}
Tiling;

typedef struct
{
    World world;
    Rasterization rasterization;
    Agent agent;
    Region region;
    Partitioning partitioning;
    Filtering filtering;
    Polygonization polygonization;
    DetailMesh detailMesh;
    Tiling tiling;
}
NavMeshParameter;

