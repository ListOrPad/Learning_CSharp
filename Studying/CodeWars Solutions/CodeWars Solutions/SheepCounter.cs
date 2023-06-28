using System;

public class SheepCounter
{
    public static int CountSheeps(bool[] sheeps)
    {
        int sheepCount = 0;
        for (int i = 0; sheeps.Length > i; i++)
        {
            if (sheeps[i] == true)
            {
                sheepCount++;
            }
        }
        return sheepCount;
    }
}