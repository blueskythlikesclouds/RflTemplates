Library "ActionChainParameter"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public struct ActionChainScoreParameter
    {
        [FieldOffset(0)]  public uint score;
        [FieldOffset(4)]  public uint level1Meter;
        [FieldOffset(8)]  public uint level2Meter;
        [FieldOffset(12)] public uint level3Meter;
        [FieldOffset(16)] public uint level4Meter;
        [FieldOffset(20)] public uint level5Meter;
        [FieldOffset(24)] public uint level6Meter;
        [FieldOffset(28)] public uint level7Meter;
        [FieldOffset(32)] public uint level8Meter;
        [FieldOffset(36)] public uint level9Meter;
        [FieldOffset(40)] public float delay;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct ActionChainAttackLevelParameter
    {
        [FieldOffset(0)] public uint level1Param;
        [FieldOffset(4)] public uint level99Param;
    }

    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public struct ActionChainAttackScoreParameter
    {
        [FieldOffset(0)]  public ActionChainAttackLevelParameter score;
        [FieldOffset(8)]  public ActionChainAttackLevelParameter level1Meter;
        [FieldOffset(16)] public ActionChainAttackLevelParameter level2Meter;
        [FieldOffset(24)] public ActionChainAttackLevelParameter level3Meter;
        [FieldOffset(32)] public ActionChainAttackLevelParameter level4Meter;
        [FieldOffset(40)] public ActionChainAttackLevelParameter level5Meter;
        [FieldOffset(48)] public ActionChainAttackLevelParameter level6Meter;
        [FieldOffset(56)] public ActionChainAttackLevelParameter level7Meter;
        [FieldOffset(64)] public ActionChainAttackLevelParameter level8Meter;
        [FieldOffset(72)] public ActionChainAttackLevelParameter level9Meter;
    }

    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public struct ActionChainIntervalScoreParameter
    {
        [FieldOffset(0)]  public float intervalTime;
        [FieldOffset(4)]  public uint score;
        [FieldOffset(8)]  public uint level1Meter;
        [FieldOffset(12)] public uint level2Meter;
        [FieldOffset(16)] public uint level3Meter;
        [FieldOffset(20)] public uint level4Meter;
        [FieldOffset(24)] public uint level5Meter;
        [FieldOffset(28)] public uint level6Meter;
        [FieldOffset(32)] public uint level7Meter;
        [FieldOffset(36)] public uint level8Meter;
        [FieldOffset(40)] public uint level9Meter;
    }

    [StructLayout(LayoutKind.Explicit, Size = 92)]
    public struct ActionChainBoostScoreParameter
    {
        [FieldOffset(0)]  public float intervalTime;
        [FieldOffset(4)]  public float minSpeed;
        [FieldOffset(8)]  public float maxSpeed;
        [FieldOffset(12)] public ActionChainAttackLevelParameter score;
        [FieldOffset(20)] public ActionChainAttackLevelParameter level1Meter;
        [FieldOffset(28)] public ActionChainAttackLevelParameter level2Meter;
        [FieldOffset(36)] public ActionChainAttackLevelParameter level3Meter;
        [FieldOffset(44)] public ActionChainAttackLevelParameter level4Meter;
        [FieldOffset(52)] public ActionChainAttackLevelParameter level5Meter;
        [FieldOffset(60)] public ActionChainAttackLevelParameter level6Meter;
        [FieldOffset(68)] public ActionChainAttackLevelParameter level7Meter;
        [FieldOffset(76)] public ActionChainAttackLevelParameter level8Meter;
        [FieldOffset(84)] public ActionChainAttackLevelParameter level9Meter;
    }

    [StructLayout(LayoutKind.Explicit, Size = 104)]
    public struct ActionChainSpinBoostScoreParameter
    {
        [FieldOffset(0)]   public float intervalTime;
        [FieldOffset(4)]   public float minSpeed;
        [FieldOffset(8)]   public float maxSpeed;
        [FieldOffset(12)]  public ActionChainAttackLevelParameter score;
        [FieldOffset(20)]  public ActionChainAttackLevelParameter level1Meter;
        [FieldOffset(28)]  public ActionChainAttackLevelParameter level2Meter;
        [FieldOffset(36)]  public ActionChainAttackLevelParameter level3Meter;
        [FieldOffset(44)]  public ActionChainAttackLevelParameter level4Meter;
        [FieldOffset(52)]  public ActionChainAttackLevelParameter level5Meter;
        [FieldOffset(60)]  public ActionChainAttackLevelParameter level6Meter;
        [FieldOffset(68)]  public ActionChainAttackLevelParameter level7Meter;
        [FieldOffset(76)]  public ActionChainAttackLevelParameter level8Meter;
        [FieldOffset(84)]  public ActionChainAttackLevelParameter level9Meter;
        [FieldOffset(92)]  public float minHeight;
        [FieldOffset(96)]  public float maxHeight;
        [FieldOffset(100)] public float maxHeightMagnification;
    }

    [StructLayout(LayoutKind.Explicit, Size = 3080)]
    public struct ActionChainActionParameter
    {
        [FieldOffset(0)]    public ActionChainScoreParameter dashRollerScore;
        [FieldOffset(44)]   public ActionChainScoreParameter dashPanelScore;
        [FieldOffset(88)]   public ActionChainScoreParameter jumpBoardScore;
        [FieldOffset(132)]  public ActionChainScoreParameter jumpSelecterScore;
        [FieldOffset(176)]  public ActionChainScoreParameter poleScore;
        [FieldOffset(220)]  public ActionChainScoreParameter selectCannonScore;
        [FieldOffset(264)]  public ActionChainScoreParameter springScore;
        [FieldOffset(308)]  public ActionChainScoreParameter wideSpringScore;
        [FieldOffset(352)]  public ActionChainScoreParameter springClassicScore;
        [FieldOffset(396)]  public ActionChainScoreParameter balloonScore;
        [FieldOffset(440)]  public ActionChainScoreParameter upReelScore;
        [FieldOffset(484)]  public ActionChainScoreParameter wallJumpScore;
        [FieldOffset(528)]  public ActionChainScoreParameter propellerSpringScore;
        [FieldOffset(572)]  public ActionChainScoreParameter springPoleScore;
        [FieldOffset(616)]  public ActionChainScoreParameter dashRingScore;
        [FieldOffset(660)]  public ActionChainAttackScoreParameter acceleCombo1Score;
        [FieldOffset(740)]  public ActionChainAttackScoreParameter acceleCombo2Score;
        [FieldOffset(820)]  public ActionChainAttackScoreParameter comboFinishScore;
        [FieldOffset(900)]  public ActionChainAttackScoreParameter acceleRushCombo1Score;
        [FieldOffset(980)]  public ActionChainAttackScoreParameter acceleRushCombo2Score;
        [FieldOffset(1060)] public ActionChainAttackScoreParameter acceleRushComboFinishScore;
        [FieldOffset(1140)] public ActionChainAttackScoreParameter chargeAttackScore;
        [FieldOffset(1220)] public ActionChainAttackScoreParameter smashScore;
        [FieldOffset(1300)] public ActionChainAttackScoreParameter recoverySmashScore;
        [FieldOffset(1380)] public ActionChainAttackScoreParameter sonicBoomScore;
        [FieldOffset(1460)] public ActionChainAttackScoreParameter crasherScore;
        [FieldOffset(1540)] public ActionChainAttackScoreParameter loopKickScore;
        [FieldOffset(1620)] public ActionChainAttackScoreParameter spinSlashScore;
        [FieldOffset(1700)] public ActionChainAttackScoreParameter stompingAttackScore;
        [FieldOffset(1780)] public ActionChainAttackScoreParameter homingShotScore;
        [FieldOffset(1860)] public ActionChainAttackScoreParameter crossSlashScore;
        [FieldOffset(1940)] public ActionChainScoreParameter ringScore;
        [FieldOffset(1984)] public ActionChainScoreParameter gismoScore;
        [FieldOffset(2028)] public ActionChainScoreParameter homingScore;
        [FieldOffset(2072)] public ActionChainAttackScoreParameter enemyHomingScore;
        [FieldOffset(2152)] public ActionChainScoreParameter airTrickScore;
        [FieldOffset(2196)] public ActionChainScoreParameter chainBoosterScore;
        [FieldOffset(2240)] public ActionChainScoreParameter parryScore;
        [FieldOffset(2284)] public ActionChainAttackScoreParameter quickCyloopScore;
        [FieldOffset(2364)] public ActionChainScoreParameter defeatEnemyScore;
        [FieldOffset(2408)] public ActionChainScoreParameter defeatMiniBossScore;
        [FieldOffset(2452)] public ActionChainAttackScoreParameter slingShotScore;
        [FieldOffset(2532)] public ActionChainScoreParameter rippleLaserScore;
        [FieldOffset(2576)] public ActionChainIntervalScoreParameter grindRailScore;
        [FieldOffset(2620)] public ActionChainIntervalScoreParameter pulleyScore;
        [FieldOffset(2664)] public ActionChainIntervalScoreParameter fanScore;
        [FieldOffset(2708)] public ActionChainIntervalScoreParameter wallRunScore;
        [FieldOffset(2752)] public ActionChainBoostScoreParameter boostScore;
        [FieldOffset(2844)] public ActionChainIntervalScoreParameter powerBoostScore;
        [FieldOffset(2888)] public ActionChainIntervalScoreParameter sandSkiScore;
        [FieldOffset(2932)] public ActionChainIntervalScoreParameter acceleRailScore;
        [FieldOffset(2976)] public ActionChainSpinBoostScoreParameter spinBoostScore;
    }

    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public struct ActionChainMeterParameter
    {
        [FieldOffset(0)]  public uint meterMax;
        [FieldOffset(4)]  public float meterDecreaseTime;
        [FieldOffset(8)]  public uint meterDecrease;
        [FieldOffset(12)] public float decreaseWaitTime;
        [FieldOffset(16)] public float decreasePercent;
        [FieldOffset(20)] public float decreaseWaitTimeAddMeter;
        [FieldOffset(24)] public float meterResetDelayTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 3340)]
    public struct ActionChainParameter
    {
        [FieldOffset(0)]    public ActionChainActionParameter actionParam;
        [FieldOffset(3080)] public ActionChainMeterParameter level1MeterParam;
        [FieldOffset(3108)] public ActionChainMeterParameter level2MeterParam;
        [FieldOffset(3136)] public ActionChainMeterParameter level3MeterParam;
        [FieldOffset(3164)] public ActionChainMeterParameter level4MeterParam;
        [FieldOffset(3192)] public ActionChainMeterParameter level5MeterParam;
        [FieldOffset(3220)] public ActionChainMeterParameter level6MeterParam;
        [FieldOffset(3248)] public ActionChainMeterParameter level7MeterParam;
        [FieldOffset(3276)] public ActionChainMeterParameter level8MeterParam;
        [FieldOffset(3304)] public ActionChainMeterParameter level9MeterParam;
        [FieldOffset(3332)] public float gimmickReuseTime;
        [FieldOffset(3336)] public bool isChainBoosterLevelUp;
    }

}