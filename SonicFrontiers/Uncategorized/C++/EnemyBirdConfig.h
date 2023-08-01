#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    csl::math::Vector3 backColliderExtents;
    csl::math::Vector3 backColliderOffset;
    csl::math::Vector3 backDamageColliderExtents;
    csl::math::Vector3 backDamageColliderOffset;
    csl::math::Vector3 chargeColliderExtents;
    csl::math::Vector3 chargeColliderOffset;
    float eyesightAngle;
    float eyesightDistance;
}
EnemyBirdCommonParam;

typedef struct
{
    int32_t maxHealthPoint;
    float attackRate;
    uint16_t expItemNum;
    uint16_t exp;
}
EnemyBirdCommonLevelParam;

typedef struct
{
    int32_t level;
    EnemyBirdCommonLevelParam common;
}
EnemyBirdLevelParam;

typedef struct
{
    int32_t level;
}
EnemyBirdLevelBand;

typedef struct
{
    float speedOnPath;
    float speedToPath;
    float eyesightDelayAfterBarAction;
}
BirdWanderParam;

typedef struct
{
    float speed;
    float maxSpeed;
    float acceleration;
    float rotateDegreeToSonic;
    float stopDistanceFromSonic;
    csl::math::Vector3 offsetFromSonic;
}
BirdApproachParam;

typedef struct
{
    float laserInterval;
    float rotateDegreeToSonic;
}
BirdLaserStateParam;

typedef struct
{
    float waitTime;
    float speed;
    float maxSpeed;
    float acceleration;
    csl::math::Vector3 offsetFromSonic;
    float duration;
    float distance;
    float minElevation;
    float maxElevation;
    float panningSuspensionK;
    float interiorPanningSuspensionK;
}
BirdChargeParam;

typedef struct
{
    float speed;
    float maxSpeed;
    float acceleration;
    float backupTime;
}
BirdBackupParam;

typedef struct
{
    float haWaitTime;
    float degreeOnPath;
    float speedOnPath;
    float speedToPath;
    float splineTension;
    float splineSpeed;
    csl::math::Vector3 velocityOnFail;
}
BirdBarParam;

typedef struct
{
    float moveSpeed;
    float gidingVelocityY;
    float limitTime;
    float rotateSpeed;
    float rotateSpeedMin;
    float rotateSpeedMax;
    float rotateSpeedMaxSpeedMin;
    float rotateSpeedMinSpeedMax;
    float heightOfChangeShake;
}
BirdGlidingParam;

typedef struct
{
    float minWaitTime;
    float maxWaitTime;
    float raycastDistance;
    float fallSpeedOnStomp;
    float maxFallSpeedOnStomp;
    float fallAccelerationOnStomp;
}
BirdDeadParam;

typedef struct
{
    float distanceFront;
    float distanceBack;
    float distanceDown;
}
BirdRaycastParam;

typedef struct
{
    float distToConsiderSonicAsOnBird;
    float distance;
}
BirdOnBackCameraParam;

typedef struct
{
    float azimuth;
    float elevation;
    float distance;
    float zRoll;
    float fovy;
    csl::math::Vector3 frameOffset;
}
BirdCameraParam;

typedef struct
{
    csl::math::Vector3 haColliderExtents;
    csl::math::Vector3 haColliderOffset;
    csl::math::Vector3 haTargetOffset;
    float haTargetRadius;
    float haTargetHeight;
    BirdWanderParam wanderParam;
    BirdApproachParam approachParam;
    BirdLaserStateParam laserStateParam;
    BirdChargeParam chargeParam;
    BirdBackupParam backupParam;
    BirdBarParam barParam;
    BirdGlidingParam glidingParam;
    BirdDeadParam deadParam;
    BirdRaycastParam raycastParam;
    bool useCamera;
    BirdOnBackCameraParam onBackCameraParam;
    BirdCameraParam cameraParam;
}
EnemyBirdParam;

typedef struct
{
    EnemyBirdCommonParam commonParam;
    EnemyBirdLevelParam levelParams[5];
    EnemyBirdLevelBand levelBand[5];
    EnemyBirdParam birdParam;
}
EnemyBirdConfig;

