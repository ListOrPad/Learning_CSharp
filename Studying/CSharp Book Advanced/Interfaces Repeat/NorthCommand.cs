﻿public class NorthCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if(robot.IsPowered == true)
        {
            robot.X++;
        }
    }
}