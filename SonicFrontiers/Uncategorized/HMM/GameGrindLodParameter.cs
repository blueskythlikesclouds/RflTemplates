Library "GameGrindLodParameter"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct GameGrindLodParameter
    {
        [FieldOffset(0)]  public unsafe fixed float distances[4];
        [FieldOffset(16)] public unsafe fixed float cullingDistances[4];
    }

}