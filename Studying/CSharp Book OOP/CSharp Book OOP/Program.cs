namespace CSharp_Book_OOP
{

    
    internal class Program
    {
        public static string Input(string text)
        {
            Console.Write(text);

            string input = Console.ReadLine();

            return input;
        }

        public static string InputLine(string text)
        {
            Console.WriteLine(text);

            string input = Console.ReadLine();

            return input;
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Object-Oriented Programming Player Guide CSharp Book";
            Console.WriteLine("Press any button to start");
            Console.ReadKey(true);





            // Experiment == piece of code
            ExperimentCaller invoker = new ExperimentCaller();
            invoker.CallExp8();
            invoker.CallExp7();
            //invoker.CallExp6();
            invoker.CallExp5();
            invoker.CallExp2();
            invoker.CallExp1();
            invoker.CallExp3();
            invoker.CallExp4();





            Arrow arrow = new Arrow(Arrowhead.Steel, Fletching.Plastic, 77);
            arrow = arrow.GetArrow();
            Console.WriteLine($"Your arrow costs {arrow.Price} gold");

            TuplesTopic tuplesTopicInvoker = new TuplesTopic();
            tuplesTopicInvoker.Invoke();

            EnumerationsTopic enumerationsTopicInvoker = new EnumerationsTopic();
            enumerationsTopicInvoker.Invoke();
            
        }
    }
}