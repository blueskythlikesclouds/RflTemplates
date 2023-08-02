Library "ObjQuestBoxParameter"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public struct ObjQuestBoxParameter
    {
        [FieldOffset(0)]  public float dropBoxProbabilly;
        [FieldOffset(4)]  public float boxHpSmall;
        [FieldOffset(8)]  public float boxHpMiddle;
        [FieldOffset(12)] public float boxHpLarge;
        [FieldOffset(16)] public float friction;
        [FieldOffset(20)] public float mass;
        [FieldOffset(24)] public float gravity;
        [FieldOffset(28)] public float linearDamping;
        [FieldOffset(32)] public float angularDamping;
        [FieldOffset(48)] public Vector3 maxSpeed;
    }

}