﻿public class Game
{
    //show result
    //determines winner, looser or a draw(knows rules)
    public void ShowResult()
    {
        (int, int) score = (0, 0);
        Player player = new Player();
        if (player.WonRound() == true)
            Console.WriteLine($"The winner is {player.Winner}.");
        else
            Console.WriteLine("It is a draw.");
    }
}