using System.ComponentModel.DataAnnotations.Schema;

public class Game
{
    public (int maxRow, int maxColumn) Size { get; }  //(row, column)
    public WorldSize _WorldSize { get; set; }
    public Game()
    {
        Size = GetSize();
    }

    public bool CheckWin(Room room, Fountain fountain, Player playerCoordinates)
    {
        if (room.GetContent(playerCoordinates, this) == RoomContent.Entrance && fountain.IsActivated)
        {
            Console.WriteLine("\nThe Fountain of Objects has been reactivated, and you have escaped with your life!");
            return true;
        }
        return false;
    }

    public (int, int) GetSize()
    {
        Console.WriteLine("Choose the world size: small, medium or large");
        string input = Console.ReadLine();

        _WorldSize = input switch
        {
            "small" => WorldSize.Small,
            "medium" => WorldSize.Medium,
            "large" => WorldSize.Large
        };
        if (_WorldSize == WorldSize.Small)
        {
            Console.WriteLine("You've chosen a small world.");
            return (4, 4); 
        }
        else if (_WorldSize == WorldSize.Medium)
        {
            Console.WriteLine("You've chosen a medium world.");
            return (6, 6);
        }
        else if(_WorldSize == WorldSize.Large)
        {
            Console.WriteLine("You've chosen a large world.");
            return (8, 8);
        }
        else
        {
            Console.WriteLine("Oops! seems you misstyped, default size was chosen: small.");
            return (4, 4);
        }
    }
}