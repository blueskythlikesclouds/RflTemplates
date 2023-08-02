Library "CameraShakeTable"
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

    public enum ShakeType : byte
{
        Directional = 0,
        WorldY = 1,
        Random = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct CameraShakeRecord
    {
        [FieldOffset(0)]  public CString name;
        [FieldOffset(16)] public ShakeType type;
        [FieldOffset(20)] public float zRot;
        [FieldOffset(24)] public float duration;
        [FieldOffset(28)] public float frequency;
        [FieldOffset(32)] public float amplitude;
        [FieldOffset(36)] public float timeAttenuationRate;
        [FieldOffset(40)] public bool enableDistanceAttenuation;
        [FieldOffset(44)] public float attenuationDistance;
    }

    [StructLayout(LayoutKind.Explicit, Size = 3072)]
    public struct CameraShakeTable
    {
        [FieldOffset(0)] public unsafe fixed byte /* CameraShakeRecord[64] */ _records[3072];

        public unsafe CameraShakeRecord* records
        {
            get
            {
                fixed (byte* p_records = _records)
                    return (CameraShakeRecord*)p_records;
            }
        }
    }

}