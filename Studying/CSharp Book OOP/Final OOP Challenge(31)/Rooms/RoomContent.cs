public abstract class RoomContent
{
    public abstract string MessageOnEncounter { get; set; }
    public abstract Position RoomPosition { get; set; }
    public abstract void WriteMessageOnEncounter();
}