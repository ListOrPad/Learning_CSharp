public class Color
{

    private int redChannelField;
    private int greenChannelField;
    private int blueChannelField;
    public int RedChannel
    {
        get 
        {
        return redChannelField;
        }
        set
        {
            if (value >= 0 && value <= 255)
                redChannelField = value;
        }
    }

    public int GreenChannel
    {
        get
        {
            return greenChannelField;
        }
        set
        {
            if (value >= 0 && value <= 255)
                greenChannelField = value;
        }
    }

        public int BlueChannel
        {
            get
            {
                return blueChannelField;
            }
            set
            {
                if (value >= 0 && value <= 255)
                    blueChannelField = value;
            }
        }


    public Color(int redChannel, int greenChannel, int blueChannel)
        {
            RedChannel = redChannel;
            GreenChannel = greenChannel;
            BlueChannel = blueChannel;
        }


    public static Color White { get; } = new Color(255, 255, 255);
    public static Color Black { get; } = new Color(0, 0, 0);
    public static Color Red  { get; } = new Color(255, 0, 0);
    public static Color Orange { get; } = new Color(255, 165, 0);
    public static Color Yellow { get; } = new Color(255, 255, 0);
    public static Color Green { get; } = new Color(0, 128, 0);
    public static Color Blue { get; } = new Color(0, 0, 255);
    public static Color Purple { get; } = new Color(128, 0, 128);

}