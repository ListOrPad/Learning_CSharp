using CSharp_Book_OOP;
using System.Security.Cryptography.X509Certificates;

internal class Exp5
{

    //find the bomb exercise
    public void Exp5Call()
    {
        FindTheBomb("ThERE is nO bOMB!");
        FindTheBomb("There is really no bomb, trust me");
        FindTheBomb("BOMB");
        FindTheBomb("I'VE FOUND ONE!");

    }

    public void FindTheBomb(string text)
    {
        string bomb = "bomb";
        Console.WriteLine(text);

        String stringLower = new String(text.ToLower());
        bool foundLower = stringLower.Contains(bomb);

        if (foundLower)
            Console.WriteLine("DUCK!!!");
        else
            Console.WriteLine("There's no bomb, relax");
    }







}