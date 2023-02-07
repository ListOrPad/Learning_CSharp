namespace Class_Topic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create class

            //create new instance of an Arrow class
            Arrow arrow = new Arrow();
            Console.WriteLine($"The arrow price is {arrow.GetCost()} gold");
        }
    }
}