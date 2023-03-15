public class Pack
{
    public InventoryItem[] items = new InventoryItem[42];
    private int MaxItems { get; }
    private float MaxWeight { get; }
    private float MaxVolume { get; }

    private int CurrentItemsCount { get; set; }
    private float CurrentWeight { get; set; }
    private float CurrentVolume { get; set;  }

    public Pack(int _maxItems, float _maxWeight, float _maxVolume)
    {
        MaxItems = _maxItems;
        MaxWeight = _maxWeight;
        MaxVolume = _maxVolume;

        CurrentItemsCount = 0;
        CurrentWeight = 0;
        CurrentVolume = 0;
    }

    public bool Add(InventoryItem item)
    {

        items[CurrentItemsCount] = item;

        //sum all the weights and volumes of all the items in an array
        for (int i = 0; i < CurrentItemsCount; i++)
        {
            CurrentWeight += items[CurrentItemsCount].Weight;
            CurrentVolume += items[CurrentItemsCount].Volume;
        }

        if (CurrentItemsCount > MaxItems || CurrentWeight > MaxWeight || CurrentVolume > MaxVolume)
        {
            return false;
        }
        else
        {
            CurrentItemsCount++;
            return true;
        }
    }

}