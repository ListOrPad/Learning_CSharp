namespace Inheritance_challenge_26_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Packing inventory challenge
            Pack pack = new Pack(6, 15f, 15.75f);
            while (true)
            {
                InventoryItem item;
                Console.WriteLine("What would you like to add to your pack?\n" +
                                     "(type in: sword, arrow, bow, rope, food, water)");
                string itemChoice = Console.ReadLine();
                item = itemChoice switch
                {
                    "sword" => new Sword(),
                    "arrow" => new Arrow(),
                    "water" => new Water(),
                    "food" => new Food(),
                    "bow" => new Bow(),
                    "rope" => new Rope(),
                };
                if (pack.Add(item))
                {
                    Console.WriteLine($"{itemChoice} successfully added to inventory!");
                }
                else
                {
                    Console.WriteLine("Failed to add: The inventory is full.");
                    break;
                }
            }



        }
    }
}