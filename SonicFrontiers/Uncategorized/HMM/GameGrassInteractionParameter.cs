Library "GameGrassInteractionParameter"
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

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct GameGrassInteractionParameterData
    {
        [FieldOffset(0)]  public CString name;
        [FieldOffset(16)] public float radius;
        [FieldOffset(20)] public float height;
        [FieldOffset(24)] public float power;
        [FieldOffset(28)] public bool moveHitEnabled;
    }

    [StructLayout(LayoutKind.Explicit, Size = 1024)]
    public struct GameGrassInteractionParameter
    {
        [FieldOffset(0)] public unsafe fixed byte /* GameGrassInteractionParameterData[32] */ _data[1024];

        public unsafe GameGrassInteractionParameterData* data
        {
            get
            {
                fixed (byte* p_data = _data)
                    return (GameGrassInteractionParameterData*)p_data;
            }
        }
    }

}