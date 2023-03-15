public class InventoryItem
{
    public float Weight { get; protected set; }
    public float Volume { get; protected set; }
    public InventoryItem(float _weight, float _volume)
    {
        Weight = _weight;
        Volume = _volume;
    }

}