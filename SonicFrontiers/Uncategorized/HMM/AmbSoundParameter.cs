Library "AmbSoundParameter"
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

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct AmbInfo
    {
        [FieldOffset(0)]  public CString cueName;
        [FieldOffset(16)] public float fadeInTime;
        [FieldOffset(20)] public float fadeOutTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct AmbBaseNoiseParameter
    {
        [FieldOffset(0)] public CString cueName;
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct AmbRelativeWindParameter
    {
        [FieldOffset(0)]  public CString cueName;
        [FieldOffset(16)] public float speedThreshold;
        [FieldOffset(20)] public float fadeTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public struct AmbNearPointParameter
    {
        [FieldOffset(0)]  public CString cueName;
        [FieldOffset(16)] public float sensorRebootTime;
        [FieldOffset(20)] public float sensorRepositionTime;
        [FieldOffset(24)] public float lifeAreaRadius;
        [FieldOffset(28)] public float lifeTime;
        [FieldOffset(32)] public float fadeTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct AmbRiverParameter_Nearest
    {
        [FieldOffset(0)]  public CString cueName;
        [FieldOffset(16)] public float sensorRadius;
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct AmbRiverParameter_Multiple3D
    {
        [FieldOffset(0)]  public CString cueName;
        [FieldOffset(16)] public float attenuationDistance;
        [FieldOffset(20)] public float maxLevelPerPoint;
    }

    [StructLayout(LayoutKind.Explicit, Size = 360)]
    public struct AmbSoundParameter
    {
        [FieldOffset(0)]   public unsafe fixed byte /* AmbInfo[8] */ _ambSoundInfo[192];

        public unsafe AmbInfo* ambSoundInfo
        {
            get
            {
                fixed (byte* p_ambSoundInfo = _ambSoundInfo)
                    return (AmbInfo*)p_ambSoundInfo;
            }
        }

        [FieldOffset(192)] public AmbBaseNoiseParameter baseNoise;
        [FieldOffset(208)] public AmbRelativeWindParameter relativeWind;
        [FieldOffset(232)] public AmbNearPointParameter insect;
        [FieldOffset(272)] public AmbNearPointParameter grass;
        [FieldOffset(312)] public AmbRiverParameter_Nearest riverNearest;
        [FieldOffset(336)] public AmbRiverParameter_Multiple3D riverMultiple3D;
    }

}