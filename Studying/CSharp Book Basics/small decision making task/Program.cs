namespace small_decision_making_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your number? ");
            int ticking = Convert.ToInt32(Console.ReadLine());
            if (ticking % 2 == 0)
            {
                Console.WriteLine("tick"); 
            }
            else
            {
                Console.WriteLine("tock"); 
            }
        }
    }
}