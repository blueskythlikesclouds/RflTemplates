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
    cstring name;
    cstring parentFrame;
    csl::math::Vector3 size;
    csl::math::Vector3 localPosition;
    csl::math::Vector3 localRotation;
}
BossDragonCollisionParamBase;

typedef struct
{
    BossDragonCollisionParamBase bossDragonCollisionParamBase;
    csl::math::Vector3 damageVelocity;
}
BossDragonHitBoxParam;

typedef struct
{
    BossDragonCollisionParamBase bossDragonCollisionParamBase;
    bool isEnableHoming;
    cstring homingNode;
    cstring homingNodeMirror;
    csl::math::Vector3 homingPosition;
}
BossDragonHurtBoxParam;

typedef struct
{
    float aimTime;
    float stunTime;
}
BossDragonScratchParam;

typedef struct
{
    float radius;
    float speed;
    float maxSpeed;
    float accel;
    float reflectSpeedScale;
    float intervalTime;
    float lifeTime;
    float pitchOffsetRange;
    float yawOffsetRange;
    bool isBound;
}
BossDragonReflectShotParam;

typedef struct
{
    float radius;
    float speed;
    float intervalTime;
    float lifeTime;
    float pitchOffsetRange;
    float yawOffsetRange;
    int32_t count;
    float waitTime;
}
BossDragonShotParam;

typedef struct
{
    float radius;
    float speed;
    float intervalTime;
    float lifeTime;
    float pitchSpeed;
    float yawSpeed;
    float circleIntervalTime;
    int32_t count;
    int32_t parriableCount;
    float waitTime;
}
BossDragonSpiralShotParam;

typedef struct
{
    float radius;
    float speed;
    float gravity;
    float intervalTime;
    float lifeTime;
    float pitch;
    float pitchInterval;
    float yawInterval;
    int32_t count;
    int32_t parriableCount;
    float waitTime;
}
BossDragonSplashShotParam;

typedef struct
{
    float radius;
    float speed;
    float maxAccel;
    float intervalTime;
    float arrivalTime;
    float lifeTime;
    float minPitchOffset;
    float maxPitchOffset;
    float yawOffsetRange;
    int32_t count;
    float waitTime;
}
BossDragonHomingLaserParam;

typedef struct
{
    float radius;
    float length;
    float speed;
    float intervalTime;
    float lifeTime;
    float minPitchOffset;
    float maxPitchOffset;
    float yawOffsetRange;
    int32_t count;
    float waitTime;
}
BossDragonHomingMissileParam;

typedef struct
{
    float innerRadius;
    float outerRadius;
    float speed;
    float intervalTime;
    float lifeTime;
    float pitchOffsetRange;
    float yawOffsetRange;
    int32_t count;
    int32_t parriableCount;
    float intervalTimeInGroup;
    int32_t countInGroup;
    float waitTime;
}
BossDragonRippleLaserParam;

typedef struct
{
    float innerRadius;
    float outerRadius;
    float speed;
    float intervalTime;
    float lifeTime;
    float maxPitch;
    float maxYaw;
    int32_t verticalCount;
    int32_t horizontalCount;
    int32_t extraFrontCount;
    int32_t parriableCount;
    float intervalTimeInGroup;
    int32_t countInGroup;
    float waitTime;
}
BossDragonRippleLaserRageParam;

typedef struct
{
    float innerRadius;
    float outerRadius;
    float speed;
    float intervalTime;
    float lifeTime;
    float pitchOffsetRange;
    float yawOffsetRange;
    int32_t count;
    float intervalTimeInGroup;
    int32_t countInGroup;
}
BossDragonRippleLaserDummyParam;

typedef struct
{
    float speed;
    float rotSpeed;
    float accel;
    float rotAccel;
    float intervalTime;
    float lifeTime;
    int32_t segmentCount;
    float waveRate;
    int32_t count;
    float waitTime;
}
BossDragonWaveParam;

typedef struct
{
    float radius;
    float length;
    float rotSpeed;
    float rotAccel;
    float roll;
    float intervalTime;
    float standbyTime;
    int32_t count;
    float waitTime;
}
BossDragonLaserParam;

typedef struct
{
    float radius;
    float speed;
    float lifeTime;
}
BossDragonCounterLaserParam;

typedef struct
{
    int32_t missileNum;
    float missileWaitTime;
}
BossDragonRingSupplyMissileParam;

typedef struct
{
    csl::math::Vector3 playerPosition;
    float moveTime;
    float moveRange;
    float rotSpeed;
    BossDragonRingSupplyMissileParam missile[3];
}
BossDragonRingSupplyParam;

enum BossDragonLayoutParam_EaseType : int8_t
{
    SMOOTH = 0,
    EASE_IN = 1,
    EASE_OUT = 2,
    EASE_IN_OUT = 3
};

typedef struct
{
    csl::math::Vector3 bossPosition;
    float bossYaw;
    BossDragonLayoutParam_EaseType bossEaseType;
    float bossEaseTime;
    csl::math::Vector3 playerPosition;
    float playerFieldRange;
    float playerFieldHeight;
    float playerFieldYaw;
    BossDragonLayoutParam_EaseType playerEaseType;
    float playerEaseTime;
}
BossDragonLayoutParam;

typedef struct
{
    cstring gazeFrame;
    cstring gazeFrameMirror;
    csl::math::Vector3 gazeOffset;
    float distance;
    csl::math::Vector3 playerOffset;
    float elevationOffset;
    csl::math::Vector3 followRate;
}
BossDragonCameraParam;

typedef struct
{
    csl::math::Vector3 playerNodes[8];
    csl::math::Vector3 bossNodes[8];
    int32_t playerNodeCount;
    int32_t bossNodeCount;
    float time;
}
BossDragonMoveParam;

typedef struct
{
    float radius;
    float length;
    float rotSpeed;
}
BossDragonFireBarParam;

typedef struct
{
    uint32_t vertRatio[3];
    float initSpeed;
    float maxSpeed;
    float acc;
    float lifeTime;
}
BossDragonEscapeShotParam;

enum Type : int8_t
{
    None = 0,
    FireBar = 1,
    FireBar4 = 2,
    Spark = 3
};

enum Location : int8_t
{
    Left = 0,
    Center = 1,
    Right = 2
};

typedef struct
{
    float distance;
    Type type;
    Location location;
}
BossDragonObstacleParam;

typedef struct
{
    float start;
    float end;
}
BossDragonHoleParam;

typedef struct
{
    float interval;
    int32_t recordNum;
    float width;
    BossDragonFireBarParam fireBar;
    BossDragonEscapeShotParam shot;
    BossDragonObstacleParam obstacles[64];
    BossDragonHoleParam holes[16];
}
BossDragonRoadParam;

typedef struct
{
    float outStrength;
    float inStrength;
    float outElev;
    float inElev;
    float speed;
    csl::math::Vector3 targetOffset;
    float launchCameraInterpolateTime;
    csl::math::Vector3 launchCameraPos;
    csl::math::Vector3 launchCameraTarget;
    float launchCameraRoll;
    float launchCameraTime;
    float fallCameraInterpolateTime;
    float fallCameraDistance;
    float fallCameraElavation;
    float landingCameraInterpolateTime;
    float landingCameraDistance;
    float landingCameraElavation;
    float landingCameraAzimuth;
    float landingCameraChangeDistance;
    float landingCameraNearInterpolateTime;
    float landingCameraNearDistance;
    float landingCameraNearElavation;
    float landingCameraNearAzimuth;
}
BossDragonLaunchParam;

typedef struct
{
    float speed;
    float boostSpeed;
    float boostSpeedMax;
}
BossDragonQuickStepParam;

typedef struct
{
    float distance;
    float goalOffset;
    float speed;
    float boostSpeed;
    float width;
    float height;
    float closeDistance;
    float closeSpeedScale;
    float fastMoveDistance;
    float stunTime;
    float stunSpeedScale;
    float superBoostDelayTime;
    float superBoostTime;
    float superBoostSpeed;
}
BossDragonChaseParam;

typedef struct
{
    bool isValid;
    float rotForce;
    float maxRotForce;
    float rotForceSpeed;
    float rotDamper;
    float straightTime;
}
BossDragonMissileIndividualParam;

typedef struct
{
    float hpRatioThreshold;
    int32_t count;
    float intervalTime;
    float waitTime;
    float badRatio;
}
BossDragonMissileFirePattern;

typedef struct
{
    float radius;
    float length;
    float speed;
    float maxSpeed;
    float accel;
    float lifeTime;
    BossDragonMissileIndividualParam individuals[16];
    BossDragonMissileIndividualParam badIndividuals[8];
    BossDragonMissileFirePattern firePatterns[8];
}
BossDragonMissileParam;

enum BossDragonSequence : int8_t
{
    NOP = 0,
    BITE = 1,
    LIGHT_SCRATCH = 2,
    SCRATCH = 3,
    SHOOT = 4,
    SHOOT_NORMAL = 5,
    SHOOT_SPIRAL = 6,
    SHOOT_SPIRAL_ALTERNATE = 7,
    SHOOT_SPIRAL_VERTICAL = 8,
    SHOOT_SPLASH = 9,
    SHOOT_HOMING_LASER = 10,
    SHOOT_HOMING_MISSILE = 11,
    SHOOT_RIPPLE_LASER = 12,
    SHOOT_RIPPLE_LASER_RAGE = 13,
    SHOOT_WAVE = 14,
    SHOOT_LASER_WINDER = 15,
    SHOOT_RANDOM_LASER = 16,
    SHOOT_END = 17,
    SWAP_SIDE = 18,
    CHASE = 19
};

enum BossDragonInterrupt : int8_t
{
    BossDragonInterrupt_NOP = 0,
    RAGE = 1,
    SPECIAL_ATTACK = 2,
    SPECIAL_ATTACK2 = 3
};

typedef struct
{
    float hpRatio;
    BossDragonInterrupt interrupt;
    bool forceInterrupt;
}
BossDragonInterruptParam;

typedef struct
{
    float postCameraTime[4];
}
BossDragonCyloopBindParam;

typedef struct
{
    float scale;
    float time;
    float easeOutTime;
    bool cameraSlow;
}
BossDragonParrySlowParam;

typedef struct
{
    BossDragonParrySlowParam slowParams[2];
}
BossDragonParryParam;

typedef struct
{
    float delayTime[6];
}
BossDragonAttackSignParam;

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
    EnemyPracticeNotifierConfig notifierConfigBattle;
}
BossDragonNotifierParam;

typedef struct
{
    BossBaseConfig bossBaseConfig;
    float cruisePathSpeed;
    float patrolPathSpeed;
    float approachPathSpeedMin;
    float approachPathSpeedMax;
    float climbPathSpeed;
    float pathSpeed;
    float ringSupplyPathSpeed;
    float sideDistance;
    float shootEndTime;
    int32_t staggerPoint;
    int32_t staggerPointRage;
    float staggerTime;
    float biteParriedTime;
    float scratchParriedTime;
    int32_t knockBackStaggerCount;
    int32_t knockBackPoint;
    float knockBackTime;
    float hardStunTime;
    float cyloopBindTime;
    float cyloopBind2Time;
    float cyloopEscapeHpRatio;
    float cyloopEscapeTime;
    float fallDeadHeight;
    int32_t specialAttackDamage;
    int32_t qte1Damage;
    cstring accessNodeNames[16];
    BossDragonHitBoxParam hitBoxes[32];
    BossDragonHurtBoxParam hurtBoxes[32];
    BossDragonScratchParam scratch;
    BossDragonReflectShotParam reflect;
    BossDragonShotParam shot;
    BossDragonSpiralShotParam spiral;
    BossDragonSpiralShotParam spiralAlternate;
    BossDragonSpiralShotParam spiralVertical;
    BossDragonSplashShotParam splash;
    BossDragonHomingLaserParam homingLaser;
    BossDragonHomingMissileParam homingMissile;
    BossDragonRippleLaserParam rippleLaser;
    BossDragonRippleLaserRageParam rippleLaserRage;
    BossDragonRippleLaserDummyParam rippleLaserDummy;
    BossDragonWaveParam wave;
    BossDragonLaserParam laserWinder;
    BossDragonLaserParam randomLaser;
    BossDragonCounterLaserParam counterLaser;
    BossDragonRingSupplyParam ringSupply;
    float damageRates[4];
    BossDragonLayoutParam layouts[46];
    BossDragonCameraParam cameras[47];
    BossDragonMoveParam swapMove;
    BossDragonRoadParam road;
    BossDragonLaunchParam launch;
    BossDragonQuickStepParam quickStep;
    BossDragonChaseParam chase;
    BossDragonMissileParam missile;
    BossDragonSequence seq[16];
    BossDragonSequence seq2[16];
    BossDragonInterruptParam interrupts[8];
    BossDragonCyloopBindParam cyloopBind;
    BossDragonParryParam parry[4];
    BossDragonAttackSignParam attackSign;
    BossDragonNotifierParam notifier;
}
BossDragonConfig;

