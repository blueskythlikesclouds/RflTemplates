using System.Numerics;
using System.Runtime.InteropServices;

public class SwayParamIndivisualClass
{
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

    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public struct SwayParamNode
    {
        [FieldOffset(0)]  public bool enable;
        [FieldOffset(4)]  public float gravity;
        [FieldOffset(8)]  public float resist;
        [FieldOffset(12)] public float resist_decay;
        [FieldOffset(16)] public float recover;
        [FieldOffset(20)] public float recover_decay;
        [FieldOffset(24)] public float spring;
        [FieldOffset(28)] public float radius;
        [FieldOffset(32)] public float transmit;
        [FieldOffset(36)] public float inertia;
        [FieldOffset(40)] public float angle_limit;
        [FieldOffset(48)] public CString nodeName;
    }

    public enum CollisionType : sbyte
    {
        SWAY_COLLISTION_TYPE_NONE = 0,
        SWAY_COLLISTION_TYPE_SPHERE = 1
    }

    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public struct SwayParamCollision
    {
        [FieldOffset(0)]  public CollisionType type;
        [FieldOffset(16)] public Vector3 translation;
        [FieldOffset(32)] public Vector3 rotation;
        [FieldOffset(48)] public Vector3 scale;
        [FieldOffset(64)] public int modelPartId;
        [FieldOffset(72)] public CString modelNodeName;
    }

    [StructLayout(LayoutKind.Explicit, Size = 768)]
    public struct SwayParamNodeCollision
    {
        [FieldOffset(0)] public SwayParamCollision collisionParam__arr0;
        [FieldOffset(96)] public SwayParamCollision collisionParam__arr1;
        [FieldOffset(192)] public SwayParamCollision collisionParam__arr2;
        [FieldOffset(288)] public SwayParamCollision collisionParam__arr3;
        [FieldOffset(384)] public SwayParamCollision collisionParam__arr4;
        [FieldOffset(480)] public SwayParamCollision collisionParam__arr5;
        [FieldOffset(576)] public SwayParamCollision collisionParam__arr6;
        [FieldOffset(672)] public SwayParamCollision collisionParam__arr7;
    }

    [StructLayout(LayoutKind.Explicit, Size = 13328)]
    public struct SwayParamIndivisual
    {
        [FieldOffset(0)]    public CString idName;
        [FieldOffset(16)]   public SwayParamNode nodeParam__arr0;
        [FieldOffset(80)] public SwayParamNode nodeParam__arr1;
        [FieldOffset(144)] public SwayParamNode nodeParam__arr2;
        [FieldOffset(208)] public SwayParamNode nodeParam__arr3;
        [FieldOffset(272)] public SwayParamNode nodeParam__arr4;
        [FieldOffset(336)] public SwayParamNode nodeParam__arr5;
        [FieldOffset(400)] public SwayParamNode nodeParam__arr6;
        [FieldOffset(464)] public SwayParamNode nodeParam__arr7;
        [FieldOffset(528)] public SwayParamNode nodeParam__arr8;
        [FieldOffset(592)] public SwayParamNode nodeParam__arr9;
        [FieldOffset(656)] public SwayParamNode nodeParam__arr10;
        [FieldOffset(720)] public SwayParamNode nodeParam__arr11;
        [FieldOffset(784)] public SwayParamNode nodeParam__arr12;
        [FieldOffset(848)] public SwayParamNode nodeParam__arr13;
        [FieldOffset(912)] public SwayParamNode nodeParam__arr14;
        [FieldOffset(976)] public SwayParamNode nodeParam__arr15;
        [FieldOffset(1040)] public SwayParamNodeCollision collisionParam__arr0;
        [FieldOffset(1808)] public SwayParamNodeCollision collisionParam__arr1;
        [FieldOffset(2576)] public SwayParamNodeCollision collisionParam__arr2;
        [FieldOffset(3344)] public SwayParamNodeCollision collisionParam__arr3;
        [FieldOffset(4112)] public SwayParamNodeCollision collisionParam__arr4;
        [FieldOffset(4880)] public SwayParamNodeCollision collisionParam__arr5;
        [FieldOffset(5648)] public SwayParamNodeCollision collisionParam__arr6;
        [FieldOffset(6416)] public SwayParamNodeCollision collisionParam__arr7;
        [FieldOffset(7184)] public SwayParamNodeCollision collisionParam__arr8;
        [FieldOffset(7952)] public SwayParamNodeCollision collisionParam__arr9;
        [FieldOffset(8720)] public SwayParamNodeCollision collisionParam__arr10;
        [FieldOffset(9488)] public SwayParamNodeCollision collisionParam__arr11;
        [FieldOffset(10256)] public SwayParamNodeCollision collisionParam__arr12;
        [FieldOffset(11024)] public SwayParamNodeCollision collisionParam__arr13;
        [FieldOffset(11792)] public SwayParamNodeCollision collisionParam__arr14;
        [FieldOffset(12560)] public SwayParamNodeCollision collisionParam__arr15;
    }

}