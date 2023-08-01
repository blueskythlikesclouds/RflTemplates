#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    uint32_t score;
    uint32_t level1Meter;
    uint32_t level2Meter;
    uint32_t level3Meter;
    uint32_t level4Meter;
    uint32_t level5Meter;
    uint32_t level6Meter;
    uint32_t level7Meter;
    uint32_t level8Meter;
    uint32_t level9Meter;
    float delay;
}
ActionChainScoreParameter;

typedef struct
{
    uint32_t level1Param;
    uint32_t level99Param;
}
ActionChainAttackLevelParameter;

typedef struct
{
    ActionChainAttackLevelParameter score;
    ActionChainAttackLevelParameter level1Meter;
    ActionChainAttackLevelParameter level2Meter;
    ActionChainAttackLevelParameter level3Meter;
    ActionChainAttackLevelParameter level4Meter;
    ActionChainAttackLevelParameter level5Meter;
    ActionChainAttackLevelParameter level6Meter;
    ActionChainAttackLevelParameter level7Meter;
    ActionChainAttackLevelParameter level8Meter;
    ActionChainAttackLevelParameter level9Meter;
}
ActionChainAttackScoreParameter;

typedef struct
{
    float intervalTime;
    uint32_t score;
    uint32_t level1Meter;
    uint32_t level2Meter;
    uint32_t level3Meter;
    uint32_t level4Meter;
    uint32_t level5Meter;
    uint32_t level6Meter;
    uint32_t level7Meter;
    uint32_t level8Meter;
    uint32_t level9Meter;
}
ActionChainIntervalScoreParameter;

typedef struct
{
    float intervalTime;
    float minSpeed;
    float maxSpeed;
    ActionChainAttackLevelParameter score;
    ActionChainAttackLevelParameter level1Meter;
    ActionChainAttackLevelParameter level2Meter;
    ActionChainAttackLevelParameter level3Meter;
    ActionChainAttackLevelParameter level4Meter;
    ActionChainAttackLevelParameter level5Meter;
    ActionChainAttackLevelParameter level6Meter;
    ActionChainAttackLevelParameter level7Meter;
    ActionChainAttackLevelParameter level8Meter;
    ActionChainAttackLevelParameter level9Meter;
}
ActionChainBoostScoreParameter;

typedef struct
{
    float intervalTime;
    float minSpeed;
    float maxSpeed;
    ActionChainAttackLevelParameter score;
    ActionChainAttackLevelParameter level1Meter;
    ActionChainAttackLevelParameter level2Meter;
    ActionChainAttackLevelParameter level3Meter;
    ActionChainAttackLevelParameter level4Meter;
    ActionChainAttackLevelParameter level5Meter;
    ActionChainAttackLevelParameter level6Meter;
    ActionChainAttackLevelParameter level7Meter;
    ActionChainAttackLevelParameter level8Meter;
    ActionChainAttackLevelParameter level9Meter;
    float minHeight;
    float maxHeight;
    float maxHeightMagnification;
}
ActionChainSpinBoostScoreParameter;

typedef struct
{
    ActionChainScoreParameter dashRollerScore;
    ActionChainScoreParameter dashPanelScore;
    ActionChainScoreParameter jumpBoardScore;
    ActionChainScoreParameter jumpSelecterScore;
    ActionChainScoreParameter poleScore;
    ActionChainScoreParameter selectCannonScore;
    ActionChainScoreParameter springScore;
    ActionChainScoreParameter wideSpringScore;
    ActionChainScoreParameter springClassicScore;
    ActionChainScoreParameter balloonScore;
    ActionChainScoreParameter upReelScore;
    ActionChainScoreParameter wallJumpScore;
    ActionChainScoreParameter propellerSpringScore;
    ActionChainScoreParameter springPoleScore;
    ActionChainScoreParameter dashRingScore;
    ActionChainAttackScoreParameter acceleCombo1Score;
    ActionChainAttackScoreParameter acceleCombo2Score;
    ActionChainAttackScoreParameter comboFinishScore;
    ActionChainAttackScoreParameter acceleRushCombo1Score;
    ActionChainAttackScoreParameter acceleRushCombo2Score;
    ActionChainAttackScoreParameter acceleRushComboFinishScore;
    ActionChainAttackScoreParameter chargeAttackScore;
    ActionChainAttackScoreParameter smashScore;
    ActionChainAttackScoreParameter recoverySmashScore;
    ActionChainAttackScoreParameter sonicBoomScore;
    ActionChainAttackScoreParameter crasherScore;
    ActionChainAttackScoreParameter loopKickScore;
    ActionChainAttackScoreParameter spinSlashScore;
    ActionChainAttackScoreParameter stompingAttackScore;
    ActionChainAttackScoreParameter homingShotScore;
    ActionChainAttackScoreParameter crossSlashScore;
    ActionChainScoreParameter ringScore;
    ActionChainScoreParameter gismoScore;
    ActionChainScoreParameter homingScore;
    ActionChainAttackScoreParameter enemyHomingScore;
    ActionChainScoreParameter airTrickScore;
    ActionChainScoreParameter chainBoosterScore;
    ActionChainScoreParameter parryScore;
    ActionChainAttackScoreParameter quickCyloopScore;
    ActionChainScoreParameter defeatEnemyScore;
    ActionChainScoreParameter defeatMiniBossScore;
    ActionChainAttackScoreParameter slingShotScore;
    ActionChainScoreParameter rippleLaserScore;
    ActionChainIntervalScoreParameter grindRailScore;
    ActionChainIntervalScoreParameter pulleyScore;
    ActionChainIntervalScoreParameter fanScore;
    ActionChainIntervalScoreParameter wallRunScore;
    ActionChainBoostScoreParameter boostScore;
    ActionChainIntervalScoreParameter powerBoostScore;
    ActionChainIntervalScoreParameter sandSkiScore;
    ActionChainIntervalScoreParameter acceleRailScore;
    ActionChainSpinBoostScoreParameter spinBoostScore;
}
ActionChainActionParameter;

typedef struct
{
    uint32_t meterMax;
    float meterDecreaseTime;
    uint32_t meterDecrease;
    float decreaseWaitTime;
    float decreasePercent;
    float decreaseWaitTimeAddMeter;
    float meterResetDelayTime;
}
ActionChainMeterParameter;

typedef struct
{
    ActionChainActionParameter actionParam;
    ActionChainMeterParameter level1MeterParam;
    ActionChainMeterParameter level2MeterParam;
    ActionChainMeterParameter level3MeterParam;
    ActionChainMeterParameter level4MeterParam;
    ActionChainMeterParameter level5MeterParam;
    ActionChainMeterParameter level6MeterParam;
    ActionChainMeterParameter level7MeterParam;
    ActionChainMeterParameter level8MeterParam;
    ActionChainMeterParameter level9MeterParam;
    float gimmickReuseTime;
    bool isChainBoosterLevelUp;
}
ActionChainParameter;

