Library "PlayerParamLowAltitudeJump"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct PlayerParamLowAltitudeJump
    {
        [FieldOffset(0)]  public float upSpeed;
        [FieldOffset(4)]  public float frontSpeed;
        [FieldOffset(8)]  public float damperV;
        [FieldOffset(12)] public float damperH;
        [FieldOffset(16)] public float gravity;
        [FieldOffset(20)] public float time;
    }

}