namespace Polymorphism_challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"The Old Robot" challenge
            //(polymorphism, chapter 26)
            while (true)
            {
                Robot robot = new Robot();

                for (int i = 0; i < robot.Commands.Length; i++)
                {
                    RobotCommand newCommand = new OnCommand(robot);
                    robot.Commands[i] = newCommand;
                }

                
                robot.Run();


            }
        }
    }
}