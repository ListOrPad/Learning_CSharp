public class ColoredItem<T>
{
    public ConsoleColor Color { get; }
    public T? Item { get; set; }

    public ColoredItem(ConsoleColor color, T item)
    {
        Item = item;
        Color = color;
    }

    //blue sword, green bow, red axe
    public virtual void Display()
    {
        Console.ForegroundColor = Color;
        Console.WriteLine(Item);
    }

}