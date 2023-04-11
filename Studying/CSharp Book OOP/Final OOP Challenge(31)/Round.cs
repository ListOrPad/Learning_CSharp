using System.Runtime.Intrinsics.X86;

public class Round
{
    
    public void DisplayStatus(Room room, Player player, Fountain fountain, Game game)
    {
        Console.WriteLine($"\nYou are in the room at (Row={player.Row}, Column={player.Column})");
        if (room.GetContent(player, game) == RoomContent.Fountain)
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
        else if (room.GetContent(player, game) == RoomContent.Entrance)
        {
            Console.WriteLine("You see light in this room coming from outside the cavern.This is the entrance.");
        }
    }

    
}