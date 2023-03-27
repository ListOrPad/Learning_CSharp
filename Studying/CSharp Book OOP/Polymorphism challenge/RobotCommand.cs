public abstract class RobotCommand
{
    public abstract void Run(Robot robot);
    public int NorthCommand(Robot robot, OnCommand command)
    {
        if (robot.IsPowered == true)
        {
            return ++command.Y;
        }
        else
        {
            return command.Y;
        }
    }
    public int SouthCommand(Robot robot, OnCommand command)
    {
        if (robot.IsPowered == true)
        {
            return --command.Y;
        }
        else
        {
            return command.Y;
        }
    }
    public int WestCommand(Robot robot, OnCommand command)
    {
        if (robot.IsPowered == true)
        {
            return --command.X;
        }
        else
        {
            return command.X;
        }
    }
    public int EastCommand(Robot robot, OnCommand command)
    {
        if (robot.IsPowered == true)
        {
            return ++command.X;
        }
        else
        {
            return command.X;
        }
    }
}