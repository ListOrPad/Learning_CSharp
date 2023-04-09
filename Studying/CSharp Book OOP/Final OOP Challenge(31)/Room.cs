public class Room
{
    public RoomContent Content { get; set; }

    public RoomContent GetContent(Player playerCoordinates)
    {
        if (playerCoordinates.Row == 0 && playerCoordinates.Column == 2)
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