Library "StandardCameraConfig"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 104)]
    public struct StandardCameraCommonParameter
    {
        [FieldOffset(0)]   public float distance;
        [FieldOffset(4)]   public float distanceSuspensionK;
        [FieldOffset(8)]   public float minElevation;
        [FieldOffset(12)]  public float maxElevation;
        [FieldOffset(16)]  public float azimuthSensitivity;
        [FieldOffset(20)]  public float elevationUpSensitivity;
        [FieldOffset(24)]  public float elevationDownSensitivity;
        [FieldOffset(28)]  public float elevationOffset;
        [FieldOffset(32)]  public float targetUpOffset;
        [FieldOffset(36)]  public float targetMinUpOffsetLimit;
        [FieldOffset(40)]  public float targetMaxUpOffsetLimit;
        [FieldOffset(44)]  public float targetMinUpOffsetLimitDistance;
        [FieldOffset(48)]  public float targetMaxUpOffsetLimitDistance;
        [FieldOffset(52)]  public float targetOffsetSuspensionK;
        [FieldOffset(56)]  public float delayAllowDistance;
        [FieldOffset(60)]  public float delayLimitDistance;
        [FieldOffset(64)]  public float delaySuspensionK;
        [FieldOffset(68)]  public float autocontrolDisabledTime;
        [FieldOffset(72)]  public float chaseSegmentSuspensionK;
        [FieldOffset(76)]  public float chaseSegmentShortenSpeed;
        [FieldOffset(80)]  public int chaseSegmentMaxCount;
        [FieldOffset(84)]  public float inertiaMinDecel;
        [FieldOffset(88)]  public float inertiaOvershootAngle;
        [FieldOffset(92)]  public float resetSuspensionK;
        [FieldOffset(96)]  public float downDirectionDotThreshold;
        [FieldOffset(100)] public float baseUpLeanRate;
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct StandardCameraDashParameter
    {
        [FieldOffset(0)]  public float minDistance;
        [FieldOffset(4)]  public float maxDistance;
        [FieldOffset(8)]  public float minDistanceAccel;
        [FieldOffset(12)] public float maxDistanceAccel;
        [FieldOffset(16)] public float distanceSuspensionK;
        [FieldOffset(20)] public float elevationOffset;
        [FieldOffset(24)] public float azimuthSensitivity;
        [FieldOffset(28)] public float targetOffsetSuspensionK;
        [FieldOffset(32)] public float targetUpOffset;
        [FieldOffset(36)] public float delayAllowDistance;
        [FieldOffset(40)] public float delayLimitDistance;
        [FieldOffset(44)] public float delaySuspensionK;
    }

    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public struct StandardCameraCyloopParameter
    {
        [FieldOffset(0)]  public float minDistance;
        [FieldOffset(4)]  public float maxDistance;
        [FieldOffset(8)]  public float elevationOffset;
        [FieldOffset(12)] public float azimuthSensitivity;
        [FieldOffset(16)] public float elevationUpSensitivity;
        [FieldOffset(20)] public float elevationDownSensitivity;
        [FieldOffset(24)] public float targetUpOffset;
        [FieldOffset(28)] public float minDelayLimitDistance;
        [FieldOffset(32)] public float maxDelayLimitDistance;
    }

    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public struct StandardCameraLockonParameter
    {
        [FieldOffset(0)]  public float distance;
        [FieldOffset(4)]  public float minElevation;
        [FieldOffset(8)]  public float maxElevation;
        [FieldOffset(12)] public float elevationOffset;
        [FieldOffset(16)] public float minElevationCyloop;
        [FieldOffset(20)] public float maxElevationCyloop;
        [FieldOffset(24)] public float elevationOffsetCyloop;
        [FieldOffset(28)] public float targetUpOffset;
        [FieldOffset(32)] public float delayAllowDistance;
        [FieldOffset(36)] public float delayLimitDistance;
        [FieldOffset(40)] public float delaySuspensionK;
        [FieldOffset(44)] public float panningSuspensionK;
        [FieldOffset(48)] public float interiorPanningDistance;
        [FieldOffset(52)] public float interiorPanningSuspensionK;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct StandardCameraWallParameter
    {
        [FieldOffset(0)] public float distance;
        [FieldOffset(4)] public float targetUpOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public struct StandardCameraLoopParameter
    {
        [FieldOffset(0)]  public float azimuthSensitivity;
        [FieldOffset(4)]  public float elevationUpSensitivity;
        [FieldOffset(8)]  public float elevationDownSensitivity;
        [FieldOffset(12)] public float targetUpOffset;
        [FieldOffset(16)] public float baseUpLeanRate;
    }

    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public struct StandardCameraBattleParameter
    {
        [FieldOffset(0)]  public float distance;
        [FieldOffset(4)]  public float distanceSuspensionK;
        [FieldOffset(8)]  public float elevationOffset;
        [FieldOffset(12)] public float azimuthMinOffset;
        [FieldOffset(16)] public float azimuthMaxOffset;
        [FieldOffset(20)] public float azimuthMinOffsetDistance;
        [FieldOffset(24)] public float azimuthMaxOffsetDistance;
        [FieldOffset(28)] public float azimuthSensitivity;
        [FieldOffset(32)] public float targetOffsetSuspensionK;
        [FieldOffset(36)] public float targetMinUpOffset;
        [FieldOffset(40)] public float targetMaxUpOffset;
        [FieldOffset(44)] public float targetFrontOffset;
        [FieldOffset(48)] public float delayAllowDistance;
        [FieldOffset(52)] public float delayLimitDistance;
        [FieldOffset(56)] public float delaySuspensionK;
        [FieldOffset(60)] public float manualControlTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public struct StandardCameraOptionParameter
    {
        [FieldOffset(0)]  public float minManualRotationSpeed;
        [FieldOffset(4)]  public float maxManualRotationSpeed;
        [FieldOffset(8)]  public float minDistanceScale;
        [FieldOffset(12)] public float maxDistanceScale;
        [FieldOffset(16)] public float maxElevationAddOffset;
        [FieldOffset(20)] public float minTargetUpOffsetScale;
        [FieldOffset(24)] public float maxTargetUpOffsetScale;
        [FieldOffset(28)] public float minFovyRate;
        [FieldOffset(32)] public float minLimitFovy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 688)]
    public struct StandardCameraConfig
    {
        [FieldOffset(0)]   public StandardCameraCommonParameter common;
        [FieldOffset(104)] public StandardCameraDashParameter dash;
        [FieldOffset(152)] public StandardCameraCyloopParameter cyloop;
        [FieldOffset(188)] public StandardCameraCyloopParameter cyloopSnipe;
        [FieldOffset(224)] public StandardCameraLockonParameter lockon;
        [FieldOffset(280)] public StandardCameraLockonParameter lockonCharger;
        [FieldOffset(336)] public StandardCameraLockonParameter lockonSpider;
        [FieldOffset(392)] public StandardCameraLockonParameter lockonDaruma;
        [FieldOffset(448)] public StandardCameraLockonParameter lockonNinja;
        [FieldOffset(504)] public StandardCameraLockonParameter lockonSumo;
        [FieldOffset(560)] public StandardCameraWallParameter wall;
        [FieldOffset(568)] public StandardCameraLoopParameter loop;
        [FieldOffset(588)] public StandardCameraBattleParameter battle;
        [FieldOffset(652)] public StandardCameraOptionParameter option;
    }

}