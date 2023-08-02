Library "NavMeshParameter"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct World
    {
        [FieldOffset(0)]  public Vector3 aabbMin;
        [FieldOffset(16)] public Vector3 aabbMax;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct Rasterization
    {
        [FieldOffset(0)] public float voxelSize;
        [FieldOffset(4)] public float voxelHeight;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct Agent
    {
        [FieldOffset(0)]  public float radius;
        [FieldOffset(4)]  public float height;
        [FieldOffset(8)]  public float maxClimb;
        [FieldOffset(12)] public float maxSlope;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct Region
    {
        [FieldOffset(0)] public int minArea;
        [FieldOffset(4)] public int mergeArea;
    }

    public enum Partition : byte
{
        Watershed = 0,
        Monotone = 1,
        Layers = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 1)]
    public struct Partitioning
    {
        [FieldOffset(0)] public Partition type;
    }

    [StructLayout(LayoutKind.Explicit, Size = 3)]
    public struct Filtering
    {
        [FieldOffset(0)] public bool lowHangingObstacles;
        [FieldOffset(1)] public bool ledgeSpans;
        [FieldOffset(2)] public bool walkableLowHeightSpans;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct Polygonization
    {
        [FieldOffset(0)] public float edgeMaxLength;
        [FieldOffset(4)] public float maxSimplificationError;
        [FieldOffset(8)] public int vertsPerPoly;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct DetailMesh
    {
        [FieldOffset(0)] public float sampleDistance;
        [FieldOffset(4)] public float sampleMaxError;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct Tiling
    {
        [FieldOffset(0)] public float size;
        [FieldOffset(4)] public int maxTiles;
        [FieldOffset(8)] public bool cache;
    }

    [StructLayout(LayoutKind.Explicit, Size = 112)]
    public struct NavMeshParameter
    {
        [FieldOffset(0)]  public World world;
        [FieldOffset(32)] public Rasterization rasterization;
        [FieldOffset(40)] public Agent agent;
        [FieldOffset(56)] public Region region;
        [FieldOffset(64)] public Partitioning partitioning;
        [FieldOffset(65)] public Filtering filtering;
        [FieldOffset(68)] public Polygonization polygonization;
        [FieldOffset(80)] public DetailMesh detailMesh;
        [FieldOffset(88)] public Tiling tiling;
    }

}