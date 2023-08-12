#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    float itemMargin;
}
InputHelpRflParam;

enum MainMenuMode : int8_t
{
    MAINMENU_MODE_SONIC1 = 0,
    MAINMENU_MODE_SONICCD = 1,
    MAINMENU_MODE_SONIC2 = 2,
    MAINMENU_MODE_SONIC3K = 3,
    MAINMENU_MODE_MISSION = 4,
    MAINMENU_MODE_DATA = 5,
    MAINMENU_MODE_NUM = 6
};

typedef struct
{
    MainMenuMode menuMode;
    bool isRepeate;
}
AllMapMenuItemParam;

typedef struct
{
    AllMapMenuItemParam itemUp;
    AllMapMenuItemParam itemDown;
    AllMapMenuItemParam itemLeft;
    AllMapMenuItemParam itemRight;
}
AllMapMenuRflParam;

typedef struct
{
    float textScrollSpeed;
    bool textScrollLoop;
    AllMapMenuRflParam allMapMenu[6];
    float backTitleInputTime;
}
MainMenuRflParam;

typedef struct
{
    bool fixedFrame;
    bool isFPS30;
}
MenuFPSRflParam;

typedef struct
{
    InputHelpRflParam inputHelpParam;
    MainMenuRflParam mainMenuParam;
    MenuFPSRflParam fpsParam;
    MenuFPSRflParam fpsParamNX;
    MenuFPSRflParam fpsParamORBIS;
    MenuFPSRflParam fpsParamDURANGO;
    float missionOutWaitTimer;
    float mydataOutWaitTimer;
    float museumOutWaitTimer;
    float optionOutWaitTimer;
}
MenuRflParam;

typedef struct
{
    float CESA_autoTimer;
    float CESA_skipTimer;
    float CESA_startTimer;
    float CESA_endTimer;
    float CAUTION_LIGHT_autoTimer;
    float CAUTION_LIGHT_skipTimer;
    float CAUTION_LIGHT_startTimer;
    float CAUTION_LIGHT_endTimer;
    float SEGA_LOGO_autoTimer;
    float SEGA_LOGO_skipTimer;
    float SEGA_LOGO_startTimer;
    float SEGA_LOGO_endTimer;
    float SONICTEAM_LOGO_autoTimer;
    float SONICTEAM_LOGO_skipTimer;
    float SONICTEAM_LOGO_startTimer;
    float SONICTEAM_LOGO_endTimer;
    float RSDK_CRI_LOGO_autoTimer;
    float RSDK_CRI_LOGO_skipTimer;
    float RSDK_CRI_LOGO_startTimer;
    float RSDK_CRI_LOGO_endTimer;
}
AdvertiseRflParam;

typedef struct
{
    float toMovieTimer;
    float movieVolume;
    float cancelInputTime;
}
TitleRflParam;

typedef struct
{
    bool enableEdit[12];
}
OptionLanguageEditRflParam;

typedef struct
{
    int32_t enableDLC1LetterBoxKinds[10];
    int32_t enableDLC2LetterBoxKinds[20];
}
OptionLetterBoxEditRflParam;

typedef struct
{
    const char* pValue;
    INSERT_PADDING(8);
}
cstring;

typedef struct
{
    cstring addText;
    int32_t addTextSize;
    cstring addCommonTagJP;
    cstring addCommonTagUS;
    cstring addCommonTagEU;
}
OptionLicensePFParam;

typedef struct
{
    int32_t commonTextSize;
    OptionLicensePFParam licensePS;
    OptionLicensePFParam licenseXBOX;
    OptionLicensePFParam licenseSWITCH;
    OptionLicensePFParam licenseSTEAM;
    OptionLicensePFParam licenseEPIC;
}
OptionLicenseRflParam;

typedef struct
{
    OptionLanguageEditRflParam languageEdit;
    OptionLetterBoxEditRflParam letterBoxEdit;
    OptionLicenseRflParam licenseParam;
    int32_t ui_seekbarActionMove;
    float ui_seekbarWheelRatio;
    int32_t applyTimer;
}
OptionRflParam;

typedef struct
{
    float minimumDisplayTime;
}
SaveIconRflParam;

typedef struct
{
    MenuRflParam menuParam;
    AdvertiseRflParam advertiseParam;
    TitleRflParam titleParam;
    OptionRflParam optionParam;
    SaveIconRflParam saveIconParam;
}
UIRflParam;

