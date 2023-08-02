Library "EnemyJumperSubConfig"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public struct EnemyJumperSubCommonParam
    {
        [FieldOffset(0)]  public float killWaitTime;
        [FieldOffset(4)]  public float colliderRadius;
        [FieldOffset(8)]  public float colliderHeight;
        [FieldOffset(12)] public float damageColliderRadiusOffset;
        [FieldOffset(16)] public float eyesightDistance;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct EnemyJumperSubCommonLevelParam
    {
        [FieldOffset(0)]  public int maxHealthPoint;
        [FieldOffset(4)]  public float attackRate;
        [FieldOffset(8)]  public ushort expItemNum;
        [FieldOffset(10)] public ushort exp;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct EnemyJumperSubLevelParam
    {
        [FieldOffset(0)] public int level;
        [FieldOffset(4)] public EnemyJumperSubCommonLevelParam common;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct EnemyJumperSubLevelBand
    {
        [FieldOffset(0)] public int level;
    }

    [StructLayout(LayoutKind.Explicit, Size = 120)]
    public struct EnemyJumperSubConfig
    {
        [FieldOffset(0)]   public EnemyJumperSubCommonParam commonParam;
        [FieldOffset(20)]  public unsafe fixed byte /* EnemyJumperSubLevelParam[5] */ _levelParams[80];

        public unsafe EnemyJumperSubLevelParam* levelParams
        {
            get
            {
                fixed (byte* p_levelParams = _levelParams)
                    return (EnemyJumperSubLevelParam*)p_levelParams;
            }
        }

        [FieldOffset(100)] public unsafe fixed byte /* EnemyJumperSubLevelBand[5] */ _levelBand[20];

        public unsafe EnemyJumperSubLevelBand* levelBand
        {
            get
            {
                fixed (byte* p_levelBand = _levelBand)
                    return (EnemyJumperSubLevelBand*)p_levelBand;
            }
        }
    }

}