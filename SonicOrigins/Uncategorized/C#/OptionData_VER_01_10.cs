using System.Numerics;
using System.Runtime.InteropServices;

public class OptionData_VER_01_10Class
{
    public enum Status : sbyte
    {
        STATUS_ZERO_FILL = 0,
        STATUS_INITIALIZED = 1
    }

    [StructLayout(LayoutKind.Explicit, Size = 60)]
    public struct HeaderData
    {
        [FieldOffset(0)]  public uint signature;
        [FieldOffset(4)]  public byte version;
        [FieldOffset(5)]  public byte minorVersion;
        [FieldOffset(6)]  public Status status;
        [FieldOffset(7)]  public byte config;
        [FieldOffset(8)]  public uint playTime;
        [FieldOffset(12)] public uint playCount;
        [FieldOffset(16)] public uint saveDate;
        [FieldOffset(20)] public byte index;
        [FieldOffset(21)] public byte flags;
        [FieldOffset(22)] public byte padding1__arr0;
        [FieldOffset(23)] public byte padding1__arr1;
        [FieldOffset(24)] public uint crc;
        [FieldOffset(28)] public byte padding2__arr0;
        [FieldOffset(29)] public byte padding2__arr1;
        [FieldOffset(30)] public byte padding2__arr2;
        [FieldOffset(31)] public byte padding2__arr3;
        [FieldOffset(32)] public byte padding2__arr4;
        [FieldOffset(33)] public byte padding2__arr5;
        [FieldOffset(34)] public byte padding2__arr6;
        [FieldOffset(35)] public byte padding2__arr7;
        [FieldOffset(36)] public byte padding2__arr8;
        [FieldOffset(37)] public byte padding2__arr9;
        [FieldOffset(38)] public byte padding2__arr10;
        [FieldOffset(39)] public byte padding2__arr11;
        [FieldOffset(40)] public byte padding2__arr12;
        [FieldOffset(41)] public byte padding2__arr13;
        [FieldOffset(42)] public byte padding2__arr14;
        [FieldOffset(43)] public byte padding2__arr15;
        [FieldOffset(44)] public byte padding2__arr16;
        [FieldOffset(45)] public byte padding2__arr17;
        [FieldOffset(46)] public byte padding2__arr18;
        [FieldOffset(47)] public byte padding2__arr19;
        [FieldOffset(48)] public byte padding2__arr20;
        [FieldOffset(49)] public byte padding2__arr21;
        [FieldOffset(50)] public byte padding2__arr22;
        [FieldOffset(51)] public byte padding2__arr23;
        [FieldOffset(52)] public byte padding2__arr24;
        [FieldOffset(53)] public byte padding2__arr25;
        [FieldOffset(54)] public byte padding2__arr26;
        [FieldOffset(55)] public byte padding2__arr27;
        [FieldOffset(56)] public byte padding2__arr28;
        [FieldOffset(57)] public byte padding2__arr29;
        [FieldOffset(58)] public byte padding2__arr30;
        [FieldOffset(59)] public byte padding2__arr31;
    }

    public enum VoiceLanguageType : sbyte
    {
        VOICE_LANGUAGE_ENGLISH = 0,
        VOICE_LANGUAGE_FRENCH = 1,
        VOICE_LANGUAGE_ITALIAN = 2,
        VOICE_LANGUAGE_GERMAN = 3,
        VOICE_LANGUAGE_SPANISH = 4,
        VOICE_LANGUAGE_JAPANESE = 5,
        NUM_VOICE_LANGUAGES = 6
    }

    public enum LanguageType : sbyte
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
    }

    public enum VibrationLevel : sbyte
    {
        None = 0,
        Low = 1,
        Medium = 2,
        High = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct OptionGamePlayData
    {
        [FieldOffset(0)] public VoiceLanguageType speech;
        [FieldOffset(1)] public LanguageType text;
        [FieldOffset(2)] public VibrationLevel vibrationLevel;
        [FieldOffset(3)] public byte config;
    }

    public enum GamepadKind : sbyte
    {
        GAMEPADKIND_NONE = -1,
        GAMEPADKIND_PS = 0,
        GAMEPADKIND_PS5 = 1,
        GAMEPADKIND_XBOX = 2,
        GAMEPADKIND_SCARLETT = 3,
        GAMEPADKIND_SWITCH = 4,
        GAMEPADKIND_STEAM = 5,
        MAX_NUM_GAMEPADKIND = 6
    }

    public enum KeyConfigType : sbyte
    {
        KEYCONFIGTYPE_DEFAULT = 0,
        KEYCONFIGTYPE_MIRROR = 1,
        KEYCONFIGTYPE_CUSTOM = 2,
        KEYCONFIGTYPE_NUM = 3
    }

    public enum InputKey : int
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
    }

    [StructLayout(LayoutKind.Explicit, Size = 1160)]
    public struct OptionControlsData_VER_01_09
    {
        [FieldOffset(0)]    public GamepadKind iconType1;
        [FieldOffset(1)]    public GamepadKind iconType2;
        [FieldOffset(2)]    public KeyConfigType pad1ConfigType;
        [FieldOffset(3)]    public KeyConfigType pad2ConfigType;
        [FieldOffset(4)]    public KeyConfigType keyConfigType;
        [FieldOffset(5)]    public byte reserved__arr0;
        [FieldOffset(6)] public byte reserved__arr1;
        [FieldOffset(7)] public byte reserved__arr2;
        [FieldOffset(8)]    public InputKey pad1Mappings__arr0;
        [FieldOffset(12)] public InputKey pad1Mappings__arr1;
        [FieldOffset(16)] public InputKey pad1Mappings__arr2;
        [FieldOffset(20)] public InputKey pad1Mappings__arr3;
        [FieldOffset(24)] public InputKey pad1Mappings__arr4;
        [FieldOffset(28)] public InputKey pad1Mappings__arr5;
        [FieldOffset(32)] public InputKey pad1Mappings__arr6;
        [FieldOffset(36)] public InputKey pad1Mappings__arr7;
        [FieldOffset(40)] public InputKey pad1Mappings__arr8;
        [FieldOffset(44)] public InputKey pad1Mappings__arr9;
        [FieldOffset(48)] public InputKey pad1Mappings__arr10;
        [FieldOffset(52)] public InputKey pad1Mappings__arr11;
        [FieldOffset(56)] public InputKey pad1Mappings__arr12;
        [FieldOffset(60)] public InputKey pad1Mappings__arr13;
        [FieldOffset(64)] public InputKey pad1Mappings__arr14;
        [FieldOffset(68)] public InputKey pad1Mappings__arr15;
        [FieldOffset(72)] public InputKey pad1Mappings__arr16;
        [FieldOffset(76)] public InputKey pad1Mappings__arr17;
        [FieldOffset(80)] public InputKey pad1Mappings__arr18;
        [FieldOffset(84)] public InputKey pad1Mappings__arr19;
        [FieldOffset(88)] public InputKey pad1Mappings__arr20;
        [FieldOffset(92)] public InputKey pad1Mappings__arr21;
        [FieldOffset(96)] public InputKey pad1Mappings__arr22;
        [FieldOffset(100)] public InputKey pad1Mappings__arr23;
        [FieldOffset(104)] public InputKey pad1Mappings__arr24;
        [FieldOffset(108)] public InputKey pad1Mappings__arr25;
        [FieldOffset(112)] public InputKey pad1Mappings__arr26;
        [FieldOffset(116)] public InputKey pad1Mappings__arr27;
        [FieldOffset(120)] public InputKey pad1Mappings__arr28;
        [FieldOffset(124)] public InputKey pad1Mappings__arr29;
        [FieldOffset(128)] public InputKey pad1Mappings__arr30;
        [FieldOffset(132)] public InputKey pad1Mappings__arr31;
        [FieldOffset(136)] public InputKey pad1Mappings__arr32;
        [FieldOffset(140)] public InputKey pad1Mappings__arr33;
        [FieldOffset(144)] public InputKey pad1Mappings__arr34;
        [FieldOffset(148)] public InputKey pad1Mappings__arr35;
        [FieldOffset(152)]  public InputKey pad2Mappings__arr0;
        [FieldOffset(156)] public InputKey pad2Mappings__arr1;
        [FieldOffset(160)] public InputKey pad2Mappings__arr2;
        [FieldOffset(164)] public InputKey pad2Mappings__arr3;
        [FieldOffset(168)] public InputKey pad2Mappings__arr4;
        [FieldOffset(172)] public InputKey pad2Mappings__arr5;
        [FieldOffset(176)] public InputKey pad2Mappings__arr6;
        [FieldOffset(180)] public InputKey pad2Mappings__arr7;
        [FieldOffset(184)] public InputKey pad2Mappings__arr8;
        [FieldOffset(188)] public InputKey pad2Mappings__arr9;
        [FieldOffset(192)] public InputKey pad2Mappings__arr10;
        [FieldOffset(196)] public InputKey pad2Mappings__arr11;
        [FieldOffset(200)] public InputKey pad2Mappings__arr12;
        [FieldOffset(204)] public InputKey pad2Mappings__arr13;
        [FieldOffset(208)] public InputKey pad2Mappings__arr14;
        [FieldOffset(212)] public InputKey pad2Mappings__arr15;
        [FieldOffset(216)] public InputKey pad2Mappings__arr16;
        [FieldOffset(220)] public InputKey pad2Mappings__arr17;
        [FieldOffset(224)] public InputKey pad2Mappings__arr18;
        [FieldOffset(228)] public InputKey pad2Mappings__arr19;
        [FieldOffset(232)] public InputKey pad2Mappings__arr20;
        [FieldOffset(236)] public InputKey pad2Mappings__arr21;
        [FieldOffset(240)] public InputKey pad2Mappings__arr22;
        [FieldOffset(244)] public InputKey pad2Mappings__arr23;
        [FieldOffset(248)] public InputKey pad2Mappings__arr24;
        [FieldOffset(252)] public InputKey pad2Mappings__arr25;
        [FieldOffset(256)] public InputKey pad2Mappings__arr26;
        [FieldOffset(260)] public InputKey pad2Mappings__arr27;
        [FieldOffset(264)] public InputKey pad2Mappings__arr28;
        [FieldOffset(268)] public InputKey pad2Mappings__arr29;
        [FieldOffset(272)] public InputKey pad2Mappings__arr30;
        [FieldOffset(276)] public InputKey pad2Mappings__arr31;
        [FieldOffset(280)] public InputKey pad2Mappings__arr32;
        [FieldOffset(284)] public InputKey pad2Mappings__arr33;
        [FieldOffset(288)] public InputKey pad2Mappings__arr34;
        [FieldOffset(292)] public InputKey pad2Mappings__arr35;
        [FieldOffset(296)]  public InputKey mainKeyMappings__arr0;
        [FieldOffset(300)] public InputKey mainKeyMappings__arr1;
        [FieldOffset(304)] public InputKey mainKeyMappings__arr2;
        [FieldOffset(308)] public InputKey mainKeyMappings__arr3;
        [FieldOffset(312)] public InputKey mainKeyMappings__arr4;
        [FieldOffset(316)] public InputKey mainKeyMappings__arr5;
        [FieldOffset(320)] public InputKey mainKeyMappings__arr6;
        [FieldOffset(324)] public InputKey mainKeyMappings__arr7;
        [FieldOffset(328)] public InputKey mainKeyMappings__arr8;
        [FieldOffset(332)] public InputKey mainKeyMappings__arr9;
        [FieldOffset(336)] public InputKey mainKeyMappings__arr10;
        [FieldOffset(340)] public InputKey mainKeyMappings__arr11;
        [FieldOffset(344)] public InputKey mainKeyMappings__arr12;
        [FieldOffset(348)] public InputKey mainKeyMappings__arr13;
        [FieldOffset(352)] public InputKey mainKeyMappings__arr14;
        [FieldOffset(356)] public InputKey mainKeyMappings__arr15;
        [FieldOffset(360)] public InputKey mainKeyMappings__arr16;
        [FieldOffset(364)] public InputKey mainKeyMappings__arr17;
        [FieldOffset(368)] public InputKey mainKeyMappings__arr18;
        [FieldOffset(372)] public InputKey mainKeyMappings__arr19;
        [FieldOffset(376)] public InputKey mainKeyMappings__arr20;
        [FieldOffset(380)] public InputKey mainKeyMappings__arr21;
        [FieldOffset(384)] public InputKey mainKeyMappings__arr22;
        [FieldOffset(388)] public InputKey mainKeyMappings__arr23;
        [FieldOffset(392)] public InputKey mainKeyMappings__arr24;
        [FieldOffset(396)] public InputKey mainKeyMappings__arr25;
        [FieldOffset(400)] public InputKey mainKeyMappings__arr26;
        [FieldOffset(404)] public InputKey mainKeyMappings__arr27;
        [FieldOffset(408)] public InputKey mainKeyMappings__arr28;
        [FieldOffset(412)] public InputKey mainKeyMappings__arr29;
        [FieldOffset(416)] public InputKey mainKeyMappings__arr30;
        [FieldOffset(420)] public InputKey mainKeyMappings__arr31;
        [FieldOffset(424)] public InputKey mainKeyMappings__arr32;
        [FieldOffset(428)] public InputKey mainKeyMappings__arr33;
        [FieldOffset(432)] public InputKey mainKeyMappings__arr34;
        [FieldOffset(436)] public InputKey mainKeyMappings__arr35;
        [FieldOffset(440)]  public InputKey subKeyMappings__arr0;
        [FieldOffset(444)] public InputKey subKeyMappings__arr1;
        [FieldOffset(448)] public InputKey subKeyMappings__arr2;
        [FieldOffset(452)] public InputKey subKeyMappings__arr3;
        [FieldOffset(456)] public InputKey subKeyMappings__arr4;
        [FieldOffset(460)] public InputKey subKeyMappings__arr5;
        [FieldOffset(464)] public InputKey subKeyMappings__arr6;
        [FieldOffset(468)] public InputKey subKeyMappings__arr7;
        [FieldOffset(472)] public InputKey subKeyMappings__arr8;
        [FieldOffset(476)] public InputKey subKeyMappings__arr9;
        [FieldOffset(480)] public InputKey subKeyMappings__arr10;
        [FieldOffset(484)] public InputKey subKeyMappings__arr11;
        [FieldOffset(488)] public InputKey subKeyMappings__arr12;
        [FieldOffset(492)] public InputKey subKeyMappings__arr13;
        [FieldOffset(496)] public InputKey subKeyMappings__arr14;
        [FieldOffset(500)] public InputKey subKeyMappings__arr15;
        [FieldOffset(504)] public InputKey subKeyMappings__arr16;
        [FieldOffset(508)] public InputKey subKeyMappings__arr17;
        [FieldOffset(512)] public InputKey subKeyMappings__arr18;
        [FieldOffset(516)] public InputKey subKeyMappings__arr19;
        [FieldOffset(520)] public InputKey subKeyMappings__arr20;
        [FieldOffset(524)] public InputKey subKeyMappings__arr21;
        [FieldOffset(528)] public InputKey subKeyMappings__arr22;
        [FieldOffset(532)] public InputKey subKeyMappings__arr23;
        [FieldOffset(536)] public InputKey subKeyMappings__arr24;
        [FieldOffset(540)] public InputKey subKeyMappings__arr25;
        [FieldOffset(544)] public InputKey subKeyMappings__arr26;
        [FieldOffset(548)] public InputKey subKeyMappings__arr27;
        [FieldOffset(552)] public InputKey subKeyMappings__arr28;
        [FieldOffset(556)] public InputKey subKeyMappings__arr29;
        [FieldOffset(560)] public InputKey subKeyMappings__arr30;
        [FieldOffset(564)] public InputKey subKeyMappings__arr31;
        [FieldOffset(568)] public InputKey subKeyMappings__arr32;
        [FieldOffset(572)] public InputKey subKeyMappings__arr33;
        [FieldOffset(576)] public InputKey subKeyMappings__arr34;
        [FieldOffset(580)] public InputKey subKeyMappings__arr35;
        [FieldOffset(584)]  public InputKey pad1MappingsCustom__arr0;
        [FieldOffset(588)] public InputKey pad1MappingsCustom__arr1;
        [FieldOffset(592)] public InputKey pad1MappingsCustom__arr2;
        [FieldOffset(596)] public InputKey pad1MappingsCustom__arr3;
        [FieldOffset(600)] public InputKey pad1MappingsCustom__arr4;
        [FieldOffset(604)] public InputKey pad1MappingsCustom__arr5;
        [FieldOffset(608)] public InputKey pad1MappingsCustom__arr6;
        [FieldOffset(612)] public InputKey pad1MappingsCustom__arr7;
        [FieldOffset(616)] public InputKey pad1MappingsCustom__arr8;
        [FieldOffset(620)] public InputKey pad1MappingsCustom__arr9;
        [FieldOffset(624)] public InputKey pad1MappingsCustom__arr10;
        [FieldOffset(628)] public InputKey pad1MappingsCustom__arr11;
        [FieldOffset(632)] public InputKey pad1MappingsCustom__arr12;
        [FieldOffset(636)] public InputKey pad1MappingsCustom__arr13;
        [FieldOffset(640)] public InputKey pad1MappingsCustom__arr14;
        [FieldOffset(644)] public InputKey pad1MappingsCustom__arr15;
        [FieldOffset(648)] public InputKey pad1MappingsCustom__arr16;
        [FieldOffset(652)] public InputKey pad1MappingsCustom__arr17;
        [FieldOffset(656)] public InputKey pad1MappingsCustom__arr18;
        [FieldOffset(660)] public InputKey pad1MappingsCustom__arr19;
        [FieldOffset(664)] public InputKey pad1MappingsCustom__arr20;
        [FieldOffset(668)] public InputKey pad1MappingsCustom__arr21;
        [FieldOffset(672)] public InputKey pad1MappingsCustom__arr22;
        [FieldOffset(676)] public InputKey pad1MappingsCustom__arr23;
        [FieldOffset(680)] public InputKey pad1MappingsCustom__arr24;
        [FieldOffset(684)] public InputKey pad1MappingsCustom__arr25;
        [FieldOffset(688)] public InputKey pad1MappingsCustom__arr26;
        [FieldOffset(692)] public InputKey pad1MappingsCustom__arr27;
        [FieldOffset(696)] public InputKey pad1MappingsCustom__arr28;
        [FieldOffset(700)] public InputKey pad1MappingsCustom__arr29;
        [FieldOffset(704)] public InputKey pad1MappingsCustom__arr30;
        [FieldOffset(708)] public InputKey pad1MappingsCustom__arr31;
        [FieldOffset(712)] public InputKey pad1MappingsCustom__arr32;
        [FieldOffset(716)] public InputKey pad1MappingsCustom__arr33;
        [FieldOffset(720)] public InputKey pad1MappingsCustom__arr34;
        [FieldOffset(724)] public InputKey pad1MappingsCustom__arr35;
        [FieldOffset(728)]  public InputKey pad2MappingsCustom__arr0;
        [FieldOffset(732)] public InputKey pad2MappingsCustom__arr1;
        [FieldOffset(736)] public InputKey pad2MappingsCustom__arr2;
        [FieldOffset(740)] public InputKey pad2MappingsCustom__arr3;
        [FieldOffset(744)] public InputKey pad2MappingsCustom__arr4;
        [FieldOffset(748)] public InputKey pad2MappingsCustom__arr5;
        [FieldOffset(752)] public InputKey pad2MappingsCustom__arr6;
        [FieldOffset(756)] public InputKey pad2MappingsCustom__arr7;
        [FieldOffset(760)] public InputKey pad2MappingsCustom__arr8;
        [FieldOffset(764)] public InputKey pad2MappingsCustom__arr9;
        [FieldOffset(768)] public InputKey pad2MappingsCustom__arr10;
        [FieldOffset(772)] public InputKey pad2MappingsCustom__arr11;
        [FieldOffset(776)] public InputKey pad2MappingsCustom__arr12;
        [FieldOffset(780)] public InputKey pad2MappingsCustom__arr13;
        [FieldOffset(784)] public InputKey pad2MappingsCustom__arr14;
        [FieldOffset(788)] public InputKey pad2MappingsCustom__arr15;
        [FieldOffset(792)] public InputKey pad2MappingsCustom__arr16;
        [FieldOffset(796)] public InputKey pad2MappingsCustom__arr17;
        [FieldOffset(800)] public InputKey pad2MappingsCustom__arr18;
        [FieldOffset(804)] public InputKey pad2MappingsCustom__arr19;
        [FieldOffset(808)] public InputKey pad2MappingsCustom__arr20;
        [FieldOffset(812)] public InputKey pad2MappingsCustom__arr21;
        [FieldOffset(816)] public InputKey pad2MappingsCustom__arr22;
        [FieldOffset(820)] public InputKey pad2MappingsCustom__arr23;
        [FieldOffset(824)] public InputKey pad2MappingsCustom__arr24;
        [FieldOffset(828)] public InputKey pad2MappingsCustom__arr25;
        [FieldOffset(832)] public InputKey pad2MappingsCustom__arr26;
        [FieldOffset(836)] public InputKey pad2MappingsCustom__arr27;
        [FieldOffset(840)] public InputKey pad2MappingsCustom__arr28;
        [FieldOffset(844)] public InputKey pad2MappingsCustom__arr29;
        [FieldOffset(848)] public InputKey pad2MappingsCustom__arr30;
        [FieldOffset(852)] public InputKey pad2MappingsCustom__arr31;
        [FieldOffset(856)] public InputKey pad2MappingsCustom__arr32;
        [FieldOffset(860)] public InputKey pad2MappingsCustom__arr33;
        [FieldOffset(864)] public InputKey pad2MappingsCustom__arr34;
        [FieldOffset(868)] public InputKey pad2MappingsCustom__arr35;
        [FieldOffset(872)]  public InputKey mainKeyMappingsCustom__arr0;
        [FieldOffset(876)] public InputKey mainKeyMappingsCustom__arr1;
        [FieldOffset(880)] public InputKey mainKeyMappingsCustom__arr2;
        [FieldOffset(884)] public InputKey mainKeyMappingsCustom__arr3;
        [FieldOffset(888)] public InputKey mainKeyMappingsCustom__arr4;
        [FieldOffset(892)] public InputKey mainKeyMappingsCustom__arr5;
        [FieldOffset(896)] public InputKey mainKeyMappingsCustom__arr6;
        [FieldOffset(900)] public InputKey mainKeyMappingsCustom__arr7;
        [FieldOffset(904)] public InputKey mainKeyMappingsCustom__arr8;
        [FieldOffset(908)] public InputKey mainKeyMappingsCustom__arr9;
        [FieldOffset(912)] public InputKey mainKeyMappingsCustom__arr10;
        [FieldOffset(916)] public InputKey mainKeyMappingsCustom__arr11;
        [FieldOffset(920)] public InputKey mainKeyMappingsCustom__arr12;
        [FieldOffset(924)] public InputKey mainKeyMappingsCustom__arr13;
        [FieldOffset(928)] public InputKey mainKeyMappingsCustom__arr14;
        [FieldOffset(932)] public InputKey mainKeyMappingsCustom__arr15;
        [FieldOffset(936)] public InputKey mainKeyMappingsCustom__arr16;
        [FieldOffset(940)] public InputKey mainKeyMappingsCustom__arr17;
        [FieldOffset(944)] public InputKey mainKeyMappingsCustom__arr18;
        [FieldOffset(948)] public InputKey mainKeyMappingsCustom__arr19;
        [FieldOffset(952)] public InputKey mainKeyMappingsCustom__arr20;
        [FieldOffset(956)] public InputKey mainKeyMappingsCustom__arr21;
        [FieldOffset(960)] public InputKey mainKeyMappingsCustom__arr22;
        [FieldOffset(964)] public InputKey mainKeyMappingsCustom__arr23;
        [FieldOffset(968)] public InputKey mainKeyMappingsCustom__arr24;
        [FieldOffset(972)] public InputKey mainKeyMappingsCustom__arr25;
        [FieldOffset(976)] public InputKey mainKeyMappingsCustom__arr26;
        [FieldOffset(980)] public InputKey mainKeyMappingsCustom__arr27;
        [FieldOffset(984)] public InputKey mainKeyMappingsCustom__arr28;
        [FieldOffset(988)] public InputKey mainKeyMappingsCustom__arr29;
        [FieldOffset(992)] public InputKey mainKeyMappingsCustom__arr30;
        [FieldOffset(996)] public InputKey mainKeyMappingsCustom__arr31;
        [FieldOffset(1000)] public InputKey mainKeyMappingsCustom__arr32;
        [FieldOffset(1004)] public InputKey mainKeyMappingsCustom__arr33;
        [FieldOffset(1008)] public InputKey mainKeyMappingsCustom__arr34;
        [FieldOffset(1012)] public InputKey mainKeyMappingsCustom__arr35;
        [FieldOffset(1016)] public InputKey subKeyMappingsCustom__arr0;
        [FieldOffset(1020)] public InputKey subKeyMappingsCustom__arr1;
        [FieldOffset(1024)] public InputKey subKeyMappingsCustom__arr2;
        [FieldOffset(1028)] public InputKey subKeyMappingsCustom__arr3;
        [FieldOffset(1032)] public InputKey subKeyMappingsCustom__arr4;
        [FieldOffset(1036)] public InputKey subKeyMappingsCustom__arr5;
        [FieldOffset(1040)] public InputKey subKeyMappingsCustom__arr6;
        [FieldOffset(1044)] public InputKey subKeyMappingsCustom__arr7;
        [FieldOffset(1048)] public InputKey subKeyMappingsCustom__arr8;
        [FieldOffset(1052)] public InputKey subKeyMappingsCustom__arr9;
        [FieldOffset(1056)] public InputKey subKeyMappingsCustom__arr10;
        [FieldOffset(1060)] public InputKey subKeyMappingsCustom__arr11;
        [FieldOffset(1064)] public InputKey subKeyMappingsCustom__arr12;
        [FieldOffset(1068)] public InputKey subKeyMappingsCustom__arr13;
        [FieldOffset(1072)] public InputKey subKeyMappingsCustom__arr14;
        [FieldOffset(1076)] public InputKey subKeyMappingsCustom__arr15;
        [FieldOffset(1080)] public InputKey subKeyMappingsCustom__arr16;
        [FieldOffset(1084)] public InputKey subKeyMappingsCustom__arr17;
        [FieldOffset(1088)] public InputKey subKeyMappingsCustom__arr18;
        [FieldOffset(1092)] public InputKey subKeyMappingsCustom__arr19;
        [FieldOffset(1096)] public InputKey subKeyMappingsCustom__arr20;
        [FieldOffset(1100)] public InputKey subKeyMappingsCustom__arr21;
        [FieldOffset(1104)] public InputKey subKeyMappingsCustom__arr22;
        [FieldOffset(1108)] public InputKey subKeyMappingsCustom__arr23;
        [FieldOffset(1112)] public InputKey subKeyMappingsCustom__arr24;
        [FieldOffset(1116)] public InputKey subKeyMappingsCustom__arr25;
        [FieldOffset(1120)] public InputKey subKeyMappingsCustom__arr26;
        [FieldOffset(1124)] public InputKey subKeyMappingsCustom__arr27;
        [FieldOffset(1128)] public InputKey subKeyMappingsCustom__arr28;
        [FieldOffset(1132)] public InputKey subKeyMappingsCustom__arr29;
        [FieldOffset(1136)] public InputKey subKeyMappingsCustom__arr30;
        [FieldOffset(1140)] public InputKey subKeyMappingsCustom__arr31;
        [FieldOffset(1144)] public InputKey subKeyMappingsCustom__arr32;
        [FieldOffset(1148)] public InputKey subKeyMappingsCustom__arr33;
        [FieldOffset(1152)] public InputKey subKeyMappingsCustom__arr34;
        [FieldOffset(1156)] public InputKey subKeyMappingsCustom__arr35;
    }

    public enum MovementStyle : sbyte
    {
        PadSimulate = 0,
        Aiming = 1
    }

    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public struct OptionCameraData
    {
        [FieldOffset(0)]  public float rotateSpeedPad;
        [FieldOffset(4)]  public float rotateSpeedVertMouse;
        [FieldOffset(8)]  public float rotateSpeedHorzMouse;
        [FieldOffset(12)] public float reticleSpeedPad;
        [FieldOffset(16)] public float reticleSpeedVertMouse;
        [FieldOffset(20)] public float reticleSpeedHorzMouse;
        [FieldOffset(24)] public MovementStyle movementStyle;
        [FieldOffset(25)] public byte config;
    }

    [StructLayout(LayoutKind.Explicit, Size = 2)]
    public struct OptionAudioData
    {
        [FieldOffset(0)] public byte sfxVolume;
        [FieldOffset(1)] public byte musicVolume;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct OptionGraphicsData
    {
        [FieldOffset(0)] public int resolutionW;
        [FieldOffset(4)] public int resolutionH;
        [FieldOffset(8)] public byte config;
        [FieldOffset(9)] public byte pkgRegion;
    }

    [StructLayout(LayoutKind.Explicit, Size = 1)]
    public struct OptionLetterboxData
    {
        [FieldOffset(0)] public byte letterboxKind;
    }

    public enum RankingType : sbyte
    {
        MyRank = 0,
        TopRank = 1
    }

    [StructLayout(LayoutKind.Explicit, Size = 1)]
    public struct MydataMenuData
    {
        [FieldOffset(0)] public RankingType lastRankingType;
    }

    [StructLayout(LayoutKind.Explicit, Size = 1272)]
    public struct OptionData_VER_01_10
    {
        [FieldOffset(0)]    public HeaderData header;
        [FieldOffset(60)]   public OptionGamePlayData gameplay;
        [FieldOffset(64)]   public OptionControlsData_VER_01_09 controls;
        [FieldOffset(1224)] public OptionCameraData camera;
        [FieldOffset(1252)] public OptionAudioData audio;
        [FieldOffset(1256)] public OptionGraphicsData graphics;
        [FieldOffset(1268)] public OptionLetterboxData letterbox;
        [FieldOffset(1269)] public MydataMenuData mydatamenu;
    }

}