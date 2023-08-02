Library "UIFishiGuideConfig"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct FishCameraParam
    {
        [FieldOffset(0)]  public Vector3 position;
        [FieldOffset(16)] public Vector3 target;
        [FieldOffset(32)] public float fovy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 5040)]
    public struct UIFishiGuideConfig
    {
        [FieldOffset(0)] public unsafe fixed byte /* FishCameraParam[105] */ _fishList[5040];

        public unsafe FishCameraParam* fishList
        {
            get
            {
                fixed (byte* p_fishList = _fishList)
                    return (FishCameraParam*)p_fishList;
            }
        }
    }

}