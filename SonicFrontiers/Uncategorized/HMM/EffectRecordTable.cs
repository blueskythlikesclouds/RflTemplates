Library "EffectRecordTable"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 1)]
    public struct Record
    {
        [FieldOffset(0)] public byte no;
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

    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public struct EffectRecord
    {
        [FieldOffset(0)] public Record record;
        [FieldOffset(8)] public unsafe fixed byte /* CString[5] */ _emitterSetName[1275];

        public unsafe CString* emitterSetName
        {
            get
            {
                fixed (byte* p_emitterSetName = _emitterSetName)
                    return (CString*)p_emitterSetName;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 22440)]
    public struct EffectRecordTable
    {
        [FieldOffset(0)] public unsafe fixed byte /* EffectRecord[255] */ _data[22440];

        public unsafe EffectRecord* data
        {
            get
            {
                fixed (byte* p_data = _data)
                    return (EffectRecord*)p_data;
            }
        }
    }

}