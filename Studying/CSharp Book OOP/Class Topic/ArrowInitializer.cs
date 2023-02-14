public class ArrowInitializer
{

    public string? Input(string text)
    {
        //It writes text then you make an input
        Console.WriteLine(text);
        string? input = Console.ReadLine();
        if (input != null)
            return input;
        else
            return null;
    }

    public static Arrow CreateEliteArrow()
    {
        return new Arrow(Arrowhead.steel, Fletching.plastic, 95);
    }
    public static Arrow CreateBeginnerArrow()
    {
        return new Arrow(Arrowhead.wooden, Fletching.gooseFeathers, 75);
    }
    public static Arrow CreateMarksmanArrow()
    {
        return new Arrow(Arrowhead.steel, Fletching.gooseFeathers, 65);
    }

    public Arrowhead GetArrowhead()
    {

        while (true)
        {
            string choice = Input("Choose an arrowhead: wooden, steel or obsidian");
            switch (choice)
            {
                case "wooden":
                    return Arrowhead.wooden;
                case "steel":
                    return Arrowhead.steel;
                case "obsidian":
                    return Arrowhead.obsidian;
                default:
                    Console.WriteLine("Try typing a more fitting answer.");
                    continue;
            }
        }
    }

    public Fletching GetFletching()
    {

        while (true)
        {
            string choice = Input("Choose fletching: plastic, turkey, goose");
            switch (choice)
            {
                case "plastic":
                    return Fletching.plastic;
                case "turkey":
                    return Fletching.turkeyFeathers;
                case "goose":
                    return Fletching.gooseFeathers;
                default:
                    Console.WriteLine("Try typing a more fitting answer.");
                    continue;
            }
        }
    }

    public float GetLength()
    {
        float cm;
        do
        {
            Console.WriteLine("Please choose the length of an arrow,\n" +
                "it should be shorter than 100 cm and longer than 60 cm");
            cm = Convert.ToSingle(Console.ReadLine());

        }
        while (cm < 60 || cm > 100);

        return cm;

    }

    public Arrow GetCustomArrow()
    {
        Arrowhead arrowhead = GetArrowhead();
        Fletching fletching = GetFletching();
        float shaftLength = GetLength();
        return new Arrow(arrowhead, fletching, shaftLength);
    }
}
