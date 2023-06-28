public class ColoredItem<T>
{
    public T? Item { get; set; }
    ConsoleColor Color { get; set; }
    public ColoredItem(T? item, ConsoleColor color)
    {
        Item = item;
        Color = color;
    }

    public void Display()
    {
        Console.ForegroundColor = Color;

        Console.WriteLine(Item.ToString());
    }
}