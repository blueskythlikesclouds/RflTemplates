Library "ScriptParameter"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct ScriptParameter
    {
        [FieldOffset(0)] public uint intervalMinuntes;
    }

}