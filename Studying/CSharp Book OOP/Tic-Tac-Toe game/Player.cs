public class Player
{
    /*
      plays the game:
        -decides on the move(picks a tile)
    */
    public char Input { get; set; }
    public char Suit { get; set; }
    public Player Winner { get; set; }
    public Player()
    {

    }
    public void WonRound()
    {
        // if (three X in a row)
            //Winner = playerX
        //else if (three O in a row)
            //Winner = playerO
        //else
            //Winner = Draw()     //Draw - is a method or a property?

        ///HOW TO DEFINE 3 O's OR 3 X's in a row? Contains() method?
    }
    public Player(Player playerX, Player playerO)
    {
        if (playerX.WonRound)      // == true?
            Winner = playerX;
        else Winner = playerO;
    }
    public void PickTile()
    {

    }
}