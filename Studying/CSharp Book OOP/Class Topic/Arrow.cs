public class Arrow
{

    private Arrowhead _arrowhead;
    private Fletching _fletching;
    private float _shaftLength;
    public Arrow(Arrowhead arrowhead, Fletching fletching, float shaftLength)
    {
        _arrowhead = arrowhead;
        _fletching = fletching;
        _shaftLength = shaftLength;
    }
    
   
    public float GetCost()
    {
        float arrowHeadCost = 0;
        if (_arrowhead == Arrowhead.steel) arrowHeadCost = 10;
        if (_arrowhead == Arrowhead.obsidian) arrowHeadCost = 5;
        if (_arrowhead == Arrowhead.wooden) arrowHeadCost = 3;

        float fletchingCost = 0;
        if (_fletching == Fletching.plastic) fletchingCost = 10;
        if (_fletching == Fletching.turkeyFeathers) fletchingCost = 5;
        if (_fletching == Fletching.gooseFeathers) fletchingCost = 3;

      float shaftCost = 0.05f * _shaftLength;

        float price = shaftCost + arrowHeadCost + fletchingCost;
        return price;
    }


}