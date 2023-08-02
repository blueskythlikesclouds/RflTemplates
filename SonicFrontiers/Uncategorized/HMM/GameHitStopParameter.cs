Library "GameHitStopParameter"
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

    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public struct GameHitStopParameterData
    {
        [FieldOffset(0)]  public CString name;
        [FieldOffset(16)] public float scale;
        [FieldOffset(20)] public float time;
        [FieldOffset(24)] public float easeOutTime;
        [FieldOffset(28)] public float delayTime;
        [FieldOffset(32)] public bool layerPlayer;
        [FieldOffset(33)] public bool layerEnemy;
        [FieldOffset(34)] public bool layerDamagedEnemy;
        [FieldOffset(35)] public bool layerCamera;
        [FieldOffset(36)] public bool layerOthers;
    }

    [StructLayout(LayoutKind.Explicit, Size = 2560)]
    public struct GameHitStopParameter
    {
        [FieldOffset(0)] public unsafe fixed byte /* GameHitStopParameterData[64] */ _data[2560];

        public unsafe GameHitStopParameterData* data
        {
            get
            {
                fixed (byte* p_data = _data)
                    return (GameHitStopParameterData*)p_data;
            }
        }
    }

}