Library "MiniBossChargerCameraShake"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public struct MiniBossChargerCameraShake
    {
        [FieldOffset(0)]  public float time;
        [FieldOffset(4)]  public float magnitude;
        [FieldOffset(8)]  public int freq;
        [FieldOffset(12)] public float attnRatio;
        [FieldOffset(16)] public float shakeRange;
    }

}