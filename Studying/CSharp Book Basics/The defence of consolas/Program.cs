namespace The_defence_of_consolas
{
    internal class Program
    {
        static string Input(string text)
        {
            Console.Write(text);
            string input = Console.ReadLine();
            return input;
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "The Defence of Consolas challenge";

            int row = Convert.ToInt32(Input("Target Row: "));
            int column = Convert.ToInt32(Input("Target Column: "));

            string firstDefenderPosition = $"({row}, {column - 1})";
            string secondDefenderPosition = $"({row - 1}, {column})";
            string thirdDefenderPosition = $"({row}, {column + 1})";
            string fourthDefenderPosition = $"({row + 1}, {column})";

            Console.WriteLine($"desploy to:\n{firstDefenderPosition}\n{secondDefenderPosition}\n" +
                                         $"{thirdDefenderPosition}\n{fourthDefenderPosition}");

            Console.Beep();
        }
    }
}