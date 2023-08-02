using System.Numerics;
using System.Runtime.InteropServices;

public class SequenceParameterClass
{

public enum SequenceType : byte
{
    SequenceSensor = 0,
    ObjItem = 1
}

[StructLayout(LayoutKind.Explicit, Size = 8)]
public struct SequenceParameter
{
    [FieldOffset(0)] public float suckedTime;
    [FieldOffset(4)] public SequenceType sequenceType;
}

} // SequenceParameterClass