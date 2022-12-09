using System.Runtime.InteropServices;

public class Exp7
{
    public void Exp7Call()
    {

        int Solution(int value)
        {

            int sum3 = 0;
            int sum5 = 0;
            int numPassed = value;
            int numPassed0 = value;
            int numPassedOriginal = value;

            int[] multiples5 = new int[numPassed / 5];

            for (int i = 0; numPassed / 5 != 0; i++)
            {
                multiples5[i] = numPassed / 5 * 5;
                numPassed = numPassed / 5 * 5 - 5;
                if (multiples5[i] % 3 == 0 || multiples5[i] == numPassedOriginal)  // why i did this?
                    continue;
                sum5 = sum5 + multiples5[i];
            }

            int[] multiples3 = new int[numPassed0 / 3];

            for (int i = 0; numPassed0 / 3 != 0; i++)
            {
                multiples3[i] = numPassed0 / 3 * 3;
                numPassed0 = numPassed0 / 3 * 3 - 3;
                if (multiples3[i] == numPassedOriginal)
                    continue;
                sum3 = sum3 + multiples3[i];
            } 

            int sum = sum3 + sum5;
            return sum;

        }

        Console.WriteLine($"{Solution(15)}");        

    }
}