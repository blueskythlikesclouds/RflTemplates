Library "GismoConfigPlanData"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    public enum ContactDamageType : sbyte
{
        CONTACT_DAMAGE_NONE = 0,
        CONTACT_DAMAGE_LOW_SPEED = 1,
        CONTACT_DAMAGE_MIDDLE_SPEED = 2,
        CONTACT_DAMAGE_HIGH_SPEED = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct GismoConfigPlanData
    {
        [FieldOffset(0)] public ContactDamageType contactDamageType;
        [FieldOffset(1)] public bool noneDamageSpin;
        [FieldOffset(2)] public bool rideOnDamage;
        [FieldOffset(3)] public bool aerialBounce;
    }

}