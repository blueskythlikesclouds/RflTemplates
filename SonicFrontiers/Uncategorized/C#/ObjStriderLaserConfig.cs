using System.Numerics;
using System.Runtime.InteropServices;

public class ObjStriderLaserConfigClass
{
    public struct ColorF
    {
        public float A;
        public float R;
        public float G;
        public float B;
    }

    public struct Color8
    {
        public byte A;
        public byte R;
        public byte G;
        public byte B;
    }

    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public struct ArcLaserConfig
    {
        [FieldOffset(0)]  public float arrivalTime;
        [FieldOffset(4)]  public byte numPatterns;
        [FieldOffset(8)]  public float radius;
        [FieldOffset(12)] public float tilingDistance;
        [FieldOffset(16)] public float fluctuationPeriod;
        [FieldOffset(20)] public float fluctuationAmplitude;
        [FieldOffset(24)] public float uvScrollSpeed;
        [FieldOffset(28)] public ColorF colorPrimary;
        [FieldOffset(44)] public Color8 colorVertexEdge;
        [FieldOffset(48)] public Color8 colorVertexCenter;
        [FieldOffset(52)] public float colorIntensity;
        [FieldOffset(56)] public float patternChangeIntervalTime;
        [FieldOffset(60)] public float edgeWidthScale;
        [FieldOffset(64)] public float edgeWidthScaleLength;
    }

    [StructLayout(LayoutKind.Explicit, Size = 100)]
    public struct ObjStriderLaserConfig
    {
        [FieldOffset(0)]  public float lifeTime;
        [FieldOffset(4)]  public float degreeVelocityPrePostLaser;
        [FieldOffset(8)]  public float degreeVelocity;
        [FieldOffset(12)] public float degreeToRotate;
        [FieldOffset(16)] public float radius;
        [FieldOffset(20)] public float collisionRadius;
        [FieldOffset(24)] public float minStartingPointOffset;
        [FieldOffset(28)] public float maxStartingPointOffset;
        [FieldOffset(32)] public ArcLaserConfig arcLaserConfig;
    }

}