using System.Diagnostics;

namespace Switches_book_task
{
    internal class Program
    {
        static string InputNoLine(string text)
        {
            Console.Write(text);
            string input = Console.ReadLine();
            return input;
        }
        static void ShowItemPrice(int choice)
        {

            string item = choice switch
            {
                1 => "Rope",
                2 => "Torches",
                3 => "Climbing Equipment",
                4 => "Clean Water",
                5 => "Machete",
                6 => "Canoe",
                7 => "Food supplies"
            };

            int price = item switch
            {
                "Rope" => 10,
                "Torches" => 15,
                "Climbing Equipment" => 25,
                "Clean Water" => 1,
                "Machete" => 20,
                "Canoe" => 200,
                "Food supplies" => 1
            };


            Console.WriteLine("What is you name btw?");
            string name = Console.ReadLine();

            if (name == "ListOrPad")
                Console.WriteLine($"For you, my friend, the {item} price is twice cheaper! it's {price / 2} gold.");
            else
                Console.WriteLine($"{item} cost {price} gold");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("The following Items are available:\n" +
                "1 - Rope\n" +
                "2 - Torches\n" +
                "3 - Climbing Equipment\n" +
                "4 - Clean Water\n" +
                "5 - Machete\n" +
                "6 - Canoe\n" +
                "7 - Food supplies");
            int choice = Convert.ToInt32(InputNoLine("What item do you want to see the price of? "));
            ShowItemPrice(choice);

        }
    }
}