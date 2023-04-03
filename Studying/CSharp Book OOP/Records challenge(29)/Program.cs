namespace Records_challenge_29_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Records challenge, lesson 29

            Sword basicSword = new Sword(Material.Iron, Gemstone.None, 42, 15);
            Sword shortSword = basicSword with { Length = 33 , CrossWidth = 9};
            Sword poorSword = basicSword with { Material = Material.Wood };
            Sword binariumSword = basicSword with { Gem = Gemstone.Bitstone, Material = Material.Binarium };

            Console.WriteLine(basicSword);
            Console.WriteLine(shortSword);
            Console.WriteLine(poorSword);
            Console.WriteLine(binariumSword);
        }
    }
}