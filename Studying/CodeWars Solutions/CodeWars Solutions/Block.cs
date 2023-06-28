class Block
{
    public int Width { get; set; }
    public int Height { get; set; }
    public int Length { get; set; }

    public Block(int[] array )
    {
        Width = array[0];
        Height = array[1];
        Length = array[2];
    }

    public int GetWidth()
    {
        return Width;
    }
    public int GetHeight()
    {
        return Height;
    }
    public int GetLength()
    {
        return Length;
    }
    public int GetVolume()
    {
        return Width * Height * Length;
    }
    public int GetSurfaceArea()
    {
        return 2 * (Width * Length + Height * Length + Height * Width);
    }
}