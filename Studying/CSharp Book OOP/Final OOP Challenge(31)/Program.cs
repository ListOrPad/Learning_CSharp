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


            while (true)
            {
                Round round = new Round();
                Room room = new Room();
                Fountain fountain = new Fountain();

                round.DisplayStatus(room, player, fountain);

                player.Action(room, fountain, game);


                //game.CheckWin();




            } 
        }
    }
}