public class Game
{

    public int MaxRow { get; }
    public int MaxColumn { get; }
    public Game(int maxRow, int maxColumn)
    {
        MaxRow = maxRow;
        MaxColumn = maxColumn;
    }

    public bool CheckWin(Room room, Fountain fountain, Player playerCoordinates)
    {
        if (room.GetContent(playerCoordinates) == RoomContent.Entrance && fountain.IsActivated)
        {
            Console.WriteLine("\nThe Fountain of Objects has been reactivated, and you have escaped with your life!");
            return true;
        }
        return false;
    }
}