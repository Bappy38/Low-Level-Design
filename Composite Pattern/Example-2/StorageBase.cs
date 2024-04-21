namespace Composite_Pattern.Example_2;

public abstract class StorageBase
{
    protected string name;
    protected double size;

    protected StorageBase(string name, double size)
    {
        this.name = name;
        this.size = size;
    }

    public abstract double CalculateSize();
}
