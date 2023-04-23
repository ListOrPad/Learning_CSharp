public class EntranceRoom : RoomContent
{
    public override string MessageOnEncounter { get; set; } = "You see light in this room coming from outside the cavern. This is the entrance.";
    public override Position RoomPosition { get; set; }
    public EntranceRoom(Position position)
    {
        RoomPosition = position;
    }
    public override void WriteMessageOnEncounter()
    {
        Console.WriteLine(MessageOnEncounter);
    }
}