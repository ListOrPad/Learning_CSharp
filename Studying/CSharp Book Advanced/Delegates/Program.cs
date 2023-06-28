namespace Delegates
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Delegates Challenge: "The Sieve"
            Console.WriteLine("Select a filter, type in: \"evens\",\"absolutes\" or \"decimals\"");
            string filter = Console.ReadLine();
            Sieve sieve =  new Sieve(Sieve.SieveEvens);
            switch (filter)
            {
                case "evens":
                    sieve = new Sieve(Sieve.SieveEvens);
                    break;
                case "absolutes":
                    sieve = new Sieve(Sieve.SieveAbsolutes);
                    break;
                case "decimals":
                    sieve = new Sieve(Sieve.SieveDecimals);
                    break;
            }
            while (true)
            {
                Console.WriteLine("Enter any number and see if it is good for the chosen filter.");

                int number = Convert.ToInt32(Console.ReadLine());
                if (sieve.IsGood(number))
                {
                    Console.WriteLine("The number is good");
                }
                else
                {
                    Console.WriteLine("The number is evil");
                }
            }
        }
    }
}