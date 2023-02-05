namespace Enumerations_challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //the initial sate of the chest
            ChestState chestState = ChestState.Locked;
            Console.WriteLine("Try using commands \"unlock\", \"open\", \"close\" and \"lock\"");

            //switching between states forever
            while (true)
            {
                string action;
                if (chestState == ChestState.Locked)
                {
                    Console.WriteLine("The chest is locked. What do you want to do?");
                    action = Console.ReadLine();
                    if (action == "unlock")
                        //as a result..
                        chestState = ChestState.Unlocked;
                }


                if (chestState == ChestState.Unlocked)
                {
                    Console.WriteLine("The chest is unlocked. What do you want to do?");
                    action = Console.ReadLine();
                    if (action == "lock")
                        chestState = ChestState.Locked;
                    else if (action == "open")
                        chestState = ChestState.Open;
                }


                if (chestState == ChestState.Open)
                {
                    Console.WriteLine("The chest is open. What do you want to do?");
                    action = Console.ReadLine();
                    if (action == "close")
                        chestState = ChestState.Unlocked;
                }
            }
        }
    }
}