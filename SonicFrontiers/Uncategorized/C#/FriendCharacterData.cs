using System.Numerics;
using System.Runtime.InteropServices;

public class FriendCharacterDataClass
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct FriendCharacterData
    {
        [FieldOffset(0)]  public ushort numRings;
        [FieldOffset(2)]  public byte ringLevel;
        [FieldOffset(3)]  public byte speedLevel;
        [FieldOffset(4)]  public uint skill;
        [FieldOffset(8)]  public uint expPoint;
        [FieldOffset(12)] public ushort skillPoint;
        [FieldOffset(14)] public byte boostGaugeLevel;
        [FieldOffset(15)] public byte padding;
        [FieldOffset(16)] public uint reserved0;
        [FieldOffset(20)] public uint reserved1;
        [FieldOffset(24)] public uint reserved2;
        [FieldOffset(28)] public uint reserved3;
    }

}