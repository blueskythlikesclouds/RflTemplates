Library "CustomMusicParameter"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct CustomMusicTransitInfo
    {
        [FieldOffset(0)] public float fadeOutTime;
        [FieldOffset(4)] public float delayTime;
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

    public enum MusicType : sbyte
{
        THEME_SONG = 0,
        OTHER = 1
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct CustomMusicInfo
    {
        [FieldOffset(0)]  public CString cueName;
        [FieldOffset(16)] public float fadeOutTiming;
        [FieldOffset(20)] public bool _lock;
        [FieldOffset(21)] public MusicType musicType;
    }

    [StructLayout(LayoutKind.Explicit, Size = 3088)]
    public struct CustomMusicParameter
    {
        [FieldOffset(0)]    public CustomMusicTransitInfo transitInfo;
        [FieldOffset(8)]    public unsafe fixed byte /* CustomMusicInfo[128] */ _musicInfos[3072];

        public unsafe CustomMusicInfo* musicInfos
        {
            get
            {
                fixed (byte* p_musicInfos = _musicInfos)
                    return (CustomMusicInfo*)p_musicInfos;
            }
        }

        [FieldOffset(3080)] public float idlingViewTime;
    }

}