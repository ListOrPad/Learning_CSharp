using System.Runtime.InteropServices;
using System.Threading;

namespace _24_Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //prepare ranks and colors for the card object
            CardRank[] ranks = new CardRank[] {CardRank.One, CardRank.Two, CardRank.Three, CardRank.Four, CardRank.Five,
                CardRank.Six, CardRank.Seven, CardRank.Eight, CardRank.Nine, CardRank.Ten, CardRank.DollarSign, CardRank.Percent,
                CardRank.Percent, CardRank.Ampersand } ;
            CardColor[] colors = new CardColor[] { CardColor.Red, CardColor.Green, CardColor.Blue, CardColor.Yellow } ;

            //Dispay full deck
            foreach (CardRank rank in ranks)
            {
                foreach (CardColor color in colors)
                {
                    Card card = new Card(rank, color);
                    Console.WriteLine($"The {card.Color} {card.Rank}");
                }
            }
        }
    }
}