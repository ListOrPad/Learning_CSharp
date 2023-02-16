namespace _24_Misc_exercises_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(2, 3);
            Point point2 = new Point(-4, 0);
            Point pointZero = new Point();

            Console.WriteLine($"First point: ({point1.X}, {point1.Y})\n" +
                $"Second point: ({point2.X}, {point2.Y})\n" +
                $"Starting point: ({pointZero.X}, {pointZero.Y})");

        }
    }
}