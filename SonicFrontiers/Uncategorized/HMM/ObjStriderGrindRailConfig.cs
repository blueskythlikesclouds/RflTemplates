Library "ObjStriderGrindRailConfig"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public struct ObjStriderGrindRailConfig
    {
        [FieldOffset(0)]  public float bulletSpeed;
        [FieldOffset(4)]  public float bulletRotDegPerSec;
        [FieldOffset(8)]  public float jumpToCenterTime;
        [FieldOffset(12)] public float jumpTime;
        [FieldOffset(16)] public float jumpToCenterTangentY;
        [FieldOffset(20)] public float jumpTangentMultiplier;
        [FieldOffset(24)] public float jumpDestinationOffsetY;
        [FieldOffset(28)] public float jumpDestinationOffsetXZ;
        [FieldOffset(32)] public float jumpToFloorHeight;
        [FieldOffset(36)] public float jumpToFloorOffset;
        [FieldOffset(40)] public float jumpToFloorTime;
        [FieldOffset(44)] public float bulletWaitTime;
        [FieldOffset(48)] public float timeTilDisappear;
        [FieldOffset(52)] public float segmentLength;
        [FieldOffset(56)] public float collisionHeight;
        [FieldOffset(60)] public float collisionRadiusAddend;
        [FieldOffset(64)] public float initialEffectScaleY;
        [FieldOffset(68)] public float initialEffectScaleXZ;
        [FieldOffset(72)] public float maxEffectScaleXZ;
        [FieldOffset(76)] public float timeToMaxEffectScale;
    }

}