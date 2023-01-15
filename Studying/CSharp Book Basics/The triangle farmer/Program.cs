namespace The_triangle_farmer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //getting input
            Console.WriteLine("Enter the base length");
            int baseLength = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the heigh length");
            int heightLength = Convert.ToInt32(Console.ReadLine());

            //computing formula
            int area = baseLength * heightLength / 2;
            Console.WriteLine($"area is {area} cm");

        }
    }
}