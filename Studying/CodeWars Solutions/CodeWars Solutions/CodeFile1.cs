using System.Collections.Generic;
using System.Globalization;

public class LineNumbering
{
    public static List<string> Number(List<string> lines)
    {
        //create a list that contains numbers for lines
        List<int> numbers = new List<int>();
        //create 'ints' array to populate list with incrementing numbers
        int[] ints = new int[lines.Count];

        for (int j = 0; j < lines.Count; j++)
        {
            if (j == 0)
                ints[j] = 1;
            if (j > 0)
                ints[j] = ints[j - 1] + 1;
        }
        
        //add 'ints' array to the list
        numbers.AddRange(ints);
        //add lines with numbers to the "lines" list
        for (int i = 0; i < lines.Count; i++)
        {
            lines[i] = $"{numbers[i]}: {lines[i]}";
        }

        return lines;
    }
}