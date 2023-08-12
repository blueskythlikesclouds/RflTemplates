using System.Numerics;
using System.Runtime.InteropServices;

public class UIRflParamClass
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct InputHelpRflParam
    {
        [FieldOffset(0)] public float itemMargin;
    }

    public enum MainMenuMode : sbyte
    {
        MAINMENU_MODE_SONIC1 = 0,
        MAINMENU_MODE_SONICCD = 1,
        MAINMENU_MODE_SONIC2 = 2,
        MAINMENU_MODE_SONIC3K = 3,
        MAINMENU_MODE_MISSION = 4,
        MAINMENU_MODE_DATA = 5,
        MAINMENU_MODE_NUM = 6
    }

    [StructLayout(LayoutKind.Explicit, Size = 2)]
    public struct AllMapMenuItemParam
    {
        [FieldOffset(0)] public MainMenuMode menuMode;
        [FieldOffset(1)] public bool isRepeate;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct AllMapMenuRflParam
    {
        [FieldOffset(0)] public AllMapMenuItemParam itemUp;
        [FieldOffset(2)] public AllMapMenuItemParam itemDown;
        [FieldOffset(4)] public AllMapMenuItemParam itemLeft;
        [FieldOffset(6)] public AllMapMenuItemParam itemRight;
    }

    [StructLayout(LayoutKind.Explicit, Size = 60)]
    public struct MainMenuRflParam
    {
        [FieldOffset(0)]  public float textScrollSpeed;
        [FieldOffset(4)]  public bool textScrollLoop;
        [FieldOffset(5)]  public AllMapMenuRflParam allMapMenu__arr0;
        [FieldOffset(13)] public AllMapMenuRflParam allMapMenu__arr1;
        [FieldOffset(21)] public AllMapMenuRflParam allMapMenu__arr2;
        [FieldOffset(29)] public AllMapMenuRflParam allMapMenu__arr3;
        [FieldOffset(37)] public AllMapMenuRflParam allMapMenu__arr4;
        [FieldOffset(45)] public AllMapMenuRflParam allMapMenu__arr5;
        [FieldOffset(56)] public float backTitleInputTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 2)]
    public struct MenuFPSRflParam
    {
        [FieldOffset(0)] public bool fixedFrame;
        [FieldOffset(1)] public bool isFPS30;
    }

    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public struct MenuRflParam
    {
        [FieldOffset(0)]  public InputHelpRflParam inputHelpParam;
        [FieldOffset(4)]  public MainMenuRflParam mainMenuParam;
        [FieldOffset(64)] public MenuFPSRflParam fpsParam;
        [FieldOffset(66)] public MenuFPSRflParam fpsParamNX;
        [FieldOffset(68)] public MenuFPSRflParam fpsParamORBIS;
        [FieldOffset(70)] public MenuFPSRflParam fpsParamDURANGO;
        [FieldOffset(72)] public float missionOutWaitTimer;
        [FieldOffset(76)] public float mydataOutWaitTimer;
        [FieldOffset(80)] public float museumOutWaitTimer;
        [FieldOffset(84)] public float optionOutWaitTimer;
    }

    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public struct AdvertiseRflParam
    {
        [FieldOffset(0)]  public float CESA_autoTimer;
        [FieldOffset(4)]  public float CESA_skipTimer;
        [FieldOffset(8)]  public float CESA_startTimer;
        [FieldOffset(12)] public float CESA_endTimer;
        [FieldOffset(16)] public float CAUTION_LIGHT_autoTimer;
        [FieldOffset(20)] public float CAUTION_LIGHT_skipTimer;
        [FieldOffset(24)] public float CAUTION_LIGHT_startTimer;
        [FieldOffset(28)] public float CAUTION_LIGHT_endTimer;
        [FieldOffset(32)] public float SEGA_LOGO_autoTimer;
        [FieldOffset(36)] public float SEGA_LOGO_skipTimer;
        [FieldOffset(40)] public float SEGA_LOGO_startTimer;
        [FieldOffset(44)] public float SEGA_LOGO_endTimer;
        [FieldOffset(48)] public float SONICTEAM_LOGO_autoTimer;
        [FieldOffset(52)] public float SONICTEAM_LOGO_skipTimer;
        [FieldOffset(56)] public float SONICTEAM_LOGO_startTimer;
        [FieldOffset(60)] public float SONICTEAM_LOGO_endTimer;
        [FieldOffset(64)] public float RSDK_CRI_LOGO_autoTimer;
        [FieldOffset(68)] public float RSDK_CRI_LOGO_skipTimer;
        [FieldOffset(72)] public float RSDK_CRI_LOGO_startTimer;
        [FieldOffset(76)] public float RSDK_CRI_LOGO_endTimer;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct TitleRflParam
    {
        [FieldOffset(0)] public float toMovieTimer;
        [FieldOffset(4)] public float movieVolume;
        [FieldOffset(8)] public float cancelInputTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct OptionLanguageEditRflParam
    {
        [FieldOffset(0)] public bool enableEdit__arr0;
        [FieldOffset(1)] public bool enableEdit__arr1;
        [FieldOffset(2)] public bool enableEdit__arr2;
        [FieldOffset(3)] public bool enableEdit__arr3;
        [FieldOffset(4)] public bool enableEdit__arr4;
        [FieldOffset(5)] public bool enableEdit__arr5;
        [FieldOffset(6)] public bool enableEdit__arr6;
        [FieldOffset(7)] public bool enableEdit__arr7;
        [FieldOffset(8)] public bool enableEdit__arr8;
        [FieldOffset(9)] public bool enableEdit__arr9;
        [FieldOffset(10)] public bool enableEdit__arr10;
        [FieldOffset(11)] public bool enableEdit__arr11;
    }

    [StructLayout(LayoutKind.Explicit, Size = 120)]
    public struct OptionLetterBoxEditRflParam
    {
        [FieldOffset(0)]  public int enableDLC1LetterBoxKinds__arr0;
        [FieldOffset(4)] public int enableDLC1LetterBoxKinds__arr1;
        [FieldOffset(8)] public int enableDLC1LetterBoxKinds__arr2;
        [FieldOffset(12)] public int enableDLC1LetterBoxKinds__arr3;
        [FieldOffset(16)] public int enableDLC1LetterBoxKinds__arr4;
        [FieldOffset(20)] public int enableDLC1LetterBoxKinds__arr5;
        [FieldOffset(24)] public int enableDLC1LetterBoxKinds__arr6;
        [FieldOffset(28)] public int enableDLC1LetterBoxKinds__arr7;
        [FieldOffset(32)] public int enableDLC1LetterBoxKinds__arr8;
        [FieldOffset(36)] public int enableDLC1LetterBoxKinds__arr9;
        [FieldOffset(40)] public int enableDLC2LetterBoxKinds__arr0;
        [FieldOffset(44)] public int enableDLC2LetterBoxKinds__arr1;
        [FieldOffset(48)] public int enableDLC2LetterBoxKinds__arr2;
        [FieldOffset(52)] public int enableDLC2LetterBoxKinds__arr3;
        [FieldOffset(56)] public int enableDLC2LetterBoxKinds__arr4;
        [FieldOffset(60)] public int enableDLC2LetterBoxKinds__arr5;
        [FieldOffset(64)] public int enableDLC2LetterBoxKinds__arr6;
        [FieldOffset(68)] public int enableDLC2LetterBoxKinds__arr7;
        [FieldOffset(72)] public int enableDLC2LetterBoxKinds__arr8;
        [FieldOffset(76)] public int enableDLC2LetterBoxKinds__arr9;
        [FieldOffset(80)] public int enableDLC2LetterBoxKinds__arr10;
        [FieldOffset(84)] public int enableDLC2LetterBoxKinds__arr11;
        [FieldOffset(88)] public int enableDLC2LetterBoxKinds__arr12;
        [FieldOffset(92)] public int enableDLC2LetterBoxKinds__arr13;
        [FieldOffset(96)] public int enableDLC2LetterBoxKinds__arr14;
        [FieldOffset(100)] public int enableDLC2LetterBoxKinds__arr15;
        [FieldOffset(104)] public int enableDLC2LetterBoxKinds__arr16;
        [FieldOffset(108)] public int enableDLC2LetterBoxKinds__arr17;
        [FieldOffset(112)] public int enableDLC2LetterBoxKinds__arr18;
        [FieldOffset(116)] public int enableDLC2LetterBoxKinds__arr19;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct CString
    {
        [FieldOffset(0)] public long pValue;

        public string Value
        {
        	get => Marshal.PtrToStringAnsi((IntPtr)pValue);
        	set => pValue = (long)Marshal.StringToHGlobalAnsi(value);
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public struct OptionLicensePFParam
    {
        [FieldOffset(0)]  public CString addText;
        [FieldOffset(16)] public int addTextSize;
        [FieldOffset(24)] public CString addCommonTagJP;
        [FieldOffset(40)] public CString addCommonTagUS;
        [FieldOffset(56)] public CString addCommonTagEU;
    }

    [StructLayout(LayoutKind.Explicit, Size = 368)]
    public struct OptionLicenseRflParam
    {
        [FieldOffset(0)]   public int commonTextSize;
        [FieldOffset(8)]   public OptionLicensePFParam licensePS;
        [FieldOffset(80)]  public OptionLicensePFParam licenseXBOX;
        [FieldOffset(152)] public OptionLicensePFParam licenseSWITCH;
        [FieldOffset(224)] public OptionLicensePFParam licenseSTEAM;
        [FieldOffset(296)] public OptionLicensePFParam licenseEPIC;
    }

    [StructLayout(LayoutKind.Explicit, Size = 520)]
    public struct OptionRflParam
    {
        [FieldOffset(0)]   public OptionLanguageEditRflParam languageEdit;
        [FieldOffset(12)]  public OptionLetterBoxEditRflParam letterBoxEdit;
        [FieldOffset(136)] public OptionLicenseRflParam licenseParam;
        [FieldOffset(504)] public int ui_seekbarActionMove;
        [FieldOffset(508)] public float ui_seekbarWheelRatio;
        [FieldOffset(512)] public int applyTimer;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct SaveIconRflParam
    {
        [FieldOffset(0)] public float minimumDisplayTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 712)]
    public struct UIRflParam
    {
        [FieldOffset(0)]   public MenuRflParam menuParam;
        [FieldOffset(88)]  public AdvertiseRflParam advertiseParam;
        [FieldOffset(168)] public TitleRflParam titleParam;
        [FieldOffset(184)] public OptionRflParam optionParam;
        [FieldOffset(704)] public SaveIconRflParam saveIconParam;
    }

}