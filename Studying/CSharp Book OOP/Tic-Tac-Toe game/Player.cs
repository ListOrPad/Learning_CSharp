public class Player
{
    /*
      plays the game:
        -decides on the move(picks a tile)
    */
    public char Input { get; set; }
    public char Suit { get; set; }
    public Player(char XO)
    {
        if (XO == 'X')
        {
            Suit = 'X';
        }

    }
    public void PickTile()
    {

    }
}