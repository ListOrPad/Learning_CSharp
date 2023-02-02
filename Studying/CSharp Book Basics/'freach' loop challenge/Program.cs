namespace _freach__loop_challenge
{
    internal class Program
    {
        static string CheckWait(int index)
        {
            if ( index % 2 == 0)
            {
                return "is waiting for you";
            }
            else
            {
                return "Isn't waiting";
            }
        }
        static void Main(string[] args)
        {
            //loop 1. Calculating the minimum value in the array

            //int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            //int currentSmallest = int.MaxValue; 
            //for (int index = 0; index < array.Length; index++)
            //{
            //    if (array[index] < currentSmallest)
            //        currentSmallest = array[index];
            //}
            //Console.WriteLine(currentSmallest);

            int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            int currentSmallest = int.MaxValue;
            foreach (int value in array)
            {
                if (value < currentSmallest)
                    currentSmallest = value;
            }
            Console.WriteLine(currentSmallest);

            //loop 2 finding average using array and foreach loop

            //int[] array2 = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            //int total = 0;
            //for (int index = 0; index < array2.Length; index++)
            //    total += array2[index];
            //float average = (float)total / array2.Length;
            //Console.WriteLine(average);

            int[] array2 = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            int total = 0;
            foreach (int value2 in array2)
                total += value2;
            float average = (float)total / array2.Length;
            Console.WriteLine(average);


            //my custom task here
            Console.WriteLine("Step to personal task\n" +
                "push any key");
            Console.ReadKey(true);
            Console.Clear();

            // if clientNumber % 2 => {clientName} is waiting
            int[] indexList = new int[] { 1,2,3,4,5 };
            string[] names = new string[] { "Dima", "Max", "Vlad", "Lew", "Ilya" };
            for (int i = 0; i < indexList.Length; i++)
            {
                Console.WriteLine($"{names[i]} {CheckWait(indexList[i])}");
            } 

        }
    }
}