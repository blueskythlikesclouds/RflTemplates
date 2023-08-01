#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    uint32_t rankTime[4];
    uint32_t rankTimeAll[4];
}
BattleRushPhaseRankParameter;

enum BgmType : int8_t
{
    INVALID = -1,
    ENEMY_BATTLE = 0,
    FORCE_BATTLE_FIELD = 1,
    MINIBOSS_CHARGER_BATTLE = 2,
    MINIBOSS_DARUMA_BATTLE = 3,
    MINIBOSS_SPIDER_BATTLE = 4,
    MINIBOSS_BLADE_BATTLE = 5,
    MINIBOSS_FLYER_BATTLE = 6,
    MINIBOSS_TRACKER_BATTLE = 7,
    MINIBOSS_ASHURA_BATTLE = 8,
    MINIBOSS_SKIER_BATTLE = 9,
    MINIBOSS_SUMO_BATTLE = 10,
    MINIBOSS_TYRANT_BATTLE = 11,
    MINIBOSS_STRIDER_BATTLE = 12,
    MINIBOSS_WARSHIP_BATTLE = 13,
    ENEMY_AQUABALL = 14,
    TUTORIAL_BLADE_BATTLE = 15
};

typedef struct
{
    uint32_t numPhases;
    float phaseLimitTime[11];
    float phaseClearedTime[11];
    float phaseResultTime[11];
    BattleRushPhaseRankParameter phaseRank[11];
    BgmType phaseBgmType[11];
    uint32_t hour;
    uint32_t minute;
}
BattleRushStageParameter;

typedef struct
{
    BattleRushStageParameter stages[4];
    float viewPaseResultTime;
}
BattleRushParameter;

