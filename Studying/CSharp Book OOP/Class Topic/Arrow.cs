public class Arrow
{

    private Arrowhead arrowhead;
    private Fletching fletching;
    private int shaftLength;

    private float price;
    public Arrow()
    {
        arrowhead = GetArrowhead();
        fletching = GetFletching();
        shaftLength = GetLength();

        price = GetCost();
    }
    public string Input(string text)
    {
        //It writes text then you make an input
        Console.WriteLine(text);
        string input = Console.ReadLine();
        return input;
    }
    public Arrowhead GetArrowhead()
    {
        string choice = Input("Choose an arrowhead: wooden, steel or obsidian");
        while (true)
        {
            switch (choice)
            {
                case "wooden":
                    return Arrowhead.wooden;
                    break;
                case "steel":
                    return Arrowhead.steel;
                    break;
                case "obsidian":
                    return Arrowhead.obsidian;
                    break;
                default:
                    Console.WriteLine("Try choosing a more fitting answer.");
                    continue;                
                    //Check this code if working THE CORRECT way
                    //It has to repeat switch if the CASE is not fitting
            } 
        }
    }

    public Fletching GetFletching()
    {

    }

    public int GetLength()
    {
        int cm;
        do
        {
            cm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please choose the length of an arrow,\n" +
                "it should be shorter than 100 cm and longer than 60 cm");
        }
        while (cm < 60 && cm > 100);

        return cm;

    }

    public float GetCost()
    {
        float ShaftCost = 0.05f * cm;
    }


}