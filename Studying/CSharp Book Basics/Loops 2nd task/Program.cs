namespace Loops_2nd_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //preparations 
            Console.Title = "The Magic Canon Challenge";
            Console.WriteLine("Push any key");
            Console.ReadKey(true);

            //main loop
            for (int turn = 1; turn <= 100; turn++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                string attack = "Normal";
                if (turn % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    attack = "Fire";
                }
                if (turn % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    attack = "Electric";
                }
                if (turn % 3 == 0 && turn % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    attack = "COMBO";
                }
                Console.WriteLine($"{turn}: {attack}");
            }
                
        }
    }
}