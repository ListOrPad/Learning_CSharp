public class Robot
{
    public int X { get; set; }
    public int Y { get; set; }
    public bool IsPowered { get; set; }
    public RobotCommand?[] Commands { get; } = new RobotCommand?[3];
    public void Run()
    {
        foreach (RobotCommand? command in Commands)
        {
            command?.Run(this);                                 //this method should contain information of all 3 commands
            Console.WriteLine($"[{X} {Y} {IsPowered}]");
        }
    }

}