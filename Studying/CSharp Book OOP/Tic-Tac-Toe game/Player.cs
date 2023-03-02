public class Player
{
    /*
      plays the game:
        -decides on the move(picks a tile)
    */
    public Player()
    {

    }
    public void PickTile(char[] s, char XO)
    {
        Console.Write("Pick the tile (use numpad) ");
        int playerInput = int.Parse(Console.ReadLine()) - 1;
        if (playerInput >= 0 && playerInput <= 8)
        {
            s[playerInput] = XO;
        }
    }
}