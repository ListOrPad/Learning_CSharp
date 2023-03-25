public abstract class RobotCommand : Robot
{
    public abstract void Run(Robot robot);
    public virtual void Command(Robot robot)
    {

    }
    public int NorthCommand(Robot robot)
    {
        if (robot.IsPowered == true)
        {
            return ++robot.Y;
        }
        else
        {
            return robot.Y;
        }
    }
    public int SouthCommand(Robot robot)
    {
        if (robot.IsPowered == true)
        {
            return --robot.Y;
        }
        else
        {
            return robot.Y;
        }
    }
    public int WestCommand(Robot robot)
    {
        if (robot.IsPowered == true)
        {
            return --robot.X;
        }
        else
        {
            return robot.X;
        }
    }
    public int EastCommand(Robot robot)
    {
        if (robot.IsPowered == true)
        {
            return ++robot.X;
        }
        else
        {
            return robot.X;
        }
    }
}