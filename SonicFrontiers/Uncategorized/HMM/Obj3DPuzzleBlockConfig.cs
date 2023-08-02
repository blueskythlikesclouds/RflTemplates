Library "Obj3DPuzzleBlockConfig"
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 5)]
    public struct FSRow
    {
        [FieldOffset(0)] public unsafe fixed byte columns[5];
    }

    [StructLayout(LayoutKind.Explicit, Size = 25)]
    public struct FSLayer
    {
        [FieldOffset(0)] public unsafe fixed byte /* FSRow[5] */ _rows[25];

        public unsafe FSRow* rows
        {
            get
            {
                fixed (byte* p_rows = _rows)
                    return (FSRow*)p_rows;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 160)]
    public struct FreeShape
    {
        [FieldOffset(0)]  public byte numLayers;
        [FieldOffset(1)]  public byte numRows;
        [FieldOffset(2)]  public byte numColumns;
        [FieldOffset(16)] public Vector3 offsetToTopLeft;
        [FieldOffset(32)] public unsafe fixed byte /* FSLayer[5] */ _layers[125];

        public unsafe FSLayer* layers
        {
            get
            {
                fixed (byte* p_layers = _layers)
                    return (FSLayer*)p_layers;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 4640)]
    public struct Obj3DPuzzleBlockConfig
    {
        [FieldOffset(0)] public unsafe fixed byte /* FreeShape[29] */ _freeShapes[4640];

        public unsafe FreeShape* freeShapes
        {
            get
            {
                fixed (byte* p_freeShapes = _freeShapes)
                    return (FreeShape*)p_freeShapes;
            }
        }
    }

}