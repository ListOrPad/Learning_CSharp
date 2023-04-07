namespace Generics_challenge_30_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //generics "Colored Items" challenge

            ColoredItem<Sword> sword = new ColoredItem<Sword>(ConsoleColor.Blue, new Sword());
            ColoredItem<Axe> axe = new ColoredItem<Axe>(ConsoleColor.Red, new Axe());
            ColoredItem<Bow> bow = new ColoredItem<Bow>(ConsoleColor.Green, new Bow());
            sword.Display();
            axe.Display();
            bow.Display();

            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}