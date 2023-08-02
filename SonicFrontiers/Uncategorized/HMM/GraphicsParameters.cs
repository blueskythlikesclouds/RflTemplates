Library "GraphicsParameters"
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

    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public struct AuraEffectLerpNode
    {
        [FieldOffset(0)]  public float distance;
        [FieldOffset(4)]  public float noiseTextureScrollSpeed;
        [FieldOffset(8)]  public float blurScale;
        [FieldOffset(12)] public float colorGain;
        [FieldOffset(16)] public float noiseGain;
    }

    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public struct AuraEffectLerpParameter
    {
        [FieldOffset(0)]  public CString name;
        [FieldOffset(16)] public unsafe fixed byte /* AuraEffectLerpNode[2] */ _node[40];

        public unsafe AuraEffectLerpNode* node
        {
            get
            {
                fixed (byte* p_node = _node)
                    return (AuraEffectLerpNode*)p_node;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 224)]
    public struct AuraEffectParameters
    {
        [FieldOffset(0)] public unsafe fixed byte /* AuraEffectLerpParameter[4] */ __params[224];

        public unsafe AuraEffectLerpParameter* _params
        {
            get
            {
                fixed (byte* p__params = __params)
                    return (AuraEffectLerpParameter*)p__params;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct EffectParameters
    {
        [FieldOffset(0)] public float localLightIntensityScale;
        [FieldOffset(4)] public bool dropPriorityEnabled;
        [FieldOffset(5)] public sbyte dropPriority;
    }

    [StructLayout(LayoutKind.Explicit, Size = 5)]
    public struct WeatherBlockParameter
    {
        [FieldOffset(0)] public unsafe fixed byte blockWeights[5];
    }

    [StructLayout(LayoutKind.Explicit, Size = 30)]
    public struct WeatherTypeParameter
    {
        [FieldOffset(0)] public unsafe fixed byte transitWeights[5];
        [FieldOffset(5)] public unsafe fixed byte /* WeatherBlockParameter[5] */ _blockParams[25];

        public unsafe WeatherBlockParameter* blockParams
        {
            get
            {
                fixed (byte* p_blockParams = _blockParams)
                    return (WeatherBlockParameter*)p_blockParams;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 2)]
    public struct WeatherTimeParameter
    {
        [FieldOffset(0)] public byte hour;
        [FieldOffset(1)] public byte minute;
    }

    [StructLayout(LayoutKind.Explicit, Size = 10)]
    public struct WeatherTimeControlParameter
    {
        [FieldOffset(0)] public WeatherTimeParameter sunriseBeginTime;
        [FieldOffset(2)] public WeatherTimeParameter dayBeginTime;
        [FieldOffset(4)] public WeatherTimeParameter sunsetBeginTime;
        [FieldOffset(6)] public WeatherTimeParameter nightBeginTime;
        [FieldOffset(8)] public WeatherTimeParameter blockTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 160)]
    public struct WeatherParameters
    {
        [FieldOffset(0)]   public unsafe fixed byte /* WeatherTypeParameter[5] */ _type[150];

        public unsafe WeatherTypeParameter* type
        {
            get
            {
                fixed (byte* p_type = _type)
                    return (WeatherTypeParameter*)p_type;
            }
        }

        [FieldOffset(150)] public WeatherTimeControlParameter timeControl;
    }

    [StructLayout(LayoutKind.Explicit, Size = 392)]
    public struct GraphicsParameters
    {
        [FieldOffset(0)]   public AuraEffectParameters aura;
        [FieldOffset(224)] public EffectParameters effect;
        [FieldOffset(232)] public WeatherParameters weather;
    }

}