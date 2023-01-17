namespace The_dominion_of_kings_challenge
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
            int provincesCount = Convert.ToInt32(Input("How many provinces do you have?"));
            int duchesCount = Convert.ToInt32(Input("How many duches do you have?"));
            int estatesCount = Convert.ToInt32(Input("How many estates do you have?"));
            Console.WriteLine($"you have {provincesCount + duchesCount * 3 + estatesCount * 6} points");
        }
    }
}