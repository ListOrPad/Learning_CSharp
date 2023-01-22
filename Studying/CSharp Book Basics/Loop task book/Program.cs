namespace Loop_task_book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user 1 move
            int chosenNumber;

            do
            {
                Console.Write("User 1, enter a number between 0 and 100 ");
                chosenNumber = Convert.ToInt32(Console.ReadLine());
            }
            while (chosenNumber < 0 || chosenNumber > 100);

                Console.Clear();

            // user 2 move
            Console.Write("User 2, guess the number. ");
            int guessedNumber;

            while(true)
            {
                guessedNumber = Convert.ToInt32(Console.ReadLine());
                if (guessedNumber < chosenNumber)
                {
                    Console.WriteLine($"{guessedNumber} is too low");
                    Console.Write("What is your next guess? ");
                }
                if (guessedNumber > chosenNumber)
                {
                    Console.WriteLine($"{guessedNumber} is too high");
                    Console.Write("What is your next guess? ");
                }
                if (guessedNumber == chosenNumber)
                {
                    Console.WriteLine("You guessed the number! Congratz!");
                    break;
                }

            }

        }
    }
}