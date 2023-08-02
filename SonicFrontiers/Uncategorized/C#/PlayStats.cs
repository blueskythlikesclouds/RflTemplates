using System.Numerics;
using System.Runtime.InteropServices;

public class PlayStatsClass
{
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

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct PlayStatsSummary
    {
        [FieldOffset(0)]  public CString stagecode;
        [FieldOffset(16)] public int highTime;
        [FieldOffset(20)] public int highScore;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct PlayStatsSummaryArray
    {
        [FieldOffset(0)] public ulong pData;
        [FieldOffset(8)] public ulong Size;
    }

    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public struct PlayLog
    {
        [FieldOffset(0)]  public CString stagecode;
        [FieldOffset(16)] public CString play;
        [FieldOffset(32)] public CString option;
        [FieldOffset(48)] public Vector3 position;
        [FieldOffset(64)] public float time;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct PlayLogArray
    {
        [FieldOffset(0)] public ulong pData;
        [FieldOffset(8)] public ulong Size;
    }

    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public struct PlayStatsData
    {
        [FieldOffset(0)]  public int enemies;
        [FieldOffset(4)]  public int damages;
        [FieldOffset(8)]  public int misses;
        [FieldOffset(12)] public int retry;
        [FieldOffset(16)] public int restart;
        [FieldOffset(24)] public PlayLogArray logs;
    }

    [StructLayout(LayoutKind.Explicit, Size = 120)]
    public struct PlayStats
    {
        [FieldOffset(0)]  public CString username;
        [FieldOffset(16)] public CString time;
        [FieldOffset(32)] public PlayStatsSummaryArray summaries;
        [FieldOffset(64)] public PlayStatsData playLog;
    }

}