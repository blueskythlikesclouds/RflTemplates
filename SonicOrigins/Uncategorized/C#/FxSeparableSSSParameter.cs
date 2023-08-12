using System.Numerics;
using System.Runtime.InteropServices;

public class FxSeparableSSSParameterClass
{
    [StructLayout(LayoutKind.Explicit, Size = 272)]
    public struct FxSeparableSSSParameter
    {
        [FieldOffset(0)]  public bool enable;
        [FieldOffset(4)]  public float width;
        [FieldOffset(8)]  public float normalOffset;
        [FieldOffset(12)] public float blurOffsetMax;
        [FieldOffset(16)] public Vector4 strength__arr0;
        [FieldOffset(32)] public Vector4 strength__arr1;
        [FieldOffset(48)] public Vector4 strength__arr2;
        [FieldOffset(64)] public Vector4 strength__arr3;
        [FieldOffset(80)] public Vector4 strength__arr4;
        [FieldOffset(96)] public Vector4 strength__arr5;
        [FieldOffset(112)] public Vector4 strength__arr6;
        [FieldOffset(128)] public Vector4 strength__arr7;
        [FieldOffset(144)] public Vector4 strength__arr8;
        [FieldOffset(160)] public Vector4 strength__arr9;
        [FieldOffset(176)] public Vector4 strength__arr10;
        [FieldOffset(192)] public Vector4 strength__arr11;
        [FieldOffset(208)] public Vector4 strength__arr12;
        [FieldOffset(224)] public Vector4 strength__arr13;
        [FieldOffset(240)] public Vector4 strength__arr14;
        [FieldOffset(256)] public Vector4 strength__arr15;
    }

}