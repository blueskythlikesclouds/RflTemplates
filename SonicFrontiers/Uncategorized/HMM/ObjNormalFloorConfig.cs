Library "ObjNormalFloorConfig"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct NormalFloorSize
    {
        [FieldOffset(0)] public float length;
        [FieldOffset(4)] public float width;
        [FieldOffset(8)] public float height;
    }

    [StructLayout(LayoutKind.Explicit, Size = 120)]
    public struct ObjNormalFloorConfig
    {
        [FieldOffset(0)] public unsafe fixed byte /* NormalFloorSize[10] */ _sizeInfo[120];

        public unsafe NormalFloorSize* sizeInfo
        {
            get
            {
                fixed (byte* p_sizeInfo = _sizeInfo)
                    return (NormalFloorSize*)p_sizeInfo;
            }
        }
    }

}