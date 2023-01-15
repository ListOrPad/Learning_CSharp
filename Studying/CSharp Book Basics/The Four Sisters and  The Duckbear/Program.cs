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
            string x = Input("how old are you?");
            Console.WriteLine($"{x} and you?");
        }
    }
}