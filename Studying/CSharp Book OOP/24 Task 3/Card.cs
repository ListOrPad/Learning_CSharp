public class Card
{
    public CardRank Rank { get; set; }
    public CardColor Color { get; set; }

    public CardRank One { get; } = CardRank.One;
    public CardRank Two { get; } = CardRank.Two;
    public CardRank Three { get; } = CardRank.Three;
    public CardRank Four { get; } = CardRank.Four;
    public CardRank Five { get; } = CardRank.Five;
    public CardRank Six { get; } = CardRank.Six;
    public CardRank Seven { get; } = CardRank.Seven;
    public CardRank Eight { get; } = CardRank.Eight;
    public CardRank Nine { get; } = CardRank.Nine;
    public CardRank Ten { get; } = CardRank.Ten;
    public CardRank Dollar { get; } = CardRank.Dollar;
    public CardRank Percent { get; } = CardRank.Percent;
    public CardRank Caret { get; } = CardRank.Caret;
    public CardRank Ampersand { get; } = CardRank.Ampersand;

    public CardColor Red { get; } = CardColor.Red;
    public CardColor Blue { get; } = CardColor.Blue;
    public CardColor Green { get; } = CardColor.Green;
    public CardColor Yellow { get; } = CardColor.Yellow;

    public CardRank[] GetRanks() 
    {
        return new[] { One, Two, Three, Four, Five, Six, Seven, Eight,
                        Nine, Ten, Dollar, Percent, Caret, Ampersand };
    }
    public CardColor[] GetColors()
    {
        return new[] { Red, Blue, Green, Yellow };
    }

    public Card() { }
    public Card(CardRank rank, CardColor color)
    {
        Rank = rank;
        Color = color;
    }
}