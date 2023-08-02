Library "CaptionParameter"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    public enum DisplayType : sbyte
{
        Caption = 0,
        Tutorial = 1
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

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct LabelData
    {
        [FieldOffset(0)]  public DisplayType display;
        [FieldOffset(8)]  public CString label;
        [FieldOffset(24)] public float waitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 648)]
    public struct Discussion
    {
        [FieldOffset(0)]   public unsafe fixed byte /* LabelData[20] */ _labels[640];

        public unsafe LabelData* labels
        {
            get
            {
                fixed (byte* p_labels = _labels)
                    return (LabelData*)p_labels;
            }
        }

        [FieldOffset(640)] public bool isForcePlay;
    }

    [StructLayout(LayoutKind.Explicit, Size = 6480)]
    public struct CaptionParameter
    {
        [FieldOffset(0)] public unsafe fixed byte /* Discussion[10] */ _discussions[6480];

        public unsafe Discussion* discussions
        {
            get
            {
                fixed (byte* p_discussions = _discussions)
                    return (Discussion*)p_discussions;
            }
        }
    }

}