namespace Tic_Tac_Toe_game
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Score score = new Score();
            while (true)
            {
                Game game = new Game();
                Board board = new Board();
                board.UpdateBoard(board.s[0], board.s[1], board.s[2], board.s[3], board.s[4], board.s[5], board.s[6], board.s[7], board.s[8]);
                while (true)
                {

                    board.Play('X');

                    if (game.IsWin(board.s))
                    {
                        score.PlayerXScore++;
                        break;
                    }
                    else if (game.IsDraw(board.s))
                    {
                        break;
                    }

                    board.Play('O');

                    if (game.IsWin(board.s))
                    {
                        score.PlayerOScore++;
                        break;
                    }
                    else if (game.IsDraw(board.s))
                    {
                        break;
                    }
                }

                score.DisplayScore();

                //Refreshes console window after a round
                Console.WriteLine("Up for another round?\n" +
                                    "Press any key");
                Console.ReadKey(true);
                Console.Clear(); 
            }
        }
    }
}