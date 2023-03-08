//public class Player
//{
//    /*
//      plays the game:
//        -decides on the move(picks a tile)
//    */
//    public Player()
//    {

//    }
//    private int GetInput()
//    {
//        Console.Write("Pick the tile (use numpad) ");
//        int playerInput = int.Parse(Console.ReadLine()) - 1;
//        return playerInput;
//    }

//    public char PickTile(char[] s, char XO)
//    {
//        int playerInput = GetInput();
//        if (playerInput >= 0 && playerInput <= 8 && ValidateInput(playerInput, s))
//        {
//            return s[playerInput] = XO;
//        }
//        else
//        {
//            Console.WriteLine("wrong tile, try again (check with numpad)");
//            return s[playerInput] = ' ';              //here's another bug!
//        }

//    }
//    public bool ValidateInput(int playerInput, char[] s)    //validates an input from user so it won't interfere with previous inputs
//    {
//        if (s[playerInput] != ' ')
//        {
//            return false;
//        }
//        else
//        {
//            return true;
//        }
//    }
//}