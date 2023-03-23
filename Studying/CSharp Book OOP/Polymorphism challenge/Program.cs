namespace Polymorphism_challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"The Old Robot" challenge
            //(polymorphism, chapter 26)
            while (true)
            {
                OnCommand command = new OnCommand();

                string? firstCommand;
                do
                {
                    Console.WriteLine("Turn the robot on or off?");
                    firstCommand = Console.ReadLine();
                }
                while (firstCommand != "on" && firstCommand != "off");

                string? secondCommand;
                do
                {
                    Console.WriteLine("first direction command");
                    secondCommand = Console.ReadLine();
                }
                while (secondCommand != "north" && secondCommand != "south" && secondCommand != "west" && secondCommand != "east");

                string? thirdCommand;
                do
                {
                    Console.WriteLine("second direction command");
                    thirdCommand = Console.ReadLine();
                }
                while (thirdCommand != "north" && thirdCommand != "south" && thirdCommand != "west" && thirdCommand != "east");

                Robot robot = new Robot();

                if (firstCommand == "on")
                {
                    robot.IsPowered = true;
                }

                robot.Y = secondCommand switch           // '+=' ???? is this a correct operator or just '=' is correct?
                {
                    "north" => command.NorthCommand(robot),
                    "south" => command.SouthCommand(robot),
                    _ => robot.Y
                };
                robot.X = secondCommand switch
                {
                    "west" => command.WestCommand(robot),
                    "east" => command.EastCommand(robot),
                    _ => robot.X
                };

                robot.Y += thirdCommand switch
                {
                    "north" => command.NorthCommand(robot),
                    "south" => command.SouthCommand(robot),
                    _ => robot.Y
                };
                robot.X += thirdCommand switch
                {
                    "west" => command.WestCommand(robot),
                    "east" => command.EastCommand(robot),
                    _ => robot.X
                };


                if (robot.IsPowered == true)
                {
                    robot.Run();
                }
                else
                {
                    Console.WriteLine("the robot is off, first, turn it on.");
                    continue;
                } 



            }
        }
    }
}