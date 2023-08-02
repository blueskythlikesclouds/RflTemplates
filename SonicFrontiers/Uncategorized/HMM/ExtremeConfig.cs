Library "ExtremeConfig"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    public enum LineType : sbyte
{
        LINE3 = 0,
        LINE5 = 1,
        LINE_INF = 2
    }

    public struct Color8
    {
        public byte A;
        public byte R;
        public byte G;
        public byte B;
    }

    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public struct ExtremeConfig
    {
        [FieldOffset(0)]  public LineType lineType;
        [FieldOffset(4)]  public float lineWidth;
        [FieldOffset(8)]  public float roadLength;
        [FieldOffset(12)] public float speed;
        [FieldOffset(16)] public float barricadeInterval;
        [FieldOffset(20)] public float emergencyDistance;
        [FieldOffset(32)] public Vector3 barricadeSize;
        [FieldOffset(48)] public Color8 roadColor;
        [FieldOffset(52)] public Color8 barricadeColor;
        [FieldOffset(56)] public float cameraFovy;
        [FieldOffset(60)] public float cameraDistance;
        [FieldOffset(64)] public float cameraUpOffset;
        [FieldOffset(68)] public float cameraShakeOffset;
    }

}