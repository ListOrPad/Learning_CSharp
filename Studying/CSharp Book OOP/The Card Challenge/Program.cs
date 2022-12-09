using System.Drawing;

namespace The_Card_Challenge
{
    internal class Program
    {
        public void CardCount()
        {

        }
        static void Main(string[] args)
        {
            Card[] cards = new Card[52];      // Do I need this line?
            Card card = new Card();

            int x = 0;

            for (int i = 0; i < cards.Length; i++)  
            {



                card.Rank = (CardRank)x;    
                card.Color = (CardColor)i; //how to reset counter to 0 after i = 3
                Console.WriteLine($"The {card.Color} {card.Rank}");
            }

            (CardColor, CardRank) cardTuple = (card.Color, card.Rank);

            //CardColor[] color = new CardColor[4];
            //CardRank[] rank = new CardRank[14];



        }
    }
}