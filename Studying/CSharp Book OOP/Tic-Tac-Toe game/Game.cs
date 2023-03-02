using System.Numerics;

public class Game
{
    //show result
    //determines winner, looser or a draw(knows rules)
    public (int X, int O) score = (0, 0);
    public bool WinXApprove { get; set; }
    public bool WinOApprove { get; set; }

    public void DisplayScore()        ///bool WinApprove?
    {
        if (WinXApprove)
        {
            score.X++;
        }
        else if (WinOApprove)
        {
            score.O++;
        }
        Console.WriteLine($"X: {score.X}, O: {score.O}");
       
    }
    public bool DetectWinOrDraw(char[] s)
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
            WinXApprove = true;
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
            Console.WriteLine("Player O Win this round!");
            WinOApprove = true;
            return true;
        }
        else if (s[0] != ' ' && s[1] != ' ' && s[2] != ' ' && s[3] != ' ' && s[4] != ' '
        && s[5] != ' ' && s[6] != ' ' && s[7] != ' ' && s[8] != ' ')
        {
            Console.WriteLine("It's a draw!");
            return true;
        }
        else return false;
    }
}