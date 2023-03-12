public class Game
{
    //determines winner or a draw(knows rules)

    public bool IsWin(char[] s)
    {
        if (s[0] == 'X' && s[1] == 'X' && s[2] == 'X' ||
            s[3] == 'X' && s[4] == 'X' && s[5] == 'X' ||
            s[6] == 'X' && s[7] == 'X' && s[8] == 'X' ||
            s[0] == 'X' && s[3] == 'X' && s[6] == 'X' ||
            s[1] == 'X' && s[4] == 'X' && s[7] == 'X' ||
            s[2] == 'X' && s[5] == 'X' && s[8] == 'X' ||
            s[0] == 'X' && s[4] == 'X' && s[8] == 'X' ||
            s[2] == 'X' && s[4] == 'X' && s[6] == 'X')
        {
            Console.WriteLine("Player X won this round!");
            return true;
        }
        else if (s[0] == 'O' && s[1] == 'O' && s[2] == 'O' ||
            s[3] == 'O' && s[4] == 'O' && s[5] == 'O' ||
            s[6] == 'O' && s[7] == 'O' && s[8] == 'O' ||
            s[0] == 'O' && s[3] == 'O' && s[6] == 'O' ||
            s[1] == 'O' && s[4] == 'O' && s[7] == 'O' ||
            s[2] == 'O' && s[5] == 'O' && s[8] == 'O' ||
            s[0] == 'O' && s[4] == 'O' && s[8] == 'O' ||
            s[2] == 'O' && s[4] == 'O' && s[6] == 'O')
        {
            Console.WriteLine("Player O won this round!");
            return true;
        }
        else return false;
    }


    public bool IsDraw(char[] s)
    {
        if (s[0] != ' ' && s[1] != ' ' && s[2] != ' ' && s[3] != ' ' && s[4] != ' '
            && s[5] != ' ' && s[6] != ' ' && s[7] != ' ' && s[8] != ' ')
        {
            Console.WriteLine("It's a draw!");
            return true;
        }
        else return false; 
    }
}