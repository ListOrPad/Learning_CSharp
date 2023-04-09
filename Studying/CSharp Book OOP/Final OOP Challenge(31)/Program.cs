namespace Final_OOP_Challenge_31_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The Fountain of Objects Challenge
            //(Hunt The Wumpus like)
            Game game = new Game(3, 3);
            Player player = new Player();
            Fountain fountain = new Fountain();


            while (true)
            {
                Round round = new Round();
                Room room = new Room();

                round.DisplayStatus(room, player, fountain);
                player.Action(room, fountain, game, player);

                if (game.CheckWin(room, fountain, player))
                {
                    break;
                }
            } 
        }
    }
}