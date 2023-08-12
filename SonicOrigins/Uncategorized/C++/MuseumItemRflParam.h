#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

enum MuseumSectionKind : int32_t
{
    MUSEUMSECTIONKIND_NORMAL = 0,
    MUSEUMSECTIONKIND_PREMIUM = 1,
    MUSEUMSECTIONKIND_NUM = 2
};

typedef struct
{
    const char* pValue;
    INSERT_PADDING(8);
}
cstring;

enum MuseumItemCategory : int32_t
{
    MUSEUMITEMCATEGORY_NONE = 0,
    MUSEUMITEMCATEGORY_TITLE_START = 1,
    MUSEUMITEMCATEGORY_TITLE_SONIC_1 = 1,
    MUSEUMITEMCATEGORY_TITLE_SONIC_CD = 2,
    MUSEUMITEMCATEGORY_TITLE_SONIC_2 = 3,
    MUSEUMITEMCATEGORY_TITLE_SONIC_3K = 4,
    MUSEUMITEMCATEGORY_TITLE_SONIC_ORIGINS = 5,
    MUSEUMITEMCATEGORY_TITLE_ETC = 6,
    MUSEUMITEMCATEGORY_TITLE_SONIC_SPINBALL = 7,
    MUSEUMITEMCATEGORY_TITLE_CHAOTIX = 8,
    MUSEUMITEMCATEGORY_TITLE_SONIC_3D_BLAST = 9,
    MUSEUMITEMCATEGORY_TITLE_RESERVE_1 = 10,
    MUSEUMITEMCATEGORY_TITLE_END = 11,
    MUSEUMITEMCATEGORY_SOUND_START = 11,
    MUSEUMITEMCATEGORY_SOUND_BGM_MENU = 11,
    MUSEUMITEMCATEGORY_SOUND_BGM_STAGE = 12,
    MUSEUMITEMCATEGORY_SOUND_JINGLE = 13,
    MUSEUMITEMCATEGORY_SOUND_ETC = 14,
    MUSEUMITEMCATEGORY_SOUND_RESERVE_1 = 15,
    MUSEUMITEMCATEGORY_SOUND_END = 16,
    MUSEUMITEMCATEGORY_CHARA_START = 16,
    MUSEUMITEMCATEGORY_CHARA_SONIC = 16,
    MUSEUMITEMCATEGORY_CHARA_TAILS = 17,
    MUSEUMITEMCATEGORY_CHARA_KNUCKLES = 18,
    MUSEUMITEMCATEGORY_CHARA_AMY = 19,
    MUSEUMITEMCATEGORY_CHARA_EGGMAN = 20,
    MUSEUMITEMCATEGORY_CHARA_METALSONIC = 21,
    MUSEUMITEMCATEGORY_CHARA_ETC = 22,
    MUSEUMITEMCATEGORY_CHARA_RESERVE_1 = 23,
    MUSEUMITEMCATEGORY_CHARA_END = 24,
    MUSEUMITEMCATEGORY_PICTURE_START = 24,
    MUSEUMITEMCATEGORY_PICTURE_INITIAL = 24,
    MUSEUMITEMCATEGORY_PICTURE_COLOR = 25,
    MUSEUMITEMCATEGORY_PICTURE_DOCUMENT = 26,
    MUSEUMITEMCATEGORY_PICTURE_PACKAGE = 27,
    MUSEUMITEMCATEGORY_PICTURE_ETC = 28,
    MUSEUMITEMCATEGORY_PICTURE_END = 29,
    MUSEUMITEMCATEGORY_NUM = 29,
    MUSEUMITEMCATEGORY_TITLE_NUM = 10,
    MUSEUMITEMCATEGORY_SOUND_NUM = 5,
    MUSEUMITEMCATEGORY_CHARA_NUM = 8,
    MUSEUMITEMCATEGORY_PICTURE_NUM = 5
};

enum MuseumItemOpenState : int32_t
{
    MUSEUMITEMOPENSTATE_UNKNOWN = 0,
    MUSEUMITEMOPENSTATE_OPEN = 1,
    MUSEUMITEMOPENSTATE_COIN = 2,
    MUSEUMITEMOPENSTATE_STATS = 3,
    MUSEUMITEMOPENSTATE_NUM = 4
};

typedef struct
{
    MuseumItemOpenState openState;
    int32_t unlockAchievementNo;
    int32_t unlockCoinNum;
}
MuseumUnlockInfo;

typedef struct
{
    bool isEnable;
    int32_t number;
    MuseumSectionKind sectionKind;
    cstring assetName;
    int32_t playTime;
    bool fadeOutMusic;
    MuseumItemCategory categories[10];
    bool isDLCItem;
    bool isTypeSD;
    bool is4KAvailable;
    uint8_t soundTexNum;
    uint8_t artPageCount;
    uint8_t movieSoundCount;
    MuseumUnlockInfo unlockInfo;
}
MuseumItemInfo;

enum MuseumSortInfo_MuseumItemCategory : int32_t
{
    MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_NONE = 0,
    MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_TITLE_START = 1,
    MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_TITLE_SONIC_1 = 1,
    MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_TITLE_SONIC_CD = 2,
    MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_TITLE_SONIC_2 = 3,
    MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_TITLE_SONIC_3K = 4,
    MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_TITLE_SONIC_ORIGINS = 5,
    MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_TITLE_ETC = 6,
    MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_TITLE_SONIC_SPINBALL = 7,
    MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_TITLE_CHAOTIX = 8,
    MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_TITLE_SONIC_3D_BLAST = 9,
    MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_TITLE_RESERVE_1 = 10,
    MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_TITLE_END = 11,
    MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_SOUND_START = 11,
    MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_SOUND_BGM_MENU = 11,
    MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_SOUND_BGM_STAGE = 12,
    MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_SOUND_JINGLE = 13,
    MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_SOUND_ETC = 14,
    MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_SOUND_RESERVE_1 = 15,
    MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_SOUND_END = 16,
    MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_CHARA_START = 16,
    MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_CHARA_SONIC = 16,
    MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_CHARA_TAILS = 17,
    MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_CHARA_KNUCKLES = 18,
    MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_CHARA_AMY = 19,
    MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_CHARA_EGGMAN = 20,
    MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_CHARA_METALSONIC = 21,
    MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_CHARA_ETC = 22,
    MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_CHARA_RESERVE_1 = 23,
    MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_CHARA_END = 24,
    MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_PICTURE_START = 24,
    MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_PICTURE_INITIAL = 24,
    MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_PICTURE_COLOR = 25,
    MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_PICTURE_DOCUMENT = 26,
    MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_PICTURE_PACKAGE = 27,
    MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_PICTURE_ETC = 28,
    MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_PICTURE_END = 29,
    MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_NUM = 29,
    MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_TITLE_NUM = 10,
    MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_SOUND_NUM = 5,
    MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_CHARA_NUM = 8,
    MuseumSortInfo_MuseumItemCategory_MUSEUMITEMCATEGORY_PICTURE_NUM = 5
};

typedef struct
{
    MuseumSortInfo_MuseumItemCategory category;
    bool isDLCCategory;
}
MuseumSortInfo;

typedef struct
{
    float time;
}
MusicFadeOutInfo;

typedef struct
{
    MuseumItemInfo musicItems[401];
    MuseumItemInfo artItems[251];
    MuseumItemInfo movieItems[51];
    MuseumSortInfo musicSortInfos[15];
    MuseumSortInfo artSortInfos[15];
    MusicFadeOutInfo musicFadeOutInfo;
}
MuseumItemRflParam;

