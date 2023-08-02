Library "PlayerParamBehindFinish"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    public enum Condition : sbyte
{
        Time = 0,
        Animation = 1
    }

    public enum Shape : sbyte
{
        Sphere = 0,
        Cylinder = 1,
        Box = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct PlayerParamAttackCollider
    {
        [FieldOffset(0)]  public Condition condition;
        [FieldOffset(1)]  public sbyte count;
        [FieldOffset(4)]  public float spanTime;
        [FieldOffset(8)]  public Shape shape;
        [FieldOffset(16)] public Vector3 shapeSize;
        [FieldOffset(32)] public Vector3 shapeOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public struct PlayerParamBehindFinish
    {
        [FieldOffset(0)]  public PlayerParamAttackCollider hit;
        [FieldOffset(48)] public float ignoreSwingingTime;
    }

}