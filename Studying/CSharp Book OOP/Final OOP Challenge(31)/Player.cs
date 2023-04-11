public class Player
{
    //represents position, in what room player currently is [row, column]
    public int Row { get; set; }
    public int Column { get; set; }
    public void Action(Room room, Fountain fountain, Game game, Player playerCoordinates)
    {
        do
        {
            Console.Write("What do you want to do? ");
        
            string? input = Console.ReadLine();
            switch (input)
            {
                case "move north":
                    if (Row < game.MaxRow && Row >= 0)
                    {
                        Row++; 
                    }
                    break;
                case "move south":
                    if (Row <= game.MaxRow && Row > 0)
                    {
                        Row--;
                    }
                    break;
                case "move east":
                    if (Column < game.MaxColumn && Column >= 0)
                    {
                        Column++; 
                    }
                    break;
                case "move west":
                    if (Column <= game.MaxColumn && Column > 0)
                    {
                        Column--; 
                    }
                    break;
                case "activate":
                    if (room.GetContent(playerCoordinates) == RoomContent.Fountain)
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
        while (Column < 0 || Column > game.MaxColumn || Row > game.MaxRow || Row < 0); //make it impossible to go out of borders

    }
}