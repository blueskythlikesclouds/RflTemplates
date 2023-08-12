#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    float foregroundBokehMaxDepth;
    float foregroundBokehStartDepth;
    float backgroundBokehStartDepth;
    float backgroundBokehMaxDepth;
}
CameraDOFRflParameter;

typedef struct
{
    float fovy;
    csl::math::Vector3 targetOffset;
    csl::math::Vector3 eyeOffset;
    CameraDOFRflParameter dof;
}
IslandCameraRflParam;

typedef struct
{
    csl::math::Vector3 floatingOffset;
}
IslandFloatingRflParam;

typedef struct
{
    float moveDistance;
    float interpolateTime;
}
CursorMoveCameraRflParam;

typedef struct
{
    float playSpeed;
}
MapAnimCameraRflParam;

typedef struct
{
    float interpolateTime;
}
TitleMoveCameraRflParam;

typedef struct
{
    bool use;
    int32_t index;
    float amplitude;
    float periodMin;
    float periodMax;
}
ShakeCameraRflParameter;

typedef struct
{
    int32_t IBLIndex;
}
TimeChangeCameraRflParameter;

typedef struct
{
    float yawMax;
    float yawMin;
    float pitchMax;
    float pitchMin;
}
RotateAngleLimitRflParam;

typedef struct
{
    float fovYMax;
    float fovYMin;
    float fovYAddSpeed;
    float rotateSpeedMax;
    float rotateSpeedMin;
    RotateAngleLimitRflParam rotateLimitNear;
    RotateAngleLimitRflParam rotateLimitFar;
}
MapCameraRflParam;

typedef struct
{
    MapCameraRflParam params[7];
}
MapCameraRflParams;

typedef struct
{
    IslandCameraRflParam islandCameraParam[7];
    IslandCameraRflParam titleCameraParam[7];
    IslandCameraRflParam islandSky3KCameraParam;
    IslandCameraRflParam titleSky3KCameraParam;
    IslandFloatingRflParam islandSky3KFlaotingParam;
    CursorMoveCameraRflParam cursorMoveCamera;
    MapAnimCameraRflParam mapAnimCameraRflParam;
    TitleMoveCameraRflParam titleMoveCameraParam;
    ShakeCameraRflParameter shakeCameraParamIsland;
    ShakeCameraRflParameter shakeCameraParamTitle;
    ShakeCameraRflParameter shakeCameraParamAllMap;
    ShakeCameraRflParameter shakeCameraParamFree;
    bool enableShakeCameraNX;
    TimeChangeCameraRflParameter timeChangeDefaultParam;
    TimeChangeCameraRflParameter timeChangeNightParam;
    MapCameraRflParams mapFreeCameraParam;
    float alphaFadeTime;
    float zNear;
    float zFar;
    int32_t sceneParamIndexDefault;
    int32_t sceneParamIndexAllMap;
}
CameraRflParam;

typedef struct
{
    float failed_RetryWindowViewWaitTime;
    float success_AddCoinTime;
    float success_AddCoinStartWaitTime;
    float success_AddCoinEndWaitTime;
}
MissionResultRflParam;

typedef struct
{
    float hud_TimeLimit;
    MissionResultRflParam result;
}
MissionRflParam;

typedef struct
{
    float failed_RetryWindowViewWaitTime;
    float success_RestartWaitTime;
}
BossrushResultRflParam;

typedef struct
{
    BossrushResultRflParam result;
    int32_t clearCoin;
    float startFade_LoopWaitTime;
}
BossrushRflParam;

typedef struct
{
    int32_t dummy;
}
AnniversaryRflParam;

typedef struct
{
    int32_t consumeCoinCount;
    int32_t ui_seekbarActionMove;
    float ui_seekbarWheelRatio;
}
RewindModeRflParam;

typedef struct
{
    int32_t consumeCoinCount;
}
SpecialStageRflParam;

typedef struct
{
    float zoomTime;
    float maxMoveSpeed;
    float speedUpTime;
    float speedDownTime;
    csl::math::Vector2 limitLeftUp;
    csl::math::Vector2 limitRightDown;
    bool isInverted;
    float minMoveThreshold;
    float maxMoveThreshold;
    bool isSwitchContinuous;
    float switchWaitTime;
    float switchIntervalTime;
    bool isSwitchPageContinuous;
    float switchPageWaitTime;
    float switchPageIntervalTime;
}
MuseumArtGraphicPlayerRflParam;

typedef struct
{
    MuseumArtGraphicPlayerRflParam artGraphicPlayer;
}
MuseumArtGalleryRflParam;

typedef struct
{
    bool isSwitchContinuous;
    float switchWaitTime;
    float switchIntervalTime;
}
MuseumMusicPlayerRflParam;

typedef struct
{
    MuseumMusicPlayerRflParam musicPlayer;
}
MuseumMusicHallRflParam;

typedef struct
{
    bool isSwitchContinuous;
    float switchWaitTime;
    float switchIntervalTime;
    float movieVolume;
}
MuseumMoviePlayerRflParam;

typedef struct
{
    MuseumMoviePlayerRflParam moviePlayer;
}
MuseumMovieTheaterRflParam;

typedef struct
{
    MuseumArtGalleryRflParam artGallery;
    MuseumMusicHallRflParam musicHall;
    MuseumMovieTheaterRflParam movieTheater;
}
MuseumModeRflParam;

enum CreditType : int8_t
{
    HITE = 0,
    SONICCD_GOODEND = 1,
    SONICCD_BADEND = 2
};

typedef struct
{
    CreditType type;
}
CreditModeRflParam;

typedef struct
{
    float stickAndDigitalKeyConversion;
}
InputRflParam;

enum FadeType : int32_t
{
    WHITE = 0,
    BLACK = 1,
    NONE = 2
};

typedef struct
{
    FadeType fadeType;
    float fadeOutTime;
    float fadeInTime;
}
SceneFadeRflParam;

typedef struct
{
    SceneFadeRflParam fadeParam;
}
GameSceneRflParam;

typedef struct
{
    CameraRflParam camera;
    MissionRflParam mission;
    BossrushRflParam bossrush;
    AnniversaryRflParam anniversary;
    RewindModeRflParam rewindMode;
    SpecialStageRflParam specialStage;
    MuseumModeRflParam museum;
    CreditModeRflParam credit;
    InputRflParam inputParam;
    GameSceneRflParam sceneParam[16];
}
GameRflParam;

