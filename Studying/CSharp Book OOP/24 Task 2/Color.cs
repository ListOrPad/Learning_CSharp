public class Color
{
    public int RedChannel { get; set; }
    public int GreenChannel { get; set; }
    public int BlueChannel { get; set; }

    //White (255, 255, 255), Black (0, 0, 0), Red (255, 0, 0), 
    //Orange(255,165, 0), Yellow(255, 255, 0), Green(0, 128, 0), Blue(0, 0, 255), Purple(128, 0, 128)

    public Color(int red, int green, int blue)
    {
        RedChannel = red;
        GreenChannel = green;
        BlueChannel = blue;
    }

    public static Color White
    {
        get => new Color(255, 255, 255);
    }
    public static Color Black
    {
        get => new Color(0, 0, 0);
    }
    public static Color Red
    {
        get => new Color(255, 0, 0);
    }
    public static Color Orange
    {
        get => new Color(255, 165, 0);
    }
    public static Color Yellow
    {
        get => new Color(255, 255, 0);
    }
    public static Color Green
    {
        get => new Color(0, 128, 0);
    }
    public static Color Blue
    {
        get => new Color(0, 0, 255);
    }
    public static Color Purple
    {
        get => new Color(128, 0, 128);
    }


}