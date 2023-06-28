public class Kata0
{
    public static string AreYouPlayingBanjo(string name)
    {
        char character = 'R';
        char character2 = 'r';

        int index0 = name.IndexOf(character);
        int index1 = name.IndexOf(character2);

        if (index0 == 0 || index1 == 0)
            return name + " plays banjo";
        else
            return name + " does not play banjo";
    }
}