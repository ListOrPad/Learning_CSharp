public class Pack
{
    public InventoryItem[] items;
    public int MaxItems { get; }
    public float MaxWeight { get; }
    public float MaxVolume { get; }

    public int CurrentItemsCount { get; set; }
    public float CurrentWeight { get; set; }
    public float CurrentVolume { get; set;  }

    public Pack(int _maxItems, float _maxWeight, float _maxVolume)
    {
        MaxItems = _maxItems;
        MaxWeight = _maxWeight;
        MaxVolume = _maxVolume;

        CurrentItemsCount = 0;
        CurrentWeight = 0;
        CurrentVolume = 0;

        items = new InventoryItem[MaxItems];
    }

    public bool Add(InventoryItem item)
    {

        items[CurrentItemsCount] = item;


        CurrentItemsCount++;
        //sum all the weights and volumes of all the items in an array
        CurrentWeight += items[CurrentItemsCount - 1].Weight;
        CurrentVolume += items[CurrentItemsCount - 1].Volume;

        if (CurrentItemsCount > MaxItems || CurrentWeight > MaxWeight || CurrentVolume > MaxVolume)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

}