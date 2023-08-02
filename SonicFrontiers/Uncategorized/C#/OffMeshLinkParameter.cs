using System.Numerics;
using System.Runtime.InteropServices;

public class OffMeshLinkParameterClass
{

public enum OffMeshLinkDirection : byte
{
    OffMeshLinkUnidirectional = 0,
    OffMeshLinkBidirectional = 1
}

[StructLayout(LayoutKind.Explicit, Size = 48)]
public struct OffMeshLinkElement
{
    [FieldOffset(0)]  public Vector3 source;
    [FieldOffset(16)] public Vector3 destination;
    [FieldOffset(32)] public float radius;
    [FieldOffset(36)] public ushort flags;
    [FieldOffset(38)] public byte area;
    [FieldOffset(39)] public OffMeshLinkDirection direction;
    [FieldOffset(40)] public uint userID;
}

[StructLayout(LayoutKind.Explicit, Size = 32)]
public struct OffMeshLinkParameter
{
    [FieldOffset(0)] public OffMeshLinkElement elements;
}

} // OffMeshLinkParameterClass