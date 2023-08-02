Library "GameSkillParameter"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 3)]
    public struct SkillParam
    {
        [FieldOffset(0)] public byte unlockPoint;
        [FieldOffset(1)] public byte addUnlockPoint;
        [FieldOffset(2)] public bool present;
    }

    public enum Value : sbyte
{
        Cyloop = 0,
        Smash = 1,
        QuickCyloop = 2,
        AcceleLevel = 3,
        ChargeAttack = 4,
        RecoverySmash = 5,
        AirTrick = 6,
        SonicBoom = 7,
        Crasher = 8,
        LoopKick = 9,
        SpinSlash = 10,
        StompingAttack = 11,
        HomingShot = 12,
        CrossSlash = 13,
        AutoCombo = 14,
        Dummy0 = 15,
        Dummy1 = 16,
        Dummy2 = 17,
        Dummy3 = 18,
        Dummy4 = 19,
        Num = 20,
        NumUsed = 15,
        Invalid = -1
    }

    [StructLayout(LayoutKind.Explicit, Size = 3)]
    public struct SkillLinkSetting
    {
        [FieldOffset(0)] public bool down;
        [FieldOffset(1)] public bool left;
        [FieldOffset(2)] public bool right;
    }

    [StructLayout(LayoutKind.Explicit, Size = 5)]
    public struct SkillNodeParam
    {
        [FieldOffset(0)] public bool enable;
        [FieldOffset(1)] public Value skill;
        [FieldOffset(2)] public SkillLinkSetting link;
    }

    [StructLayout(LayoutKind.Explicit, Size = 151)]
    public struct SkillTreeParam
    {
        [FieldOffset(0)]   public unsafe fixed byte /* SkillNodeParam[30] */ _nodeParams[150];

        public unsafe SkillNodeParam* nodeParams
        {
            get
            {
                fixed (byte* p_nodeParams = _nodeParams)
                    return (SkillNodeParam*)p_nodeParams;
            }
        }

        [FieldOffset(150)] public sbyte startIndex;
    }

    [StructLayout(LayoutKind.Explicit, Size = 211)]
    public struct GameSkillParameter
    {
        [FieldOffset(0)]  public unsafe fixed byte /* SkillParam[20] */ _skillParams[60];

        public unsafe SkillParam* skillParams
        {
            get
            {
                fixed (byte* p_skillParams = _skillParams)
                    return (SkillParam*)p_skillParams;
            }
        }

        [FieldOffset(60)] public SkillTreeParam treeParams;
    }

}