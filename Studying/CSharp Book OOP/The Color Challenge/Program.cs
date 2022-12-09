namespace The_Color_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Color yellow = Color.Yellow;
            Color customColor = new Color(77, 77, 42);

            Console.WriteLine($"You've chosen the yellow color: ({yellow.RedChannel}, {yellow.GreenChannel}, {yellow.BlueChannel})");
            Console.WriteLine($"Your custom color is ({customColor.RedChannel}, {customColor.GreenChannel}, {customColor.BlueChannel})");
        }
    }
}