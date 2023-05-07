using System.Drawing;

public class MethodCollection
{
    public string? Input(string text)
    {
        Console.WriteLine(text);
        string? input = Console.ReadLine();
        return input;
    }

    public int CalcCanonDmg(int round)
    {
        
        if (round % 3 == 0 && round % 5 == 0) //COMBO
        {
            return 10;
        }
        else if (round % 3 == 0) //fire attack
        {
            return 3;
        }
        else if (round % 5 == 0) //electric
        {
            return 5;
        }
        else return 1; //normal attack
    }
    public void RecolorDamage(int canonDamage)
    {
        if (canonDamage == 3)
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        else if (canonDamage == 5)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        else if (canonDamage == 10)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

    }
    public void RenameElementalDamage(int canonDamage)
    {
        if (canonDamage == 3)
        {
            Console.Write(" Fire");
        }
        else if (canonDamage == 5)
        {
            Console.Write(" Electric");
        }
        else if (canonDamage == 10)
        {
            Console.Write(" Combined");
        }
    }
    public void DisplayInfo(int _round, int _cityHP, int _bossHP, int _canonDamage)
    {
        Console.Write($"STATUS: Round: {_round} City: {_cityHP}/15 Manticore: {_bossHP}/10\n" +
                $"The Canon is expected to deal ");

        RecolorDamage(_canonDamage);
        Console.Write(_canonDamage);
        RenameElementalDamage(_canonDamage);
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine(" damage this round");

    }

    public int OpenFire(int _manticoreDistance, int _bossHP, int _canonDamage)
    {

        Console.Write("Enter the desired Canon range ( 0 to 100 ): ");
        int canonTarget = Convert.ToInt32(Console.ReadLine());
        if (canonTarget > _manticoreDistance)
        {
            Console.WriteLine("That round OVERSHOT the target");
            return _bossHP;
        }
        else if (canonTarget < _manticoreDistance)
        {
            Console.WriteLine("That round FELL SHORT of the target");
            return _bossHP;
        }
        else
        {
            Console.WriteLine("This round was a direct HIT");
            return _bossHP -= _canonDamage;
        }
    }
    public bool ShowResult(int bossHP, int cityHP)
    {
        if (bossHP <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The Manticore was destroyed! The city of Consolas has been saved!");
            Console.ReadKey(true);
            return true;
        }
        else if (cityHP <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You've lost! Push any key, then try again.");
            Console.ReadKey(true);
            return true;
        }
        return false;
    }
}