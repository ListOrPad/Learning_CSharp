public class Game
{

    public int MaxRow { get; }
    public int MaxColumn { get; }
    public WorldSize Size { get; }
    public Game(int maxRow, int maxColumn )
    {
        Size = GetSize();
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

    public WorldSize GetSize()
    {
        string input = Console.ReadLine();
        WorldSize size;

        size = input switch
        {
            "small" => WorldSize.Small,
            "medium" => WorldSize.Medium,
            "large" => WorldSize.Large,
        };
        return size;
    }
}