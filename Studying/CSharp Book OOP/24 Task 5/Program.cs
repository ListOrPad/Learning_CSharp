namespace _24_Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //password validator task
            while(true)
            {
                PasswordValidator validator = new PasswordValidator();

                Console.Write("Enter the password to check. ");
                validator.Password = Console.ReadLine();

                if (validator.Password == null) break;

                string validOrNot = validator.TellIfValid(validator.Password);
                Console.WriteLine($"This password is {validOrNot}");
            }

        }
    }
}