Library "MonologueParameters"
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

    [StructLayout(LayoutKind.Explicit, Size = 392)]
    public struct MonologueIslandParameters
    {
        [FieldOffset(0)] public float playSpanTime;
        [FieldOffset(8)] public unsafe fixed byte /* CString[24] */ _labelNames[6120];

        public unsafe CString* labelNames
        {
            get
            {
                fixed (byte* p_labelNames = _labelNames)
                    return (CString*)p_labelNames;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public struct MonologueMultiTextParameters
    {
        [FieldOffset(0)] public unsafe fixed byte /* CString[4] */ _labelNames[1020];

        public unsafe CString* labelNames
        {
            get
            {
                fixed (byte* p_labelNames = _labelNames)
                    return (CString*)p_labelNames;
            }
        }
    }

    public enum Value : sbyte
{
        SteppeIsland1 = 0,
        DesertIsland = 1,
        VolcanicIsland = 2,
        TowerIsland = 3,
        SteppeIsland2 = 4,
        Num = 5,
        ExtraIsland = 5,
        NumInExtra = 6
    }

    [StructLayout(LayoutKind.Explicit, Size = 2032)]
    public struct MonologueParameters
    {
        [FieldOffset(0)]    public unsafe fixed byte /* MonologueIslandParameters[5] */ _islands[1960];

        public unsafe MonologueIslandParameters* islands
        {
            get
            {
                fixed (byte* p_islands = _islands)
                    return (MonologueIslandParameters*)p_islands;
            }
        }

        [FieldOffset(1960)] public MonologueMultiTextParameters multiText;
        [FieldOffset(2024)] public sbyte firstTheEndNotifyCount;
        [FieldOffset(2025)] public sbyte theEndNotifyCount;
        [FieldOffset(2026)] public Value dummy;
    }

}