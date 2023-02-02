namespace Countdown_method_challenge
{
    internal class Program
    {
        //whats the task?
        //Write code that counts down from 10 to 1


        static void CountDown(int startNumber)
        {
            if (startNumber == 0) return;
            Console.WriteLine(startNumber);
            CountDown(startNumber - 1);
        }


        static void Main(string[] args)
        {
            //initial code
            for (int x = 10; x > 0; x--)
                Console.WriteLine(x);
            //here goes our method
            CountDown(10);
        }
    }
}