Library "UIMapParameter"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 160)]
    public struct ChallengeID1DimParameter
    {
        [FieldOffset(0)] public unsafe fixed int challengeID[40];
    }

    [StructLayout(LayoutKind.Explicit, Size = 6400)]
    public struct IslandMapParameter
    {
        [FieldOffset(0)] public unsafe fixed byte /* ChallengeID1DimParameter[40] */ _challengeIDHorizonGridGroup[6400];

        public unsafe ChallengeID1DimParameter* challengeIDHorizonGridGroup
        {
            get
            {
                fixed (byte* p_challengeIDHorizonGridGroup = _challengeIDHorizonGridGroup)
                    return (ChallengeID1DimParameter*)p_challengeIDHorizonGridGroup;
            }
        }
    }

    public struct Color8
    {
        public byte A;
        public byte R;
        public byte G;
        public byte B;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct IDColor
    {
        [FieldOffset(0)] public int id;
        [FieldOffset(4)] public Color8 color;
    }

    [StructLayout(LayoutKind.Explicit, Size = 33088)]
    public struct UIMapParameter
    {
        [FieldOffset(0)]     public unsafe fixed byte /* IslandMapParameter[5] */ _islandMapParam[32000];

        public unsafe IslandMapParameter* islandMapParam
        {
            get
            {
                fixed (byte* p_islandMapParam = _islandMapParam)
                    return (IslandMapParameter*)p_islandMapParam;
            }
        }

        [FieldOffset(32000)] public unsafe fixed byte /* IDColor[136] */ _idColors[1088];

        public unsafe IDColor* idColors
        {
            get
            {
                fixed (byte* p_idColors = _idColors)
                    return (IDColor*)p_idColors;
            }
        }
    }

}