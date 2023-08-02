Library "RecordData"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

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

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct EventDataArray
    {
        [FieldOffset(0)] public ulong pData;
        [FieldOffset(8)] public ulong Size;
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct NodeInfoInAnim
    {
        [FieldOffset(0)]  public Vector3 position;
        [FieldOffset(16)] public Quaternion rotation;
        [FieldOffset(32)] public float time;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct NodeInfoInAnimArray
    {
        [FieldOffset(0)] public ulong pData;
        [FieldOffset(8)] public ulong Size;
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct NodeData
    {
        [FieldOffset(0)]  public CString name;
        [FieldOffset(16)] public NodeInfoInAnimArray nodeInfos;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct NodeDataArray
    {
        [FieldOffset(0)] public ulong pData;
        [FieldOffset(8)] public ulong Size;
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct DeltaMotionInfoInAnim
    {
        [FieldOffset(0)]  public Vector3 position;
        [FieldOffset(16)] public Quaternion rotation;
        [FieldOffset(32)] public float time;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct DeltaMotionInfoInAnimArray
    {
        [FieldOffset(0)] public ulong pData;
        [FieldOffset(8)] public ulong Size;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct DeltaMotionData
    {
        [FieldOffset(0)] public DeltaMotionInfoInAnimArray deltaInfos;
    }

    [StructLayout(LayoutKind.Explicit, Size = 120)]
    public struct AnimData
    {
        [FieldOffset(0)]   public CString name;
        [FieldOffset(16)]  public EventDataArray eventDatas;
        [FieldOffset(48)]  public NodeDataArray nodeDatas;
        [FieldOffset(80)]  public DeltaMotionData deltaMotionData;
        [FieldOffset(112)] public float maxTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct AnimDataArray
    {
        [FieldOffset(0)] public ulong pData;
        [FieldOffset(8)] public ulong Size;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct RecordData
    {
        [FieldOffset(0)] public AnimDataArray animDatas;
    }

}