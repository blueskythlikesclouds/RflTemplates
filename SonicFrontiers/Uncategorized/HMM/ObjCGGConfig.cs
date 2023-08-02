Library "ObjCGGConfig"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    public struct Color8
    {
        public byte A;
        public byte R;
        public byte G;
        public byte B;
    }

    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public struct RailCameraParam
    {
        [FieldOffset(0)]  public float yOffset;
        [FieldOffset(4)]  public float cameraElevation;
        [FieldOffset(8)]  public float cameraDistance;
        [FieldOffset(12)] public float cameraFovy;
        [FieldOffset(16)] public float radius;
        [FieldOffset(20)] public float cameraLookAtPointOffsetY;
        [FieldOffset(24)] public float cameraDegreeForClockwiseMovement;
        [FieldOffset(28)] public float cameraDegreeForCounterClockwiseMovement;
        [FieldOffset(32)] public float cameraMaxChangeableDegreeByStickInput;
        [FieldOffset(36)] public float cameraMaxDegreeChangedByStickInputPerSec;
    }

    [StructLayout(LayoutKind.Explicit, Size = 128)]
    public struct ObjCGGRootConfig
    {
        [FieldOffset(0)]  public float radius;
        [FieldOffset(16)] public Vector3 offset;
        [FieldOffset(32)] public Color8 colorActive;
        [FieldOffset(36)] public Color8 colorDeactive;
        [FieldOffset(40)] public float timerHeightOffset;
        [FieldOffset(44)] public RailCameraParam twoRailCamera;
        [FieldOffset(84)] public RailCameraParam threeRailCamera;
    }

    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public struct ObjCGGBulletNormalConfig
    {
        [FieldOffset(0)]  public float radius;
        [FieldOffset(4)]  public Color8 color;
        [FieldOffset(8)]  public float speed;
        [FieldOffset(12)] public float waitFollowTime;
        [FieldOffset(16)] public float followTime;
        [FieldOffset(20)] public float waitKillTime;
        [FieldOffset(24)] public float radiusBulletCircle;
        [FieldOffset(28)] public float followLimitAngleHorizontal;
        [FieldOffset(32)] public float followLimitAngleVertical;
        [FieldOffset(36)] public float rotateDeceleration;
        [FieldOffset(40)] public float muzzuleEffectLoopTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct ObjCGGResetBindConfig
    {
        [FieldOffset(0)] public float radius;
        [FieldOffset(4)] public Color8 color;
        [FieldOffset(8)] public float timeToReachTimer;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct ObjCGGLaserConfig
    {
        [FieldOffset(0)] public float radius;
        [FieldOffset(4)] public float heightInterval;
        [FieldOffset(8)] public Color8 color;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct ObjCGGAttachmentConfig
    {
        [FieldOffset(0)] public float radius;
        [FieldOffset(4)] public Color8 color;
    }

    [StructLayout(LayoutKind.Explicit, Size = 208)]
    public struct ObjCGGConfig
    {
        [FieldOffset(0)]   public ObjCGGRootConfig root;
        [FieldOffset(128)] public ObjCGGBulletNormalConfig bulletNormal;
        [FieldOffset(172)] public ObjCGGResetBindConfig resetBind;
        [FieldOffset(184)] public ObjCGGLaserConfig laser;
        [FieldOffset(196)] public ObjCGGAttachmentConfig attachment;
    }

}