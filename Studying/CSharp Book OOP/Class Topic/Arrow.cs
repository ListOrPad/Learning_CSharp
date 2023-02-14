public class Arrow
{
    public Arrowhead ArrowheadProperty { get; set; }
    public Fletching FletchingProperty { get; set; }
    public float ShaftLength { get; set; }
    public Arrow(Arrowhead arrowhead, Fletching fletching, float shaftLength)
    {
        ArrowheadProperty = arrowhead;
        FletchingProperty = fletching;
        ShaftLength = shaftLength;
    }

    public float GetCost()
    {
        float arrowHeadCost = 0;
        if (ArrowheadProperty == Arrowhead.steel) arrowHeadCost = 10;
        if (ArrowheadProperty == Arrowhead.obsidian) arrowHeadCost = 5;
        if (ArrowheadProperty == Arrowhead.wooden) arrowHeadCost = 3;

        float fletchingCost = 0;
        if (FletchingProperty == Fletching.plastic) fletchingCost = 10;
        if (FletchingProperty == Fletching.turkeyFeathers) fletchingCost = 5;
        if (FletchingProperty == Fletching.gooseFeathers) fletchingCost = 3;

      float shaftCost = 0.05f * ShaftLength;

        float price = shaftCost + arrowHeadCost + fletchingCost;
        return price;
    }
}
