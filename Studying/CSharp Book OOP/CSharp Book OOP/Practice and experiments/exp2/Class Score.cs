public class Score
{
    public string name;
    public int points;
    public int level;

    string GetName() => name;

    public Score()
    {
        name = "unknown";
        points = 0;
        level = 1;
    }

    public bool EarnedStar() => (points / level) > 1000;
}