Library "MasterTrialParameters"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct MasterTrialStageParameter
    {
        [FieldOffset(0)]  public byte prerequisite;
        [FieldOffset(4)]  public float limitTime;
        [FieldOffset(8)]  public float speedUpScale;
        [FieldOffset(12)] public float recoveryHpTime;
        [FieldOffset(16)] public uint recoveryHpPoint;
        [FieldOffset(20)] public uint limitMistake;
    }

    [StructLayout(LayoutKind.Explicit, Size = 100)]
    public struct MasterTrialParameterElement
    {
        [FieldOffset(0)] public int applicableFailedCount;
        [FieldOffset(4)] public unsafe fixed byte /* MasterTrialStageParameter[4] */ _stages[96];

        public unsafe MasterTrialStageParameter* stages
        {
            get
            {
                fixed (byte* p_stages = _stages)
                    return (MasterTrialStageParameter*)p_stages;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 324)]
    public struct MasterTrialParameters
    {
        [FieldOffset(0)]  public float subjectViewTime;
        [FieldOffset(4)]  public float readyTime;
        [FieldOffset(8)]  public float clearTime;
        [FieldOffset(12)] public float failedTime;
        [FieldOffset(16)] public float clearWaitTime;
        [FieldOffset(20)] public float failedWaitTime;
        [FieldOffset(24)] public unsafe fixed byte /* MasterTrialParameterElement[3] */ _element[300];

        public unsafe MasterTrialParameterElement* element
        {
            get
            {
                fixed (byte* p_element = _element)
                    return (MasterTrialParameterElement*)p_element;
            }
        }
    }

}