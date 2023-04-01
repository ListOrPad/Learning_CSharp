namespace Structs_challenge_28_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Structs challenge

            Coordinate firstCoordinate = new Coordinate(2,2);
            Coordinate secondCoordinate = new Coordinate(2,0);
            Coordinate thirdCoordinate = new Coordinate(1,0);
            Console.WriteLine($"{firstCoordinate.IsAdjacent(secondCoordinate)}, {secondCoordinate.IsAdjacent(thirdCoordinate)}, {thirdCoordinate.IsAdjacent(firstCoordinate)}");
        }
    }
}