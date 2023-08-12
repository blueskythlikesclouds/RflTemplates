using System.Numerics;
using System.Runtime.InteropServices;

public class SoundCommonParameterClass
{
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct BGMVolumeChangeInfo
    {
        [FieldOffset(0)] public float value;
        [FieldOffset(4)] public float delayTime;
        [FieldOffset(8)] public float fadeTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 144)]
    public struct BGMVolumeChangeInfoList
    {
        [FieldOffset(0)]   public BGMVolumeChangeInfo playerStop;
        [FieldOffset(12)]  public BGMVolumeChangeInfo playerWalk;
        [FieldOffset(24)]  public BGMVolumeChangeInfo playerRun;
        [FieldOffset(36)]  public BGMVolumeChangeInfo breakPortalStart;
        [FieldOffset(48)]  public BGMVolumeChangeInfo breakPortalEnd;
        [FieldOffset(60)]  public BGMVolumeChangeInfo getEmeraldStart;
        [FieldOffset(72)]  public BGMVolumeChangeInfo getEmeraldEnd;
        [FieldOffset(84)]  public BGMVolumeChangeInfo getEmeraldEndBoss;
        [FieldOffset(96)]  public BGMVolumeChangeInfo bossAreaIn;
        [FieldOffset(108)] public BGMVolumeChangeInfo bossAreaOut;
        [FieldOffset(120)] public BGMVolumeChangeInfo fishingHitIn;
        [FieldOffset(132)] public BGMVolumeChangeInfo fishingHitOut;
    }

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

    [StructLayout(LayoutKind.Explicit, Size = 10456)]
    public struct SoundCommonParameter
    {
        [FieldOffset(0)]    public float pauseFadeOutTime;
        [FieldOffset(4)]    public float pauseFadeInTime;
        [FieldOffset(8)]    public float enterCyberFadeOutTime;
        [FieldOffset(12)]   public BGMVolumeChangeInfoList bgmVolumeInfo;
        [FieldOffset(160)]  public BGMInfo changeBgmInfo__arr0;
        [FieldOffset(224)] public BGMInfo changeBgmInfo__arr1;
        [FieldOffset(288)] public BGMInfo changeBgmInfo__arr2;
        [FieldOffset(352)] public BGMInfo changeBgmInfo__arr3;
        [FieldOffset(416)] public BGMInfo changeBgmInfo__arr4;
        [FieldOffset(480)] public BGMInfo changeBgmInfo__arr5;
        [FieldOffset(544)] public BGMInfo changeBgmInfo__arr6;
        [FieldOffset(608)] public BGMInfo changeBgmInfo__arr7;
        [FieldOffset(672)] public BGMInfo changeBgmInfo__arr8;
        [FieldOffset(736)] public BGMInfo changeBgmInfo__arr9;
        [FieldOffset(800)] public BGMInfo changeBgmInfo__arr10;
        [FieldOffset(864)] public BGMInfo changeBgmInfo__arr11;
        [FieldOffset(928)] public BGMInfo changeBgmInfo__arr12;
        [FieldOffset(992)] public BGMInfo changeBgmInfo__arr13;
        [FieldOffset(1056)] public BGMInfo changeBgmInfo__arr14;
        [FieldOffset(1120)] public BGMInfo changeBgmInfo__arr15;
        [FieldOffset(1184)] public BGMInfo changeBgmInfo__arr16;
        [FieldOffset(1248)] public BGMInfo changeBgmInfo__arr17;
        [FieldOffset(1312)] public BGMInfo changeBgmInfo__arr18;
        [FieldOffset(1376)] public BGMInfo changeBgmInfo__arr19;
        [FieldOffset(1440)] public BGMInfo changeBgmInfo__arr20;
        [FieldOffset(1504)] public BGMInfo changeBgmInfo__arr21;
        [FieldOffset(1568)] public BGMInfo changeBgmInfo__arr22;
        [FieldOffset(1632)] public BGMInfo changeBgmInfo__arr23;
        [FieldOffset(1696)] public BGMInfo changeBgmInfo__arr24;
        [FieldOffset(1760)] public BGMInfo changeBgmInfo__arr25;
        [FieldOffset(1824)] public BGMInfo changeBgmInfo__arr26;
        [FieldOffset(1888)] public BGMInfo changeBgmInfo__arr27;
        [FieldOffset(1952)] public BGMInfo changeBgmInfo__arr28;
        [FieldOffset(2016)] public BGMInfo changeBgmInfo__arr29;
        [FieldOffset(2080)] public BGMInfo changeBgmInfo__arr30;
        [FieldOffset(2144)] public BGMInfo changeBgmInfo__arr31;
        [FieldOffset(2208)] public BGMInfo changeBgmInfo__arr32;
        [FieldOffset(2272)] public BGMInfo changeBgmInfo__arr33;
        [FieldOffset(2336)] public BGMInfo changeBgmInfo__arr34;
        [FieldOffset(2400)] public BGMInfo changeBgmInfo__arr35;
        [FieldOffset(2464)] public BGMInfo changeBgmInfo__arr36;
        [FieldOffset(2528)] public BGMInfo changeBgmInfo__arr37;
        [FieldOffset(2592)] public BGMInfo changeBgmInfo__arr38;
        [FieldOffset(2656)] public BGMInfo changeBgmInfo__arr39;
        [FieldOffset(2720)] public BGMInfo changeBgmInfo__arr40;
        [FieldOffset(2784)] public BGMInfo changeBgmInfo__arr41;
        [FieldOffset(2848)] public BGMInfo changeBgmInfo__arr42;
        [FieldOffset(2912)] public BGMInfo changeBgmInfo__arr43;
        [FieldOffset(2976)] public BGMInfo changeBgmInfo__arr44;
        [FieldOffset(3040)] public BGMInfo changeBgmInfo__arr45;
        [FieldOffset(3104)] public BGMInfo changeBgmInfo__arr46;
        [FieldOffset(3168)] public BGMInfo changeBgmInfo__arr47;
        [FieldOffset(3232)] public BGMInfo changeBgmInfo__arr48;
        [FieldOffset(3296)] public BGMInfo changeBgmInfo__arr49;
        [FieldOffset(3360)] public BGMInfo changeBgmInfo__arr50;
        [FieldOffset(3424)] public BGMInfo changeBgmInfo__arr51;
        [FieldOffset(3488)] public BGMInfo changeBgmInfo__arr52;
        [FieldOffset(3552)] public BGMInfo changeBgmInfo__arr53;
        [FieldOffset(3616)] public BGMInfo changeBgmInfo__arr54;
        [FieldOffset(3680)] public BGMInfo changeBgmInfo__arr55;
        [FieldOffset(3744)] public BGMInfo changeBgmInfo__arr56;
        [FieldOffset(3808)] public BGMInfo changeBgmInfo__arr57;
        [FieldOffset(3872)] public BGMInfo changeBgmInfo__arr58;
        [FieldOffset(3936)] public BGMInfo changeBgmInfo__arr59;
        [FieldOffset(4000)] public BGMInfo changeBgmInfo__arr60;
        [FieldOffset(4064)] public BGMInfo changeBgmInfo__arr61;
        [FieldOffset(4128)] public BGMInfo changeBgmInfo__arr62;
        [FieldOffset(4192)] public BGMInfo changeBgmInfo__arr63;
        [FieldOffset(4256)] public BGMInfo changeBgmInfo__arr64;
        [FieldOffset(4320)] public BGMInfo changeBgmInfo__arr65;
        [FieldOffset(4384)] public BGMInfo changeBgmInfo__arr66;
        [FieldOffset(4448)] public BGMInfo changeBgmInfo__arr67;
        [FieldOffset(4512)] public BGMInfo changeBgmInfo__arr68;
        [FieldOffset(4576)] public BGMInfo changeBgmInfo__arr69;
        [FieldOffset(4640)] public BGMInfo changeBgmInfo__arr70;
        [FieldOffset(4704)] public BGMInfo changeBgmInfo__arr71;
        [FieldOffset(4768)] public BGMInfo changeBgmInfo__arr72;
        [FieldOffset(4832)] public BGMInfo changeBgmInfo__arr73;
        [FieldOffset(4896)] public BGMInfo changeBgmInfo__arr74;
        [FieldOffset(4960)] public BGMInfo changeBgmInfo__arr75;
        [FieldOffset(5024)] public BGMInfo changeBgmInfo__arr76;
        [FieldOffset(5088)] public BGMInfo changeBgmInfo__arr77;
        [FieldOffset(5152)] public BGMInfo changeBgmInfo__arr78;
        [FieldOffset(5216)] public BGMInfo changeBgmInfo__arr79;
        [FieldOffset(5280)] public BGMInfo changeBgmInfo__arr80;
        [FieldOffset(5344)] public BGMInfo changeBgmInfo__arr81;
        [FieldOffset(5408)] public BGMInfo changeBgmInfo__arr82;
        [FieldOffset(5472)] public BGMInfo changeBgmInfo__arr83;
        [FieldOffset(5536)] public BGMInfo changeBgmInfo__arr84;
        [FieldOffset(5600)] public BGMInfo changeBgmInfo__arr85;
        [FieldOffset(5664)] public BGMInfo changeBgmInfo__arr86;
        [FieldOffset(5728)] public BGMInfo changeBgmInfo__arr87;
        [FieldOffset(5792)] public BGMInfo changeBgmInfo__arr88;
        [FieldOffset(5856)] public BGMInfo changeBgmInfo__arr89;
        [FieldOffset(5920)] public BGMInfo changeBgmInfo__arr90;
        [FieldOffset(5984)] public BGMInfo changeBgmInfo__arr91;
        [FieldOffset(6048)] public BGMInfo changeBgmInfo__arr92;
        [FieldOffset(6112)] public BGMInfo changeBgmInfo__arr93;
        [FieldOffset(6176)] public BGMInfo changeBgmInfo__arr94;
        [FieldOffset(6240)] public BGMInfo changeBgmInfo__arr95;
        [FieldOffset(6304)] public BGMInfo changeBgmInfo__arr96;
        [FieldOffset(6368)] public BGMInfo changeBgmInfo__arr97;
        [FieldOffset(6432)] public BGMInfo changeBgmInfo__arr98;
        [FieldOffset(6496)] public BGMTransitInfo transitBgmInfo__arr0;
        [FieldOffset(6536)] public BGMTransitInfo transitBgmInfo__arr1;
        [FieldOffset(6576)] public BGMTransitInfo transitBgmInfo__arr2;
        [FieldOffset(6616)] public BGMTransitInfo transitBgmInfo__arr3;
        [FieldOffset(6656)] public BGMTransitInfo transitBgmInfo__arr4;
        [FieldOffset(6696)] public BGMTransitInfo transitBgmInfo__arr5;
        [FieldOffset(6736)] public BGMTransitInfo transitBgmInfo__arr6;
        [FieldOffset(6776)] public BGMTransitInfo transitBgmInfo__arr7;
        [FieldOffset(6816)] public BGMTransitInfo transitBgmInfo__arr8;
        [FieldOffset(6856)] public BGMTransitInfo transitBgmInfo__arr9;
        [FieldOffset(6896)] public BGMTransitInfo transitBgmInfo__arr10;
        [FieldOffset(6936)] public BGMTransitInfo transitBgmInfo__arr11;
        [FieldOffset(6976)] public BGMTransitInfo transitBgmInfo__arr12;
        [FieldOffset(7016)] public BGMTransitInfo transitBgmInfo__arr13;
        [FieldOffset(7056)] public BGMTransitInfo transitBgmInfo__arr14;
        [FieldOffset(7096)] public BGMTransitInfo transitBgmInfo__arr15;
        [FieldOffset(7136)] public BGMTransitInfo transitBgmInfo__arr16;
        [FieldOffset(7176)] public BGMTransitInfo transitBgmInfo__arr17;
        [FieldOffset(7216)] public BGMTransitInfo transitBgmInfo__arr18;
        [FieldOffset(7256)] public BGMTransitInfo transitBgmInfo__arr19;
        [FieldOffset(7296)] public BGMTransitInfo transitBgmInfo__arr20;
        [FieldOffset(7336)] public BGMTransitInfo transitBgmInfo__arr21;
        [FieldOffset(7376)] public BGMTransitInfo transitBgmInfo__arr22;
        [FieldOffset(7416)] public BGMTransitInfo transitBgmInfo__arr23;
        [FieldOffset(7456)] public BGMTransitInfo transitBgmInfo__arr24;
        [FieldOffset(7496)] public BGMTransitInfo transitBgmInfo__arr25;
        [FieldOffset(7536)] public BGMTransitInfo transitBgmInfo__arr26;
        [FieldOffset(7576)] public BGMTransitInfo transitBgmInfo__arr27;
        [FieldOffset(7616)] public BGMTransitInfo transitBgmInfo__arr28;
        [FieldOffset(7656)] public BGMTransitInfo transitBgmInfo__arr29;
        [FieldOffset(7696)] public BGMTransitInfo transitBgmInfo__arr30;
        [FieldOffset(7736)] public BGMTransitInfo transitBgmInfo__arr31;
        [FieldOffset(7776)] public BGMTransitInfo transitBgmInfo__arr32;
        [FieldOffset(7816)] public BGMTransitInfo transitBgmInfo__arr33;
        [FieldOffset(7856)] public BGMTransitInfo transitBgmInfo__arr34;
        [FieldOffset(7896)] public BGMTransitInfo transitBgmInfo__arr35;
        [FieldOffset(7936)] public BGMTransitInfo transitBgmInfo__arr36;
        [FieldOffset(7976)] public BGMTransitInfo transitBgmInfo__arr37;
        [FieldOffset(8016)] public BGMTransitInfo transitBgmInfo__arr38;
        [FieldOffset(8056)] public BGMTransitInfo transitBgmInfo__arr39;
        [FieldOffset(8096)] public BGMTransitInfo transitBgmInfo__arr40;
        [FieldOffset(8136)] public BGMTransitInfo transitBgmInfo__arr41;
        [FieldOffset(8176)] public BGMTransitInfo transitBgmInfo__arr42;
        [FieldOffset(8216)] public BGMTransitInfo transitBgmInfo__arr43;
        [FieldOffset(8256)] public BGMTransitInfo transitBgmInfo__arr44;
        [FieldOffset(8296)] public BGMTransitInfo transitBgmInfo__arr45;
        [FieldOffset(8336)] public BGMTransitInfo transitBgmInfo__arr46;
        [FieldOffset(8376)] public BGMTransitInfo transitBgmInfo__arr47;
        [FieldOffset(8416)] public BGMTransitInfo transitBgmInfo__arr48;
        [FieldOffset(8456)] public BGMTransitInfo transitBgmInfo__arr49;
        [FieldOffset(8496)] public BGMTransitInfo transitBgmInfo__arr50;
        [FieldOffset(8536)] public BGMTransitInfo transitBgmInfo__arr51;
        [FieldOffset(8576)] public BGMTransitInfo transitBgmInfo__arr52;
        [FieldOffset(8616)] public BGMTransitInfo transitBgmInfo__arr53;
        [FieldOffset(8656)] public BGMTransitInfo transitBgmInfo__arr54;
        [FieldOffset(8696)] public BGMTransitInfo transitBgmInfo__arr55;
        [FieldOffset(8736)] public BGMTransitInfo transitBgmInfo__arr56;
        [FieldOffset(8776)] public BGMTransitInfo transitBgmInfo__arr57;
        [FieldOffset(8816)] public BGMTransitInfo transitBgmInfo__arr58;
        [FieldOffset(8856)] public BGMTransitInfo transitBgmInfo__arr59;
        [FieldOffset(8896)] public BGMTransitInfo transitBgmInfo__arr60;
        [FieldOffset(8936)] public BGMTransitInfo transitBgmInfo__arr61;
        [FieldOffset(8976)] public BGMTransitInfo transitBgmInfo__arr62;
        [FieldOffset(9016)] public BGMTransitInfo transitBgmInfo__arr63;
        [FieldOffset(9056)] public BGMTransitInfo transitBgmInfo__arr64;
        [FieldOffset(9096)] public BGMTransitInfo transitBgmInfo__arr65;
        [FieldOffset(9136)] public BGMTransitInfo transitBgmInfo__arr66;
        [FieldOffset(9176)] public BGMTransitInfo transitBgmInfo__arr67;
        [FieldOffset(9216)] public BGMTransitInfo transitBgmInfo__arr68;
        [FieldOffset(9256)] public BGMTransitInfo transitBgmInfo__arr69;
        [FieldOffset(9296)] public BGMTransitInfo transitBgmInfo__arr70;
        [FieldOffset(9336)] public BGMTransitInfo transitBgmInfo__arr71;
        [FieldOffset(9376)] public BGMTransitInfo transitBgmInfo__arr72;
        [FieldOffset(9416)] public BGMTransitInfo transitBgmInfo__arr73;
        [FieldOffset(9456)] public BGMTransitInfo transitBgmInfo__arr74;
        [FieldOffset(9496)] public BGMTransitInfo transitBgmInfo__arr75;
        [FieldOffset(9536)] public BGMTransitInfo transitBgmInfo__arr76;
        [FieldOffset(9576)] public BGMTransitInfo transitBgmInfo__arr77;
        [FieldOffset(9616)] public BGMTransitInfo transitBgmInfo__arr78;
        [FieldOffset(9656)] public BGMTransitInfo transitBgmInfo__arr79;
        [FieldOffset(9696)] public BGMTransitInfo transitBgmInfo__arr80;
        [FieldOffset(9736)] public BGMTransitInfo transitBgmInfo__arr81;
        [FieldOffset(9776)] public BGMTransitInfo transitBgmInfo__arr82;
        [FieldOffset(9816)] public BGMTransitInfo transitBgmInfo__arr83;
        [FieldOffset(9856)] public BGMTransitInfo transitBgmInfo__arr84;
        [FieldOffset(9896)] public BGMTransitInfo transitBgmInfo__arr85;
        [FieldOffset(9936)] public BGMTransitInfo transitBgmInfo__arr86;
        [FieldOffset(9976)] public BGMTransitInfo transitBgmInfo__arr87;
        [FieldOffset(10016)] public BGMTransitInfo transitBgmInfo__arr88;
        [FieldOffset(10056)] public BGMTransitInfo transitBgmInfo__arr89;
        [FieldOffset(10096)] public BGMTransitInfo transitBgmInfo__arr90;
        [FieldOffset(10136)] public BGMTransitInfo transitBgmInfo__arr91;
        [FieldOffset(10176)] public BGMTransitInfo transitBgmInfo__arr92;
        [FieldOffset(10216)] public BGMTransitInfo transitBgmInfo__arr93;
        [FieldOffset(10256)] public BGMTransitInfo transitBgmInfo__arr94;
        [FieldOffset(10296)] public BGMTransitInfo transitBgmInfo__arr95;
        [FieldOffset(10336)] public BGMTransitInfo transitBgmInfo__arr96;
        [FieldOffset(10376)] public BGMTransitInfo transitBgmInfo__arr97;
        [FieldOffset(10416)] public BGMTransitInfo transitBgmInfo__arr98;
    }

}