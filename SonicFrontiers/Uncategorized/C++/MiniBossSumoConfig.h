#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    float scoutDistance;
    float scoutDistanceOutside;
    float zoomDistance;
    csl::math::Vector3 zoomOffset;
    csl::math::Vector3 zoomAngle;
    float zoomFov;
}
MiniBossCommonConfig;

typedef struct
{
    float mass;
    float slopeAngleMax;
    float timeStun;
    float timeExpend;
    float timeGuardBreak;
    float visualOffset;
    csl::math::Vector3 hpGaugeOffset;
    float guardEffectCoolTime;
}
MiniBossSumoBaseConfig;

typedef struct
{
    const char* pValue;
    INSERT_PADDING(8);
}
cstring;

enum ColliderProperty : uint32_t
{
    None = 0,
    Damaged = 1,
    DamageToPlayer = 2,
    Block = 4,
    DetectPuck = 8,
    Cyloop = 16,
    BlockBody = 32,
    SensorArm = 64,
    PressBlow = 128,
    PressBlowBody = 256,
    PressBlowArm = 512
};

typedef struct
{
    uint8_t alpha;
    uint8_t red;
    uint8_t green;
    uint8_t blue;
}
color8;

typedef struct
{
    bool enabled;
    float height;
    float radius;
    cstring attachNodeName;
    csl::math::Vector3 offset;
    csl::math::Vector3 rotation;
    cstring tag;
    ColliderProperty properties[2];
    bool debugDraw;
    color8 color;
}
MiniBossSumoColliderParam;

typedef struct
{
    MiniBossSumoColliderParam damaged[6];
    MiniBossSumoColliderParam damage[2];
    MiniBossSumoColliderParam detectPuck;
    MiniBossSumoColliderParam cyloop;
    MiniBossSumoColliderParam pressBlow[3];
    MiniBossSumoColliderParam sensorArm[2];
    MiniBossSumoColliderParam simpleBody;
    float moveRadius;
    float moveHeight;
    csl::math::Vector3 targetMarkerOffset;
    float comboRadiusMin;
    float comboRadiusMax;
    float comboHeight;
}
MiniBossSumoColliderConfig;

typedef struct
{
    float coolDownTimeToChangeElectric;
    float timeToWaitChangeAfterDamage;
    float blowOffSpeedDamagedElectricRope;
    float decelerationDamagedElectricRope;
    float timeElectricReaction;
    int32_t damageByReflectCount[5];
    float bendLengthOnHit;
    int32_t expansionBoundCount;
    float blowOffSpeedExpansionBoundRope;
    float decelerationExpansionBoundRope;
    float lockonPanningSuspensionKExpansionBoundRope;
    float reflectAngleMaxExpansionBoundRope;
}
MiniBossSumoRopeConfig;

typedef struct
{
    float backInitialSpeeds[5];
    float backDeccelation;
    float frontAngle;
    float timeTurn;
}
MiniBossSumoSlingShotConfig;

typedef struct
{
    float moveHorzLimitAngle;
    float moveRotateDeceleration;
}
MiniBossSumoMoveConfig;

typedef struct
{
    float distanceThrow;
    float coolTime;
    csl::math::Vector3 attachOffset;
    csl::math::Vector3 attachRotateL;
    csl::math::Vector3 attachRotateR;
    float throwAngleLimit;
    csl::math::Vector3 throwOffsetMulti;
}
MiniBossSumoThrowPuckParam;

typedef struct
{
    int32_t count;
    bool reflectBack;
    float reflectRagWidth;
}
MiniBossSumoSlingshotComboParam;

typedef struct
{
    csl::math::Vector3 kneeAxisLS;
    csl::math::Vector3 footEndLS;
    float footPlantedAnkleHeightMS;
    float footRaisedAnkleHeightMS;
    float maxAnkleHeightMS;
    float minAnkleHeightMS;
    float maxKneeAngleDegrees;
    float minKneeAngleDegrees;
    float onOffGain;
    float groundAscendingGain;
    float groundDescendingGain;
    float footPlantedGain;
    float footRaisedGain;
    float footLockingGain;
    float ankleRotationGain;
    cstring hipName;
    cstring kneeName;
    cstring ankleName;
    cstring toeName;
}
MiniBossSumoIKFootParam;

typedef struct
{
    csl::math::Vector3 elbowAxisLS;
    csl::math::Vector3 handOffsetLS;
    csl::math::Vector3 backHandNormalLS;
    float maxElbowAngleDegrees;
    float minElbowAngleDegrees;
    bool enforceWristRotation;
    cstring shoulderName;
    cstring elbowName;
    cstring wristName;
}
MiniBossSumoIKHandParam;

typedef struct
{
    float footRaycastDistanceUp;
    float footRaycastDistanceDown;
    MiniBossSumoIKFootParam feet[2];
    float handRaycastDistanceUp;
    float handRaycastDistanceDown;
    float handSweepRadius;
    float handGain;
    float easeInTimeHandIk;
    float easeOutTimeHandIk;
    MiniBossSumoIKHandParam hands[2];
}
MiniBossSumoIKParam;

typedef struct
{
    float puckSpeed;
    float puckTimeStartDecelerate;
    float puckDeceleration;
    float puckLifeTime;
}
MiniBossSumoCyloopConfig;

typedef struct
{
    float distance;
    float minElevation;
    float maxElevation;
    float elevationOffset;
}
MiniBossSumoLockonConfig;

typedef struct
{
    MiniBossCommonConfig common;
    MiniBossSumoBaseConfig base;
    MiniBossSumoColliderConfig collider;
    MiniBossSumoRopeConfig rope;
    MiniBossSumoSlingShotConfig slingShot;
    MiniBossSumoMoveConfig move;
    MiniBossSumoThrowPuckParam throwPuck;
    MiniBossSumoSlingshotComboParam combo;
    MiniBossSumoIKParam ik;
    MiniBossSumoCyloopConfig cyloop;
    MiniBossSumoLockonConfig lockon;
}
MiniBossSumoCommonParam;

typedef struct
{
    int32_t maxHealthPoint;
    float maxStunPoint[3];
    float stunDecreaseStartTime;
    float stunDecreaseSpeed;
    float maxStaggerPoint[3];
    float staggerDecreaseStartTime;
    float staggerDecreaseSpeed;
    float attackRate;
    uint16_t expItemNum;
    uint16_t exp;
}
MiniBossLevelCommonConfig;

typedef struct
{
    int32_t level;
    MiniBossLevelCommonConfig commonConfig;
}
MiniBossSumoLevelParam;

typedef struct
{
    int32_t puckCount;
    float speed;
    float lifeTime;
}
MiniBossSumoPuckParam;

typedef struct
{
    bool enabled;
    bool electriced[8];
}
MiniBossSumoElectricRopePattern;

typedef struct
{
    MiniBossSumoElectricRopePattern patterns[10];
}
MiniBossSumoRotationElectricRopeParam;

typedef struct
{
    int32_t rateHp;
    MiniBossSumoPuckParam puck;
    MiniBossSumoRotationElectricRopeParam rotation8;
    MiniBossSumoRotationElectricRopeParam rotation7;
    MiniBossSumoRotationElectricRopeParam rotation6;
    MiniBossSumoRotationElectricRopeParam rotation5;
    MiniBossSumoRotationElectricRopeParam rotation4;
}
MiniBossSumoBehaviorHPRateParam;

typedef struct
{
    int32_t level;
    MiniBossSumoBehaviorHPRateParam hpRateParams[3];
}
MiniBossSumoLevelBand;

typedef struct
{
    MiniBossSumoCommonParam commonParam;
    MiniBossSumoLevelParam levelParams[5];
    MiniBossSumoLevelBand levelBand[5];
}
MiniBossSumoConfig;

