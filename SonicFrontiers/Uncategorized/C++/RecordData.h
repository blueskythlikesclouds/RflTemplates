#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    const char* pValue;
    INSERT_PADDING(8);
}
cstring;

enum EventType : int8_t
{
    KEY = 0,
    INTERVAL = 1
};

typedef struct
{
    cstring name;
    EventType type;
    float inTime;
    float outTime;
}
EventData;

typedef struct
{
    csl::math::Vector3 position;
    csl::math::Quaternion rotation;
    float time;
}
NodeInfoInAnim;

typedef struct
{
    cstring name;
    NodeInfoInAnim nodeInfos;
}
NodeData;

typedef struct
{
    csl::math::Vector3 position;
    csl::math::Quaternion rotation;
    float time;
}
DeltaMotionInfoInAnim;

typedef struct
{
    DeltaMotionInfoInAnim deltaInfos;
}
DeltaMotionData;

typedef struct
{
    cstring name;
    EventData eventDatas;
    NodeData nodeDatas;
    DeltaMotionData deltaMotionData;
    float maxTime;
}
AnimData;

typedef struct
{
    AnimData animDatas;
}
RecordData;

