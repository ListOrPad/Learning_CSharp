public class OnCommand : RobotCommand
{
    public int X { get; set; }
    public int Y { get; set; }      //maybe make a tuple (int x, int y) Coordinates ?
    public string? Command { get; set; }
    public OnCommand(Robot robot)
    {
        Command = Console.ReadLine();
        

        //create an object accordingly to text prompt
        if (Command == "on")
        {
            robot.IsPowered = true;
        }

        if (Command == "north")
        {
            Y = NorthCommand(robot, this);
        }
        if (Command == "south")
        {
            Y = SouthCommand(robot, this);
        }
        if (Command == "west")
        {
            X = WestCommand(robot, this);
        }
        if (Command == "east")
        {
            X = EastCommand(robot, this);
        }
    }
    public override void Run(Robot robot)
    {
        //update each command object with used back then coordinates
        robot.X += X;
        robot.Y += Y;
    }
    
}