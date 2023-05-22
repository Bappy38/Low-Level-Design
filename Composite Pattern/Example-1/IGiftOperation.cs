namespace Composite_Pattern.Example_1;

/// <summary>
/// In many example, we can see additional operations like add and remove
/// inside the abstract Component class. But, we didn't do that as our
/// leaf class doesn't need that operations.
/// 
/// Instead, we add those operations in this interface. Only our Composite
/// object will implement this interface, but the Leaf object won't.
/// </summary>
public interface IGiftOperation
{
    void Add(GiftBase gift);
    void Remove(GiftBase gift);
}
