using System.Numerics;
using System.Runtime.InteropServices;

public class DecoConfigParamClass
{
    public struct Color8
    {
        public byte A;
        public byte R;
        public byte G;
        public byte B;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct DecoConfigParam
    {
        [FieldOffset(0)]  public Color8 clientColor;
        [FieldOffset(4)]  public byte windowAlpha;
        [FieldOffset(8)]  public Color8 startGradationGuideColor;
        [FieldOffset(12)] public Color8 endGradationGuideColor;
    }

}