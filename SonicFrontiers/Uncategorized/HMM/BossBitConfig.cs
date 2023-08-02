Library "BossBitConfig"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct LargeBitLaserParameter
    {
        [FieldOffset(0)] public float rangeMin;
        [FieldOffset(4)] public float rangeMax;
    }

    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public struct SmallBitLaserBulletParameter
    {
        [FieldOffset(0)]  public float bulletRadius;
        [FieldOffset(4)]  public float bulletMoveLimitDistance;
        [FieldOffset(8)]  public float bitHp;
        [FieldOffset(12)] public float rotDamageAngleSpeed;
        [FieldOffset(16)] public float rotDamageSize;
        [FieldOffset(20)] public float hitDamageNotAttackTime;
        [FieldOffset(24)] public float blowoffSpeed;
        [FieldOffset(28)] public float outOfControlTime;
        [FieldOffset(32)] public float keepVelocity;
        [FieldOffset(36)] public float muzzleEffectMinTime;
        [FieldOffset(40)] public byte dropRingNum;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct CString
    {
        [FieldOffset(0)] public long pValue;

        public string Value
        {
        	get => Marshal.PtrToStringAnsi((IntPtr)pValue);
        	set => pValue = (long)Marshal.StringToHGlobalAnsi(value);
        }
    }

    public enum BulletType : byte
{
        Normal = 0,
        Normal2 = 1,
        Laser = 2,
        Homing = 3
    }

    public enum RotType : byte
{
        Rotation = 0,
        RoundTrip = 1,
        Aim = 2,
        Fix = 3
    }

    public enum CameraId : byte
{
        Invalid = 0,
        Rotate = 1,
        Trace = 2,
        Sub = 3,
        Num = 4
    }

    public enum FormationId : byte
{
        Default = 0,
        FanShaped = 1
    }

    [StructLayout(LayoutKind.Explicit, Size = 100)]
    public struct SmallBitAttackPatternParameter
    {
        [FieldOffset(0)]  public bool isParry;
        [FieldOffset(4)]  public float time;
        [FieldOffset(8)]  public float angleSpeed;
        [FieldOffset(12)] public BulletType bulletType;
        [FieldOffset(13)] public RotType rotType;
        [FieldOffset(16)] public float rotAngle;
        [FieldOffset(20)] public float phaseRotTime;
        [FieldOffset(24)] public uint shootNum;
        [FieldOffset(28)] public float shootSpeed;
        [FieldOffset(32)] public float addShootSpeed;
        [FieldOffset(36)] public float shootAccel;
        [FieldOffset(40)] public float shootAccelMax;
        [FieldOffset(44)] public float shootAccelDelay;
        [FieldOffset(48)] public byte wayNum;
        [FieldOffset(52)] public float wayAngle;
        [FieldOffset(56)] public float shootTime;
        [FieldOffset(60)] public float phaseShootTime;
        [FieldOffset(64)] public uint periodShootCool;
        [FieldOffset(68)] public float periodShootCoolTime;
        [FieldOffset(72)] public float homingAccuracy;
        [FieldOffset(76)] public float homingDelay;
        [FieldOffset(80)] public float homingLimitAngle;
        [FieldOffset(84)] public bool isHomingLowFly;
        [FieldOffset(85)] public CameraId overlookingId;
        [FieldOffset(88)] public float waveRotationSpeed;
        [FieldOffset(92)] public float flyMoveSpeed;
        [FieldOffset(96)] public FormationId formationId;
    }

    [StructLayout(LayoutKind.Explicit, Size = 120)]
    public struct SmallBitSetPatternParameter
    {
        [FieldOffset(0)]  public CString text;
        [FieldOffset(16)] public SmallBitAttackPatternParameter param;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct SmallBitFormationFanShaped
    {
        [FieldOffset(0)]  public float distance;
        [FieldOffset(4)]  public float height;
        [FieldOffset(8)]  public float radius;
        [FieldOffset(12)] public float angleMax;
    }

    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public struct SmallBitFormationParameter
    {
        [FieldOffset(0)]  public float changeTime;
        [FieldOffset(4)]  public float changeDelay;
        [FieldOffset(8)]  public float changeOffsetHeight;
        [FieldOffset(12)] public SmallBitFormationFanShaped fanShaped;
    }

    [StructLayout(LayoutKind.Explicit, Size = 7768)]
    public struct BossBitConfig
    {
        [FieldOffset(0)]    public LargeBitLaserParameter largeBitLaserParam;
        [FieldOffset(8)]    public SmallBitLaserBulletParameter smallBitLaserParam;
        [FieldOffset(56)]   public unsafe fixed byte /* SmallBitSetPatternParameter[64] */ _smallBitPatternDatas[7680];

        public unsafe SmallBitSetPatternParameter* smallBitPatternDatas
        {
            get
            {
                fixed (byte* p_smallBitPatternDatas = _smallBitPatternDatas)
                    return (SmallBitSetPatternParameter*)p_smallBitPatternDatas;
            }
        }

        [FieldOffset(7736)] public SmallBitFormationParameter smallBitFormation;
    }

}