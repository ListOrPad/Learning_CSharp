using CSharp_Book_OOP;

internal class Exp4
{
    internal void Exp4Caller()
    {
        //Arrays Challenge repeated

        string userInput;
        int[] array1 = new int[5];

        Console.WriteLine("Enter five numbers to replicate them  ");
        for (int i = 0; i < array1.Length; i++)
        {
            userInput = Console.ReadLine();
            array1[i] = Convert.ToInt32(userInput);
        }

        int[] array2 = new int[5];
        for (int i = 0; i < array2.Length; i++)
        {
            array2[i] = array1[i];
            Console.WriteLine($"{array1[i]}, {array2[i]}");
        }



        //exp 3 more tuple's
        (string Name, int Points, int Level) GetScore() => ("Boris", 15000, 42);
        var score = GetScore();
        Console.WriteLine($"Name: {score.Name}, Score: {score.Points}, Level: {score.Level}");
    }
}