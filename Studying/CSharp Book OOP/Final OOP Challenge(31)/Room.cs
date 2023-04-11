public class Room
{
    public RoomContent Content { get; set; }

    public RoomContent GetContent(Player playerCoordinates, Game game)
    {
        if (playerCoordinates.Row == 0 && playerCoordinates.Column == 2 && game._WorldSize == WorldSize.Small)
        {
            return Content = RoomContent.Fountain;
        }
        else if (playerCoordinates.Row == 2 && playerCoordinates.Column == 4 && game._WorldSize == WorldSize.Medium)
        {
            return Content = RoomContent.Fountain;
        }
        else if (playerCoordinates.Row == 4 && playerCoordinates.Column == 6 && game._WorldSize == WorldSize.Large)
        {
            return Content = RoomContent.Fountain;
        }
        else if (playerCoordinates.Row == 0 && playerCoordinates.Column == 0)
        {
            return Content = RoomContent.Entrance;
        }
        else
        {
            return Content = RoomContent.None;
        }
    }
}