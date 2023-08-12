using System.Numerics;
using System.Runtime.InteropServices;

public class OcclusionCapsuleListClass
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

    public enum VolumeType : sbyte
    {
        VOLUME_SPHERE = 0,
        VOLUME_CAPSULE = 1
    }

    public enum LODLevel : sbyte
    {
        LOD_HIGH = 0,
        LOD_MIDDLE = 1,
        LOD_LOW = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 112)]
    public struct CapsuleParam
    {
        [FieldOffset(0)]   public CString type;
        [FieldOffset(16)]  public VolumeType volume;
        [FieldOffset(20)]  public int priority;
        [FieldOffset(32)]  public Vector3 translation;
        [FieldOffset(48)]  public Vector3 rotation;
        [FieldOffset(64)]  public Vector3 scale;
        [FieldOffset(80)]  public Vector3 rate;
        [FieldOffset(96)]  public float radius;
        [FieldOffset(100)] public LODLevel lod;
    }

    [StructLayout(LayoutKind.Explicit, Size = 7168)]
    public struct OcclusionCapsuleList
    {
        [FieldOffset(0)] public CapsuleParam capsules__arr0;
        [FieldOffset(112)] public CapsuleParam capsules__arr1;
        [FieldOffset(224)] public CapsuleParam capsules__arr2;
        [FieldOffset(336)] public CapsuleParam capsules__arr3;
        [FieldOffset(448)] public CapsuleParam capsules__arr4;
        [FieldOffset(560)] public CapsuleParam capsules__arr5;
        [FieldOffset(672)] public CapsuleParam capsules__arr6;
        [FieldOffset(784)] public CapsuleParam capsules__arr7;
        [FieldOffset(896)] public CapsuleParam capsules__arr8;
        [FieldOffset(1008)] public CapsuleParam capsules__arr9;
        [FieldOffset(1120)] public CapsuleParam capsules__arr10;
        [FieldOffset(1232)] public CapsuleParam capsules__arr11;
        [FieldOffset(1344)] public CapsuleParam capsules__arr12;
        [FieldOffset(1456)] public CapsuleParam capsules__arr13;
        [FieldOffset(1568)] public CapsuleParam capsules__arr14;
        [FieldOffset(1680)] public CapsuleParam capsules__arr15;
        [FieldOffset(1792)] public CapsuleParam capsules__arr16;
        [FieldOffset(1904)] public CapsuleParam capsules__arr17;
        [FieldOffset(2016)] public CapsuleParam capsules__arr18;
        [FieldOffset(2128)] public CapsuleParam capsules__arr19;
        [FieldOffset(2240)] public CapsuleParam capsules__arr20;
        [FieldOffset(2352)] public CapsuleParam capsules__arr21;
        [FieldOffset(2464)] public CapsuleParam capsules__arr22;
        [FieldOffset(2576)] public CapsuleParam capsules__arr23;
        [FieldOffset(2688)] public CapsuleParam capsules__arr24;
        [FieldOffset(2800)] public CapsuleParam capsules__arr25;
        [FieldOffset(2912)] public CapsuleParam capsules__arr26;
        [FieldOffset(3024)] public CapsuleParam capsules__arr27;
        [FieldOffset(3136)] public CapsuleParam capsules__arr28;
        [FieldOffset(3248)] public CapsuleParam capsules__arr29;
        [FieldOffset(3360)] public CapsuleParam capsules__arr30;
        [FieldOffset(3472)] public CapsuleParam capsules__arr31;
        [FieldOffset(3584)] public CapsuleParam capsules__arr32;
        [FieldOffset(3696)] public CapsuleParam capsules__arr33;
        [FieldOffset(3808)] public CapsuleParam capsules__arr34;
        [FieldOffset(3920)] public CapsuleParam capsules__arr35;
        [FieldOffset(4032)] public CapsuleParam capsules__arr36;
        [FieldOffset(4144)] public CapsuleParam capsules__arr37;
        [FieldOffset(4256)] public CapsuleParam capsules__arr38;
        [FieldOffset(4368)] public CapsuleParam capsules__arr39;
        [FieldOffset(4480)] public CapsuleParam capsules__arr40;
        [FieldOffset(4592)] public CapsuleParam capsules__arr41;
        [FieldOffset(4704)] public CapsuleParam capsules__arr42;
        [FieldOffset(4816)] public CapsuleParam capsules__arr43;
        [FieldOffset(4928)] public CapsuleParam capsules__arr44;
        [FieldOffset(5040)] public CapsuleParam capsules__arr45;
        [FieldOffset(5152)] public CapsuleParam capsules__arr46;
        [FieldOffset(5264)] public CapsuleParam capsules__arr47;
        [FieldOffset(5376)] public CapsuleParam capsules__arr48;
        [FieldOffset(5488)] public CapsuleParam capsules__arr49;
        [FieldOffset(5600)] public CapsuleParam capsules__arr50;
        [FieldOffset(5712)] public CapsuleParam capsules__arr51;
        [FieldOffset(5824)] public CapsuleParam capsules__arr52;
        [FieldOffset(5936)] public CapsuleParam capsules__arr53;
        [FieldOffset(6048)] public CapsuleParam capsules__arr54;
        [FieldOffset(6160)] public CapsuleParam capsules__arr55;
        [FieldOffset(6272)] public CapsuleParam capsules__arr56;
        [FieldOffset(6384)] public CapsuleParam capsules__arr57;
        [FieldOffset(6496)] public CapsuleParam capsules__arr58;
        [FieldOffset(6608)] public CapsuleParam capsules__arr59;
        [FieldOffset(6720)] public CapsuleParam capsules__arr60;
        [FieldOffset(6832)] public CapsuleParam capsules__arr61;
        [FieldOffset(6944)] public CapsuleParam capsules__arr62;
        [FieldOffset(7056)] public CapsuleParam capsules__arr63;
    }

}