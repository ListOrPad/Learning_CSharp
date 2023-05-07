namespace Final_OOP_Challenge_31_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The Fountain of Objects Challenge
            //(Hunt The Wumpus like)
            Game game = new Game();
            DateTime timeBeginning = DateTime.Now;
            Player player = new Player();
            FountainRoom fountain = new FountainRoom(game);
            EntranceRoom entrance = new EntranceRoom(new Position(0, 0));
            Maelstrom maelstrom = new Maelstrom(new Position(0, 1));
            Maelstrom secondMaelstrom = new Maelstrom(new Position(-13, -13));

            if (game.GameWorldSize == WorldSize.Medium)
            {
                maelstrom = new Maelstrom(new Position(3, 4));
                secondMaelstrom = new Maelstrom(new Position(0, 1));
            }
            else if (game.GameWorldSize == WorldSize.Large)
            {
                maelstrom = new Maelstrom(new Position(5, 6));
                secondMaelstrom = new Maelstrom(new Position(3, 4));
            }
            while (true)
            {
                Round round = new Round();

                round.DisplayStatus(game, player, fountain, entrance, maelstrom, secondMaelstrom);
                player.DoAction(fountain, game);
                maelstrom.MakeMovementOnEncounter(game, player); //if player meets maelstrom, they move positions
                secondMaelstrom.MakeMovementOnEncounter(game, player);

                if (game.CheckWin(entrance, fountain, player))
                {
                    DateTime timeEnding = DateTime.Now;
                    int timeSpan = timeEnding.Second - timeBeginning.Second;
                    Console.WriteLine("You were in the dungeon for " + timeSpan + " seconds");
                    break;
                }
            } 
        }
    }
}