public class Round
{
    
    public void DisplayStatus(Room room, Player player, Fountain fountain)   //unfinished
    {
        Console.WriteLine($"You are in the room at (Row={player.Row}, Column={player.Column})");
        if (room.Content == RoomContent.Fountain)
        {
            if (!fountain.IsActivated) //checks if fountain is on or off
            {
                Console.WriteLine("You hear water dripping in this room. The Fountain of Objects is here!"); 
            }
            else
            {
                Console.WriteLine("You hear the rushing waters from the Fountain of Objects. It has been reactivated!"); 
            } 
        }
        else if (room.Content == RoomContent.Entrance)
        {

        }
    }

    
}