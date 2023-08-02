Library "ElectricLineParameter"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct ElectricLineConnectData
    {
        [FieldOffset(0)] public int challengeNo0;
        [FieldOffset(4)] public int challengeNo1;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct ElectricLineConnectParameter
    {
        [FieldOffset(0)] public int challengeNo0;
        [FieldOffset(4)] public int challengeNo1;
        [FieldOffset(8)] public unsafe fixed byte /* ElectricLineConnectData[3] */ _data[24];

        public unsafe ElectricLineConnectData* data
        {
            get
            {
                fixed (byte* p_data = _data)
                    return (ElectricLineConnectData*)p_data;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 6400)]
    public struct ElectricLineParameter
    {
        [FieldOffset(0)] public unsafe fixed byte /* ElectricLineConnectParameter[200] */ _connect[6400];

        public unsafe ElectricLineConnectParameter* connect
        {
            get
            {
                fixed (byte* p_connect = _connect)
                    return (ElectricLineConnectParameter*)p_connect;
            }
        }
    }

}