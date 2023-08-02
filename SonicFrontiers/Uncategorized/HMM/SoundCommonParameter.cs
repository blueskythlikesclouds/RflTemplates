Library "SoundCommonParameter"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct BGMVolumeChangeInfo
    {
        [FieldOffset(0)] public float value;
        [FieldOffset(4)] public float delayTime;
        [FieldOffset(8)] public float fadeTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 84)]
    public struct BGMVolumeChangeInfoList
    {
        [FieldOffset(0)]  public BGMVolumeChangeInfo playerStop;
        [FieldOffset(12)] public BGMVolumeChangeInfo playerWalk;
        [FieldOffset(24)] public BGMVolumeChangeInfo playerRun;
        [FieldOffset(36)] public BGMVolumeChangeInfo fishingHitIn;
        [FieldOffset(48)] public BGMVolumeChangeInfo fishingHitOut;
        [FieldOffset(60)] public BGMVolumeChangeInfo musicBoxIn;
        [FieldOffset(72)] public BGMVolumeChangeInfo musicBoxOut;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct AisacChangeInfo
    {
        [FieldOffset(0)] public float value;
        [FieldOffset(4)] public float fadeTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public struct AisacChangeInfoList
    {
        [FieldOffset(0)]  public AisacChangeInfo sunny;
        [FieldOffset(8)]  public AisacChangeInfo cloudy;
        [FieldOffset(16)] public AisacChangeInfo rainy;
        [FieldOffset(24)] public AisacChangeInfo beginUnderWater;
        [FieldOffset(32)] public AisacChangeInfo finishUnderWater;
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

    public enum Priority : sbyte
{
        PRIORITY_LOW = 0,
        PRIORITY_DEFAULT = 1,
        PRIORITY_HIGH = 2,
        PRIORITY_SUPER_HIGH = 3,
        NUM_PRIORITY = 4,
        PRIORITY_INVALID = -1
    }

    public enum InterruptType : sbyte
{
        INTERRUPT_TYPE_STOP = 0,
        INTERRUPT_TYPE_PAUSE = 1,
        INTERRUPT_TYPE_OVERLAP = 2,
        NUM_INTERRUPT_TYPE = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public struct BGMInfo
    {
        [FieldOffset(0)]  public CString cueName;
        [FieldOffset(16)] public int blockId;
        [FieldOffset(20)] public float fadeInTime;
        [FieldOffset(24)] public float fadeOutTime;
        [FieldOffset(28)] public float delayTime;
        [FieldOffset(32)] public CString aisacName;
        [FieldOffset(48)] public float aisacValue;
        [FieldOffset(52)] public float aisacFadeTime;
        [FieldOffset(56)] public bool isVolumeControl;
        [FieldOffset(57)] public bool isOverlapPlay;
        [FieldOffset(58)] public Priority priority;
        [FieldOffset(59)] public InterruptType interruptType;
    }

    public enum BGMTransitInfo_InterruptType : sbyte
{
        BGMTransitInfo_InterruptType_INTERRUPT_TYPE_STOP = 0,
        BGMTransitInfo_InterruptType_INTERRUPT_TYPE_PAUSE = 1,
        BGMTransitInfo_InterruptType_INTERRUPT_TYPE_OVERLAP = 2,
        BGMTransitInfo_InterruptType_NUM_INTERRUPT_TYPE = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct BGMTransitInfo
    {
        [FieldOffset(0)]  public CString tagName;
        [FieldOffset(16)] public int beforeId;
        [FieldOffset(20)] public int beforeIdMax;
        [FieldOffset(24)] public int afterId;
        [FieldOffset(28)] public BGMTransitInfo_InterruptType type;
        [FieldOffset(32)] public float fadeOutTime;
        [FieldOffset(36)] public float fadeInTime;
        [FieldOffset(40)] public float delayTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 14480)]
    public struct SoundCommonParameter
    {
        [FieldOffset(0)]    public float pauseFadeOutTime;
        [FieldOffset(4)]    public float pauseFadeInTime;
        [FieldOffset(8)]    public float enterCyberFadeOutTime;
        [FieldOffset(12)]   public float leaveCyberResultFadeOutTime;
        [FieldOffset(16)]   public BGMVolumeChangeInfoList bgmVolumeInfo;
        [FieldOffset(100)]  public AisacChangeInfoList aisacInfo;
        [FieldOffset(144)]  public unsafe fixed byte /* BGMInfo[128] */ _changeBgmInfo[8192];

        public unsafe BGMInfo* changeBgmInfo
        {
            get
            {
                fixed (byte* p_changeBgmInfo = _changeBgmInfo)
                    return (BGMInfo*)p_changeBgmInfo;
            }
        }

        [FieldOffset(8336)] public unsafe fixed byte /* BGMTransitInfo[128] */ _transitBgmInfo[6144];

        public unsafe BGMTransitInfo* transitBgmInfo
        {
            get
            {
                fixed (byte* p_transitBgmInfo = _transitBgmInfo)
                    return (BGMTransitInfo*)p_transitBgmInfo;
            }
        }
    }

}