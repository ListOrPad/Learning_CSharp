using System;
using System.Reflection;

public class GreenBottles
{
    public static string TenGreenBottles(int n)
    {
        string[] iterationsOfText = new string[n];
        string text = "";
        for (int i = 0; (n - 1) >= i; i++ )
        {
            string bottlesCountString = n switch
            {
                1 => "One",
                2 => "Two",
                3 => "Three",
                4 => "Four",
                5 => "Five",
                6 => "Six",
                7 => "Seven",
                8 => "Eight",
                9 => "Nine",
                10 => "Ten",
                _ => "this number doesn't exist =)"
            };

            string bottlesCountStringMinusOne = (n - 1) switch
            {
                1 => "one",
                2 => "two",
                3 => "three",
                4 => "four",
                5 => "five",
                6 => "six",
                7 => "seven",
                8 => "eight",
                9 => "nine",
                10 => "ten",
                _ => "this number doesn't exist =)"
            };

            string bottlesCountStringMinusI = (n - i) switch
            {
                1 => "One",
                2 => "Two",
                3 => "Three",
                4 => "Four",
                5 => "Five",
                6 => "Six",
                7 => "Seven",
                8 => "Eight",
                9 => "Nine",
                10 => "Ten",
                _ => "this number doesn't exist =)"
            };
            string bottlesCountStringMinusOneAndI = (n - 1 - i) switch
            {
                1 => "one",
                2 => "two",
                3 => "three",
                4 => "four",
                5 => "five",
                6 => "six",
                7 => "seven",
                8 => "eight",
                9 => "nine",
                10 => "ten",
                _ => "this number doesn't exist =)"
            };

            
            if (bottlesCountString == "One" || bottlesCountStringMinusI == "One")
                iterationsOfText[i] =
                    $"One green bottle hanging on the wall,\n" +
                    $"One green bottle hanging on the wall,\n" +
                    $"If that one green bottle should accidentally fall,\n" +
                    $"There'll be no green bottles hanging on the wall.\n";
            else if (bottlesCountString == "Two" || bottlesCountStringMinusI == "Two")
                iterationsOfText[i] =
                    $"Two green bottles hanging on the wall,\n" +
                    $"Two green bottles hanging on the wall,\n" +
                    $"And if one green bottle should accidentally fall,\n" +
                    $"There'll be one green bottle hanging on the wall.\n\n";
            else if (i == 0)
                iterationsOfText[i] =
                    $"{bottlesCountString} green bottles hanging on the wall,\n" +
                    $"{bottlesCountString} green bottles hanging on the wall,\n" +
                    $"And if one green bottle should accidentally fall,\n" +
                    $"There'll be {bottlesCountStringMinusOne} green bottles hanging on the wall.\n\n";
            else
                iterationsOfText[i] = 
                    $"{bottlesCountStringMinusI} green bottles hanging on the wall,\n" +
                    $"{bottlesCountStringMinusI} green bottles hanging on the wall,\n" +
                    $"And if one green bottle should accidentally fall,\n" +
                    $"There'll be {bottlesCountStringMinusOneAndI} green bottles hanging on the wall.\n\n";

            text += iterationsOfText[i];
        }
        return text;
    }
}