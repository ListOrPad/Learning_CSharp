namespace _24_Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for starting password
            Console.Write("Enter the starting password: ");
            int password = Convert.ToInt32(Console.ReadLine());

            //create Door instance
            Door door = new Door(password);

            //text commands
            while (true)
            {
                Console.WriteLine($"The door is {door.State}, your actions?\n" +
                    $"(try \"open\", \"close\", \"unlock\", \"lock\")"); 
                string input = Console.ReadLine();
                if (door.State == DoorState.Locked && input == "unlock")
                {
                    door.State = door.UnlockDoor();
                }
                if (door.State == DoorState.Closed && input == "lock")
                {
                    door.State = door.LockDoor();
                }
                if (door.State == DoorState.Closed && input == "open")
                {
                    door.State = door.OpenDoor();
                }
                if (door.State == DoorState.Open && input == "close")
                {
                    door.State = door.CloseDoor();
                }
                if (door.State == DoorState.Locked)
                {
                    Console.WriteLine("The door is locked, would you like to change the password now?\n" +
                        "(y/n)");
                    string changeReply = Console.ReadLine();
                    if (changeReply == "y")
                    {
                        door.ChangePassword();
                    }
                    else continue;
                }
            }

        }
    }
}