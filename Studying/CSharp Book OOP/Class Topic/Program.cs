namespace Class_Topic
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrowInitializer arrowInitializer = new ArrowInitializer();

            Arrowhead arrowhead = arrowInitializer.GetArrowhead();
            Fletching fletching = arrowInitializer.GetFletching();
            float shaftLength = arrowInitializer.GetLength();

            Arrow arrow = new Arrow(arrowhead, fletching, shaftLength);
            float price = arrow.GetCost();
            Console.WriteLine($"The arrow price is {price} gold");
        }
    }
}