Library "BossCommonParameters"
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

    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public struct BossResourceInfo
    {
        [FieldOffset(0)]  public CString modelName;
        [FieldOffset(16)] public CString animName;
        [FieldOffset(32)] public Vector3 scale;
        [FieldOffset(48)] public CString stageName;
        [FieldOffset(64)] public Vector3 stagePos;
    }

    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public struct HoldPoint
    {
        [FieldOffset(0)]  public CString nodeName;
        [FieldOffset(16)] public Vector3 offset;
        [FieldOffset(32)] public Vector3 rot;
        [FieldOffset(48)] public CString tagName;
        [FieldOffset(64)] public int nextPointId;
    }

    [StructLayout(LayoutKind.Explicit, Size = 10240)]
    public struct HoldPointParameter
    {
        [FieldOffset(0)] public unsafe fixed byte /* HoldPoint[128] */ _holdPoints[10240];

        public unsafe HoldPoint* holdPoints
        {
            get
            {
                fixed (byte* p_holdPoints = _holdPoints)
                    return (HoldPoint*)p_holdPoints;
            }
        }
    }

    public enum Shape : sbyte
{
        SHAPE_SPHERER = 0,
        SHAPE_BOX = 1,
        SHAPE_CYLINDER = 2,
        SHAPE_CAPCULE = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public struct CollisionPart
    {
        [FieldOffset(0)]  public CString nodeName;
        [FieldOffset(16)] public Shape shape;
        [FieldOffset(17)] public bool isPhysics;
        [FieldOffset(32)] public Vector3 size;
        [FieldOffset(48)] public Vector3 offset;
        [FieldOffset(64)] public Vector3 rot;
        [FieldOffset(80)] public CString tagName;
    }

    [StructLayout(LayoutKind.Explicit, Size = 3072)]
    public struct CollisionPartParameter
    {
        [FieldOffset(0)] public unsafe fixed byte /* CollisionPart[32] */ _colParts[3072];

        public unsafe CollisionPart* colParts
        {
            get
            {
                fixed (byte* p_colParts = _colParts)
                    return (CollisionPart*)p_colParts;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 13392)]
    public struct BossCommonParameters
    {
        [FieldOffset(0)]     public BossResourceInfo resource;
        [FieldOffset(80)]    public HoldPointParameter holdParam;
        [FieldOffset(10320)] public CollisionPartParameter colParam;
    }

}