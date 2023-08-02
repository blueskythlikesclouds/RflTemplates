Library "BakeBoxParameter"
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

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct BakeBoxParameter
    {
        [FieldOffset(0)]  public CString name;
        [FieldOffset(16)] public Vector3 center;
        [FieldOffset(32)] public Vector3 halfExtents;
    }

}