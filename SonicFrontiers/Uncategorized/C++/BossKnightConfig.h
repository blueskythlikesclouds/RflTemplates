#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    uint8_t guid[16];
}
csetobjectid;

typedef struct
{
    const char* pValue;
    INSERT_PADDING(8);
}
cstring;

typedef struct
{
    array initPositions;
    cstring heightTargetNodeName;
    float heightMoveSpeed;
    float bossToPlayerDistanceMin;
    float bossToPlayerDistanceMax;
    float offsetHeightMin;
    float offsetHeightMax;
    float areaDistanceMin;
    float areaDistanceMax;
    float playerSpawnDistance;
    float playerRespawnDistance;
    float playerRespawnDistance2;
}
PlayerMoveableRangeParam;

typedef struct
{
    bool isUse;
    bool isUsePillar;
    float phaseChangeHpRatio;
}
BossPhaseParam;

enum EaseType : int8_t
{
    ET_Sin = 0,
    ET_Cubic = 1,
    ET_Quadratic = 2
};

typedef struct
{
    float easeTime;
    EaseType easeType;
    cstring mainLookAtNodeName;
    csl::math::Vector3 mainLookOffsetPos;
    cstring subLookAtNodeName;
    csl::math::Vector3 subLookOffsetPos;
    float distance;
    csl::math::Vector3 playerOffsetPos;
}
BossLockOnCameraParam;

typedef struct
{
    uint32_t healthPoint;
    float stunTime;
    float maxStunPoint[3];
    float maxStaggerPoint[5];
    uint16_t exp;
    PlayerMoveableRangeParam moveRangeParam;
    PlayerMoveableRangeParam cyloopDamageMoveRangeParam;
    BossPhaseParam phaseParams[8];
    BossLockOnCameraParam cameraParam;
    bool isDebugDraw;
    uint32_t debugDrawPhaseIndex;
}
BossStatusConfig;

enum GimmickType : int8_t
{
    GT_A = 0,
    GT_B = 1,
    GT_C = 2,
    GT_D = 3,
    GT_E = 4,
    NUM_GIMMICK_TYPE = 5
};

enum AttackType : int8_t
{
    AT_A = 0,
    AT_B = 1,
    AT_C = 2,
    AT_D = 3,
    AT_E = 4,
    NUM_ATTACK_TYPE = 5
};

enum BossPillarParam_GimmickType : int8_t
{
    BossPillarParam_GimmickType_GT_A = 0,
    BossPillarParam_GimmickType_GT_B = 1,
    BossPillarParam_GimmickType_GT_C = 2,
    BossPillarParam_GimmickType_GT_D = 3,
    BossPillarParam_GimmickType_GT_E = 4,
    BossPillarParam_GimmickType_NUM_GIMMICK_TYPE = 5
};

enum BossPillarParam_AttackType : int8_t
{
    BossPillarParam_AttackType_AT_A = 0,
    BossPillarParam_AttackType_AT_B = 1,
    BossPillarParam_AttackType_AT_C = 2,
    BossPillarParam_AttackType_AT_D = 3,
    BossPillarParam_AttackType_AT_E = 4,
    BossPillarParam_AttackType_NUM_ATTACK_TYPE = 5
};

typedef struct
{
    bool isUse;
    float gimmickPhaseTime;
    float attackPhaseTime;
    bool isUnique;
    BossPillarParam_GimmickType gimmickType;
    float gimmickIntervalTime;
    BossPillarParam_AttackType attackType;
    float attackIntervalTime;
}
BossPillarParam;

typedef struct
{
    GimmickType gimmickTypeAll;
    float gimmickIntervalTimeAll;
    AttackType attackTypeAll;
    float attackIntervalTimeAll;
    BossPillarParam pillars[32];
    cstring spawnPositionName;
    uint32_t pillarHealthPoint;
    uint32_t pillarBreakDamage;
    float pillarBreakStun;
    bool isDebugDraw;
    uint32_t DebugDrawType;
}
BossPillarConfig;

enum CollisionType : int8_t
{
    CT_SPHERE = 0,
    CT_CAPSULE = 1,
    CT_CYLINDER = 2,
    CT_BOX = 3,
    NUM_COLLISION_TYPE = 4
};

enum ColliderActiveType : int8_t
{
    Always = 0,
    OnContactActive = 1,
    OnContactInactive = 2,
    OnMotionActive = 3,
    OnMotionInactive = 4,
    Manual = 5,
    NUM_COLLIDER_ACTIVE_TYPE = 6
};

enum ColliderProperty : int16_t
{
    CpNone = 0,
    CpBattleUse = 1,
    CpBattleUnuse = 2,
    CpRestPoint = 3,
    CpHomingTarget = 4,
    CpPerceive = 5,
    CpDamage = 6,
    CpAttack = 7,
    CpContactActive = 8,
    CpContactInactive = 9,
    CpMotionActive = 10,
    CpMotionInactive = 11,
    CpManual = 12,
    CpUpperSide = 13,
    CpLowerSide = 14,
    CpFrontSide = 15,
    CpBackSide = 16,
    CpLeftSide = 17,
    CpRightSide = 18,
    CpPointA = 19,
    CpPointB = 20,
    CpPointC = 21,
    CpPointD = 22,
    CpCyloopDownUnuse = 23,
    CpDummyDamage = 24,
    NUM_COLLIDER_PROPERTY = 25
};

typedef struct
{
    ColliderActiveType type;
    ColliderProperty propertys[4];
    cstring text;
}
BossColliderStatus;

typedef struct
{
    bool isUse;
    int16_t priority;
    CollisionType type;
    cstring attachNodeName;
    cstring name;
    BossColliderStatus status;
    csl::math::Vector3 size;
    csl::math::Vector3 offset;
    csl::math::Vector3 rotation;
}
BossPerceiveCollisionParam;

typedef struct
{
    BossPerceiveCollisionParam perceiveCollisions[64];
    bool isDebugDraw;
}
BossPerceivePartsWithCollisionConfig;

enum PointType : int8_t
{
    PT_HOMINGPOINT = 0,
    PT_HEROSAGE = 1,
    PT_MINIONGENERATOR = 2,
    PT_TRIGGER = 3,
    PT_ANCHOR = 4,
    PT_DAMAGEPOINT = 5,
    PT_STICK = 6,
    PT_DAMAGEEFFECT = 7,
    PT_DASHCIRCLE = 8,
    NUM_POINT_TYPE = 9
};

typedef struct
{
    BossColliderStatus status;
    float distance;
    float nextSearchDistance;
}
BossHomingPointParam;

typedef struct
{
    uint32_t num;
    float interval;
    float liveTime;
    float waitTime;
}
BossMinionParam;

enum Shape : int8_t
{
    SHAPE_BOX = 0,
    SHAPE_SPHERE = 1,
    SHAPE_CYLINDER = 2,
    SHAPE_CAPSULE = 3
};

typedef struct
{
    Shape ShapeType;
    float CollisionWidth;
    float CollisionHeight;
    float CollisionDepth;
}
BossTrigerParam;

typedef struct
{
    float phaseTime;
}
BossStickParam;

typedef struct
{
    bool isCyloopDownUnuse;
    cstring text;
}
BossDamagePointParam;

typedef struct
{
    int32_t focusGeometryIndex;
    int32_t focusTriangleIndex;
    float sizeScale;
    float impulseSpeed;
    float ocTime;
    float slowRateBoss;
    float slowRatePlayer;
    float slowTime;
    float slowEaseInTime;
    float slowEaseOutTime;
}
BossDashCirclPointParam;

typedef struct
{
    bool isUse;
    uint32_t geometryIndex;
    uint32_t triangleIndex;
    PointType type;
    BossHomingPointParam homingPoint;
    BossMinionParam minionParam;
    BossTrigerParam trigger;
    BossStickParam stickParam;
    BossDamagePointParam damagePoint;
    BossDashCirclPointParam dashCirclPoint;
    int32_t linkNums[5];
    csl::math::Vector3 offsetPos;
    csl::math::Vector3 offsetRot;
}
BossMeshFrameParam;

typedef struct
{
    BossMeshFrameParam meshShapeKeyFrames[256];
    bool isDebugDraw;
    bool isDebugDrawPoint;
    bool isDebugDrawMesh;
    bool isDebugDrawMeshIndivid;
    float debugDrawMeshTriangleDistance;
    uint32_t debugDrawMeshTriangleNum;
}
BossMeshFrameConfig;

enum BossAttackCollisionParam_AttackType : int8_t
{
    AT_NONE = 0,
    AT_BLOWOFF = 1,
    AT_SLAMDOWNWARD = 2,
    AT_KILLING = 3,
    AT_NOTPARRY = 4,
    AT_NOTDAMAGE = 5,
    BossAttackCollisionParam_AttackType_NUM_ATTACK_TYPE = 6
};

typedef struct
{
    bool isUse;
    cstring attachNodeName;
    float damageVelocityRaito;
    BossAttackCollisionParam_AttackType types[4];
    BossColliderStatus status;
    float size;
    csl::math::Vector3 offset;
    cstring parryCounterTargetCollisionName;
}
BossAttackCollisionParam;

typedef struct
{
    BossAttackCollisionParam attackCollisions[64];
    bool isDebugDraw;
}
BossAttackCollisionConfig;

typedef struct
{
    bool isUse;
    cstring attachNodeName;
    cstring name;
    float size;
    csl::math::Vector3 offset;
    csl::math::Vector3 rotation;
    bool isParryActive;
    float cyloopRadius;
    bool onlyRigidBody;
}
BossBattlePhaseCollisionParam;

typedef struct
{
    BossBattlePhaseCollisionParam battleCollisions[16];
    bool isDebugDraw;
}
BossBattlePhaseCollisionConfig;

typedef struct
{
    uint32_t ringNumQuickCyloopUp;
    uint32_t ringNumQuickCyloopDown;
    uint32_t ringNumSonicSpecial;
    float ringSpawnDistance;
    float ringSuckedVelocity;
}
BossDropRingConfig;

typedef struct
{
    BossStatusConfig status;
    BossPillarConfig pillar;
    BossPerceivePartsWithCollisionConfig perceivPartsWithCollision;
    BossMeshFrameConfig meshShapeKeyFrame;
    BossAttackCollisionConfig attackCollision;
    BossBattlePhaseCollisionConfig battleCollision;
    BossDropRingConfig dropRing;
}
BossBaseConfig;

typedef struct
{
    float runSpeed;
}
KnightIdleConfig;

typedef struct
{
    float moveIntervalAfterSlam;
    float moveIntervalAfterMove;
    float moveIntervalAfterFall;
}
KnightClimbIdleConfig;

typedef struct
{
    float speedAvg;
    float angle1Min;
    float angle1Max;
    float angle2Min;
    float angle2Max;
    float move2WaitDuration;
}
KnightClimbMoveConfig;

typedef struct
{
    float duration;
    float lockonDistance;
    float unlockDistance;
    float distance;
    float minElevation;
    float maxElevation;
    float panningSuspensionK;
    float interiorPanningSuspensionK;
}
KnightClimbSlamLookupCameraConfig;

typedef struct
{
    float interval;
    uint32_t generateNum;
    float coolTime;
    float radius;
    float appearRadius;
    float keepRadius;
    float disappearRadius;
    float heightMin;
    float heightMax;
    float lifeTime;
    float modelScale;
    float modelDiameter;
    float effectDistance;
}
KnightClimbSlamWaveConfig;

typedef struct
{
    float rotateSpeedBeforeSlam;
    float slamAnimSpeed;
    float waitTimeAfterSlam;
    float liftUpStartAnimSpeed;
    float liftUpEndAnimSpeed;
    float liftUpStartAnimSpeedMiss;
    float liftUpEndAnimSpeedMiss;
    KnightClimbSlamLookupCameraConfig lookupCam;
    KnightClimbSlamWaveConfig wave;
}
KnightClimbSlamConfig;

enum PlayerOffsetType : int8_t
{
    PLAYER_OFFSET_NORMAL = 0,
    PLAYER_OFFSET_ABSOLUTE = 1
};

typedef struct
{
    float fovy;
    float zRot;
    float distance;
    float pathOffset;
    bool usePathVerticalComponent;
    bool usePathNormal;
    float angleSensitivity;
    float angleSensitivityBoost;
    float azimuthOffsetDeg;
    float elevationOffsetDeg;
    float gravityOffset;
    csl::math::Vector3 playerOffset;
    PlayerOffsetType playerOffsetType;
}
KnightGrindCameraConfig;

typedef struct
{
    int32_t damage;
    bool blowOff;
}
KnightGrindTrapConfig;

typedef struct
{
    csl::math::Vector3 lookAtOffset;
    csl::math::Vector3 eyeOffset;
    float duration;
    float easeTimeBegin;
    float easeTimeEnd;
}
KnightGrindLaunchCameraConfig;

typedef struct
{
    float outStrength;
    float inStrength;
    float outElev;
    float inElev;
    float speed;
    cstring landFrameName;
    csl::math::Vector3 landOffset;
    csl::math::Vector3 landRayOffset;
    csl::math::Vector3 landOffsetAfterRaycast;
    KnightGrindLaunchCameraConfig camera;
}
KnightGrindLaunchConfig;

typedef struct
{
    KnightGrindCameraConfig camera;
    float playerSpeed;
    KnightGrindTrapConfig trap;
    KnightGrindLaunchConfig launch;
}
KnightClimbGrindConfig;

typedef struct
{
    float traceSpeed;
    float traceRotSpeed;
    float traceLifeTime;
    float traceWidth;
    float traceHeight;
    float traceAppearDistance;
    float traceKeepDistance;
    float traceDisappearDistance;
    float traceModelScale;
    float traceModelDiameter;
    float traceModelInterval;
    float traceCollisionDistance;
}
KnightClimbTraceWaveConfig;

typedef struct
{
    KnightClimbIdleConfig idle;
    KnightClimbMoveConfig move;
    KnightClimbSlamConfig slam;
    KnightClimbGrindConfig grind;
    float climbTimeLimit;
    KnightClimbTraceWaveConfig trace;
}
KnightClimbConfig;

typedef struct
{
    float moveInterval;
}
KnightBattle1IdleConfig;

typedef struct
{
    float speedAvg;
    float angle1Min;
    float angle1Max;
    float angle2Min;
    float angle2Max;
    float move2WaitDuration;
}
KnightBattle1MoveConfig;

typedef struct
{
    float guardStaggerMax;
    float damageStaggerMax;
}
KnightBattle1GuardConfig;

typedef struct
{
    float startDistance;
    float startXOffset;
    float startYOffset;
    float startAngle;
    float speed;
    float turnAcc;
    float turnSpeedMax;
    float areaRadius;
    float windPowerMin;
    float windPowerMax;
    float windTimeMin;
    float windTimeMax;
    float windInterval;
    float camRideElevation;
    float camRideDistance;
    csl::math::Vector3 camRideOffset;
    float camCompeteElevation;
    float camCompeteAzimuth;
    float camCompeteDistance;
    float camHitElevation;
    float camHitAzimuth;
    float camHitDistance;
    float camShakeHitLoopMagnitude;
    int32_t camShakeHitLoopFreq;
    float camShakeRejectLoopMagnitude;
    int32_t camShakeRejectLoopFreq;
    uint8_t missileNum;
    float missileInterval;
    float missileStartTime;
    float missileSpeed;
    float missileRotateSpeed;
    float missileMidPosDistance;
    float missileMidPosHeightOffset;
    float missileShotAngle;
    float missileShotStartWait;
    float missileRiseSpeed;
    float missileRiseTime;
    float missileHideTime;
    float missileAppearDistance;
    float missileAppearHeight;
    float missileAppearWidth;
    float missileLifeTime;
    float missileLifeTimeNoHit;
    float missileHitPower;
    float missileHitPowerRateDown;
    float missileHitPowerKeepTime;
    float missileHeightShakeMax;
    float missileHeightShakeMin;
    float missileWidthShake;
    float rejectCompeteDuration;
    float hitShaveDamageSum;
    uint32_t hitShaveHitNum;
    float hitShaveHitInterval;
    float damageRatio;
    float staggerValue;
    float knockbackDistance;
    float durationAfterHit;
    uint32_t missileHitPattern[10];
}
KnightShieldRideConfig;

typedef struct
{
    float parriedDuration;
    float slowRate;
    float slowTime;
    float cameraOffset;
    float cameraFade;
}
KnightBattle1InterruptConfig;

typedef struct
{
    float height;
    float riseDuration;
    float floatDuration;
    float fallDuration;
    float cyFallDuration;
    float cyFallDelay;
    float downDuration;
    float enableDownCounterHPRatio;
    float enableGuardHPRatio;
}
KnightBattle1CyFloat;

typedef struct
{
    float hpRatio;
    int32_t missileNum;
    float missileWaitTime;
}
KnightThresholdRingSupplyParam;

typedef struct
{
    float interpolateTimeBegin;
    float interpolateTimeEnd;
}
KnightRageShieldAttackCameraConfig;

typedef struct
{
    float modelScale;
    float hitEffectScale;
    float actionGuideOffsetX;
    float actionGuideOffsetY;
    float heightOffset;
    float flySpeed;
    float flyLineWidth;
    float flyLineAfterHitWallLength;
    float flyLineDuration;
    float hitWallTargetingStart;
    float hitWallTargetingAdd;
    float hitWallTargetingSub;
    float hitWallTargeting;
    uint8_t hitWallTargetingCycle;
    float hitWallTargetAreaRadius;
    float hitWallStopDuration;
    float hitWallFlySpeed;
    float hitWallAccStartTime;
    float hitWallAccDuration;
    float parryTargetRange;
    float parryTargetAngVel;
    float parryTargetTimeLimit;
    float parryTargetLineWidth;
    float parryTargetLineLength;
    float parryFlySpeedStart;
    float parryFlySpeed;
    float parryAccStartTime;
    float parryAccDuration;
    float parryFlyLineWidth;
    float parryFlyLineDuration;
    float parryFlySuspendDuration;
    float parryFlySuspendEndDistance;
    KnightRageShieldAttackCameraConfig attackCamera;
    float damageRatio;
    float damageVelocity;
}
KnightRageShieldConfig;

typedef struct
{
    float azimuth;
    float elevation;
    float distance;
    float zRoll;
    float fovy;
    csl::math::Vector3 offset;
    float followPlayerRatio;
    float lookCenterRatio;
    float interpolateTimeBegin;
    float interpolateTimeEnd;
    float controlAngAcc;
    float controlAngVel;
}
KnightRageOverlookCameraConfig;

typedef struct
{
    KnightRageShieldConfig shield;
    KnightRageOverlookCameraConfig normalCamera;
    KnightRageOverlookCameraConfig targetingCamera;
    float moveRestartAnimSpeed;
}
KnightBattle1Rage;

typedef struct
{
    float downTime;
    float downCutChangeTime[2];
    csl::math::Vector3 downCamOffset;
    float riseTime;
    csl::math::Vector3 riseCamOffset;
}
KnightAerialCamera;

typedef struct
{
    float closedAreaRadius;
    KnightBattle1IdleConfig idle;
    KnightBattle1MoveConfig move;
    KnightBattle1GuardConfig guard;
    KnightShieldRideConfig shieldRide;
    KnightBattle1InterruptConfig interrupt;
    float normalKnockbackDistance;
    KnightBattle1CyFloat cyFloat;
    KnightThresholdRingSupplyParam ringSupply[3];
    KnightBattle1Rage rage;
    float rageHPRatio;
    float atkSpecialHPRatio;
    KnightAerialCamera aerialCamera;
    float damageEventTime;
}
KnightBattle1Config;

typedef struct
{
    float azimuth;
    float elevation;
    float distance;
    float zRoll;
    float fovy;
    csl::math::Vector3 frameOffset;
}
KnightBattle2RunCamera;

typedef struct
{
    float speed;
    float moveWidth;
    float moveHeight;
    csl::math::Vector3 playerOffset;
    csl::math::Vector3 playerOffsetFar;
    csl::math::Vector3 playerOffsetNear;
    csl::math::Vector3 playerOffsetTackle;
    float attackInterval;
    float attackIntervalDelayOnHit;
    KnightBattle2RunCamera camera;
}
KnightBattle2RunConfig;

enum XType : uint8_t
{
    Zero = 0,
    HitPosX = 1,
    Indivisual = 2
};

typedef struct
{
    bool enable;
    XType xType;
    float xIndivisual;
    float y;
    float z;
}
KnightBattle2ShieldSplineNode;

typedef struct
{
    float duration;
    float interpolateTimeBegin;
    float interpolateTimeEnd;
}
KnightBattle2ShieldUTurnCameraConfig;

typedef struct
{
    KnightBattle2ShieldSplineNode nodesStraight[8];
    float stopPosRatioStraight;
    float stopDecStartPosRatioStraight;
    float stopAccEndPosRatioStraight;
    float stopDurationStraight;
    float speedStraight1;
    float speedStraight2;
    float hitPosXStraight;
    float uTurnEndPosStraight;
    float swordDelayStraight;
    KnightBattle2ShieldSplineNode nodesSlalom[8];
    float stopPosRatioSlalom;
    float stopDecStartPosRatioSlalom;
    float stopAccEndPosRatioSlalom;
    float stopDurationSlalom;
    float speedSlalom1;
    float speedSlalom2;
    float hitPosXSlalom;
    float uTurnEndPosSlalom;
    float magnitudeSlalomFar;
    float magnitudeSlalomNear;
    uint8_t slalomNumMin;
    uint8_t slalomNumMax;
    float slalomEndPosRatio;
    float swordDelaySlalom;
    float uTurnSpeedRatioDuringCam;
    float uTurnSpeedRatioAfterCam;
    KnightBattle2ShieldUTurnCameraConfig uTurnCamera;
    float attackLineWidth;
}
KnightBattle2ShieldConfig;

typedef struct
{
    float parriedDuration;
    float animSpeedOnDoubleAtkParried;
}
KnightBattle2SwordConfig;

typedef struct
{
    float parriedDuration;
}
KnightBattle2InterruptConfig;

typedef struct
{
    float height;
    float riseDuration;
    float floatDuration;
    float fallDuration;
    float cyFallDuration;
    float cyFallDelay;
    float downDuration;
    float enableDownCounterHPRatio;
    float enableGuardHPRatio;
}
KnightBattle2CyFloat;

typedef struct
{
    KnightBattle2RunConfig run;
    KnightBattle2ShieldConfig shield;
    KnightBattle2SwordConfig sword;
    KnightBattle2InterruptConfig interrupt;
    float knockbackDistance;
    KnightBattle2CyFloat cyFloat;
    KnightAerialCamera aerialCamera;
}
KnightBattle2Config;

typedef struct
{
    float damageRatio;
}
KnightSonicSpecialConfig;

typedef struct
{
    csl::math::Vector3 upOffset[8];
    csl::math::Vector3 upRotationAngle[8];
    float upMoveDistanceOffset;
    csl::math::Vector3 downOffset;
    float downMoveDelay;
    float downMoveDistance[3];
    float downMoveDuration[3];
}
KnightCyFloatSpearConfig;

typedef struct
{
    float delayTime[6];
}
KnightAttackSignParam;

typedef struct
{
    bool usePracticeNotifier;
    int8_t practiceNo;
    int8_t tipsNo;
}
EnemyPracticeNotifierConfig;

typedef struct
{
    EnemyPracticeNotifierConfig notifierConfigClimb;
    EnemyPracticeNotifierConfig notifierConfigBattle1;
    EnemyPracticeNotifierConfig notifierConfigBattle2;
}
BossKnightNotifierParam;

typedef struct
{
    BossBaseConfig bossBaseConfig;
    KnightIdleConfig idle;
    KnightClimbConfig climb;
    KnightBattle1Config battle1;
    KnightBattle2Config battle2;
    KnightSonicSpecialConfig sonicSpecial;
    KnightCyFloatSpearConfig cyFloatSpear;
    uint8_t knockbackStaggerCount;
    float thresholdDamageEffectHPRatio[3];
    KnightAttackSignParam attackSign;
    BossKnightNotifierParam notifier;
}
BossKnightConfig;

