Library "ObjEffectDebrisParameters"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct ExplosionParameter
    {
        [FieldOffset(0)]  public Vector3 centerPosOffsetMin;
        [FieldOffset(16)] public Vector3 centerPosOffsetMax;
        [FieldOffset(32)] public float range;
        [FieldOffset(36)] public float powerMin;
        [FieldOffset(40)] public float powerMax;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct ImpulseParameter
    {
        [FieldOffset(0)]  public Vector3 impulseDir;
        [FieldOffset(16)] public float powerMin;
        [FieldOffset(20)] public float powerMax;
    }

    [StructLayout(LayoutKind.Explicit, Size = 112)]
    public struct DebrisPhaseParameter
    {
        [FieldOffset(0)]  public float marginTime;
        [FieldOffset(4)]  public float nextTime;
        [FieldOffset(8)]  public float gravity;
        [FieldOffset(12)] public float moveStopTime;
        [FieldOffset(16)] public bool damping;
        [FieldOffset(32)] public ExplosionParameter explosionParam;
        [FieldOffset(80)] public ImpulseParameter impulseParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 336)]
    public struct EffectDebrisParameter
    {
        [FieldOffset(0)] public unsafe fixed byte /* DebrisPhaseParameter[3] */ _debrisPhaseParameters[336];

        public unsafe DebrisPhaseParameter* debrisPhaseParameters
        {
            get
            {
                fixed (byte* p_debrisPhaseParameters = _debrisPhaseParameters)
                    return (DebrisPhaseParameter*)p_debrisPhaseParameters;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 3360)]
    public struct ObjEffectDebrisParameters
    {
        [FieldOffset(0)] public unsafe fixed byte /* EffectDebrisParameter[10] */ _effectDebrisParameters[3360];

        public unsafe EffectDebrisParameter* effectDebrisParameters
        {
            get
            {
                fixed (byte* p_effectDebrisParameters = _effectDebrisParameters)
                    return (EffectDebrisParameter*)p_effectDebrisParameters;
            }
        }
    }

}