public class OnCommand : RobotCommand
{
    public override void Run(Robot robot)

    {

    }
    public override void Command(Robot robot)
    {
        string? command;

        command = Console.ReadLine();

        if (command == "on")
        {
            robot.IsPowered = true;
        }

        robot.Y = command switch
        {
            "north" => NorthCommand(robot),
            "south" => SouthCommand(robot),
            _ => robot.Y
        };
        robot.X = command switch
        {
            "west" => WestCommand(robot),
            "east" => EastCommand(robot),
            _ => robot.X
        }; 
    }

}