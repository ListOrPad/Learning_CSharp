public class Board
{
    //knows the status of every tile
    //tells if the tile is already filled
    //updates the status(data) and displays itself to the players every move(draws the board)
    //___________________________________________________________________________
    //'S' stays for "symbol" variable
    //filling an array of chars with empty space symbols

    public char[] s = Enumerable.Repeat(' ', 9).ToArray();
    public void UpdateBoard(char s1, char s2, char s3, char s4, char s5, char s6, char s7, char s8, char s9)
    {
        //Draw updated board
        Console.WriteLine
      ($" {s7} | {s8} | {s9} \n" +
       $"---+---+---\n" +
       $" {s4} | {s5} | {s6} \n" +
       $"---+---+---\n" +
       $" {s1} | {s2} | {s3} ");
    }
    public void Play(char symbol)
    {
        //Draw the board
       
        Player playerS = new Player(symbol);
        //player X makes a move
        do
        {
            playerS.PickTile(s, symbol);
        }
        while (playerS.Name == symbol);
        UpdateBoard(s[0], s[1], s[2], s[3], s[4], s[5], s[6], s[7], s[8]);


        //check if someone is victorious this round

    }

}