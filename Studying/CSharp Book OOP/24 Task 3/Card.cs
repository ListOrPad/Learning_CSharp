public class Card
{
    public CardRank Rank { get; set; }
    public CardColor Color { get; set; }

    public Card(CardRank rank, CardColor color)
    {
        Rank = rank;
        Color = color;
    }

    public bool IsSymbol()
    {
        return Rank == CardRank.DollarSign || Rank == CardRank.Percent || Rank == CardRank.Caret || Rank == CardRank.Ampersand;
    }

    public bool IsNumber()
    {
        return !IsSymbol();
    }
}