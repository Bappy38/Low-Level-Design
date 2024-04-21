namespace Composite_Pattern.Example_2;

public class File : StorageBase
{
    public File(string name, double size) : base(name, size)
    {
    }

    public override double CalculateSize()
    {
        Console.WriteLine($"Size of file with name: {name} = {size}");
        return size;
    }
}
