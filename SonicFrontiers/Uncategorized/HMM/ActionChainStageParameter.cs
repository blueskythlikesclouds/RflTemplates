Library "ActionChainStageParameter"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct ActionChainScoreThresholdParameter
    {
        [FieldOffset(0)]  public uint scoreS;
        [FieldOffset(4)]  public uint scoreA;
        [FieldOffset(8)]  public uint scoreB;
        [FieldOffset(12)] public uint scoreC;
    }

    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public struct ActionChainPlaceParameter
    {
        [FieldOffset(0)]  public float time;
        [FieldOffset(4)]  public ActionChainScoreThresholdParameter scoreEasy;
        [FieldOffset(20)] public ActionChainScoreThresholdParameter scoreNormal;
        [FieldOffset(36)] public ActionChainScoreThresholdParameter scoreHard;
        [FieldOffset(52)] public ActionChainScoreThresholdParameter scoreVeryHard;
    }

    [StructLayout(LayoutKind.Explicit, Size = 1088)]
    public struct ActionChainStageParameter
    {
        [FieldOffset(0)] public unsafe fixed byte /* ActionChainPlaceParameter[16] */ _placeParam[1088];

        public unsafe ActionChainPlaceParameter* placeParam
        {
            get
            {
                fixed (byte* p_placeParam = _placeParam)
                    return (ActionChainPlaceParameter*)p_placeParam;
            }
        }
    }

}