Library "TalkEventCameraPresetParameters"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    public enum GazePositionType : sbyte
{
        Base = 0,
        Head = 1,
        Eye = 2,
        Center = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public struct TalkEventCameraPresetParameter
    {
        [FieldOffset(0)]  public bool enable;
        [FieldOffset(1)]  public GazePositionType primaryTarget;
        [FieldOffset(2)]  public GazePositionType secondaryTarget;
        [FieldOffset(4)]  public float targetRatio;
        [FieldOffset(8)]  public float rotateDegreePitch;
        [FieldOffset(12)] public float rotateDegreeYaw;
        [FieldOffset(16)] public float cameraOffsetRatio;
        [FieldOffset(20)] public float fovy;
        [FieldOffset(24)] public float targetOffsetX;
        [FieldOffset(28)] public float targetOffsetY;
        [FieldOffset(32)] public float targetOffsetZ;
    }

    [StructLayout(LayoutKind.Explicit, Size = 576)]
    public struct TalkEventCameraPresetParameters
    {
        [FieldOffset(0)] public unsafe fixed byte /* TalkEventCameraPresetParameter[16] */ _param[576];

        public unsafe TalkEventCameraPresetParameter* param
        {
            get
            {
                fixed (byte* p_param = _param)
                    return (TalkEventCameraPresetParameter*)p_param;
            }
        }
    }

}