using System.Runtime.InteropServices;
using System.Threading;

namespace _24_Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //prepare ranks and colors for the card object
            Card cardInit = new Card();
            CardRank[] ranks = cardInit.GetRanks();
            CardColor[] colors = cardInit.GetColors();


            for (int i = 0; i < 14; i++)        //14 == 14 ranks in a deck
            {
                for (int j = 0; j < 4; j++)         //4 because 4 colors for each rank in a deck
                {
                    Card card = new Card(ranks[i], colors[j]);
                    Console.WriteLine($"The {card.Color} {card.Rank}");
                }
            }
        }
    }
}