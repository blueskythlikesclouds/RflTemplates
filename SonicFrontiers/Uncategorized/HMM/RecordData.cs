using System.Numerics;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size=16)]
public struct CString
{
    [FieldOffset(0)] public long pValue;

    public string Value
    {
    	get => Marshal.PtrToStringAnsi((IntPtr)pValue);
    	set => pValue = (long)Marshal.StringToHGlobalAnsi(value);
    }
}

public enum EventType : sbyte
{
    KEY = 0,
    INTERVAL = 1
}

[StructLayout(LayoutKind.Explicit, Size = 32)]
public struct EventData
{
    [FieldOffset(0)]  public CString name;
    [FieldOffset(16)] public EventType type;
    [FieldOffset(20)] public float inTime;
    [FieldOffset(24)] public float outTime;
}

[StructLayout(LayoutKind.Explicit, Size = 48)]
public struct NodeInfoInAnim
{
    [FieldOffset(0)]  public Vector3 position;
    [FieldOffset(16)] public Quaternion rotation;
    [FieldOffset(32)] public float time;
}

[StructLayout(LayoutKind.Explicit, Size = 48)]
public struct NodeData
{
    [FieldOffset(0)]  public CString name;
    [FieldOffset(16)] public NodeInfoInAnim nodeInfos;
}

[StructLayout(LayoutKind.Explicit, Size = 48)]
public struct DeltaMotionInfoInAnim
{
    [FieldOffset(0)]  public Vector3 position;
    [FieldOffset(16)] public Quaternion rotation;
    [FieldOffset(32)] public float time;
}

[StructLayout(LayoutKind.Explicit, Size = 32)]
public struct DeltaMotionData
{
    [FieldOffset(0)] public DeltaMotionInfoInAnim deltaInfos;
}

[StructLayout(LayoutKind.Explicit, Size = 120)]
public struct AnimData
{
    [FieldOffset(0)]   public CString name;
    [FieldOffset(16)]  public EventData eventDatas;
    [FieldOffset(48)]  public NodeData nodeDatas;
    [FieldOffset(80)]  public DeltaMotionData deltaMotionData;
    [FieldOffset(112)] public float maxTime;
}

[StructLayout(LayoutKind.Explicit, Size = 32)]
public struct RecordData
{
    [FieldOffset(0)] public AnimData animDatas;
}

