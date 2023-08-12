using System.Numerics;
using System.Runtime.InteropServices;

public class DecoTechParamsClass
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

    public struct Color8
    {
        public byte A;
        public byte R;
        public byte G;
        public byte B;
    }

    public enum Orientation : sbyte
    {
        ORIENTATION_NONE = 0,
        ORIENTATION_HORIZONTAL = 1,
        ORIENTATION_VERTICAL = 2,
        ORIENTATION_DIAGONAL = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct DecoGradationParam
    {
        [FieldOffset(0)]  public Orientation orientation;
        [FieldOffset(1)]  public sbyte srcPosX;
        [FieldOffset(2)]  public sbyte srcPosY;
        [FieldOffset(3)]  public sbyte dstPosX;
        [FieldOffset(4)]  public sbyte dstPosY;
        [FieldOffset(8)]  public Color8 srcColor;
        [FieldOffset(12)] public Color8 dstColor;
    }

    public enum DecoLayerBlendOp : sbyte
    {
        DECO_LAYER_BLEND_OP_BLEND = 0,
        DECO_LAYER_BLEND_OP_SUBTRACT_ALPHA = 1
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct DecoDropShadowParam
    {
        [FieldOffset(0)] public Color8 color;
        [FieldOffset(4)] public byte size;
        [FieldOffset(5)] public byte spread;
        [FieldOffset(6)] public sbyte distanceX;
        [FieldOffset(7)] public sbyte distanceY;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct DecoRimParam
    {
        [FieldOffset(0)]  public Color8 color;
        [FieldOffset(4)]  public int thickness;
        [FieldOffset(8)]  public int offsetX;
        [FieldOffset(12)] public int offsetY;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct DecoBlurParam
    {
        [FieldOffset(0)] public int radius;
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct DecoPassParam
    {
        [FieldOffset(0)]  public DecoDropShadowParam dropShadow;
        [FieldOffset(8)]  public DecoRimParam rim;
        [FieldOffset(24)] public DecoGradationParam gradation;
        [FieldOffset(40)] public DecoBlurParam blur;
        [FieldOffset(44)] public bool avoidEdgeArtifact;
    }

    [StructLayout(LayoutKind.Explicit, Size = 288)]
    public struct DecoTechParam
    {
        [FieldOffset(0)]  public CString name;
        [FieldOffset(16)] public Color8 fontColor;
        [FieldOffset(20)] public DecoGradationParam fontGradParam;
        [FieldOffset(36)] public DecoLayerBlendOp layerBlendOp;
        [FieldOffset(40)] public int numPasses;
        [FieldOffset(44)] public DecoPassParam passParams__arr0;
        [FieldOffset(92)] public DecoPassParam passParams__arr1;
        [FieldOffset(140)] public DecoPassParam passParams__arr2;
        [FieldOffset(188)] public DecoPassParam passParams__arr3;
        [FieldOffset(236)] public DecoPassParam passParams__arr4;
    }

    [StructLayout(LayoutKind.Explicit, Size = 147456)]
    public struct DecoTechParams
    {
        [FieldOffset(0)] public DecoTechParam _params__arr0;
        [FieldOffset(288)] public DecoTechParam _params__arr1;
        [FieldOffset(576)] public DecoTechParam _params__arr2;
        [FieldOffset(864)] public DecoTechParam _params__arr3;
        [FieldOffset(1152)] public DecoTechParam _params__arr4;
        [FieldOffset(1440)] public DecoTechParam _params__arr5;
        [FieldOffset(1728)] public DecoTechParam _params__arr6;
        [FieldOffset(2016)] public DecoTechParam _params__arr7;
        [FieldOffset(2304)] public DecoTechParam _params__arr8;
        [FieldOffset(2592)] public DecoTechParam _params__arr9;
        [FieldOffset(2880)] public DecoTechParam _params__arr10;
        [FieldOffset(3168)] public DecoTechParam _params__arr11;
        [FieldOffset(3456)] public DecoTechParam _params__arr12;
        [FieldOffset(3744)] public DecoTechParam _params__arr13;
        [FieldOffset(4032)] public DecoTechParam _params__arr14;
        [FieldOffset(4320)] public DecoTechParam _params__arr15;
        [FieldOffset(4608)] public DecoTechParam _params__arr16;
        [FieldOffset(4896)] public DecoTechParam _params__arr17;
        [FieldOffset(5184)] public DecoTechParam _params__arr18;
        [FieldOffset(5472)] public DecoTechParam _params__arr19;
        [FieldOffset(5760)] public DecoTechParam _params__arr20;
        [FieldOffset(6048)] public DecoTechParam _params__arr21;
        [FieldOffset(6336)] public DecoTechParam _params__arr22;
        [FieldOffset(6624)] public DecoTechParam _params__arr23;
        [FieldOffset(6912)] public DecoTechParam _params__arr24;
        [FieldOffset(7200)] public DecoTechParam _params__arr25;
        [FieldOffset(7488)] public DecoTechParam _params__arr26;
        [FieldOffset(7776)] public DecoTechParam _params__arr27;
        [FieldOffset(8064)] public DecoTechParam _params__arr28;
        [FieldOffset(8352)] public DecoTechParam _params__arr29;
        [FieldOffset(8640)] public DecoTechParam _params__arr30;
        [FieldOffset(8928)] public DecoTechParam _params__arr31;
        [FieldOffset(9216)] public DecoTechParam _params__arr32;
        [FieldOffset(9504)] public DecoTechParam _params__arr33;
        [FieldOffset(9792)] public DecoTechParam _params__arr34;
        [FieldOffset(10080)] public DecoTechParam _params__arr35;
        [FieldOffset(10368)] public DecoTechParam _params__arr36;
        [FieldOffset(10656)] public DecoTechParam _params__arr37;
        [FieldOffset(10944)] public DecoTechParam _params__arr38;
        [FieldOffset(11232)] public DecoTechParam _params__arr39;
        [FieldOffset(11520)] public DecoTechParam _params__arr40;
        [FieldOffset(11808)] public DecoTechParam _params__arr41;
        [FieldOffset(12096)] public DecoTechParam _params__arr42;
        [FieldOffset(12384)] public DecoTechParam _params__arr43;
        [FieldOffset(12672)] public DecoTechParam _params__arr44;
        [FieldOffset(12960)] public DecoTechParam _params__arr45;
        [FieldOffset(13248)] public DecoTechParam _params__arr46;
        [FieldOffset(13536)] public DecoTechParam _params__arr47;
        [FieldOffset(13824)] public DecoTechParam _params__arr48;
        [FieldOffset(14112)] public DecoTechParam _params__arr49;
        [FieldOffset(14400)] public DecoTechParam _params__arr50;
        [FieldOffset(14688)] public DecoTechParam _params__arr51;
        [FieldOffset(14976)] public DecoTechParam _params__arr52;
        [FieldOffset(15264)] public DecoTechParam _params__arr53;
        [FieldOffset(15552)] public DecoTechParam _params__arr54;
        [FieldOffset(15840)] public DecoTechParam _params__arr55;
        [FieldOffset(16128)] public DecoTechParam _params__arr56;
        [FieldOffset(16416)] public DecoTechParam _params__arr57;
        [FieldOffset(16704)] public DecoTechParam _params__arr58;
        [FieldOffset(16992)] public DecoTechParam _params__arr59;
        [FieldOffset(17280)] public DecoTechParam _params__arr60;
        [FieldOffset(17568)] public DecoTechParam _params__arr61;
        [FieldOffset(17856)] public DecoTechParam _params__arr62;
        [FieldOffset(18144)] public DecoTechParam _params__arr63;
        [FieldOffset(18432)] public DecoTechParam _params__arr64;
        [FieldOffset(18720)] public DecoTechParam _params__arr65;
        [FieldOffset(19008)] public DecoTechParam _params__arr66;
        [FieldOffset(19296)] public DecoTechParam _params__arr67;
        [FieldOffset(19584)] public DecoTechParam _params__arr68;
        [FieldOffset(19872)] public DecoTechParam _params__arr69;
        [FieldOffset(20160)] public DecoTechParam _params__arr70;
        [FieldOffset(20448)] public DecoTechParam _params__arr71;
        [FieldOffset(20736)] public DecoTechParam _params__arr72;
        [FieldOffset(21024)] public DecoTechParam _params__arr73;
        [FieldOffset(21312)] public DecoTechParam _params__arr74;
        [FieldOffset(21600)] public DecoTechParam _params__arr75;
        [FieldOffset(21888)] public DecoTechParam _params__arr76;
        [FieldOffset(22176)] public DecoTechParam _params__arr77;
        [FieldOffset(22464)] public DecoTechParam _params__arr78;
        [FieldOffset(22752)] public DecoTechParam _params__arr79;
        [FieldOffset(23040)] public DecoTechParam _params__arr80;
        [FieldOffset(23328)] public DecoTechParam _params__arr81;
        [FieldOffset(23616)] public DecoTechParam _params__arr82;
        [FieldOffset(23904)] public DecoTechParam _params__arr83;
        [FieldOffset(24192)] public DecoTechParam _params__arr84;
        [FieldOffset(24480)] public DecoTechParam _params__arr85;
        [FieldOffset(24768)] public DecoTechParam _params__arr86;
        [FieldOffset(25056)] public DecoTechParam _params__arr87;
        [FieldOffset(25344)] public DecoTechParam _params__arr88;
        [FieldOffset(25632)] public DecoTechParam _params__arr89;
        [FieldOffset(25920)] public DecoTechParam _params__arr90;
        [FieldOffset(26208)] public DecoTechParam _params__arr91;
        [FieldOffset(26496)] public DecoTechParam _params__arr92;
        [FieldOffset(26784)] public DecoTechParam _params__arr93;
        [FieldOffset(27072)] public DecoTechParam _params__arr94;
        [FieldOffset(27360)] public DecoTechParam _params__arr95;
        [FieldOffset(27648)] public DecoTechParam _params__arr96;
        [FieldOffset(27936)] public DecoTechParam _params__arr97;
        [FieldOffset(28224)] public DecoTechParam _params__arr98;
        [FieldOffset(28512)] public DecoTechParam _params__arr99;
        [FieldOffset(28800)] public DecoTechParam _params__arr100;
        [FieldOffset(29088)] public DecoTechParam _params__arr101;
        [FieldOffset(29376)] public DecoTechParam _params__arr102;
        [FieldOffset(29664)] public DecoTechParam _params__arr103;
        [FieldOffset(29952)] public DecoTechParam _params__arr104;
        [FieldOffset(30240)] public DecoTechParam _params__arr105;
        [FieldOffset(30528)] public DecoTechParam _params__arr106;
        [FieldOffset(30816)] public DecoTechParam _params__arr107;
        [FieldOffset(31104)] public DecoTechParam _params__arr108;
        [FieldOffset(31392)] public DecoTechParam _params__arr109;
        [FieldOffset(31680)] public DecoTechParam _params__arr110;
        [FieldOffset(31968)] public DecoTechParam _params__arr111;
        [FieldOffset(32256)] public DecoTechParam _params__arr112;
        [FieldOffset(32544)] public DecoTechParam _params__arr113;
        [FieldOffset(32832)] public DecoTechParam _params__arr114;
        [FieldOffset(33120)] public DecoTechParam _params__arr115;
        [FieldOffset(33408)] public DecoTechParam _params__arr116;
        [FieldOffset(33696)] public DecoTechParam _params__arr117;
        [FieldOffset(33984)] public DecoTechParam _params__arr118;
        [FieldOffset(34272)] public DecoTechParam _params__arr119;
        [FieldOffset(34560)] public DecoTechParam _params__arr120;
        [FieldOffset(34848)] public DecoTechParam _params__arr121;
        [FieldOffset(35136)] public DecoTechParam _params__arr122;
        [FieldOffset(35424)] public DecoTechParam _params__arr123;
        [FieldOffset(35712)] public DecoTechParam _params__arr124;
        [FieldOffset(36000)] public DecoTechParam _params__arr125;
        [FieldOffset(36288)] public DecoTechParam _params__arr126;
        [FieldOffset(36576)] public DecoTechParam _params__arr127;
        [FieldOffset(36864)] public DecoTechParam _params__arr128;
        [FieldOffset(37152)] public DecoTechParam _params__arr129;
        [FieldOffset(37440)] public DecoTechParam _params__arr130;
        [FieldOffset(37728)] public DecoTechParam _params__arr131;
        [FieldOffset(38016)] public DecoTechParam _params__arr132;
        [FieldOffset(38304)] public DecoTechParam _params__arr133;
        [FieldOffset(38592)] public DecoTechParam _params__arr134;
        [FieldOffset(38880)] public DecoTechParam _params__arr135;
        [FieldOffset(39168)] public DecoTechParam _params__arr136;
        [FieldOffset(39456)] public DecoTechParam _params__arr137;
        [FieldOffset(39744)] public DecoTechParam _params__arr138;
        [FieldOffset(40032)] public DecoTechParam _params__arr139;
        [FieldOffset(40320)] public DecoTechParam _params__arr140;
        [FieldOffset(40608)] public DecoTechParam _params__arr141;
        [FieldOffset(40896)] public DecoTechParam _params__arr142;
        [FieldOffset(41184)] public DecoTechParam _params__arr143;
        [FieldOffset(41472)] public DecoTechParam _params__arr144;
        [FieldOffset(41760)] public DecoTechParam _params__arr145;
        [FieldOffset(42048)] public DecoTechParam _params__arr146;
        [FieldOffset(42336)] public DecoTechParam _params__arr147;
        [FieldOffset(42624)] public DecoTechParam _params__arr148;
        [FieldOffset(42912)] public DecoTechParam _params__arr149;
        [FieldOffset(43200)] public DecoTechParam _params__arr150;
        [FieldOffset(43488)] public DecoTechParam _params__arr151;
        [FieldOffset(43776)] public DecoTechParam _params__arr152;
        [FieldOffset(44064)] public DecoTechParam _params__arr153;
        [FieldOffset(44352)] public DecoTechParam _params__arr154;
        [FieldOffset(44640)] public DecoTechParam _params__arr155;
        [FieldOffset(44928)] public DecoTechParam _params__arr156;
        [FieldOffset(45216)] public DecoTechParam _params__arr157;
        [FieldOffset(45504)] public DecoTechParam _params__arr158;
        [FieldOffset(45792)] public DecoTechParam _params__arr159;
        [FieldOffset(46080)] public DecoTechParam _params__arr160;
        [FieldOffset(46368)] public DecoTechParam _params__arr161;
        [FieldOffset(46656)] public DecoTechParam _params__arr162;
        [FieldOffset(46944)] public DecoTechParam _params__arr163;
        [FieldOffset(47232)] public DecoTechParam _params__arr164;
        [FieldOffset(47520)] public DecoTechParam _params__arr165;
        [FieldOffset(47808)] public DecoTechParam _params__arr166;
        [FieldOffset(48096)] public DecoTechParam _params__arr167;
        [FieldOffset(48384)] public DecoTechParam _params__arr168;
        [FieldOffset(48672)] public DecoTechParam _params__arr169;
        [FieldOffset(48960)] public DecoTechParam _params__arr170;
        [FieldOffset(49248)] public DecoTechParam _params__arr171;
        [FieldOffset(49536)] public DecoTechParam _params__arr172;
        [FieldOffset(49824)] public DecoTechParam _params__arr173;
        [FieldOffset(50112)] public DecoTechParam _params__arr174;
        [FieldOffset(50400)] public DecoTechParam _params__arr175;
        [FieldOffset(50688)] public DecoTechParam _params__arr176;
        [FieldOffset(50976)] public DecoTechParam _params__arr177;
        [FieldOffset(51264)] public DecoTechParam _params__arr178;
        [FieldOffset(51552)] public DecoTechParam _params__arr179;
        [FieldOffset(51840)] public DecoTechParam _params__arr180;
        [FieldOffset(52128)] public DecoTechParam _params__arr181;
        [FieldOffset(52416)] public DecoTechParam _params__arr182;
        [FieldOffset(52704)] public DecoTechParam _params__arr183;
        [FieldOffset(52992)] public DecoTechParam _params__arr184;
        [FieldOffset(53280)] public DecoTechParam _params__arr185;
        [FieldOffset(53568)] public DecoTechParam _params__arr186;
        [FieldOffset(53856)] public DecoTechParam _params__arr187;
        [FieldOffset(54144)] public DecoTechParam _params__arr188;
        [FieldOffset(54432)] public DecoTechParam _params__arr189;
        [FieldOffset(54720)] public DecoTechParam _params__arr190;
        [FieldOffset(55008)] public DecoTechParam _params__arr191;
        [FieldOffset(55296)] public DecoTechParam _params__arr192;
        [FieldOffset(55584)] public DecoTechParam _params__arr193;
        [FieldOffset(55872)] public DecoTechParam _params__arr194;
        [FieldOffset(56160)] public DecoTechParam _params__arr195;
        [FieldOffset(56448)] public DecoTechParam _params__arr196;
        [FieldOffset(56736)] public DecoTechParam _params__arr197;
        [FieldOffset(57024)] public DecoTechParam _params__arr198;
        [FieldOffset(57312)] public DecoTechParam _params__arr199;
        [FieldOffset(57600)] public DecoTechParam _params__arr200;
        [FieldOffset(57888)] public DecoTechParam _params__arr201;
        [FieldOffset(58176)] public DecoTechParam _params__arr202;
        [FieldOffset(58464)] public DecoTechParam _params__arr203;
        [FieldOffset(58752)] public DecoTechParam _params__arr204;
        [FieldOffset(59040)] public DecoTechParam _params__arr205;
        [FieldOffset(59328)] public DecoTechParam _params__arr206;
        [FieldOffset(59616)] public DecoTechParam _params__arr207;
        [FieldOffset(59904)] public DecoTechParam _params__arr208;
        [FieldOffset(60192)] public DecoTechParam _params__arr209;
        [FieldOffset(60480)] public DecoTechParam _params__arr210;
        [FieldOffset(60768)] public DecoTechParam _params__arr211;
        [FieldOffset(61056)] public DecoTechParam _params__arr212;
        [FieldOffset(61344)] public DecoTechParam _params__arr213;
        [FieldOffset(61632)] public DecoTechParam _params__arr214;
        [FieldOffset(61920)] public DecoTechParam _params__arr215;
        [FieldOffset(62208)] public DecoTechParam _params__arr216;
        [FieldOffset(62496)] public DecoTechParam _params__arr217;
        [FieldOffset(62784)] public DecoTechParam _params__arr218;
        [FieldOffset(63072)] public DecoTechParam _params__arr219;
        [FieldOffset(63360)] public DecoTechParam _params__arr220;
        [FieldOffset(63648)] public DecoTechParam _params__arr221;
        [FieldOffset(63936)] public DecoTechParam _params__arr222;
        [FieldOffset(64224)] public DecoTechParam _params__arr223;
        [FieldOffset(64512)] public DecoTechParam _params__arr224;
        [FieldOffset(64800)] public DecoTechParam _params__arr225;
        [FieldOffset(65088)] public DecoTechParam _params__arr226;
        [FieldOffset(65376)] public DecoTechParam _params__arr227;
        [FieldOffset(65664)] public DecoTechParam _params__arr228;
        [FieldOffset(65952)] public DecoTechParam _params__arr229;
        [FieldOffset(66240)] public DecoTechParam _params__arr230;
        [FieldOffset(66528)] public DecoTechParam _params__arr231;
        [FieldOffset(66816)] public DecoTechParam _params__arr232;
        [FieldOffset(67104)] public DecoTechParam _params__arr233;
        [FieldOffset(67392)] public DecoTechParam _params__arr234;
        [FieldOffset(67680)] public DecoTechParam _params__arr235;
        [FieldOffset(67968)] public DecoTechParam _params__arr236;
        [FieldOffset(68256)] public DecoTechParam _params__arr237;
        [FieldOffset(68544)] public DecoTechParam _params__arr238;
        [FieldOffset(68832)] public DecoTechParam _params__arr239;
        [FieldOffset(69120)] public DecoTechParam _params__arr240;
        [FieldOffset(69408)] public DecoTechParam _params__arr241;
        [FieldOffset(69696)] public DecoTechParam _params__arr242;
        [FieldOffset(69984)] public DecoTechParam _params__arr243;
        [FieldOffset(70272)] public DecoTechParam _params__arr244;
        [FieldOffset(70560)] public DecoTechParam _params__arr245;
        [FieldOffset(70848)] public DecoTechParam _params__arr246;
        [FieldOffset(71136)] public DecoTechParam _params__arr247;
        [FieldOffset(71424)] public DecoTechParam _params__arr248;
        [FieldOffset(71712)] public DecoTechParam _params__arr249;
        [FieldOffset(72000)] public DecoTechParam _params__arr250;
        [FieldOffset(72288)] public DecoTechParam _params__arr251;
        [FieldOffset(72576)] public DecoTechParam _params__arr252;
        [FieldOffset(72864)] public DecoTechParam _params__arr253;
        [FieldOffset(73152)] public DecoTechParam _params__arr254;
        [FieldOffset(73440)] public DecoTechParam _params__arr255;
        [FieldOffset(73728)] public DecoTechParam _params__arr256;
        [FieldOffset(74016)] public DecoTechParam _params__arr257;
        [FieldOffset(74304)] public DecoTechParam _params__arr258;
        [FieldOffset(74592)] public DecoTechParam _params__arr259;
        [FieldOffset(74880)] public DecoTechParam _params__arr260;
        [FieldOffset(75168)] public DecoTechParam _params__arr261;
        [FieldOffset(75456)] public DecoTechParam _params__arr262;
        [FieldOffset(75744)] public DecoTechParam _params__arr263;
        [FieldOffset(76032)] public DecoTechParam _params__arr264;
        [FieldOffset(76320)] public DecoTechParam _params__arr265;
        [FieldOffset(76608)] public DecoTechParam _params__arr266;
        [FieldOffset(76896)] public DecoTechParam _params__arr267;
        [FieldOffset(77184)] public DecoTechParam _params__arr268;
        [FieldOffset(77472)] public DecoTechParam _params__arr269;
        [FieldOffset(77760)] public DecoTechParam _params__arr270;
        [FieldOffset(78048)] public DecoTechParam _params__arr271;
        [FieldOffset(78336)] public DecoTechParam _params__arr272;
        [FieldOffset(78624)] public DecoTechParam _params__arr273;
        [FieldOffset(78912)] public DecoTechParam _params__arr274;
        [FieldOffset(79200)] public DecoTechParam _params__arr275;
        [FieldOffset(79488)] public DecoTechParam _params__arr276;
        [FieldOffset(79776)] public DecoTechParam _params__arr277;
        [FieldOffset(80064)] public DecoTechParam _params__arr278;
        [FieldOffset(80352)] public DecoTechParam _params__arr279;
        [FieldOffset(80640)] public DecoTechParam _params__arr280;
        [FieldOffset(80928)] public DecoTechParam _params__arr281;
        [FieldOffset(81216)] public DecoTechParam _params__arr282;
        [FieldOffset(81504)] public DecoTechParam _params__arr283;
        [FieldOffset(81792)] public DecoTechParam _params__arr284;
        [FieldOffset(82080)] public DecoTechParam _params__arr285;
        [FieldOffset(82368)] public DecoTechParam _params__arr286;
        [FieldOffset(82656)] public DecoTechParam _params__arr287;
        [FieldOffset(82944)] public DecoTechParam _params__arr288;
        [FieldOffset(83232)] public DecoTechParam _params__arr289;
        [FieldOffset(83520)] public DecoTechParam _params__arr290;
        [FieldOffset(83808)] public DecoTechParam _params__arr291;
        [FieldOffset(84096)] public DecoTechParam _params__arr292;
        [FieldOffset(84384)] public DecoTechParam _params__arr293;
        [FieldOffset(84672)] public DecoTechParam _params__arr294;
        [FieldOffset(84960)] public DecoTechParam _params__arr295;
        [FieldOffset(85248)] public DecoTechParam _params__arr296;
        [FieldOffset(85536)] public DecoTechParam _params__arr297;
        [FieldOffset(85824)] public DecoTechParam _params__arr298;
        [FieldOffset(86112)] public DecoTechParam _params__arr299;
        [FieldOffset(86400)] public DecoTechParam _params__arr300;
        [FieldOffset(86688)] public DecoTechParam _params__arr301;
        [FieldOffset(86976)] public DecoTechParam _params__arr302;
        [FieldOffset(87264)] public DecoTechParam _params__arr303;
        [FieldOffset(87552)] public DecoTechParam _params__arr304;
        [FieldOffset(87840)] public DecoTechParam _params__arr305;
        [FieldOffset(88128)] public DecoTechParam _params__arr306;
        [FieldOffset(88416)] public DecoTechParam _params__arr307;
        [FieldOffset(88704)] public DecoTechParam _params__arr308;
        [FieldOffset(88992)] public DecoTechParam _params__arr309;
        [FieldOffset(89280)] public DecoTechParam _params__arr310;
        [FieldOffset(89568)] public DecoTechParam _params__arr311;
        [FieldOffset(89856)] public DecoTechParam _params__arr312;
        [FieldOffset(90144)] public DecoTechParam _params__arr313;
        [FieldOffset(90432)] public DecoTechParam _params__arr314;
        [FieldOffset(90720)] public DecoTechParam _params__arr315;
        [FieldOffset(91008)] public DecoTechParam _params__arr316;
        [FieldOffset(91296)] public DecoTechParam _params__arr317;
        [FieldOffset(91584)] public DecoTechParam _params__arr318;
        [FieldOffset(91872)] public DecoTechParam _params__arr319;
        [FieldOffset(92160)] public DecoTechParam _params__arr320;
        [FieldOffset(92448)] public DecoTechParam _params__arr321;
        [FieldOffset(92736)] public DecoTechParam _params__arr322;
        [FieldOffset(93024)] public DecoTechParam _params__arr323;
        [FieldOffset(93312)] public DecoTechParam _params__arr324;
        [FieldOffset(93600)] public DecoTechParam _params__arr325;
        [FieldOffset(93888)] public DecoTechParam _params__arr326;
        [FieldOffset(94176)] public DecoTechParam _params__arr327;
        [FieldOffset(94464)] public DecoTechParam _params__arr328;
        [FieldOffset(94752)] public DecoTechParam _params__arr329;
        [FieldOffset(95040)] public DecoTechParam _params__arr330;
        [FieldOffset(95328)] public DecoTechParam _params__arr331;
        [FieldOffset(95616)] public DecoTechParam _params__arr332;
        [FieldOffset(95904)] public DecoTechParam _params__arr333;
        [FieldOffset(96192)] public DecoTechParam _params__arr334;
        [FieldOffset(96480)] public DecoTechParam _params__arr335;
        [FieldOffset(96768)] public DecoTechParam _params__arr336;
        [FieldOffset(97056)] public DecoTechParam _params__arr337;
        [FieldOffset(97344)] public DecoTechParam _params__arr338;
        [FieldOffset(97632)] public DecoTechParam _params__arr339;
        [FieldOffset(97920)] public DecoTechParam _params__arr340;
        [FieldOffset(98208)] public DecoTechParam _params__arr341;
        [FieldOffset(98496)] public DecoTechParam _params__arr342;
        [FieldOffset(98784)] public DecoTechParam _params__arr343;
        [FieldOffset(99072)] public DecoTechParam _params__arr344;
        [FieldOffset(99360)] public DecoTechParam _params__arr345;
        [FieldOffset(99648)] public DecoTechParam _params__arr346;
        [FieldOffset(99936)] public DecoTechParam _params__arr347;
        [FieldOffset(100224)] public DecoTechParam _params__arr348;
        [FieldOffset(100512)] public DecoTechParam _params__arr349;
        [FieldOffset(100800)] public DecoTechParam _params__arr350;
        [FieldOffset(101088)] public DecoTechParam _params__arr351;
        [FieldOffset(101376)] public DecoTechParam _params__arr352;
        [FieldOffset(101664)] public DecoTechParam _params__arr353;
        [FieldOffset(101952)] public DecoTechParam _params__arr354;
        [FieldOffset(102240)] public DecoTechParam _params__arr355;
        [FieldOffset(102528)] public DecoTechParam _params__arr356;
        [FieldOffset(102816)] public DecoTechParam _params__arr357;
        [FieldOffset(103104)] public DecoTechParam _params__arr358;
        [FieldOffset(103392)] public DecoTechParam _params__arr359;
        [FieldOffset(103680)] public DecoTechParam _params__arr360;
        [FieldOffset(103968)] public DecoTechParam _params__arr361;
        [FieldOffset(104256)] public DecoTechParam _params__arr362;
        [FieldOffset(104544)] public DecoTechParam _params__arr363;
        [FieldOffset(104832)] public DecoTechParam _params__arr364;
        [FieldOffset(105120)] public DecoTechParam _params__arr365;
        [FieldOffset(105408)] public DecoTechParam _params__arr366;
        [FieldOffset(105696)] public DecoTechParam _params__arr367;
        [FieldOffset(105984)] public DecoTechParam _params__arr368;
        [FieldOffset(106272)] public DecoTechParam _params__arr369;
        [FieldOffset(106560)] public DecoTechParam _params__arr370;
        [FieldOffset(106848)] public DecoTechParam _params__arr371;
        [FieldOffset(107136)] public DecoTechParam _params__arr372;
        [FieldOffset(107424)] public DecoTechParam _params__arr373;
        [FieldOffset(107712)] public DecoTechParam _params__arr374;
        [FieldOffset(108000)] public DecoTechParam _params__arr375;
        [FieldOffset(108288)] public DecoTechParam _params__arr376;
        [FieldOffset(108576)] public DecoTechParam _params__arr377;
        [FieldOffset(108864)] public DecoTechParam _params__arr378;
        [FieldOffset(109152)] public DecoTechParam _params__arr379;
        [FieldOffset(109440)] public DecoTechParam _params__arr380;
        [FieldOffset(109728)] public DecoTechParam _params__arr381;
        [FieldOffset(110016)] public DecoTechParam _params__arr382;
        [FieldOffset(110304)] public DecoTechParam _params__arr383;
        [FieldOffset(110592)] public DecoTechParam _params__arr384;
        [FieldOffset(110880)] public DecoTechParam _params__arr385;
        [FieldOffset(111168)] public DecoTechParam _params__arr386;
        [FieldOffset(111456)] public DecoTechParam _params__arr387;
        [FieldOffset(111744)] public DecoTechParam _params__arr388;
        [FieldOffset(112032)] public DecoTechParam _params__arr389;
        [FieldOffset(112320)] public DecoTechParam _params__arr390;
        [FieldOffset(112608)] public DecoTechParam _params__arr391;
        [FieldOffset(112896)] public DecoTechParam _params__arr392;
        [FieldOffset(113184)] public DecoTechParam _params__arr393;
        [FieldOffset(113472)] public DecoTechParam _params__arr394;
        [FieldOffset(113760)] public DecoTechParam _params__arr395;
        [FieldOffset(114048)] public DecoTechParam _params__arr396;
        [FieldOffset(114336)] public DecoTechParam _params__arr397;
        [FieldOffset(114624)] public DecoTechParam _params__arr398;
        [FieldOffset(114912)] public DecoTechParam _params__arr399;
        [FieldOffset(115200)] public DecoTechParam _params__arr400;
        [FieldOffset(115488)] public DecoTechParam _params__arr401;
        [FieldOffset(115776)] public DecoTechParam _params__arr402;
        [FieldOffset(116064)] public DecoTechParam _params__arr403;
        [FieldOffset(116352)] public DecoTechParam _params__arr404;
        [FieldOffset(116640)] public DecoTechParam _params__arr405;
        [FieldOffset(116928)] public DecoTechParam _params__arr406;
        [FieldOffset(117216)] public DecoTechParam _params__arr407;
        [FieldOffset(117504)] public DecoTechParam _params__arr408;
        [FieldOffset(117792)] public DecoTechParam _params__arr409;
        [FieldOffset(118080)] public DecoTechParam _params__arr410;
        [FieldOffset(118368)] public DecoTechParam _params__arr411;
        [FieldOffset(118656)] public DecoTechParam _params__arr412;
        [FieldOffset(118944)] public DecoTechParam _params__arr413;
        [FieldOffset(119232)] public DecoTechParam _params__arr414;
        [FieldOffset(119520)] public DecoTechParam _params__arr415;
        [FieldOffset(119808)] public DecoTechParam _params__arr416;
        [FieldOffset(120096)] public DecoTechParam _params__arr417;
        [FieldOffset(120384)] public DecoTechParam _params__arr418;
        [FieldOffset(120672)] public DecoTechParam _params__arr419;
        [FieldOffset(120960)] public DecoTechParam _params__arr420;
        [FieldOffset(121248)] public DecoTechParam _params__arr421;
        [FieldOffset(121536)] public DecoTechParam _params__arr422;
        [FieldOffset(121824)] public DecoTechParam _params__arr423;
        [FieldOffset(122112)] public DecoTechParam _params__arr424;
        [FieldOffset(122400)] public DecoTechParam _params__arr425;
        [FieldOffset(122688)] public DecoTechParam _params__arr426;
        [FieldOffset(122976)] public DecoTechParam _params__arr427;
        [FieldOffset(123264)] public DecoTechParam _params__arr428;
        [FieldOffset(123552)] public DecoTechParam _params__arr429;
        [FieldOffset(123840)] public DecoTechParam _params__arr430;
        [FieldOffset(124128)] public DecoTechParam _params__arr431;
        [FieldOffset(124416)] public DecoTechParam _params__arr432;
        [FieldOffset(124704)] public DecoTechParam _params__arr433;
        [FieldOffset(124992)] public DecoTechParam _params__arr434;
        [FieldOffset(125280)] public DecoTechParam _params__arr435;
        [FieldOffset(125568)] public DecoTechParam _params__arr436;
        [FieldOffset(125856)] public DecoTechParam _params__arr437;
        [FieldOffset(126144)] public DecoTechParam _params__arr438;
        [FieldOffset(126432)] public DecoTechParam _params__arr439;
        [FieldOffset(126720)] public DecoTechParam _params__arr440;
        [FieldOffset(127008)] public DecoTechParam _params__arr441;
        [FieldOffset(127296)] public DecoTechParam _params__arr442;
        [FieldOffset(127584)] public DecoTechParam _params__arr443;
        [FieldOffset(127872)] public DecoTechParam _params__arr444;
        [FieldOffset(128160)] public DecoTechParam _params__arr445;
        [FieldOffset(128448)] public DecoTechParam _params__arr446;
        [FieldOffset(128736)] public DecoTechParam _params__arr447;
        [FieldOffset(129024)] public DecoTechParam _params__arr448;
        [FieldOffset(129312)] public DecoTechParam _params__arr449;
        [FieldOffset(129600)] public DecoTechParam _params__arr450;
        [FieldOffset(129888)] public DecoTechParam _params__arr451;
        [FieldOffset(130176)] public DecoTechParam _params__arr452;
        [FieldOffset(130464)] public DecoTechParam _params__arr453;
        [FieldOffset(130752)] public DecoTechParam _params__arr454;
        [FieldOffset(131040)] public DecoTechParam _params__arr455;
        [FieldOffset(131328)] public DecoTechParam _params__arr456;
        [FieldOffset(131616)] public DecoTechParam _params__arr457;
        [FieldOffset(131904)] public DecoTechParam _params__arr458;
        [FieldOffset(132192)] public DecoTechParam _params__arr459;
        [FieldOffset(132480)] public DecoTechParam _params__arr460;
        [FieldOffset(132768)] public DecoTechParam _params__arr461;
        [FieldOffset(133056)] public DecoTechParam _params__arr462;
        [FieldOffset(133344)] public DecoTechParam _params__arr463;
        [FieldOffset(133632)] public DecoTechParam _params__arr464;
        [FieldOffset(133920)] public DecoTechParam _params__arr465;
        [FieldOffset(134208)] public DecoTechParam _params__arr466;
        [FieldOffset(134496)] public DecoTechParam _params__arr467;
        [FieldOffset(134784)] public DecoTechParam _params__arr468;
        [FieldOffset(135072)] public DecoTechParam _params__arr469;
        [FieldOffset(135360)] public DecoTechParam _params__arr470;
        [FieldOffset(135648)] public DecoTechParam _params__arr471;
        [FieldOffset(135936)] public DecoTechParam _params__arr472;
        [FieldOffset(136224)] public DecoTechParam _params__arr473;
        [FieldOffset(136512)] public DecoTechParam _params__arr474;
        [FieldOffset(136800)] public DecoTechParam _params__arr475;
        [FieldOffset(137088)] public DecoTechParam _params__arr476;
        [FieldOffset(137376)] public DecoTechParam _params__arr477;
        [FieldOffset(137664)] public DecoTechParam _params__arr478;
        [FieldOffset(137952)] public DecoTechParam _params__arr479;
        [FieldOffset(138240)] public DecoTechParam _params__arr480;
        [FieldOffset(138528)] public DecoTechParam _params__arr481;
        [FieldOffset(138816)] public DecoTechParam _params__arr482;
        [FieldOffset(139104)] public DecoTechParam _params__arr483;
        [FieldOffset(139392)] public DecoTechParam _params__arr484;
        [FieldOffset(139680)] public DecoTechParam _params__arr485;
        [FieldOffset(139968)] public DecoTechParam _params__arr486;
        [FieldOffset(140256)] public DecoTechParam _params__arr487;
        [FieldOffset(140544)] public DecoTechParam _params__arr488;
        [FieldOffset(140832)] public DecoTechParam _params__arr489;
        [FieldOffset(141120)] public DecoTechParam _params__arr490;
        [FieldOffset(141408)] public DecoTechParam _params__arr491;
        [FieldOffset(141696)] public DecoTechParam _params__arr492;
        [FieldOffset(141984)] public DecoTechParam _params__arr493;
        [FieldOffset(142272)] public DecoTechParam _params__arr494;
        [FieldOffset(142560)] public DecoTechParam _params__arr495;
        [FieldOffset(142848)] public DecoTechParam _params__arr496;
        [FieldOffset(143136)] public DecoTechParam _params__arr497;
        [FieldOffset(143424)] public DecoTechParam _params__arr498;
        [FieldOffset(143712)] public DecoTechParam _params__arr499;
        [FieldOffset(144000)] public DecoTechParam _params__arr500;
        [FieldOffset(144288)] public DecoTechParam _params__arr501;
        [FieldOffset(144576)] public DecoTechParam _params__arr502;
        [FieldOffset(144864)] public DecoTechParam _params__arr503;
        [FieldOffset(145152)] public DecoTechParam _params__arr504;
        [FieldOffset(145440)] public DecoTechParam _params__arr505;
        [FieldOffset(145728)] public DecoTechParam _params__arr506;
        [FieldOffset(146016)] public DecoTechParam _params__arr507;
        [FieldOffset(146304)] public DecoTechParam _params__arr508;
        [FieldOffset(146592)] public DecoTechParam _params__arr509;
        [FieldOffset(146880)] public DecoTechParam _params__arr510;
        [FieldOffset(147168)] public DecoTechParam _params__arr511;
    }

}