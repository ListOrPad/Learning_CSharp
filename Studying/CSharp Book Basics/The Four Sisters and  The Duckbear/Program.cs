namespace The_Four_Sisters_and__The_Duckbear
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
            int eggCount = Convert.ToInt32(Input("How many choco eggs were gathered today?"));
            int bearGets = eggCount % 4;
            Console.WriteLine($"The bear gets {bearGets} eggs today");
        }
    }
}