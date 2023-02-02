namespace Manticore__final_for_basics
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
            Console.WriteLine("the guardsman: OH NO! THE MANTICORE IS APPROACHING! TAKE COVER!");
            Console.ReadKey(true);
            Console.Clear();

            //taking initial data, player 1 placing the Manticore
            int bossHP = 10;
            int cityHP = 15;
            int round = 0;
            int manticoreDistance = Convert.ToInt32(
                Input("Player 1, Where would you like to place the airship?\n" +
                "Choose the distance between 0 and 100")
                );
            Console.Clear();

            //player 2 turn
            Console.WriteLine("Player 2, it's your turn");

            while (true)
            {
                round++;

                //Calculating canonDamage
                int canonDamage = 1;
                if (round % 3 == 0)
                {
                    canonDamage = 3;
                }
                if (round % 5 == 0)
                {
                    canonDamage = 5;
                }
                if (round % 3 == 0 && round % 5 == 0)
                {
                    canonDamage = 10;
                }

                //Info
                Console.WriteLine($"STATUS: Round: {round} City: {cityHP}/15 Manticore: {bossHP}/10\n" +
                    $"The Canon is expected to deal {canonDamage} damage this round");
                //opening the fire
                Console.Write("Enter the desired Canon range ( 0 to 100 ): ");
                int canonTarget = Convert.ToInt32(Console.ReadLine());
                if (canonTarget > manticoreDistance)
                    Console.WriteLine("That round OVERSHOT the target");
                if (canonTarget < manticoreDistance)
                    Console.WriteLine("That round FELL SHORT of the target");
                if (canonTarget == manticoreDistance)
                {
                    bossHP -= canonDamage;
                    Console.WriteLine("This round was a direct HIT"); 
                }

                // in the end of the turn:
                if (bossHP <= 0)
                {
                    Console.WriteLine("The Manticore was destroyed! The city of Consolas has been saved!");
                    break;
                }

                else if (cityHP <= 0)
                {
                    Console.WriteLine("You've lost! Try again.");
                    break;
                }
                else
                    cityHP--;
            }
        }
    }
}