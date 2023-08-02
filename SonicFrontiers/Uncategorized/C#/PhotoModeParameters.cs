using System.Numerics;
using System.Runtime.InteropServices;

public class PhotoModeParametersClass
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct PhotoModeCameraParameters
    {
        [FieldOffset(0)]  public float translationLimit;
        [FieldOffset(4)]  public float translationSpeedXZ;
        [FieldOffset(8)]  public float translationSpeedY;
        [FieldOffset(12)] public float elevLimit;
        [FieldOffset(16)] public float rotationSpeed;
        [FieldOffset(20)] public float rollRange;
        [FieldOffset(24)] public float rollSpeed;
        [FieldOffset(28)] public float fovyRange;
        [FieldOffset(32)] public float fovySpeed;
        [FieldOffset(36)] public float speedRatioFast;
        [FieldOffset(40)] public float speedRatioSlow;
        [FieldOffset(44)] public float distance;
    }

    [StructLayout(LayoutKind.Explicit, Size = 60)]
    public struct PhotoModeFilterParameters
    {
        [FieldOffset(0)]  public float sepiaSaturationOffset;
        [FieldOffset(4)]  public float sepiaColorizeRate;
        [FieldOffset(8)]  public float sepiaColorizeHue;
        [FieldOffset(12)] public float increaseSaturationOffset;
        [FieldOffset(16)] public int warmColorROffset;
        [FieldOffset(20)] public int warmColorGOffset;
        [FieldOffset(24)] public int warmColorBOffset;
        [FieldOffset(28)] public int coldColorROffset;
        [FieldOffset(32)] public int coldColorGOffset;
        [FieldOffset(36)] public int coldColorBOffset;
        [FieldOffset(40)] public float retroContrastOffset;
        [FieldOffset(44)] public int retroROffset;
        [FieldOffset(48)] public int retroGOffset;
        [FieldOffset(52)] public int retroBOffset;
        [FieldOffset(56)] public float retroSaturationOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 108)]
    public struct PhotoModeParameters
    {
        [FieldOffset(0)]  public PhotoModeCameraParameters camera;
        [FieldOffset(48)] public PhotoModeFilterParameters filter;
    }

}