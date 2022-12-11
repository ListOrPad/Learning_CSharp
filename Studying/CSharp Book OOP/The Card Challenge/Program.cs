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
            Card card = new Card();

            int enumCountRank = Enum.GetNames(typeof(CardRank)).Length;
            int enumCountColor = Enum.GetNames(typeof(CardColor)).Length;

            for (int i = 0; i < enumCountRank; i++)  
            {
                for (int k = 0; k < enumCountColor; k++)
                {

                    card.Rank = (CardRank)i;
                    card.Color = (CardColor)k; //how to reset counter to 0 after i = 3
                    Console.WriteLine($"The {card.Color} {card.Rank}");

                }
            }

            //(CardColor, CardRank) cardTuple = (card.Color, card.Rank);

            //CardColor[] color = new CardColor[4];
            //CardRank[] rank = new CardRank[14];



        }
    }
}