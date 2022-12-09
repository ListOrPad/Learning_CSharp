
using CSharp_Book_OOP;
using System;

internal class Arrow

{
    public Arrowhead Arrowhead { get; }
    public Fletching Fletching { get; }
    public float Length { get; }

    public Arrow(Arrowhead arrowhead, Fletching fletching, float shaftLength)
    {
        Arrowhead = arrowhead;
        Fletching = fletching;
        Length = shaftLength;
    }

    public Arrow CreateCustomArrow()
    {
        Arrowhead arrowhead = GetArrowhead();
        Fletching fletching = GetFletching();
        float shaftLength = GetShaft();

        return new Arrow(arrowhead, fletching, shaftLength);
    }

    public Arrowhead GetArrowhead()
        {
            string inputArrowhead = Program.Input("Choose an arrowhead type(wooden, steel, obsidian)  ");
            return inputArrowhead switch
            {
                "wooden" => Arrowhead.Wooden,
                "steel" => Arrowhead.Steel,
                "obsidian" => Arrowhead.Obsidian
            };
        } 

    public Fletching GetFletching()
    {
        string inputFletching = Program.Input("Choose the fletching(turkey feathers, goose feathers, plastic  ");
        return inputFletching switch
        {
            "turkey feathers" => Fletching.TurkeyFeathers,
            "goose feathers" => Fletching.GooseFeathers,
            "plastic" => Fletching.Plastic
        };
    }
    public float GetShaft()
    {
        while (true)
        {
            string inputShaft = Program.Input("Choose the length of the shaft. it should be between 60 and 100 cm ");
            float shaftLen = Convert.ToSingle(inputShaft);
            if (shaftLen >= 60 && shaftLen <= 100)
                return shaftLen;
            else
                Console.WriteLine("Wrong length.(60 to 100 cm)");
        }
    }


    public float Price
    {
        get
        {
            float arrowheadCost = 0;
            float fletchingCost = 0;

            if (Arrowhead == Arrowhead.Wooden)
                arrowheadCost = 3;
            else if (Arrowhead == Arrowhead.Steel)
                arrowheadCost = 10;
            else if (Arrowhead == Arrowhead.Obsidian)
                arrowheadCost = 5;

            if (Fletching == Fletching.TurkeyFeathers)
                fletchingCost = 5;
            else if (Fletching == Fletching.Plastic)
                fletchingCost = 10;
            else if (Fletching == Fletching.GooseFeathers)
                fletchingCost = 3;


            float shaftCost = Length * 0.05f;

            float totalCost = arrowheadCost + fletchingCost + shaftCost;
            return totalCost;
        } 
    }


    public Arrow CreateEliteArrow()
    {
        return new Arrow(Arrowhead.Steel, Fletching.Plastic, 95);
    }

    public Arrow CreateMarksmanArrow()
    {
        return new Arrow(Arrowhead.Steel, Fletching.GooseFeathers, 65);
    }

    public Arrow CreateBeginnerArrow()
    {
        return new Arrow(Arrowhead.Wooden, Fletching.GooseFeathers, 75);
    }

    public Arrow GetArrow()
    {
        string arrowChoice = Program.Input("Choose your arrow or create a custom one ");
        return arrowChoice switch
        {
            "elite" => CreateEliteArrow(),
            "marksman" => CreateMarksmanArrow(),
            "beginner" => CreateBeginnerArrow(),
            "custom" => CreateCustomArrow()
        };
    }

}