
public class Round
{

    public void DisplayStatus(Game game, Player player, FountainRoom fountain, EntranceRoom entrance, Maelstrom maelstrom, Maelstrom secondMaelstrom)
    {
        Console.WriteLine($"\nYou are in the room at (Row={player.PlayerPosition.Row}, Column={player.PlayerPosition.Column})");
        if (player.PlayerPosition.Row == entrance.RoomPosition.Row && player.PlayerPosition.Column == entrance.RoomPosition.Column)
        {
            entrance.WriteMessageOnEncounter();
        }
        if (player.PlayerPosition.Row == fountain.RoomPosition.Row && player.PlayerPosition.Column == fountain.RoomPosition.Column)
        {
            if (!fountain.IsActivated) //checks if fountain is on or off
            {
                fountain.WriteMessageOnEncounter();
            }
            else
            {
                Console.WriteLine(fountain.MessageOnActivate);
            }
        }
        //if strom is in adjacent room write warning message
        if (player.PlayerPosition.Row + 1 == maelstrom.RoomPosition.Row && player.PlayerPosition.Column == maelstrom.RoomPosition.Column
            || player.PlayerPosition.Column + 1 == maelstrom.RoomPosition.Column && player.PlayerPosition.Row == maelstrom.RoomPosition.Row
            || player.PlayerPosition.Row - 1 == maelstrom.RoomPosition.Row && player.PlayerPosition.Column == maelstrom.RoomPosition.Column
            || player.PlayerPosition.Column - 1 == maelstrom.RoomPosition.Column && player.PlayerPosition.Row == maelstrom.RoomPosition.Row)
        {
            Console.WriteLine(maelstrom.WarningMessage);
        }

        if (game.GameWorldSize == WorldSize.Medium || game.GameWorldSize == WorldSize.Large)
        {
            if (player.PlayerPosition.Row + 1 == secondMaelstrom.RoomPosition.Row && player.PlayerPosition.Column == secondMaelstrom.RoomPosition.Column
                || player.PlayerPosition.Column + 1 == secondMaelstrom.RoomPosition.Column && player.PlayerPosition.Row == secondMaelstrom.RoomPosition.Row
                || player.PlayerPosition.Row - 1 == secondMaelstrom.RoomPosition.Row && player.PlayerPosition.Column == secondMaelstrom.RoomPosition.Column
                || player.PlayerPosition.Column - 1 == secondMaelstrom.RoomPosition.Column && player.PlayerPosition.Row == secondMaelstrom.RoomPosition.Row)
            {
                Console.WriteLine(secondMaelstrom.WarningMessage);
            } 
        }
    }
}