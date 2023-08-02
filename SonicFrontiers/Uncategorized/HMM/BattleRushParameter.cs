Library "BattleRushParameter"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct BattleRushPhaseRankParameter
    {
        [FieldOffset(0)]  public unsafe fixed uint rankTime[4];
        [FieldOffset(16)] public unsafe fixed uint rankTimeAll[4];
    }

    public enum BgmType : sbyte
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
    }

    [StructLayout(LayoutKind.Explicit, Size = 508)]
    public struct BattleRushStageParameter
    {
        [FieldOffset(0)]   public uint numPhases;
        [FieldOffset(4)]   public unsafe fixed float phaseLimitTime[11];
        [FieldOffset(48)]  public unsafe fixed float phaseClearedTime[11];
        [FieldOffset(92)]  public unsafe fixed float phaseResultTime[11];
        [FieldOffset(136)] public unsafe fixed byte /* BattleRushPhaseRankParameter[11] */ _phaseRank[352];

        public unsafe BattleRushPhaseRankParameter* phaseRank
        {
            get
            {
                fixed (byte* p_phaseRank = _phaseRank)
                    return (BattleRushPhaseRankParameter*)p_phaseRank;
            }
        }

        [FieldOffset(488)] public unsafe fixed byte /* BgmType[11] */ _phaseBgmType[11];

        public unsafe BgmType* phaseBgmType
        {
            get
            {
                fixed (byte* p_phaseBgmType = _phaseBgmType)
                    return (BgmType*)p_phaseBgmType;
            }
        }

        [FieldOffset(500)] public uint hour;
        [FieldOffset(504)] public uint minute;
    }

    [StructLayout(LayoutKind.Explicit, Size = 2036)]
    public struct BattleRushParameter
    {
        [FieldOffset(0)]    public unsafe fixed byte /* BattleRushStageParameter[4] */ _stages[2032];

        public unsafe BattleRushStageParameter* stages
        {
            get
            {
                fixed (byte* p_stages = _stages)
                    return (BattleRushStageParameter*)p_stages;
            }
        }

        [FieldOffset(2032)] public float viewPaseResultTime;
    }

}