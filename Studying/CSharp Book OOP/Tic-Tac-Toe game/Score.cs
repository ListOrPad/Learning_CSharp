public class Score
{
    public int PlayerXScore { get; set; }
    public int PlayerOScore { get; set; }

    public Score()
    {
        PlayerXScore = 0;
        PlayerOScore = 0;
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Score: X - {PlayerXScore} , O - {PlayerOScore}");
    }
}