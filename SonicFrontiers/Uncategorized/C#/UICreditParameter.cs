using System.Numerics;
using System.Runtime.InteropServices;

public class UICreditParameterClass
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct UICreditParameter
    {
        [FieldOffset(0)]  public float LicenseInterval;
        [FieldOffset(4)]  public float NameInterval;
        [FieldOffset(8)]  public float PostInterval;
        [FieldOffset(12)] public float CompanyInterval;
        [FieldOffset(16)] public float LogoInterval;
        [FieldOffset(20)] public float WaitTime;
    }

}