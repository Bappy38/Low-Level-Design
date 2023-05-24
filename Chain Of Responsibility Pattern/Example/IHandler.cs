namespace Chain_Of_Responsibility_Pattern.Example;

/// <summary>
/// The handler interface declares a method for building the chain of
/// handlers. It also declares a method for executing a request.
/// </summary>

public interface IHandler
{
    IHandler SetNext(IHandler handler);

    object Handle(object request);
}
