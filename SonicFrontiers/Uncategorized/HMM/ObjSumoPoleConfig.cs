Library "ObjSumoPoleConfig"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public struct ObjSumoPoleColliderConfig
    {
        [FieldOffset(0)]  public float baseHeight;
        [FieldOffset(4)]  public float baseRadius;
        [FieldOffset(8)]  public float baseOffset;
        [FieldOffset(12)] public float poleHeight;
        [FieldOffset(16)] public float poleRadius;
        [FieldOffset(20)] public float rigidAdditionalHeight;
        [FieldOffset(24)] public float ropeThicknessRigid;
        [FieldOffset(28)] public float ropeThicknessDamage;
        [FieldOffset(32)] public float ropeThicknessArea;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct ObjSumoPoleSlingShotLookDownCameraConfig
    {
        [FieldOffset(0)] public float interpolationTime;
        [FieldOffset(4)] public float height;
        [FieldOffset(8)] public float fovy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 76)]
    public struct ObjSumoPoleSlingShotConfig
    {
        [FieldOffset(0)]  public float shotGuideMoveDistance;
        [FieldOffset(4)]  public float shotRaycastLength;
        [FieldOffset(8)]  public float sweepCapsuleHeight;
        [FieldOffset(12)] public float shotMoveLengthMax;
        [FieldOffset(16)] public int shotReflectCountMax;
        [FieldOffset(20)] public int shotReflectOwnerCountMax;
        [FieldOffset(24)] public float shotOffset;
        [FieldOffset(28)] public float shotDirAngleLimit;
        [FieldOffset(32)] public float shotDirAngleChangeSpeed;
        [FieldOffset(36)] public float shotSpeedMin;
        [FieldOffset(40)] public float shotSpeedMax;
        [FieldOffset(44)] public float shotSpeedAdd;
        [FieldOffset(48)] public float cancelSpeed;
        [FieldOffset(52)] public float bendPullLength;
        [FieldOffset(56)] public float aimTimeScale;
        [FieldOffset(60)] public float aimLimitTime;
        [FieldOffset(64)] public ObjSumoPoleSlingShotLookDownCameraConfig cameraLookDown;
    }

    public struct Color8
    {
        public byte A;
        public byte R;
        public byte G;
        public byte B;
    }

    [StructLayout(LayoutKind.Explicit, Size = 52)]
    public struct ObjSumoPoleSlingshotLineConfig
    {
        [FieldOffset(0)]  public float width;
        [FieldOffset(4)]  public float maxDistance;
        [FieldOffset(8)]  public float tilingDistance;
        [FieldOffset(12)] public float uvScrollSpeedMin;
        [FieldOffset(16)] public float uvScrollSpeedMax;
        [FieldOffset(20)] public int reflectCountSpeedMax;
        [FieldOffset(24)] public unsafe fixed byte /* Color8[5] */ _colors[1275];

        public unsafe Color8* colors
        {
            get
            {
                fixed (byte* p_colors = _colors)
                    return (Color8*)p_colors;
            }
        }

        [FieldOffset(44)] public float colorIntensity;
        [FieldOffset(48)] public bool colorGradation;
        [FieldOffset(49)] public bool colorChangeAll;
    }

    public struct ColorF
    {
        public float A;
        public float R;
        public float G;
        public float B;
    }

    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public struct ObjSumoPoleRopeElectricConfig
    {
        [FieldOffset(0)]  public float width;
        [FieldOffset(4)]  public float tilingDistance;
        [FieldOffset(8)]  public float fluctuationPeriod;
        [FieldOffset(12)] public float fluctuationAmplitude;
        [FieldOffset(16)] public float uvScrollSpeed;
        [FieldOffset(20)] public ColorF colorPrimary;
        [FieldOffset(36)] public Color8 colorVertexEdge;
        [FieldOffset(40)] public Color8 colorVertexCenter;
        [FieldOffset(44)] public float colorIntensityAnimTime;
        [FieldOffset(48)] public float colorIntensityMin;
        [FieldOffset(52)] public float colorIntensityMax;
        [FieldOffset(56)] public float patternChangeIntervalTime;
        [FieldOffset(60)] public float edgeWidthScale;
        [FieldOffset(64)] public float edgeWidthScaleLength;
        [FieldOffset(68)] public float roll;
    }

    [StructLayout(LayoutKind.Explicit, Size = 108)]
    public struct ObjSumoPoleRopeConfig
    {
        [FieldOffset(0)]  public float timeAppear;
        [FieldOffset(4)]  public float timeDisappear;
        [FieldOffset(8)]  public int count;
        [FieldOffset(12)] public float swingWidthMin;
        [FieldOffset(16)] public float swingWidthMax;
        [FieldOffset(20)] public float swingWidthReductionRate;
        [FieldOffset(24)] public float swingTime;
        [FieldOffset(28)] public float swingPeriod;
        [FieldOffset(32)] public float swingReturnSlowTime;
        [FieldOffset(36)] public ObjSumoPoleRopeElectricConfig electric;
    }

    [StructLayout(LayoutKind.Explicit, Size = 276)]
    public struct ObjSumoPoleConfig
    {
        [FieldOffset(0)]   public int electricDamageToEnemy;
        [FieldOffset(4)]   public ObjSumoPoleColliderConfig collider;
        [FieldOffset(40)]  public ObjSumoPoleSlingShotConfig slingShot;
        [FieldOffset(116)] public ObjSumoPoleSlingshotLineConfig line;
        [FieldOffset(168)] public ObjSumoPoleRopeConfig rope;
    }

}