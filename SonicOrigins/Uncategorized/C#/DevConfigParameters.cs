using System.Numerics;
using System.Runtime.InteropServices;

public class DevConfigParametersClass
{
    public enum ReplayMode : sbyte
    {
        REPLAY_MODE_OFF = 0,
        REPLAY_MODE_RECORD = 1,
        REPLAY_MODE_PLAY = 2,
        REPLAY_MODE_GHOST = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 6)]
    public struct DevConfigParameters
    {
        [FieldOffset(0)] public bool autoSaveEnabled;
        [FieldOffset(1)] public bool gismoEnabled;
        [FieldOffset(2)] public bool reportEnabled;
        [FieldOffset(3)] public bool skillTreeEnabled;
        [FieldOffset(4)] public bool tutorialEnabled;
        [FieldOffset(5)] public ReplayMode replayMode;
    }

}