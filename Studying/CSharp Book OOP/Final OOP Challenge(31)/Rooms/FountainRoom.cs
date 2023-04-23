public class FountainRoom : RoomContent
{
    public bool IsActivated { get; set; }
    public string MessageOnActivate { get; } = "You hear the rushing waters from the Fountain of Objects. It has been reactivated!";
    public override string MessageOnEncounter { get; set; } = "You hear water dripping in this room.The Fountain of Objects is here!";
    public override Position RoomPosition { get; set; }
    public FountainRoom(Game game)
    {
        if (game.GameWorldSize == WorldSize.Small)
        {
            RoomPosition = new Position(0, 2); 
        }
        else if (game.GameWorldSize == WorldSize.Medium)
        {
            RoomPosition = new Position(2, 4);
        }
        else if (game.GameWorldSize == WorldSize.Large)
        {
            RoomPosition = new Position(4, 6);
        }
    }
    public override void WriteMessageOnEncounter()
    {
        Console.WriteLine(MessageOnEncounter);
    }
}