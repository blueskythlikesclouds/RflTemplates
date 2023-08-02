Library "SwayParamIndivisual"
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

    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public struct SwayParamNode
    {
        [FieldOffset(0)]  public bool enable;
        [FieldOffset(4)]  public float gravity;
        [FieldOffset(8)]  public float resist;
        [FieldOffset(12)] public float resist_decay;
        [FieldOffset(16)] public float recover;
        [FieldOffset(20)] public float recover_decay;
        [FieldOffset(24)] public float spring;
        [FieldOffset(28)] public float radius;
        [FieldOffset(32)] public float transmit;
        [FieldOffset(36)] public float inertia;
        [FieldOffset(40)] public float angle_limit;
        [FieldOffset(48)] public CString nodeName;
    }

    public enum CollisionType : sbyte
{
        SWAY_COLLISTION_TYPE_NONE = 0,
        SWAY_COLLISTION_TYPE_SPHERE = 1
    }

    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public struct SwayParamCollision
    {
        [FieldOffset(0)]  public CollisionType type;
        [FieldOffset(16)] public Vector3 translation;
        [FieldOffset(32)] public Vector3 rotation;
        [FieldOffset(48)] public Vector3 scale;
        [FieldOffset(64)] public int modelPartId;
        [FieldOffset(72)] public CString modelNodeName;
    }

    [StructLayout(LayoutKind.Explicit, Size = 768)]
    public struct SwayParamNodeCollision
    {
        [FieldOffset(0)] public unsafe fixed byte /* SwayParamCollision[8] */ _collisionParam[768];

        public unsafe SwayParamCollision* collisionParam
        {
            get
            {
                fixed (byte* p_collisionParam = _collisionParam)
                    return (SwayParamCollision*)p_collisionParam;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 13328)]
    public struct SwayParamIndivisual
    {
        [FieldOffset(0)]    public CString idName;
        [FieldOffset(16)]   public unsafe fixed byte /* SwayParamNode[16] */ _nodeParam[1024];

        public unsafe SwayParamNode* nodeParam
        {
            get
            {
                fixed (byte* p_nodeParam = _nodeParam)
                    return (SwayParamNode*)p_nodeParam;
            }
        }

        [FieldOffset(1040)] public unsafe fixed byte /* SwayParamNodeCollision[16] */ _collisionParam[12288];

        public unsafe SwayParamNodeCollision* collisionParam
        {
            get
            {
                fixed (byte* p_collisionParam = _collisionParam)
                    return (SwayParamNodeCollision*)p_collisionParam;
            }
        }
    }

}