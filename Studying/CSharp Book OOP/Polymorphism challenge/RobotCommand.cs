public abstract class RobotCommand
{
    public abstract void Run(Robot robot);
    public virtual int NorthCommand(Robot robot)
    {
        if (robot.IsPowered == true)
        {
            return robot.Y++;
        }
        else
        {
            return robot.Y;
        }
    }
    public virtual int SouthCommand(Robot robot)
    {
        if (robot.IsPowered == true)
        {
            return robot.Y--;
        }
        else
        {
            return robot.Y;
        }
    }
    public virtual int WestCommand(Robot robot)
    {
        if (robot.IsPowered == true)
        {
            return robot.X--;
        }
        else
        {
            return robot.X;
        }
    }
    public virtual int EastCommand(Robot robot)
    {
        if (robot.IsPowered == true)
        {
            return robot.X++;
        }
        else
        {
            return robot.X;
        }
    }
}