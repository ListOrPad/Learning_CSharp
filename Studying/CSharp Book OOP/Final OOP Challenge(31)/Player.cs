public class Player
{
    //represents position, in what room player currently is [row, column]
    public int Row { get; set; }
    public int Column { get; set; }
    public void Action(Room room, Fountain fountain, Game game)
    {
        do
        {
            Console.Write("What do you want to do?");
        
            string? input = Console.ReadLine();
            switch (input)
            {
                case "move north":
                    Column++;
                    break;
                case "move south":
                    Column--;
                    break;
                case "move east":
                    Row++;
                    break;
                case "move west":
                    Row--;
                    break;
                case "activate fountain":
                    if (room.Content == RoomContent.Fountain)
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