using System.Numerics;
using System.Runtime.InteropServices;

public class MuseumItemRflParamClass
{
    public enum MuseumSectionKind : int
    {
        MUSEUMSECTIONKIND_NORMAL = 0,
        MUSEUMSECTIONKIND_PREMIUM = 1,
        MUSEUMSECTIONKIND_NUM = 2
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

    public enum MuseumItemCategory : int
    {
        MUSEUMITEMCATEGORY_NONE = 0,
        MUSEUMITEMCATEGORY_TITLE_START = 1,
        MUSEUMITEMCATEGORY_TITLE_SONIC_1 = 1,
        MUSEUMITEMCATEGORY_TITLE_SONIC_CD = 2,
        MUSEUMITEMCATEGORY_TITLE_SONIC_2 = 3,
        MUSEUMITEMCATEGORY_TITLE_SONIC_3K = 4,
        MUSEUMITEMCATEGORY_TITLE_SONIC_ORIGINS = 5,
        MUSEUMITEMCATEGORY_TITLE_ETC = 6,
        MUSEUMITEMCATEGORY_TITLE_SONIC_SPINBALL = 7,
        MUSEUMITEMCATEGORY_TITLE_CHAOTIX = 8,
        MUSEUMITEMCATEGORY_TITLE_SONIC_3D_BLAST = 9,
        MUSEUMITEMCATEGORY_TITLE_RESERVE_1 = 10,
        MUSEUMITEMCATEGORY_TITLE_END = 11,
        MUSEUMITEMCATEGORY_SOUND_START = 11,
        MUSEUMITEMCATEGORY_SOUND_BGM_MENU = 11,
        MUSEUMITEMCATEGORY_SOUND_BGM_STAGE = 12,
        MUSEUMITEMCATEGORY_SOUND_JINGLE = 13,
        MUSEUMITEMCATEGORY_SOUND_ETC = 14,
        MUSEUMITEMCATEGORY_SOUND_RESERVE_1 = 15,
        MUSEUMITEMCATEGORY_SOUND_END = 16,
        MUSEUMITEMCATEGORY_CHARA_START = 16,
        MUSEUMITEMCATEGORY_CHARA_SONIC = 16,
        MUSEUMITEMCATEGORY_CHARA_TAILS = 17,
        MUSEUMITEMCATEGORY_CHARA_KNUCKLES = 18,
        MUSEUMITEMCATEGORY_CHARA_AMY = 19,
        MUSEUMITEMCATEGORY_CHARA_EGGMAN = 20,
        MUSEUMITEMCATEGORY_CHARA_METALSONIC = 21,
        MUSEUMITEMCATEGORY_CHARA_ETC = 22,
        MUSEUMITEMCATEGORY_CHARA_RESERVE_1 = 23,
        MUSEUMITEMCATEGORY_CHARA_END = 24,
        MUSEUMITEMCATEGORY_PICTURE_START = 24,
        MUSEUMITEMCATEGORY_PICTURE_INITIAL = 24,
        MUSEUMITEMCATEGORY_PICTURE_COLOR = 25,
        MUSEUMITEMCATEGORY_PICTURE_DOCUMENT = 26,
        MUSEUMITEMCATEGORY_PICTURE_PACKAGE = 27,
        MUSEUMITEMCATEGORY_PICTURE_ETC = 28,
        MUSEUMITEMCATEGORY_PICTURE_END = 29,
        MUSEUMITEMCATEGORY_NUM = 29,
        MUSEUMITEMCATEGORY_TITLE_NUM = 10,
        MUSEUMITEMCATEGORY_SOUND_NUM = 5,
        MUSEUMITEMCATEGORY_CHARA_NUM = 8,
        MUSEUMITEMCATEGORY_PICTURE_NUM = 5
    }

    public enum MuseumItemOpenState : int
    {
        MUSEUMITEMOPENSTATE_UNKNOWN = 0,
        MUSEUMITEMOPENSTATE_OPEN = 1,
        MUSEUMITEMOPENSTATE_COIN = 2,
        MUSEUMITEMOPENSTATE_STATS = 3,
        MUSEUMITEMOPENSTATE_NUM = 4
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct MuseumUnlockInfo
    {
        [FieldOffset(0)] public MuseumItemOpenState openState;
        [FieldOffset(4)] public int unlockAchievementNo;
        [FieldOffset(8)] public int unlockCoinNum;
    }

    [StructLayout(LayoutKind.Explicit, Size = 104)]
    public struct MuseumItemInfo
    {
        [FieldOffset(0)]  public bool isEnable;
        [FieldOffset(4)]  public int number;
        [FieldOffset(8)]  public MuseumSectionKind sectionKind;
        [FieldOffset(16)] public CString assetName;
        [FieldOffset(32)] public int playTime;
        [FieldOffset(36)] public bool fadeOutMusic;
        [FieldOffset(40)] public MuseumItemCategory categories__arr0;
        [FieldOffset(44)] public MuseumItemCategory categories__arr1;
        [FieldOffset(48)] public MuseumItemCategory categories__arr2;
        [FieldOffset(52)] public MuseumItemCategory categories__arr3;
        [FieldOffset(56)] public MuseumItemCategory categories__arr4;
        [FieldOffset(60)] public MuseumItemCategory categories__arr5;
        [FieldOffset(64)] public MuseumItemCategory categories__arr6;
        [FieldOffset(68)] public MuseumItemCategory categories__arr7;
        [FieldOffset(72)] public MuseumItemCategory categories__arr8;
        [FieldOffset(76)] public MuseumItemCategory categories__arr9;
        [FieldOffset(80)] public bool isDLCItem;
        [FieldOffset(81)] public bool isTypeSD;
        [FieldOffset(82)] public bool is4KAvailable;
        [FieldOffset(83)] public byte soundTexNum;
        [FieldOffset(84)] public byte artPageCount;
        [FieldOffset(85)] public byte movieSoundCount;
        [FieldOffset(88)] public MuseumUnlockInfo unlockInfo;
    }

    public enum MuseumSortInfo_MuseumItemCategory : int
    {
        MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_NONE = 0,
        MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_TITLE_START = 1,
        MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_TITLE_SONIC_1 = 1,
        MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_TITLE_SONIC_CD = 2,
        MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_TITLE_SONIC_2 = 3,
        MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_TITLE_SONIC_3K = 4,
        MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_TITLE_SONIC_ORIGINS = 5,
        MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_TITLE_ETC = 6,
        MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_TITLE_SONIC_SPINBALL = 7,
        MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_TITLE_CHAOTIX = 8,
        MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_TITLE_SONIC_3D_BLAST = 9,
        MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_TITLE_RESERVE_1 = 10,
        MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_TITLE_END = 11,
        MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_SOUND_START = 11,
        MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_SOUND_BGM_MENU = 11,
        MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_SOUND_BGM_STAGE = 12,
        MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_SOUND_JINGLE = 13,
        MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_SOUND_ETC = 14,
        MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_SOUND_RESERVE_1 = 15,
        MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_SOUND_END = 16,
        MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_CHARA_START = 16,
        MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_CHARA_SONIC = 16,
        MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_CHARA_TAILS = 17,
        MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_CHARA_KNUCKLES = 18,
        MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_CHARA_AMY = 19,
        MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_CHARA_EGGMAN = 20,
        MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_CHARA_METALSONIC = 21,
        MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_CHARA_ETC = 22,
        MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_CHARA_RESERVE_1 = 23,
        MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_CHARA_END = 24,
        MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_PICTURE_START = 24,
        MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_PICTURE_INITIAL = 24,
        MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_PICTURE_COLOR = 25,
        MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_PICTURE_DOCUMENT = 26,
        MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_PICTURE_PACKAGE = 27,
        MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_PICTURE_ETC = 28,
        MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_PICTURE_END = 29,
        MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_NUM = 29,
        MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_TITLE_NUM = 10,
        MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_SOUND_NUM = 5,
        MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_CHARA_NUM = 8,
        MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_PICTURE_NUM = 5
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct MuseumSortInfo
    {
        [FieldOffset(0)] public MuseumSortInfo_MuseumItemCategory category;
        [FieldOffset(4)] public bool isDLCCategory;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct MusicFadeOutInfo
    {
        [FieldOffset(0)] public float time;
    }

    [StructLayout(LayoutKind.Explicit, Size = 73360)]
    public struct MuseumItemRflParam
    {
        [FieldOffset(0)]     public MuseumItemInfo musicItems__arr0;
        [FieldOffset(104)] public MuseumItemInfo musicItems__arr1;
        [FieldOffset(208)] public MuseumItemInfo musicItems__arr2;
        [FieldOffset(312)] public MuseumItemInfo musicItems__arr3;
        [FieldOffset(416)] public MuseumItemInfo musicItems__arr4;
        [FieldOffset(520)] public MuseumItemInfo musicItems__arr5;
        [FieldOffset(624)] public MuseumItemInfo musicItems__arr6;
        [FieldOffset(728)] public MuseumItemInfo musicItems__arr7;
        [FieldOffset(832)] public MuseumItemInfo musicItems__arr8;
        [FieldOffset(936)] public MuseumItemInfo musicItems__arr9;
        [FieldOffset(1040)] public MuseumItemInfo musicItems__arr10;
        [FieldOffset(1144)] public MuseumItemInfo musicItems__arr11;
        [FieldOffset(1248)] public MuseumItemInfo musicItems__arr12;
        [FieldOffset(1352)] public MuseumItemInfo musicItems__arr13;
        [FieldOffset(1456)] public MuseumItemInfo musicItems__arr14;
        [FieldOffset(1560)] public MuseumItemInfo musicItems__arr15;
        [FieldOffset(1664)] public MuseumItemInfo musicItems__arr16;
        [FieldOffset(1768)] public MuseumItemInfo musicItems__arr17;
        [FieldOffset(1872)] public MuseumItemInfo musicItems__arr18;
        [FieldOffset(1976)] public MuseumItemInfo musicItems__arr19;
        [FieldOffset(2080)] public MuseumItemInfo musicItems__arr20;
        [FieldOffset(2184)] public MuseumItemInfo musicItems__arr21;
        [FieldOffset(2288)] public MuseumItemInfo musicItems__arr22;
        [FieldOffset(2392)] public MuseumItemInfo musicItems__arr23;
        [FieldOffset(2496)] public MuseumItemInfo musicItems__arr24;
        [FieldOffset(2600)] public MuseumItemInfo musicItems__arr25;
        [FieldOffset(2704)] public MuseumItemInfo musicItems__arr26;
        [FieldOffset(2808)] public MuseumItemInfo musicItems__arr27;
        [FieldOffset(2912)] public MuseumItemInfo musicItems__arr28;
        [FieldOffset(3016)] public MuseumItemInfo musicItems__arr29;
        [FieldOffset(3120)] public MuseumItemInfo musicItems__arr30;
        [FieldOffset(3224)] public MuseumItemInfo musicItems__arr31;
        [FieldOffset(3328)] public MuseumItemInfo musicItems__arr32;
        [FieldOffset(3432)] public MuseumItemInfo musicItems__arr33;
        [FieldOffset(3536)] public MuseumItemInfo musicItems__arr34;
        [FieldOffset(3640)] public MuseumItemInfo musicItems__arr35;
        [FieldOffset(3744)] public MuseumItemInfo musicItems__arr36;
        [FieldOffset(3848)] public MuseumItemInfo musicItems__arr37;
        [FieldOffset(3952)] public MuseumItemInfo musicItems__arr38;
        [FieldOffset(4056)] public MuseumItemInfo musicItems__arr39;
        [FieldOffset(4160)] public MuseumItemInfo musicItems__arr40;
        [FieldOffset(4264)] public MuseumItemInfo musicItems__arr41;
        [FieldOffset(4368)] public MuseumItemInfo musicItems__arr42;
        [FieldOffset(4472)] public MuseumItemInfo musicItems__arr43;
        [FieldOffset(4576)] public MuseumItemInfo musicItems__arr44;
        [FieldOffset(4680)] public MuseumItemInfo musicItems__arr45;
        [FieldOffset(4784)] public MuseumItemInfo musicItems__arr46;
        [FieldOffset(4888)] public MuseumItemInfo musicItems__arr47;
        [FieldOffset(4992)] public MuseumItemInfo musicItems__arr48;
        [FieldOffset(5096)] public MuseumItemInfo musicItems__arr49;
        [FieldOffset(5200)] public MuseumItemInfo musicItems__arr50;
        [FieldOffset(5304)] public MuseumItemInfo musicItems__arr51;
        [FieldOffset(5408)] public MuseumItemInfo musicItems__arr52;
        [FieldOffset(5512)] public MuseumItemInfo musicItems__arr53;
        [FieldOffset(5616)] public MuseumItemInfo musicItems__arr54;
        [FieldOffset(5720)] public MuseumItemInfo musicItems__arr55;
        [FieldOffset(5824)] public MuseumItemInfo musicItems__arr56;
        [FieldOffset(5928)] public MuseumItemInfo musicItems__arr57;
        [FieldOffset(6032)] public MuseumItemInfo musicItems__arr58;
        [FieldOffset(6136)] public MuseumItemInfo musicItems__arr59;
        [FieldOffset(6240)] public MuseumItemInfo musicItems__arr60;
        [FieldOffset(6344)] public MuseumItemInfo musicItems__arr61;
        [FieldOffset(6448)] public MuseumItemInfo musicItems__arr62;
        [FieldOffset(6552)] public MuseumItemInfo musicItems__arr63;
        [FieldOffset(6656)] public MuseumItemInfo musicItems__arr64;
        [FieldOffset(6760)] public MuseumItemInfo musicItems__arr65;
        [FieldOffset(6864)] public MuseumItemInfo musicItems__arr66;
        [FieldOffset(6968)] public MuseumItemInfo musicItems__arr67;
        [FieldOffset(7072)] public MuseumItemInfo musicItems__arr68;
        [FieldOffset(7176)] public MuseumItemInfo musicItems__arr69;
        [FieldOffset(7280)] public MuseumItemInfo musicItems__arr70;
        [FieldOffset(7384)] public MuseumItemInfo musicItems__arr71;
        [FieldOffset(7488)] public MuseumItemInfo musicItems__arr72;
        [FieldOffset(7592)] public MuseumItemInfo musicItems__arr73;
        [FieldOffset(7696)] public MuseumItemInfo musicItems__arr74;
        [FieldOffset(7800)] public MuseumItemInfo musicItems__arr75;
        [FieldOffset(7904)] public MuseumItemInfo musicItems__arr76;
        [FieldOffset(8008)] public MuseumItemInfo musicItems__arr77;
        [FieldOffset(8112)] public MuseumItemInfo musicItems__arr78;
        [FieldOffset(8216)] public MuseumItemInfo musicItems__arr79;
        [FieldOffset(8320)] public MuseumItemInfo musicItems__arr80;
        [FieldOffset(8424)] public MuseumItemInfo musicItems__arr81;
        [FieldOffset(8528)] public MuseumItemInfo musicItems__arr82;
        [FieldOffset(8632)] public MuseumItemInfo musicItems__arr83;
        [FieldOffset(8736)] public MuseumItemInfo musicItems__arr84;
        [FieldOffset(8840)] public MuseumItemInfo musicItems__arr85;
        [FieldOffset(8944)] public MuseumItemInfo musicItems__arr86;
        [FieldOffset(9048)] public MuseumItemInfo musicItems__arr87;
        [FieldOffset(9152)] public MuseumItemInfo musicItems__arr88;
        [FieldOffset(9256)] public MuseumItemInfo musicItems__arr89;
        [FieldOffset(9360)] public MuseumItemInfo musicItems__arr90;
        [FieldOffset(9464)] public MuseumItemInfo musicItems__arr91;
        [FieldOffset(9568)] public MuseumItemInfo musicItems__arr92;
        [FieldOffset(9672)] public MuseumItemInfo musicItems__arr93;
        [FieldOffset(9776)] public MuseumItemInfo musicItems__arr94;
        [FieldOffset(9880)] public MuseumItemInfo musicItems__arr95;
        [FieldOffset(9984)] public MuseumItemInfo musicItems__arr96;
        [FieldOffset(10088)] public MuseumItemInfo musicItems__arr97;
        [FieldOffset(10192)] public MuseumItemInfo musicItems__arr98;
        [FieldOffset(10296)] public MuseumItemInfo musicItems__arr99;
        [FieldOffset(10400)] public MuseumItemInfo musicItems__arr100;
        [FieldOffset(10504)] public MuseumItemInfo musicItems__arr101;
        [FieldOffset(10608)] public MuseumItemInfo musicItems__arr102;
        [FieldOffset(10712)] public MuseumItemInfo musicItems__arr103;
        [FieldOffset(10816)] public MuseumItemInfo musicItems__arr104;
        [FieldOffset(10920)] public MuseumItemInfo musicItems__arr105;
        [FieldOffset(11024)] public MuseumItemInfo musicItems__arr106;
        [FieldOffset(11128)] public MuseumItemInfo musicItems__arr107;
        [FieldOffset(11232)] public MuseumItemInfo musicItems__arr108;
        [FieldOffset(11336)] public MuseumItemInfo musicItems__arr109;
        [FieldOffset(11440)] public MuseumItemInfo musicItems__arr110;
        [FieldOffset(11544)] public MuseumItemInfo musicItems__arr111;
        [FieldOffset(11648)] public MuseumItemInfo musicItems__arr112;
        [FieldOffset(11752)] public MuseumItemInfo musicItems__arr113;
        [FieldOffset(11856)] public MuseumItemInfo musicItems__arr114;
        [FieldOffset(11960)] public MuseumItemInfo musicItems__arr115;
        [FieldOffset(12064)] public MuseumItemInfo musicItems__arr116;
        [FieldOffset(12168)] public MuseumItemInfo musicItems__arr117;
        [FieldOffset(12272)] public MuseumItemInfo musicItems__arr118;
        [FieldOffset(12376)] public MuseumItemInfo musicItems__arr119;
        [FieldOffset(12480)] public MuseumItemInfo musicItems__arr120;
        [FieldOffset(12584)] public MuseumItemInfo musicItems__arr121;
        [FieldOffset(12688)] public MuseumItemInfo musicItems__arr122;
        [FieldOffset(12792)] public MuseumItemInfo musicItems__arr123;
        [FieldOffset(12896)] public MuseumItemInfo musicItems__arr124;
        [FieldOffset(13000)] public MuseumItemInfo musicItems__arr125;
        [FieldOffset(13104)] public MuseumItemInfo musicItems__arr126;
        [FieldOffset(13208)] public MuseumItemInfo musicItems__arr127;
        [FieldOffset(13312)] public MuseumItemInfo musicItems__arr128;
        [FieldOffset(13416)] public MuseumItemInfo musicItems__arr129;
        [FieldOffset(13520)] public MuseumItemInfo musicItems__arr130;
        [FieldOffset(13624)] public MuseumItemInfo musicItems__arr131;
        [FieldOffset(13728)] public MuseumItemInfo musicItems__arr132;
        [FieldOffset(13832)] public MuseumItemInfo musicItems__arr133;
        [FieldOffset(13936)] public MuseumItemInfo musicItems__arr134;
        [FieldOffset(14040)] public MuseumItemInfo musicItems__arr135;
        [FieldOffset(14144)] public MuseumItemInfo musicItems__arr136;
        [FieldOffset(14248)] public MuseumItemInfo musicItems__arr137;
        [FieldOffset(14352)] public MuseumItemInfo musicItems__arr138;
        [FieldOffset(14456)] public MuseumItemInfo musicItems__arr139;
        [FieldOffset(14560)] public MuseumItemInfo musicItems__arr140;
        [FieldOffset(14664)] public MuseumItemInfo musicItems__arr141;
        [FieldOffset(14768)] public MuseumItemInfo musicItems__arr142;
        [FieldOffset(14872)] public MuseumItemInfo musicItems__arr143;
        [FieldOffset(14976)] public MuseumItemInfo musicItems__arr144;
        [FieldOffset(15080)] public MuseumItemInfo musicItems__arr145;
        [FieldOffset(15184)] public MuseumItemInfo musicItems__arr146;
        [FieldOffset(15288)] public MuseumItemInfo musicItems__arr147;
        [FieldOffset(15392)] public MuseumItemInfo musicItems__arr148;
        [FieldOffset(15496)] public MuseumItemInfo musicItems__arr149;
        [FieldOffset(15600)] public MuseumItemInfo musicItems__arr150;
        [FieldOffset(15704)] public MuseumItemInfo musicItems__arr151;
        [FieldOffset(15808)] public MuseumItemInfo musicItems__arr152;
        [FieldOffset(15912)] public MuseumItemInfo musicItems__arr153;
        [FieldOffset(16016)] public MuseumItemInfo musicItems__arr154;
        [FieldOffset(16120)] public MuseumItemInfo musicItems__arr155;
        [FieldOffset(16224)] public MuseumItemInfo musicItems__arr156;
        [FieldOffset(16328)] public MuseumItemInfo musicItems__arr157;
        [FieldOffset(16432)] public MuseumItemInfo musicItems__arr158;
        [FieldOffset(16536)] public MuseumItemInfo musicItems__arr159;
        [FieldOffset(16640)] public MuseumItemInfo musicItems__arr160;
        [FieldOffset(16744)] public MuseumItemInfo musicItems__arr161;
        [FieldOffset(16848)] public MuseumItemInfo musicItems__arr162;
        [FieldOffset(16952)] public MuseumItemInfo musicItems__arr163;
        [FieldOffset(17056)] public MuseumItemInfo musicItems__arr164;
        [FieldOffset(17160)] public MuseumItemInfo musicItems__arr165;
        [FieldOffset(17264)] public MuseumItemInfo musicItems__arr166;
        [FieldOffset(17368)] public MuseumItemInfo musicItems__arr167;
        [FieldOffset(17472)] public MuseumItemInfo musicItems__arr168;
        [FieldOffset(17576)] public MuseumItemInfo musicItems__arr169;
        [FieldOffset(17680)] public MuseumItemInfo musicItems__arr170;
        [FieldOffset(17784)] public MuseumItemInfo musicItems__arr171;
        [FieldOffset(17888)] public MuseumItemInfo musicItems__arr172;
        [FieldOffset(17992)] public MuseumItemInfo musicItems__arr173;
        [FieldOffset(18096)] public MuseumItemInfo musicItems__arr174;
        [FieldOffset(18200)] public MuseumItemInfo musicItems__arr175;
        [FieldOffset(18304)] public MuseumItemInfo musicItems__arr176;
        [FieldOffset(18408)] public MuseumItemInfo musicItems__arr177;
        [FieldOffset(18512)] public MuseumItemInfo musicItems__arr178;
        [FieldOffset(18616)] public MuseumItemInfo musicItems__arr179;
        [FieldOffset(18720)] public MuseumItemInfo musicItems__arr180;
        [FieldOffset(18824)] public MuseumItemInfo musicItems__arr181;
        [FieldOffset(18928)] public MuseumItemInfo musicItems__arr182;
        [FieldOffset(19032)] public MuseumItemInfo musicItems__arr183;
        [FieldOffset(19136)] public MuseumItemInfo musicItems__arr184;
        [FieldOffset(19240)] public MuseumItemInfo musicItems__arr185;
        [FieldOffset(19344)] public MuseumItemInfo musicItems__arr186;
        [FieldOffset(19448)] public MuseumItemInfo musicItems__arr187;
        [FieldOffset(19552)] public MuseumItemInfo musicItems__arr188;
        [FieldOffset(19656)] public MuseumItemInfo musicItems__arr189;
        [FieldOffset(19760)] public MuseumItemInfo musicItems__arr190;
        [FieldOffset(19864)] public MuseumItemInfo musicItems__arr191;
        [FieldOffset(19968)] public MuseumItemInfo musicItems__arr192;
        [FieldOffset(20072)] public MuseumItemInfo musicItems__arr193;
        [FieldOffset(20176)] public MuseumItemInfo musicItems__arr194;
        [FieldOffset(20280)] public MuseumItemInfo musicItems__arr195;
        [FieldOffset(20384)] public MuseumItemInfo musicItems__arr196;
        [FieldOffset(20488)] public MuseumItemInfo musicItems__arr197;
        [FieldOffset(20592)] public MuseumItemInfo musicItems__arr198;
        [FieldOffset(20696)] public MuseumItemInfo musicItems__arr199;
        [FieldOffset(20800)] public MuseumItemInfo musicItems__arr200;
        [FieldOffset(20904)] public MuseumItemInfo musicItems__arr201;
        [FieldOffset(21008)] public MuseumItemInfo musicItems__arr202;
        [FieldOffset(21112)] public MuseumItemInfo musicItems__arr203;
        [FieldOffset(21216)] public MuseumItemInfo musicItems__arr204;
        [FieldOffset(21320)] public MuseumItemInfo musicItems__arr205;
        [FieldOffset(21424)] public MuseumItemInfo musicItems__arr206;
        [FieldOffset(21528)] public MuseumItemInfo musicItems__arr207;
        [FieldOffset(21632)] public MuseumItemInfo musicItems__arr208;
        [FieldOffset(21736)] public MuseumItemInfo musicItems__arr209;
        [FieldOffset(21840)] public MuseumItemInfo musicItems__arr210;
        [FieldOffset(21944)] public MuseumItemInfo musicItems__arr211;
        [FieldOffset(22048)] public MuseumItemInfo musicItems__arr212;
        [FieldOffset(22152)] public MuseumItemInfo musicItems__arr213;
        [FieldOffset(22256)] public MuseumItemInfo musicItems__arr214;
        [FieldOffset(22360)] public MuseumItemInfo musicItems__arr215;
        [FieldOffset(22464)] public MuseumItemInfo musicItems__arr216;
        [FieldOffset(22568)] public MuseumItemInfo musicItems__arr217;
        [FieldOffset(22672)] public MuseumItemInfo musicItems__arr218;
        [FieldOffset(22776)] public MuseumItemInfo musicItems__arr219;
        [FieldOffset(22880)] public MuseumItemInfo musicItems__arr220;
        [FieldOffset(22984)] public MuseumItemInfo musicItems__arr221;
        [FieldOffset(23088)] public MuseumItemInfo musicItems__arr222;
        [FieldOffset(23192)] public MuseumItemInfo musicItems__arr223;
        [FieldOffset(23296)] public MuseumItemInfo musicItems__arr224;
        [FieldOffset(23400)] public MuseumItemInfo musicItems__arr225;
        [FieldOffset(23504)] public MuseumItemInfo musicItems__arr226;
        [FieldOffset(23608)] public MuseumItemInfo musicItems__arr227;
        [FieldOffset(23712)] public MuseumItemInfo musicItems__arr228;
        [FieldOffset(23816)] public MuseumItemInfo musicItems__arr229;
        [FieldOffset(23920)] public MuseumItemInfo musicItems__arr230;
        [FieldOffset(24024)] public MuseumItemInfo musicItems__arr231;
        [FieldOffset(24128)] public MuseumItemInfo musicItems__arr232;
        [FieldOffset(24232)] public MuseumItemInfo musicItems__arr233;
        [FieldOffset(24336)] public MuseumItemInfo musicItems__arr234;
        [FieldOffset(24440)] public MuseumItemInfo musicItems__arr235;
        [FieldOffset(24544)] public MuseumItemInfo musicItems__arr236;
        [FieldOffset(24648)] public MuseumItemInfo musicItems__arr237;
        [FieldOffset(24752)] public MuseumItemInfo musicItems__arr238;
        [FieldOffset(24856)] public MuseumItemInfo musicItems__arr239;
        [FieldOffset(24960)] public MuseumItemInfo musicItems__arr240;
        [FieldOffset(25064)] public MuseumItemInfo musicItems__arr241;
        [FieldOffset(25168)] public MuseumItemInfo musicItems__arr242;
        [FieldOffset(25272)] public MuseumItemInfo musicItems__arr243;
        [FieldOffset(25376)] public MuseumItemInfo musicItems__arr244;
        [FieldOffset(25480)] public MuseumItemInfo musicItems__arr245;
        [FieldOffset(25584)] public MuseumItemInfo musicItems__arr246;
        [FieldOffset(25688)] public MuseumItemInfo musicItems__arr247;
        [FieldOffset(25792)] public MuseumItemInfo musicItems__arr248;
        [FieldOffset(25896)] public MuseumItemInfo musicItems__arr249;
        [FieldOffset(26000)] public MuseumItemInfo musicItems__arr250;
        [FieldOffset(26104)] public MuseumItemInfo musicItems__arr251;
        [FieldOffset(26208)] public MuseumItemInfo musicItems__arr252;
        [FieldOffset(26312)] public MuseumItemInfo musicItems__arr253;
        [FieldOffset(26416)] public MuseumItemInfo musicItems__arr254;
        [FieldOffset(26520)] public MuseumItemInfo musicItems__arr255;
        [FieldOffset(26624)] public MuseumItemInfo musicItems__arr256;
        [FieldOffset(26728)] public MuseumItemInfo musicItems__arr257;
        [FieldOffset(26832)] public MuseumItemInfo musicItems__arr258;
        [FieldOffset(26936)] public MuseumItemInfo musicItems__arr259;
        [FieldOffset(27040)] public MuseumItemInfo musicItems__arr260;
        [FieldOffset(27144)] public MuseumItemInfo musicItems__arr261;
        [FieldOffset(27248)] public MuseumItemInfo musicItems__arr262;
        [FieldOffset(27352)] public MuseumItemInfo musicItems__arr263;
        [FieldOffset(27456)] public MuseumItemInfo musicItems__arr264;
        [FieldOffset(27560)] public MuseumItemInfo musicItems__arr265;
        [FieldOffset(27664)] public MuseumItemInfo musicItems__arr266;
        [FieldOffset(27768)] public MuseumItemInfo musicItems__arr267;
        [FieldOffset(27872)] public MuseumItemInfo musicItems__arr268;
        [FieldOffset(27976)] public MuseumItemInfo musicItems__arr269;
        [FieldOffset(28080)] public MuseumItemInfo musicItems__arr270;
        [FieldOffset(28184)] public MuseumItemInfo musicItems__arr271;
        [FieldOffset(28288)] public MuseumItemInfo musicItems__arr272;
        [FieldOffset(28392)] public MuseumItemInfo musicItems__arr273;
        [FieldOffset(28496)] public MuseumItemInfo musicItems__arr274;
        [FieldOffset(28600)] public MuseumItemInfo musicItems__arr275;
        [FieldOffset(28704)] public MuseumItemInfo musicItems__arr276;
        [FieldOffset(28808)] public MuseumItemInfo musicItems__arr277;
        [FieldOffset(28912)] public MuseumItemInfo musicItems__arr278;
        [FieldOffset(29016)] public MuseumItemInfo musicItems__arr279;
        [FieldOffset(29120)] public MuseumItemInfo musicItems__arr280;
        [FieldOffset(29224)] public MuseumItemInfo musicItems__arr281;
        [FieldOffset(29328)] public MuseumItemInfo musicItems__arr282;
        [FieldOffset(29432)] public MuseumItemInfo musicItems__arr283;
        [FieldOffset(29536)] public MuseumItemInfo musicItems__arr284;
        [FieldOffset(29640)] public MuseumItemInfo musicItems__arr285;
        [FieldOffset(29744)] public MuseumItemInfo musicItems__arr286;
        [FieldOffset(29848)] public MuseumItemInfo musicItems__arr287;
        [FieldOffset(29952)] public MuseumItemInfo musicItems__arr288;
        [FieldOffset(30056)] public MuseumItemInfo musicItems__arr289;
        [FieldOffset(30160)] public MuseumItemInfo musicItems__arr290;
        [FieldOffset(30264)] public MuseumItemInfo musicItems__arr291;
        [FieldOffset(30368)] public MuseumItemInfo musicItems__arr292;
        [FieldOffset(30472)] public MuseumItemInfo musicItems__arr293;
        [FieldOffset(30576)] public MuseumItemInfo musicItems__arr294;
        [FieldOffset(30680)] public MuseumItemInfo musicItems__arr295;
        [FieldOffset(30784)] public MuseumItemInfo musicItems__arr296;
        [FieldOffset(30888)] public MuseumItemInfo musicItems__arr297;
        [FieldOffset(30992)] public MuseumItemInfo musicItems__arr298;
        [FieldOffset(31096)] public MuseumItemInfo musicItems__arr299;
        [FieldOffset(31200)] public MuseumItemInfo musicItems__arr300;
        [FieldOffset(31304)] public MuseumItemInfo musicItems__arr301;
        [FieldOffset(31408)] public MuseumItemInfo musicItems__arr302;
        [FieldOffset(31512)] public MuseumItemInfo musicItems__arr303;
        [FieldOffset(31616)] public MuseumItemInfo musicItems__arr304;
        [FieldOffset(31720)] public MuseumItemInfo musicItems__arr305;
        [FieldOffset(31824)] public MuseumItemInfo musicItems__arr306;
        [FieldOffset(31928)] public MuseumItemInfo musicItems__arr307;
        [FieldOffset(32032)] public MuseumItemInfo musicItems__arr308;
        [FieldOffset(32136)] public MuseumItemInfo musicItems__arr309;
        [FieldOffset(32240)] public MuseumItemInfo musicItems__arr310;
        [FieldOffset(32344)] public MuseumItemInfo musicItems__arr311;
        [FieldOffset(32448)] public MuseumItemInfo musicItems__arr312;
        [FieldOffset(32552)] public MuseumItemInfo musicItems__arr313;
        [FieldOffset(32656)] public MuseumItemInfo musicItems__arr314;
        [FieldOffset(32760)] public MuseumItemInfo musicItems__arr315;
        [FieldOffset(32864)] public MuseumItemInfo musicItems__arr316;
        [FieldOffset(32968)] public MuseumItemInfo musicItems__arr317;
        [FieldOffset(33072)] public MuseumItemInfo musicItems__arr318;
        [FieldOffset(33176)] public MuseumItemInfo musicItems__arr319;
        [FieldOffset(33280)] public MuseumItemInfo musicItems__arr320;
        [FieldOffset(33384)] public MuseumItemInfo musicItems__arr321;
        [FieldOffset(33488)] public MuseumItemInfo musicItems__arr322;
        [FieldOffset(33592)] public MuseumItemInfo musicItems__arr323;
        [FieldOffset(33696)] public MuseumItemInfo musicItems__arr324;
        [FieldOffset(33800)] public MuseumItemInfo musicItems__arr325;
        [FieldOffset(33904)] public MuseumItemInfo musicItems__arr326;
        [FieldOffset(34008)] public MuseumItemInfo musicItems__arr327;
        [FieldOffset(34112)] public MuseumItemInfo musicItems__arr328;
        [FieldOffset(34216)] public MuseumItemInfo musicItems__arr329;
        [FieldOffset(34320)] public MuseumItemInfo musicItems__arr330;
        [FieldOffset(34424)] public MuseumItemInfo musicItems__arr331;
        [FieldOffset(34528)] public MuseumItemInfo musicItems__arr332;
        [FieldOffset(34632)] public MuseumItemInfo musicItems__arr333;
        [FieldOffset(34736)] public MuseumItemInfo musicItems__arr334;
        [FieldOffset(34840)] public MuseumItemInfo musicItems__arr335;
        [FieldOffset(34944)] public MuseumItemInfo musicItems__arr336;
        [FieldOffset(35048)] public MuseumItemInfo musicItems__arr337;
        [FieldOffset(35152)] public MuseumItemInfo musicItems__arr338;
        [FieldOffset(35256)] public MuseumItemInfo musicItems__arr339;
        [FieldOffset(35360)] public MuseumItemInfo musicItems__arr340;
        [FieldOffset(35464)] public MuseumItemInfo musicItems__arr341;
        [FieldOffset(35568)] public MuseumItemInfo musicItems__arr342;
        [FieldOffset(35672)] public MuseumItemInfo musicItems__arr343;
        [FieldOffset(35776)] public MuseumItemInfo musicItems__arr344;
        [FieldOffset(35880)] public MuseumItemInfo musicItems__arr345;
        [FieldOffset(35984)] public MuseumItemInfo musicItems__arr346;
        [FieldOffset(36088)] public MuseumItemInfo musicItems__arr347;
        [FieldOffset(36192)] public MuseumItemInfo musicItems__arr348;
        [FieldOffset(36296)] public MuseumItemInfo musicItems__arr349;
        [FieldOffset(36400)] public MuseumItemInfo musicItems__arr350;
        [FieldOffset(36504)] public MuseumItemInfo musicItems__arr351;
        [FieldOffset(36608)] public MuseumItemInfo musicItems__arr352;
        [FieldOffset(36712)] public MuseumItemInfo musicItems__arr353;
        [FieldOffset(36816)] public MuseumItemInfo musicItems__arr354;
        [FieldOffset(36920)] public MuseumItemInfo musicItems__arr355;
        [FieldOffset(37024)] public MuseumItemInfo musicItems__arr356;
        [FieldOffset(37128)] public MuseumItemInfo musicItems__arr357;
        [FieldOffset(37232)] public MuseumItemInfo musicItems__arr358;
        [FieldOffset(37336)] public MuseumItemInfo musicItems__arr359;
        [FieldOffset(37440)] public MuseumItemInfo musicItems__arr360;
        [FieldOffset(37544)] public MuseumItemInfo musicItems__arr361;
        [FieldOffset(37648)] public MuseumItemInfo musicItems__arr362;
        [FieldOffset(37752)] public MuseumItemInfo musicItems__arr363;
        [FieldOffset(37856)] public MuseumItemInfo musicItems__arr364;
        [FieldOffset(37960)] public MuseumItemInfo musicItems__arr365;
        [FieldOffset(38064)] public MuseumItemInfo musicItems__arr366;
        [FieldOffset(38168)] public MuseumItemInfo musicItems__arr367;
        [FieldOffset(38272)] public MuseumItemInfo musicItems__arr368;
        [FieldOffset(38376)] public MuseumItemInfo musicItems__arr369;
        [FieldOffset(38480)] public MuseumItemInfo musicItems__arr370;
        [FieldOffset(38584)] public MuseumItemInfo musicItems__arr371;
        [FieldOffset(38688)] public MuseumItemInfo musicItems__arr372;
        [FieldOffset(38792)] public MuseumItemInfo musicItems__arr373;
        [FieldOffset(38896)] public MuseumItemInfo musicItems__arr374;
        [FieldOffset(39000)] public MuseumItemInfo musicItems__arr375;
        [FieldOffset(39104)] public MuseumItemInfo musicItems__arr376;
        [FieldOffset(39208)] public MuseumItemInfo musicItems__arr377;
        [FieldOffset(39312)] public MuseumItemInfo musicItems__arr378;
        [FieldOffset(39416)] public MuseumItemInfo musicItems__arr379;
        [FieldOffset(39520)] public MuseumItemInfo musicItems__arr380;
        [FieldOffset(39624)] public MuseumItemInfo musicItems__arr381;
        [FieldOffset(39728)] public MuseumItemInfo musicItems__arr382;
        [FieldOffset(39832)] public MuseumItemInfo musicItems__arr383;
        [FieldOffset(39936)] public MuseumItemInfo musicItems__arr384;
        [FieldOffset(40040)] public MuseumItemInfo musicItems__arr385;
        [FieldOffset(40144)] public MuseumItemInfo musicItems__arr386;
        [FieldOffset(40248)] public MuseumItemInfo musicItems__arr387;
        [FieldOffset(40352)] public MuseumItemInfo musicItems__arr388;
        [FieldOffset(40456)] public MuseumItemInfo musicItems__arr389;
        [FieldOffset(40560)] public MuseumItemInfo musicItems__arr390;
        [FieldOffset(40664)] public MuseumItemInfo musicItems__arr391;
        [FieldOffset(40768)] public MuseumItemInfo musicItems__arr392;
        [FieldOffset(40872)] public MuseumItemInfo musicItems__arr393;
        [FieldOffset(40976)] public MuseumItemInfo musicItems__arr394;
        [FieldOffset(41080)] public MuseumItemInfo musicItems__arr395;
        [FieldOffset(41184)] public MuseumItemInfo musicItems__arr396;
        [FieldOffset(41288)] public MuseumItemInfo musicItems__arr397;
        [FieldOffset(41392)] public MuseumItemInfo musicItems__arr398;
        [FieldOffset(41496)] public MuseumItemInfo musicItems__arr399;
        [FieldOffset(41600)] public MuseumItemInfo musicItems__arr400;
        [FieldOffset(41704)] public MuseumItemInfo artItems__arr0;
        [FieldOffset(41808)] public MuseumItemInfo artItems__arr1;
        [FieldOffset(41912)] public MuseumItemInfo artItems__arr2;
        [FieldOffset(42016)] public MuseumItemInfo artItems__arr3;
        [FieldOffset(42120)] public MuseumItemInfo artItems__arr4;
        [FieldOffset(42224)] public MuseumItemInfo artItems__arr5;
        [FieldOffset(42328)] public MuseumItemInfo artItems__arr6;
        [FieldOffset(42432)] public MuseumItemInfo artItems__arr7;
        [FieldOffset(42536)] public MuseumItemInfo artItems__arr8;
        [FieldOffset(42640)] public MuseumItemInfo artItems__arr9;
        [FieldOffset(42744)] public MuseumItemInfo artItems__arr10;
        [FieldOffset(42848)] public MuseumItemInfo artItems__arr11;
        [FieldOffset(42952)] public MuseumItemInfo artItems__arr12;
        [FieldOffset(43056)] public MuseumItemInfo artItems__arr13;
        [FieldOffset(43160)] public MuseumItemInfo artItems__arr14;
        [FieldOffset(43264)] public MuseumItemInfo artItems__arr15;
        [FieldOffset(43368)] public MuseumItemInfo artItems__arr16;
        [FieldOffset(43472)] public MuseumItemInfo artItems__arr17;
        [FieldOffset(43576)] public MuseumItemInfo artItems__arr18;
        [FieldOffset(43680)] public MuseumItemInfo artItems__arr19;
        [FieldOffset(43784)] public MuseumItemInfo artItems__arr20;
        [FieldOffset(43888)] public MuseumItemInfo artItems__arr21;
        [FieldOffset(43992)] public MuseumItemInfo artItems__arr22;
        [FieldOffset(44096)] public MuseumItemInfo artItems__arr23;
        [FieldOffset(44200)] public MuseumItemInfo artItems__arr24;
        [FieldOffset(44304)] public MuseumItemInfo artItems__arr25;
        [FieldOffset(44408)] public MuseumItemInfo artItems__arr26;
        [FieldOffset(44512)] public MuseumItemInfo artItems__arr27;
        [FieldOffset(44616)] public MuseumItemInfo artItems__arr28;
        [FieldOffset(44720)] public MuseumItemInfo artItems__arr29;
        [FieldOffset(44824)] public MuseumItemInfo artItems__arr30;
        [FieldOffset(44928)] public MuseumItemInfo artItems__arr31;
        [FieldOffset(45032)] public MuseumItemInfo artItems__arr32;
        [FieldOffset(45136)] public MuseumItemInfo artItems__arr33;
        [FieldOffset(45240)] public MuseumItemInfo artItems__arr34;
        [FieldOffset(45344)] public MuseumItemInfo artItems__arr35;
        [FieldOffset(45448)] public MuseumItemInfo artItems__arr36;
        [FieldOffset(45552)] public MuseumItemInfo artItems__arr37;
        [FieldOffset(45656)] public MuseumItemInfo artItems__arr38;
        [FieldOffset(45760)] public MuseumItemInfo artItems__arr39;
        [FieldOffset(45864)] public MuseumItemInfo artItems__arr40;
        [FieldOffset(45968)] public MuseumItemInfo artItems__arr41;
        [FieldOffset(46072)] public MuseumItemInfo artItems__arr42;
        [FieldOffset(46176)] public MuseumItemInfo artItems__arr43;
        [FieldOffset(46280)] public MuseumItemInfo artItems__arr44;
        [FieldOffset(46384)] public MuseumItemInfo artItems__arr45;
        [FieldOffset(46488)] public MuseumItemInfo artItems__arr46;
        [FieldOffset(46592)] public MuseumItemInfo artItems__arr47;
        [FieldOffset(46696)] public MuseumItemInfo artItems__arr48;
        [FieldOffset(46800)] public MuseumItemInfo artItems__arr49;
        [FieldOffset(46904)] public MuseumItemInfo artItems__arr50;
        [FieldOffset(47008)] public MuseumItemInfo artItems__arr51;
        [FieldOffset(47112)] public MuseumItemInfo artItems__arr52;
        [FieldOffset(47216)] public MuseumItemInfo artItems__arr53;
        [FieldOffset(47320)] public MuseumItemInfo artItems__arr54;
        [FieldOffset(47424)] public MuseumItemInfo artItems__arr55;
        [FieldOffset(47528)] public MuseumItemInfo artItems__arr56;
        [FieldOffset(47632)] public MuseumItemInfo artItems__arr57;
        [FieldOffset(47736)] public MuseumItemInfo artItems__arr58;
        [FieldOffset(47840)] public MuseumItemInfo artItems__arr59;
        [FieldOffset(47944)] public MuseumItemInfo artItems__arr60;
        [FieldOffset(48048)] public MuseumItemInfo artItems__arr61;
        [FieldOffset(48152)] public MuseumItemInfo artItems__arr62;
        [FieldOffset(48256)] public MuseumItemInfo artItems__arr63;
        [FieldOffset(48360)] public MuseumItemInfo artItems__arr64;
        [FieldOffset(48464)] public MuseumItemInfo artItems__arr65;
        [FieldOffset(48568)] public MuseumItemInfo artItems__arr66;
        [FieldOffset(48672)] public MuseumItemInfo artItems__arr67;
        [FieldOffset(48776)] public MuseumItemInfo artItems__arr68;
        [FieldOffset(48880)] public MuseumItemInfo artItems__arr69;
        [FieldOffset(48984)] public MuseumItemInfo artItems__arr70;
        [FieldOffset(49088)] public MuseumItemInfo artItems__arr71;
        [FieldOffset(49192)] public MuseumItemInfo artItems__arr72;
        [FieldOffset(49296)] public MuseumItemInfo artItems__arr73;
        [FieldOffset(49400)] public MuseumItemInfo artItems__arr74;
        [FieldOffset(49504)] public MuseumItemInfo artItems__arr75;
        [FieldOffset(49608)] public MuseumItemInfo artItems__arr76;
        [FieldOffset(49712)] public MuseumItemInfo artItems__arr77;
        [FieldOffset(49816)] public MuseumItemInfo artItems__arr78;
        [FieldOffset(49920)] public MuseumItemInfo artItems__arr79;
        [FieldOffset(50024)] public MuseumItemInfo artItems__arr80;
        [FieldOffset(50128)] public MuseumItemInfo artItems__arr81;
        [FieldOffset(50232)] public MuseumItemInfo artItems__arr82;
        [FieldOffset(50336)] public MuseumItemInfo artItems__arr83;
        [FieldOffset(50440)] public MuseumItemInfo artItems__arr84;
        [FieldOffset(50544)] public MuseumItemInfo artItems__arr85;
        [FieldOffset(50648)] public MuseumItemInfo artItems__arr86;
        [FieldOffset(50752)] public MuseumItemInfo artItems__arr87;
        [FieldOffset(50856)] public MuseumItemInfo artItems__arr88;
        [FieldOffset(50960)] public MuseumItemInfo artItems__arr89;
        [FieldOffset(51064)] public MuseumItemInfo artItems__arr90;
        [FieldOffset(51168)] public MuseumItemInfo artItems__arr91;
        [FieldOffset(51272)] public MuseumItemInfo artItems__arr92;
        [FieldOffset(51376)] public MuseumItemInfo artItems__arr93;
        [FieldOffset(51480)] public MuseumItemInfo artItems__arr94;
        [FieldOffset(51584)] public MuseumItemInfo artItems__arr95;
        [FieldOffset(51688)] public MuseumItemInfo artItems__arr96;
        [FieldOffset(51792)] public MuseumItemInfo artItems__arr97;
        [FieldOffset(51896)] public MuseumItemInfo artItems__arr98;
        [FieldOffset(52000)] public MuseumItemInfo artItems__arr99;
        [FieldOffset(52104)] public MuseumItemInfo artItems__arr100;
        [FieldOffset(52208)] public MuseumItemInfo artItems__arr101;
        [FieldOffset(52312)] public MuseumItemInfo artItems__arr102;
        [FieldOffset(52416)] public MuseumItemInfo artItems__arr103;
        [FieldOffset(52520)] public MuseumItemInfo artItems__arr104;
        [FieldOffset(52624)] public MuseumItemInfo artItems__arr105;
        [FieldOffset(52728)] public MuseumItemInfo artItems__arr106;
        [FieldOffset(52832)] public MuseumItemInfo artItems__arr107;
        [FieldOffset(52936)] public MuseumItemInfo artItems__arr108;
        [FieldOffset(53040)] public MuseumItemInfo artItems__arr109;
        [FieldOffset(53144)] public MuseumItemInfo artItems__arr110;
        [FieldOffset(53248)] public MuseumItemInfo artItems__arr111;
        [FieldOffset(53352)] public MuseumItemInfo artItems__arr112;
        [FieldOffset(53456)] public MuseumItemInfo artItems__arr113;
        [FieldOffset(53560)] public MuseumItemInfo artItems__arr114;
        [FieldOffset(53664)] public MuseumItemInfo artItems__arr115;
        [FieldOffset(53768)] public MuseumItemInfo artItems__arr116;
        [FieldOffset(53872)] public MuseumItemInfo artItems__arr117;
        [FieldOffset(53976)] public MuseumItemInfo artItems__arr118;
        [FieldOffset(54080)] public MuseumItemInfo artItems__arr119;
        [FieldOffset(54184)] public MuseumItemInfo artItems__arr120;
        [FieldOffset(54288)] public MuseumItemInfo artItems__arr121;
        [FieldOffset(54392)] public MuseumItemInfo artItems__arr122;
        [FieldOffset(54496)] public MuseumItemInfo artItems__arr123;
        [FieldOffset(54600)] public MuseumItemInfo artItems__arr124;
        [FieldOffset(54704)] public MuseumItemInfo artItems__arr125;
        [FieldOffset(54808)] public MuseumItemInfo artItems__arr126;
        [FieldOffset(54912)] public MuseumItemInfo artItems__arr127;
        [FieldOffset(55016)] public MuseumItemInfo artItems__arr128;
        [FieldOffset(55120)] public MuseumItemInfo artItems__arr129;
        [FieldOffset(55224)] public MuseumItemInfo artItems__arr130;
        [FieldOffset(55328)] public MuseumItemInfo artItems__arr131;
        [FieldOffset(55432)] public MuseumItemInfo artItems__arr132;
        [FieldOffset(55536)] public MuseumItemInfo artItems__arr133;
        [FieldOffset(55640)] public MuseumItemInfo artItems__arr134;
        [FieldOffset(55744)] public MuseumItemInfo artItems__arr135;
        [FieldOffset(55848)] public MuseumItemInfo artItems__arr136;
        [FieldOffset(55952)] public MuseumItemInfo artItems__arr137;
        [FieldOffset(56056)] public MuseumItemInfo artItems__arr138;
        [FieldOffset(56160)] public MuseumItemInfo artItems__arr139;
        [FieldOffset(56264)] public MuseumItemInfo artItems__arr140;
        [FieldOffset(56368)] public MuseumItemInfo artItems__arr141;
        [FieldOffset(56472)] public MuseumItemInfo artItems__arr142;
        [FieldOffset(56576)] public MuseumItemInfo artItems__arr143;
        [FieldOffset(56680)] public MuseumItemInfo artItems__arr144;
        [FieldOffset(56784)] public MuseumItemInfo artItems__arr145;
        [FieldOffset(56888)] public MuseumItemInfo artItems__arr146;
        [FieldOffset(56992)] public MuseumItemInfo artItems__arr147;
        [FieldOffset(57096)] public MuseumItemInfo artItems__arr148;
        [FieldOffset(57200)] public MuseumItemInfo artItems__arr149;
        [FieldOffset(57304)] public MuseumItemInfo artItems__arr150;
        [FieldOffset(57408)] public MuseumItemInfo artItems__arr151;
        [FieldOffset(57512)] public MuseumItemInfo artItems__arr152;
        [FieldOffset(57616)] public MuseumItemInfo artItems__arr153;
        [FieldOffset(57720)] public MuseumItemInfo artItems__arr154;
        [FieldOffset(57824)] public MuseumItemInfo artItems__arr155;
        [FieldOffset(57928)] public MuseumItemInfo artItems__arr156;
        [FieldOffset(58032)] public MuseumItemInfo artItems__arr157;
        [FieldOffset(58136)] public MuseumItemInfo artItems__arr158;
        [FieldOffset(58240)] public MuseumItemInfo artItems__arr159;
        [FieldOffset(58344)] public MuseumItemInfo artItems__arr160;
        [FieldOffset(58448)] public MuseumItemInfo artItems__arr161;
        [FieldOffset(58552)] public MuseumItemInfo artItems__arr162;
        [FieldOffset(58656)] public MuseumItemInfo artItems__arr163;
        [FieldOffset(58760)] public MuseumItemInfo artItems__arr164;
        [FieldOffset(58864)] public MuseumItemInfo artItems__arr165;
        [FieldOffset(58968)] public MuseumItemInfo artItems__arr166;
        [FieldOffset(59072)] public MuseumItemInfo artItems__arr167;
        [FieldOffset(59176)] public MuseumItemInfo artItems__arr168;
        [FieldOffset(59280)] public MuseumItemInfo artItems__arr169;
        [FieldOffset(59384)] public MuseumItemInfo artItems__arr170;
        [FieldOffset(59488)] public MuseumItemInfo artItems__arr171;
        [FieldOffset(59592)] public MuseumItemInfo artItems__arr172;
        [FieldOffset(59696)] public MuseumItemInfo artItems__arr173;
        [FieldOffset(59800)] public MuseumItemInfo artItems__arr174;
        [FieldOffset(59904)] public MuseumItemInfo artItems__arr175;
        [FieldOffset(60008)] public MuseumItemInfo artItems__arr176;
        [FieldOffset(60112)] public MuseumItemInfo artItems__arr177;
        [FieldOffset(60216)] public MuseumItemInfo artItems__arr178;
        [FieldOffset(60320)] public MuseumItemInfo artItems__arr179;
        [FieldOffset(60424)] public MuseumItemInfo artItems__arr180;
        [FieldOffset(60528)] public MuseumItemInfo artItems__arr181;
        [FieldOffset(60632)] public MuseumItemInfo artItems__arr182;
        [FieldOffset(60736)] public MuseumItemInfo artItems__arr183;
        [FieldOffset(60840)] public MuseumItemInfo artItems__arr184;
        [FieldOffset(60944)] public MuseumItemInfo artItems__arr185;
        [FieldOffset(61048)] public MuseumItemInfo artItems__arr186;
        [FieldOffset(61152)] public MuseumItemInfo artItems__arr187;
        [FieldOffset(61256)] public MuseumItemInfo artItems__arr188;
        [FieldOffset(61360)] public MuseumItemInfo artItems__arr189;
        [FieldOffset(61464)] public MuseumItemInfo artItems__arr190;
        [FieldOffset(61568)] public MuseumItemInfo artItems__arr191;
        [FieldOffset(61672)] public MuseumItemInfo artItems__arr192;
        [FieldOffset(61776)] public MuseumItemInfo artItems__arr193;
        [FieldOffset(61880)] public MuseumItemInfo artItems__arr194;
        [FieldOffset(61984)] public MuseumItemInfo artItems__arr195;
        [FieldOffset(62088)] public MuseumItemInfo artItems__arr196;
        [FieldOffset(62192)] public MuseumItemInfo artItems__arr197;
        [FieldOffset(62296)] public MuseumItemInfo artItems__arr198;
        [FieldOffset(62400)] public MuseumItemInfo artItems__arr199;
        [FieldOffset(62504)] public MuseumItemInfo artItems__arr200;
        [FieldOffset(62608)] public MuseumItemInfo artItems__arr201;
        [FieldOffset(62712)] public MuseumItemInfo artItems__arr202;
        [FieldOffset(62816)] public MuseumItemInfo artItems__arr203;
        [FieldOffset(62920)] public MuseumItemInfo artItems__arr204;
        [FieldOffset(63024)] public MuseumItemInfo artItems__arr205;
        [FieldOffset(63128)] public MuseumItemInfo artItems__arr206;
        [FieldOffset(63232)] public MuseumItemInfo artItems__arr207;
        [FieldOffset(63336)] public MuseumItemInfo artItems__arr208;
        [FieldOffset(63440)] public MuseumItemInfo artItems__arr209;
        [FieldOffset(63544)] public MuseumItemInfo artItems__arr210;
        [FieldOffset(63648)] public MuseumItemInfo artItems__arr211;
        [FieldOffset(63752)] public MuseumItemInfo artItems__arr212;
        [FieldOffset(63856)] public MuseumItemInfo artItems__arr213;
        [FieldOffset(63960)] public MuseumItemInfo artItems__arr214;
        [FieldOffset(64064)] public MuseumItemInfo artItems__arr215;
        [FieldOffset(64168)] public MuseumItemInfo artItems__arr216;
        [FieldOffset(64272)] public MuseumItemInfo artItems__arr217;
        [FieldOffset(64376)] public MuseumItemInfo artItems__arr218;
        [FieldOffset(64480)] public MuseumItemInfo artItems__arr219;
        [FieldOffset(64584)] public MuseumItemInfo artItems__arr220;
        [FieldOffset(64688)] public MuseumItemInfo artItems__arr221;
        [FieldOffset(64792)] public MuseumItemInfo artItems__arr222;
        [FieldOffset(64896)] public MuseumItemInfo artItems__arr223;
        [FieldOffset(65000)] public MuseumItemInfo artItems__arr224;
        [FieldOffset(65104)] public MuseumItemInfo artItems__arr225;
        [FieldOffset(65208)] public MuseumItemInfo artItems__arr226;
        [FieldOffset(65312)] public MuseumItemInfo artItems__arr227;
        [FieldOffset(65416)] public MuseumItemInfo artItems__arr228;
        [FieldOffset(65520)] public MuseumItemInfo artItems__arr229;
        [FieldOffset(65624)] public MuseumItemInfo artItems__arr230;
        [FieldOffset(65728)] public MuseumItemInfo artItems__arr231;
        [FieldOffset(65832)] public MuseumItemInfo artItems__arr232;
        [FieldOffset(65936)] public MuseumItemInfo artItems__arr233;
        [FieldOffset(66040)] public MuseumItemInfo artItems__arr234;
        [FieldOffset(66144)] public MuseumItemInfo artItems__arr235;
        [FieldOffset(66248)] public MuseumItemInfo artItems__arr236;
        [FieldOffset(66352)] public MuseumItemInfo artItems__arr237;
        [FieldOffset(66456)] public MuseumItemInfo artItems__arr238;
        [FieldOffset(66560)] public MuseumItemInfo artItems__arr239;
        [FieldOffset(66664)] public MuseumItemInfo artItems__arr240;
        [FieldOffset(66768)] public MuseumItemInfo artItems__arr241;
        [FieldOffset(66872)] public MuseumItemInfo artItems__arr242;
        [FieldOffset(66976)] public MuseumItemInfo artItems__arr243;
        [FieldOffset(67080)] public MuseumItemInfo artItems__arr244;
        [FieldOffset(67184)] public MuseumItemInfo artItems__arr245;
        [FieldOffset(67288)] public MuseumItemInfo artItems__arr246;
        [FieldOffset(67392)] public MuseumItemInfo artItems__arr247;
        [FieldOffset(67496)] public MuseumItemInfo artItems__arr248;
        [FieldOffset(67600)] public MuseumItemInfo artItems__arr249;
        [FieldOffset(67704)] public MuseumItemInfo artItems__arr250;
        [FieldOffset(67808)] public MuseumItemInfo movieItems__arr0;
        [FieldOffset(67912)] public MuseumItemInfo movieItems__arr1;
        [FieldOffset(68016)] public MuseumItemInfo movieItems__arr2;
        [FieldOffset(68120)] public MuseumItemInfo movieItems__arr3;
        [FieldOffset(68224)] public MuseumItemInfo movieItems__arr4;
        [FieldOffset(68328)] public MuseumItemInfo movieItems__arr5;
        [FieldOffset(68432)] public MuseumItemInfo movieItems__arr6;
        [FieldOffset(68536)] public MuseumItemInfo movieItems__arr7;
        [FieldOffset(68640)] public MuseumItemInfo movieItems__arr8;
        [FieldOffset(68744)] public MuseumItemInfo movieItems__arr9;
        [FieldOffset(68848)] public MuseumItemInfo movieItems__arr10;
        [FieldOffset(68952)] public MuseumItemInfo movieItems__arr11;
        [FieldOffset(69056)] public MuseumItemInfo movieItems__arr12;
        [FieldOffset(69160)] public MuseumItemInfo movieItems__arr13;
        [FieldOffset(69264)] public MuseumItemInfo movieItems__arr14;
        [FieldOffset(69368)] public MuseumItemInfo movieItems__arr15;
        [FieldOffset(69472)] public MuseumItemInfo movieItems__arr16;
        [FieldOffset(69576)] public MuseumItemInfo movieItems__arr17;
        [FieldOffset(69680)] public MuseumItemInfo movieItems__arr18;
        [FieldOffset(69784)] public MuseumItemInfo movieItems__arr19;
        [FieldOffset(69888)] public MuseumItemInfo movieItems__arr20;
        [FieldOffset(69992)] public MuseumItemInfo movieItems__arr21;
        [FieldOffset(70096)] public MuseumItemInfo movieItems__arr22;
        [FieldOffset(70200)] public MuseumItemInfo movieItems__arr23;
        [FieldOffset(70304)] public MuseumItemInfo movieItems__arr24;
        [FieldOffset(70408)] public MuseumItemInfo movieItems__arr25;
        [FieldOffset(70512)] public MuseumItemInfo movieItems__arr26;
        [FieldOffset(70616)] public MuseumItemInfo movieItems__arr27;
        [FieldOffset(70720)] public MuseumItemInfo movieItems__arr28;
        [FieldOffset(70824)] public MuseumItemInfo movieItems__arr29;
        [FieldOffset(70928)] public MuseumItemInfo movieItems__arr30;
        [FieldOffset(71032)] public MuseumItemInfo movieItems__arr31;
        [FieldOffset(71136)] public MuseumItemInfo movieItems__arr32;
        [FieldOffset(71240)] public MuseumItemInfo movieItems__arr33;
        [FieldOffset(71344)] public MuseumItemInfo movieItems__arr34;
        [FieldOffset(71448)] public MuseumItemInfo movieItems__arr35;
        [FieldOffset(71552)] public MuseumItemInfo movieItems__arr36;
        [FieldOffset(71656)] public MuseumItemInfo movieItems__arr37;
        [FieldOffset(71760)] public MuseumItemInfo movieItems__arr38;
        [FieldOffset(71864)] public MuseumItemInfo movieItems__arr39;
        [FieldOffset(71968)] public MuseumItemInfo movieItems__arr40;
        [FieldOffset(72072)] public MuseumItemInfo movieItems__arr41;
        [FieldOffset(72176)] public MuseumItemInfo movieItems__arr42;
        [FieldOffset(72280)] public MuseumItemInfo movieItems__arr43;
        [FieldOffset(72384)] public MuseumItemInfo movieItems__arr44;
        [FieldOffset(72488)] public MuseumItemInfo movieItems__arr45;
        [FieldOffset(72592)] public MuseumItemInfo movieItems__arr46;
        [FieldOffset(72696)] public MuseumItemInfo movieItems__arr47;
        [FieldOffset(72800)] public MuseumItemInfo movieItems__arr48;
        [FieldOffset(72904)] public MuseumItemInfo movieItems__arr49;
        [FieldOffset(73008)] public MuseumItemInfo movieItems__arr50;
        [FieldOffset(73112)] public MuseumSortInfo musicSortInfos__arr0;
        [FieldOffset(73120)] public MuseumSortInfo musicSortInfos__arr1;
        [FieldOffset(73128)] public MuseumSortInfo musicSortInfos__arr2;
        [FieldOffset(73136)] public MuseumSortInfo musicSortInfos__arr3;
        [FieldOffset(73144)] public MuseumSortInfo musicSortInfos__arr4;
        [FieldOffset(73152)] public MuseumSortInfo musicSortInfos__arr5;
        [FieldOffset(73160)] public MuseumSortInfo musicSortInfos__arr6;
        [FieldOffset(73168)] public MuseumSortInfo musicSortInfos__arr7;
        [FieldOffset(73176)] public MuseumSortInfo musicSortInfos__arr8;
        [FieldOffset(73184)] public MuseumSortInfo musicSortInfos__arr9;
        [FieldOffset(73192)] public MuseumSortInfo musicSortInfos__arr10;
        [FieldOffset(73200)] public MuseumSortInfo musicSortInfos__arr11;
        [FieldOffset(73208)] public MuseumSortInfo musicSortInfos__arr12;
        [FieldOffset(73216)] public MuseumSortInfo musicSortInfos__arr13;
        [FieldOffset(73224)] public MuseumSortInfo musicSortInfos__arr14;
        [FieldOffset(73232)] public MuseumSortInfo artSortInfos__arr0;
        [FieldOffset(73240)] public MuseumSortInfo artSortInfos__arr1;
        [FieldOffset(73248)] public MuseumSortInfo artSortInfos__arr2;
        [FieldOffset(73256)] public MuseumSortInfo artSortInfos__arr3;
        [FieldOffset(73264)] public MuseumSortInfo artSortInfos__arr4;
        [FieldOffset(73272)] public MuseumSortInfo artSortInfos__arr5;
        [FieldOffset(73280)] public MuseumSortInfo artSortInfos__arr6;
        [FieldOffset(73288)] public MuseumSortInfo artSortInfos__arr7;
        [FieldOffset(73296)] public MuseumSortInfo artSortInfos__arr8;
        [FieldOffset(73304)] public MuseumSortInfo artSortInfos__arr9;
        [FieldOffset(73312)] public MuseumSortInfo artSortInfos__arr10;
        [FieldOffset(73320)] public MuseumSortInfo artSortInfos__arr11;
        [FieldOffset(73328)] public MuseumSortInfo artSortInfos__arr12;
        [FieldOffset(73336)] public MuseumSortInfo artSortInfos__arr13;
        [FieldOffset(73344)] public MuseumSortInfo artSortInfos__arr14;
        [FieldOffset(73352)] public MusicFadeOutInfo musicFadeOutInfo;
    }

}