namespace Class_Topic
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrowInitializer arrowInitializer = new ArrowInitializer();

            Console.WriteLine("Choose which arrow to buy: elite, beginner, marksman or custom");
            string choice = Console.ReadLine();
            Arrow arrow = choice switch
            {
                "elite" => ArrowInitializer.CreateEliteArrow(),
                "beginner" => ArrowInitializer.CreateBeginnerArrow(),
                "marksman" => ArrowInitializer.CreateMarksmanArrow(),
                "custom" => arrowInitializer.GetCustomArrow(),
            };

            float price = arrow.GetCost();
            Console.WriteLine($"The arrow price is {price} gold");
        }
    }
}