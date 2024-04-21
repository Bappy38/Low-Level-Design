namespace Composite_Pattern.Example_2;

public class Folder : StorageBase, IStorageOperation
{
    private List<StorageBase> storages;

    public Folder(string name, double size) : base(name, size)
    {
        storages = new List<StorageBase>();
    }

    public void Add(StorageBase storage)
    {
        storages.Add(storage);
    }

    public void Remove(StorageBase storage)
    {
        storages.Remove(storage);
    }

    public override double CalculateSize()
    {
        var totalSize = 0.0;

        foreach (StorageBase storage in storages)
        {
            totalSize += storage.CalculateSize();
        }

        Console.WriteLine($"Total Size of Folder with name: {name} = {totalSize}");
        return totalSize;
    }
}
