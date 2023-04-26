public class Maelstrom : RoomContent
{
    public override string MessageOnEncounter { get; set; } = "You've encountered a maelstrom, your location was changed.";
    public string WarningMessage { get; } = "You hear the growling and groaning of a maelstrom nearby.";
    public override Position RoomPosition { get; set; }
    public Maelstrom(Position position)
    {
        RoomPosition = position;
    }
    public override void WriteMessageOnEncounter()
    {
        Console.WriteLine(MessageOnEncounter);
    }
    public void MakeMovementOnEncounter(Game game, Player player)
    {
        if (player.PlayerPosition.Row == RoomPosition.Row && player.PlayerPosition.Column == RoomPosition.Column)
        {
            //if maelstrom is at the entrance move it to the opposite corner of the map so the player could leave the dungeon
            if (RoomPosition.Row == 0 && RoomPosition.Column == 0)
            {
                RoomPosition = new Position(game.Size.maxRow, game.Size.maxColumn);
            }

            //change maelstrom position on encounter
            RoomPosition = new Position(RoomPosition.Row + 1, RoomPosition.Column - 2);

            if (RoomPosition.Row > game.Size.maxRow)
            {
                RoomPosition = new Position(game.Size.maxRow, RoomPosition.Column);
            }
            else if (RoomPosition.Row < 0)
            {
                RoomPosition = new Position(0, RoomPosition.Column);
            }

            if (RoomPosition.Column > game.Size.maxColumn)
            {
                RoomPosition = new Position(RoomPosition.Row, game.Size.maxColumn);
            }
            else if (RoomPosition.Column < 0)
            {
                RoomPosition = new Position(RoomPosition.Row, 0);
            }
            
            //change player position on encounter
            player.PlayerPosition = new Position(player.PlayerPosition.Row - 1, player.PlayerPosition.Column + 2);

            if (player.PlayerPosition.Row > game.Size.maxRow)
            {
                player.PlayerPosition = new Position(game.Size.maxRow, player.PlayerPosition.Column);
            }
            else if (player.PlayerPosition.Row < 0)
            {
                player.PlayerPosition = new Position(0, player.PlayerPosition.Column);
            }

            if (player.PlayerPosition.Column > game.Size.maxColumn)
            {
                player.PlayerPosition = new Position(player.PlayerPosition.Row, game.Size.maxColumn);
            }
            else if (player.PlayerPosition.Column < 0)
            {
                player.PlayerPosition = new Position(player.PlayerPosition.Row, 0);
            }

            WriteMessageOnEncounter();
        }
    }
}