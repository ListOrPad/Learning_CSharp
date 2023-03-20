namespace Inheritance_challenge_26_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Packing inventory challenge
            Pack pack = new Pack(6, 20F, 16.5F);
            while (true)
            {
                InventoryItem item;
                Console.WriteLine($"Your pack has \n" +
                    $"{pack.CurrentItemsCount}/{pack.MaxItems} items, {pack.CurrentWeight}/{pack.MaxWeight} weight, {pack.CurrentVolume}/{pack.MaxVolume} volume.\n" +
                    $"What would you like to add to your pack? (type in: sword, arrow, bow, rope, food, water)");
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
                    pack.DisplayContents();
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