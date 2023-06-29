public class Notifier
{
    public void NotificationHandler(CharberryTree tree)
    {
        if (tree.Ripe == true)
        {
            Console.WriteLine($"A charberry fruit has ripened!");    
        }
    }
    public Notifier(CharberryTree tree)
    {
        tree.Ripened += NotificationHandler;
    }
}