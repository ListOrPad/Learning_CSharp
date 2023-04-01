public struct Coordinate
{
    public int Row { get; }
    public int Column { get; }
    public Coordinate(int row, int column)
    {
        Row = row;
        Column = column;
    }
    public bool IsAdjacent(Coordinate coordinate)
    {
        if (coordinate.Row - 1 == Row && coordinate.Column == Column)
        {
            return true; 
        }
        else if (coordinate.Row + 1 == Row  && coordinate.Column == Column)
        {
            return true;
        }
        else if (coordinate.Column - 1 == Column && coordinate.Row == Row)
        {
            return true;
        }
        else if (coordinate.Column + 1 == Column && coordinate.Row == Row)
        {
            return true;
        }

        else return false;
    }
}