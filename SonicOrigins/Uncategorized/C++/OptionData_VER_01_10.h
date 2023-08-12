#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

enum Status : int8_t
{
    STATUS_ZERO_FILL = 0,
    STATUS_INITIALIZED = 1
};

typedef struct
{
    uint32_t signature;
    uint8_t version;
    uint8_t minorVersion;
    Status status;
    uint8_t config;
    uint32_t playTime;
    uint32_t playCount;
    uint32_t saveDate;
    uint8_t index;
    uint8_t flags;
    uint8_t padding1[2];
    uint32_t crc;
    uint8_t padding2[32];
}
HeaderData;

enum VoiceLanguageType : int8_t
{
    VOICE_LANGUAGE_ENGLISH = 0,
    VOICE_LANGUAGE_FRENCH = 1,
    VOICE_LANGUAGE_ITALIAN = 2,
    VOICE_LANGUAGE_GERMAN = 3,
    VOICE_LANGUAGE_SPANISH = 4,
    VOICE_LANGUAGE_JAPANESE = 5,
    NUM_VOICE_LANGUAGES = 6
};

enum LanguageType : int8_t
{
    LANGUAGE_ENGLISH = 0,
    LANGUAGE_FRENCH = 1,
    LANGUAGE_ITALIAN = 2,
    LANGUAGE_GERMAN = 3,
    LANGUAGE_SPANISH = 4,
    LANGUAGE_POLISH = 5,
    LANGUAGE_PORTUGUESE = 6,
    LANGUAGE_RUSSIAN = 7,
    LANGUAGE_JAPANESE = 8,
    LANGUAGE_ZHONGWEN = 9,
    LANGUAGE_ZHONGWEN_S = 10,
    LANGUAGE_KOREAN = 11,
    NUM_LANGUAGES = 12
};

enum VibrationLevel : int8_t
{
    None = 0,
    Low = 1,
    Medium = 2,
    High = 3
};

typedef struct
{
    VoiceLanguageType speech;
    LanguageType text;
    VibrationLevel vibrationLevel;
    uint8_t config;
}
OptionGamePlayData;

enum GamepadKind : int8_t
{
    GAMEPADKIND_NONE = -1,
    GAMEPADKIND_PS = 0,
    GAMEPADKIND_PS5 = 1,
    GAMEPADKIND_XBOX = 2,
    GAMEPADKIND_SCARLETT = 3,
    GAMEPADKIND_SWITCH = 4,
    GAMEPADKIND_STEAM = 5,
    MAX_NUM_GAMEPADKIND = 6
};

enum KeyConfigType : int8_t
{
    KEYCONFIGTYPE_DEFAULT = 0,
    KEYCONFIGTYPE_MIRROR = 1,
    KEYCONFIGTYPE_CUSTOM = 2,
    KEYCONFIGTYPE_NUM = 3
};

enum InputKey : int32_t
{
    Invalid = -1,
    GamePad_DPadLeft = 0,
    GamePad_DPadRight = 1,
    GamePad_DPadUp = 2,
    GamePad_DPadDown = 3,
    GamePad_ButtonLeft = 4,
    GamePad_ButtonRight = 5,
    GamePad_ButtonTop = 6,
    GamePad_ButtonBottom = 7,
    GamePad_LeftX = 8,
    GamePad_LeftY = 9,
    GamePad_RightX = 10,
    GamePad_RightY = 11,
    GamePad_LeftShoulder = 12,
    GamePad_LeftTrigger = 13,
    GamePad_LeftClick = 14,
    GamePad_RightShoulder = 15,
    GamePad_RightTrigger = 16,
    GamePad_RightClick = 17,
    GamePad_LeftStickLeft = 18,
    GamePad_LeftStickRight = 19,
    GamePad_LeftStickUp = 20,
    GamePad_LeftStickDown = 21,
    GamePad_RightStickLeft = 22,
    GamePad_RightStickRight = 23,
    GamePad_RightStickUp = 24,
    GamePad_RightStickDown = 25,
    GamePad_Start = 26,
    GamePad_Select = 27,
    GamePad_LeftSideTriggerLeft = 28,
    GamePad_LeftSideTriggerRight = 29,
    GamePad_RightSideTriggerLeft = 30,
    GamePad_RightSideTriggerRight = 31,
    Keyboard_Nop = 32,
    Keyboard_A = 33,
    Keyboard_B = 34,
    Keyboard_C = 35,
    Keyboard_D = 36,
    Keyboard_E = 37,
    Keyboard_F = 38,
    Keyboard_G = 39,
    Keyboard_H = 40,
    Keyboard_I = 41,
    Keyboard_J = 42,
    Keyboard_K = 43,
    Keyboard_L = 44,
    Keyboard_M = 45,
    Keyboard_N = 46,
    Keyboard_O = 47,
    Keyboard_P = 48,
    Keyboard_Q = 49,
    Keyboard_R = 50,
    Keyboard_S = 51,
    Keyboard_T = 52,
    Keyboard_U = 53,
    Keyboard_V = 54,
    Keyboard_W = 55,
    Keyboard_X = 56,
    Keyboard_Y = 57,
    Keyboard_Z = 58,
    Keyboard_1 = 59,
    Keyboard_2 = 60,
    Keyboard_3 = 61,
    Keyboard_4 = 62,
    Keyboard_5 = 63,
    Keyboard_6 = 64,
    Keyboard_7 = 65,
    Keyboard_8 = 66,
    Keyboard_9 = 67,
    Keyboard_0 = 68,
    Keyboard_Enter = 69,
    Keyboard_Escape = 70,
    Keyboard_BackSpace = 71,
    Keyboard_Tab = 72,
    Keyboard_Spacebar = 73,
    Keyboard_Minus = 74,
    Keyboard_Accent = 75,
    Keyboard_Atmark = 76,
    Keyboard_LeftBracket = 77,
    Keyboard_BackSlash = 78,
    Keyboard_RightBracket = 79,
    Keyboard_SemiColon = 80,
    Keyboard_Colon = 81,
    Keyboard_Comma = 82,
    Keyboard_Period = 83,
    Keyboard_Slash = 84,
    Keyboard_CapsLock = 85,
    Keyboard_Grave = 86,
    Keyboard_Equals = 87,
    Keyboard_Apostrophe = 88,
    Keyboard_OEM_102 = 89,
    Keyboard_ABNT_C1 = 90,
    Keyboard_F1 = 91,
    Keyboard_F2 = 92,
    Keyboard_F3 = 93,
    Keyboard_F4 = 94,
    Keyboard_F5 = 95,
    Keyboard_F6 = 96,
    Keyboard_F7 = 97,
    Keyboard_F8 = 98,
    Keyboard_F9 = 99,
    Keyboard_F10 = 100,
    Keyboard_F11 = 101,
    Keyboard_F12 = 102,
    Keyboard_Insert = 103,
    Keyboard_Home = 104,
    Keyboard_PageUp = 105,
    Keyboard_Delete = 106,
    Keyboard_End = 107,
    Keyboard_PageDown = 108,
    Keyboard_LeftArrow = 109,
    Keyboard_RightArrow = 110,
    Keyboard_UpArrow = 111,
    Keyboard_DownArrow = 112,
    Keyboard_PadSlash = 113,
    Keyboard_PadAsterisk = 114,
    Keyboard_PadMinus = 115,
    Keyboard_PadPlus = 116,
    Keyboard_PadEnter = 117,
    Keyboard_PadNum1 = 118,
    Keyboard_PadNum2 = 119,
    Keyboard_PadNum3 = 120,
    Keyboard_PadNum4 = 121,
    Keyboard_PadNum5 = 122,
    Keyboard_PadNum6 = 123,
    Keyboard_PadNum7 = 124,
    Keyboard_PadNum8 = 125,
    Keyboard_PadNum9 = 126,
    Keyboard_PadNum0 = 127,
    Keyboard_PadPeriod = 128,
    Keyboard_LeftCtrl = 129,
    Keyboard_RightCtrl = 130,
    Keyboard_LeftShift = 131,
    Keyboard_RightShift = 132,
    Keyboard_LeftAlt = 133,
    Keyboard_RightAlt = 134,
    Keyboard_LeftGui = 135,
    Keyboard_RightGui = 136,
    Mouse_X = 137,
    Mouse_Y = 138,
    Mouse_ButtonLeft = 139,
    Mouse_ButtonRight = 140,
    Mouse_ButtonMiddle = 141,
    Mouse_ButtonX1 = 142,
    Mouse_ButtonX2 = 143,
    Mouse_ButtonX3 = 144,
    Mouse_ButtonX4 = 145,
    Mouse_ButtonX5 = 146,
    Mouse_Wheel = 147,
    Mouse_WheelUp = 148,
    Mouse_WheelDown = 149
};

typedef struct
{
    GamepadKind iconType1;
    GamepadKind iconType2;
    KeyConfigType pad1ConfigType;
    KeyConfigType pad2ConfigType;
    KeyConfigType keyConfigType;
    uint8_t reserved[3];
    InputKey pad1Mappings[36];
    InputKey pad2Mappings[36];
    InputKey mainKeyMappings[36];
    InputKey subKeyMappings[36];
    InputKey pad1MappingsCustom[36];
    InputKey pad2MappingsCustom[36];
    InputKey mainKeyMappingsCustom[36];
    InputKey subKeyMappingsCustom[36];
}
OptionControlsData_VER_01_09;

enum MovementStyle : int8_t
{
    PadSimulate = 0,
    Aiming = 1
};

typedef struct
{
    float rotateSpeedPad;
    float rotateSpeedVertMouse;
    float rotateSpeedHorzMouse;
    float reticleSpeedPad;
    float reticleSpeedVertMouse;
    float reticleSpeedHorzMouse;
    MovementStyle movementStyle;
    uint8_t config;
}
OptionCameraData;

typedef struct
{
    uint8_t sfxVolume;
    uint8_t musicVolume;
}
OptionAudioData;

typedef struct
{
    int32_t resolutionW;
    int32_t resolutionH;
    uint8_t config;
    uint8_t pkgRegion;
}
OptionGraphicsData;

typedef struct
{
    uint8_t letterboxKind;
}
OptionLetterboxData;

enum RankingType : int8_t
{
    MyRank = 0,
    TopRank = 1
};

typedef struct
{
    RankingType lastRankingType;
}
MydataMenuData;

typedef struct
{
    HeaderData header;
    OptionGamePlayData gameplay;
    OptionControlsData_VER_01_09 controls;
    OptionCameraData camera;
    OptionAudioData audio;
    OptionGraphicsData graphics;
    OptionLetterboxData letterbox;
    MydataMenuData mydatamenu;
}
OptionData_VER_01_10;

