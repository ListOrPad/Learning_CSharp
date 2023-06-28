
using System;
public class Isogram
{
    public static bool IsIsogram(string word)
    {
        List<char> chars = new List<char>();
        foreach (char character in word.ToLower())
        {
            char newCharacter = character;

            if (chars.Contains(newCharacter))
            {
                return false;
            }
            chars.Add(character);
        }
        return true;
    }
}