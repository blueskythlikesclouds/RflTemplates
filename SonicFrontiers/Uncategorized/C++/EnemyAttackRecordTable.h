#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

typedef struct
{
    uint8_t no;
}
Record;

typedef struct
{
    const char* pValue;
    INSERT_PADDING(8);
}
cstring;

enum Kind : int8_t
{
    InvalidKind = -1,
    Dead_BattleJellymanLv1 = 0,
    Dead_BattleJellymanLv2 = 1,
    Dead_BattleJellymanLv3 = 2,
    Dead_BattleJellymanLv4 = 3,
    Dead_BattleWolf = 4,
    Dead_BattleBird = 5,
    Dead_BattleSniper = 6,
    Dead_BattleTwister = 7,
    Dead_BattleBommer = 8,
    Dead_BattleBubble = 9,
    Dead_BattleDefender = 10,
    Dead_BattleUmbrella = 11,
    Dead_BattleAquaBall = 12,
    Dead_BattleJumper = 13,
    Dead_BattleBladeLv1 = 14,
    Dead_BattleBladeLv2 = 15,
    Dead_BattleBladeLv3 = 16,
    Dead_BattleBladeLv4 = 17,
    Dead_BattleDarumaLv1 = 18,
    Dead_BattleDarumaLv2 = 19,
    Dead_BattleDarumaLv3 = 20,
    Dead_BattleDarumaLv4 = 21,
    Dead_BattleSpider = 22,
    Dead_BattleCharger = 23,
    Dead_BattleFlyer = 24,
    Dead_BattleTracker = 25,
    Dead_BattleAsura = 26,
    Dead_BattleSkier = 27,
    Dead_BattleTyrant = 28,
    Dead_BattleSumo = 29,
    Dead_BattleStrider = 30,
    Dead_BattleWarship = 31,
    Dead_BattleGiantFC = 32,
    Dead_BattleGiantClimb = 33,
    Dead_BattleGiant = 34,
    Dead_BattleDragonFC = 35,
    Dead_BattleDragonClimb = 36,
    Dead_BattleDragon = 37,
    Dead_BattleKnightFC = 38,
    Dead_BattleKnightClimb = 39,
    Dead_BattleKnight = 40,
    Dead_BattleRifle = 41,
    Dead_BattleTheEnd = 42,
    Dead_Gimmick = 43,
    Dead_Fall = 44,
    Dead_Water = 45,
    Dead_Lava = 46,
    Failed_QuestKodamaCollect1 = 47,
    Failed_QuestMowingGrass = 48,
    Failed_QuestKodamaEscort = 49,
    Failed_QuestKodamaCollect2 = 50,
    Failed_QuestDarumaBattle = 51,
    Failed_QuestCollectItem = 52,
    Failed_QuestDrawBridge = 53,
    Failed_PinBall = 54,
    Failed_Hacking = 55,
    Transit_ToIsland = 56,
    Transit_ToCyber = 57,
    Transit_ToFishing = 58,
    Transit_ToHacking = 59,
    Transit_ToTheEnd = 60,
    Transit_ToSkill1 = 61,
    Transit_ToSkill2 = 62,
    Transit_ToSkill3 = 63,
    Transit_ToSkill4 = 64,
    Transit_ToSkill5 = 65,
    Transit_ToSkill6 = 66,
    Transit_ToSkill7 = 67,
    Transit_ToSkill8 = 68,
    Transit_ToSkill9 = 69,
    Transit_ToSkill10 = 70,
    Transit_ToSkill11 = 71,
    Transit_ToSkill12 = 72,
    Transit_ToSkill13 = 73,
    Transit_ToSkill14 = 74,
    Transit_ToSkill15 = 75,
    Transit_ToSkill16 = 76,
    Transit_ToSkill17 = 77,
    Transit_ToSkill18 = 78,
    Transit_ToSkill19 = 79,
    Transit_ToSkill20 = 80,
    NumKinds = 81
};

typedef struct
{
    Record record;
    cstring name;
    int32_t damage;
    float velocityX;
    float velocityY;
    cstring hitStopName;
    cstring cameraShakeName;
    Kind practice;
}
EnemyAttackRecord;

typedef struct
{
    EnemyAttackRecord data[192];
}
EnemyAttackRecordTable;

