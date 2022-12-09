using CSharp_Book_OOP;

internal class Exp3
{
    internal void Exp3Caller()
    {

        //Soup WITH Tupples

        Console.WriteLine("What could we cook? Make a decision: ");

        (Seasoning, Ingridient, FoodType)[] menu = new (Seasoning, Ingridient, FoodType)[4]

            {
                    (Seasoning.Sweet, Ingridient.Carrot, FoodType.Stew),
                    (Seasoning.Spicy, Ingridient.Mushrooms, FoodType.Gumbo),
                    (Seasoning.Salty, Ingridient.Potato, FoodType.Soup),
                    (Seasoning.Salty, Ingridient.Chicken, FoodType.Gumbo)
            };
        for (int i = 0; i < menu.Length; i++)
        {
            Seasoning seasoning;
            Ingridient ingridient;
            FoodType foodType;
            (seasoning, ingridient, foodType) = menu[i];
            Console.WriteLine($"{i + 1}:  {seasoning} {ingridient} {foodType}");         //+1 cause i = 0 in 1st iteration
        }

        while (true)
        {
            string answer = Program.InputLine("So, what will it be? Choose a number.  ");
            switch (answer)
            {
                case "1":
                    Console.WriteLine("Are you a bunny? hehe");
                    break;
                case "2":
                    Console.WriteLine("mmm... mushrooms... spicy!");
                    break;
                case "3":
                    Console.WriteLine("Potatoes are not healthy food");
                    break;
                case "4":
                    Console.WriteLine("Some meat won't hurt it");
                    break;
                default:
                    Console.WriteLine("I don't understand, choose a number from the menu pls");
                    continue;
            }
            break;
        }
    }
}