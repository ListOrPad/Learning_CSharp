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
        static void DisplayInfo(int _round, int _cityHP, int _bossHP, int _canonDamage)
        {
            Console.WriteLine($"STATUS: Round: {_round} City: {_cityHP}/15 Manticore: {_bossHP}/10\n" +
                    $"The Canon is expected to deal {_canonDamage} damage this round");
        }

        static int OpenFire(int _manticoreDistance, int _bossHP, int _canonDamage)
        {

            Console.Write("Enter the desired Canon range ( 0 to 100 ): ");
            int canonTarget = Convert.ToInt32(Console.ReadLine());
            if (canonTarget > _manticoreDistance)
            {
                Console.WriteLine("That round OVERSHOT the target");
                return _bossHP;
            }
            else if (canonTarget < _manticoreDistance)
            {
                Console.WriteLine("That round FELL SHORT of the target");
                return _bossHP;
            }
            else
            {
                return _bossHP -= _canonDamage;
                Console.WriteLine("This round was a direct HIT");
            }
        }
        static void ShowResult()
        {

        }
        static void Main(string[] args)
        {
            //ALERT
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

                //Calculating canonDamage this round
                int canonDamage = CalcCanonDmg(round);

                //Display Info, Status this round
                DisplayInfo(round, cityHP, bossHP, canonDamage);

                //(opening the fire) giving feedback on an attack, updating bossHP if needed
                bossHP = OpenFire(manticoreDistance, bossHP, canonDamage);

                //Updating cityHP in the end of the round
                cityHP--;

                // Show Results:
                if (bossHP <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("The Manticore was destroyed! The city of Consolas has been saved!");
                    Console.ReadKey(true);
                    break;
                }
                else if (cityHP <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You've lost! Push any key, then try again.");
                    Console.ReadKey(true);
                    break;
                }
            }
        }
    }
}