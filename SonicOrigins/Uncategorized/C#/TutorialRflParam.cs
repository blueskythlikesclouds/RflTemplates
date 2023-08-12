using System.Numerics;
using System.Runtime.InteropServices;

public class TutorialRflParamClass
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct TutorialPageInfo
    {
        [FieldOffset(0)] public bool isEnable;
        [FieldOffset(4)] public int movieIndex;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct TutorialInfo
    {
        [FieldOffset(0)] public bool isEnable;
        [FieldOffset(4)] public int priority;
        [FieldOffset(8)] public TutorialPageInfo pageInfos__arr0;
        [FieldOffset(16)] public TutorialPageInfo pageInfos__arr1;
        [FieldOffset(24)] public TutorialPageInfo pageInfos__arr2;
    }

    [StructLayout(LayoutKind.Explicit, Size = 2048)]
    public struct TutorialRflParam
    {
        [FieldOffset(0)] public TutorialInfo infos__arr0;
        [FieldOffset(32)] public TutorialInfo infos__arr1;
        [FieldOffset(64)] public TutorialInfo infos__arr2;
        [FieldOffset(96)] public TutorialInfo infos__arr3;
        [FieldOffset(128)] public TutorialInfo infos__arr4;
        [FieldOffset(160)] public TutorialInfo infos__arr5;
        [FieldOffset(192)] public TutorialInfo infos__arr6;
        [FieldOffset(224)] public TutorialInfo infos__arr7;
        [FieldOffset(256)] public TutorialInfo infos__arr8;
        [FieldOffset(288)] public TutorialInfo infos__arr9;
        [FieldOffset(320)] public TutorialInfo infos__arr10;
        [FieldOffset(352)] public TutorialInfo infos__arr11;
        [FieldOffset(384)] public TutorialInfo infos__arr12;
        [FieldOffset(416)] public TutorialInfo infos__arr13;
        [FieldOffset(448)] public TutorialInfo infos__arr14;
        [FieldOffset(480)] public TutorialInfo infos__arr15;
        [FieldOffset(512)] public TutorialInfo infos__arr16;
        [FieldOffset(544)] public TutorialInfo infos__arr17;
        [FieldOffset(576)] public TutorialInfo infos__arr18;
        [FieldOffset(608)] public TutorialInfo infos__arr19;
        [FieldOffset(640)] public TutorialInfo infos__arr20;
        [FieldOffset(672)] public TutorialInfo infos__arr21;
        [FieldOffset(704)] public TutorialInfo infos__arr22;
        [FieldOffset(736)] public TutorialInfo infos__arr23;
        [FieldOffset(768)] public TutorialInfo infos__arr24;
        [FieldOffset(800)] public TutorialInfo infos__arr25;
        [FieldOffset(832)] public TutorialInfo infos__arr26;
        [FieldOffset(864)] public TutorialInfo infos__arr27;
        [FieldOffset(896)] public TutorialInfo infos__arr28;
        [FieldOffset(928)] public TutorialInfo infos__arr29;
        [FieldOffset(960)] public TutorialInfo infos__arr30;
        [FieldOffset(992)] public TutorialInfo infos__arr31;
        [FieldOffset(1024)] public TutorialInfo infos__arr32;
        [FieldOffset(1056)] public TutorialInfo infos__arr33;
        [FieldOffset(1088)] public TutorialInfo infos__arr34;
        [FieldOffset(1120)] public TutorialInfo infos__arr35;
        [FieldOffset(1152)] public TutorialInfo infos__arr36;
        [FieldOffset(1184)] public TutorialInfo infos__arr37;
        [FieldOffset(1216)] public TutorialInfo infos__arr38;
        [FieldOffset(1248)] public TutorialInfo infos__arr39;
        [FieldOffset(1280)] public TutorialInfo infos__arr40;
        [FieldOffset(1312)] public TutorialInfo infos__arr41;
        [FieldOffset(1344)] public TutorialInfo infos__arr42;
        [FieldOffset(1376)] public TutorialInfo infos__arr43;
        [FieldOffset(1408)] public TutorialInfo infos__arr44;
        [FieldOffset(1440)] public TutorialInfo infos__arr45;
        [FieldOffset(1472)] public TutorialInfo infos__arr46;
        [FieldOffset(1504)] public TutorialInfo infos__arr47;
        [FieldOffset(1536)] public TutorialInfo infos__arr48;
        [FieldOffset(1568)] public TutorialInfo infos__arr49;
        [FieldOffset(1600)] public TutorialInfo infos__arr50;
        [FieldOffset(1632)] public TutorialInfo infos__arr51;
        [FieldOffset(1664)] public TutorialInfo infos__arr52;
        [FieldOffset(1696)] public TutorialInfo infos__arr53;
        [FieldOffset(1728)] public TutorialInfo infos__arr54;
        [FieldOffset(1760)] public TutorialInfo infos__arr55;
        [FieldOffset(1792)] public TutorialInfo infos__arr56;
        [FieldOffset(1824)] public TutorialInfo infos__arr57;
        [FieldOffset(1856)] public TutorialInfo infos__arr58;
        [FieldOffset(1888)] public TutorialInfo infos__arr59;
        [FieldOffset(1920)] public TutorialInfo infos__arr60;
        [FieldOffset(1952)] public TutorialInfo infos__arr61;
        [FieldOffset(1984)] public TutorialInfo infos__arr62;
        [FieldOffset(2016)] public TutorialInfo infos__arr63;
    }

}