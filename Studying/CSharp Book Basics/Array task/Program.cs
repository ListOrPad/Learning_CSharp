namespace Array_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //First array creation, taking numbers
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                string[] numberTaken = new string[5] { "first", "second", "third", "fourth", "fifth" };
                Console.WriteLine($"Enter the {numberTaken[i]} number"); 
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Making copy
            int[] arrayCopy = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                arrayCopy[i] = array[i];
                Console.WriteLine($"First array: {array[i]}, Second array: {arrayCopy[i]}");
            }
        }
    }
}