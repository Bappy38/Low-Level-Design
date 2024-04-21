namespace Composite_Pattern.Example_2;

public interface IStorageOperation
{
    void Add(StorageBase storage);
    void Remove(StorageBase storage);
}
