#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    const char* pValue;
    INSERT_PADDING(8);
}
cstring;

typedef struct
{
    cstring effectName;
    cstring effectNodeName;
    bool follow;
}
EffectInfo;

typedef struct
{
    EffectInfo effectInfo;
    uint32_t frames[2];
}
OneShotEffectInfo;

typedef struct
{
    cstring model;
    cstring flyAnim;
    cstring attackAnim;
    cstring skeleton;
    float radius;
    EffectInfo burnerEffectInfos[2];
    OneShotEffectInfo strongBurnerEffectInfos[2];
}
BeetonObjectResourceRflParam;

typedef struct
{
    BeetonObjectResourceRflParam beetonObjectResourceParam;
}
BeetonObjectRflParam;

typedef struct
{
    int32_t dummy;
}
RoundTripObjectRflParam;

typedef struct
{
    cstring model;
    cstring moveAnim;
    cstring waitAnim;
    cstring jumpAnim;
    cstring skeleton;
    float radius;
    EffectInfo effectMoveGrass;
    OneShotEffectInfo effectJumpGrass;
    OneShotEffectInfo effectLandingGrass;
    EffectInfo effectMoveRock;
    OneShotEffectInfo effectJumpRock;
    OneShotEffectInfo effectLandingRock;
    bool isLeaningOnPath;
}
RoundTripObjectResourceRflParam;

typedef struct
{
    RoundTripObjectResourceRflParam roundTripObjectResourceRflParam;
    int32_t dummy;
}
MotoraObjectResourceRflParam;

typedef struct
{
    RoundTripObjectRflParam roundTripObjectRflParam;
    MotoraObjectResourceRflParam motoraObjectResourceParam;
}
MotoraObjectRflParam;

typedef struct
{
    int32_t dummy;
}
WaterObjectRflParam;

typedef struct
{
    cstring model;
    cstring animation;
    cstring skeleton;
    float radius;
    OneShotEffectInfo effectJump;
    OneShotEffectInfo effectTouchdown;
    OneShotEffectInfo effectWaterDrop;
}
WaterObjectResourceRflParam;

typedef struct
{
    WaterObjectResourceRflParam waterObjectResourceRflParam;
    int32_t dummy;
}
BatabataObjectResourceRflParam;

typedef struct
{
    WaterObjectRflParam waterObjectRflParam;
    BatabataObjectResourceRflParam batabataObjectResourceParam;
}
BatabataObjectRflParam;

typedef struct
{
    WaterObjectResourceRflParam waterObjectResourceRflParam;
    int32_t dummy;
}
RockyObjectResourceRflParam;

typedef struct
{
    WaterObjectRflParam waterObjectRflParam;
    RockyObjectResourceRflParam rockyObjectResourceParam;
}
RockyObjectRflParam;

typedef struct
{
    int32_t dummy;
}
GroundObjectRflParam;

typedef struct
{
    cstring model;
    cstring animation;
    cstring skeleton;
    float radius;
    OneShotEffectInfo effectJumpGrass;
    OneShotEffectInfo effectLandingGrass;
    OneShotEffectInfo effectJumpRock;
    OneShotEffectInfo effectLandingRock;
}
GroundObjectResourceRflParam;

typedef struct
{
    GroundObjectResourceRflParam groundObjectResourceRflParam;
    int32_t dummy;
}
FlickyObjectResourceRflParam;

typedef struct
{
    GroundObjectRflParam groundObjectRflParam;
    FlickyObjectResourceRflParam flickyObjectResourceParam;
}
FlickyObjectRflParam;

typedef struct
{
    WaterObjectResourceRflParam waterObjectResourceRflParam;
    int32_t dummy;
}
PeckyObjectResourceRflParam;

typedef struct
{
    WaterObjectRflParam waterObjectRflParam;
    PeckyObjectResourceRflParam peckyObjectResourceParam;
}
PeckyObjectRflParam;

typedef struct
{
    GroundObjectResourceRflParam groundObjectResourceRflParam;
    int32_t dummy;
}
RickyObjectResourceRflParam;

typedef struct
{
    GroundObjectRflParam groundObjectRflParam;
    RickyObjectResourceRflParam rickyObjectResourceParam;
}
RickyObjectRflParam;

typedef struct
{
    GroundObjectResourceRflParam groundObjectResourceRflParam;
    int32_t dummy;
}
CuckyObjectResourceRflParam;

typedef struct
{
    GroundObjectRflParam groundObjectRflParam;
    CuckyObjectResourceRflParam cuckyObjectResourceParam;
}
CuckyObjectRflParam;

typedef struct
{
    GroundObjectResourceRflParam groundObjectResourceRflParam;
    int32_t dummy;
}
PickyObjectResourceRflParam;

typedef struct
{
    GroundObjectRflParam groundObjectRflParam;
    PickyObjectResourceRflParam pickyObjectResourceParam;
}
PickyObjectRflParam;

typedef struct
{
    GroundObjectResourceRflParam groundObjectResourceRflParam;
    int32_t dummy;
}
PockyObjectResourceRflParam;

typedef struct
{
    GroundObjectRflParam groundObjectRflParam;
    PockyObjectResourceRflParam pockyObjectResourceParam;
}
PockyObjectRflParam;

typedef struct
{
    int32_t dummy;
}
CommonObjectRflParam;

typedef struct
{
    bool isActive;
    cstring uvAnimNames[2];
}
UVAnimationInfo;

typedef struct
{
    bool isActive;
    cstring visAnimNames;
}
VISAnimationInfo;

typedef struct
{
    cstring model;
    cstring animation;
    cstring skeleton;
    float radius;
    EffectInfo effectInfos[2];
    OneShotEffectInfo oneShotEffectInfos[2];
    UVAnimationInfo loopUVAnimInfo;
    VISAnimationInfo loopVISAnimInfo;
}
CommonObjectResourceRflParam;

typedef struct
{
    CommonObjectResourceRflParam commonObjectResourceRflParam;
    int32_t dummy;
}
TornadoObjectResourceRflParam;

typedef struct
{
    CommonObjectRflParam commonObjectRflParam;
    TornadoObjectResourceRflParam tornadoObjectResourceParam;
}
TornadoObjectRflParam;

typedef struct
{
    CommonObjectResourceRflParam commonObjectResourceRflParam;
    int32_t dummy;
}
EggroboObjectResourceRflParam;

typedef struct
{
    CommonObjectRflParam commonObjectRflParam;
    EggroboObjectResourceRflParam eggroboObjectResourceParam;
}
EggroboObjectRflParam;

typedef struct
{
    CommonObjectResourceRflParam commonObjectResourceRflParam;
    int32_t dummy;
}
MogumoguObjectResourceRflParam;

typedef struct
{
    CommonObjectRflParam commonObjectRflParam;
    MogumoguObjectResourceRflParam mogumoguObjectResourceParam;
}
MogumoguObjectRflParam;

typedef struct
{
    CommonObjectResourceRflParam commonObjectResourceRflParam;
    int32_t dummy;
}
ValkyneObjectResourceRflParam;

typedef struct
{
    CommonObjectRflParam commonObjectRflParam;
    ValkyneObjectResourceRflParam valkyneObjectResourceParam;
}
ValkyneObjectRflParam;

typedef struct
{
    int32_t dummy;
}
SkyObjectRflParam;

typedef struct
{
    cstring model;
    cstring animation;
    cstring skeleton;
    float radius;
}
SkyObjectResourceRflParam;

typedef struct
{
    SkyObjectResourceRflParam skyObjectResourceRflParam;
    int32_t dummy;
}
PatabataObjectResourceRflParam;

typedef struct
{
    SkyObjectRflParam skyObjectRflParam;
    PatabataObjectResourceRflParam patabataObjectResourceParam;
}
PatabataObjectRflParam;

typedef struct
{
    CommonObjectResourceRflParam commonObjectResourceRflParam;
    int32_t dummy;
}
MetalSonicObjectResourceRflParam;

typedef struct
{
    CommonObjectRflParam commonObjectRflParam;
    MetalSonicObjectResourceRflParam metalSonicObjectResourceParam;
}
MetalSonicObjectRflParam;

typedef struct
{
    RoundTripObjectResourceRflParam roundTripObjectResourceRflParam;
    int32_t dummy;
}
AntonObjectResourceRflParam;

typedef struct
{
    RoundTripObjectRflParam roundTripObjectRflParam;
    AntonObjectResourceRflParam antonObjectResourceParam;
}
AntonObjectRflParam;

typedef struct
{
    CommonObjectResourceRflParam commonObjectResourceRflParam;
    int32_t dummy;
}
AiaiObjectResourceRflParam;

typedef struct
{
    CommonObjectRflParam commonObjectRflParam;
    AiaiObjectResourceRflParam aiaiObjectResourceParam;
}
AiaiObjectRflParam;

typedef struct
{
    CommonObjectResourceRflParam commonObjectResourceRflParam;
    int32_t dummy;
}
LanderObjectResourceRflParam;

typedef struct
{
    CommonObjectRflParam commonObjectRflParam;
    LanderObjectResourceRflParam landerObjectResourceParam;
}
LanderObjectRflParam;

typedef struct
{
    int32_t dummy;
}
LinePathObjectRflParam;

typedef struct
{
    cstring model;
    cstring animation;
    cstring skeleton;
    float radius;
    EffectInfo effectInfos[2];
    VISAnimationInfo loopVISAnimInfo;
}
LinePathObjectResourceRflParam;

typedef struct
{
    LinePathObjectResourceRflParam linePathObjectResourceRflParam;
    int32_t dummy;
}
FlickyBlueObjectResourceRflParam;

typedef struct
{
    LinePathObjectRflParam linePathObjectRflParam;
    FlickyBlueObjectResourceRflParam flickyBlueObjectResourceParam;
}
FlickyBlueObjectRflParam;

typedef struct
{
    LinePathObjectResourceRflParam linePathObjectResourceRflParam;
    int32_t dummy;
}
FlickyGreenObjectResourceRflParam;

typedef struct
{
    LinePathObjectRflParam linePathObjectRflParam;
    FlickyGreenObjectResourceRflParam flickyGreenObjectResourceParam;
}
FlickyGreenObjectRflParam;

typedef struct
{
    LinePathObjectResourceRflParam linePathObjectResourceRflParam;
    int32_t dummy;
}
FlickyPinkObjectResourceRflParam;

typedef struct
{
    LinePathObjectRflParam linePathObjectRflParam;
    FlickyPinkObjectResourceRflParam flickyPinkObjectResourceParam;
}
FlickyPinkObjectRflParam;

typedef struct
{
    LinePathObjectResourceRflParam linePathObjectResourceRflParam;
    int32_t dummy;
}
FlickyRedObjectResourceRflParam;

typedef struct
{
    LinePathObjectRflParam linePathObjectRflParam;
    FlickyRedObjectResourceRflParam flickyRedObjectResourceParam;
}
FlickyRedObjectRflParam;

typedef struct
{
    LinePathObjectResourceRflParam linePathObjectResourceRflParam;
    int32_t dummy;
}
WaterSonicObjectResourceRflParam;

typedef struct
{
    LinePathObjectRflParam linePathObjectRflParam;
    WaterSonicObjectResourceRflParam waterSonicObjectResourceParam;
}
WaterSonicObjectRflParam;

typedef struct
{
    LinePathObjectResourceRflParam linePathObjectResourceRflParam;
    int32_t dummy;
}
SuperSonicObjectResourceRflParam;

typedef struct
{
    LinePathObjectRflParam linePathObjectRflParam;
    SuperSonicObjectResourceRflParam superSonicObjectResourceParam;
}
SuperSonicObjectRflParam;

typedef struct
{
    LinePathObjectResourceRflParam linePathObjectResourceRflParam;
    int32_t dummy;
}
FlyingTailsObjectResourceRflParam;

typedef struct
{
    LinePathObjectRflParam linePathObjectRflParam;
    FlyingTailsObjectResourceRflParam flyingTailsObjectResourceParam;
}
FlyingTailsObjectRflParam;

typedef struct
{
    cstring model;
    cstring normalWaitAnim;
    cstring islandAnims[4];
    cstring islandCommonWaitAnimA;
    cstring islandCommonWaitAnimB;
    cstring skeleton;
    UVAnimationInfo islandEyeUVAnimInfos[4];
    UVAnimationInfo islandCommonWaitBEyeUVAnimInfo;
    VISAnimationInfo islandVISAnimInfos[4];
    VISAnimationInfo normalWaitVISAnimInfo;
    VISAnimationInfo islandCommonWaitAVISAnimInfo;
    VISAnimationInfo islandCommonWaitBVISAnimInfo;
    float radius;
}
IslandCommonSonicObjectResourceRflParam;

typedef struct
{
    IslandCommonSonicObjectResourceRflParam islandCommonSonicObjectResourceParam;
}
IslandCommonSonicObjectRflParam;

typedef struct
{
    CommonObjectResourceRflParam commonObjectResourceRflParam;
    int32_t dummy;
}
IslandW2SonicObjectResourceRflParam;

typedef struct
{
    CommonObjectRflParam commonObjectRflParam;
    IslandW2SonicObjectResourceRflParam islandW2SonicObjectResourceParam;
}
IslandW2SonicObjectRflParam;

typedef struct
{
    cstring sonicModel;
    cstring sonicAnim;
    cstring sonicAnimR;
    cstring sonicAnimSwitch;
    cstring sonicAnimSwitchR;
    cstring sonicSkeleton;
    cstring drumModel;
    cstring drumAnim;
    cstring drumAnimR;
    cstring drumAnimSwitch;
    cstring drumAnimSwitchR;
    cstring drumSkeleton;
    OneShotEffectInfo effectDrum;
    OneShotEffectInfo effectDrumR;
    VISAnimationInfo loopVISAnimInfo;
    VISAnimationInfo loopVISAnimInfoR;
    VISAnimationInfo switchVISAnimInfo;
    VISAnimationInfo switchVISAnimInfoR;
    float radius;
}
IslandW5SonicObjectResourceRflParam;

typedef struct
{
    IslandW5SonicObjectResourceRflParam islandW5SonicObjectResourceParam;
}
IslandW5SonicObjectRflParam;

typedef struct
{
    cstring model;
    cstring normalWaitAnim;
    cstring islandAnims[5];
    cstring skeleton;
    UVAnimationInfo islandEyeUVAnimInfos[5];
    float radius;
}
IslandCommonTailsObjectResourceRflParam;

typedef struct
{
    IslandCommonTailsObjectResourceRflParam islandCommonTailsObjectResourceParam;
}
IslandCommonTailsObjectRflParam;

typedef struct
{
    cstring model;
    cstring normalWaitAnim;
    cstring islandAnims[5];
    cstring skeleton;
    float radius;
}
IslandCommonEggmanObjectResourceRflParam;

typedef struct
{
    IslandCommonEggmanObjectResourceRflParam islandCommonEggmanObjectResourceParam;
}
IslandCommonEggmanObjectRflParam;

typedef struct
{
    cstring model;
    cstring normalWaitAnim;
    cstring islandLeftAnim;
    cstring islandRightAnim;
    cstring skeleton;
    float radius;
}
IslandW1EggmanObjectResourceRflParam;

typedef struct
{
    IslandW1EggmanObjectResourceRflParam islandW1EggmanObjectResourceParam;
}
IslandW1EggmanObjectRflParam;

typedef struct
{
    cstring model;
    cstring normalWaitAnim;
    cstring islandAnims[6];
    cstring skeleton;
    VISAnimationInfo islandVISAnimInfos[6];
    VISAnimationInfo normalWaitVISAnimInfo;
    float radius;
}
IslandCommonKnucklesObjectResourceRflParam;

typedef struct
{
    IslandCommonKnucklesObjectResourceRflParam islandCommonKnucklesObjectResourceParam;
}
IslandCommonKnucklesObjectRflParam;

typedef struct
{
    cstring model;
    cstring animation;
    cstring skeleton;
    VISAnimationInfo VISAnimInfo;
    float radius;
}
IslandW5KnucklesObjectResourceRflParam;

typedef struct
{
    IslandW5KnucklesObjectResourceRflParam islandW5KnucklesObjectResourceParam;
}
IslandW5KnucklesObjectRflParam;

typedef struct
{
    cstring model;
    cstring islandAnims[6];
    cstring skeleton;
    VISAnimationInfo islandVISAnimInfos[6];
    float radius;
}
GlidingKnucklesObjectResourceRflParam;

typedef struct
{
    LinePathObjectRflParam linePathObjectRflParam;
    GlidingKnucklesObjectResourceRflParam glidingKnucklesObjectResourceParam;
}
GlidingKnucklesObjectRflParam;

typedef struct
{
    cstring model;
    cstring normalWaitAnim;
    cstring islandAnims[6];
    cstring skeleton;
    VISAnimationInfo islandVISAnimInfos[6];
    VISAnimationInfo normalWaitVISAnimInfo;
    float radius;
}
IslandCommonAmyObjectResourceRflParam;

typedef struct
{
    IslandCommonAmyObjectResourceRflParam islandCommonAmyObjectResourceParam;
}
IslandCommonAmyObjectRflParam;

typedef struct
{
    EffectInfo effectInfo;
    uint32_t frame;
}
AmyOneShotEffectInfo;

typedef struct
{
    cstring model;
    cstring idleAnim;
    cstring islandAnim;
    cstring skeleton;
    AmyOneShotEffectInfo oneShotEffect;
    VISAnimationInfo idleVISAnimInfo;
    VISAnimationInfo islandVISAnimInfo;
    float radius;
}
IslandW3AmyObjectResourceRflParam;

typedef struct
{
    IslandW3AmyObjectResourceRflParam islandW3AmyObjectResourceParam;
}
IslandW3AmyObjectRflParam;

typedef struct
{
    EffectInfo effectInfo;
    uint32_t startFrame;
    uint32_t endFrame;
}
AmyLoopEffectInfo;

typedef struct
{
    cstring amyModel;
    cstring amyIdleAnim;
    cstring amyIslandAnim;
    cstring amySkeleton;
    cstring hammerModel;
    cstring hammerIdleAnim;
    cstring hammerIslandAnim;
    cstring hammerSkeleton;
    AmyOneShotEffectInfo oneShotEffect;
    AmyLoopEffectInfo loopEffect;
    VISAnimationInfo idleVISAnimInfo;
    VISAnimationInfo islandVISAnimInfo;
    float radius;
}
IslandW4AmyObjectResourceRflParam;

typedef struct
{
    IslandW4AmyObjectResourceRflParam islandW4AmyObjectResourceParam;
}
IslandW4AmyObjectRflParam;

typedef struct
{
    CommonObjectResourceRflParam commonObjectResourceRflParam;
    int32_t dummy;
}
StarlightfloorObjectResourceRflParam;

typedef struct
{
    CommonObjectRflParam commonObjectRflParam;
    StarlightfloorObjectResourceRflParam starlightfloorObjectResourceParam;
}
StarlightfloorObjectRflParam;

typedef struct
{
    CommonObjectResourceRflParam commonObjectResourceRflParam;
    int32_t dummy;
}
CarnivalDrumObjectResourceRflParam;

typedef struct
{
    CommonObjectRflParam commonObjectRflParam;
    CarnivalDrumObjectResourceRflParam carnivalDrumObjectResourceParam;
}
CarnivalDrumObjectRflParam;

typedef struct
{
    int32_t dummy;
}
StaticObjectRflParam;

typedef struct
{
    cstring model;
    float radius;
}
StaticObjectResourceRflParam;

typedef struct
{
    StaticObjectResourceRflParam staticObjectResourceRflParam;
    int32_t dummy;
}
ShadowObjectResourceRflParam;

typedef struct
{
    StaticObjectRflParam staticObjectRflParam;
    ShadowObjectResourceRflParam shadowObjectResourceParam;
}
ShadowObjectRflParam;

typedef struct
{
    StaticObjectResourceRflParam staticObjectResourceRflParam;
    int32_t dummy;
}
ShadowSkyObjectResourceRflParam;

typedef struct
{
    StaticObjectRflParam staticObjectRflParam;
    ShadowSkyObjectResourceRflParam shadowSkyObjectResourceParam;
}
ShadowSkyObjectRflParam;

typedef struct
{
    cstring model;
    float radius;
}
IslandObjectResourceRflParam;

typedef struct
{
    IslandObjectResourceRflParam islandObjectResourceParam;
    float impostorScale;
}
IslandObjectRflParam;

typedef struct
{
    BeetonObjectRflParam beetonObject;
    MotoraObjectRflParam motoraObject;
    BatabataObjectRflParam batabataObject;
    RockyObjectRflParam rockyObject;
    FlickyObjectRflParam flickyObject;
    PeckyObjectRflParam peckyObject;
    RickyObjectRflParam rickyObject;
    CuckyObjectRflParam cuckyObject;
    PickyObjectRflParam pickyObject;
    PockyObjectRflParam pockyObject;
    TornadoObjectRflParam tornadoObject;
    EggroboObjectRflParam eggroboObject;
    MogumoguObjectRflParam mogumoguObject;
    ValkyneObjectRflParam valkyneObject;
    PatabataObjectRflParam patabataObject;
    MetalSonicObjectRflParam metalSonicObject;
    AntonObjectRflParam antonObject;
    AiaiObjectRflParam aiaiObject;
    LanderObjectRflParam landerObject;
    FlickyBlueObjectRflParam flickyBlueObject;
    FlickyGreenObjectRflParam flickyGreenObject;
    FlickyPinkObjectRflParam flickyPinkObject;
    FlickyRedObjectRflParam flickyRedObject;
    WaterSonicObjectRflParam waterSonicObject;
    SuperSonicObjectRflParam superSonicObject;
    FlyingTailsObjectRflParam flyingTailsObject;
    IslandCommonSonicObjectRflParam islandCommonSonicObject;
    IslandW2SonicObjectRflParam islandW2SonicObject;
    IslandW5SonicObjectRflParam islandW5SonicObject;
    IslandCommonTailsObjectRflParam islandCommonTailsObject;
    IslandCommonEggmanObjectRflParam islandCommonEggmanObject;
    IslandW1EggmanObjectRflParam islandW1EggmanObject;
    IslandCommonKnucklesObjectRflParam islandCommonKnucklesObject;
    IslandW5KnucklesObjectRflParam islandW5KnucklesObject;
    GlidingKnucklesObjectRflParam glidingKnucklesObject;
    IslandCommonAmyObjectRflParam islandCommonAmyObject;
    IslandW3AmyObjectRflParam islandW3AmyObject;
    IslandW4AmyObjectRflParam islandW4AmyObject;
    StarlightfloorObjectRflParam starlightfloorObject;
    CarnivalDrumObjectRflParam carnivalDrumObject;
    ShadowObjectRflParam shadowObject;
    ShadowSkyObjectRflParam shadowSkyObject;
    IslandObjectRflParam islandObject[6];
}
ObjectRflParam;

