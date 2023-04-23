public class Player
{
    public Position PlayerPosition { get; set; }
    public void DoAction(FountainRoom fountain, Game game)
    {
        do
        {
            Console.Write("What do you want to do? ");

            string? input = Console.ReadLine();
            switch (input)
            {
                case "move north":
                    if (PlayerPosition.Row <= game.Size.maxRow && PlayerPosition.Row > 0)
                    {
                        PlayerPosition = new Position(PlayerPosition.Row - 1, PlayerPosition.Column);
                    }
                    break;
                case "move south":
                    if (PlayerPosition.Row < game.Size.maxRow && PlayerPosition.Row >= 0)
                    {
                        PlayerPosition = new Position(PlayerPosition.Row + 1, PlayerPosition.Column);
                    }
                    break;
                case "move east":
                    if (PlayerPosition.Column < game.Size.maxColumn && PlayerPosition.Column >= 0)
                    {
                        PlayerPosition = new Position(PlayerPosition.Row, PlayerPosition.Column + 1);
                    }
                    break;
                case "move west":
                    if (PlayerPosition.Column <= game.Size.maxColumn && PlayerPosition.Column > 0)
                    {
                        PlayerPosition = new Position(PlayerPosition.Row, PlayerPosition.Column - 1);
                    }
                    break;
                case "activate":
                    if (PlayerPosition.Row == fountain.RoomPosition.Row && PlayerPosition.Column == fountain.RoomPosition.Column)
                    {
                        fountain.IsActivated = true;
                    }
                    else
                    {
                        Console.WriteLine("You can't activate the fountain, wrong room.");
                    }
                    break;

            }
        }
        //make it impossible to go out of borders
        while (PlayerPosition.Column < 0 || PlayerPosition.Column > game.Size.maxColumn || PlayerPosition.Row > game.Size.maxRow || PlayerPosition.Row < 0);
    }
}