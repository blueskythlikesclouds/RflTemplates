Library "ObjHackingPlayerMachineConfig"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 144)]
    public struct PlayerMachineConfig
    {
        [FieldOffset(0)]   public int baseHp;
        [FieldOffset(4)]   public int lifeCount;
        [FieldOffset(8)]   public unsafe fixed int lifeUpFailedCount[6];
        [FieldOffset(32)]  public int lifeMax;
        [FieldOffset(36)]  public float gageUpVolume;
        [FieldOffset(40)]  public float gageMax;
        [FieldOffset(44)]  public int laserNum;
        [FieldOffset(48)]  public float laserInterval;
        [FieldOffset(52)]  public float bulletInterval;
        [FieldOffset(56)]  public float moveSpeed;
        [FieldOffset(60)]  public float nodamageTime;
        [FieldOffset(64)]  public float specialmoveTime;
        [FieldOffset(68)]  public float bodyCol;
        [FieldOffset(72)]  public float barrierCol;
        [FieldOffset(76)]  public float attackRangeTime;
        [FieldOffset(80)]  public float expandAttackCol;
        [FieldOffset(96)]  public Vector3 hitPos;
        [FieldOffset(112)] public Vector3 barrierPos;
        [FieldOffset(128)] public Vector3 expandAttackPos;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct HomingLaserTrailConfig
    {
        [FieldOffset(0)] public float length;
        [FieldOffset(4)] public float minLength;
        [FieldOffset(8)] public float texWidth;
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct HomingLaserConfig
    {
        [FieldOffset(0)]  public float radius;
        [FieldOffset(4)]  public float speed;
        [FieldOffset(8)]  public float maxAccel;
        [FieldOffset(12)] public float arrivalTime;
        [FieldOffset(16)] public float lifeTime;
        [FieldOffset(20)] public float minYaw;
        [FieldOffset(24)] public float maxYaw;
        [FieldOffset(28)] public float depthVelocity;
        [FieldOffset(32)] public uint power;
        [FieldOffset(36)] public HomingLaserTrailConfig trail;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct ElementBulletConfig
    {
        [FieldOffset(0)]  public float radius;
        [FieldOffset(4)]  public float speed;
        [FieldOffset(8)]  public float scale;
        [FieldOffset(12)] public uint power;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct HackingConfig
    {
        [FieldOffset(0)] public uint dummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 224)]
    public struct ObjHackingPlayerMachineConfig
    {
        [FieldOffset(0)]   public PlayerMachineConfig machine;
        [FieldOffset(144)] public HomingLaserConfig laser;
        [FieldOffset(192)] public ElementBulletConfig bullet;
        [FieldOffset(208)] public HackingConfig hacking;
    }

}