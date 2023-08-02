Library "MeteorShowerParameter"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public struct MeteorShowerEffectParameter
    {
        [FieldOffset(0)]  public float spawnIntervalMax;
        [FieldOffset(4)]  public float spawnIntervalMin;
        [FieldOffset(8)]  public float spawnHeightMax;
        [FieldOffset(12)] public float spawnHeightMin;
        [FieldOffset(16)] public float spawnHorizonMax;
        [FieldOffset(20)] public float spawnHorizonMin;
        [FieldOffset(24)] public float speedMax;
        [FieldOffset(28)] public float speedMin;
        [FieldOffset(32)] public float lengthMax;
        [FieldOffset(36)] public float lengthMin;
        [FieldOffset(40)] public float width;
        [FieldOffset(44)] public float angleMax;
        [FieldOffset(48)] public float angleMin;
        [FieldOffset(52)] public float moveTimeMax;
        [FieldOffset(56)] public float moveTimeMin;
        [FieldOffset(60)] public float fadeTimeMax;
        [FieldOffset(64)] public float fadeTimeMin;
        [FieldOffset(68)] public float spawnAngle;
        [FieldOffset(80)] public Vector3 color;
    }

    public enum Symbol : sbyte
{
        Invalid = -1,
        Seven = 0,
        Bar = 1,
        Fruit = 2,
        Bell = 3,
        NumSymbols = 4
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct ReelParam
    {
        [FieldOffset(0)]  public unsafe fixed byte /* Symbol[16] */ _symbols[16];

        public unsafe Symbol* symbols
        {
            get
            {
                fixed (byte* p_symbols = _symbols)
                    return (Symbol*)p_symbols;
            }
        }

        [FieldOffset(16)] public float spinSpeedMin;
        [FieldOffset(20)] public float spinSpeedMax;
        [FieldOffset(24)] public float autoStopTimeMin;
        [FieldOffset(28)] public float autoStopTimeMax;
    }

    public enum RateInfo_Symbol : sbyte
{
        RateInfo_Symbol_Invalid = -1,
        RateInfo_Symbol_Seven = 0,
        RateInfo_Symbol_Bar = 1,
        RateInfo_Symbol_Fruit = 2,
        RateInfo_Symbol_Bell = 3,
        RateInfo_Symbol_NumSymbols = 4
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct RateInfo
    {
        [FieldOffset(0)] public unsafe fixed byte /* RateInfo_Symbol[3] */ _symbols[3];

        public unsafe RateInfo_Symbol* symbols
        {
            get
            {
                fixed (byte* p_symbols = _symbols)
                    return (RateInfo_Symbol*)p_symbols;
            }
        }

        [FieldOffset(4)] public float rate;
    }

    public enum CeilingInfo_Symbol : sbyte
{
        CeilingInfo_Symbol_Invalid = -1,
        CeilingInfo_Symbol_Seven = 0,
        CeilingInfo_Symbol_Bar = 1,
        CeilingInfo_Symbol_Fruit = 2,
        CeilingInfo_Symbol_Bell = 3,
        CeilingInfo_Symbol_NumSymbols = 4
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct CeilingInfo
    {
        [FieldOffset(0)] public unsafe fixed byte /* CeilingInfo_Symbol[3] */ _symbols[3];

        public unsafe CeilingInfo_Symbol* symbols
        {
            get
            {
                fixed (byte* p_symbols = _symbols)
                    return (CeilingInfo_Symbol*)p_symbols;
            }
        }

        [FieldOffset(4)] public uint rollCount;
    }

    public enum PayoutInfo_Symbol : sbyte
{
        PayoutInfo_Symbol_Invalid = -1,
        PayoutInfo_Symbol_Seven = 0,
        PayoutInfo_Symbol_Bar = 1,
        PayoutInfo_Symbol_Fruit = 2,
        PayoutInfo_Symbol_Bell = 3,
        PayoutInfo_Symbol_NumSymbols = 4
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct PayoutInfo
    {
        [FieldOffset(0)] public unsafe fixed byte /* PayoutInfo_Symbol[3] */ _symbols[3];

        public unsafe PayoutInfo_Symbol* symbols
        {
            get
            {
                fixed (byte* p_symbols = _symbols)
                    return (PayoutInfo_Symbol*)p_symbols;
            }
        }

        [FieldOffset(4)] public uint payout;
    }

    [StructLayout(LayoutKind.Explicit, Size = 216)]
    public struct ObjBonusSlotConfig
    {
        [FieldOffset(0)]   public unsafe fixed byte /* ReelParam[3] */ _reelParams[96];

        public unsafe ReelParam* reelParams
        {
            get
            {
                fixed (byte* p_reelParams = _reelParams)
                    return (ReelParam*)p_reelParams;
            }
        }

        [FieldOffset(96)]  public float spinInterval;
        [FieldOffset(100)] public unsafe fixed byte /* RateInfo[4] */ _rateInfos[32];

        public unsafe RateInfo* rateInfos
        {
            get
            {
                fixed (byte* p_rateInfos = _rateInfos)
                    return (RateInfo*)p_rateInfos;
            }
        }

        [FieldOffset(132)] public unsafe fixed byte /* CeilingInfo[4] */ _ceilingInfos[32];

        public unsafe CeilingInfo* ceilingInfos
        {
            get
            {
                fixed (byte* p_ceilingInfos = _ceilingInfos)
                    return (CeilingInfo*)p_ceilingInfos;
            }
        }

        [FieldOffset(164)] public unsafe fixed byte /* PayoutInfo[4] */ _payoutInfos[32];

        public unsafe PayoutInfo* payoutInfos
        {
            get
            {
                fixed (byte* p_payoutInfos = _payoutInfos)
                    return (PayoutInfo*)p_payoutInfos;
            }
        }

        [FieldOffset(196)] public uint payoutOnBlank;
        [FieldOffset(200)] public bool WinEvenWithPush;
        [FieldOffset(204)] public float retrySpeed;
        [FieldOffset(208)] public float backSpeed;
        [FieldOffset(212)] public float stepSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 352)]
    public struct MeteorShowerParameter
    {
        [FieldOffset(0)]   public float rangeFromSonicObjectsDontRespawn;
        [FieldOffset(4)]   public uint intervalDay;
        [FieldOffset(8)]   public uint startHour;
        [FieldOffset(12)]  public uint startMinute;
        [FieldOffset(16)]  public uint durationHour;
        [FieldOffset(20)]  public uint durationMinute;
        [FieldOffset(32)]  public MeteorShowerEffectParameter effect;
        [FieldOffset(128)] public ObjBonusSlotConfig bonusSlotConfig;
    }

}