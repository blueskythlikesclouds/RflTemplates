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
    float scale;
}
LaserTargetConfig;

typedef struct
{
    bool useHpBorder;
    float hpBorder;
    bool useWaveId;
    uint8_t waveId;
    float delayTime;
    cstring voice;
}
SerifConfig;

typedef struct
{
    bool usePracticeNotifier;
    int8_t practiceNo;
    int8_t tipsNo;
}
EnemyPracticeNotifierConfig;

typedef struct
{
    uint8_t waveId;
    EnemyPracticeNotifierConfig practiceNotifierConfig;
}
NotifierConfig;

typedef struct
{
    float borderLifeRatio;
    float sonicDamageRatio;
}
UIConfig;

typedef struct
{
    BossBaseConfig bossBaseConfig;
    LaserTargetConfig target;
    SerifConfig serifConfigs[26];
    NotifierConfig notifierConfigStart;
    NotifierConfig notifierConfigLaser;
    UIConfig uiConfig;
}
BossTheEndConfig;

