using System.Numerics;
using System.Runtime.InteropServices;

public class HackingEnemyParametersClass
{
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public struct HackingEnemyParameterNormal
    {
        [FieldOffset(0)]  public ushort hpS;
        [FieldOffset(2)]  public ushort hpM;
        [FieldOffset(4)]  public ushort hpL;
        [FieldOffset(8)]  public float colliderRadius;
        [FieldOffset(12)] public float colliderHeight;
        [FieldOffset(16)] public float modelScale;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct HackingEnemyParameterCore
    {
        [FieldOffset(0)] public float colliderRadius;
        [FieldOffset(4)] public float colliderHeight;
        [FieldOffset(8)] public float modelScale;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct HackingEnemyParameters
    {
        [FieldOffset(0)]  public HackingEnemyParameterNormal normalEnemyParam;
        [FieldOffset(20)] public HackingEnemyParameterCore coreEnemyParam;
    }

}