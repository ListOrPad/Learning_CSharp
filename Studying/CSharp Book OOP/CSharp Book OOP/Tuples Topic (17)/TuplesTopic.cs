using CSharp_Book_OOP;

internal class TuplesTopic : Program
{

    //Simula's soup challenge
    public void Invoke()
    {


    (FoodType type, Ingridient ingridient, Seasoning seasoning) soup = GetSoup();
    Console.WriteLine($"{soup.seasoning} {soup.ingridient} {soup.type}");

    }


    (FoodType, Ingridient, Seasoning) GetSoup()
    {
        FoodType type1 = GetType();
        Ingridient ingridient1 = GetIngridient();
        Seasoning seasoning1 = GetSeasoning();
        return (type1, ingridient1, seasoning1);
    }

    FoodType GetType()
    {
        string input = Input("choose which soup are we going to cook(soup, gumbo, stew)  ");
        return input switch
        {
            "soup" => FoodType.Soup,
            "gumbo" => FoodType.Gumbo,
            "stew" => FoodType.Stew
        };
    }


    Ingridient GetIngridient()
    {
        string input = Input("what ingridient to add? (potato, chicken, mushrooms, carrot)  ");
        return input switch
        {
            "potato" => Ingridient.Potato,
            "chicken" => Ingridient.Chicken,
            "muchrooms" => Ingridient.Mushrooms,
            "carrot" => Ingridient.Carrot
        };
    }


    Seasoning GetSeasoning()
    {
        string input = Input("Choose seasoning (salty, sweet, spicy)  ");
        return input switch
        {
            "salty" => Seasoning.Salty,
            "sweet" => Seasoning.Sweet,
            "spicy" => Seasoning.Spicy
        };
    }
}