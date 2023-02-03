using System.Text;

namespace Manticore_with_methods
    {
        internal class Program
    {
        static string Input(string text)
        {
            Console.WriteLine(text);
            string input = Console.ReadLine();
            return input;
        }

        static int CalcCanonDmg(int round)
        {
            if (round % 3 == 0) //fire attack
            {
                return 3;
            }
            else if (round % 5 == 0) //electric
            {
                return 5;
            }
            else if (round % 3 == 0 && round % 5 == 0) //COMBO
            {
                return 10;
            }
            else return 1; //normal attack
        }
        static void DisplayInfo(int round, int cityHP, int bossHP, int canonDamage)
        {
            Console.WriteLine($"STATUS: Round: {round} City: {cityHP}/15 Manticore: {bossHP}/10\n" +
                    $"The Canon is expected to deal {canonDamage} damage this round");
        }

        static void OpenFire(int manticoreDistance, int bossHP, int canonDamage)
        {

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
        }
        static void Main(string[] args)
        {
            //ALRT
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
                //Move to the next round
                round++;

                //Calculating canonDamage
                int canonDamage = CalcCanonDmg(round);

                //Display Info, Status
                DisplayInfo(round, cityHP, bossHP, canonDamage);

                //opening the fire
                OpenFire(manticoreDistance, bossHP, canonDamage);

                // Conclusions in the end of the turn:
                if (bossHP <= 0)
                {
                    Console.WriteLine("The Manticore was destroyed! The city of Consolas has been saved!");
                    Console.ReadKey(true);
                    break;
                }
                else if (cityHP <= 0)
                {
                    Console.WriteLine("You've lost! Push any key, then try again.");
                    Console.ReadKey(true);
                    break;
                }
                else
                    cityHP--;
            }
        }
    }
}