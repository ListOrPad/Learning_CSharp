public class OnCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        robot.IsPowered = true;
    }

    //public override int NorthCommand(Robot robot)
    //{
    //    return base.NorthCommand(robot);
    //}

    //public override int SouthCommand(Robot robot)
    //{
    //    return base.SouthCommand(robot);
    //}

    //public override int WestCommand(Robot robot)
    //{
    //    return base.WestCommand(robot);
    //}

    //public override int EastCommand(Robot robot)
    //{
    //    return base.EastCommand(robot);
    //}
}