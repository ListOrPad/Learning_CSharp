namespace Polymprphism_challenge_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //robot polymorphism challenge the way it was intended
            while(true)
            {
                Robot robot = new Robot();

                int i = 0;
                while (true)
                {
                    string? input = Console.ReadLine();
                    if (input == "stop")
                    {
                        break;
                    }

                    IRobotCommand newCommand;
                    newCommand = input switch
                    {
                        "on" => new OnCommand(),
                        "off" => new OffCommand(),
                        "north" => new NorthCommand(),
                        "south" => new SouthCommand(),
                        "west" => new WestCommand(),
                        "east" => new EastCommand(),
                        "stop" => new StopCommand(),
                        _ => new OffCommand(),
                    };

                    robot.Commands.Add(newCommand);
                    i++;
                }

                robot.Run();
            }
        }
    }
}