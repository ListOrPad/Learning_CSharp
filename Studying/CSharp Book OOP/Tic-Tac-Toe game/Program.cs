﻿namespace Tic_Tac_Toe_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Finally, we're at it!
            //Tic-Tac-Toe Game
            while (true)
            {
                Game game = new Game();
                Board board = new Board();
                board.Play();

                
                
                game.DisplayScore();
                //Refreshes console window after a round
                Console.WriteLine("Up for another round?\n" +
                                    "Press any key");
                Console.ReadKey(true);
                Console.Clear();
            }


        }
    }
}