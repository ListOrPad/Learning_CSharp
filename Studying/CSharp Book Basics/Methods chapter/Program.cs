namespace Methods_chapter
{
    internal class Program
    {
        public int AskForNumber(string text)
        {
            Console.WriteLine(text);
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }
        public int AskForNumberInRange(string text, int min, int max)
        {
            while (true)
            {
                Console.WriteLine(text);
                int number = Convert.ToInt32(Console.ReadLine());
                if (number > min && number < max)
                    return number; 
            }

        }
        static void Main(string[] args)
        {
           int pick = AskForNumber("Which number would you pick?");
        }
    }
}