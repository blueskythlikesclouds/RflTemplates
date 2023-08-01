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

enum ActionType : int8_t
{
    ActionType_AT_NONE = 0,
    AT_HAND_L = 1,
    AT_HAND_R = 2,
    AT_SHOT1 = 3,
    AT_SHOT2 = 4,
    AT_SHOT3 = 5,
    AT_SHOT4 = 6,
    AT_QTE_NONE = 7,
    AT_WAIT = 8,
    AT_LASER = 9,
    AT_HOMINGLASER_NORMAL = 10,
    AT_HOMINGLASER_FLY = 11,
    AT_BIT_WAVE = 12,
    AT_BIT_WAVE_END = 13,
    AT_COUNTER_BLOW = 14,
    AT_SP01 = 15,
    AT_SP02 = 16,
    NUM_ACTION_TYPE = 17
};

typedef struct
{
    ActionType attackType;
    cstring waveName;
    cstring subWaveName;
    float actionTime;
    int16_t nextStep;
    bool isBitActionReset;
    bool isFlyMoveReverse;
    bool isFlyWait;
}
BossRifleAttackData;

typedef struct
{
    BossRifleAttackData attackDatas[16];
    BossRifleAttackData bitBreakAttackDatas[2];
    uint32_t breakBitNum;
}
BossRifleAttackPatternParam;

typedef struct
{
    float attackWaitTime;
    float attackSpeedRatio;
    uint32_t knockbackCountMax;
    BossRifleAttackPatternParam patterns[4];
    float patternChangeHpRatios[4];
}
BossRiflePhaseParam;

enum ActionAttribute : int8_t
{
    AA_NONE = 0,
    AA_ALL = 1,
    AA_FRONT = 2,
    AA_BACK = 3,
    AA_LEFT = 4,
    AA_RIGHT = 5
};

typedef struct
{
    ActionAttribute attribute1;
    ActionAttribute attribute2;
    float useDistanceMin;
    float useDistanceMax;
    float useHeightMin;
    float useHeightMax;
    float useAngleMin;
    float useAngleMax;
    float useAbsAngleOver;
    float useHpRatioMin;
    float useHpRatioMax;
    float useAreaOver;
    uint32_t priority;
    float coolTime;
    float initCoolTime;
    float readyTime;
    uint32_t consecutiveUsesLimit;
    float consecutiveUsesLimitCoolTime;
    bool isCounterUse;
    bool isCounterOnly;
}
BossRiflePhaseAttackActionParam;

enum BossRifleBattleParam_ActionType : int8_t
{
    BossRifleBattleParam_ActionType_AT_NONE = 0,
    BossRifleBattleParam_ActionType_AT_HAND_L = 1,
    BossRifleBattleParam_ActionType_AT_HAND_R = 2,
    BossRifleBattleParam_ActionType_AT_SHOT1 = 3,
    BossRifleBattleParam_ActionType_AT_SHOT2 = 4,
    BossRifleBattleParam_ActionType_AT_SHOT3 = 5,
    BossRifleBattleParam_ActionType_AT_SHOT4 = 6,
    BossRifleBattleParam_ActionType_AT_QTE_NONE = 7,
    BossRifleBattleParam_ActionType_AT_WAIT = 8,
    BossRifleBattleParam_ActionType_AT_LASER = 9,
    BossRifleBattleParam_ActionType_AT_HOMINGLASER_NORMAL = 10,
    BossRifleBattleParam_ActionType_AT_HOMINGLASER_FLY = 11,
    BossRifleBattleParam_ActionType_AT_BIT_WAVE = 12,
    BossRifleBattleParam_ActionType_AT_BIT_WAVE_END = 13,
    BossRifleBattleParam_ActionType_AT_COUNTER_BLOW = 14,
    BossRifleBattleParam_ActionType_AT_SP01 = 15,
    BossRifleBattleParam_ActionType_AT_SP02 = 16,
    BossRifleBattleParam_ActionType_NUM_ACTION_TYPE = 17
};

typedef struct
{
    float landingCounterHPRatio;
    float floatCounterHPRatio;
}
BossRifleCyloopFloatActionParam;

typedef struct
{
    bool isParry;
    bool isUse;
    float shotDirElevation;
    float shotDirRoll;
}
BossRifleBattleAttackHomingLaserShotPoint;

typedef struct
{
    cstring nodeName;
    csl::math::Vector3 nodePos;
    csl::math::Vector3 nodeFront;
    csl::math::Vector3 nodeAxis;
    float straightKeepTime;
    uint32_t parryMax;
    uint32_t num;
    uint32_t countMax;
    float initSpeed;
    float speed;
    float acceleDelay;
    float acceleTime;
    float interval;
    float intervals[8];
    float delay;
    BossRifleBattleAttackHomingLaserShotPoint points[32];
    csl::math::Vector3 fixedCameraEyePos;
    csl::math::Vector3 fixedCameraLookAtPos;
    float fixedCameraDelay;
    float fixedCameraTime;
    float fixedCameraStartEaseTime;
    float fixedCameraEndEaseTime;
    csl::math::Vector3 parryCameraEyePos;
    csl::math::Vector3 parryCameraLookAtPos;
    float parryCameraStartEaseTime;
    float parryCameraEndEaseTime;
    bool isParrySlow;
}
BossRifleBattleAttackHomingLaserAttackParam;

typedef struct
{
    float bulletScale;
    float parryMoveTime;
    BossRifleBattleAttackHomingLaserAttackParam headShotParam;
    BossRifleBattleAttackHomingLaserAttackParam headShotFlyParam;
    BossRifleBattleAttackHomingLaserAttackParam normalShotParam;
    bool isDebugDraw;
}
BossRifleBattleAttackHomingLaser;

typedef struct
{
    float intarvalDistance;
    float delay;
    csl::math::Vector3 localStartPos;
    csl::math::Vector3 localEndPos;
    csl::math::Vector3 localStartDir;
    csl::math::Vector3 localEndDir;
}
BossRifleBattleAttackHandLaserPatternParam;

typedef struct
{
    float bulletRadius;
    float bulletSpeed;
    float wayAngle;
    uint32_t wayNum;
    float limitDistance;
    float blowoffSpeed;
    float outOfControlTime;
    float keepVelocity;
    BossRifleBattleAttackHandLaserPatternParam handLeftPatterns[4];
    BossRifleBattleAttackHandLaserPatternParam handRightPatterns[4];
}
BossRifleBattleAttackHandLaser;

typedef struct
{
    float flyHeight;
    float flyRotationSpeed;
    float flyMoveHitDamageDownSpeedRatio;
    float flyMoveHitDamageDownSpeedTime;
    float flyMoveSpeed;
    float flyMoveCircleRadius;
}
BossRifleBattleFlyParam;

typedef struct
{
    float distance;
    float elevation;
    float playerHeight;
    float easeInTime;
    float easeOutTime;
    float changeParamDistanceMin;
    float changeParamDistanceMax;
    float addDistance;
    float addElevation;
    float addPlayerHeight;
}
BossRifleBattleZoomCamera;

typedef struct
{
    BossRifleBattleZoomCamera normalCamera[2];
    BossRifleBattleZoomCamera flyCamera[2];
}
BossRifleBattleCameraParam;

typedef struct
{
    float scale;
    float time;
    float easeOutTime;
    bool cameraSlow;
}
BossRifleParrySlowParam;

typedef struct
{
    BossRifleParrySlowParam homingLaserParrySlow;
    BossRifleParrySlowParam homingLaserLastParrySlow;
    BossRifleParrySlowParam homingLaserOneShotParrySlow;
}
BossRifleParryParam;

typedef struct
{
    BossRiflePhaseParam giantPhaseParams[4];
    BossRiflePhaseAttackActionParam actionParams[16];
    BossRifleBattleParam_ActionType immediateActions[20];
    BossRifleCyloopFloatActionParam cyloopFloatAction;
    BossRifleBattleAttackHomingLaser attackHomingLaser;
    BossRifleBattleAttackHandLaser attackHandLaser;
    BossRifleBattleFlyParam flyParam;
    BossRifleBattleCameraParam cameraParam;
    BossRifleParryParam parryParam;
    float thresholdDamageEffectHPRatio[3];
    float qteSucceedWaitTimes[4];
    bool isDebugDraw;
    bool isSkip;
}
BossRifleBattleParam;

typedef struct
{
    bool usePracticeNotifier;
    int8_t practiceNo;
    int8_t tipsNo;
}
EnemyPracticeNotifierConfig;

typedef struct
{
    EnemyPracticeNotifierConfig notifierConfigBattle1;
    EnemyPracticeNotifierConfig notifierConfigBattle2;
}
BossRifleNotifierParam;

typedef struct
{
    BossBaseConfig bossBaseConfig;
    BossRifleBattleParam battleParam;
    BossRifleNotifierParam notifierParam;
}
BossRifleConfig;

