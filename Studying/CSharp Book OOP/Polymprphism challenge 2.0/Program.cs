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

                for (int i = 0; i < robot.Commands.Length; i++)
                {
                    string? input = Console.ReadLine();

                    IRobotCommand newCommand;
                    newCommand = input switch
                    {
                        "on" => new OnCommand(),
                        "off" => new OffCommand(),
                        "north" => new NorthCommand(),
                        "south" => new SouthCommand(),
                        "west" => new WestCommand(),
                        "east" => new EastCommand(),
                        _ => new OffCommand(),
                    };
                    robot.Commands[i] = newCommand;
                }

                robot.Run();
            }


        }
    }
}