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

                //    if (robot.IsPowered == true)
                //    {
                //        robot.Run();
                //    }
                //    else
                //    {
                //        Console.WriteLine("the robot is off, at first, turn it on.");
                //        continue;
                //    } 
                Robot robot = new Robot();

                for (int i = 0; i < robot.Commands.Length; i++)
                {
                    RobotCommand command = new OnCommand();
                    command.Command(robot);
                    robot.Commands[i] = command;
                }

                robot.Run();


            }
        }
    }
}