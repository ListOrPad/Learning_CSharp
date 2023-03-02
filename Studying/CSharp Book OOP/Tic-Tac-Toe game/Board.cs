using System.Diagnostics.Metrics;

public class Board
{
    //knows the status of every tile
    //tells if the tile is already filled
    //updates the status(data) and displays itself to the players every move(draws the board)

    private void UpdateBoard(char s1, char s2, char s3, char s4, char s5, char s6, char s7, char s8, char s9)
    {
        //Draw updated board
        Console.WriteLine
      ($" {s7} | {s8} | {s9} \n" +
       $"---+---+---\n" +
       $" {s4} | {s5} | {s6} \n" +
       $"---+---+---\n" +
       $" {s1} | {s2} | {s3} ");
    }
    public void Play()
    {
        //'s' stays for "symbol" variable
        //filling an array of chars with empty space symbols
        char[] s = Enumerable.Repeat(' ', 9).ToArray();

        //Draw the board
        UpdateBoard(s[0], s[1], s[2], s[3], s[4], s[5], s[6], s[7], s[8]);

        //Continue the flow of the game after the board was drawn
        while (true)
        {

            //player X makes a move
            Player player = new Player();
            player.PickTile(s, 'X');

            UpdateBoard(s[0], s[1], s[2], s[3], s[4], s[5], s[6], s[7], s[8]);

            //player O makes a move
            player.PickTile(s, 'O');

            UpdateBoard(s[0], s[1], s[2], s[3], s[4], s[5], s[6], s[7], s[8]);

            //check if someone is victorious this round
            Game game = new Game();
            if (game.DetectWinOrDraw(s))
            {
                break; 
            }
        }
    }

}