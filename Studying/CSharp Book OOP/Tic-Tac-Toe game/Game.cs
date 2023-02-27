public class Game
{
    //show result
    //determines winner, looser or a draw(knows rules)
    public void ShowResult()
    {
        Player player = new Player();
        if (player.Winner == WonRound())
            Console.WriteLine($"The winner is {player.Winner}.");
        else
            Console.WriteLine("It is a draw.");
    }
}