Library "BGMInfoParameter"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

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

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct BGMSceneInfo
    {
        [FieldOffset(0)]  public CString sceneName;
        [FieldOffset(16)] public int bgmId;
        [FieldOffset(20)] public bool disableSameBgmId;
    }

    [StructLayout(LayoutKind.Explicit, Size = 3680)]
    public struct BGMInfoParameter
    {
        [FieldOffset(0)]    public unsafe fixed byte /* BGMInfo[32] */ _changeBgmInfo[2048];

        public unsafe BGMInfo* changeBgmInfo
        {
            get
            {
                fixed (byte* p_changeBgmInfo = _changeBgmInfo)
                    return (BGMInfo*)p_changeBgmInfo;
            }
        }

        [FieldOffset(2048)] public unsafe fixed byte /* BGMTransitInfo[32] */ _transitBgmInfo[1536];

        public unsafe BGMTransitInfo* transitBgmInfo
        {
            get
            {
                fixed (byte* p_transitBgmInfo = _transitBgmInfo)
                    return (BGMTransitInfo*)p_transitBgmInfo;
            }
        }

        [FieldOffset(3584)] public unsafe fixed byte /* BGMSceneInfo[4] */ _sceneBgmInfo[96];

        public unsafe BGMSceneInfo* sceneBgmInfo
        {
            get
            {
                fixed (byte* p_sceneBgmInfo = _sceneBgmInfo)
                    return (BGMSceneInfo*)p_sceneBgmInfo;
            }
        }
    }

}