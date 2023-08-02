#pragma once

#include <rangers-api/rangers-api/rangers-api.h>

enum LayerType : int8_t
{
    LAYER_NONE = 0,
    LAYER_SOLID = 1,
    LAYER_LIQUID = 2,
    LAYER_THROUGH = 3,
    LAYER_CAMERA = 4,
    LAYER_SOLID_ONEWAY = 5,
    LAYER_SOLID_THROUGH = 6,
    LAYER_SOLID_TINY = 7,
    LAYER_SOLID_DETAIL = 8,
    LAYER_LEAF = 9,
    LAYER_LAND = 10,
    LAYER_RAYBLOCK = 11,
    LAYER_EVENT = 12,
    LAYER_RESERVED13 = 13,
    LAYER_RESERVED14 = 14,
    LAYER_PLAYER = 15,
    LAYER_ENEMY = 16,
    LAYER_ENEMY_BODY = 17,
    LAYER_GIMMICK = 18,
    LAYER_DYNAMICS = 19,
    LAYER_RING = 20,
    LAYER_CHARACTER_CONTROL = 21,
    LAYER_PLAYER_ONLY = 22,
    LAYER_DYNAMICS_THROUGH = 23,
    LAYER_ENEMY_ONLY = 24,
    LAYER_SENSOR_PLAYER = 25,
    LAYER_SENSOR_RING = 26,
    LAYER_SENSOR_GIMMICK = 27,
    LAYER_SENSOR_LAND = 28,
    LAYER_SENSOR_ALL = 29,
    LAYER_RESERVED30 = 30,
    LAYER_RESERVED31 = 31
};

enum MaterialType : int8_t
{
    MAT_NONE = 0,
    MAT_STONE = 1,
    MAT_EARTH = 2,
    MAT_WOOD = 3,
    MAT_GRASS = 4,
    MAT_IRON = 5,
    MAT_SAND = 6,
    MAT_LAVA = 7,
    MAT_GLASS = 8,
    MAT_SNOW = 9,
    MAT_NO_ENTRY = 10,
    MAT_ICE = 11,
    MAT_WATER = 12,
    MAT_SEA = 13,
    MAT_DAMAGE = 14,
    MAT_DEAD = 15,
    MAT_FLOWER0 = 16,
    MAT_FLOWER1 = 17,
    MAT_FLOWER2 = 18,
    MAT_AIR = 19,
    MAT_DEADLEAVES = 20,
    MAT_WIREMESH = 21,
    MAT_DEAD_ANYDIR = 22,
    MAT_DAMAGE_THROUGH = 23,
    MAT_DRY_GRASS = 24,
    MAT_RELIC = 25,
    MAT_GIANT = 26,
    MAT_GRAVEL = 27,
    MAT_MUD_WATER = 28,
    MAT_SAND2 = 29,
    MAT_SAND3 = 30
};

typedef struct
{
    LayerType layer;
    MaterialType material;
    bool notStand;
    bool wall;
    bool parkour;
}
HeightFieldConfigData;

typedef struct
{
    HeightFieldConfigData data[255];
}
HeightFieldConfig;
