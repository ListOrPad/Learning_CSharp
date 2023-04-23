
public class Game
{
    public (int maxRow, int maxColumn) Size { get; }  //(row, column)
    public WorldSize GameWorldSize { get; set; }
    public EntranceRoom? Entrance { get; }
    public Game()
    {
        Size = GetSize();
    }

    public bool CheckWin(EntranceRoom entrance, FountainRoom fountain, Player player)
    {
        if (player.PlayerPosition.Row == entrance.RoomPosition.Row && player.PlayerPosition.Column == entrance.RoomPosition.Column && fountain.IsActivated) 
        {
            Console.WriteLine("\nThe Fountain of Objects has been reactivated, and you have escaped with your life!");
            return true;
        }
        return false;
    }

    public (int, int) GetSize()
    {
        Console.WriteLine("Choose the world size: small, medium or large");
        string? input = Console.ReadLine();

        GameWorldSize = input switch
        {
            "small" => WorldSize.Small,
            "medium" => WorldSize.Medium,
            "large" => WorldSize.Large,
            _ => WorldSize.Small
        };
        if (GameWorldSize == WorldSize.Small)
        {
            Console.WriteLine("You've chosen a small world.");
            return (3, 3); 
        }
        else if (GameWorldSize == WorldSize.Medium)
        {
            Console.WriteLine("You've chosen a medium world.");
            return (5, 5);
        }
        else if(GameWorldSize == WorldSize.Large)
        {
            Console.WriteLine("You've chosen a large world.");
            return (7, 7);
        }
        else
        {
            Console.WriteLine("Oops! seems you've misstyped, default size was chosen: small.");
            return (3, 3);
        }
    }
}