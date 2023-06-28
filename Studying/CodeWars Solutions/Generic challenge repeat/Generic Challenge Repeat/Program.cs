namespace Generic_Challenge_Repeat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Repeatition
            ColoredItem<Axe> Axe = new ColoredItem<Axe>(new Axe(), ConsoleColor.Red);
            ColoredItem<Sword> Sword = new ColoredItem<Sword>(new Sword(), ConsoleColor.Blue);
            ColoredItem<Bow> Bow = new ColoredItem<Bow>(new Bow(), ConsoleColor.Green);

            Axe.Display();
            Sword.Display();
            Bow.Display();

        }
    }
}