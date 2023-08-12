using System.Numerics;
using System.Runtime.InteropServices;

public class BGMInfoParameterClass
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

    public enum Priority : sbyte
    {
        PRIORITY_LOW = 0,
        PRIORITY_DEFAULT = 1,
        PRIORITY_HIGH = 2,
        PRIORITY_SUPER_HIGH = 3,
        NUM_PRIORITY = 4,
        PRIORITY_INVALID = -1
    }

    public enum InterruptType : sbyte
    {
        INTERRUPT_TYPE_STOP = 0,
        INTERRUPT_TYPE_PAUSE = 1,
        INTERRUPT_TYPE_OVERLAP = 2,
        NUM_INTERRUPT_TYPE = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public struct BGMInfo
    {
        [FieldOffset(0)]  public CString cueName;
        [FieldOffset(16)] public int blockId;
        [FieldOffset(20)] public float fadeInTime;
        [FieldOffset(24)] public float fadeOutTime;
        [FieldOffset(28)] public float delayTime;
        [FieldOffset(32)] public CString aisacName;
        [FieldOffset(48)] public float aisacValue;
        [FieldOffset(52)] public float aisacFadeTime;
        [FieldOffset(56)] public bool isVolumeControl;
        [FieldOffset(57)] public bool isOverlapPlay;
        [FieldOffset(58)] public Priority priority;
        [FieldOffset(59)] public InterruptType interruptType;
    }

    public enum BGMTransitInfo_InterruptType : sbyte
    {
        BGMTransitInfo_InterruptType_INTERRUPT_TYPE_STOP = 0,
        BGMTransitInfo_InterruptType_INTERRUPT_TYPE_PAUSE = 1,
        BGMTransitInfo_InterruptType_INTERRUPT_TYPE_OVERLAP = 2,
        BGMTransitInfo_InterruptType_NUM_INTERRUPT_TYPE = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public struct BGMTransitInfo
    {
        [FieldOffset(0)]  public CString tagName;
        [FieldOffset(16)] public int beforeId;
        [FieldOffset(20)] public int afterId;
        [FieldOffset(24)] public BGMTransitInfo_InterruptType type;
        [FieldOffset(28)] public float fadeOutTime;
        [FieldOffset(32)] public float fadeInTime;
        [FieldOffset(36)] public float delayTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct BGMSceneInfo
    {
        [FieldOffset(0)]  public CString sceneName;
        [FieldOffset(16)] public int bgmId;
        [FieldOffset(20)] public bool disableSameBgmId;
    }

    [StructLayout(LayoutKind.Explicit, Size = 3424)]
    public struct BGMInfoParameter
    {
        [FieldOffset(0)]    public BGMInfo changeBgmInfo__arr0;
        [FieldOffset(64)] public BGMInfo changeBgmInfo__arr1;
        [FieldOffset(128)] public BGMInfo changeBgmInfo__arr2;
        [FieldOffset(192)] public BGMInfo changeBgmInfo__arr3;
        [FieldOffset(256)] public BGMInfo changeBgmInfo__arr4;
        [FieldOffset(320)] public BGMInfo changeBgmInfo__arr5;
        [FieldOffset(384)] public BGMInfo changeBgmInfo__arr6;
        [FieldOffset(448)] public BGMInfo changeBgmInfo__arr7;
        [FieldOffset(512)] public BGMInfo changeBgmInfo__arr8;
        [FieldOffset(576)] public BGMInfo changeBgmInfo__arr9;
        [FieldOffset(640)] public BGMInfo changeBgmInfo__arr10;
        [FieldOffset(704)] public BGMInfo changeBgmInfo__arr11;
        [FieldOffset(768)] public BGMInfo changeBgmInfo__arr12;
        [FieldOffset(832)] public BGMInfo changeBgmInfo__arr13;
        [FieldOffset(896)] public BGMInfo changeBgmInfo__arr14;
        [FieldOffset(960)] public BGMInfo changeBgmInfo__arr15;
        [FieldOffset(1024)] public BGMInfo changeBgmInfo__arr16;
        [FieldOffset(1088)] public BGMInfo changeBgmInfo__arr17;
        [FieldOffset(1152)] public BGMInfo changeBgmInfo__arr18;
        [FieldOffset(1216)] public BGMInfo changeBgmInfo__arr19;
        [FieldOffset(1280)] public BGMInfo changeBgmInfo__arr20;
        [FieldOffset(1344)] public BGMInfo changeBgmInfo__arr21;
        [FieldOffset(1408)] public BGMInfo changeBgmInfo__arr22;
        [FieldOffset(1472)] public BGMInfo changeBgmInfo__arr23;
        [FieldOffset(1536)] public BGMInfo changeBgmInfo__arr24;
        [FieldOffset(1600)] public BGMInfo changeBgmInfo__arr25;
        [FieldOffset(1664)] public BGMInfo changeBgmInfo__arr26;
        [FieldOffset(1728)] public BGMInfo changeBgmInfo__arr27;
        [FieldOffset(1792)] public BGMInfo changeBgmInfo__arr28;
        [FieldOffset(1856)] public BGMInfo changeBgmInfo__arr29;
        [FieldOffset(1920)] public BGMInfo changeBgmInfo__arr30;
        [FieldOffset(1984)] public BGMInfo changeBgmInfo__arr31;
        [FieldOffset(2048)] public BGMTransitInfo transitBgmInfo__arr0;
        [FieldOffset(2088)] public BGMTransitInfo transitBgmInfo__arr1;
        [FieldOffset(2128)] public BGMTransitInfo transitBgmInfo__arr2;
        [FieldOffset(2168)] public BGMTransitInfo transitBgmInfo__arr3;
        [FieldOffset(2208)] public BGMTransitInfo transitBgmInfo__arr4;
        [FieldOffset(2248)] public BGMTransitInfo transitBgmInfo__arr5;
        [FieldOffset(2288)] public BGMTransitInfo transitBgmInfo__arr6;
        [FieldOffset(2328)] public BGMTransitInfo transitBgmInfo__arr7;
        [FieldOffset(2368)] public BGMTransitInfo transitBgmInfo__arr8;
        [FieldOffset(2408)] public BGMTransitInfo transitBgmInfo__arr9;
        [FieldOffset(2448)] public BGMTransitInfo transitBgmInfo__arr10;
        [FieldOffset(2488)] public BGMTransitInfo transitBgmInfo__arr11;
        [FieldOffset(2528)] public BGMTransitInfo transitBgmInfo__arr12;
        [FieldOffset(2568)] public BGMTransitInfo transitBgmInfo__arr13;
        [FieldOffset(2608)] public BGMTransitInfo transitBgmInfo__arr14;
        [FieldOffset(2648)] public BGMTransitInfo transitBgmInfo__arr15;
        [FieldOffset(2688)] public BGMTransitInfo transitBgmInfo__arr16;
        [FieldOffset(2728)] public BGMTransitInfo transitBgmInfo__arr17;
        [FieldOffset(2768)] public BGMTransitInfo transitBgmInfo__arr18;
        [FieldOffset(2808)] public BGMTransitInfo transitBgmInfo__arr19;
        [FieldOffset(2848)] public BGMTransitInfo transitBgmInfo__arr20;
        [FieldOffset(2888)] public BGMTransitInfo transitBgmInfo__arr21;
        [FieldOffset(2928)] public BGMTransitInfo transitBgmInfo__arr22;
        [FieldOffset(2968)] public BGMTransitInfo transitBgmInfo__arr23;
        [FieldOffset(3008)] public BGMTransitInfo transitBgmInfo__arr24;
        [FieldOffset(3048)] public BGMTransitInfo transitBgmInfo__arr25;
        [FieldOffset(3088)] public BGMTransitInfo transitBgmInfo__arr26;
        [FieldOffset(3128)] public BGMTransitInfo transitBgmInfo__arr27;
        [FieldOffset(3168)] public BGMTransitInfo transitBgmInfo__arr28;
        [FieldOffset(3208)] public BGMTransitInfo transitBgmInfo__arr29;
        [FieldOffset(3248)] public BGMTransitInfo transitBgmInfo__arr30;
        [FieldOffset(3288)] public BGMTransitInfo transitBgmInfo__arr31;
        [FieldOffset(3328)] public BGMSceneInfo sceneBgmInfo__arr0;
        [FieldOffset(3352)] public BGMSceneInfo sceneBgmInfo__arr1;
        [FieldOffset(3376)] public BGMSceneInfo sceneBgmInfo__arr2;
        [FieldOffset(3400)] public BGMSceneInfo sceneBgmInfo__arr3;
    }

}