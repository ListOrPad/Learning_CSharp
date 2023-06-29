namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Events "Charberry trees" challenge

            CharberryTree tree = new CharberryTree();
            Notifier notifier = new Notifier(tree);
            Harvester harvester = new Harvester(tree);
            while (true)
                tree.MaybeGrow();
        }
    }
}