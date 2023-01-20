namespace The_Watchtower_Challenge
{
    internal class Program
    {
        static string Input(string text)
        {
            Console.WriteLine(text);
            string input = Console.ReadLine();
            return input;
        }
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Input("tell the x coordinate"));
            int y = Convert.ToInt32(Input("tell the y coordinate"));

           
            if (x < 0 && y > 0) Console.WriteLine("NW");
            if (x == 0 && y > 0) Console.WriteLine("N");
            if (x > 0 && y > 0) Console.WriteLine("NE");
            if (x < 0 && y == 0) Console.WriteLine("W");
            if (x == 0 && y == 0) Console.WriteLine("Right Here!");
            if (x > 0 && y == 0) Console.WriteLine("E");
            if (x < 0 && y < 0) Console.WriteLine("SW");
            if (x == 0 && y < 0) Console.WriteLine("S");
            if (x > 0 && y < 0) Console.WriteLine("SE");
        }
    }
}