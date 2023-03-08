public class Player
{
    /*
      plays the game:
        -decides on the move(picks a tile)
    */
    public string Name { get; }
    public int Wins { get; set; }
    public Player(string name)
    {
        Name = name;
        Wins = 0;
    }
    private int GetInput()
    {
        Console.Write("Pick the tile (use numpad) ");
        int playerInput = int.Parse(Console.ReadLine()) - 1;
        return playerInput;
    }

    public char PickTile(char[] s, char XO, char revertXO)
    {
        int playerInput = GetInput();
        if (playerInput >= 0 && playerInput <= 8 && ValidateInput(playerInput, s))
        {
            return s[playerInput] = XO;
        }
        else
        {
            Console.WriteLine("wrong tile, try again (check with numpad)");
            if (RevertValidate(playerInput, s))        //if this is the tile is not empty
            {
                return s[playerInput] = revertXO;
            } 
            else
            {
                return s[playerInput] = ' '; 
            }
        }

    }
    public bool ValidateInput(int playerInput, char[] s)    //validates an input from user so it won't interfere with previous inputs
    {
        if (s[playerInput] != ' ')
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public bool RevertValidate(int playerInput, char[] s)    //validates an input from user so it won't interfere with previous inputs
    {
        if (s[playerInput] == ' ')
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}