Library "PracticeParameters"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    public enum Checker : sbyte
{
        InvalidChecker = -1,
        CountActions = 0,
        CountAirTrick = 1,
        CountControlCamera = 2,
        CountInfinityCombo = 3,
        CountFiveCombo = 4,
        NumCheckers = 5
    }

    public enum Type : byte
{
        None = 0,
        ControlCamera = 1,
        Cyloop = 2,
        QuickCyloop = 3,
        FocusCamera = 4,
        Parry = 5,
        Avoid = 6,
        AcceleCombo = 7,
        Crasher = 8,
        HomingShot = 9,
        StompingAttack = 10,
        SonicBoom = 11,
        SpinSlash = 12,
        LoopKick = 13,
        CrossSlash = 14,
        ChargeAttack = 15,
        Smash = 16,
        RecoverySmash = 17,
        Jump = 18,
        DoubleJump = 19,
        HomingAttack = 20,
        Boost = 21,
        Stomping = 22,
        BoundStomping = 23,
        AirBoost = 24,
        QuickStep = 25,
        LightDash = 26,
        DropDash = 27,
        Sliding = 28,
        WallRun = 29,
        Discontinued = 30,
        AirTrick = 31,
        AirTrickEnd = 32,
        CancelHomingAttackBounceStomping = 33,
        CancelAirBoostStomping = 34,
        Squat = 35,
        SpinBoostCharge = 36,
        SpinBoost = 37,
        RunToSpinBoost = 38,
        Num = 39
    }

    public enum Judge : sbyte
{
        Succeed = 0,
        Failed = 1,
        Skiped = 2,
        Waiting = 3,
        Unknown = 4,
        NumJudges = 5
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

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct PracticeAction
    {
        [FieldOffset(0)]  public Type action;
        [FieldOffset(1)]  public Judge dummy;
        [FieldOffset(8)]  public ulong skipableActions;
        [FieldOffset(16)] public CString label;
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct PracticePrerequisite
    {
        [FieldOffset(0)]  public uint skill;
        [FieldOffset(8)]  public ulong clearedSubject;
        [FieldOffset(16)] public ulong clearedSubject2;
        [FieldOffset(24)] public ulong clearedSubject3;
        [FieldOffset(32)] public ulong clearedSubject4;
        [FieldOffset(40)] public bool unlockSpinBoost;
    }

    [StructLayout(LayoutKind.Explicit, Size = 264)]
    public struct PracticeSubject
    {
        [FieldOffset(0)]   public Checker checker;
        [FieldOffset(8)]   public unsafe fixed byte /* PracticeAction[6] */ _actions[192];

        public unsafe PracticeAction* actions
        {
            get
            {
                fixed (byte* p_actions = _actions)
                    return (PracticeAction*)p_actions;
            }
        }

        [FieldOffset(200)] public int count;
        [FieldOffset(208)] public PracticePrerequisite prerequisite;
        [FieldOffset(256)] public byte options;
    }

    [StructLayout(LayoutKind.Explicit, Size = 160)]
    public struct PracticeText
    {
        [FieldOffset(0)] public unsafe fixed byte /* CString[10] */ _labels[2550];

        public unsafe CString* labels
        {
            get
            {
                fixed (byte* p_labels = _labels)
                    return (CString*)p_labels;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public struct PracticeTime
    {
        [FieldOffset(0)]  public float readyTime;
        [FieldOffset(4)]  public float countTime;
        [FieldOffset(8)]  public float subjectViewTime;
        [FieldOffset(12)] public float clearedPostTime;
        [FieldOffset(16)] public float fadeoutWaitTime;
        [FieldOffset(20)] public float rebuildWaitTime1;
        [FieldOffset(24)] public float rebuildWaitTime2;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct PracticeTipsPrerequisite
    {
        [FieldOffset(0)] public uint skill;
        [FieldOffset(4)] public bool tutorialCleared;
        [FieldOffset(5)] public bool unlockArcadeMode;
        [FieldOffset(6)] public bool unlockCyberPowerBoost;
        [FieldOffset(7)] public bool unlockVeryHardMode;
        [FieldOffset(8)] public bool unlockStrongNewGame;
        [FieldOffset(9)] public bool unlockSpinBoost;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct PracticeTips
    {
        [FieldOffset(0)] public PracticeTipsPrerequisite prerequisite;
    }

    [StructLayout(LayoutKind.Explicit, Size = 220)]
    public struct PracticeSet
    {
        [FieldOffset(0)]  public unsafe fixed sbyte subjects[20];
        [FieldOffset(20)] public unsafe fixed short tips[100];
    }

    [StructLayout(LayoutKind.Explicit, Size = 73888)]
    public struct PracticeParameters
    {
        [FieldOffset(0)]     public unsafe fixed byte /* PracticeSubject[200] */ _subjects[52800];

        public unsafe PracticeSubject* subjects
        {
            get
            {
                fixed (byte* p_subjects = _subjects)
                    return (PracticeSubject*)p_subjects;
            }
        }

        [FieldOffset(52800)] public PracticeText text;
        [FieldOffset(52960)] public PracticeTime time;
        [FieldOffset(52988)] public float notifyTime;
        [FieldOffset(52992)] public unsafe fixed byte /* PracticeTips[256] */ _tips[3072];

        public unsafe PracticeTips* tips
        {
            get
            {
                fixed (byte* p_tips = _tips)
                    return (PracticeTips*)p_tips;
            }
        }

        [FieldOffset(56064)] public float tipsMinViewTime;
        [FieldOffset(56068)] public unsafe fixed byte /* PracticeSet[81] */ _sets[17820];

        public unsafe PracticeSet* sets
        {
            get
            {
                fixed (byte* p_sets = _sets)
                    return (PracticeSet*)p_sets;
            }
        }
    }

}