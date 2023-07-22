namespace Adapter_Pattern.Example;

/// <summary>
/// The Target defines the domain specific interface used by the client code.
/// </summary>
public interface ITarget
{
    string GetRequest();
}
