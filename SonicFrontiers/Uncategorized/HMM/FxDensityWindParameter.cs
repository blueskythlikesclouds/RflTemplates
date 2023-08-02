Library "FxDensityWindParameter"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct FxDensityWindParameter
    {
        [FieldOffset(0)]  public float windDir;
        [FieldOffset(4)]  public float windPower;
        [FieldOffset(8)]  public float windLenght;
        [FieldOffset(12)] public float windSpeed;
        [FieldOffset(16)] public float windRalenght;
        [FieldOffset(20)] public float windRaamp;
        [FieldOffset(24)] public float windRalevel;
        [FieldOffset(28)] public float windRtpower;
    }

}