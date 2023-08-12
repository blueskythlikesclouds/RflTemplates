using System.Numerics;
using System.Runtime.InteropServices;

public class ObjectRflParamClass
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

    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public struct EffectInfo
    {
        [FieldOffset(0)]  public CString effectName;
        [FieldOffset(16)] public CString effectNodeName;
        [FieldOffset(32)] public bool follow;
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct OneShotEffectInfo
    {
        [FieldOffset(0)]  public EffectInfo effectInfo;
        [FieldOffset(40)] public uint frames__arr0;
        [FieldOffset(44)] public uint frames__arr1;
    }

    [StructLayout(LayoutKind.Explicit, Size = 248)]
    public struct BeetonObjectResourceRflParam
    {
        [FieldOffset(0)]   public CString model;
        [FieldOffset(16)]  public CString flyAnim;
        [FieldOffset(32)]  public CString attackAnim;
        [FieldOffset(48)]  public CString skeleton;
        [FieldOffset(64)]  public float radius;
        [FieldOffset(72)]  public EffectInfo burnerEffectInfos__arr0;
        [FieldOffset(112)] public EffectInfo burnerEffectInfos__arr1;
        [FieldOffset(152)] public OneShotEffectInfo strongBurnerEffectInfos__arr0;
        [FieldOffset(200)] public OneShotEffectInfo strongBurnerEffectInfos__arr1;
    }

    [StructLayout(LayoutKind.Explicit, Size = 248)]
    public struct BeetonObjectRflParam
    {
        [FieldOffset(0)] public BeetonObjectResourceRflParam beetonObjectResourceParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct RoundTripObjectRflParam
    {
        [FieldOffset(0)] public int dummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 368)]
    public struct RoundTripObjectResourceRflParam
    {
        [FieldOffset(0)]   public CString model;
        [FieldOffset(16)]  public CString moveAnim;
        [FieldOffset(32)]  public CString waitAnim;
        [FieldOffset(48)]  public CString jumpAnim;
        [FieldOffset(64)]  public CString skeleton;
        [FieldOffset(80)]  public float radius;
        [FieldOffset(88)]  public EffectInfo effectMoveGrass;
        [FieldOffset(128)] public OneShotEffectInfo effectJumpGrass;
        [FieldOffset(176)] public OneShotEffectInfo effectLandingGrass;
        [FieldOffset(224)] public EffectInfo effectMoveRock;
        [FieldOffset(264)] public OneShotEffectInfo effectJumpRock;
        [FieldOffset(312)] public OneShotEffectInfo effectLandingRock;
        [FieldOffset(360)] public bool isLeaningOnPath;
    }

    [StructLayout(LayoutKind.Explicit, Size = 376)]
    public struct MotoraObjectResourceRflParam
    {
        [FieldOffset(0)]   public RoundTripObjectResourceRflParam roundTripObjectResourceRflParam;
        [FieldOffset(368)] public int dummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 384)]
    public struct MotoraObjectRflParam
    {
        [FieldOffset(0)] public RoundTripObjectRflParam roundTripObjectRflParam;
        [FieldOffset(8)] public MotoraObjectResourceRflParam motoraObjectResourceParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct WaterObjectRflParam
    {
        [FieldOffset(0)] public int dummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 200)]
    public struct WaterObjectResourceRflParam
    {
        [FieldOffset(0)]   public CString model;
        [FieldOffset(16)]  public CString animation;
        [FieldOffset(32)]  public CString skeleton;
        [FieldOffset(48)]  public float radius;
        [FieldOffset(56)]  public OneShotEffectInfo effectJump;
        [FieldOffset(104)] public OneShotEffectInfo effectTouchdown;
        [FieldOffset(152)] public OneShotEffectInfo effectWaterDrop;
    }

    [StructLayout(LayoutKind.Explicit, Size = 208)]
    public struct BatabataObjectResourceRflParam
    {
        [FieldOffset(0)]   public WaterObjectResourceRflParam waterObjectResourceRflParam;
        [FieldOffset(200)] public int dummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 216)]
    public struct BatabataObjectRflParam
    {
        [FieldOffset(0)] public WaterObjectRflParam waterObjectRflParam;
        [FieldOffset(8)] public BatabataObjectResourceRflParam batabataObjectResourceParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 208)]
    public struct RockyObjectResourceRflParam
    {
        [FieldOffset(0)]   public WaterObjectResourceRflParam waterObjectResourceRflParam;
        [FieldOffset(200)] public int dummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 216)]
    public struct RockyObjectRflParam
    {
        [FieldOffset(0)] public WaterObjectRflParam waterObjectRflParam;
        [FieldOffset(8)] public RockyObjectResourceRflParam rockyObjectResourceParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct GroundObjectRflParam
    {
        [FieldOffset(0)] public int dummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 248)]
    public struct GroundObjectResourceRflParam
    {
        [FieldOffset(0)]   public CString model;
        [FieldOffset(16)]  public CString animation;
        [FieldOffset(32)]  public CString skeleton;
        [FieldOffset(48)]  public float radius;
        [FieldOffset(56)]  public OneShotEffectInfo effectJumpGrass;
        [FieldOffset(104)] public OneShotEffectInfo effectLandingGrass;
        [FieldOffset(152)] public OneShotEffectInfo effectJumpRock;
        [FieldOffset(200)] public OneShotEffectInfo effectLandingRock;
    }

    [StructLayout(LayoutKind.Explicit, Size = 256)]
    public struct FlickyObjectResourceRflParam
    {
        [FieldOffset(0)]   public GroundObjectResourceRflParam groundObjectResourceRflParam;
        [FieldOffset(248)] public int dummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 264)]
    public struct FlickyObjectRflParam
    {
        [FieldOffset(0)] public GroundObjectRflParam groundObjectRflParam;
        [FieldOffset(8)] public FlickyObjectResourceRflParam flickyObjectResourceParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 208)]
    public struct PeckyObjectResourceRflParam
    {
        [FieldOffset(0)]   public WaterObjectResourceRflParam waterObjectResourceRflParam;
        [FieldOffset(200)] public int dummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 216)]
    public struct PeckyObjectRflParam
    {
        [FieldOffset(0)] public WaterObjectRflParam waterObjectRflParam;
        [FieldOffset(8)] public PeckyObjectResourceRflParam peckyObjectResourceParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 256)]
    public struct RickyObjectResourceRflParam
    {
        [FieldOffset(0)]   public GroundObjectResourceRflParam groundObjectResourceRflParam;
        [FieldOffset(248)] public int dummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 264)]
    public struct RickyObjectRflParam
    {
        [FieldOffset(0)] public GroundObjectRflParam groundObjectRflParam;
        [FieldOffset(8)] public RickyObjectResourceRflParam rickyObjectResourceParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 256)]
    public struct CuckyObjectResourceRflParam
    {
        [FieldOffset(0)]   public GroundObjectResourceRflParam groundObjectResourceRflParam;
        [FieldOffset(248)] public int dummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 264)]
    public struct CuckyObjectRflParam
    {
        [FieldOffset(0)] public GroundObjectRflParam groundObjectRflParam;
        [FieldOffset(8)] public CuckyObjectResourceRflParam cuckyObjectResourceParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 256)]
    public struct PickyObjectResourceRflParam
    {
        [FieldOffset(0)]   public GroundObjectResourceRflParam groundObjectResourceRflParam;
        [FieldOffset(248)] public int dummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 264)]
    public struct PickyObjectRflParam
    {
        [FieldOffset(0)] public GroundObjectRflParam groundObjectRflParam;
        [FieldOffset(8)] public PickyObjectResourceRflParam pickyObjectResourceParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 256)]
    public struct PockyObjectResourceRflParam
    {
        [FieldOffset(0)]   public GroundObjectResourceRflParam groundObjectResourceRflParam;
        [FieldOffset(248)] public int dummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 264)]
    public struct PockyObjectRflParam
    {
        [FieldOffset(0)] public GroundObjectRflParam groundObjectRflParam;
        [FieldOffset(8)] public PockyObjectResourceRflParam pockyObjectResourceParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct CommonObjectRflParam
    {
        [FieldOffset(0)] public int dummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public struct UVAnimationInfo
    {
        [FieldOffset(0)] public bool isActive;
        [FieldOffset(8)] public CString uvAnimNames__arr0;
        [FieldOffset(263)] public CString uvAnimNames__arr1;
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct VISAnimationInfo
    {
        [FieldOffset(0)] public bool isActive;
        [FieldOffset(8)] public CString visAnimNames;
    }

    [StructLayout(LayoutKind.Explicit, Size = 296)]
    public struct CommonObjectResourceRflParam
    {
        [FieldOffset(0)]   public CString model;
        [FieldOffset(16)]  public CString animation;
        [FieldOffset(32)]  public CString skeleton;
        [FieldOffset(48)]  public float radius;
        [FieldOffset(56)]  public EffectInfo effectInfos__arr0;
        [FieldOffset(96)] public EffectInfo effectInfos__arr1;
        [FieldOffset(136)] public OneShotEffectInfo oneShotEffectInfos__arr0;
        [FieldOffset(184)] public OneShotEffectInfo oneShotEffectInfos__arr1;
        [FieldOffset(232)] public UVAnimationInfo loopUVAnimInfo;
        [FieldOffset(272)] public VISAnimationInfo loopVISAnimInfo;
    }

    [StructLayout(LayoutKind.Explicit, Size = 304)]
    public struct TornadoObjectResourceRflParam
    {
        [FieldOffset(0)]   public CommonObjectResourceRflParam commonObjectResourceRflParam;
        [FieldOffset(296)] public int dummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 312)]
    public struct TornadoObjectRflParam
    {
        [FieldOffset(0)] public CommonObjectRflParam commonObjectRflParam;
        [FieldOffset(8)] public TornadoObjectResourceRflParam tornadoObjectResourceParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 304)]
    public struct EggroboObjectResourceRflParam
    {
        [FieldOffset(0)]   public CommonObjectResourceRflParam commonObjectResourceRflParam;
        [FieldOffset(296)] public int dummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 312)]
    public struct EggroboObjectRflParam
    {
        [FieldOffset(0)] public CommonObjectRflParam commonObjectRflParam;
        [FieldOffset(8)] public EggroboObjectResourceRflParam eggroboObjectResourceParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 304)]
    public struct MogumoguObjectResourceRflParam
    {
        [FieldOffset(0)]   public CommonObjectResourceRflParam commonObjectResourceRflParam;
        [FieldOffset(296)] public int dummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 312)]
    public struct MogumoguObjectRflParam
    {
        [FieldOffset(0)] public CommonObjectRflParam commonObjectRflParam;
        [FieldOffset(8)] public MogumoguObjectResourceRflParam mogumoguObjectResourceParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 304)]
    public struct ValkyneObjectResourceRflParam
    {
        [FieldOffset(0)]   public CommonObjectResourceRflParam commonObjectResourceRflParam;
        [FieldOffset(296)] public int dummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 312)]
    public struct ValkyneObjectRflParam
    {
        [FieldOffset(0)] public CommonObjectRflParam commonObjectRflParam;
        [FieldOffset(8)] public ValkyneObjectResourceRflParam valkyneObjectResourceParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct SkyObjectRflParam
    {
        [FieldOffset(0)] public int dummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public struct SkyObjectResourceRflParam
    {
        [FieldOffset(0)]  public CString model;
        [FieldOffset(16)] public CString animation;
        [FieldOffset(32)] public CString skeleton;
        [FieldOffset(48)] public float radius;
    }

    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public struct PatabataObjectResourceRflParam
    {
        [FieldOffset(0)]  public SkyObjectResourceRflParam skyObjectResourceRflParam;
        [FieldOffset(56)] public int dummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public struct PatabataObjectRflParam
    {
        [FieldOffset(0)] public SkyObjectRflParam skyObjectRflParam;
        [FieldOffset(8)] public PatabataObjectResourceRflParam patabataObjectResourceParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 304)]
    public struct MetalSonicObjectResourceRflParam
    {
        [FieldOffset(0)]   public CommonObjectResourceRflParam commonObjectResourceRflParam;
        [FieldOffset(296)] public int dummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 312)]
    public struct MetalSonicObjectRflParam
    {
        [FieldOffset(0)] public CommonObjectRflParam commonObjectRflParam;
        [FieldOffset(8)] public MetalSonicObjectResourceRflParam metalSonicObjectResourceParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 376)]
    public struct AntonObjectResourceRflParam
    {
        [FieldOffset(0)]   public RoundTripObjectResourceRflParam roundTripObjectResourceRflParam;
        [FieldOffset(368)] public int dummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 384)]
    public struct AntonObjectRflParam
    {
        [FieldOffset(0)] public RoundTripObjectRflParam roundTripObjectRflParam;
        [FieldOffset(8)] public AntonObjectResourceRflParam antonObjectResourceParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 304)]
    public struct AiaiObjectResourceRflParam
    {
        [FieldOffset(0)]   public CommonObjectResourceRflParam commonObjectResourceRflParam;
        [FieldOffset(296)] public int dummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 312)]
    public struct AiaiObjectRflParam
    {
        [FieldOffset(0)] public CommonObjectRflParam commonObjectRflParam;
        [FieldOffset(8)] public AiaiObjectResourceRflParam aiaiObjectResourceParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 304)]
    public struct LanderObjectResourceRflParam
    {
        [FieldOffset(0)]   public CommonObjectResourceRflParam commonObjectResourceRflParam;
        [FieldOffset(296)] public int dummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 312)]
    public struct LanderObjectRflParam
    {
        [FieldOffset(0)] public CommonObjectRflParam commonObjectRflParam;
        [FieldOffset(8)] public LanderObjectResourceRflParam landerObjectResourceParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct LinePathObjectRflParam
    {
        [FieldOffset(0)] public int dummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 160)]
    public struct LinePathObjectResourceRflParam
    {
        [FieldOffset(0)]   public CString model;
        [FieldOffset(16)]  public CString animation;
        [FieldOffset(32)]  public CString skeleton;
        [FieldOffset(48)]  public float radius;
        [FieldOffset(56)]  public EffectInfo effectInfos__arr0;
        [FieldOffset(96)] public EffectInfo effectInfos__arr1;
        [FieldOffset(136)] public VISAnimationInfo loopVISAnimInfo;
    }

    [StructLayout(LayoutKind.Explicit, Size = 168)]
    public struct FlickyBlueObjectResourceRflParam
    {
        [FieldOffset(0)]   public LinePathObjectResourceRflParam linePathObjectResourceRflParam;
        [FieldOffset(160)] public int dummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 176)]
    public struct FlickyBlueObjectRflParam
    {
        [FieldOffset(0)] public LinePathObjectRflParam linePathObjectRflParam;
        [FieldOffset(8)] public FlickyBlueObjectResourceRflParam flickyBlueObjectResourceParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 168)]
    public struct FlickyGreenObjectResourceRflParam
    {
        [FieldOffset(0)]   public LinePathObjectResourceRflParam linePathObjectResourceRflParam;
        [FieldOffset(160)] public int dummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 176)]
    public struct FlickyGreenObjectRflParam
    {
        [FieldOffset(0)] public LinePathObjectRflParam linePathObjectRflParam;
        [FieldOffset(8)] public FlickyGreenObjectResourceRflParam flickyGreenObjectResourceParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 168)]
    public struct FlickyPinkObjectResourceRflParam
    {
        [FieldOffset(0)]   public LinePathObjectResourceRflParam linePathObjectResourceRflParam;
        [FieldOffset(160)] public int dummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 176)]
    public struct FlickyPinkObjectRflParam
    {
        [FieldOffset(0)] public LinePathObjectRflParam linePathObjectRflParam;
        [FieldOffset(8)] public FlickyPinkObjectResourceRflParam flickyPinkObjectResourceParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 168)]
    public struct FlickyRedObjectResourceRflParam
    {
        [FieldOffset(0)]   public LinePathObjectResourceRflParam linePathObjectResourceRflParam;
        [FieldOffset(160)] public int dummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 176)]
    public struct FlickyRedObjectRflParam
    {
        [FieldOffset(0)] public LinePathObjectRflParam linePathObjectRflParam;
        [FieldOffset(8)] public FlickyRedObjectResourceRflParam flickyRedObjectResourceParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 168)]
    public struct WaterSonicObjectResourceRflParam
    {
        [FieldOffset(0)]   public LinePathObjectResourceRflParam linePathObjectResourceRflParam;
        [FieldOffset(160)] public int dummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 176)]
    public struct WaterSonicObjectRflParam
    {
        [FieldOffset(0)] public LinePathObjectRflParam linePathObjectRflParam;
        [FieldOffset(8)] public WaterSonicObjectResourceRflParam waterSonicObjectResourceParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 168)]
    public struct SuperSonicObjectResourceRflParam
    {
        [FieldOffset(0)]   public LinePathObjectResourceRflParam linePathObjectResourceRflParam;
        [FieldOffset(160)] public int dummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 176)]
    public struct SuperSonicObjectRflParam
    {
        [FieldOffset(0)] public LinePathObjectRflParam linePathObjectRflParam;
        [FieldOffset(8)] public SuperSonicObjectResourceRflParam superSonicObjectResourceParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 168)]
    public struct FlyingTailsObjectResourceRflParam
    {
        [FieldOffset(0)]   public LinePathObjectResourceRflParam linePathObjectResourceRflParam;
        [FieldOffset(160)] public int dummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 176)]
    public struct FlyingTailsObjectRflParam
    {
        [FieldOffset(0)] public LinePathObjectRflParam linePathObjectRflParam;
        [FieldOffset(8)] public FlyingTailsObjectResourceRflParam flyingTailsObjectResourceParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 520)]
    public struct IslandCommonSonicObjectResourceRflParam
    {
        [FieldOffset(0)]   public CString model;
        [FieldOffset(16)]  public CString normalWaitAnim;
        [FieldOffset(32)]  public CString islandAnims__arr0;
        [FieldOffset(287)] public CString islandAnims__arr1;
        [FieldOffset(542)] public CString islandAnims__arr2;
        [FieldOffset(797)] public CString islandAnims__arr3;
        [FieldOffset(96)]  public CString islandCommonWaitAnimA;
        [FieldOffset(112)] public CString islandCommonWaitAnimB;
        [FieldOffset(128)] public CString skeleton;
        [FieldOffset(144)] public UVAnimationInfo islandEyeUVAnimInfos__arr0;
        [FieldOffset(184)] public UVAnimationInfo islandEyeUVAnimInfos__arr1;
        [FieldOffset(224)] public UVAnimationInfo islandEyeUVAnimInfos__arr2;
        [FieldOffset(264)] public UVAnimationInfo islandEyeUVAnimInfos__arr3;
        [FieldOffset(304)] public UVAnimationInfo islandCommonWaitBEyeUVAnimInfo;
        [FieldOffset(344)] public VISAnimationInfo islandVISAnimInfos__arr0;
        [FieldOffset(368)] public VISAnimationInfo islandVISAnimInfos__arr1;
        [FieldOffset(392)] public VISAnimationInfo islandVISAnimInfos__arr2;
        [FieldOffset(416)] public VISAnimationInfo islandVISAnimInfos__arr3;
        [FieldOffset(440)] public VISAnimationInfo normalWaitVISAnimInfo;
        [FieldOffset(464)] public VISAnimationInfo islandCommonWaitAVISAnimInfo;
        [FieldOffset(488)] public VISAnimationInfo islandCommonWaitBVISAnimInfo;
        [FieldOffset(512)] public float radius;
    }

    [StructLayout(LayoutKind.Explicit, Size = 520)]
    public struct IslandCommonSonicObjectRflParam
    {
        [FieldOffset(0)] public IslandCommonSonicObjectResourceRflParam islandCommonSonicObjectResourceParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 304)]
    public struct IslandW2SonicObjectResourceRflParam
    {
        [FieldOffset(0)]   public CommonObjectResourceRflParam commonObjectResourceRflParam;
        [FieldOffset(296)] public int dummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 312)]
    public struct IslandW2SonicObjectRflParam
    {
        [FieldOffset(0)] public CommonObjectRflParam commonObjectRflParam;
        [FieldOffset(8)] public IslandW2SonicObjectResourceRflParam islandW2SonicObjectResourceParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 392)]
    public struct IslandW5SonicObjectResourceRflParam
    {
        [FieldOffset(0)]   public CString sonicModel;
        [FieldOffset(16)]  public CString sonicAnim;
        [FieldOffset(32)]  public CString sonicAnimR;
        [FieldOffset(48)]  public CString sonicAnimSwitch;
        [FieldOffset(64)]  public CString sonicAnimSwitchR;
        [FieldOffset(80)]  public CString sonicSkeleton;
        [FieldOffset(96)]  public CString drumModel;
        [FieldOffset(112)] public CString drumAnim;
        [FieldOffset(128)] public CString drumAnimR;
        [FieldOffset(144)] public CString drumAnimSwitch;
        [FieldOffset(160)] public CString drumAnimSwitchR;
        [FieldOffset(176)] public CString drumSkeleton;
        [FieldOffset(192)] public OneShotEffectInfo effectDrum;
        [FieldOffset(240)] public OneShotEffectInfo effectDrumR;
        [FieldOffset(288)] public VISAnimationInfo loopVISAnimInfo;
        [FieldOffset(312)] public VISAnimationInfo loopVISAnimInfoR;
        [FieldOffset(336)] public VISAnimationInfo switchVISAnimInfo;
        [FieldOffset(360)] public VISAnimationInfo switchVISAnimInfoR;
        [FieldOffset(384)] public float radius;
    }

    [StructLayout(LayoutKind.Explicit, Size = 392)]
    public struct IslandW5SonicObjectRflParam
    {
        [FieldOffset(0)] public IslandW5SonicObjectResourceRflParam islandW5SonicObjectResourceParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 336)]
    public struct IslandCommonTailsObjectResourceRflParam
    {
        [FieldOffset(0)]   public CString model;
        [FieldOffset(16)]  public CString normalWaitAnim;
        [FieldOffset(32)]  public CString islandAnims__arr0;
        [FieldOffset(287)] public CString islandAnims__arr1;
        [FieldOffset(542)] public CString islandAnims__arr2;
        [FieldOffset(797)] public CString islandAnims__arr3;
        [FieldOffset(1052)] public CString islandAnims__arr4;
        [FieldOffset(112)] public CString skeleton;
        [FieldOffset(128)] public UVAnimationInfo islandEyeUVAnimInfos__arr0;
        [FieldOffset(168)] public UVAnimationInfo islandEyeUVAnimInfos__arr1;
        [FieldOffset(208)] public UVAnimationInfo islandEyeUVAnimInfos__arr2;
        [FieldOffset(248)] public UVAnimationInfo islandEyeUVAnimInfos__arr3;
        [FieldOffset(288)] public UVAnimationInfo islandEyeUVAnimInfos__arr4;
        [FieldOffset(328)] public float radius;
    }

    [StructLayout(LayoutKind.Explicit, Size = 336)]
    public struct IslandCommonTailsObjectRflParam
    {
        [FieldOffset(0)] public IslandCommonTailsObjectResourceRflParam islandCommonTailsObjectResourceParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 136)]
    public struct IslandCommonEggmanObjectResourceRflParam
    {
        [FieldOffset(0)]   public CString model;
        [FieldOffset(16)]  public CString normalWaitAnim;
        [FieldOffset(32)]  public CString islandAnims__arr0;
        [FieldOffset(287)] public CString islandAnims__arr1;
        [FieldOffset(542)] public CString islandAnims__arr2;
        [FieldOffset(797)] public CString islandAnims__arr3;
        [FieldOffset(1052)] public CString islandAnims__arr4;
        [FieldOffset(112)] public CString skeleton;
        [FieldOffset(128)] public float radius;
    }

    [StructLayout(LayoutKind.Explicit, Size = 136)]
    public struct IslandCommonEggmanObjectRflParam
    {
        [FieldOffset(0)] public IslandCommonEggmanObjectResourceRflParam islandCommonEggmanObjectResourceParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public struct IslandW1EggmanObjectResourceRflParam
    {
        [FieldOffset(0)]  public CString model;
        [FieldOffset(16)] public CString normalWaitAnim;
        [FieldOffset(32)] public CString islandLeftAnim;
        [FieldOffset(48)] public CString islandRightAnim;
        [FieldOffset(64)] public CString skeleton;
        [FieldOffset(80)] public float radius;
    }

    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public struct IslandW1EggmanObjectRflParam
    {
        [FieldOffset(0)] public IslandW1EggmanObjectResourceRflParam islandW1EggmanObjectResourceParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 320)]
    public struct IslandCommonKnucklesObjectResourceRflParam
    {
        [FieldOffset(0)]   public CString model;
        [FieldOffset(16)]  public CString normalWaitAnim;
        [FieldOffset(32)]  public CString islandAnims__arr0;
        [FieldOffset(287)] public CString islandAnims__arr1;
        [FieldOffset(542)] public CString islandAnims__arr2;
        [FieldOffset(797)] public CString islandAnims__arr3;
        [FieldOffset(1052)] public CString islandAnims__arr4;
        [FieldOffset(1307)] public CString islandAnims__arr5;
        [FieldOffset(128)] public CString skeleton;
        [FieldOffset(144)] public VISAnimationInfo islandVISAnimInfos__arr0;
        [FieldOffset(168)] public VISAnimationInfo islandVISAnimInfos__arr1;
        [FieldOffset(192)] public VISAnimationInfo islandVISAnimInfos__arr2;
        [FieldOffset(216)] public VISAnimationInfo islandVISAnimInfos__arr3;
        [FieldOffset(240)] public VISAnimationInfo islandVISAnimInfos__arr4;
        [FieldOffset(264)] public VISAnimationInfo islandVISAnimInfos__arr5;
        [FieldOffset(288)] public VISAnimationInfo normalWaitVISAnimInfo;
        [FieldOffset(312)] public float radius;
    }

    [StructLayout(LayoutKind.Explicit, Size = 320)]
    public struct IslandCommonKnucklesObjectRflParam
    {
        [FieldOffset(0)] public IslandCommonKnucklesObjectResourceRflParam islandCommonKnucklesObjectResourceParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public struct IslandW5KnucklesObjectResourceRflParam
    {
        [FieldOffset(0)]  public CString model;
        [FieldOffset(16)] public CString animation;
        [FieldOffset(32)] public CString skeleton;
        [FieldOffset(48)] public VISAnimationInfo VISAnimInfo;
        [FieldOffset(72)] public float radius;
    }

    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public struct IslandW5KnucklesObjectRflParam
    {
        [FieldOffset(0)] public IslandW5KnucklesObjectResourceRflParam islandW5KnucklesObjectResourceParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 280)]
    public struct GlidingKnucklesObjectResourceRflParam
    {
        [FieldOffset(0)]   public CString model;
        [FieldOffset(16)]  public CString islandAnims__arr0;
        [FieldOffset(271)] public CString islandAnims__arr1;
        [FieldOffset(526)] public CString islandAnims__arr2;
        [FieldOffset(781)] public CString islandAnims__arr3;
        [FieldOffset(1036)] public CString islandAnims__arr4;
        [FieldOffset(1291)] public CString islandAnims__arr5;
        [FieldOffset(112)] public CString skeleton;
        [FieldOffset(128)] public VISAnimationInfo islandVISAnimInfos__arr0;
        [FieldOffset(152)] public VISAnimationInfo islandVISAnimInfos__arr1;
        [FieldOffset(176)] public VISAnimationInfo islandVISAnimInfos__arr2;
        [FieldOffset(200)] public VISAnimationInfo islandVISAnimInfos__arr3;
        [FieldOffset(224)] public VISAnimationInfo islandVISAnimInfos__arr4;
        [FieldOffset(248)] public VISAnimationInfo islandVISAnimInfos__arr5;
        [FieldOffset(272)] public float radius;
    }

    [StructLayout(LayoutKind.Explicit, Size = 288)]
    public struct GlidingKnucklesObjectRflParam
    {
        [FieldOffset(0)] public LinePathObjectRflParam linePathObjectRflParam;
        [FieldOffset(8)] public GlidingKnucklesObjectResourceRflParam glidingKnucklesObjectResourceParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 320)]
    public struct IslandCommonAmyObjectResourceRflParam
    {
        [FieldOffset(0)]   public CString model;
        [FieldOffset(16)]  public CString normalWaitAnim;
        [FieldOffset(32)]  public CString islandAnims__arr0;
        [FieldOffset(287)] public CString islandAnims__arr1;
        [FieldOffset(542)] public CString islandAnims__arr2;
        [FieldOffset(797)] public CString islandAnims__arr3;
        [FieldOffset(1052)] public CString islandAnims__arr4;
        [FieldOffset(1307)] public CString islandAnims__arr5;
        [FieldOffset(128)] public CString skeleton;
        [FieldOffset(144)] public VISAnimationInfo islandVISAnimInfos__arr0;
        [FieldOffset(168)] public VISAnimationInfo islandVISAnimInfos__arr1;
        [FieldOffset(192)] public VISAnimationInfo islandVISAnimInfos__arr2;
        [FieldOffset(216)] public VISAnimationInfo islandVISAnimInfos__arr3;
        [FieldOffset(240)] public VISAnimationInfo islandVISAnimInfos__arr4;
        [FieldOffset(264)] public VISAnimationInfo islandVISAnimInfos__arr5;
        [FieldOffset(288)] public VISAnimationInfo normalWaitVISAnimInfo;
        [FieldOffset(312)] public float radius;
    }

    [StructLayout(LayoutKind.Explicit, Size = 320)]
    public struct IslandCommonAmyObjectRflParam
    {
        [FieldOffset(0)] public IslandCommonAmyObjectResourceRflParam islandCommonAmyObjectResourceParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct AmyOneShotEffectInfo
    {
        [FieldOffset(0)]  public EffectInfo effectInfo;
        [FieldOffset(40)] public uint frame;
    }

    [StructLayout(LayoutKind.Explicit, Size = 168)]
    public struct IslandW3AmyObjectResourceRflParam
    {
        [FieldOffset(0)]   public CString model;
        [FieldOffset(16)]  public CString idleAnim;
        [FieldOffset(32)]  public CString islandAnim;
        [FieldOffset(48)]  public CString skeleton;
        [FieldOffset(64)]  public AmyOneShotEffectInfo oneShotEffect;
        [FieldOffset(112)] public VISAnimationInfo idleVISAnimInfo;
        [FieldOffset(136)] public VISAnimationInfo islandVISAnimInfo;
        [FieldOffset(160)] public float radius;
    }

    [StructLayout(LayoutKind.Explicit, Size = 168)]
    public struct IslandW3AmyObjectRflParam
    {
        [FieldOffset(0)] public IslandW3AmyObjectResourceRflParam islandW3AmyObjectResourceParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct AmyLoopEffectInfo
    {
        [FieldOffset(0)]  public EffectInfo effectInfo;
        [FieldOffset(40)] public uint startFrame;
        [FieldOffset(44)] public uint endFrame;
    }

    [StructLayout(LayoutKind.Explicit, Size = 280)]
    public struct IslandW4AmyObjectResourceRflParam
    {
        [FieldOffset(0)]   public CString amyModel;
        [FieldOffset(16)]  public CString amyIdleAnim;
        [FieldOffset(32)]  public CString amyIslandAnim;
        [FieldOffset(48)]  public CString amySkeleton;
        [FieldOffset(64)]  public CString hammerModel;
        [FieldOffset(80)]  public CString hammerIdleAnim;
        [FieldOffset(96)]  public CString hammerIslandAnim;
        [FieldOffset(112)] public CString hammerSkeleton;
        [FieldOffset(128)] public AmyOneShotEffectInfo oneShotEffect;
        [FieldOffset(176)] public AmyLoopEffectInfo loopEffect;
        [FieldOffset(224)] public VISAnimationInfo idleVISAnimInfo;
        [FieldOffset(248)] public VISAnimationInfo islandVISAnimInfo;
        [FieldOffset(272)] public float radius;
    }

    [StructLayout(LayoutKind.Explicit, Size = 280)]
    public struct IslandW4AmyObjectRflParam
    {
        [FieldOffset(0)] public IslandW4AmyObjectResourceRflParam islandW4AmyObjectResourceParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 304)]
    public struct StarlightfloorObjectResourceRflParam
    {
        [FieldOffset(0)]   public CommonObjectResourceRflParam commonObjectResourceRflParam;
        [FieldOffset(296)] public int dummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 312)]
    public struct StarlightfloorObjectRflParam
    {
        [FieldOffset(0)] public CommonObjectRflParam commonObjectRflParam;
        [FieldOffset(8)] public StarlightfloorObjectResourceRflParam starlightfloorObjectResourceParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 304)]
    public struct CarnivalDrumObjectResourceRflParam
    {
        [FieldOffset(0)]   public CommonObjectResourceRflParam commonObjectResourceRflParam;
        [FieldOffset(296)] public int dummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 312)]
    public struct CarnivalDrumObjectRflParam
    {
        [FieldOffset(0)] public CommonObjectRflParam commonObjectRflParam;
        [FieldOffset(8)] public CarnivalDrumObjectResourceRflParam carnivalDrumObjectResourceParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct StaticObjectRflParam
    {
        [FieldOffset(0)] public int dummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct StaticObjectResourceRflParam
    {
        [FieldOffset(0)]  public CString model;
        [FieldOffset(16)] public float radius;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct ShadowObjectResourceRflParam
    {
        [FieldOffset(0)]  public StaticObjectResourceRflParam staticObjectResourceRflParam;
        [FieldOffset(24)] public int dummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public struct ShadowObjectRflParam
    {
        [FieldOffset(0)] public StaticObjectRflParam staticObjectRflParam;
        [FieldOffset(8)] public ShadowObjectResourceRflParam shadowObjectResourceParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct ShadowSkyObjectResourceRflParam
    {
        [FieldOffset(0)]  public StaticObjectResourceRflParam staticObjectResourceRflParam;
        [FieldOffset(24)] public int dummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public struct ShadowSkyObjectRflParam
    {
        [FieldOffset(0)] public StaticObjectRflParam staticObjectRflParam;
        [FieldOffset(8)] public ShadowSkyObjectResourceRflParam shadowSkyObjectResourceParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct IslandObjectResourceRflParam
    {
        [FieldOffset(0)]  public CString model;
        [FieldOffset(16)] public float radius;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct IslandObjectRflParam
    {
        [FieldOffset(0)]  public IslandObjectResourceRflParam islandObjectResourceParam;
        [FieldOffset(24)] public float impostorScale;
    }

    [StructLayout(LayoutKind.Explicit, Size = 10608)]
    public struct ObjectRflParam
    {
        [FieldOffset(0)]     public BeetonObjectRflParam beetonObject;
        [FieldOffset(248)]   public MotoraObjectRflParam motoraObject;
        [FieldOffset(632)]   public BatabataObjectRflParam batabataObject;
        [FieldOffset(848)]   public RockyObjectRflParam rockyObject;
        [FieldOffset(1064)]  public FlickyObjectRflParam flickyObject;
        [FieldOffset(1328)]  public PeckyObjectRflParam peckyObject;
        [FieldOffset(1544)]  public RickyObjectRflParam rickyObject;
        [FieldOffset(1808)]  public CuckyObjectRflParam cuckyObject;
        [FieldOffset(2072)]  public PickyObjectRflParam pickyObject;
        [FieldOffset(2336)]  public PockyObjectRflParam pockyObject;
        [FieldOffset(2600)]  public TornadoObjectRflParam tornadoObject;
        [FieldOffset(2912)]  public EggroboObjectRflParam eggroboObject;
        [FieldOffset(3224)]  public MogumoguObjectRflParam mogumoguObject;
        [FieldOffset(3536)]  public ValkyneObjectRflParam valkyneObject;
        [FieldOffset(3848)]  public PatabataObjectRflParam patabataObject;
        [FieldOffset(3920)]  public MetalSonicObjectRflParam metalSonicObject;
        [FieldOffset(4232)]  public AntonObjectRflParam antonObject;
        [FieldOffset(4616)]  public AiaiObjectRflParam aiaiObject;
        [FieldOffset(4928)]  public LanderObjectRflParam landerObject;
        [FieldOffset(5240)]  public FlickyBlueObjectRflParam flickyBlueObject;
        [FieldOffset(5416)]  public FlickyGreenObjectRflParam flickyGreenObject;
        [FieldOffset(5592)]  public FlickyPinkObjectRflParam flickyPinkObject;
        [FieldOffset(5768)]  public FlickyRedObjectRflParam flickyRedObject;
        [FieldOffset(5944)]  public WaterSonicObjectRflParam waterSonicObject;
        [FieldOffset(6120)]  public SuperSonicObjectRflParam superSonicObject;
        [FieldOffset(6296)]  public FlyingTailsObjectRflParam flyingTailsObject;
        [FieldOffset(6472)]  public IslandCommonSonicObjectRflParam islandCommonSonicObject;
        [FieldOffset(6992)]  public IslandW2SonicObjectRflParam islandW2SonicObject;
        [FieldOffset(7304)]  public IslandW5SonicObjectRflParam islandW5SonicObject;
        [FieldOffset(7696)]  public IslandCommonTailsObjectRflParam islandCommonTailsObject;
        [FieldOffset(8032)]  public IslandCommonEggmanObjectRflParam islandCommonEggmanObject;
        [FieldOffset(8168)]  public IslandW1EggmanObjectRflParam islandW1EggmanObject;
        [FieldOffset(8256)]  public IslandCommonKnucklesObjectRflParam islandCommonKnucklesObject;
        [FieldOffset(8576)]  public IslandW5KnucklesObjectRflParam islandW5KnucklesObject;
        [FieldOffset(8656)]  public GlidingKnucklesObjectRflParam glidingKnucklesObject;
        [FieldOffset(8944)]  public IslandCommonAmyObjectRflParam islandCommonAmyObject;
        [FieldOffset(9264)]  public IslandW3AmyObjectRflParam islandW3AmyObject;
        [FieldOffset(9432)]  public IslandW4AmyObjectRflParam islandW4AmyObject;
        [FieldOffset(9712)]  public StarlightfloorObjectRflParam starlightfloorObject;
        [FieldOffset(10024)] public CarnivalDrumObjectRflParam carnivalDrumObject;
        [FieldOffset(10336)] public ShadowObjectRflParam shadowObject;
        [FieldOffset(10376)] public ShadowSkyObjectRflParam shadowSkyObject;
        [FieldOffset(10416)] public IslandObjectRflParam islandObject__arr0;
        [FieldOffset(10448)] public IslandObjectRflParam islandObject__arr1;
        [FieldOffset(10480)] public IslandObjectRflParam islandObject__arr2;
        [FieldOffset(10512)] public IslandObjectRflParam islandObject__arr3;
        [FieldOffset(10544)] public IslandObjectRflParam islandObject__arr4;
        [FieldOffset(10576)] public IslandObjectRflParam islandObject__arr5;
    }

}