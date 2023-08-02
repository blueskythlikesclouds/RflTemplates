Library "BulletPatternSetParameters"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public struct HackingBulletParameter
    {
        [FieldOffset(0)]  public float bulletRadius;
        [FieldOffset(4)]  public float bulletModelScale;
        [FieldOffset(8)]  public float bulletRadiusLastBoss;
        [FieldOffset(12)] public float bulletModelScaleLastBoss;
        [FieldOffset(16)] public float bulletModelOffsetRateLastBoss;
        [FieldOffset(20)] public float laserNormalRadius;
        [FieldOffset(24)] public float laserThickRadius;
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

    public enum Type : byte
{
        BulletFixed = 0,
        BulletAimPlayer = 1,
        LaserNormal = 2,
        LaserThick = 3,
        LaserAimPlayer = 4
    }

    public enum ElementType : byte
{
        Hacking1 = 0,
        Hacking2 = 1
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct AnimationParameter
    {
        [FieldOffset(0)] public float angle;
        [FieldOffset(4)] public float time;
    }

    [StructLayout(LayoutKind.Explicit, Size = 104)]
    public struct BulletPatternParameter
    {
        [FieldOffset(0)]  public Type type;
        [FieldOffset(1)]  public ElementType element;
        [FieldOffset(4)]  public float startAngle;
        [FieldOffset(8)]  public float endAngle;
        [FieldOffset(12)] public byte shootNum;
        [FieldOffset(16)] public float shootSpeed;
        [FieldOffset(20)] public byte wayNum;
        [FieldOffset(24)] public float wayAngle;
        [FieldOffset(28)] public float laserLength;
        [FieldOffset(32)] public float lifeTime;
        [FieldOffset(36)] public bool animation;
        [FieldOffset(40)] public unsafe fixed byte /* AnimationParameter[8] */ _animParam[64];

        public unsafe AnimationParameter* animParam
        {
            get
            {
                fixed (byte* p_animParam = _animParam)
                    return (AnimationParameter*)p_animParam;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 120)]
    public struct BulletPatternSetParameter
    {
        [FieldOffset(0)]  public CString name;
        [FieldOffset(16)] public BulletPatternParameter param;
    }

    [StructLayout(LayoutKind.Explicit, Size = 30752)]
    public struct BulletPatternSetParameters
    {
        [FieldOffset(0)]  public HackingBulletParameter bulletParam;
        [FieldOffset(32)] public unsafe fixed byte /* BulletPatternSetParameter[256] */ _data[30720];

        public unsafe BulletPatternSetParameter* data
        {
            get
            {
                fixed (byte* p_data = _data)
                    return (BulletPatternSetParameter*)p_data;
            }
        }
    }

}