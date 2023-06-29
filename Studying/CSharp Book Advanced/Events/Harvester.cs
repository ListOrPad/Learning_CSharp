public class Harvester
{
    int harvestCount;
    public void OnHarvest(CharberryTree harvestedTree)
    {
        if (harvestedTree.Ripe == true)
        {
            harvestedTree.Ripe = false;
            harvestCount++;
            Console.WriteLine($"The tree has been harvested {harvestCount} times");
        }
    }
    public Harvester(CharberryTree tree)
    {
        tree.Ripened += OnHarvest;
    }
}