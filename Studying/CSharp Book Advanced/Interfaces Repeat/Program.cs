namespace Interfaces_Repeat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();
            while (true)
            {
                Console.WriteLine($"Enter command 1");
                string inputPowerCommand = Console.ReadLine();
                if (inputPowerCommand == "on" || inputPowerCommand == "off")
                {
                    switch (inputPowerCommand)
                    {
                        case "on":
                            robot.Commands[0] = new OnCommand();
                            break;
                        case "off":
                            robot.Commands[0] = new OffCommand();
                            break;
                    }
                }
                else if (robot.Commands[0] != new OnCommand() || robot.Commands[0] != new OffCommand())
                {
                    Console.WriteLine("Turn the robot \"on\" or \"off\"");
                    continue;
                }
                for (int i = 1; i <= robot.commandCount; i++)
                {
                    Console.WriteLine($"Enter Command {i+1}");
                    string input = Console.ReadLine();
                    switch (input)
                    {
                        case "north":
                            robot.Commands[i] = new NorthCommand();
                            break;
                        case "south":
                            robot.Commands[i] = new SouthCommand();
                            break;
                        case "west":
                            robot.Commands[i] = new WestCommand();
                            break;
                        case "east":
                            robot.Commands[i] = new EastCommand();
                            break;
                    }
                }
                robot.Run();
            }
        }
    }
}