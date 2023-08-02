Library "PlayerCameraSetParameters"
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

    public enum Priority : byte
{
        Default = 0,
        High = 1
    }

    public enum CameraType : byte
{
        None = 0,
        Fixed = 1,
        Offset = 2,
        Follow = 3,
        Pan = 4,
        StaticPan = 5,
        PanUpByFront = 6
    }

    public enum CameraCoordType : byte
{
        Orthgonal = 0,
        Spherical = 1
    }

    [StructLayout(LayoutKind.Explicit, Size = 112)]
    public struct PlayerCameraParameter
    {
        [FieldOffset(0)]  public CameraType type;
        [FieldOffset(4)]  public float time;
        [FieldOffset(8)]  public float easeinTime;
        [FieldOffset(12)] public CameraCoordType lookAtCoord;
        [FieldOffset(16)] public Vector3 localLookAtOffset;
        [FieldOffset(32)] public Vector3 worldLookAtOffset;
        [FieldOffset(48)] public CameraCoordType eyeCoord;
        [FieldOffset(64)] public Vector3 localEyeOffset;
        [FieldOffset(80)] public Vector3 worldEyeOffset;
        [FieldOffset(96)] public float roll;
    }

    [StructLayout(LayoutKind.Explicit, Size = 928)]
    public struct PlayerCameraSetParameter
    {
        [FieldOffset(0)]  public CString name;
        [FieldOffset(16)] public float easeoutTime;
        [FieldOffset(20)] public Priority priority;
        [FieldOffset(32)] public unsafe fixed byte /* PlayerCameraParameter[8] */ _param[896];

        public unsafe PlayerCameraParameter* param
        {
            get
            {
                fixed (byte* p_param = _param)
                    return (PlayerCameraParameter*)p_param;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 41760)]
    public struct PlayerCameraSetParameters
    {
        [FieldOffset(0)] public unsafe fixed byte /* PlayerCameraSetParameter[45] */ _data[41760];

        public unsafe PlayerCameraSetParameter* data
        {
            get
            {
                fixed (byte* p_data = _data)
                    return (PlayerCameraSetParameter*)p_data;
            }
        }
    }

}