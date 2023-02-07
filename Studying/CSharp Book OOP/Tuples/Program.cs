namespace Tuples
{
    internal class Program
    {

        static FoodType GetType()
        {
            while (true)
            {
                Console.Write("What are we cooking? ");
                string input = Console.ReadLine();
                if (input == "Stew") return FoodType.Stew;
                else if (input == "Gumbo") return FoodType.Gumbo;
                else if (input == "Soup") return FoodType.Soup;
                else continue; 
            }
        }

        static MainIngredient GetIngredient()
        {
            while (true)
            {
                Console.Write("What is the main ingredient? ");
                string input = Console.ReadLine();
                if (input == "Mushrooms") return MainIngredient.Mushrooms;
                else if (input == "Chicken") return MainIngredient.Chicken;
                else if (input == "Potatoes") return MainIngredient.Potatoes;
                else if (input == "Carrots") return MainIngredient.Carrots;
                else continue;
            }
        }

        static Seasoning GetSeasoning()
        {
            while (true)
            {
                Console.Write("How does it tastes? ");
                string input = Console.ReadLine();
                if (input == "Salty") return Seasoning.Salty;
                else if (input == "Spicy") return Seasoning.Spicy;
                else if (input == "Sweet") return Seasoning.Sweet;
                else continue;
            }
        }

        static void Main(string[] args)
        {
            //Expected Result:

            //How does it tastes? Sweet
            //What is the main ingrediend? Chicken
            //What are we cooking? Gumbo
            //We are brewing Sweet Chicken Gumbo


            (Seasoning seasoning, MainIngredient ingredient, FoodType type) soup; 
            soup = (GetSeasoning(), GetIngredient(), GetType());
            Console.WriteLine($"We are brewing {soup.seasoning} {soup.ingredient} {soup.type}");
        }
    }
}