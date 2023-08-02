Library "DevConfigParameters"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    public enum Value : sbyte
{
        Invalid = -1,
        Sonic = 0,
        Amy = 1,
        Knuckles = 2,
        Tails = 3,
        Num = 4,
        Default = 0
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct DevConfigParameters
    {
        [FieldOffset(0)]  public bool autoSaveEnabled;
        [FieldOffset(1)]  public bool gismoEnabled;
        [FieldOffset(2)]  public bool reportEnabled;
        [FieldOffset(3)]  public bool skillTreeEnabled;
        [FieldOffset(4)]  public bool tutorialEnabled;
        [FieldOffset(5)]  public bool arcadeModeEnabled;
        [FieldOffset(6)]  public bool battleModeEnabled;
        [FieldOffset(7)]  public bool cyberChallengeEnabled;
        [FieldOffset(8)]  public bool practice;
        [FieldOffset(9)]  public bool practiceTimeLimitEnabled;
        [FieldOffset(10)] public bool creditsEnabled;
        [FieldOffset(11)] public Value character;
    }

}