Library "OcclusionCapsuleList"
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

    public enum VolumeType : sbyte
{
        VOLUME_SPHERE = 0,
        VOLUME_CAPSULE = 1
    }

    public enum LODLevel : sbyte
{
        LOD_HIGH = 0,
        LOD_MIDDLE = 1,
        LOD_LOW = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 112)]
    public struct CapsuleParam
    {
        [FieldOffset(0)]   public CString type;
        [FieldOffset(16)]  public VolumeType volume;
        [FieldOffset(20)]  public int priority;
        [FieldOffset(32)]  public Vector3 translation;
        [FieldOffset(48)]  public Vector3 rotation;
        [FieldOffset(64)]  public Vector3 scale;
        [FieldOffset(80)]  public Vector3 rate;
        [FieldOffset(96)]  public float radius;
        [FieldOffset(100)] public LODLevel lod;
    }

    [StructLayout(LayoutKind.Explicit, Size = 7168)]
    public struct OcclusionCapsuleList
    {
        [FieldOffset(0)] public unsafe fixed byte /* CapsuleParam[64] */ _capsules[7168];

        public unsafe CapsuleParam* capsules
        {
            get
            {
                fixed (byte* p_capsules = _capsules)
                    return (CapsuleParam*)p_capsules;
            }
        }
    }

}