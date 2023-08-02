Library "ObjHoverStoneConfig"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct ObjHoverStoneConfig
    {
        [FieldOffset(0)] public float hoverUpSpeed;
        [FieldOffset(4)] public float fallSpeed;
        [FieldOffset(8)] public float homingAttackBounce;
    }

}