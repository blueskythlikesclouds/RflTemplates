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
    cstring name;
    float scale;
    float time;
    float easeOutTime;
    float delayTime;
    bool layerPlayer;
    bool layerEnemy;
    bool layerDamagedEnemy;
    bool layerCamera;
    bool layerOthers;
}
GameHitStopParameterData;

typedef struct
{
    GameHitStopParameterData data[64];
}
GameHitStopParameter;

