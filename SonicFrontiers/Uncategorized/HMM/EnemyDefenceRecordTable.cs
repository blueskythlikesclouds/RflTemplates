Library "EnemyDefenceRecordTable"
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

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct EnemyDefenceRecord
    {
        [FieldOffset(0)]  public Record record;
        [FieldOffset(8)]  public CString name;
        [FieldOffset(24)] public float baseRate;
        [FieldOffset(28)] public float slashRate;
        [FieldOffset(32)] public float quickRate;
        [FieldOffset(36)] public float stunRate;
        [FieldOffset(40)] public float staggerRate;
    }

    [StructLayout(LayoutKind.Explicit, Size = 6144)]
    public struct EnemyDefenceRecordTable
    {
        [FieldOffset(0)] public unsafe fixed byte /* EnemyDefenceRecord[128] */ _data[6144];

        public unsafe EnemyDefenceRecord* data
        {
            get
            {
                fixed (byte* p_data = _data)
                    return (EnemyDefenceRecord*)p_data;
            }
        }
    }

}