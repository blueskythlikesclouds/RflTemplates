#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    uint16_t pointMin;
    uint16_t pointMax;
    float damageRandomRate;
    float damageRandomRateSS;
    float shapeDamageRate;
    float shapeStunRate;
    float shapeStaggerRate;
}
PlayerParamOffensive;

typedef struct
{
    uint8_t rateMin;
    uint8_t rateMax;
    uint16_t infimumDropRings;
}
PlayerParamDefensive;

typedef struct
{
    PlayerParamOffensive offensive;
    PlayerParamDefensive defensive;
    float criticalDamageRate;
    float criticalRate;
    float criticalRateSS;
    float downedDamageRate;
}
PlayerParamAttackCommon;

enum HitSE : int8_t
{
    SE_None = -1,
    Weak = 0,
    Strong = 1,
    VeryStrong = 2
};

typedef struct
{
    const char* pValue;
    INSERT_PADDING(8);
}
cstring;

typedef struct
{
    float damageRate;
    float damageRateSS;
    float damageRateAcceleMode;
    float damageRateManual;
    float stunPoint;
    float staggerPoint;
    csl::math::Vector3 velocity;
    float velocityKeepTime;
    float addComboValue;
    float addComboValueAccele;
    float addComboValueSS;
    float addComboValueAcceleSS;
    float addQuickCyloopEnergy;
    float addQuickCyloopEnergyAccele;
    float addQuickCyloopEnergySS;
    float addQuickCyloopEnergyAcceleSS;
    float addQuickCyloopEnergyGuard;
    float addQuickCyloopEnergyAcceleGuard;
    csl::math::Vector3 gimmickVelocity;
    float ignoreTime;
    uint16_t attributes;
    HitSE se;
    cstring hitEffectName;
    cstring hitEffectNameSS;
    cstring hitStopName;
    cstring hitStopNameDead;
    cstring hitStopNameDeadBoss;
    cstring hitStopNameSS;
    cstring hitStopNameDeadSS;
    cstring hitCameraShakeName;
    cstring hitCameraShakeNameDead;
    cstring hitCameraShakeNameDeadBoss;
    cstring hitCameraShakeNameSS;
    cstring hitCameraShakeNameDeadSS;
    cstring hitVibrationName;
    cstring hitVibrationNameSS;
}
PlayerParamAttackData;

typedef struct
{
    PlayerParamAttackCommon common;
    PlayerParamAttackData spinAttack;
    PlayerParamAttackData spinDash;
    PlayerParamAttackData homingAttack;
    PlayerParamAttackData homingAttackAir;
    PlayerParamAttackData pursuitKick;
    PlayerParamAttackData stomping;
    PlayerParamAttackData stompingAttack;
    PlayerParamAttackData boundStompingLast;
    PlayerParamAttackData sliding;
    PlayerParamAttackData loopKick;
    PlayerParamAttackData crasher;
    PlayerParamAttackData spinSlashHoming;
    PlayerParamAttackData spinSlash;
    PlayerParamAttackData spinSlashLast;
    PlayerParamAttackData sonicBoom;
    PlayerParamAttackData crossSlash;
    PlayerParamAttackData homingShot;
    PlayerParamAttackData chargeAttack;
    PlayerParamAttackData chargeAttackLast;
    PlayerParamAttackData cyloop;
    PlayerParamAttackData cyloopQuick;
    PlayerParamAttackData cyloopAerial;
    PlayerParamAttackData accele1;
    PlayerParamAttackData accele2;
    PlayerParamAttackData aerialAccele1;
    PlayerParamAttackData aerialAccele2;
    PlayerParamAttackData comboFinish;
    PlayerParamAttackData comboFinishF;
    PlayerParamAttackData comboFinishB;
    PlayerParamAttackData comboFinishL;
    PlayerParamAttackData comboFinishR;
    PlayerParamAttackData acceleComboFinish;
    PlayerParamAttackData acceleComboFinishF;
    PlayerParamAttackData acceleComboFinishB;
    PlayerParamAttackData acceleComboFinishL;
    PlayerParamAttackData acceleComboFinishR;
    PlayerParamAttackData smash;
    PlayerParamAttackData smashLast;
    PlayerParamAttackData slingShot;
    PlayerParamAttackData knucklesPunch1;
    PlayerParamAttackData knucklesPunch2;
    PlayerParamAttackData knucklesUppercut;
    PlayerParamAttackData amyTarotAttack;
    PlayerParamAttackData amyTarotRolling;
}
PlayerParamAttack;

typedef struct
{
    float resistRate;
    float breatheBrake;
    float breatheTime;
    float breatheGravity;
}
PlayerParamWaterAct;

typedef struct
{
    float baseSpeed;
    float upSpeed;
    float upSpeedAir;
    float edgeSpeed;
    float airActionTime;
    float wallMoveTime;
}
PlayerParamBaseJump;

typedef struct
{
    float maxSpeed;
    float slidePower;
    float brakeForce;
    float slidePowerSlalom;
    float brakeForceSlalom;
    float releaseSpeed;
    bool useInput;
}
PlayerParamBallMove;

typedef struct
{
    float width;
    float distance;
    float u0;
    float u1;
}
PlayerParamLocusData;

typedef struct
{
    PlayerParamLocusData data[4];
}
PlayerParamLocus;

typedef struct
{
    float effectSpanTime;
    float effectLifeTime;
    float effectOffsetDistance;
    float effectOverlapDistance;
}
PlayerParamAuraTrain;

typedef struct
{
    uint8_t ringsLevel;
    uint8_t speedLevel;
    uint8_t offensiveLevel;
    uint8_t defensiveLevel;
}
PlayerParamLevel;

typedef struct
{
    float coolTime;
}
PlayerParamBarrierWall;

typedef struct
{
    float rates[5];
}
PlayerParamDamageRateLevel;

typedef struct
{
    PlayerParamDamageRateLevel diffculties[4];
}
PlayerParamDamageRate;

typedef struct
{
    PlayerParamAttack attack;
    PlayerParamWaterAct wateract;
    PlayerParamBaseJump basejump;
    PlayerParamBallMove ballmove;
    PlayerParamLocus locus;
    PlayerParamAuraTrain auratrain;
    PlayerParamLevel level;
    PlayerParamBarrierWall barrierWall;
    PlayerParamDamageRate damageRate;
}
CommonPackage;

typedef struct
{
    float longPressTime;
}
PlayerParamComboCommon;

enum ComboMoveType : uint8_t
{
    Homing = 0,
    Step = 1,
    None = 2
};

typedef struct
{
    ComboMoveType moveType;
    float moveInitialSpeed;
    float moveMaxSpeed;
    float moveAccele;
    float timeout;
}
PlayerParamComboMove;

typedef struct
{
    float moveSpeed;
    float rotateSpeed;
}
PlayerParamComboMoveCorrection;

enum Action : int8_t
{
    Root = 0,
    HomingAttack = 1,
    AerialHomingAttack = 2,
    Pursuit = 3,
    Stomping = 4,
    LoopKick = 5,
    Crasher = 6,
    SpinSlash = 7,
    SonicBoom = 8,
    CrossSlash = 9,
    HomingShot = 10,
    ChargeAttack = 11,
    QuickCyloop = 12,
    AerialQuickCyloop = 13,
    AcceleCombo1 = 14,
    AcceleCombo2 = 15,
    AcceleCombo3 = 16,
    AcceleCombo4 = 17,
    AerialAcceleCombo1 = 18,
    AerialAcceleCombo2 = 19,
    AerialAcceleCombo3 = 20,
    AerialAcceleCombo4 = 21,
    ComboFinish = 22,
    SpinJump = 23,
    Smash = 24,
    Behind = 25,
    Guarded = 26,
    Avoid = 27,
    AirBoost = 28,
    AfterAirBoost = 29,
    KnucklesPunch1 = 30,
    KnucklesPunch2 = 31,
    KnucklesUppercut = 32,
    KnucklesCyKnuckle = 33,
    KnucklesHeatKnuckle = 34,
    AmyTarotAttack = 35,
    AmyTarotRolling = 36,
    AmyCyHammer = 37,
    ActionNum = 38
};

typedef struct
{
    Action transitExistTarget[6];
    Action transitInAir[6];
    Action transitNotExistTarget[6];
}
PlayerParamComboTransit;

typedef struct
{
    PlayerParamComboTransit root;
    PlayerParamComboTransit homingAttack;
    PlayerParamComboTransit aerialHoming;
    PlayerParamComboTransit pursuit;
    PlayerParamComboTransit stomping;
    PlayerParamComboTransit loopKick;
    PlayerParamComboTransit crasher;
    PlayerParamComboTransit spinSlash;
    PlayerParamComboTransit sonicBoom;
    PlayerParamComboTransit crossSlash;
    PlayerParamComboTransit homingShot;
    PlayerParamComboTransit chargeAttack;
    PlayerParamComboTransit quickCyloop;
    PlayerParamComboTransit aerialQuickCyloop;
    PlayerParamComboTransit acceleCombo1;
    PlayerParamComboTransit acceleCombo2;
    PlayerParamComboTransit acceleCombo3;
    PlayerParamComboTransit acceleCombo4;
    PlayerParamComboTransit aerialAcceleCombo1;
    PlayerParamComboTransit aerialAcceleCombo2;
    PlayerParamComboTransit aerialAcceleCombo3;
    PlayerParamComboTransit aerialAcceleCombo4;
    PlayerParamComboTransit behind;
    PlayerParamComboTransit guarded;
    PlayerParamComboTransit avoid;
    PlayerParamComboTransit airBoost;
    PlayerParamComboTransit afterAirBoost;
    PlayerParamComboTransit knucklesPunch1;
    PlayerParamComboTransit knucklesPunch2;
    PlayerParamComboTransit knucklesUppercut;
    PlayerParamComboTransit knucklesCyKnuckle;
    PlayerParamComboTransit knucklesHeatKnuckle;
    PlayerParamComboTransit amyTarotAttack;
    PlayerParamComboTransit amyTarotRolling;
    PlayerParamComboTransit amyCyHammer;
}
PlayerParamComboTransitTable;

typedef struct
{
    PlayerParamComboCommon common;
    PlayerParamComboMove comboMoveSonic;
    PlayerParamComboMove comboMoveSupersonic;
    PlayerParamComboMoveCorrection comboMoveCorrection;
    PlayerParamComboTransitTable comboTable;
}
PlayerParamCombo;

enum Condition : int8_t
{
    Time = 0,
    Animation = 1
};

enum Shape : int8_t
{
    Sphere = 0,
    Cylinder = 1,
    Box = 2
};

typedef struct
{
    Condition condition;
    int8_t count;
    float spanTime;
    Shape shape;
    csl::math::Vector3 shapeSize;
    csl::math::Vector3 shapeOffset;
}
PlayerParamAttackCollider;

typedef struct
{
    PlayerParamAttackCollider hit;
    float motionScale;
    float motionSpeedRate;
}
KnucklesParamComboPunch1;

typedef struct
{
    PlayerParamAttackCollider hit;
    float motionScale;
    float motionSpeedRate;
}
KnucklesParamComboPunch2;

typedef struct
{
    PlayerParamAttackCollider hit;
    float motionScale;
    float motionSpeedRate;
}
KnucklesParamComboUppercut;

typedef struct
{
    CommonPackage commonPackage;
    PlayerParamCombo combo;
    KnucklesParamComboPunch1 comboPunch1;
    KnucklesParamComboPunch2 comboPunch2;
    KnucklesParamComboUppercut comboUppercut;
}
CommonPackageKnuckles;

enum SupportedPlane : int8_t
{
    Flat = 0,
    Slope = 1,
    Wall = 2
};

typedef struct
{
    float movableMaxSlope;
    float activeLandingSlope;
    float activeLandingSlopeInBoost;
    float landingMaxSlope;
    float slidingMaxSlope;
    float wallAngleMaxSlope;
    SupportedPlane onStand;
    SupportedPlane onRunInAir;
    SupportedPlane onRun;
    bool moveHolding;
    bool wallSlideSlowInBoost;
    bool attrWallOnGround;
    float priorityInputTime;
    int32_t capacityRings;
    int32_t capacityRingsLvMax;
    float collectRingRange;
}
PlayerParamCommon;

typedef struct
{
    float initial;
    float min;
    float max;
    float minTurn;
}
PlayerParamSpeedData;

typedef struct
{
    float force;
    float force2;
    float damperRange;
    float jerkMin;
    float jerkMax;
}
PlayerParamSpeedAcceleData;

typedef struct
{
    float force;
    float damperRange;
    float jerkMin;
    float jerkMax;
}
PlayerParamSpeedAcceleData2;

typedef struct
{
    PlayerParamSpeedData normal;
    PlayerParamSpeedData normal2;
    PlayerParamSpeedData boost;
    PlayerParamSpeedData boost2;
    PlayerParamSpeedData boostLvMax;
    PlayerParamSpeedData boostLvMax2;
    float maxSpeedOver;
    float opitonMaxSpeedLimitMin;
    float opitonMaxSpeedLimitMax;
    float thresholdStopSpeed;
    float maxFallSpeed;
    PlayerParamSpeedAcceleData accele;
    PlayerParamSpeedAcceleData decele;
    PlayerParamSpeedAcceleData2 deceleNeutralMin;
    PlayerParamSpeedAcceleData2 deceleNeutralMax;
    float acceleAuto;
    float deceleAuto;
    float turnDeceleAngleMin;
    float turnDeceleAngleMax;
    float maxGravityAccele;
    float maxGravityDecele;
    float deceleSquat;
    float acceleSensitive;
    float boostAnimSpeedInWater;
}
PlayerParamSpeed;

typedef struct
{
    float baseRotateForce;
    float baseRotateForce2;
    float baseRotateForceSpeed;
    float minRotateForce;
    float maxRotateForce;
    bool angleRotateForceDecayEnabled;
    float frontRotateRatio;
    float rotationForceDecaySpeed;
    float rotationForceDecayRate;
    float rotationForceDecayMax;
    float autorunRotateForce;
}
PlayerParamRotation;

typedef struct
{
    float walkSpeed;
    float sneakingSpeed;
    float animSpeedSneak;
    float animSpeedWalk;
    float animSpeedRun;
    float animSpeedBoost;
    float animLRBlendSampleTime;
    float animLRBlendAngleMin;
    float animLRBlendAngleMax;
    float animLRBlendSpeed;
    float animLRBlendSpeedToCenter;
    float minChangeWalkTime;
    float fallAnimationAngle;
}
PlayerParamRunning;

typedef struct
{
    float rotateSpeedMinFB;
    float rotateSpeedMaxFB;
    float rotateSpeedMinLR;
    float rotateSpeedMaxLR;
}
PlayerParamBalanceData;

typedef struct
{
    PlayerParamBalanceData standard;
    PlayerParamBalanceData loop;
}
PlayerParamBalance;

typedef struct
{
    float initialSpeedRatio;
    float maxSpeed;
    float forceLand;
    float forceAir;
    float endSpeed;
    float stopTime;
}
PlayerParamBrake;

typedef struct
{
    float thresholdSpeed;
    float thresholdAngle;
    float turnAfterSpeed;
    bool stopEdge;
}
PlayerParamTurn;

typedef struct
{
    float preActionTime;
    float longPressTime;
    float addForceTime;
    float force;
    float addForce;
    float forceMin;
    float gravitySize;
}
PlayerParamJump;

typedef struct
{
    float acceleForce;
    float deceleForce;
    float deceleNeutralForce;
    float deceleBackForce;
    float limitMin;
    float limitUpSpeed;
    float rotationForce;
    float rotationForceDecaySpeed;
    float rotationForceDecayRate;
    float rotationForceDecayMax;
    float baseAirDragScaleMin;
    float baseAirDragScaleMax;
}
PlayerParamJumpSpeed;

typedef struct
{
    float initialSpeed;
    float bounceSpeed;
    float limitSpeedMin;
}
PlayerParamDoubleJump;

typedef struct
{
    float thresholdVertSpeed;
    float tolerateJumpTime;
    float fallEndDelayTime;
    float fallEndFadeTime;
    float acceleForce;
    float deceleForce;
    float overSpeedDeceleForce;
    float rotationForce;
    float rotationForceDecaySpeed;
    float rotationForceDecayRate;
    float rotationForceDecayMax;
}
PlayerParamFall;

typedef struct
{
    float invincibleTime;
}
PlayerParamDamageCommon;

typedef struct
{
    float initialHorzSpeed;
    float initialVertSpeed;
    float deceleForce;
    float transitFallTime;
    float gravityScale;
}
PlayerParamDamageNormal;

typedef struct
{
    float fixedTime;
}
PlayerParamDamageTurnBack;

typedef struct
{
    float initialHorzSpeed;
    float initialVertSpeed;
    float deceleForceInAir;
    float deceleForceOnGround;
    float gravityScale;
    float downTime;
    float transitTime;
}
PlayerParamDamageBlowOff;

typedef struct
{
    float vertSpeed;
    float horzSpeed;
    float deceleForce;
    float transitTime;
}
PlayerParamDamageGuarded;

typedef struct
{
    float actionTime;
    float minSpeed;
    float lossSpeed;
    float lossTime;
}
PlayerParamDamageRunning;

typedef struct
{
    float actionTime;
}
PlayerParamDamageQuake;

typedef struct
{
    csl::math::Vector3 jumpVelocity;
    float gravitySize;
    float invincibleTime;
    float noActionTime;
}
PlayerParamDamageLava;

typedef struct
{
    PlayerParamDamageCommon common;
    PlayerParamDamageNormal normal;
    PlayerParamDamageTurnBack turnBack;
    PlayerParamDamageBlowOff blowOff;
    PlayerParamDamageGuarded guarded;
    PlayerParamDamageGuarded guardedSS;
    PlayerParamDamageRunning running;
    PlayerParamDamageQuake quake;
    PlayerParamDamageLava lava;
}
PlayerParamDamage;

typedef struct
{
    float invincibleTime;
    float initialHorzSpeed;
    float initialVertSpeed;
}
PlayerParamDeadNormal;

typedef struct
{
    PlayerParamDeadNormal normal;
}
PlayerParamDead;

typedef struct
{
    float minSpeed;
    float endSpeed;
    float deceleJerk;
    float deceleJerkContinue;
    float deceleForceMax;
    float baseRotateForce;
    float baseRotateForceSpeed;
    float maxRotateForce;
    float frontRotateRatio;
    float rotationForceAutoRun;
    float movableMaxSlope;
    float gravitySize;
    float minContinueTime;
    float maxAutoRunTime;
    float endSpeedAutoRun;
    float loopKickTransitTime;
}
PlayerParamSliding;

typedef struct
{
    float initialSpeed;
    float initialAccele;
    float maxAccele;
    float jerk;
    float maxFallSpeed;
    float angle;
    float landingCancelTime;
    float boundStompingCollisionScale;
}
PlayerParamStomping;

typedef struct
{
    float maxSpeed;
    float maxBoostSpeed;
    float acceleForce;
    float deceleForce;
    float limitSpeedMin;
}
PlayerParamGrind;

typedef struct
{
    float initialSpeed;
    float maxSpeed;
    float brakeAngle;
    float highBrakeAngle;
    float brakeForce;
    float brakeForceHigh;
    float gravitySize;
    float gravitySizeAir;
    float endSpeedFront;
    float endSpeedBack;
    float reverseFallTime;
    float fallToSlipTime;
    float slipIdlingTime;
    float minSlipTime;
}
PlayerParamFallSlope;

typedef struct
{
    float thresholdSpeed;
    float maxSpeed;
    float flipAngle;
}
PlayerParamFallFlip;

typedef struct
{
    bool enabled;
    float sideSpinAngle;
    float initialVertSpeed;
    float gravitySize;
    float gravitySize2;
    float deceleForceInAir;
    float minSpeedInAir;
    float rotateEaseTimeLeftRight;
    float rotateEaseTimeFrontBack;
    float rotateSpeedMinLeftRight;
    float rotateSpeedMaxLeftRight;
    float rotateSpeedMinFrontBack;
    float rotateSpeedMaxFrontBack;
    float angleLeftRightStagger;
    float angleLeftRightRoll;
    float angleFrontBackRoll;
    float angleBigRoll;
    float inRunTime;
    float inAirTime;
    float rollSpeedFront;
    float bigRollVelocityRatio;
    float dropDashHoldTime;
    float airBrakeVertSpeed;
    float airBrakeForce;
    float airTrickHeight;
    float airTrickTime;
}
PlayerParamTumble;

typedef struct
{
    float jumpForce;
    float jumpAddForce;
    float addTime;
    float acceleForce;
    float deceleForce;
    float brakeForce;
    float limitSpeedMin;
    float limitSpeedMax;
}
PlayerParamSpinAttack;

typedef struct
{
    float speed;
}
PlayerParamHomingAttackData;

typedef struct
{
    float bounceVertSpeed;
    float bounceHorzSpeed;
    float bounceAcceleForce;
    float bounceDeceleForce;
    float bounceAngleWidth;
    float bounceTime;
    float attackDownTime;
    float attackDownTimeForStomp;
}
PlayerParamHomingBounceData;

typedef struct
{
    PlayerParamHomingAttackData sonic;
    PlayerParamHomingAttackData supersonic;
    PlayerParamHomingBounceData sonicBounce;
    PlayerParamHomingBounceData sonicBounceWeak;
    PlayerParamHomingBounceData sonicBounceStorm;
    PlayerParamHomingBounceData sonicBounceStormSwirl;
    PlayerParamHomingBounceData supersonicBounce;
    float cameraEaseInTime;
    float cameraEaseOutTime;
}
PlayerParamHomingAttack;

typedef struct
{
    float bounceVertSpeed;
    float bounceHorzSpeed;
    float attackDownTime;
    float enableHomingTime;
}
PlayerParamHitEnemy;

typedef struct
{
    float maxVertSpeed;
    float acceleVertForce;
    float maxHorzSpeed;
    float acceleHorzForce;
}
SpeedParam;

typedef struct
{
    SpeedParam normal;
    SpeedParam fast;
    SpeedParam damaged;
    SpeedParam ringdash;
    float startHeight;
    float startSpeed;
    float deceleVertForce;
    float deceleHorzForce;
    float deceleNeutralForce;
    float damageTime;
    float ringdashTime;
}
PlayerParamDiving;

typedef struct
{
    float damperV;
    float damperH;
    float accelRate;
    float moveForceFV;
    float moveForceSV;
    float jumpCheckSpeed;
}
PlayerParamFan;

typedef struct
{
    float jumpSpeed;
    float backSpeed;
    float downAccel;
    float damperV;
    float damperH;
    float time;
}
PlayerParamBackflip;

typedef struct
{
    float startSpeed;
    float maxSpeed;
    float accel;
    float brake;
    float damageSpeed;
    float damageBrake;
    float steeringSpeed;
    float endSteeringSpeed;
}
PlayerParamSlowMove;

typedef struct
{
    float startSlopeAngle;
    float endSlopeAngle;
    float startSpeed;
    float endSpeed;
    float stickAngle;
    float brake;
    float forceBrake;
    float maxSpeed;
}
PlayerParamSpin;

typedef struct
{
    float maxSpeed;
    float walkSpeed;
    float walkSpeedMax;
    float runSpeed;
    float runSpeedMax;
    float walkSpeedOnMesh;
    float walkSpeedOnMeshMax;
    float runSpeedOnMesh;
    float runSpeedOnMeshMax;
    float minAccessSpeed;
    float stickSpeed;
    float gravity;
    float accel;
    float brake;
    float stopBrake;
    float fallSpeed;
    float steeringSpeed1;
    float steeringSpeed2;
    float startSteeringSpeed;
    float endSteeringSpeed;
    float startTime;
    float useEnergySpeedBase;
    float useEnergySpeedBaseOnMesh;
    float useEnergySpeedVal;
    float useEnergySpeedValOnMesh;
    float useEnergyAngle;
    float useEnergyAngleOnMesh;
    float brakeStartEnergy;
    float brakeStartEnergyOnMesh;
    float homingSearchDistanceNear;
    float homingSearchDistanceFar;
    float wallBumpHeightUpper;
    float wallBumpHeightUnder;
    float recoveryCheckTime;
}
PlayerParamWallMove;

typedef struct
{
    float gravitySize;
    float minTime;
    float maxTime;
    float stopTime;
    float maxDownSpeed;
    float fallGroundDistance;
    float frontForce;
    float upForce;
    float impulseTime;
}
PlayerParamWallJump;

typedef struct
{
    float stepSpeedFront;
    float stepSpeedFrontDash;
    float stepSpeedSide;
    float stepSpeedSideDash;
    float stepSpeedBack;
    float stepDashRate;
    float maxAnimSpeed;
    float exhaustAngle;
    float exhaustAngleOnMesh;
    float exhaustBase;
    float exhaustBaseOnMesh;
    float exhaustRate;
    float exhaustRateOnMesh;
    float useGrabGaugeSpeed;
    float useGrabGaugeSpeedOnMesh;
    float useGrabGaugeTurbo;
    float useGrabGaugeTurboOnMesh;
    float homingSearchDistanceNear;
    float homingSearchDistanceFar;
    float resetAngle;
    float recoveryCheckTime;
}
PlayerParamClimbing;

typedef struct
{
    float time;
    float speed;
    float speedOnMesh;
    float accel;
    float brake;
    float brakeOnMesh;
}
PlayerParamSlideDown;

typedef struct
{
    float consumptionRate;
    float consumptionRateSS;
    float recoveryRate;
    float recoveryRateSS;
    float reigniteRatio;
    float recoveryByRing;
    float recoveryByAttack;
    float blurPowers[3];
    float blurEaseInTime;
    float blurEaseOutTime;
    float endSpeed;
    float powerBoostCoolTime;
    float infinityBoostTime;
}
PlayerParamBoost;

typedef struct
{
    float startHSpeed;
    float startHSpeedMax;
    float startVSpeed;
    float minHSpeed;
    float minHSpeedMax;
    float brakeTime;
    float minKeepTime;
    float maxKeepTime;
    float maxTime;
    float gravityRate;
    float steeringSpeed;
    float additionalTransitTime;
    float supersonicTime;
}
PlayerParamAirBoost;

typedef struct
{
    float initialSideSpeed;
    float acceleSideForce;
    float deceleSideForce;
    float maxSideSpeed;
}
PlayerParamAutorun;

typedef struct
{
    float speed;
    float brakeForce;
    float motionSpeedRatio;
    float stepSpeed;
    float maxStepDistance;
    float minStepDistance;
    float maxStepSpeed;
    float minStepSpeed;
}
PlayerParamSideStep;

typedef struct
{
    float speed;
    float brakeForce;
    float motionSpeedRatio;
    float stepSpeed;
    float maxStepDistance;
    float minStepDistance;
    float maxStepSpeed;
    float minStepSpeed;
}
PlayerParamSideStep2;

typedef struct
{
    float needSpeed;
    float acceleForce;
    float acceleSideForce;
    float stepInitialSpeed;
    float avoidForce;
    float justBoostForce;
    float justBoostMax;
    float justBoostTime;
    float justBoostBrake;
}
PlayerParamQuickStep;

typedef struct
{
    float minRecieveTime;
    float maxRecieveTime;
    float frozenTime;
    float justEffectEasein;
    float justEffectEaseout;
    float justEffectTime;
    float justEffectEasein2;
    float justEffectEaseout2;
    float justEffectTime2;
}
PlayerParamParry;

typedef struct
{
    float speed;
    float damper;
    float parryTime;
    float invincibleTime;
}
PlayerParamAvoidData;

typedef struct
{
    float time;
    float fixedTime;
    float reentryInputPriorityTime;
    float reentryTime;
    float frontAngle;
    float backAngle;
    float addFallSpeed;
    PlayerParamAvoidData data[7];
    float baseDistance;
    float limitAngle;
}
PlayerParamAvoid;

typedef struct
{
    PlayerParamCommon common;
    PlayerParamSpeed speed;
    PlayerParamRotation rotation;
    PlayerParamRunning running;
    PlayerParamBalance balance;
    PlayerParamBrake brake;
    PlayerParamTurn turn;
    PlayerParamJump jump;
    PlayerParamJumpSpeed jumpSpeed;
    PlayerParamDoubleJump doubleJump;
    PlayerParamFall fall;
    PlayerParamDamage damage;
    PlayerParamDead dead;
    PlayerParamSliding sliding;
    PlayerParamStomping stomping;
    PlayerParamGrind grind;
    PlayerParamFallSlope fallSlope;
    PlayerParamFallFlip fallFlip;
    PlayerParamTumble tumble;
    PlayerParamSpinAttack spinAttack;
    PlayerParamHomingAttack homingAttack;
    PlayerParamHitEnemy hitEnemy;
    PlayerParamDiving diving;
    PlayerParamFan fan;
    PlayerParamBackflip backflip;
    PlayerParamSlowMove slowmove;
    PlayerParamSpin spin;
    PlayerParamWallMove wallmove;
    PlayerParamWallJump walljump;
    PlayerParamClimbing climbing;
    PlayerParamSlideDown slidedown;
    PlayerParamBoost boost;
    PlayerParamAirBoost airboost;
    PlayerParamAutorun autorun;
    PlayerParamSideStep sidestep;
    PlayerParamSideStep2 sidestep2;
    PlayerParamQuickStep quickstep;
    PlayerParamParry parry;
    PlayerParamAvoid avoid;
}
ModePackage;

typedef struct
{
    float azimuthSensitivity;
    float elevationOffset;
}
KnucklesParamGlidingCamera;

typedef struct
{
    float minSpeed;
    float minSpeedRingMax;
    float fallSpeed;
    float fallAccel;
    float maxSteerSpeed;
    float rollSpeed;
    float neutralRollSpeed;
    float yawSpeed;
    float maxRollAngle;
    float height;
    float startHeight;
    bool restartable;
    KnucklesParamGlidingCamera camera;
}
KnucklesParamGliding;

typedef struct
{
    float findRadius;
    uint32_t numNotifies;
    float activeRadius;
    float findDistanceStomp;
    float findRadiusStomp;
}
KnucklesParamCyKnuckle;

typedef struct
{
    float diveScale;
    float speed;
    float stompingAttackScale;
    bool alsoStomping;
}
KnucklesParamCyKnuckleDig;

typedef struct
{
    float appearWaitTime;
}
KnucklesParamCyKnuckleWarp;

typedef struct
{
    float appearWaitTime;
}
KnucklesParamCyKnucklePopupItem;

typedef struct
{
    float appearWaitTime;
    uint32_t ringWeight;
    uint32_t superRingWeight;
    uint32_t skillPieceWeight;
    uint32_t numRings;
    uint32_t numSuperRings;
    uint32_t numSkillPieces;
    uint32_t skillPieceExp;
}
KnucklesParamCyKnuckleAppearGimmick;

typedef struct
{
    float lockonLevelUpSpanTime[5];
    float lockonSearchDistance;
    float lockonSearchDistanceFar;
    float speed;
    float followSpeed;
    float followTime;
    cstring hitStopObject;
}
KnucklesParamMaximumHeatKnuckle;

typedef struct
{
    float prepareTime;
}
KnucklesParamDrillBoost;

typedef struct
{
    float initialSpeed;
    float maxSpeed;
    PlayerParamSpeedAcceleData accele;
    PlayerParamSpeedAcceleData decele;
    float baseRotateForce;
    float minTurnSpeed;
    float turnDeceleAngleMin;
    float turnDeceleAngleMax;
}
PlayerParamSpinBoostSpeed;

enum AirAccelMode : int8_t
{
    Alawys = 0,
    AirAccelMode_None = 1,
    Speed = 2
};

typedef struct
{
    float forceRunTime;
    float initialRunTime;
    PlayerParamSpinBoostSpeed speedBall;
    PlayerParamSpinBoostSpeed speedBoost;
    PlayerParamSpeedAcceleData2 deceleNeutralMin;
    PlayerParamSpeedAcceleData2 deceleNeutralMax;
    float gravitySize;
    float gravityBeginTime;
    float gravityMaxTime;
    float gravitySizeMinInAir;
    float gravitySizeMaxInAir;
    float maxGravityAccele;
    float maxGravityDecele;
    float inAirTime;
    float spinBoostEndSpeed;
    float jumpOutAngle;
    float jumpOutSpeed;
    bool humpJumpOut;
    AirAccelMode airAccelMode;
    float airAccelVertSpeedThreshold;
    float chargeRotateForce;
    float chargeRotateForceMinAngle;
    float chargeRotateForceMaxAngle;
    cstring cameraShakeName;
}
PlayerParamSpinBoost;

typedef struct
{
    ModePackage modePackage;
    KnucklesParamGliding gliding;
    KnucklesParamCyKnuckle cyknuckle;
    KnucklesParamCyKnuckleDig cyknuckleDig;
    KnucklesParamCyKnuckleWarp cyknuckleWarp;
    KnucklesParamCyKnucklePopupItem cyknucklePopupItem;
    KnucklesParamCyKnuckleAppearGimmick cyknuckleAppearGimmick;
    KnucklesParamMaximumHeatKnuckle maximumHeatKnuckle;
    KnucklesParamDrillBoost drillBoost;
    PlayerParamSpinBoost spinBoost;
}
ModePackageKnuckles;

typedef struct
{
    PlayerParamSpeed speed;
    PlayerParamJump jump;
    PlayerParamJumpSpeed jumpSpeed;
    PlayerParamDoubleJump doubleJump;
    PlayerParamBoost boost;
    PlayerParamAirBoost airboost;
}
WaterModePackage;

typedef struct
{
    CommonPackageKnuckles common;
    ModePackageKnuckles forwardView;
    WaterModePackage water;
}
KnucklesParameters;

