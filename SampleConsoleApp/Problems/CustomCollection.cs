namespace SampleConsoleApp.Problems;

public class CustomCollection
{
    private int[] items;

    public int this[int index]
    {
        get
        {
            return items[index];
        }
        set
        {
            items[index] = value;
        }
    }

    public CustomCollection(int size)
    {
        items = new int[size];
    }
}
