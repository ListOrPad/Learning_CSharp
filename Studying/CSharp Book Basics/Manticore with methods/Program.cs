using System.Text;

namespace Manticore_with_methods
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            MethodCollection method = new MethodCollection();
            //ALERT
            Console.WriteLine("the guardsman: OH NO! THE MANTICORE IS APPROACHING! TAKE COVER!");
            Console.ReadKey(true);
            Console.Clear();

            //taking initial data, player 1 placing the Manticore
            int bossHP = 10;
            int cityHP = 15;
            int round = 0;

            Random random = new Random();
            int manticoreDistance = random.Next(0, 101);
            //int manticoreDistance = Convert.ToInt32(
            //method.Input("Player 1, Where would you like to place the airship?\n" +
            //"Choose the distance between 0 and 100")
            //);
            Console.Clear();


            //player 2 turn
            Console.WriteLine("Player 2, it's your turn");

            while (true)
            {
                //Move to the next round
                round++;

                //Calculating canonDamage this round
                int canonDamage = method.CalcCanonDmg(round);

                //Display Info, Status this round
                method.DisplayInfo(round, cityHP, bossHP, canonDamage);

                //(opening the fire) giving feedback on an attack, updating bossHP if needed
                bossHP = method.OpenFire(manticoreDistance, bossHP, canonDamage);

                //Updating cityHP in the end of the round
                cityHP--;

                // Show Results:
                if (method.ShowResult(bossHP, cityHP))
                {
                    break;
                }
            }
        }
    }
}