Library "ObjWolfManagerConfig"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct FocusCameraConfig
    {
        [FieldOffset(0)]  public float duration;
        [FieldOffset(4)]  public float distance;
        [FieldOffset(8)]  public float minElevation;
        [FieldOffset(12)] public float maxElevation;
        [FieldOffset(16)] public float panningSuspensionK;
        [FieldOffset(20)] public float interiorPanningSuspensionK;
    }

    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public struct ObjWolfManagerConfig
    {
        [FieldOffset(0)]  public FocusCameraConfig focusCamera;
        [FieldOffset(24)] public float shotInterval;
        [FieldOffset(28)] public float shotInterval_Parried;
        [FieldOffset(32)] public float shotInterval_Reborn;
        [FieldOffset(36)] public float shotInterval_First;
        [FieldOffset(40)] public float shotInterval_NoReborn;
        [FieldOffset(44)] public float stunTime;
        [FieldOffset(48)] public float approachWait;
        [FieldOffset(52)] public float dispWait;
        [FieldOffset(56)] public float rollWait;
        [FieldOffset(60)] public float reactionTime;
        [FieldOffset(64)] public float controlDelay;
        [FieldOffset(68)] public float shotAngle;
    }

}