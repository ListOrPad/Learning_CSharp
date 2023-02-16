namespace _24_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //My custom color display
            Color customColor = new Color(244, 4, 44);
            Console.WriteLine("Display Custom color values:");
            Console.WriteLine($"Red:{customColor.RedChannel} Green:{customColor.GreenChannel} Blue:{customColor.BlueChannel}");

            //Static predefined Red color display
            Console.WriteLine("Display Red predefined color values:");
            Console.WriteLine($"Red:{Color.Red.RedChannel} Green:{Color.Red.GreenChannel} Blue:{Color.Red.BlueChannel}");


            //Static predefined Purple color display
            Color purple = Color.Purple;
            Console.WriteLine("Display Purple predefined color values:");
            Console.WriteLine($"Red:{purple.RedChannel} Green:{purple.GreenChannel} Blue:{purple.BlueChannel}");
            //mention different ways of using Color.Red/Color.Purple properties!!!
        }
    }
}